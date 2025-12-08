# Remaining Views Analysis

This document identifies SQL Views that remain in usage within the `xPort5` codebase following the `replace-views-with-linq` refactoring initiative.

## 1. PrintManager Views

The following views are still used in `xPort5/Order/Quotation/PrintManager.cs` and `xPort5/Order/SalesContract/PrintManager.cs`. These classes use `xPort5.EF6.SqlHelper` to execute direct SQL queries against these views for report generation.

*   `vwPrint_CompletedPriceList`
*   `vwPrint_PriceList`
*   `vwPriceDetailList`
*   `vwPrint_QuotationList`

**Reason for retention:**
Refactoring these `PrintManager` classes would require a more significant overhaul of the reporting infrastructure to use `ViewService` and potentially modify how the `xPort5.Controls.Reporting.RS.Viewer` consumes data. This was deemed out of scope for the current `replace-views-with-linq` change (see Phase 3.11.2 in `tasks.md`).

## 2. Factory ProductList View

*   `vwProductList`

**Status:**
While the UI in `xPort5/Factory/Product/ProductList.cs` has been refactored to use `ViewService.Default.GetProductList()`, the `BuildSqlQueryString()` method (or similar logic) was restored/maintained to support the `XR.Loader` which expects a valid SQL query string for its operations (possibly for printing or exporting). The view itself is still referenced in the database, but the primary data access for the list screen is now via LINQ.
*Note: The actual `vwProductList` view object in the database is still required if `XR.Loader` uses it directly via the generated SQL string.*

## 3. Analysis Views (Incomplete Refactoring)

During verification, it was found that the following views are still used because the corresponding `ViewService` methods are either missing or incomplete (missing required columns):

*   `vwShipmentHistory` (used in `xPort5/Order/Analysis/ShipmentHistory2.cs`)
    *   **Reason:** `ViewService.Default.GetShipmentHistory` exists but returns a subset of columns (15 columns) that does not match the requirements of the UI (which expects 15 columns, but different ones including `SupplierCode`, `PackageCode`, `SCNumber`, etc.).
*   `vwOSShipment` (used in `xPort5/Order/Analysis/OutstandingShipment.cs`)
    *   **Reason:** No corresponding `ViewService` method appears to exist for this specific view (or `GetShipmentHistory` was intended but is insufficient).

## 4. Other Views (Out of Scope)

*   `vwProductWithSupplierAndPackage` (used in `xPort5/Controls/Product/FindProduct.cs`)
    *   **Reason:** This view was not part of the original refactoring scope defined in `tasks.md`.

## 5. Other Findings

A search for `vw` in `.cs` files (excluding the above) yielded no other significant direct usages of SQL views for data retrieval in the refactored modules (`Order`, `Factory`, etc.). 

## Recommendations

*   **Future Phase:** A future "modernize reporting" phase should target the `PrintManager` classes and `vwPrint_*` views.
*   **Cleanup:** Confirm if `vwProductList` is strictly needed by `XR.Loader` or if `XR.Loader` can be adapted to accept a `DataTable` or `DataSet` directly, allowing for the eventual removal of `vwProductList`.
