namespace xPort5.Factory.Product.Report
{
    partial class ProductListXr
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.srpSupplier = new DevExpress.XtraReports.UI.XRSubreport();
            this.xrLine1 = new DevExpress.XtraReports.UI.XRLine();
            this.srpGeneral = new DevExpress.XtraReports.UI.XRSubreport();
            this.srpPacking = new DevExpress.XtraReports.UI.XRSubreport();
            this.PageHeader = new DevExpress.XtraReports.UI.PageHeaderBand();
            this.lblPicture = new DevExpress.XtraReports.UI.XRLabel();
            this.lblReportTitle = new DevExpress.XtraReports.UI.XRLabel();
            this.lblHeight = new DevExpress.XtraReports.UI.XRLabel();
            this.lblWidth = new DevExpress.XtraReports.UI.XRLabel();
            this.lblLength = new DevExpress.XtraReports.UI.XRLabel();
            this.lblCurrency = new DevExpress.XtraReports.UI.XRLabel();
            this.lblUnitCost = new DevExpress.XtraReports.UI.XRLabel();
            this.lblLCLCost = new DevExpress.XtraReports.UI.XRLabel();
            this.lblFCLCost = new DevExpress.XtraReports.UI.XRLabel();
            this.lblSuppRef = new DevExpress.XtraReports.UI.XRLabel();
            this.lblSupplier = new DevExpress.XtraReports.UI.XRLabel();
            this.lblContainer = new DevExpress.XtraReports.UI.XRLabel();
            this.lbltotalQty = new DevExpress.XtraReports.UI.XRLabel();
            this.lblCUFT = new DevExpress.XtraReports.UI.XRLabel();
            this.lblNet = new DevExpress.XtraReports.UI.XRLabel();
            this.lblOuterBox = new DevExpress.XtraReports.UI.XRLabel();
            this.lblGross = new DevExpress.XtraReports.UI.XRLabel();
            this.lblInnerBox = new DevExpress.XtraReports.UI.XRLabel();
            this.lblUnit = new DevExpress.XtraReports.UI.XRLabel();
            this.lblPacking = new DevExpress.XtraReports.UI.XRLabel();
            this.lblRemarks = new DevExpress.XtraReports.UI.XRLabel();
            this.lblOrigin = new DevExpress.XtraReports.UI.XRLabel();
            this.lblColor = new DevExpress.XtraReports.UI.XRLabel();
            this.lblCategory = new DevExpress.XtraReports.UI.XRLabel();
            this.lblBarcode = new DevExpress.XtraReports.UI.XRLabel();
            this.lblSKU = new DevExpress.XtraReports.UI.XRLabel();
            this.lblProductCode = new DevExpress.XtraReports.UI.XRLabel();
            this.lblDescription = new DevExpress.XtraReports.UI.XRLabel();
            this.pnlPageInfo = new DevExpress.XtraReports.UI.XRPanel();
            this.txtPrintedOn = new DevExpress.XtraReports.UI.XRPageInfo();
            this.txtPrintedBy = new DevExpress.XtraReports.UI.XRLabel();
            this.lblPrintedBy = new DevExpress.XtraReports.UI.XRLabel();
            this.phPageNumber = new DevExpress.XtraReports.UI.XRPageInfo();
            this.lblPage = new DevExpress.XtraReports.UI.XRLabel();
            this.lblPrintedOn = new DevExpress.XtraReports.UI.XRLabel();
            this.PageFooter = new DevExpress.XtraReports.UI.PageFooterBand();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.srpSupplier,
            this.xrLine1,
            this.srpGeneral,
            this.srpPacking});
            this.Detail.Height = 54;
            this.Detail.KeepTogether = true;
            this.Detail.Name = "Detail";
            this.Detail.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.Detail_BeforePrint);
            // 
            // srpSupplier
            // 
            this.srpSupplier.Location = new System.Drawing.Point(850, 4);
            this.srpSupplier.Name = "srpSupplier";
            this.srpSupplier.Size = new System.Drawing.Size(250, 50);
            // 
            // xrLine1
            // 
            this.xrLine1.ForeColor = System.Drawing.Color.Gainsboro;
            this.xrLine1.Location = new System.Drawing.Point(0, 0);
            this.xrLine1.Name = "xrLine1";
            this.xrLine1.ParentStyleUsing.UseForeColor = false;
            this.xrLine1.Size = new System.Drawing.Size(1100, 2);
            // 
            // srpGeneral
            // 
            this.srpGeneral.Location = new System.Drawing.Point(0, 4);
            this.srpGeneral.Name = "srpGeneral";
            this.srpGeneral.Size = new System.Drawing.Size(500, 50);
            // 
            // srpPacking
            // 
            this.srpPacking.Location = new System.Drawing.Point(500, 4);
            this.srpPacking.Name = "srpPacking";
            this.srpPacking.Size = new System.Drawing.Size(350, 50);
            // 
            // PageHeader
            // 
            this.PageHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.lblPicture,
            this.lblReportTitle,
            this.lblHeight,
            this.lblWidth,
            this.lblLength,
            this.lblCurrency,
            this.lblUnitCost,
            this.lblLCLCost,
            this.lblFCLCost,
            this.lblSuppRef,
            this.lblSupplier,
            this.lblContainer,
            this.lbltotalQty,
            this.lblCUFT,
            this.lblNet,
            this.lblOuterBox,
            this.lblGross,
            this.lblInnerBox,
            this.lblUnit,
            this.lblPacking,
            this.lblRemarks,
            this.lblOrigin,
            this.lblColor,
            this.lblCategory,
            this.lblBarcode,
            this.lblSKU,
            this.lblProductCode,
            this.lblDescription,
            this.pnlPageInfo});
            this.PageHeader.Name = "PageHeader";
            // 
            // lblPicture
            // 
            this.lblPicture.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.lblPicture.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
                        | DevExpress.XtraPrinting.BorderSide.Right)
                        | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.lblPicture.Font = new System.Drawing.Font("Arial Unicode MS", 7F);
            this.lblPicture.Location = new System.Drawing.Point(0, 33);
            this.lblPicture.Name = "lblPicture";
            this.lblPicture.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblPicture.ParentStyleUsing.UseBorderColor = false;
            this.lblPicture.ParentStyleUsing.UseBorders = false;
            this.lblPicture.ParentStyleUsing.UseFont = false;
            this.lblPicture.Size = new System.Drawing.Size(100, 67);
            this.lblPicture.Text = "Picture";
            this.lblPicture.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // lblReportTitle
            // 
            this.lblReportTitle.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F);
            this.lblReportTitle.Location = new System.Drawing.Point(0, 0);
            this.lblReportTitle.Name = "lblReportTitle";
            this.lblReportTitle.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblReportTitle.ParentStyleUsing.UseFont = false;
            this.lblReportTitle.Size = new System.Drawing.Size(300, 20);
            this.lblReportTitle.Text = "Product List (Waiting for Approval)";
            // 
            // lblHeight
            // 
            this.lblHeight.Font = new System.Drawing.Font("Arial Unicode MS", 7F);
            this.lblHeight.Location = new System.Drawing.Point(750, 67);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblHeight.ParentStyleUsing.UseFont = false;
            this.lblHeight.Size = new System.Drawing.Size(50, 14);
            this.lblHeight.Text = "Height";
            this.lblHeight.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // lblWidth
            // 
            this.lblWidth.Font = new System.Drawing.Font("Arial Unicode MS", 7F);
            this.lblWidth.Location = new System.Drawing.Point(700, 67);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblWidth.ParentStyleUsing.UseFont = false;
            this.lblWidth.Size = new System.Drawing.Size(50, 14);
            this.lblWidth.Text = "Width";
            this.lblWidth.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // lblLength
            // 
            this.lblLength.Font = new System.Drawing.Font("Arial Unicode MS", 7F);
            this.lblLength.Location = new System.Drawing.Point(650, 67);
            this.lblLength.Name = "lblLength";
            this.lblLength.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblLength.ParentStyleUsing.UseFont = false;
            this.lblLength.Size = new System.Drawing.Size(50, 14);
            this.lblLength.Text = "Length";
            this.lblLength.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // lblCurrency
            // 
            this.lblCurrency.Font = new System.Drawing.Font("Arial Unicode MS", 7F);
            this.lblCurrency.Location = new System.Drawing.Point(1050, 67);
            this.lblCurrency.Name = "lblCurrency";
            this.lblCurrency.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblCurrency.ParentStyleUsing.UseFont = false;
            this.lblCurrency.Size = new System.Drawing.Size(50, 14);
            this.lblCurrency.Text = "Currency";
            this.lblCurrency.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // lblUnitCost
            // 
            this.lblUnitCost.Font = new System.Drawing.Font("Arial Unicode MS", 7F);
            this.lblUnitCost.Location = new System.Drawing.Point(1000, 67);
            this.lblUnitCost.Name = "lblUnitCost";
            this.lblUnitCost.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblUnitCost.ParentStyleUsing.UseFont = false;
            this.lblUnitCost.Size = new System.Drawing.Size(50, 14);
            this.lblUnitCost.Text = "Unit Cost";
            this.lblUnitCost.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // lblLCLCost
            // 
            this.lblLCLCost.Font = new System.Drawing.Font("Arial Unicode MS", 7F);
            this.lblLCLCost.Location = new System.Drawing.Point(950, 67);
            this.lblLCLCost.Name = "lblLCLCost";
            this.lblLCLCost.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblLCLCost.ParentStyleUsing.UseFont = false;
            this.lblLCLCost.Size = new System.Drawing.Size(50, 14);
            this.lblLCLCost.Text = "LCL Cost";
            this.lblLCLCost.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // lblFCLCost
            // 
            this.lblFCLCost.Font = new System.Drawing.Font("Arial Unicode MS", 7F);
            this.lblFCLCost.Location = new System.Drawing.Point(900, 67);
            this.lblFCLCost.Name = "lblFCLCost";
            this.lblFCLCost.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblFCLCost.ParentStyleUsing.UseFont = false;
            this.lblFCLCost.Size = new System.Drawing.Size(50, 14);
            this.lblFCLCost.Text = "FCL Cost";
            this.lblFCLCost.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // lblSuppRef
            // 
            this.lblSuppRef.Font = new System.Drawing.Font("Arial Unicode MS", 7F);
            this.lblSuppRef.Location = new System.Drawing.Point(850, 67);
            this.lblSuppRef.Name = "lblSuppRef";
            this.lblSuppRef.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblSuppRef.ParentStyleUsing.UseFont = false;
            this.lblSuppRef.Size = new System.Drawing.Size(50, 14);
            this.lblSuppRef.Text = "Supp. Ref.";
            this.lblSuppRef.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // lblSupplier
            // 
            this.lblSupplier.Font = new System.Drawing.Font("Arial Unicode MS", 7F);
            this.lblSupplier.Location = new System.Drawing.Point(850, 50);
            this.lblSupplier.Name = "lblSupplier";
            this.lblSupplier.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblSupplier.ParentStyleUsing.UseFont = false;
            this.lblSupplier.Size = new System.Drawing.Size(250, 14);
            this.lblSupplier.Text = "Supplier";
            // 
            // lblContainer
            // 
            this.lblContainer.Font = new System.Drawing.Font("Arial Unicode MS", 7F);
            this.lblContainer.Location = new System.Drawing.Point(800, 83);
            this.lblContainer.Name = "lblContainer";
            this.lblContainer.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblContainer.ParentStyleUsing.UseFont = false;
            this.lblContainer.Size = new System.Drawing.Size(50, 14);
            this.lblContainer.Text = "Container";
            this.lblContainer.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // lbltotalQty
            // 
            this.lbltotalQty.Font = new System.Drawing.Font("Arial Unicode MS", 7F);
            this.lbltotalQty.Location = new System.Drawing.Point(750, 83);
            this.lbltotalQty.Name = "lbltotalQty";
            this.lbltotalQty.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lbltotalQty.ParentStyleUsing.UseFont = false;
            this.lbltotalQty.Size = new System.Drawing.Size(50, 14);
            this.lbltotalQty.Text = "Total Qty";
            this.lbltotalQty.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // lblCUFT
            // 
            this.lblCUFT.Font = new System.Drawing.Font("Arial Unicode MS", 7F);
            this.lblCUFT.Location = new System.Drawing.Point(800, 67);
            this.lblCUFT.Name = "lblCUFT";
            this.lblCUFT.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblCUFT.ParentStyleUsing.UseFont = false;
            this.lblCUFT.Size = new System.Drawing.Size(50, 14);
            this.lblCUFT.Text = "CUFT";
            this.lblCUFT.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // lblNet
            // 
            this.lblNet.Font = new System.Drawing.Font("Arial Unicode MS", 7F);
            this.lblNet.Location = new System.Drawing.Point(700, 83);
            this.lblNet.Name = "lblNet";
            this.lblNet.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblNet.ParentStyleUsing.UseFont = false;
            this.lblNet.Size = new System.Drawing.Size(50, 14);
            this.lblNet.Text = "Net";
            this.lblNet.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // lblOuterBox
            // 
            this.lblOuterBox.Font = new System.Drawing.Font("Arial Unicode MS", 7F);
            this.lblOuterBox.Location = new System.Drawing.Point(600, 67);
            this.lblOuterBox.Name = "lblOuterBox";
            this.lblOuterBox.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblOuterBox.ParentStyleUsing.UseFont = false;
            this.lblOuterBox.Size = new System.Drawing.Size(50, 14);
            this.lblOuterBox.Text = "Outer Box";
            this.lblOuterBox.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // lblGross
            // 
            this.lblGross.Font = new System.Drawing.Font("Arial Unicode MS", 7F);
            this.lblGross.Location = new System.Drawing.Point(650, 83);
            this.lblGross.Name = "lblGross";
            this.lblGross.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblGross.ParentStyleUsing.UseFont = false;
            this.lblGross.Size = new System.Drawing.Size(50, 14);
            this.lblGross.Text = "Gross";
            this.lblGross.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // lblInnerBox
            // 
            this.lblInnerBox.Font = new System.Drawing.Font("Arial Unicode MS", 7F);
            this.lblInnerBox.Location = new System.Drawing.Point(550, 67);
            this.lblInnerBox.Name = "lblInnerBox";
            this.lblInnerBox.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblInnerBox.ParentStyleUsing.UseFont = false;
            this.lblInnerBox.Size = new System.Drawing.Size(50, 14);
            this.lblInnerBox.Text = "Inner Box";
            this.lblInnerBox.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // lblUnit
            // 
            this.lblUnit.Font = new System.Drawing.Font("Arial Unicode MS", 7F);
            this.lblUnit.Location = new System.Drawing.Point(500, 67);
            this.lblUnit.Name = "lblUnit";
            this.lblUnit.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblUnit.ParentStyleUsing.UseFont = false;
            this.lblUnit.Size = new System.Drawing.Size(50, 14);
            this.lblUnit.Text = "Unit";
            this.lblUnit.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // lblPacking
            // 
            this.lblPacking.Font = new System.Drawing.Font("Arial Unicode MS", 7F);
            this.lblPacking.Location = new System.Drawing.Point(500, 50);
            this.lblPacking.Name = "lblPacking";
            this.lblPacking.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblPacking.ParentStyleUsing.UseFont = false;
            this.lblPacking.Size = new System.Drawing.Size(350, 14);
            this.lblPacking.Text = "Packing";
            // 
            // lblRemarks
            // 
            this.lblRemarks.Font = new System.Drawing.Font("Arial Unicode MS", 7F);
            this.lblRemarks.Location = new System.Drawing.Point(300, 83);
            this.lblRemarks.Name = "lblRemarks";
            this.lblRemarks.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblRemarks.ParentStyleUsing.UseFont = false;
            this.lblRemarks.Size = new System.Drawing.Size(200, 14);
            this.lblRemarks.Text = "Remarks";
            // 
            // lblOrigin
            // 
            this.lblOrigin.Font = new System.Drawing.Font("Arial Unicode MS", 7F);
            this.lblOrigin.Location = new System.Drawing.Point(300, 67);
            this.lblOrigin.Name = "lblOrigin";
            this.lblOrigin.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblOrigin.ParentStyleUsing.UseFont = false;
            this.lblOrigin.Size = new System.Drawing.Size(200, 14);
            this.lblOrigin.Text = "Origin";
            // 
            // lblColor
            // 
            this.lblColor.Font = new System.Drawing.Font("Arial Unicode MS", 7F);
            this.lblColor.Location = new System.Drawing.Point(100, 67);
            this.lblColor.Name = "lblColor";
            this.lblColor.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblColor.ParentStyleUsing.UseFont = false;
            this.lblColor.Size = new System.Drawing.Size(200, 14);
            this.lblColor.Text = "Color";
            // 
            // lblCategory
            // 
            this.lblCategory.Font = new System.Drawing.Font("Arial Unicode MS", 7F);
            this.lblCategory.Location = new System.Drawing.Point(300, 50);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblCategory.ParentStyleUsing.UseFont = false;
            this.lblCategory.Size = new System.Drawing.Size(200, 14);
            this.lblCategory.Text = "Category";
            // 
            // lblBarcode
            // 
            this.lblBarcode.Font = new System.Drawing.Font("Arial Unicode MS", 7F);
            this.lblBarcode.Location = new System.Drawing.Point(300, 33);
            this.lblBarcode.Name = "lblBarcode";
            this.lblBarcode.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblBarcode.ParentStyleUsing.UseFont = false;
            this.lblBarcode.Size = new System.Drawing.Size(200, 14);
            this.lblBarcode.Text = "Barcode";
            // 
            // lblSKU
            // 
            this.lblSKU.Font = new System.Drawing.Font("Arial Unicode MS", 7F);
            this.lblSKU.Location = new System.Drawing.Point(100, 33);
            this.lblSKU.Name = "lblSKU";
            this.lblSKU.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblSKU.ParentStyleUsing.UseFont = false;
            this.lblSKU.Size = new System.Drawing.Size(200, 14);
            this.lblSKU.Text = "SKU";
            // 
            // lblProductCode
            // 
            this.lblProductCode.Font = new System.Drawing.Font("Arial Unicode MS", 7F);
            this.lblProductCode.Location = new System.Drawing.Point(100, 50);
            this.lblProductCode.Name = "lblProductCode";
            this.lblProductCode.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblProductCode.ParentStyleUsing.UseFont = false;
            this.lblProductCode.Size = new System.Drawing.Size(200, 14);
            this.lblProductCode.Text = "Product Code";
            // 
            // lblDescription
            // 
            this.lblDescription.Font = new System.Drawing.Font("Arial Unicode MS", 7F);
            this.lblDescription.Location = new System.Drawing.Point(100, 83);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblDescription.ParentStyleUsing.UseFont = false;
            this.lblDescription.Size = new System.Drawing.Size(200, 14);
            this.lblDescription.Text = "Description";
            // 
            // pnlPageInfo
            // 
            this.pnlPageInfo.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.txtPrintedOn,
            this.txtPrintedBy,
            this.lblPrintedBy,
            this.phPageNumber,
            this.lblPage,
            this.lblPrintedOn});
            this.pnlPageInfo.Location = new System.Drawing.Point(958, 0);
            this.pnlPageInfo.Name = "pnlPageInfo";
            this.pnlPageInfo.Size = new System.Drawing.Size(142, 47);
            // 
            // txtPrintedOn
            // 
            this.txtPrintedOn.Font = new System.Drawing.Font("Arial Unicode MS", 7F);
            this.txtPrintedOn.Format = "{0:yyyy-MM-dd HH:mm}";
            this.txtPrintedOn.Location = new System.Drawing.Point(58, 0);
            this.txtPrintedOn.Name = "txtPrintedOn";
            this.txtPrintedOn.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.txtPrintedOn.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime;
            this.txtPrintedOn.ParentStyleUsing.UseFont = false;
            this.txtPrintedOn.Size = new System.Drawing.Size(84, 14);
            // 
            // txtPrintedBy
            // 
            this.txtPrintedBy.Font = new System.Drawing.Font("Arial Unicode MS", 7F);
            this.txtPrintedBy.Location = new System.Drawing.Point(58, 16);
            this.txtPrintedBy.Name = "txtPrintedBy";
            this.txtPrintedBy.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.txtPrintedBy.ParentStyleUsing.UseFont = false;
            this.txtPrintedBy.Size = new System.Drawing.Size(84, 14);
            this.txtPrintedBy.Text = "txtPrintedBy";
            // 
            // lblPrintedBy
            // 
            this.lblPrintedBy.Font = new System.Drawing.Font("Arial Unicode MS", 7F);
            this.lblPrintedBy.Location = new System.Drawing.Point(0, 16);
            this.lblPrintedBy.Name = "lblPrintedBy";
            this.lblPrintedBy.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblPrintedBy.ParentStyleUsing.UseFont = false;
            this.lblPrintedBy.Size = new System.Drawing.Size(57, 14);
            this.lblPrintedBy.Text = "Printed By:";
            // 
            // phPageNumber
            // 
            this.phPageNumber.Font = new System.Drawing.Font("Arial Unicode MS", 7F);
            this.phPageNumber.Location = new System.Drawing.Point(58, 31);
            this.phPageNumber.Name = "phPageNumber";
            this.phPageNumber.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.phPageNumber.ParentStyleUsing.UseFont = false;
            this.phPageNumber.Size = new System.Drawing.Size(84, 14);
            // 
            // lblPage
            // 
            this.lblPage.Font = new System.Drawing.Font("Arial Unicode MS", 7F);
            this.lblPage.Location = new System.Drawing.Point(0, 31);
            this.lblPage.Name = "lblPage";
            this.lblPage.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblPage.ParentStyleUsing.UseFont = false;
            this.lblPage.Size = new System.Drawing.Size(57, 14);
            this.lblPage.Text = "Page:";
            // 
            // lblPrintedOn
            // 
            this.lblPrintedOn.Font = new System.Drawing.Font("Arial Unicode MS", 7F);
            this.lblPrintedOn.Location = new System.Drawing.Point(0, 0);
            this.lblPrintedOn.Name = "lblPrintedOn";
            this.lblPrintedOn.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblPrintedOn.ParentStyleUsing.UseFont = false;
            this.lblPrintedOn.Size = new System.Drawing.Size(57, 14);
            this.lblPrintedOn.Text = "Printed On:";
            // 
            // PageFooter
            // 
            this.PageFooter.Height = 0;
            this.PageFooter.Name = "PageFooter";
            // 
            // ProductListXr
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.PageHeader,
            this.PageFooter});
            this.Landscape = true;
            this.Margins = new System.Drawing.Printing.Margins(25, 25, 25, 25);
            this.PageHeight = 827;
            this.PageWidth = 1169;
            this.PaperKind = System.Drawing.Printing.PaperKind.A4;
            this.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.ProductListXr_BeforePrint);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.PageHeaderBand PageHeader;
        private DevExpress.XtraReports.UI.PageFooterBand PageFooter;
        private DevExpress.XtraReports.UI.XRPanel pnlPageInfo;
        private DevExpress.XtraReports.UI.XRPageInfo phPageNumber;
        private DevExpress.XtraReports.UI.XRPageInfo txtPrintedOn;
        private DevExpress.XtraReports.UI.XRLabel lblPage;
        private DevExpress.XtraReports.UI.XRLabel lblPrintedOn;
        private DevExpress.XtraReports.UI.XRLabel lblPrintedBy;
        private DevExpress.XtraReports.UI.XRLabel txtPrintedBy;
        private DevExpress.XtraReports.UI.XRLabel lblRemarks;
        private DevExpress.XtraReports.UI.XRLabel lblOrigin;
        private DevExpress.XtraReports.UI.XRLabel lblColor;
        private DevExpress.XtraReports.UI.XRLabel lblCategory;
        private DevExpress.XtraReports.UI.XRLabel lblBarcode;
        private DevExpress.XtraReports.UI.XRLabel lblSKU;
        private DevExpress.XtraReports.UI.XRLabel lblProductCode;
        private DevExpress.XtraReports.UI.XRLabel lblDescription;
        private DevExpress.XtraReports.UI.XRLabel lblCUFT;
        private DevExpress.XtraReports.UI.XRLabel lblNet;
        private DevExpress.XtraReports.UI.XRLabel lblOuterBox;
        private DevExpress.XtraReports.UI.XRLabel lblGross;
        private DevExpress.XtraReports.UI.XRLabel lblInnerBox;
        private DevExpress.XtraReports.UI.XRLabel lblUnit;
        private DevExpress.XtraReports.UI.XRLabel lblPacking;
        private DevExpress.XtraReports.UI.XRLabel lblCurrency;
        private DevExpress.XtraReports.UI.XRLabel lblUnitCost;
        private DevExpress.XtraReports.UI.XRLabel lblLCLCost;
        private DevExpress.XtraReports.UI.XRLabel lblFCLCost;
        private DevExpress.XtraReports.UI.XRLabel lblSuppRef;
        private DevExpress.XtraReports.UI.XRLabel lblSupplier;
        private DevExpress.XtraReports.UI.XRLabel lblContainer;
        private DevExpress.XtraReports.UI.XRLabel lbltotalQty;
        private DevExpress.XtraReports.UI.XRLabel lblHeight;
        private DevExpress.XtraReports.UI.XRLabel lblWidth;
        private DevExpress.XtraReports.UI.XRLabel lblLength;
        private DevExpress.XtraReports.UI.XRLabel lblReportTitle;
        private DevExpress.XtraReports.UI.XRLabel lblPicture;
        private DevExpress.XtraReports.UI.XRSubreport srpPacking;
        private DevExpress.XtraReports.UI.XRSubreport srpGeneral;
        private DevExpress.XtraReports.UI.XRLine xrLine1;
        private DevExpress.XtraReports.UI.XRSubreport srpSupplier;
    }
}
