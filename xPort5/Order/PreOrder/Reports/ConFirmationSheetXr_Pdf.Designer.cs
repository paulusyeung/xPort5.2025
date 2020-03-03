namespace xPort5.Order.PreOrder.Reports
{
    partial class ConFirmationSheetXr_Pdf
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
            DevExpress.XtraPrinting.Shape.ShapeRectangle shapeRectangle4 = new DevExpress.XtraPrinting.Shape.ShapeRectangle();
            DevExpress.XtraPrinting.Shape.ShapeRectangle shapeRectangle3 = new DevExpress.XtraPrinting.Shape.ShapeRectangle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConFirmationSheetXr_Pdf));
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.PageHeader = new DevExpress.XtraReports.UI.PageHeaderBand();
            this.PageFooter = new DevExpress.XtraReports.UI.PageFooterBand();
            this.gh1 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.gh2 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.gf1 = new DevExpress.XtraReports.UI.GroupFooterBand();
            this.xrLabel6 = new DevExpress.XtraReports.UI.XRLabel();
            this.txtPLNumber = new DevExpress.XtraReports.UI.XRRichText();
            this.txtPLDate = new DevExpress.XtraReports.UI.XRRichText();
            this.xrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
            this.txtCustName = new DevExpress.XtraReports.UI.XRRichText();
            this.txtFax = new DevExpress.XtraReports.UI.XRRichText();
            this.txtCustAddr = new DevExpress.XtraReports.UI.XRRichText();
            this.txtPageInfo = new DevExpress.XtraReports.UI.XRPageInfo();
            this.xrShape2 = new DevExpress.XtraReports.UI.XRShape();
            this.txtTel = new DevExpress.XtraReports.UI.XRRichText();
            this.xrLabel5 = new DevExpress.XtraReports.UI.XRLabel();
            this.txtHeader = new DevExpress.XtraReports.UI.XRRichText();
            this.xrLabel15 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel17 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel19 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel20 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel21 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel22 = new DevExpress.XtraReports.UI.XRLabel();
            this.gh1Unit = new DevExpress.XtraReports.UI.XRLabel();
            this.gh1Currency1 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrShape1 = new DevExpress.XtraReports.UI.XRShape();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.lblYourRef = new DevExpress.XtraReports.UI.XRLabel();
            this.txtArticleCode = new DevExpress.XtraReports.UI.XRLabel();
            this.txtUnitPrice = new DevExpress.XtraReports.UI.XRLabel();
            this.txtQty = new DevExpress.XtraReports.UI.XRLabel();
            this.txtSuppName = new DevExpress.XtraReports.UI.XRRichText();
            this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
            ((System.ComponentModel.ISupportInitialize)(this.txtPLNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPLDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCustName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCustAddr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHeader)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSuppName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.txtSuppName,
            this.txtQty,
            this.txtUnitPrice,
            this.txtArticleCode,
            this.lblYourRef});
            this.Detail.Height = 23;
            this.Detail.KeepTogether = true;
            this.Detail.Name = "Detail";
            this.Detail.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.Detail_BeforePrint);
            // 
            // PageHeader
            // 
            this.PageHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.txtHeader});
            this.PageHeader.Name = "PageHeader";
            // 
            // PageFooter
            // 
            this.PageFooter.Height = 0;
            this.PageFooter.Name = "PageFooter";
            // 
            // gh1
            // 
            this.gh1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel1,
            this.gh1Currency1,
            this.gh1Unit,
            this.xrLabel22,
            this.xrLabel21,
            this.xrLabel20,
            this.xrLabel19,
            this.xrLabel17,
            this.xrLabel15,
            this.xrShape1});
            this.gh1.Height = 51;
            this.gh1.Name = "gh1";
            this.gh1.RepeatEveryPage = true;
            this.gh1.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.gh1_BeforePrint);
            // 
            // gh2
            // 
            this.gh2.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel5,
            this.txtTel,
            this.txtPageInfo,
            this.txtCustAddr,
            this.txtFax,
            this.txtCustName,
            this.xrLabel3,
            this.xrLabel4,
            this.txtPLDate,
            this.txtPLNumber,
            this.xrLabel6,
            this.xrShape2});
            this.gh2.Height = 159;
            this.gh2.Level = 1;
            this.gh2.Name = "gh2";
            this.gh2.RepeatEveryPage = true;
            this.gh2.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.gh2_BeforePrint);
            // 
            // gf1
            // 
            this.gf1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel2});
            this.gf1.Height = 34;
            this.gf1.Name = "gf1";
            // 
            // xrLabel6
            // 
            this.xrLabel6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel6.Location = new System.Drawing.Point(508, 108);
            this.xrLabel6.Name = "xrLabel6";
            this.xrLabel6.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel6.ParentStyleUsing.UseFont = false;
            this.xrLabel6.Size = new System.Drawing.Size(113, 21);
            this.xrLabel6.Text = "PAGE";
            // 
            // txtPLNumber
            // 
            this.txtPLNumber.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPLNumber.Location = new System.Drawing.Point(625, 42);
            this.txtPLNumber.Name = "txtPLNumber";
            this.txtPLNumber.ParentStyleUsing.UseFont = false;
            this.txtPLNumber.Size = new System.Drawing.Size(125, 20);
            // 
            // txtPLDate
            // 
            this.txtPLDate.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPLDate.Location = new System.Drawing.Point(625, 62);
            this.txtPLDate.Name = "txtPLDate";
            this.txtPLDate.ParentStyleUsing.UseFont = false;
            this.txtPLDate.Size = new System.Drawing.Size(125, 21);
            // 
            // xrLabel4
            // 
            this.xrLabel4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel4.Location = new System.Drawing.Point(508, 62);
            this.xrLabel4.Name = "xrLabel4";
            this.xrLabel4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel4.ParentStyleUsing.UseFont = false;
            this.xrLabel4.Size = new System.Drawing.Size(113, 21);
            this.xrLabel4.Text = "DATE";
            // 
            // xrLabel3
            // 
            this.xrLabel3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel3.Location = new System.Drawing.Point(508, 42);
            this.xrLabel3.Name = "xrLabel3";
            this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel3.ParentStyleUsing.UseFont = false;
            this.xrLabel3.Size = new System.Drawing.Size(113, 20);
            this.xrLabel3.Text = "OUR REF. NO.";
            // 
            // txtCustName
            // 
            this.txtCustName.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F);
            this.txtCustName.Location = new System.Drawing.Point(8, 33);
            this.txtCustName.Name = "txtCustName";
            this.txtCustName.ParentStyleUsing.UseFont = false;
            this.txtCustName.Size = new System.Drawing.Size(359, 21);
            // 
            // txtFax
            // 
            this.txtFax.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFax.Location = new System.Drawing.Point(8, 125);
            this.txtFax.Name = "txtFax";
            this.txtFax.ParentStyleUsing.UseFont = false;
            this.txtFax.Size = new System.Drawing.Size(175, 21);
            // 
            // txtCustAddr
            // 
            this.txtCustAddr.CanGrow = false;
            this.txtCustAddr.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F);
            this.txtCustAddr.Location = new System.Drawing.Point(8, 50);
            this.txtCustAddr.Name = "txtCustAddr";
            this.txtCustAddr.ParentStyleUsing.UseFont = false;
            this.txtCustAddr.Size = new System.Drawing.Size(359, 67);
            // 
            // txtPageInfo
            // 
            this.txtPageInfo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPageInfo.Location = new System.Drawing.Point(625, 108);
            this.txtPageInfo.Name = "txtPageInfo";
            this.txtPageInfo.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.txtPageInfo.ParentStyleUsing.UseFont = false;
            this.txtPageInfo.Size = new System.Drawing.Size(125, 21);
            // 
            // xrShape2
            // 
            this.xrShape2.Location = new System.Drawing.Point(0, 33);
            this.xrShape2.Name = "xrShape2";
            this.xrShape2.Shape = shapeRectangle4;
            this.xrShape2.Size = new System.Drawing.Size(380, 113);
            // 
            // txtTel
            // 
            this.txtTel.CanGrow = false;
            this.txtTel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTel.Location = new System.Drawing.Point(187, 125);
            this.txtTel.Name = "txtTel";
            this.txtTel.ParentStyleUsing.UseFont = false;
            this.txtTel.Size = new System.Drawing.Size(180, 21);
            // 
            // xrLabel5
            // 
            this.xrLabel5.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.xrLabel5.Location = new System.Drawing.Point(0, 0);
            this.xrLabel5.Name = "xrLabel5";
            this.xrLabel5.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel5.ParentStyleUsing.UseFont = false;
            this.xrLabel5.Size = new System.Drawing.Size(750, 33);
            this.xrLabel5.Text = "CONFORMATION SHEET";
            this.xrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // txtHeader
            // 
            this.txtHeader.Location = new System.Drawing.Point(0, 0);
            this.txtHeader.Name = "txtHeader";
            this.txtHeader.Size = new System.Drawing.Size(750, 100);
            this.txtHeader.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.txtHeader_BeforePrint);
            // 
            // xrLabel15
            // 
            this.xrLabel15.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel15.Location = new System.Drawing.Point(7, 8);
            this.xrLabel15.Name = "xrLabel15";
            this.xrLabel15.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel15.ParentStyleUsing.UseFont = false;
            this.xrLabel15.Size = new System.Drawing.Size(84, 20);
            this.xrLabel15.Text = "Your Ref.";
            // 
            // xrLabel17
            // 
            this.xrLabel17.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel17.Location = new System.Drawing.Point(176, 8);
            this.xrLabel17.Name = "xrLabel17";
            this.xrLabel17.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel17.ParentStyleUsing.UseFont = false;
            this.xrLabel17.Size = new System.Drawing.Size(208, 20);
            this.xrLabel17.Text = "Maker";
            // 
            // xrLabel19
            // 
            this.xrLabel19.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel19.Location = new System.Drawing.Point(508, 8);
            this.xrLabel19.Name = "xrLabel19";
            this.xrLabel19.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel19.ParentStyleUsing.UseFont = false;
            this.xrLabel19.Size = new System.Drawing.Size(41, 20);
            this.xrLabel19.Text = "Qty.";
            this.xrLabel19.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // xrLabel20
            // 
            this.xrLabel20.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel20.Location = new System.Drawing.Point(91, 8);
            this.xrLabel20.Name = "xrLabel20";
            this.xrLabel20.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel20.ParentStyleUsing.UseFont = false;
            this.xrLabel20.Size = new System.Drawing.Size(84, 20);
            this.xrLabel20.Text = "Item No.";
            // 
            // xrLabel21
            // 
            this.xrLabel21.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel21.Location = new System.Drawing.Point(408, 8);
            this.xrLabel21.Name = "xrLabel21";
            this.xrLabel21.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel21.ParentStyleUsing.UseFont = false;
            this.xrLabel21.Size = new System.Drawing.Size(80, 20);
            this.xrLabel21.Text = "Unit Price";
            this.xrLabel21.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel22
            // 
            this.xrLabel22.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel22.Location = new System.Drawing.Point(625, 8);
            this.xrLabel22.Name = "xrLabel22";
            this.xrLabel22.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel22.ParentStyleUsing.UseFont = false;
            this.xrLabel22.Size = new System.Drawing.Size(80, 20);
            this.xrLabel22.Text = "Remarks";
            // 
            // gh1Unit
            // 
            this.gh1Unit.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gh1Unit.Location = new System.Drawing.Point(508, 25);
            this.gh1Unit.Name = "gh1Unit";
            this.gh1Unit.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.gh1Unit.ParentStyleUsing.UseFont = false;
            this.gh1Unit.Size = new System.Drawing.Size(41, 20);
            this.gh1Unit.Text = "XXX";
            this.gh1Unit.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // gh1Currency1
            // 
            this.gh1Currency1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gh1Currency1.Location = new System.Drawing.Point(408, 25);
            this.gh1Currency1.Name = "gh1Currency1";
            this.gh1Currency1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.gh1Currency1.ParentStyleUsing.UseFont = false;
            this.gh1Currency1.Size = new System.Drawing.Size(80, 20);
            this.gh1Currency1.Text = "XXX";
            this.gh1Currency1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrShape1
            // 
            this.xrShape1.BackColor = System.Drawing.Color.Silver;
            this.xrShape1.Location = new System.Drawing.Point(0, 0);
            this.xrShape1.Name = "xrShape1";
            this.xrShape1.ParentStyleUsing.UseBackColor = false;
            this.xrShape1.ParentStyleUsing.UseBorders = false;
            this.xrShape1.Shape = shapeRectangle3;
            this.xrShape1.Size = new System.Drawing.Size(750, 50);
            // 
            // xrLabel1
            // 
            this.xrLabel1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrLabel1.Location = new System.Drawing.Point(558, 8);
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel1.ParentStyleUsing.UseFont = false;
            this.xrLabel1.Size = new System.Drawing.Size(58, 20);
            this.xrLabel1.Text = "Shpt";
            // 
            // lblYourRef
            // 
            this.lblYourRef.Font = new System.Drawing.Font("Arial", 9.75F);
            this.lblYourRef.Location = new System.Drawing.Point(0, 0);
            this.lblYourRef.Name = "lblYourRef";
            this.lblYourRef.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblYourRef.ParentStyleUsing.UseFont = false;
            this.lblYourRef.Size = new System.Drawing.Size(84, 20);
            this.lblYourRef.Text = "lblYourRef";
            // 
            // txtArticleCode
            // 
            this.txtArticleCode.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArticleCode.Location = new System.Drawing.Point(92, 0);
            this.txtArticleCode.Name = "txtArticleCode";
            this.txtArticleCode.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.txtArticleCode.ParentStyleUsing.UseFont = false;
            this.txtArticleCode.Size = new System.Drawing.Size(84, 20);
            this.txtArticleCode.Text = "txtArticleCode";
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUnitPrice.Location = new System.Drawing.Point(408, 0);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.txtUnitPrice.ParentStyleUsing.UseFont = false;
            this.txtUnitPrice.Size = new System.Drawing.Size(80, 20);
            this.txtUnitPrice.Text = "txtUnitPrice";
            this.txtUnitPrice.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // txtQty
            // 
            this.txtQty.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQty.Location = new System.Drawing.Point(492, 0);
            this.txtQty.Name = "txtQty";
            this.txtQty.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.txtQty.ParentStyleUsing.UseFont = false;
            this.txtQty.Size = new System.Drawing.Size(58, 20);
            this.txtQty.Text = "txtQty";
            this.txtQty.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // txtSuppName
            // 
            this.txtSuppName.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F);
            this.txtSuppName.Location = new System.Drawing.Point(176, 0);
            this.txtSuppName.Name = "txtSuppName";
            this.txtSuppName.ParentStyleUsing.UseFont = false;
            this.txtSuppName.RtfText = ((DevExpress.XtraReports.UI.SerializableString)(resources.GetObject("txtSuppName.RtfText")));
            this.txtSuppName.Size = new System.Drawing.Size(208, 20);
            // 
            // xrLabel2
            // 
            this.xrLabel2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrLabel2.Location = new System.Drawing.Point(0, 17);
            this.xrLabel2.Name = "xrLabel2";
            this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel2.ParentStyleUsing.UseFont = false;
            this.xrLabel2.Size = new System.Drawing.Size(117, 17);
            this.xrLabel2.Text = "BEST REGARDS";
            // 
            // ConFirmationSheetXr_Pdf
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.PageHeader,
            this.PageFooter,
            this.gh1,
            this.gh2,
            this.gf1});
            this.Margins = new System.Drawing.Printing.Margins(50, 0, 50, 50);
            this.PageHeight = 1169;
            this.PageWidth = 827;
            this.PaperKind = System.Drawing.Printing.PaperKind.A4;
            ((System.ComponentModel.ISupportInitialize)(this.txtPLNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPLDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCustName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCustAddr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHeader)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSuppName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.PageHeaderBand PageHeader;
        private DevExpress.XtraReports.UI.PageFooterBand PageFooter;
        private DevExpress.XtraReports.UI.GroupHeaderBand gh1;
        private DevExpress.XtraReports.UI.GroupHeaderBand gh2;
        private DevExpress.XtraReports.UI.GroupFooterBand gf1;
        private DevExpress.XtraReports.UI.XRLabel xrLabel5;
        private DevExpress.XtraReports.UI.XRRichText txtTel;
        private DevExpress.XtraReports.UI.XRShape xrShape2;
        private DevExpress.XtraReports.UI.XRPageInfo txtPageInfo;
        private DevExpress.XtraReports.UI.XRRichText txtCustAddr;
        private DevExpress.XtraReports.UI.XRRichText txtFax;
        private DevExpress.XtraReports.UI.XRRichText txtCustName;
        private DevExpress.XtraReports.UI.XRLabel xrLabel3;
        private DevExpress.XtraReports.UI.XRLabel xrLabel4;
        private DevExpress.XtraReports.UI.XRRichText txtPLDate;
        private DevExpress.XtraReports.UI.XRRichText txtPLNumber;
        private DevExpress.XtraReports.UI.XRLabel xrLabel6;
        private DevExpress.XtraReports.UI.XRRichText txtHeader;
        private DevExpress.XtraReports.UI.XRLabel gh1Currency1;
        private DevExpress.XtraReports.UI.XRLabel gh1Unit;
        private DevExpress.XtraReports.UI.XRLabel xrLabel22;
        private DevExpress.XtraReports.UI.XRLabel xrLabel21;
        private DevExpress.XtraReports.UI.XRLabel xrLabel20;
        private DevExpress.XtraReports.UI.XRLabel xrLabel19;
        private DevExpress.XtraReports.UI.XRLabel xrLabel17;
        private DevExpress.XtraReports.UI.XRLabel xrLabel15;
        private DevExpress.XtraReports.UI.XRShape xrShape1;
        private DevExpress.XtraReports.UI.XRLabel xrLabel1;
        private DevExpress.XtraReports.UI.XRLabel txtArticleCode;
        private DevExpress.XtraReports.UI.XRLabel lblYourRef;
        private DevExpress.XtraReports.UI.XRLabel txtQty;
        private DevExpress.XtraReports.UI.XRLabel txtUnitPrice;
        private DevExpress.XtraReports.UI.XRRichText txtSuppName;
        private DevExpress.XtraReports.UI.XRLabel xrLabel2;
    }
}
