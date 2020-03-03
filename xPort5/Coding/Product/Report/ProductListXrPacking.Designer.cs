namespace xPort5.Coding.Product.Report
{
    partial class ProductListXrPacking
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
            this.txtContainer = new DevExpress.XtraReports.UI.XRLabel();
            this.txtTotalQty = new DevExpress.XtraReports.UI.XRLabel();
            this.txtNet = new DevExpress.XtraReports.UI.XRLabel();
            this.txtGross = new DevExpress.XtraReports.UI.XRLabel();
            this.txtCUFT = new DevExpress.XtraReports.UI.XRLabel();
            this.txtHeight = new DevExpress.XtraReports.UI.XRLabel();
            this.txtWidth = new DevExpress.XtraReports.UI.XRLabel();
            this.txtLength = new DevExpress.XtraReports.UI.XRLabel();
            this.txtOuterBox = new DevExpress.XtraReports.UI.XRLabel();
            this.txtInnerBox = new DevExpress.XtraReports.UI.XRLabel();
            this.txtUnit = new DevExpress.XtraReports.UI.XRLabel();
            this.txtPacking = new DevExpress.XtraReports.UI.XRLabel();
            this.paneDetail = new DevExpress.XtraReports.UI.XRPanel();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.paneDetail});
            this.Detail.Height = 46;
            this.Detail.Name = "Detail";
            this.Detail.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.Detail_BeforePrint);
            // 
            // txtContainer
            // 
            this.txtContainer.Font = new System.Drawing.Font("Arial Unicode MS", 7F);
            this.txtContainer.Location = new System.Drawing.Point(300, 31);
            this.txtContainer.Name = "txtContainer";
            this.txtContainer.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.txtContainer.ParentStyleUsing.UseFont = false;
            this.txtContainer.Size = new System.Drawing.Size(50, 14);
            this.txtContainer.Text = "Container";
            this.txtContainer.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // txtTotalQty
            // 
            this.txtTotalQty.Font = new System.Drawing.Font("Arial Unicode MS", 7F);
            this.txtTotalQty.Location = new System.Drawing.Point(250, 31);
            this.txtTotalQty.Name = "txtTotalQty";
            this.txtTotalQty.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.txtTotalQty.ParentStyleUsing.UseFont = false;
            this.txtTotalQty.Size = new System.Drawing.Size(50, 14);
            this.txtTotalQty.Text = "Total Qty";
            this.txtTotalQty.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // txtNet
            // 
            this.txtNet.Font = new System.Drawing.Font("Arial Unicode MS", 7F);
            this.txtNet.Location = new System.Drawing.Point(200, 31);
            this.txtNet.Name = "txtNet";
            this.txtNet.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.txtNet.ParentStyleUsing.UseFont = false;
            this.txtNet.Size = new System.Drawing.Size(50, 14);
            this.txtNet.Text = "Net";
            this.txtNet.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // txtGross
            // 
            this.txtGross.Font = new System.Drawing.Font("Arial Unicode MS", 7F);
            this.txtGross.Location = new System.Drawing.Point(150, 31);
            this.txtGross.Name = "txtGross";
            this.txtGross.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.txtGross.ParentStyleUsing.UseFont = false;
            this.txtGross.Size = new System.Drawing.Size(50, 14);
            this.txtGross.Text = "Gross";
            this.txtGross.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // txtCUFT
            // 
            this.txtCUFT.Font = new System.Drawing.Font("Arial Unicode MS", 7F);
            this.txtCUFT.Location = new System.Drawing.Point(300, 15);
            this.txtCUFT.Name = "txtCUFT";
            this.txtCUFT.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.txtCUFT.ParentStyleUsing.UseFont = false;
            this.txtCUFT.Size = new System.Drawing.Size(50, 14);
            this.txtCUFT.Text = "CUFT";
            this.txtCUFT.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // txtHeight
            // 
            this.txtHeight.Font = new System.Drawing.Font("Arial Unicode MS", 7F);
            this.txtHeight.Location = new System.Drawing.Point(250, 15);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.txtHeight.ParentStyleUsing.UseFont = false;
            this.txtHeight.Size = new System.Drawing.Size(50, 14);
            this.txtHeight.Text = "Height";
            this.txtHeight.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // txtWidth
            // 
            this.txtWidth.Font = new System.Drawing.Font("Arial Unicode MS", 7F);
            this.txtWidth.Location = new System.Drawing.Point(200, 15);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.txtWidth.ParentStyleUsing.UseFont = false;
            this.txtWidth.Size = new System.Drawing.Size(50, 14);
            this.txtWidth.Text = "Width";
            this.txtWidth.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // txtLength
            // 
            this.txtLength.Font = new System.Drawing.Font("Arial Unicode MS", 7F);
            this.txtLength.Location = new System.Drawing.Point(150, 15);
            this.txtLength.Name = "txtLength";
            this.txtLength.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.txtLength.ParentStyleUsing.UseFont = false;
            this.txtLength.Size = new System.Drawing.Size(50, 14);
            this.txtLength.Text = "Length";
            this.txtLength.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // txtOuterBox
            // 
            this.txtOuterBox.Font = new System.Drawing.Font("Arial Unicode MS", 7F);
            this.txtOuterBox.Location = new System.Drawing.Point(100, 15);
            this.txtOuterBox.Name = "txtOuterBox";
            this.txtOuterBox.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.txtOuterBox.ParentStyleUsing.UseFont = false;
            this.txtOuterBox.Size = new System.Drawing.Size(50, 14);
            this.txtOuterBox.Text = "Outer Box";
            this.txtOuterBox.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // txtInnerBox
            // 
            this.txtInnerBox.Font = new System.Drawing.Font("Arial Unicode MS", 7F);
            this.txtInnerBox.Location = new System.Drawing.Point(50, 15);
            this.txtInnerBox.Name = "txtInnerBox";
            this.txtInnerBox.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.txtInnerBox.ParentStyleUsing.UseFont = false;
            this.txtInnerBox.Size = new System.Drawing.Size(50, 14);
            this.txtInnerBox.Text = "Inner Box";
            this.txtInnerBox.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // txtUnit
            // 
            this.txtUnit.Font = new System.Drawing.Font("Arial Unicode MS", 7F);
            this.txtUnit.Location = new System.Drawing.Point(0, 15);
            this.txtUnit.Name = "txtUnit";
            this.txtUnit.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.txtUnit.ParentStyleUsing.UseFont = false;
            this.txtUnit.Size = new System.Drawing.Size(50, 14);
            this.txtUnit.Text = "Unit";
            this.txtUnit.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // txtPacking
            // 
            this.txtPacking.Font = new System.Drawing.Font("Arial Unicode MS", 7F);
            this.txtPacking.Location = new System.Drawing.Point(0, 0);
            this.txtPacking.Name = "txtPacking";
            this.txtPacking.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.txtPacking.ParentStyleUsing.UseFont = false;
            this.txtPacking.Size = new System.Drawing.Size(350, 14);
            this.txtPacking.Text = "Packing";
            // 
            // paneDetail
            // 
            this.paneDetail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.txtContainer,
            this.txtTotalQty,
            this.txtNet,
            this.txtGross,
            this.txtCUFT,
            this.txtHeight,
            this.txtWidth,
            this.txtPacking,
            this.txtOuterBox,
            this.txtInnerBox,
            this.txtUnit,
            this.txtLength});
            this.paneDetail.Location = new System.Drawing.Point(0, 0);
            this.paneDetail.Name = "paneDetail";
            this.paneDetail.Size = new System.Drawing.Size(350, 46);
            // 
            // ProductListXrPacking
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail});
            this.Margins = new System.Drawing.Printing.Margins(0, 0, 0, 0);
            this.PageHeight = 100;
            this.PageWidth = 350;
            this.PaperKind = System.Drawing.Printing.PaperKind.Custom;
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.XRLabel txtContainer;
        private DevExpress.XtraReports.UI.XRLabel txtTotalQty;
        private DevExpress.XtraReports.UI.XRLabel txtNet;
        private DevExpress.XtraReports.UI.XRLabel txtGross;
        private DevExpress.XtraReports.UI.XRLabel txtCUFT;
        private DevExpress.XtraReports.UI.XRLabel txtHeight;
        private DevExpress.XtraReports.UI.XRLabel txtWidth;
        private DevExpress.XtraReports.UI.XRLabel txtLength;
        private DevExpress.XtraReports.UI.XRLabel txtOuterBox;
        private DevExpress.XtraReports.UI.XRLabel txtInnerBox;
        private DevExpress.XtraReports.UI.XRLabel txtUnit;
        private DevExpress.XtraReports.UI.XRLabel txtPacking;
        private DevExpress.XtraReports.UI.XRPanel paneDetail;
    }
}
