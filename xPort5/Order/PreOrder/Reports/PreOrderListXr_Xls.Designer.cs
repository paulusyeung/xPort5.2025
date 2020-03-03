namespace xPort5.Order.PreOrder.Reports
{
    partial class PreOrderListXr_Xls
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PreOrderListXr_Xls));
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.txtCustRef = new DevExpress.XtraReports.UI.XRLabel();
            this.txtParticular = new DevExpress.XtraReports.UI.XRRichText();
            this.txtArticleName = new DevExpress.XtraReports.UI.XRRichText();
            this.txtArticleCode = new DevExpress.XtraReports.UI.XRLabel();
            this.txtColor = new DevExpress.XtraReports.UI.XRRichText();
            this.txtPacking = new DevExpress.XtraReports.UI.XRRichText();
            this.txtOrderQty = new DevExpress.XtraReports.UI.XRLabel();
            this.txtSuppName = new DevExpress.XtraReports.UI.XRRichText();
            this.xrLabel11 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel12 = new DevExpress.XtraReports.UI.XRLabel();
            this.PageHeader = new DevExpress.XtraReports.UI.PageHeaderBand();
            this.txtHeader = new DevExpress.XtraReports.UI.XRRichText();
            this.PageFooter = new DevExpress.XtraReports.UI.PageFooterBand();
            this.gh1 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel7 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel8 = new DevExpress.XtraReports.UI.XRLabel();
            this.gh2 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.txtCustName = new DevExpress.XtraReports.UI.XRRichText();
            this.xrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
            this.txtPLDate = new DevExpress.XtraReports.UI.XRRichText();
            this.txtPLNumber = new DevExpress.XtraReports.UI.XRRichText();
            this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel5 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel9 = new DevExpress.XtraReports.UI.XRLabel();
            this.subCustShipment = new DevExpress.XtraReports.UI.XRSubreport();
            this.subSuppShipment = new DevExpress.XtraReports.UI.XRSubreport();
            this.txtCostPrice = new DevExpress.XtraReports.UI.XRLabel();
            this.txtCostPrice2 = new DevExpress.XtraReports.UI.XRLabel();
            ((System.ComponentModel.ISupportInitialize)(this.txtParticular)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtArticleName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPacking)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSuppName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHeader)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCustName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPLDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPLNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.txtCostPrice2,
            this.txtCostPrice,
            this.subSuppShipment,
            this.subCustShipment,
            this.txtCustRef,
            this.txtParticular,
            this.txtArticleName,
            this.txtArticleCode,
            this.txtColor,
            this.txtPacking,
            this.txtOrderQty,
            this.txtSuppName,
            this.xrLabel11,
            this.xrLabel12});
            this.Detail.Height = 165;
            this.Detail.Name = "Detail";
            this.Detail.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.Detail_BeforePrint);
            // 
            // txtCustRef
            // 
            this.txtCustRef.Font = new System.Drawing.Font("Arial", 9.75F);
            this.txtCustRef.Location = new System.Drawing.Point(0, 20);
            this.txtCustRef.Name = "txtCustRef";
            this.txtCustRef.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.txtCustRef.ParentStyleUsing.UseFont = false;
            this.txtCustRef.Size = new System.Drawing.Size(100, 20);
            this.txtCustRef.Text = "txtCustRef";
            // 
            // txtParticular
            // 
            this.txtParticular.Font = new System.Drawing.Font("Arial", 9.75F);
            this.txtParticular.Location = new System.Drawing.Point(100, 80);
            this.txtParticular.Name = "txtParticular";
            this.txtParticular.ParentStyleUsing.UseFont = false;
            this.txtParticular.RtfText = ((DevExpress.XtraReports.UI.SerializableString)(resources.GetObject("txtParticular.RtfText")));
            this.txtParticular.Size = new System.Drawing.Size(360, 20);
            // 
            // txtArticleName
            // 
            this.txtArticleName.Font = new System.Drawing.Font("Arial", 9.75F);
            this.txtArticleName.Location = new System.Drawing.Point(100, 0);
            this.txtArticleName.Name = "txtArticleName";
            this.txtArticleName.ParentStyleUsing.UseFont = false;
            this.txtArticleName.RtfText = ((DevExpress.XtraReports.UI.SerializableString)(resources.GetObject("txtArticleName.RtfText")));
            this.txtArticleName.Size = new System.Drawing.Size(360, 40);
            // 
            // txtArticleCode
            // 
            this.txtArticleCode.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArticleCode.Location = new System.Drawing.Point(0, 0);
            this.txtArticleCode.Name = "txtArticleCode";
            this.txtArticleCode.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.txtArticleCode.ParentStyleUsing.UseFont = false;
            this.txtArticleCode.Size = new System.Drawing.Size(100, 20);
            this.txtArticleCode.Text = "txtArticleCode";
            // 
            // txtColor
            // 
            this.txtColor.Font = new System.Drawing.Font("Arial", 9.75F);
            this.txtColor.Location = new System.Drawing.Point(100, 40);
            this.txtColor.Name = "txtColor";
            this.txtColor.ParentStyleUsing.UseFont = false;
            this.txtColor.RtfText = ((DevExpress.XtraReports.UI.SerializableString)(resources.GetObject("txtColor.RtfText")));
            this.txtColor.Size = new System.Drawing.Size(360, 20);
            // 
            // txtPacking
            // 
            this.txtPacking.Font = new System.Drawing.Font("Arial", 9.75F);
            this.txtPacking.Location = new System.Drawing.Point(100, 60);
            this.txtPacking.Name = "txtPacking";
            this.txtPacking.ParentStyleUsing.UseFont = false;
            this.txtPacking.RtfText = ((DevExpress.XtraReports.UI.SerializableString)(resources.GetObject("txtPacking.RtfText")));
            this.txtPacking.Size = new System.Drawing.Size(360, 20);
            // 
            // txtOrderQty
            // 
            this.txtOrderQty.Font = new System.Drawing.Font("Arial", 9.75F);
            this.txtOrderQty.Location = new System.Drawing.Point(602, 0);
            this.txtOrderQty.Name = "txtOrderQty";
            this.txtOrderQty.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.txtOrderQty.ParentStyleUsing.UseFont = false;
            this.txtOrderQty.Size = new System.Drawing.Size(150, 20);
            this.txtOrderQty.Text = "txtOrderQty";
            this.txtOrderQty.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // txtSuppName
            // 
            this.txtSuppName.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F);
            this.txtSuppName.Location = new System.Drawing.Point(100, 100);
            this.txtSuppName.Name = "txtSuppName";
            this.txtSuppName.ParentStyleUsing.UseFont = false;
            this.txtSuppName.RtfText = ((DevExpress.XtraReports.UI.SerializableString)(resources.GetObject("txtSuppName.RtfText")));
            this.txtSuppName.Size = new System.Drawing.Size(360, 20);
            // 
            // xrLabel11
            // 
            this.xrLabel11.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel11.Font = new System.Drawing.Font("Arial", 9.75F);
            this.xrLabel11.Location = new System.Drawing.Point(100, 120);
            this.xrLabel11.Name = "xrLabel11";
            this.xrLabel11.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel11.ParentStyleUsing.UseBorders = false;
            this.xrLabel11.ParentStyleUsing.UseFont = false;
            this.xrLabel11.Size = new System.Drawing.Size(209, 20);
            this.xrLabel11.Text = "Customer Shipment Schedule";
            this.xrLabel11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel12
            // 
            this.xrLabel12.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel12.Font = new System.Drawing.Font("Arial", 9.75F);
            this.xrLabel12.Location = new System.Drawing.Point(325, 120);
            this.xrLabel12.Name = "xrLabel12";
            this.xrLabel12.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel12.ParentStyleUsing.UseBorders = false;
            this.xrLabel12.ParentStyleUsing.UseFont = false;
            this.xrLabel12.Size = new System.Drawing.Size(210, 20);
            this.xrLabel12.Text = "Supplier Shipment Schedule";
            this.xrLabel12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // PageHeader
            // 
            this.PageHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.txtHeader});
            this.PageHeader.Name = "PageHeader";
            // 
            // txtHeader
            // 
            this.txtHeader.Font = new System.Drawing.Font("Arial", 9.75F);
            this.txtHeader.Location = new System.Drawing.Point(0, 0);
            this.txtHeader.Name = "txtHeader";
            this.txtHeader.ParentStyleUsing.UseFont = false;
            this.txtHeader.RtfText = ((DevExpress.XtraReports.UI.SerializableString)(resources.GetObject("txtHeader.RtfText")));
            this.txtHeader.Size = new System.Drawing.Size(750, 100);
            this.txtHeader.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.txtHeader_BeforePrint);
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
            this.xrLabel2,
            this.xrLabel7,
            this.xrLabel8});
            this.gh1.Height = 18;
            this.gh1.Name = "gh1";
            // 
            // xrLabel1
            // 
            this.xrLabel1.Font = new System.Drawing.Font("Arial", 9.75F);
            this.xrLabel1.Location = new System.Drawing.Point(0, 0);
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel1.ParentStyleUsing.UseFont = false;
            this.xrLabel1.Size = new System.Drawing.Size(100, 18);
            this.xrLabel1.Text = "Article Code";
            // 
            // xrLabel2
            // 
            this.xrLabel2.Font = new System.Drawing.Font("Arial", 9.75F);
            this.xrLabel2.Location = new System.Drawing.Point(100, 0);
            this.xrLabel2.Name = "xrLabel2";
            this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel2.ParentStyleUsing.UseFont = false;
            this.xrLabel2.Size = new System.Drawing.Size(360, 18);
            this.xrLabel2.Text = "Description";
            // 
            // xrLabel7
            // 
            this.xrLabel7.Font = new System.Drawing.Font("Arial", 9.75F);
            this.xrLabel7.Location = new System.Drawing.Point(460, 0);
            this.xrLabel7.Name = "xrLabel7";
            this.xrLabel7.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel7.ParentStyleUsing.UseFont = false;
            this.xrLabel7.Size = new System.Drawing.Size(142, 18);
            this.xrLabel7.Text = "Cost / Price";
            this.xrLabel7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // xrLabel8
            // 
            this.xrLabel8.Font = new System.Drawing.Font("Arial", 9.75F);
            this.xrLabel8.Location = new System.Drawing.Point(602, 0);
            this.xrLabel8.Name = "xrLabel8";
            this.xrLabel8.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel8.ParentStyleUsing.UseFont = false;
            this.xrLabel8.Size = new System.Drawing.Size(150, 18);
            this.xrLabel8.Text = "Order Qty";
            this.xrLabel8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // gh2
            // 
            this.gh2.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.txtCustName,
            this.xrLabel4,
            this.txtPLDate,
            this.txtPLNumber,
            this.xrLabel3,
            this.xrLabel5,
            this.xrLabel9});
            this.gh2.Height = 129;
            this.gh2.Level = 1;
            this.gh2.Name = "gh2";
            this.gh2.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.gh2_BeforePrint);
            // 
            // txtCustName
            // 
            this.txtCustName.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F);
            this.txtCustName.Location = new System.Drawing.Point(100, 48);
            this.txtCustName.Name = "txtCustName";
            this.txtCustName.ParentStyleUsing.UseFont = false;
            this.txtCustName.RtfText = ((DevExpress.XtraReports.UI.SerializableString)(resources.GetObject("txtCustName.RtfText")));
            this.txtCustName.Size = new System.Drawing.Size(360, 20);
            // 
            // xrLabel4
            // 
            this.xrLabel4.Font = new System.Drawing.Font("Arial", 9.75F);
            this.xrLabel4.Location = new System.Drawing.Point(522, 68);
            this.xrLabel4.Name = "xrLabel4";
            this.xrLabel4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel4.ParentStyleUsing.UseFont = false;
            this.xrLabel4.Size = new System.Drawing.Size(80, 21);
            this.xrLabel4.Text = "Date";
            // 
            // txtPLDate
            // 
            this.txtPLDate.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPLDate.Location = new System.Drawing.Point(602, 68);
            this.txtPLDate.Name = "txtPLDate";
            this.txtPLDate.ParentStyleUsing.UseFont = false;
            this.txtPLDate.RtfText = ((DevExpress.XtraReports.UI.SerializableString)(resources.GetObject("txtPLDate.RtfText")));
            this.txtPLDate.Size = new System.Drawing.Size(150, 21);
            // 
            // txtPLNumber
            // 
            this.txtPLNumber.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPLNumber.Location = new System.Drawing.Point(602, 48);
            this.txtPLNumber.Name = "txtPLNumber";
            this.txtPLNumber.ParentStyleUsing.UseFont = false;
            this.txtPLNumber.RtfText = ((DevExpress.XtraReports.UI.SerializableString)(resources.GetObject("txtPLNumber.RtfText")));
            this.txtPLNumber.Size = new System.Drawing.Size(150, 20);
            // 
            // xrLabel3
            // 
            this.xrLabel3.Font = new System.Drawing.Font("Arial", 9.75F);
            this.xrLabel3.Location = new System.Drawing.Point(522, 48);
            this.xrLabel3.Name = "xrLabel3";
            this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel3.ParentStyleUsing.UseFont = false;
            this.xrLabel3.Size = new System.Drawing.Size(80, 20);
            this.xrLabel3.Text = "Number";
            // 
            // xrLabel5
            // 
            this.xrLabel5.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.xrLabel5.Location = new System.Drawing.Point(0, 0);
            this.xrLabel5.Name = "xrLabel5";
            this.xrLabel5.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel5.ParentStyleUsing.UseFont = false;
            this.xrLabel5.Size = new System.Drawing.Size(750, 33);
            this.xrLabel5.Text = "Pre-Order List";
            this.xrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel9
            // 
            this.xrLabel9.Font = new System.Drawing.Font("Arial", 9.75F);
            this.xrLabel9.Location = new System.Drawing.Point(0, 48);
            this.xrLabel9.Name = "xrLabel9";
            this.xrLabel9.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel9.ParentStyleUsing.UseFont = false;
            this.xrLabel9.Size = new System.Drawing.Size(100, 20);
            this.xrLabel9.Text = "To Messers :";
            // 
            // subCustShipment
            // 
            this.subCustShipment.Location = new System.Drawing.Point(100, 140);
            this.subCustShipment.Name = "subCustShipment";
            this.subCustShipment.Size = new System.Drawing.Size(209, 25);
            // 
            // subSuppShipment
            // 
            this.subSuppShipment.Location = new System.Drawing.Point(325, 140);
            this.subSuppShipment.Name = "subSuppShipment";
            this.subSuppShipment.Size = new System.Drawing.Size(209, 25);
            // 
            // txtCostPrice
            // 
            this.txtCostPrice.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCostPrice.Location = new System.Drawing.Point(460, 0);
            this.txtCostPrice.Name = "txtCostPrice";
            this.txtCostPrice.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.txtCostPrice.ParentStyleUsing.UseFont = false;
            this.txtCostPrice.Size = new System.Drawing.Size(142, 20);
            this.txtCostPrice.Text = "txtCostPrice";
            this.txtCostPrice.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // txtCostPrice2
            // 
            this.txtCostPrice2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCostPrice2.Location = new System.Drawing.Point(460, 20);
            this.txtCostPrice2.Name = "txtCostPrice2";
            this.txtCostPrice2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.txtCostPrice2.ParentStyleUsing.UseFont = false;
            this.txtCostPrice2.Size = new System.Drawing.Size(142, 20);
            this.txtCostPrice2.Text = "txtCostPrice2";
            this.txtCostPrice2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // PreOrderListXr_Xls
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.PageHeader,
            this.PageFooter,
            this.gh1,
            this.gh2});
            this.Margins = new System.Drawing.Printing.Margins(50, 0, 50, 50);
            this.PageHeight = 1169;
            this.PageWidth = 827;
            this.PaperKind = System.Drawing.Printing.PaperKind.A4;
            ((System.ComponentModel.ISupportInitialize)(this.txtParticular)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtArticleName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPacking)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSuppName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHeader)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCustName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPLDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPLNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.PageHeaderBand PageHeader;
        private DevExpress.XtraReports.UI.PageFooterBand PageFooter;
        private DevExpress.XtraReports.UI.GroupHeaderBand gh1;
        private DevExpress.XtraReports.UI.GroupHeaderBand gh2;
        private DevExpress.XtraReports.UI.XRRichText txtHeader;
        private DevExpress.XtraReports.UI.XRRichText txtCustName;
        private DevExpress.XtraReports.UI.XRLabel xrLabel4;
        private DevExpress.XtraReports.UI.XRRichText txtPLDate;
        private DevExpress.XtraReports.UI.XRRichText txtPLNumber;
        private DevExpress.XtraReports.UI.XRLabel xrLabel3;
        private DevExpress.XtraReports.UI.XRLabel xrLabel5;
        private DevExpress.XtraReports.UI.XRLabel xrLabel9;
        private DevExpress.XtraReports.UI.XRLabel xrLabel1;
        private DevExpress.XtraReports.UI.XRLabel xrLabel2;
        private DevExpress.XtraReports.UI.XRLabel xrLabel7;
        private DevExpress.XtraReports.UI.XRLabel xrLabel8;
        private DevExpress.XtraReports.UI.XRLabel txtCustRef;
        private DevExpress.XtraReports.UI.XRRichText txtParticular;
        private DevExpress.XtraReports.UI.XRRichText txtArticleName;
        private DevExpress.XtraReports.UI.XRLabel txtArticleCode;
        private DevExpress.XtraReports.UI.XRRichText txtColor;
        private DevExpress.XtraReports.UI.XRRichText txtPacking;
        private DevExpress.XtraReports.UI.XRLabel txtOrderQty;
        private DevExpress.XtraReports.UI.XRRichText txtSuppName;
        private DevExpress.XtraReports.UI.XRLabel xrLabel11;
        private DevExpress.XtraReports.UI.XRLabel xrLabel12;
        private DevExpress.XtraReports.UI.XRSubreport subSuppShipment;
        private DevExpress.XtraReports.UI.XRSubreport subCustShipment;
        private DevExpress.XtraReports.UI.XRLabel txtCostPrice2;
        private DevExpress.XtraReports.UI.XRLabel txtCostPrice;
    }
}
