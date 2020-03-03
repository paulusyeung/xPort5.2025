namespace xPort5.Factory.Product.Report
{
    partial class ProductListXrSupplier
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
            this.txtFCLCost = new DevExpress.XtraReports.UI.XRLabel();
            this.txtSuppRef = new DevExpress.XtraReports.UI.XRLabel();
            this.txtLCLCost = new DevExpress.XtraReports.UI.XRLabel();
            this.txtCurrency = new DevExpress.XtraReports.UI.XRLabel();
            this.txtUnitCost = new DevExpress.XtraReports.UI.XRLabel();
            this.txtSupplier = new DevExpress.XtraReports.UI.XRLabel();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.paneDetail});
            this.Detail.Height = 31;
            this.Detail.Name = "Detail";
            this.Detail.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.Detail_BeforePrint);
            // 
            // paneDetail
            // 
            this.paneDetail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.txtFCLCost,
            this.txtSuppRef,
            this.txtLCLCost,
            this.txtCurrency,
            this.txtUnitCost,
            this.txtSupplier});
            this.paneDetail.Location = new System.Drawing.Point(0, 0);
            this.paneDetail.Name = "paneDetail";
            this.paneDetail.Size = new System.Drawing.Size(250, 31);
            // 
            // txtFCLCost
            // 
            this.txtFCLCost.Font = new System.Drawing.Font("Arial Unicode MS", 7F);
            this.txtFCLCost.Location = new System.Drawing.Point(50, 15);
            this.txtFCLCost.Name = "txtFCLCost";
            this.txtFCLCost.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.txtFCLCost.ParentStyleUsing.UseFont = false;
            this.txtFCLCost.Size = new System.Drawing.Size(50, 14);
            this.txtFCLCost.Text = "FCL Cost";
            this.txtFCLCost.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // txtSuppRef
            // 
            this.txtSuppRef.Font = new System.Drawing.Font("Arial Unicode MS", 7F);
            this.txtSuppRef.Location = new System.Drawing.Point(0, 15);
            this.txtSuppRef.Name = "txtSuppRef";
            this.txtSuppRef.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.txtSuppRef.ParentStyleUsing.UseFont = false;
            this.txtSuppRef.Size = new System.Drawing.Size(50, 14);
            this.txtSuppRef.Text = "Supp. Ref.";
            this.txtSuppRef.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // txtLCLCost
            // 
            this.txtLCLCost.Font = new System.Drawing.Font("Arial Unicode MS", 7F);
            this.txtLCLCost.Location = new System.Drawing.Point(100, 15);
            this.txtLCLCost.Name = "txtLCLCost";
            this.txtLCLCost.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.txtLCLCost.ParentStyleUsing.UseFont = false;
            this.txtLCLCost.Size = new System.Drawing.Size(50, 14);
            this.txtLCLCost.Text = "LCL Cost";
            this.txtLCLCost.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // txtCurrency
            // 
            this.txtCurrency.Font = new System.Drawing.Font("Arial Unicode MS", 7F);
            this.txtCurrency.Location = new System.Drawing.Point(200, 15);
            this.txtCurrency.Name = "txtCurrency";
            this.txtCurrency.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.txtCurrency.ParentStyleUsing.UseFont = false;
            this.txtCurrency.Size = new System.Drawing.Size(50, 14);
            this.txtCurrency.Text = "Currency";
            this.txtCurrency.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // txtUnitCost
            // 
            this.txtUnitCost.Font = new System.Drawing.Font("Arial Unicode MS", 7F);
            this.txtUnitCost.Location = new System.Drawing.Point(150, 15);
            this.txtUnitCost.Name = "txtUnitCost";
            this.txtUnitCost.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.txtUnitCost.ParentStyleUsing.UseFont = false;
            this.txtUnitCost.Size = new System.Drawing.Size(50, 14);
            this.txtUnitCost.Text = "Unit Cost";
            this.txtUnitCost.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // txtSupplier
            // 
            this.txtSupplier.Font = new System.Drawing.Font("Arial Unicode MS", 7F);
            this.txtSupplier.Location = new System.Drawing.Point(0, 0);
            this.txtSupplier.Name = "txtSupplier";
            this.txtSupplier.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.txtSupplier.ParentStyleUsing.UseFont = false;
            this.txtSupplier.Size = new System.Drawing.Size(250, 14);
            this.txtSupplier.Text = "Supplier";
            // 
            // ProductListXrSupplier
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail});
            this.Margins = new System.Drawing.Printing.Margins(0, 0, 0, 0);
            this.PageWidth = 250;
            this.PaperKind = System.Drawing.Printing.PaperKind.Custom;
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.XRPanel paneDetail;
        private DevExpress.XtraReports.UI.XRLabel txtFCLCost;
        private DevExpress.XtraReports.UI.XRLabel txtSuppRef;
        private DevExpress.XtraReports.UI.XRLabel txtLCLCost;
        private DevExpress.XtraReports.UI.XRLabel txtCurrency;
        private DevExpress.XtraReports.UI.XRLabel txtUnitCost;
        private DevExpress.XtraReports.UI.XRLabel txtSupplier;
    }
}
