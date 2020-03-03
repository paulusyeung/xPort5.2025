namespace xPort5.Order.PreOrder.Reports
{
    partial class ShipmentSchedule_Supplier
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
            this.PageHeader = new DevExpress.XtraReports.UI.PageHeaderBand();
            this.PageFooter = new DevExpress.XtraReports.UI.PageFooterBand();
            this.txtShippedOn = new DevExpress.XtraReports.UI.XRLabel();
            this.txtShippedQty = new DevExpress.XtraReports.UI.XRLabel();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.txtShippedQty,
            this.txtShippedOn});
            this.Detail.Height = 20;
            this.Detail.Name = "Detail";
            this.Detail.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.Detail_BeforePrint);
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
            // txtShippedOn
            // 
            this.txtShippedOn.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtShippedOn.Location = new System.Drawing.Point(0, 0);
            this.txtShippedOn.Name = "txtShippedOn";
            this.txtShippedOn.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.txtShippedOn.ParentStyleUsing.UseFont = false;
            this.txtShippedOn.Size = new System.Drawing.Size(134, 20);
            this.txtShippedOn.Text = "txtShippedOn";
            // 
            // txtShippedQty
            // 
            this.txtShippedQty.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtShippedQty.Location = new System.Drawing.Point(134, 0);
            this.txtShippedQty.Name = "txtShippedQty";
            this.txtShippedQty.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.txtShippedQty.ParentStyleUsing.UseFont = false;
            this.txtShippedQty.Size = new System.Drawing.Size(75, 20);
            this.txtShippedQty.Text = "txtShippedQty";
            this.txtShippedQty.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // ShipmentSchedule_Supplier
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.PageHeader,
            this.PageFooter});
            this.Margins = new System.Drawing.Printing.Margins(0, 0, 0, 0);
            this.PageWidth = 210;
            this.PaperKind = System.Drawing.Printing.PaperKind.Custom;
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.PageHeaderBand PageHeader;
        private DevExpress.XtraReports.UI.PageFooterBand PageFooter;
        private DevExpress.XtraReports.UI.XRLabel txtShippedQty;
        private DevExpress.XtraReports.UI.XRLabel txtShippedOn;
    }
}
