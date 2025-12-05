## 1. Phase 1: Create ViewService Infrastructure
- [x] 1.1 Create `ViewService.cs` class in `xPort5.EF6` project
- [x] 1.2 Implement singleton pattern with `Default` static property (similar to `OlapService`)
- [x] 1.3 Add `GetDbContext()` method for EF6 context access
- [x] 1.4 Add `ToDataSet<T>()` extension method if not already available (reuse from `OlapService` if possible)
- [x] 1.5 Create helper methods for common View patterns:
  - [x] 1.5.1 Date filtering helpers
  - [x] 1.5.2 String-based WHERE clause support (using `SqlToLinqConverter`)

## 2. Phase 2: Convert Views to LINQ Queries

### 2.1 Convert vwProductList
- [x] 2.1.1 Analyze View SQL structure and joins
- [x] 2.1.2 Create `GetProductList()` method in `ViewService`
- [x] 2.1.3 Implement LINQ query matching View logic
- [x] 2.1.4 Return `DataSet` for compatibility

### 2.2 Convert vwCategoryList
- [x] 2.2.1 Analyze View SQL structure
- [x] 2.2.2 Create `GetCategoryList()` method in `ViewService`
- [x] 2.2.3 Implement LINQ query
- [x] 2.2.4 Return `DataSet` for compatibility

### 2.3 Convert vwInvoiceList
- [x] 2.3.1 Analyze View SQL structure
- [x] 2.3.2 Create `GetInvoiceList()` method in `ViewService`
- [x] 2.3.3 Implement LINQ query
- [x] 2.3.4 Return `DataSet` for compatibility

### 2.4 Convert vwInvoiceItemList
- [x] 2.4.1 Analyze View SQL structure
- [x] 2.4.2 Create `GetInvoiceItemList()` method in `ViewService`
- [x] 2.4.3 Implement LINQ query
- [x] 2.4.4 Return `DataSet` for compatibility

### 2.5 Convert vwOrderQTList
- [x] 2.5.1 Analyze View SQL structure
- [x] 2.5.2 Create `GetQuotationList()` method in `ViewService`
- [x] 2.5.3 Implement LINQ query
- [x] 2.5.4 Return `DataSet` for compatibility

### 2.6 Fix Build Issues
- [x] 2.6.1 Resolve ViewService compilation errors <!-- id: 27 -->

### 2.6 Convert vwOrderQTItemList
- [x] 2.6.1 Analyze View SQL structure
- [x] 2.6.2 Create `GetQuotationItemList()` method in `ViewService`
- [x] 2.6.3 Implement LINQ query
- [x] 2.6.4 Return `DataSet` for compatibility

### 2.7 Convert vwPreOrderList
- [x] 2.7.1 Analyze View SQL structure
- [x] 2.7.2 Create `GetPreOrderList()` method in `ViewService`
- [x] 2.7.3 Implement LINQ query
- [x] 2.7.4 Return `DataSet` for compatibility

### 2.8 Convert vwPreOrderItemList
- [x] 2.8.1 Analyze View SQL structure
- [x] 2.8.2 Create `GetPreOrderItemList()` method in `ViewService`
- [x] 2.8.3 Implement LINQ query
- [x] 2.8.4 Return `DataSet` for compatibility

### 2.9 Convert vwSalesContractList
- [x] 2.9.1 Analyze View SQL structure
- [x] 2.9.2 Create `GetSalesContractList()` method in `ViewService`
- [x] 2.9.3 Implement LINQ query
- [x] 2.9.4 Return `DataSet` for compatibility

### 2.10 Convert vwSalesContractItemList
- [x] 2.10.1 Analyze View SQL structure
- [x] 2.10.2 Create `GetSalesContractItemList()` method in `ViewService`
- [x] 2.10.3 Implement LINQ query
- [x] 2.10.4 Return `DataSet` for compatibility

### 2.11 Convert vwPurchaseContractList
- [x] 2.11.1 Analyze View SQL structure
- [x] 2.11.2 Create `GetPurchaseContractList()` method in `ViewService`
- [x] 2.11.3 Implement LINQ query
- [x] 2.11.4 Return `DataSet` for compatibility

### 2.12 Convert vwPurchaseContractItemList
- [x] 2.12.1 Analyze View SQL structure
- [x] 2.12.2 Create `GetPurchaseContractItemList()` method in `ViewService`
- [x] 2.12.3 Implement LINQ query
- [x] 2.12.4 Return `DataSet` for compatibility

### 2.13 Convert vwOrderSPList
- [x] 2.13.1 Analyze View SQL structure
- [x] 2.13.2 Create `GetSampleList()` method in `ViewService`
- [x] 2.13.3 Implement LINQ query
- [x] 2.13.4 Return `DataSet` for compatibility

### 2.14 Convert vwOrderSPItemList
- [x] 2.14.1 Analyze View SQL structure
- [x] 2.14.2 Create `GetSampleItemList()` method in `ViewService`
- [x] 2.14.3 Implement LINQ query
- [x] 2.14.4 Return `DataSet` for compatibility

### 2.15 Convert vwOSSample
- [x] 2.15.1 Analyze View SQL structure
- [x] 2.15.2 Create `GetSampleItemRecord()` method in `ViewService`
- [x] 2.15.3 Implement LINQ query
- [x] 2.15.4 Return `DataSet` for compatibility

### 2.16 Convert History Views
- [x] 2.16.1 Convert `vwQuoteHistory` - Create `GetQuoteHistory()` method
- [x] 2.16.2 Convert `vwPurchaseHistory` - Create `GetPurchaseHistory()` method
- [x] 2.16.3 Convert `vwShipmentHistory` - Create `GetShipmentHistory()` method

### 2.17 Convert Master Data Views
- [x] 2.17.1 Convert `vwUserList` - Create `GetUserList()` method
- [x] 2.17.2 Convert `vwCityList` - Create `GetCityList()` method
- [x] 2.17.3 Convert `vwCustomerList` - Create `GetCustomerList()` method
- [x] 2.17.4 Convert `vwCustomerAddressList` - Create `GetCustomerAddressList()` method
- [x] 2.17.5 Convert `vwCustomerContactList` - Create `GetCustomerContactList()` method
- [x] 2.17.6 Convert `vwSupplierList` - Create `GetSupplierList()` method
- [x] 2.17.7 Convert `vwSupplierAddressList` - Create `GetSupplierAddressList()` method
- [x] 2.17.8 Convert `vwSupplierContactList` - Create `GetSupplierContactList()` method
- [x] 2.17.9 Convert `vwStaffList` - Create `GetStaffList()` method
- [x] 2.17.10 Convert `vwStaffAddressList` - Create `GetStaffAddressList()` method

### 2.18 Convert Reporting Views (vwRpt*)
- [x] 2.18.1 Convert `vwRptSalesContractList` - Create `GetRptSalesContractList()` method
- [x] 2.18.2 Convert `vwRptPurchaseContractList` - Create `GetRptPurchaseContractList()` method
- [x] 2.18.3 Convert `vwRptInvoiceList` - Create `GetRptInvoiceList()` method
- [x] 2.18.4 Convert `vwRptProformaInvoiceList` - Create `GetRptProformaInvoiceList()` method
- [x] 2.18.5 Convert `vwRptPriceList` - Create `GetRptPriceList()` method
- [x] 2.18.6 Convert `vwRptPreOrderList` - Create `GetRptPreOrderList()` method
- [x] 2.18.7 Convert `vwRptShipmentAdviseList` - Create `GetRptShipmentAdviseList()` method
- [x] 2.18.8 Convert `vwRptPurchaseContractShipmentList` - Create `GetRptPurchaseContractShipmentList()` method
- [x] 2.18.9 Convert `vwRptSalesContractShipmentList` - Create `GetRptSalesContractShipmentList()` method
- [x] 2.18.10 Convert `vwRptPreOrderList_CustShipment` - Create `GetRptPreOrderListCustShipment()` method
- [x] 2.18.11 Convert `vwRptPreOrderList_SuppShipment` - Create `GetRptPreOrderListSuppShipment()` method
- [x] 2.18.12 Convert `vwRptInvoice_Charges` - Create `GetRptInvoiceCharges()` method

### 2.19 Convert Print Views
- [x] 2.19.1 Convert `vwPrint_PriceList` - Create `GetPrintPriceList()` method
- [x] 2.19.2 Convert `vwPrint_CompletedPriceList` - Create `GetPrintCompletedPriceList()` method
- [x] 2.19.3 Convert `vwPriceDetailList` - Create `GetPriceDetailList()` method
- [x] 2.19.4 Convert `vwPrint_QuotationList` - Create `GetPrintQuotationList()` method

### 2.20 Convert Bot Views (if applicable)
- [x] 2.20.1 Investigate `vwClientList` - Determine if it exists in database or different schema
- [x] 2.20.2 Investigate `vwClientUserList` - Determine if it exists in database or different schema
- [x] 2.20.3 Convert `vwClientList` - Create `GetClientList()` method (if applicable)
- [x] 2.20.4 Convert `vwClientUserList` - Create `GetClientUserList()` method (if applicable)

## 3. Phase 3: Update Code to Use ViewService

### 3.1 Update ProductList screens
- [ ] 3.1.1 Update `xPort5/Order/Coding/Product/ProductList.cs`
- [ ] 3.1.2 Update `xPort5/Factory/Product/ProductList.cs` (if exists)
- [ ] 3.1.3 Replace SQL queries with `ViewService.Default.GetProductList()`

### 3.2 Update Invoice screens
- [ ] 3.2.1 Update `xPort5/Order/Invoice/InvoiceList.cs`
- [ ] 3.2.2 Update `xPort5/Order/Invoice/Items/ItemList.cs`
- [ ] 3.2.3 Replace SQL queries with `ViewService` methods

### 3.3 Update Quotation screens
- [ ] 3.3.1 Update `xPort5/Order/Quotation/QuotationList.cs`
- [ ] 3.3.2 Update `xPort5/Order/Quotation/Items/ItemList.cs`
- [ ] 3.3.3 Replace SQL queries with `ViewService` methods

### 3.4 Update PreOrder screens
- [ ] 3.4.1 Update `xPort5/Order/PreOrder/PreOrderList.cs`
- [ ] 3.4.2 Update `xPort5/Order/PreOrder/Items/ItemsList.cs`
- [ ] 3.4.3 Replace SQL queries with `ViewService` methods

### 3.5 Update SalesContract screens
- [ ] 3.5.1 Update `xPort5/Order/SalesContract/SalesContractList.cs`
- [ ] 3.5.2 Update `xPort5/Order/SalesContract/Items/ItemList.cs`
- [ ] 3.5.3 Replace SQL queries with `ViewService` methods

### 3.6 Update PurchaseContract screens
- [ ] 3.6.1 Update `xPort5/Order/PurchaseContract/PurchaseContractList.cs`
- [ ] 3.6.2 Update `xPort5/Order/PurchaseContract/Items/ItemsList.cs`
- [ ] 3.6.3 Replace SQL queries with `ViewService` methods

### 3.7 Update Sample screens
- [ ] 3.7.1 Update `xPort5/Order/Sample/SampleList.cs`
- [ ] 3.7.2 Update `xPort5/Order/Sample/Items/ItemList.cs`
- [ ] 3.7.3 Update `xPort5/Order/Sample/Items/ItemRecord.cs`
- [ ] 3.7.4 Replace SQL queries with `ViewService` methods

### 3.8 Update Utility methods
- [ ] 3.8.1 Update `xPort5/Controls/Utility.cs`
- [ ] 3.8.2 Replace `vwCategoryList` queries with `ViewService.Default.GetCategoryList()`

### 3.9 Update Master Data screens
- [ ] 3.9.1 Update CustomerList, CustomerAddressList, CustomerContactList screens
- [ ] 3.9.2 Update SupplierList, SupplierAddressList, SupplierContactList screens
- [ ] 3.9.3 Update StaffList, StaffAddressList screens
- [ ] 3.9.4 Update UserList screen
- [ ] 3.9.5 Update CityList screen

### 3.10 Update Analysis screens
- [ ] 3.10.1 Update QuoteHistory screen
- [ ] 3.10.2 Update PurchaseHistory screen
- [ ] 3.10.3 Update ShipmentHistory screens

### 3.11 Update Reporting code
- [ ] 3.11.1 Update `xPort5/Controls/Reporting/XR/DataSource.cs` to use ViewService methods for all `vwRpt*` Views
- [ ] 3.11.2 Update PrintManager classes to use ViewService methods for `vwPrint_*` Views

### 3.12 Update Bot code
- [ ] 3.12.1 Update `xPort5.Bot/Controllers/CloudDiskController.cs` to use ViewService for `vwClientList`
- [ ] 3.12.2 Update `xPort5.Bot/Helper/CloudDiskHelper.cs` to use ViewService for `vwClientUserList`

## 4. Phase 4: Testing and Validation
- [ ] 4.1 Test ProductList screens with new LINQ queries
- [ ] 4.2 Test Invoice screens with new LINQ queries
- [ ] 4.3 Test Quotation screens with new LINQ queries
- [ ] 4.4 Test PreOrder screens with new LINQ queries
- [ ] 4.5 Test SalesContract screens with new LINQ queries
- [ ] 4.6 Test PurchaseContract screens with new LINQ queries
- [ ] 4.7 Test Sample screens with new LINQ queries
- [ ] 4.8 Test Master Data screens (Customer, Supplier, Staff, User, City) with new LINQ queries
- [ ] 4.9 Test Analysis screens (QuoteHistory, PurchaseHistory, ShipmentHistory) with new LINQ queries
- [ ] 4.10 Test Reporting functionality with new LINQ queries
- [ ] 4.11 Test Print/Report generation with new LINQ queries
- [ ] 4.12 Test Bot functionality (if applicable)
- [ ] 4.13 Test category dropdown functionality
- [ ] 4.14 Verify data matches original View results for all Views
- [ ] 4.15 Performance testing - ensure LINQ queries perform acceptably

## 5. Phase 5: Cleanup
- [ ] 5.1 Remove unused View references from code
- [ ] 5.2 Document any Views that may still be needed for reporting or other purposes
- [ ] 5.3 Verify no other code references the replaced Views
- [ ] 5.4 Update documentation to reflect new LINQ-based approach
