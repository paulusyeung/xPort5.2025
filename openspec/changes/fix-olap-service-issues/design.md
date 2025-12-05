# Design: Fix OLAP Service Critical Issues

## Context

The `OlapService` implementation successfully converted stored procedures to LINQ, but code review identified critical gaps that must be addressed. This design document outlines technical decisions for fixing currency conversion, optimizing performance, and improving code quality.

## Goals / Non-Goals

### Goals
- Implement complete currency conversion logic using T_Currency table
- Optimize query performance by moving aggregation to database
- Reduce memory usage by avoiding premature materialization
- Improve code maintainability through helper method extraction
- Ensure production readiness with proper error handling

### Non-Goals
- Changing API contracts or method signatures
- Modifying ASPX page code (all changes are internal to service)
- Changing data structures or column names
- Implementing new features beyond fixing identified issues

## Decisions

### Decision 1: Currency Conversion Implementation

**What**: Implement `GetExchangeRate` and `ConvertCurrency` methods using EF6 DbContext to query `T_Currency` table.

**Why**: 
- Current implementation has TODO placeholders that return incorrect values
- Multi-currency reports require accurate conversion
- T_Currency table contains `XchgRate` property with exchange rates

**Implementation**:
```csharp
public decimal GetExchangeRate(Guid? fromCurrencyId, Guid? toCurrencyId, xPort5Entities context)
{
    if (fromCurrencyId == toCurrencyId || !fromCurrencyId.HasValue || !toCurrencyId.HasValue)
        return 1.0m;
    
    // Lookup exchange rate from T_Currency
    var fromCurrency = context.T_Currency.FirstOrDefault(c => c.CurrencyId == fromCurrencyId.Value);
    var toCurrency = context.T_Currency.FirstOrDefault(c => c.CurrencyId == toCurrencyId.Value);
    
    if (fromCurrency == null || toCurrency == null)
        return 1.0m; // Fallback to 1.0 if currency not found
    
    // Exchange rates are stored relative to base currency (HKD)
    // To convert from A to B: amount * (B.XchgRate / A.XchgRate)
    return toCurrency.XchgRate / fromCurrency.XchgRate;
}
```

**Alternatives Considered**:
- Caching exchange rates in memory: Rejected for initial implementation (can be added later if performance issue)
- Throwing exceptions for missing currencies: Rejected in favor of graceful fallback (1.0 rate)

### Decision 2: Server-Side Aggregation Pattern

**What**: Refactor all query methods to perform aggregation (Sum, GroupBy) in the database before calling `.ToList()`.

**Why**:
- Current implementation materializes entire result sets before aggregation
- For large datasets, this causes high memory usage and poor performance
- Database engines are optimized for aggregation operations

**Pattern**:
```csharp
// BEFORE (current - inefficient):
var results = query.ToList(); // Materializes all rows
var grouped = results.GroupBy(...).Select(...); // Aggregation in memory

// AFTER (optimized):
var grouped = query
    .GroupBy(...)  // Aggregation in SQL
    .Select(...)   // Projection in SQL
    .ToList();     // Materialize only aggregated results
```

**Limitation**: Month-column pivoting (Amt1-12) must remain in memory because it requires conditional logic that's difficult to express in SQL. This is acceptable as the pivot operates on already-aggregated data.

**Alternatives Considered**:
- Using SQL Server PIVOT operator: Rejected - EF6 doesn't support dynamic pivoting well, and month columns are fixed
- Materializing then pivoting: Current approach - acceptable for aggregated data

### Decision 3: Month Key Generation Helper

**What**: Extract repeated "last 12 months" logic into `GetLast12MonthKeys(DateTime referenceDate)` helper method.

**Why**:
- Logic is duplicated in 5 methods
- Reduces maintenance burden
- Ensures consistent month key generation

**Implementation**:
```csharp
private List<string> GetLast12MonthKeys(DateTime referenceDate)
{
    var month = new DateTime(referenceDate.Year, referenceDate.Month, 1);
    var monthStrings = new List<string>();
    for (int i = 11; i >= 0; i--)
    {
        monthStrings.Add(month.AddMonths(-i).ToString("yyyy-MM"));
    }
    return monthStrings;
}
```

**Note**: `GetShipmentSummary` uses a different month range (current + 1 through + 11), so it needs a separate helper or parameter.

**Alternatives Considered**:
- Inline logic: Rejected - too much duplication
- Single helper with parameters: Accepted - more flexible

### Decision 4: ToDataSet Empty Schema Handling

**What**: Improve `ToDataSet` to generate DataTable schema even when result set is empty.

**Why**:
- Empty result sets currently return DataTable with no columns
- DevExpress PivotGrid may fail to bind if expected columns are missing
- Schema should be predictable regardless of data presence

**Implementation**:
- Add overload accepting `Type` parameter for explicit schema
- Generate columns from type properties even when list is empty
- Maintain backward compatibility with existing overload

**Alternatives Considered**:
- Always require type parameter: Rejected - breaks existing code
- Generate schema from first item only: Current approach - acceptable with type overload

## Risks / Trade-offs

### Risk 1: Currency Conversion Performance
**Risk**: Looking up exchange rates for each row could cause N+1 query problem.

**Mitigation**: 
- Exchange rates are already joined in most queries (see `GetInvoiceSummary` line 328, 351)
- If `ConvertCurrency` is called per-row, consider caching or batch lookup
- Profile and optimize if performance issue appears

### Risk 2: Aggregation Complexity
**Risk**: Some aggregations may be complex to express in LINQ-to-Entities.

**Mitigation**:
- Test each refactored method thoroughly
- Compare SQL generated by EF6 with stored procedure SQL
- Fall back to in-memory aggregation if LINQ-to-Entities limitations encountered

### Risk 3: Breaking Changes
**Risk**: Refactoring could introduce subtle bugs that change results.

**Mitigation**:
- Comprehensive testing comparing results with stored procedures
- Row-by-row validation of calculated amounts
- Gradual rollout with monitoring

### Trade-off: Memory vs. Query Complexity
**Trade-off**: Server-side aggregation reduces memory but may increase query complexity.

**Decision**: Accept increased query complexity for significant memory savings and better scalability.

## Migration Plan

1. **Implement currency conversion** (low risk, high value)
2. **Profile and optimize one method at a time** (reduces risk)
3. **Extract helpers** (low risk, improves maintainability)
4. **Comprehensive testing** before deployment

## Open Questions

1. **Q**: Is `ConvertCurrency` method actually used, or are conversions done inline in queries?
   **A**: Need to verify by searching codebase. If unused, may not need implementation.

2. **Q**: Should exchange rates be cached in memory for performance?
   **A**: Defer decision until profiling shows performance issue. Rates change infrequently.

3. **Q**: What is the maximum expected dataset size for performance testing?
   **A**: Need to determine from production data or ask stakeholders.
