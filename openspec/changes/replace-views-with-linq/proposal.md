# Change: Replace Database Views with LINQ Queries

## Why
The xPort5 application currently uses 15+ database Views for data retrieval across various order and product management screens. These Views create a dependency on database-level abstractions that:
- Limit flexibility in query optimization
- Make it harder to test and maintain data access logic
- Create coupling between the application and database schema
- Prevent leveraging EF6's query capabilities and type safety

Following the successful pattern established by `OlapService` (which replaced stored procedures with LINQ queries), we should replace these Views with LINQ queries in `xPort5.EF6` to improve maintainability, testability, and align with the migration strategy from DAL to EF6.

## What Changes
- **BREAKING**: Create a new `ViewService` class in `xPort5.EF6` similar to `OlapService`
- Replace direct SQL queries against Views with LINQ queries in `ViewService`
- Update all code that queries Views to use `ViewService` methods instead
- Maintain backward compatibility by returning `DataSet` objects (matching current usage patterns)
- Views identified for replacement (44+ Views):
  - **Order & Product Views (15)**: `vwProductList`, `vwCategoryList`, `vwInvoiceItemList`, `vwPreOrderItemList`, `vwOrderSPItemList`, `vwSalesContractItemList`, `vwOrderQTItemList`, `vwPurchaseContractItemList`, `vwOrderQTList`, `vwPreOrderList`, `vwSalesContractList`, `vwPurchaseContractList`, `vwInvoiceList`, `vwOSSample`, `vwOrderSPList`
  - **History Views (3)**: `vwQuoteHistory`, `vwPurchaseHistory`, `vwShipmentHistory`
  - **Master Data Views (9)**: `vwUserList`, `vwCityList`, `vwCustomerList`, `vwCustomerAddressList`, `vwCustomerContactList`, `vwSupplierList`, `vwSupplierAddressList`, `vwSupplierContactList`, `vwStaffList`, `vwStaffAddressList`
  - **Reporting Views (11)**: `vwRptSalesContractList`, `vwRptPurchaseContractList`, `vwRptInvoiceList`, `vwRptProformaInvoiceList`, `vwRptPriceList`, `vwRptPreOrderList`, `vwRptShipmentAdviseList`, `vwRptPurchaseContractShipmentList`, `vwRptSalesContractShipmentList`, `vwRptPreOrderList_CustShipment`, `vwRptPreOrderList_SuppShipment`, `vwRptInvoice_Charges`
  - **Print Views (4)**: `vwPrint_PriceList`, `vwPrint_CompletedPriceList`, `vwPriceDetailList`, `vwPrint_QuotationList`
  - **Bot Views (2)**: `vwClientList`, `vwClientUserList` (Note: These may be in a different database or missing from the script)

## Impact
- Affected specs: `data-access`
- Affected code:
  - `xPort5.EF6` - New `ViewService` class
  - `xPort5.Bot` - Uses `vwClientList` and `vwClientUserList`
  - **Order screens**: ProductList, InvoiceList, InvoiceItemList, QuotationList, QuotationItemList, PreOrderList, PreOrderItemList, SalesContractList, SalesContractItemList, PurchaseContractList, PurchaseContractItemList, SampleList, SampleItemList, SampleItemRecord
  - **Master data screens**: CustomerList, CustomerAddressList, CustomerContactList, SupplierList, SupplierAddressList, SupplierContactList, StaffList, StaffAddressList, UserList, CityList
  - **Analysis screens**: QuoteHistory, PurchaseHistory, ShipmentHistory
  - **Reporting**: `xPort5/Controls/Reporting/XR/DataSource.cs` - Uses multiple `vwRpt*` Views
  - **Print/Reports**: PrintManager classes and RDLC report files use `vwPrint_*` and `vwPriceDetailList` Views
  - **Utilities**: `xPort5/Controls/Utility.cs` - Uses `vwCategoryList`
