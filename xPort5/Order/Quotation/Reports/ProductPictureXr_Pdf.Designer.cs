namespace xPort5.Order.Quotation.Reports
{
    partial class ProductPictureXr_Pdf
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductPictureXr_Pdf));
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.imgProductPicture = new DevExpress.XtraReports.UI.XRPictureBox();
            this.txtArticleCode = new DevExpress.XtraReports.UI.XRLabel();
            this.PageHeader = new DevExpress.XtraReports.UI.PageHeaderBand();
            this.xrLine1 = new DevExpress.XtraReports.UI.XRLine();
            this.txtQTNumber = new DevExpress.XtraReports.UI.XRRichText();
            this.txtPageInfo = new DevExpress.XtraReports.UI.XRPageInfo();
            this.PageFooter = new DevExpress.XtraReports.UI.PageFooterBand();
            this.xrControlStyle1 = new DevExpress.XtraReports.UI.XRControlStyle();
            ((System.ComponentModel.ISupportInitialize)(this.txtQTNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.txtArticleCode,
            this.imgProductPicture});
            this.Detail.Height = 311;
            this.Detail.KeepTogether = true;
            this.Detail.MultiColumn.ColumnCount = 2;
            this.Detail.MultiColumn.Direction = DevExpress.XtraReports.UI.ColumnDirection.AcrossThenDown;
            this.Detail.MultiColumn.Mode = DevExpress.XtraReports.UI.MultiColumnMode.UseColumnCount;
            this.Detail.Name = "Detail";
            this.Detail.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.Detail_BeforePrint);
            // 
            // imgProductPicture
            // 
            this.imgProductPicture.BorderColor = System.Drawing.Color.Gainsboro;
            this.imgProductPicture.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
                        | DevExpress.XtraPrinting.BorderSide.Right)
                        | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.imgProductPicture.Location = new System.Drawing.Point(0, 0);
            this.imgProductPicture.Name = "imgProductPicture";
            this.imgProductPicture.ParentStyleUsing.UseBorderColor = false;
            this.imgProductPicture.ParentStyleUsing.UseBorders = false;
            this.imgProductPicture.Size = new System.Drawing.Size(360, 288);
            this.imgProductPicture.Sizing = DevExpress.XtraPrinting.ImageSizeMode.ZoomImage;
            // 
            // txtArticleCode
            // 
            this.txtArticleCode.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArticleCode.Location = new System.Drawing.Point(0, 288);
            this.txtArticleCode.Name = "txtArticleCode";
            this.txtArticleCode.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.txtArticleCode.ParentStyleUsing.UseFont = false;
            this.txtArticleCode.Size = new System.Drawing.Size(360, 20);
            this.txtArticleCode.Text = "txtArticleCode";
            this.txtArticleCode.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // PageHeader
            // 
            this.PageHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLine1,
            this.txtQTNumber,
            this.txtPageInfo});
            this.PageHeader.Height = 22;
            this.PageHeader.Name = "PageHeader";
            this.PageHeader.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.PageHeader_BeforePrint);
            // 
            // xrLine1
            // 
            this.xrLine1.Location = new System.Drawing.Point(0, 12);
            this.xrLine1.Name = "xrLine1";
            this.xrLine1.Size = new System.Drawing.Size(746, 4);
            // 
            // txtQTNumber
            // 
            this.txtQTNumber.Font = new System.Drawing.Font("Arial", 8F);
            this.txtQTNumber.Location = new System.Drawing.Point(0, 0);
            this.txtQTNumber.Name = "txtQTNumber";
            this.txtQTNumber.ParentStyleUsing.UseFont = false;
            this.txtQTNumber.RtfText = ((DevExpress.XtraReports.UI.SerializableString)(resources.GetObject("txtQTNumber.RtfText")));
            this.txtQTNumber.Size = new System.Drawing.Size(150, 16);
            // 
            // txtPageInfo
            // 
            this.txtPageInfo.Font = new System.Drawing.Font("Arial", 8F);
            this.txtPageInfo.Location = new System.Drawing.Point(650, 0);
            this.txtPageInfo.Name = "txtPageInfo";
            this.txtPageInfo.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.txtPageInfo.ParentStyleUsing.UseFont = false;
            this.txtPageInfo.Size = new System.Drawing.Size(100, 16);
            this.txtPageInfo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // PageFooter
            // 
            this.PageFooter.Height = 0;
            this.PageFooter.Name = "PageFooter";
            // 
            // xrControlStyle1
            // 
            this.xrControlStyle1.Name = "xrControlStyle1";
            // 
            // ProductPictureXr_Pdf
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.PageHeader,
            this.PageFooter});
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margins = new System.Drawing.Printing.Margins(50, 0, 50, 50);
            this.PageHeight = 1169;
            this.PageWidth = 827;
            this.PaperKind = System.Drawing.Printing.PaperKind.A4;
            this.StyleSheet.AddRange(new DevExpress.XtraReports.UI.XRControlStyle[] {
            this.xrControlStyle1});
            ((System.ComponentModel.ISupportInitialize)(this.txtQTNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.PageHeaderBand PageHeader;
        private DevExpress.XtraReports.UI.PageFooterBand PageFooter;
        private DevExpress.XtraReports.UI.XRRichText txtQTNumber;
        private DevExpress.XtraReports.UI.XRLabel txtArticleCode;
        private DevExpress.XtraReports.UI.XRPageInfo txtPageInfo;
        private DevExpress.XtraReports.UI.XRControlStyle xrControlStyle1;
        private DevExpress.XtraReports.UI.XRLine xrLine1;
        private DevExpress.XtraReports.UI.XRPictureBox imgProductPicture;
    }
}
