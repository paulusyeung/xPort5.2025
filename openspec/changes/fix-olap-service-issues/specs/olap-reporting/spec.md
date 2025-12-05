## MODIFIED Requirements

### Requirement: OLAP Reporting Data Access
The system SHALL provide OLAP reporting functionality using LINQ queries instead of stored procedures.

#### Scenario: Invoice Summary Report
- **WHEN** the user requests an Invoice Summary report with customer filter
- **THEN** the system SHALL execute a LINQ query using EF6 DbContext
- **AND** the query SHALL filter invoices by customer IDs from the provided array
- **AND** the query SHALL calculate monthly amounts (BackLogAmt, Amt1-12, Total) based on invoice dates
- **AND** the query SHALL perform aggregation (Sum, GroupBy) in the database before materializing results
- **AND** the query SHALL return a DataSet matching the structure previously returned by `olap_InvoiceSummary` stored procedure
- **AND** the system SHALL NOT use stored procedures for this report

#### Scenario: Monthly Invoice Summary Report
- **WHEN** the user requests a Monthly Invoice Summary report with date range
- **THEN** the system SHALL execute a LINQ query filtering invoices by date range
- **AND** the query SHALL group results by month
- **AND** the query SHALL perform aggregation in the database before materializing results
- **AND** the query SHALL return a DataSet matching the structure previously returned by `olap_MonthlyInvoiceSummary` stored procedure
- **AND** the system SHALL NOT use stored procedures for this report

#### Scenario: Outstanding Order Summary Report
- **WHEN** the user requests an Outstanding Order Summary report
- **THEN** the system SHALL execute a LINQ query to retrieve outstanding orders
- **AND** the query SHALL filter by customer IDs from the provided array
- **AND** the query SHALL perform aggregation in the database before materializing results
- **AND** the query SHALL return a DataSet matching the structure previously returned by `olap_OSOrder` stored procedure
- **AND** the system SHALL NOT use stored procedures for this report

#### Scenario: Outstanding Profit Summary Report
- **WHEN** the user requests an Outstanding Profit Summary report
- **THEN** the system SHALL execute a LINQ query to calculate profit metrics
- **AND** the query SHALL filter by customer IDs from the provided array
- **AND** the query SHALL perform aggregation in the database before materializing results
- **AND** the query SHALL return a DataSet matching the structure previously returned by `olap_OSProfit` stored procedure
- **AND** the system SHALL NOT use stored procedures for this report

#### Scenario: Sales Contract Summary Report
- **WHEN** the user requests a Sales Contract Summary report with date range
- **THEN** the system SHALL execute a LINQ query filtering sales contracts by date range
- **AND** the query SHALL filter by customer IDs from the provided array
- **AND** the query SHALL perform aggregation in the database before materializing results
- **AND** the query SHALL return a DataSet matching the structure previously returned by `olap_SalesContract` stored procedure
- **AND** the system SHALL NOT use stored procedures for this report

#### Scenario: Sales Turnover Report
- **WHEN** the user requests a Sales Turnover report with date range
- **THEN** the system SHALL execute a LINQ query filtering sales by date range
- **AND** the query SHALL filter by customer IDs from the provided array
- **AND** the query SHALL perform aggregation in the database before materializing results
- **AND** the query SHALL return a DataSet matching the structure previously returned by `olap_SalesTurnover` stored procedure
- **AND** the system SHALL NOT use stored procedures for this report

#### Scenario: Shipment Summary Report
- **WHEN** the user requests a Shipment Summary report with currency filter
- **THEN** the system SHALL execute a LINQ query filtering shipments by currency code
- **AND** the query SHALL filter by customer IDs and date range from provided parameters
- **AND** the query SHALL perform aggregation in the database before materializing results
- **AND** the query SHALL return a DataSet matching the structure previously returned by `olap_ShipmentSummary` stored procedure
- **AND** the system SHALL NOT use stored procedures for this report

#### Scenario: Top 10 Suppliers Report
- **WHEN** the user requests a Top 10 Suppliers report with date range
- **THEN** the system SHALL execute a LINQ query ordering suppliers by purchase amount
- **AND** the query SHALL filter by supplier IDs and date range from provided parameters
- **AND** the query SHALL perform aggregation in the database before materializing results
- **AND** the query SHALL return the top 10 suppliers
- **AND** the query SHALL return a DataSet matching the structure previously returned by `olap_Top10Supplier` stored procedure
- **AND** the system SHALL NOT use stored procedures for this report

## MODIFIED Requirements

### Requirement: Currency Conversion
The system SHALL provide accurate currency conversion for multi-currency OLAP reports.

#### Scenario: Exchange rate lookup
- **WHEN** currency conversion is required
- **THEN** the system SHALL query the `T_Currency` table using EF6 DbContext
- **AND** the system SHALL retrieve exchange rates from the `XchgRate` property
- **AND** the system SHALL handle missing currency records gracefully (return 1.0 rate or throw appropriate error)

#### Scenario: Currency conversion calculation
- **WHEN** an amount needs to be converted from one currency to another
- **THEN** the system SHALL use the exchange rate from `T_Currency` table
- **AND** the system SHALL apply the conversion formula correctly
- **AND** the system SHALL return the same amount if source and target currencies are identical

## MODIFIED Requirements

### Requirement: OLAP Service Class
The system SHALL provide an `OlapService` class in the `xPort5.EF6` project to encapsulate OLAP query logic.

#### Scenario: Service instantiation
- **WHEN** application code needs to execute OLAP queries
- **THEN** the system SHALL provide `OlapService.Default` static property for singleton access
- **AND** the service SHALL use EF6 DbContext for database access
- **AND** the service SHALL create a new DbContext instance for each query operation

#### Scenario: DataSet conversion
- **WHEN** a LINQ query returns entity results
- **THEN** the system SHALL provide a method to convert LINQ results to DataSet format
- **AND** the DataSet structure SHALL match the structure previously returned by stored procedures
- **AND** column names and data types SHALL be preserved exactly
- **AND** the DataTable SHALL have proper schema even when result set is empty

#### Scenario: Parameter handling
- **WHEN** OLAP queries require customer ID arrays
- **THEN** the service SHALL parse comma-separated GUID strings into collections
- **AND** the service SHALL handle date range parameters (FromDate, ToDate)
- **AND** the service SHALL handle optional currency code filters

#### Scenario: Query performance
- **WHEN** OLAP queries are executed
- **THEN** the queries SHALL perform aggregation (Sum, GroupBy) in the database before materializing results
- **AND** the queries SHALL only materialize aggregated results, not raw line items
- **AND** query performance SHALL be within 10% of stored procedure performance

## MODIFIED Requirements

### Requirement: Backward Compatibility
The system SHALL maintain backward compatibility with existing OLAP reporting pages.

#### Scenario: Existing page code compatibility
- **WHEN** an OLAP reporting page calls the service
- **THEN** the page code SHALL continue to work with minimal changes
- **AND** the DataSet structure returned SHALL match stored procedure output exactly
- **AND** PivotGrid binding SHALL work without modification
- **AND** Excel export functionality SHALL continue to work
- **AND** DataTable column names SHALL match ASPX field expectations exactly

#### Scenario: Performance compatibility
- **WHEN** LINQ queries are executed
- **THEN** query performance SHALL be within 10% of stored procedure performance
- **AND** memory usage SHALL be acceptable for production datasets
- **AND** if performance degrades beyond 10%, optimizations SHALL be applied (compiled queries, eager loading, etc.)
