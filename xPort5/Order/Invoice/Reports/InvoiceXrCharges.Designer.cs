namespace xPort5.Order.Invoice.Reports
{
    partial class InvoiceXrCharges
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
            this.lblDescription = new DevExpress.XtraReports.UI.XRLabel();
            this.txtAmount = new DevExpress.XtraReports.UI.XRLabel();
            this.PageHeader = new DevExpress.XtraReports.UI.PageHeaderBand();
            this.PageFooter = new DevExpress.XtraReports.UI.PageFooterBand();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.lblDescription,
            this.txtAmount});
            this.Detail.Height = 20;
            this.Detail.Name = "Detail";
            this.Detail.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.Detail_BeforePrint);
            // 
            // lblDescription
            // 
            this.lblDescription.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(0, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblDescription.ParentStyleUsing.UseFont = false;
            this.lblDescription.Size = new System.Drawing.Size(545, 20);
            this.lblDescription.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // txtAmount
            // 
            this.txtAmount.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmount.Location = new System.Drawing.Point(550, 0);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.txtAmount.ParentStyleUsing.UseFont = false;
            this.txtAmount.Size = new System.Drawing.Size(80, 20);
            this.txtAmount.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // PageHeader
            // 
            this.PageHeader.Height = 0;
            this.PageHeader.Name = "PageHeader";
            // 
            // PageFooter
            // 
            this.PageFooter.Height = 0;
            this.PageFooter.Name = "PageFooter";
            // 
            // InvoiceXrCharges
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.PageHeader,
            this.PageFooter});
            this.Margins = new System.Drawing.Printing.Margins(0, 0, 0, 0);
            this.PageHeight = 1169;
            this.PageWidth = 630;
            this.PaperKind = System.Drawing.Printing.PaperKind.Custom;
            this.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.InvoiceXrCharges_BeforePrint);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.PageHeaderBand PageHeader;
        private DevExpress.XtraReports.UI.PageFooterBand PageFooter;
        private DevExpress.XtraReports.UI.XRLabel txtAmount;
        private DevExpress.XtraReports.UI.XRLabel lblDescription;
    }
}
