namespace xPort5.Order.SalesContract.Reports
{
    partial class SalesContractXrShipment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalesContractXrShipment));
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.lblQtyShipped = new DevExpress.XtraReports.UI.XRLabel();
            this.txtShippedOn = new DevExpress.XtraReports.UI.XRRichText();
            this.txtShipment = new DevExpress.XtraReports.UI.XRRichText();
            ((System.ComponentModel.ISupportInitialize)(this.txtShippedOn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtShipment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.lblQtyShipped,
            this.txtShippedOn,
            this.txtShipment});
            this.Detail.Height = 20;
            this.Detail.Name = "Detail";
            this.Detail.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.Detail_BeforePrint);
            // 
            // lblQtyShipped
            // 
            this.lblQtyShipped.Location = new System.Drawing.Point(220, 0);
            this.lblQtyShipped.Name = "lblQtyShipped";
            this.lblQtyShipped.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblQtyShipped.Size = new System.Drawing.Size(70, 20);
            this.lblQtyShipped.Text = "lblQtyShipped";
            this.lblQtyShipped.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // txtShippedOn
            // 
            this.txtShippedOn.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtShippedOn.Location = new System.Drawing.Point(67, 0);
            this.txtShippedOn.Name = "txtShippedOn";
            this.txtShippedOn.ParentStyleUsing.UseFont = false;
            this.txtShippedOn.Size = new System.Drawing.Size(150, 20);
            // 
            // txtShipment
            // 
            this.txtShipment.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtShipment.Location = new System.Drawing.Point(0, 0);
            this.txtShipment.Name = "txtShipment";
            this.txtShipment.ParentStyleUsing.UseFont = false;
            this.txtShipment.RtfText = ((DevExpress.XtraReports.UI.SerializableString)(resources.GetObject("txtShipment.RtfText")));
            this.txtShipment.Size = new System.Drawing.Size(70, 20);
            // 
            // SalesContractXrShipment
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail});
            this.Font = new System.Drawing.Font("Arial", 9.75F);
            this.Margins = new System.Drawing.Printing.Margins(0, 0, 0, 0);
            this.PageWidth = 290;
            this.PaperKind = System.Drawing.Printing.PaperKind.Custom;
            ((System.ComponentModel.ISupportInitialize)(this.txtShippedOn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtShipment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.XRRichText txtShippedOn;
        private DevExpress.XtraReports.UI.XRRichText txtShipment;
        private DevExpress.XtraReports.UI.XRLabel lblQtyShipped;
    }
}
