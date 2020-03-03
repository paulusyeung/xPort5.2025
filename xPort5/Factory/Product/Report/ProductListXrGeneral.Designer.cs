namespace xPort5.Factory.Product.Report
{
    partial class ProductListXrGeneral
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
            this.paneDetail = new DevExpress.XtraReports.UI.XRPanel();
            this.txtDescription = new DevExpress.XtraReports.UI.XRLabel();
            this.txtProductCode = new DevExpress.XtraReports.UI.XRLabel();
            this.txtSKU = new DevExpress.XtraReports.UI.XRLabel();
            this.txtRemarks = new DevExpress.XtraReports.UI.XRLabel();
            this.txtBarcode = new DevExpress.XtraReports.UI.XRLabel();
            this.txtCategory = new DevExpress.XtraReports.UI.XRLabel();
            this.txtOrigin = new DevExpress.XtraReports.UI.XRLabel();
            this.txtColor = new DevExpress.XtraReports.UI.XRLabel();
            this.picProduct = new DevExpress.XtraReports.UI.XRPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.paneDetail});
            this.Detail.Height = 84;
            this.Detail.Name = "Detail";
            this.Detail.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.Detail_BeforePrint);
            // 
            // paneDetail
            // 
            this.paneDetail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.txtDescription,
            this.txtProductCode,
            this.txtSKU,
            this.txtRemarks,
            this.txtBarcode,
            this.txtCategory,
            this.txtOrigin,
            this.txtColor,
            this.picProduct});
            this.paneDetail.Location = new System.Drawing.Point(0, 0);
            this.paneDetail.Name = "paneDetail";
            this.paneDetail.ParentStyleUsing.UseBackColor = false;
            this.paneDetail.Size = new System.Drawing.Size(502, 83);
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Arial Unicode MS", 7F);
            this.txtDescription.Location = new System.Drawing.Point(99, 52);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.txtDescription.ParentStyleUsing.UseFont = false;
            this.txtDescription.Size = new System.Drawing.Size(200, 14);
            this.txtDescription.Text = "txtDescription";
            // 
            // txtProductCode
            // 
            this.txtProductCode.Font = new System.Drawing.Font("Arial Unicode MS", 7F);
            this.txtProductCode.Location = new System.Drawing.Point(99, 21);
            this.txtProductCode.Name = "txtProductCode";
            this.txtProductCode.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.txtProductCode.ParentStyleUsing.UseFont = false;
            this.txtProductCode.Size = new System.Drawing.Size(200, 14);
            this.txtProductCode.Text = "txtProductCode";
            // 
            // txtSKU
            // 
            this.txtSKU.Font = new System.Drawing.Font("Arial Unicode MS", 7F);
            this.txtSKU.Location = new System.Drawing.Point(99, 5);
            this.txtSKU.Name = "txtSKU";
            this.txtSKU.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.txtSKU.ParentStyleUsing.UseFont = false;
            this.txtSKU.Size = new System.Drawing.Size(200, 14);
            this.txtSKU.Text = "txtSKU";
            // 
            // txtRemarks
            // 
            this.txtRemarks.Font = new System.Drawing.Font("Arial Unicode MS", 7F);
            this.txtRemarks.Location = new System.Drawing.Point(302, 52);
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.txtRemarks.ParentStyleUsing.UseFont = false;
            this.txtRemarks.Size = new System.Drawing.Size(200, 14);
            this.txtRemarks.Text = "txtRemarks";
            // 
            // txtBarcode
            // 
            this.txtBarcode.Font = new System.Drawing.Font("Arial Unicode MS", 7F);
            this.txtBarcode.Location = new System.Drawing.Point(302, 5);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.txtBarcode.ParentStyleUsing.UseFont = false;
            this.txtBarcode.Size = new System.Drawing.Size(200, 14);
            this.txtBarcode.Text = "txtBarcode";
            // 
            // txtCategory
            // 
            this.txtCategory.Font = new System.Drawing.Font("Arial Unicode MS", 7F);
            this.txtCategory.Location = new System.Drawing.Point(302, 21);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.txtCategory.ParentStyleUsing.UseFont = false;
            this.txtCategory.Size = new System.Drawing.Size(200, 14);
            this.txtCategory.Text = "txtCategory";
            // 
            // txtOrigin
            // 
            this.txtOrigin.Font = new System.Drawing.Font("Arial Unicode MS", 7F);
            this.txtOrigin.Location = new System.Drawing.Point(302, 36);
            this.txtOrigin.Name = "txtOrigin";
            this.txtOrigin.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.txtOrigin.ParentStyleUsing.UseFont = false;
            this.txtOrigin.Size = new System.Drawing.Size(200, 14);
            this.txtOrigin.Text = "txtOrigin";
            // 
            // txtColor
            // 
            this.txtColor.Font = new System.Drawing.Font("Arial Unicode MS", 7F);
            this.txtColor.Location = new System.Drawing.Point(99, 36);
            this.txtColor.Name = "txtColor";
            this.txtColor.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.txtColor.ParentStyleUsing.UseFont = false;
            this.txtColor.Size = new System.Drawing.Size(200, 14);
            this.txtColor.Text = "txtColor";
            // 
            // picProduct
            // 
            this.picProduct.Location = new System.Drawing.Point(3, 5);
            this.picProduct.Name = "picProduct";
            this.picProduct.Size = new System.Drawing.Size(94, 75);
            this.picProduct.Sizing = DevExpress.XtraPrinting.ImageSizeMode.ZoomImage;
            // 
            // ProductListXrGeneral
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail});
            this.Margins = new System.Drawing.Printing.Margins(0, 0, 0, 0);
            this.PageHeight = 100;
            this.PageWidth = 502;
            this.PaperKind = System.Drawing.Printing.PaperKind.Custom;
            this.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.ProductListXrGeneral_BeforePrint);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.XRPanel paneDetail;
        private DevExpress.XtraReports.UI.XRLabel txtDescription;
        private DevExpress.XtraReports.UI.XRLabel txtProductCode;
        private DevExpress.XtraReports.UI.XRLabel txtSKU;
        private DevExpress.XtraReports.UI.XRLabel txtRemarks;
        private DevExpress.XtraReports.UI.XRLabel txtBarcode;
        private DevExpress.XtraReports.UI.XRLabel txtCategory;
        private DevExpress.XtraReports.UI.XRLabel txtOrigin;
        private DevExpress.XtraReports.UI.XRLabel txtColor;
        private DevExpress.XtraReports.UI.XRPictureBox picProduct;
    }
}
