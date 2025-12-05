## MODIFIED Requirements

### Requirement: Data Access Layer Query Methods
The data access layer SHALL provide methods to retrieve complex data sets using LINQ queries instead of database Views.

#### Scenario: Product list retrieval
- **WHEN** the application needs to display a product list with category, origin, age grading, and color information
- **THEN** `ViewService.Default.GetProductList()` SHALL return a DataSet containing product data with all related lookup information joined from Article, T_Category, T_Origin, T_AgeGrading, T_Color, and Staff tables

#### Scenario: Category list retrieval
- **WHEN** the application needs to populate category dropdowns with department, class, and category information
- **THEN** `ViewService.Default.GetCategoryList()` SHALL return a DataSet containing category data with all related lookup information joined from T_Dept, T_Class, and T_Category tables

#### Scenario: Invoice list retrieval
- **WHEN** the application needs to display invoice lists with customer and order information
- **THEN** `ViewService.Default.GetInvoiceList()` SHALL return a DataSet containing invoice data with all related customer and order information joined from OrderIN, Customer, and related tables

#### Scenario: Invoice item list retrieval
- **WHEN** the application needs to display invoice items with article, package, supplier, and pricing information
- **THEN** `ViewService.Default.GetInvoiceItemList()` SHALL return a DataSet containing invoice item data with all related information joined from OrderINItems, Article, T_Package, Supplier, ArticleSupplier, OrderQTItems, and related tables

#### Scenario: Quotation list retrieval
- **WHEN** the application needs to display quotation lists with customer and order information
- **THEN** `ViewService.Default.GetQuotationList()` SHALL return a DataSet containing quotation data with all related customer and order information joined from OrderQT, Customer, and related tables

#### Scenario: Quotation item list retrieval
- **WHEN** the application needs to display quotation items with article, package, supplier, and pricing information
- **THEN** `ViewService.Default.GetQuotationItemList()` SHALL return a DataSet containing quotation item data with all related information joined from OrderQTItems, Article, T_Package, Supplier, ArticleSupplier, and related tables

#### Scenario: PreOrder list retrieval
- **WHEN** the application needs to display pre-order lists with customer and order information
- **THEN** `ViewService.Default.GetPreOrderList()` SHALL return a DataSet containing pre-order data with all related customer and order information joined from OrderPL, Customer, and related tables

#### Scenario: PreOrder item list retrieval
- **WHEN** the application needs to display pre-order items with article, package, supplier, and pricing information
- **THEN** `ViewService.Default.GetPreOrderItemList()` SHALL return a DataSet containing pre-order item data with all related information joined from OrderPLItems, Article, T_Package, Supplier, ArticleSupplier, OrderQTItems, and related tables

#### Scenario: Sales contract list retrieval
- **WHEN** the application needs to display sales contract lists with customer and order information
- **THEN** `ViewService.Default.GetSalesContractList()` SHALL return a DataSet containing sales contract data with all related customer and order information joined from OrderSC, Customer, and related tables

#### Scenario: Sales contract item list retrieval
- **WHEN** the application needs to display sales contract items with article, package, supplier, and pricing information
- **THEN** `ViewService.Default.GetSalesContractItemList()` SHALL return a DataSet containing sales contract item data with all related information joined from OrderSCItems, Article, T_Package, Supplier, ArticleSupplier, OrderQTItems, and related tables

#### Scenario: Purchase contract list retrieval
- **WHEN** the application needs to display purchase contract lists with supplier and order information
- **THEN** `ViewService.Default.GetPurchaseContractList()` SHALL return a DataSet containing purchase contract data with all related supplier and order information joined from OrderPC, Supplier, and related tables

#### Scenario: Purchase contract item list retrieval
- **WHEN** the application needs to display purchase contract items with article, package, supplier, and pricing information
- **THEN** `ViewService.Default.GetPurchaseContractItemList()` SHALL return a DataSet containing purchase contract item data with all related information joined from OrderPCItems, Article, T_Package, Supplier, ArticleSupplier, OrderQTItems, and related tables

#### Scenario: Sample list retrieval
- **WHEN** the application needs to display sample lists with customer and order information
- **THEN** `ViewService.Default.GetSampleList()` SHALL return a DataSet containing sample data with all related customer and order information joined from OrderSP, Customer, and related tables

#### Scenario: Sample item list retrieval
- **WHEN** the application needs to display sample items with article, package, supplier, and pricing information
- **THEN** `ViewService.Default.GetSampleItemList()` SHALL return a DataSet containing sample item data with all related information joined from OrderSPItems, Article, T_Package, Supplier, ArticleSupplier, OrderQTItems, and related tables

#### Scenario: Sample item record retrieval
- **WHEN** the application needs to display a detailed sample item record with all related information
- **THEN** `ViewService.Default.GetSampleItemRecord()` SHALL return a DataSet containing sample item record data with all related information joined from OrderSPItems, Article, T_Package, Supplier, ArticleSupplier, OrderQTItems, and related tables

#### Scenario: History data retrieval
- **WHEN** the application needs to display quote, purchase, or shipment history
- **THEN** `ViewService.Default.GetQuoteHistory()`, `GetPurchaseHistory()`, and `GetShipmentHistory()` SHALL return DataSets containing historical order data with all related information joined from OrderQTItems, OrderPCItems, OrderQTCustShipping, and related tables

#### Scenario: Master data list retrieval
- **WHEN** the application needs to display customer, supplier, staff, user, or city lists with related lookup information
- **THEN** `ViewService.Default.GetCustomerList()`, `GetSupplierList()`, `GetStaffList()`, `GetUserList()`, `GetCityList()`, and related address/contact list methods SHALL return DataSets containing master data with all related lookup information joined from base tables and lookup tables

#### Scenario: Reporting data retrieval
- **WHEN** the application needs to generate reports for sales contracts, purchase contracts, invoices, pre-orders, or shipments
- **THEN** `ViewService.Default.GetRptSalesContractList()`, `GetRptPurchaseContractList()`, `GetRptInvoiceList()`, `GetRptPreOrderList()`, and related reporting methods SHALL return DataSets containing report data with all related information formatted for reporting

#### Scenario: Print data retrieval
- **WHEN** the application needs to generate print-ready documents such as price lists, quotations, or completed price lists
- **THEN** `ViewService.Default.GetPrintPriceList()`, `GetPrintQuotationList()`, `GetPrintCompletedPriceList()`, and `GetPriceDetailList()` SHALL return DataSets containing print-formatted data with all related information

#### Scenario: Bot client data retrieval
- **WHEN** xPort5.Bot needs to retrieve client or client user information
- **THEN** `ViewService.Default.GetClientList()` and `GetClientUserList()` SHALL return DataSets containing client data (if applicable, depending on database schema)

## ADDED Requirements

### Requirement: ViewService Class
The system SHALL provide a `ViewService` class in `xPort5.EF6` that encapsulates LINQ queries replacing database Views.

#### Scenario: ViewService singleton access
- **WHEN** code needs to access ViewService methods
- **THEN** `ViewService.Default` SHALL provide a singleton instance for convenient access

#### Scenario: ViewService DbContext access
- **WHEN** ViewService needs to access the database
- **THEN** `ViewService.GetDbContext()` SHALL return a new `xPort5Entities` DbContext instance

#### Scenario: ViewService DataSet compatibility
- **WHEN** ViewService methods return query results
- **THEN** results SHALL be returned as `DataSet` objects to maintain compatibility with existing code that expects DataSet format

#### Scenario: ViewService WHERE clause support
- **WHEN** ViewService methods need to filter results using string-based WHERE clauses
- **THEN** methods SHALL support optional WHERE clause parameters that are converted using `SqlToLinqConverter.ConvertWhereClause()` for backward compatibility
