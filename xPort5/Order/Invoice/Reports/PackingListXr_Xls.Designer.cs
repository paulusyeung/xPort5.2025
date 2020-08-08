namespace xPort5.Order.Invoice.Reports
{
    partial class PackingListXr_Xls
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

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PackingListXr_Xls));
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.txtWeightNet = new DevExpress.XtraReports.UI.XRLabel();
            this.txtWeightGross = new DevExpress.XtraReports.UI.XRLabel();
            this.txtQty = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLine1 = new DevExpress.XtraReports.UI.XRLine();
            this.txtArticleCode = new DevExpress.XtraReports.UI.XRRichText();
            this.txtSize = new DevExpress.XtraReports.UI.XRRichText();
            this.txtColor = new DevExpress.XtraReports.UI.XRRichText();
            this.txtUnit = new DevExpress.XtraReports.UI.XRLabel();
            this.txtArticleName = new DevExpress.XtraReports.UI.XRRichText();
            this.txtShippingMark = new DevExpress.XtraReports.UI.XRRichText();
            this.PageHeader = new DevExpress.XtraReports.UI.PageHeaderBand();
            this.txtHeader = new DevExpress.XtraReports.UI.XRRichText();
            this.PageFooter = new DevExpress.XtraReports.UI.PageFooterBand();
            this.GroupHeader1 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.xrLabel16 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel14 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel13 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel12 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel11 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel10 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel9 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel8 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel7 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
            this.txt = new DevExpress.XtraReports.UI.XRLabel();
            this.GroupHeader2 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.txtNo = new DevExpress.XtraReports.UI.XRRichText();
            this.xrLabel5 = new DevExpress.XtraReports.UI.XRLabel();
            this.txtCustAddr = new DevExpress.XtraReports.UI.XRRichText();
            this.txtCustName = new DevExpress.XtraReports.UI.XRRichText();
            this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
            this.txtINDate = new DevExpress.XtraReports.UI.XRRichText();
            this.txtINNumber = new DevExpress.XtraReports.UI.XRRichText();
            this.GroupHeader3 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.xrLabel15 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel17 = new DevExpress.XtraReports.UI.XRLabel();
            this.txtCarrier = new DevExpress.XtraReports.UI.XRRichText();
            this.txtBoardDate = new DevExpress.XtraReports.UI.XRRichText();
            this.txtRemarks = new DevExpress.XtraReports.UI.XRRichText();
            this.topMarginBand1 = new DevExpress.XtraReports.UI.TopMarginBand();
            this.bottomMarginBand1 = new DevExpress.XtraReports.UI.BottomMarginBand();
            ((System.ComponentModel.ISupportInitialize)(this.txtArticleCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtArticleName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtShippingMark)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHeader)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCustAddr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCustName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtINDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtINNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCarrier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBoardDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRemarks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.txtWeightNet,
            this.txtWeightGross,
            this.txtQty,
            this.xrLine1,
            this.txtArticleCode,
            this.txtSize,
            this.txtColor,
            this.txtUnit,
            this.txtArticleName,
            this.txtShippingMark});
            this.Detail.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.Detail.HeightF = 90F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.Detail.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.Detail_BeforePrint);
            // 
            // txtWeightNet
            // 
            this.txtWeightNet.Font = new System.Drawing.Font("Arial", 9.75F);
            this.txtWeightNet.LocationFloat = new DevExpress.Utils.PointFloat(684F, 0F);
            this.txtWeightNet.Name = "txtWeightNet";
            this.txtWeightNet.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.txtWeightNet.SizeF = new System.Drawing.SizeF(67F, 17F);
            this.txtWeightNet.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // txtWeightGross
            // 
            this.txtWeightGross.Font = new System.Drawing.Font("Arial", 9.75F);
            this.txtWeightGross.LocationFloat = new DevExpress.Utils.PointFloat(622F, 0F);
            this.txtWeightGross.Name = "txtWeightGross";
            this.txtWeightGross.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.txtWeightGross.SizeF = new System.Drawing.SizeF(62F, 17F);
            this.txtWeightGross.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // txtQty
            // 
            this.txtQty.Font = new System.Drawing.Font("Arial", 9.75F);
            this.txtQty.LocationFloat = new DevExpress.Utils.PointFloat(442F, 0F);
            this.txtQty.Name = "txtQty";
            this.txtQty.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.txtQty.SizeF = new System.Drawing.SizeF(40F, 17F);
            this.txtQty.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // xrLine1
            // 
            this.xrLine1.LocationFloat = new DevExpress.Utils.PointFloat(108F, 77F);
            this.xrLine1.Name = "xrLine1";
            this.xrLine1.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.xrLine1.SizeF = new System.Drawing.SizeF(642F, 9F);
            // 
            // txtArticleCode
            // 
            this.txtArticleCode.Font = new System.Drawing.Font("Arial", 9.75F);
            this.txtArticleCode.LocationFloat = new DevExpress.Utils.PointFloat(242F, 0F);
            this.txtArticleCode.Name = "txtArticleCode";
            this.txtArticleCode.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.txtArticleCode.SizeF = new System.Drawing.SizeF(200F, 17F);
            // 
            // txtSize
            // 
            this.txtSize.Font = new System.Drawing.Font("Arial", 9.75F);
            this.txtSize.LocationFloat = new DevExpress.Utils.PointFloat(522F, 0F);
            this.txtSize.Name = "txtSize";
            this.txtSize.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.txtSize.SizeF = new System.Drawing.SizeF(100F, 17F);
            // 
            // txtColor
            // 
            this.txtColor.Font = new System.Drawing.Font("Arial", 9.75F);
            this.txtColor.LocationFloat = new DevExpress.Utils.PointFloat(242F, 57F);
            this.txtColor.Name = "txtColor";
            this.txtColor.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.txtColor.SizeF = new System.Drawing.SizeF(200F, 20F);
            // 
            // txtUnit
            // 
            this.txtUnit.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUnit.LocationFloat = new DevExpress.Utils.PointFloat(482F, 0F);
            this.txtUnit.Name = "txtUnit";
            this.txtUnit.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.txtUnit.SizeF = new System.Drawing.SizeF(40F, 17F);
            this.txtUnit.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // txtArticleName
            // 
            this.txtArticleName.Font = new System.Drawing.Font("Arial", 9.75F);
            this.txtArticleName.LocationFloat = new DevExpress.Utils.PointFloat(242F, 17F);
            this.txtArticleName.Name = "txtArticleName";
            this.txtArticleName.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.txtArticleName.SizeF = new System.Drawing.SizeF(200F, 40F);
            // 
            // txtShippingMark
            // 
            this.txtShippingMark.Font = new System.Drawing.Font("Arial", 9.75F);
            this.txtShippingMark.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.txtShippingMark.Name = "txtShippingMark";
            this.txtShippingMark.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.txtShippingMark.SizeF = new System.Drawing.SizeF(108F, 25F);
            // 
            // PageHeader
            // 
            this.PageHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.txtHeader});
            this.PageHeader.HeightF = 100F;
            this.PageHeader.Name = "PageHeader";
            this.PageHeader.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.PageHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // txtHeader
            // 
            this.txtHeader.Font = new System.Drawing.Font("Arial", 9.75F);
            this.txtHeader.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.txtHeader.Name = "txtHeader";
            this.txtHeader.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.txtHeader.SizeF = new System.Drawing.SizeF(750F, 100F);
            this.txtHeader.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.txtHeader_BeforePrint);
            // 
            // PageFooter
            // 
            this.PageFooter.HeightF = 0F;
            this.PageFooter.Name = "PageFooter";
            this.PageFooter.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.PageFooter.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // GroupHeader1
            // 
            this.GroupHeader1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel16,
            this.xrLabel14,
            this.xrLabel13,
            this.xrLabel12,
            this.xrLabel1,
            this.xrLabel11,
            this.xrLabel10,
            this.xrLabel9,
            this.xrLabel8,
            this.xrLabel7,
            this.xrLabel2,
            this.txt});
            this.GroupHeader1.HeightF = 42F;
            this.GroupHeader1.Name = "GroupHeader1";
            this.GroupHeader1.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.GroupHeader1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLabel16
            // 
            this.xrLabel16.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel16.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrLabel16.LocationFloat = new DevExpress.Utils.PointFloat(622F, 18F);
            this.xrLabel16.Name = "xrLabel16";
            this.xrLabel16.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel16.SizeF = new System.Drawing.SizeF(62F, 20F);
            this.xrLabel16.Text = "IN KGS";
            this.xrLabel16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLabel14
            // 
            this.xrLabel14.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel14.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrLabel14.LocationFloat = new DevExpress.Utils.PointFloat(684F, 18F);
            this.xrLabel14.Name = "xrLabel14";
            this.xrLabel14.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel14.SizeF = new System.Drawing.SizeF(67F, 20F);
            this.xrLabel14.Text = "IN KGS";
            this.xrLabel14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLabel13
            // 
            this.xrLabel13.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel13.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrLabel13.LocationFloat = new DevExpress.Utils.PointFloat(522F, 18F);
            this.xrLabel13.Name = "xrLabel13";
            this.xrLabel13.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel13.SizeF = new System.Drawing.SizeF(100F, 20F);
            this.xrLabel13.Text = "IN CM";
            this.xrLabel13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLabel12
            // 
            this.xrLabel12.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrLabel12.LocationFloat = new DevExpress.Utils.PointFloat(117F, 18F);
            this.xrLabel12.Name = "xrLabel12";
            this.xrLabel12.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel12.SizeF = new System.Drawing.SizeF(41F, 20F);
            this.xrLabel12.Text = "NO.";
            this.xrLabel12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLabel1
            // 
            this.xrLabel1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(684F, 0F);
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel1.SizeF = new System.Drawing.SizeF(67F, 18F);
            this.xrLabel1.Text = "N.W.";
            this.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLabel11
            // 
            this.xrLabel11.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrLabel11.LocationFloat = new DevExpress.Utils.PointFloat(622F, 0F);
            this.xrLabel11.Name = "xrLabel11";
            this.xrLabel11.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel11.SizeF = new System.Drawing.SizeF(62F, 18F);
            this.xrLabel11.Text = "G.W.";
            this.xrLabel11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLabel10
            // 
            this.xrLabel10.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrLabel10.LocationFloat = new DevExpress.Utils.PointFloat(522F, 0F);
            this.xrLabel10.Name = "xrLabel10";
            this.xrLabel10.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel10.SizeF = new System.Drawing.SizeF(100F, 18F);
            this.xrLabel10.Text = "MEAS.";
            this.xrLabel10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLabel9
            // 
            this.xrLabel9.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrLabel9.LocationFloat = new DevExpress.Utils.PointFloat(442F, 18F);
            this.xrLabel9.Name = "xrLabel9";
            this.xrLabel9.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel9.SizeF = new System.Drawing.SizeF(80F, 20F);
            this.xrLabel9.Text = "QTY/PKG";
            this.xrLabel9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLabel8
            // 
            this.xrLabel8.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrLabel8.LocationFloat = new DevExpress.Utils.PointFloat(242F, 18F);
            this.xrLabel8.Name = "xrLabel8";
            this.xrLabel8.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel8.SizeF = new System.Drawing.SizeF(183F, 20F);
            this.xrLabel8.Text = "DESCRIPTION OF GOODS";
            this.xrLabel8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLabel7
            // 
            this.xrLabel7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrLabel7.LocationFloat = new DevExpress.Utils.PointFloat(158F, 18F);
            this.xrLabel7.Name = "xrLabel7";
            this.xrLabel7.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel7.SizeF = new System.Drawing.SizeF(84F, 20F);
            this.xrLabel7.Text = "NO. OF PK";
            this.xrLabel7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLabel2
            // 
            this.xrLabel2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(117F, 0F);
            this.xrLabel2.Name = "xrLabel2";
            this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel2.SizeF = new System.Drawing.SizeF(41F, 18F);
            this.xrLabel2.Text = "CTN.";
            this.xrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // txt
            // 
            this.txt.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.txt.LocationFloat = new DevExpress.Utils.PointFloat(0F, 18F);
            this.txt.Name = "txt";
            this.txt.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.txt.SizeF = new System.Drawing.SizeF(117F, 20F);
            this.txt.Text = "MARKS & NOS.";
            this.txt.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // GroupHeader2
            // 
            this.GroupHeader2.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.txtNo});
            this.GroupHeader2.HeightF = 22F;
            this.GroupHeader2.Level = 1;
            this.GroupHeader2.Name = "GroupHeader2";
            this.GroupHeader2.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.GroupHeader2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.GroupHeader2.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.GroupHeader2_BeforePrint);
            // 
            // txtNo
            // 
            this.txtNo.Font = new System.Drawing.Font("Arial", 9.75F);
            this.txtNo.LocationFloat = new DevExpress.Utils.PointFloat(17F, 0F);
            this.txtNo.Name = "txtNo";
            this.txtNo.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.txtNo.SizeF = new System.Drawing.SizeF(366F, 20F);
            // 
            // xrLabel5
            // 
            this.xrLabel5.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.xrLabel5.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrLabel5.Name = "xrLabel5";
            this.xrLabel5.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel5.SizeF = new System.Drawing.SizeF(750F, 33F);
            this.xrLabel5.Text = "PACKING LIST";
            this.xrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // txtCustAddr
            // 
            this.txtCustAddr.CanGrow = false;
            this.txtCustAddr.Font = new System.Drawing.Font("Arial", 9.75F);
            this.txtCustAddr.LocationFloat = new DevExpress.Utils.PointFloat(17F, 62F);
            this.txtCustAddr.Name = "txtCustAddr";
            this.txtCustAddr.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.txtCustAddr.SizeF = new System.Drawing.SizeF(366F, 66F);
            // 
            // txtCustName
            // 
            this.txtCustName.Font = new System.Drawing.Font("Arial", 9.75F);
            this.txtCustName.LocationFloat = new DevExpress.Utils.PointFloat(17F, 42F);
            this.txtCustName.Name = "txtCustName";
            this.txtCustName.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.txtCustName.SizeF = new System.Drawing.SizeF(366F, 20F);
            // 
            // xrLabel3
            // 
            this.xrLabel3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel3.LocationFloat = new DevExpress.Utils.PointFloat(425F, 42F);
            this.xrLabel3.Name = "xrLabel3";
            this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel3.SizeF = new System.Drawing.SizeF(133F, 20F);
            this.xrLabel3.Text = "PACKING LIST NO.";
            this.xrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLabel4
            // 
            this.xrLabel4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel4.LocationFloat = new DevExpress.Utils.PointFloat(425F, 62F);
            this.xrLabel4.Name = "xrLabel4";
            this.xrLabel4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel4.SizeF = new System.Drawing.SizeF(133F, 20F);
            this.xrLabel4.Text = "DATE";
            this.xrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // txtINDate
            // 
            this.txtINDate.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtINDate.LocationFloat = new DevExpress.Utils.PointFloat(558F, 62F);
            this.txtINDate.Name = "txtINDate";
            this.txtINDate.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.txtINDate.SizeF = new System.Drawing.SizeF(192F, 20F);
            // 
            // txtINNumber
            // 
            this.txtINNumber.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtINNumber.LocationFloat = new DevExpress.Utils.PointFloat(558F, 42F);
            this.txtINNumber.Name = "txtINNumber";
            this.txtINNumber.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.txtINNumber.SizeF = new System.Drawing.SizeF(192F, 20F);
            // 
            // GroupHeader3
            // 
            this.GroupHeader3.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel15,
            this.xrLabel17,
            this.txtCarrier,
            this.txtBoardDate,
            this.txtRemarks,
            this.txtINNumber,
            this.txtCustAddr,
            this.txtCustName,
            this.xrLabel3,
            this.xrLabel4,
            this.txtINDate,
            this.xrLabel5});
            this.GroupHeader3.HeightF = 146F;
            this.GroupHeader3.Level = 2;
            this.GroupHeader3.Name = "GroupHeader3";
            this.GroupHeader3.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.GroupHeader3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.GroupHeader3.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.GroupHeader3_BeforePrint);
            // 
            // xrLabel15
            // 
            this.xrLabel15.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrLabel15.LocationFloat = new DevExpress.Utils.PointFloat(425F, 83F);
            this.xrLabel15.Name = "xrLabel15";
            this.xrLabel15.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel15.SizeF = new System.Drawing.SizeF(133F, 20F);
            this.xrLabel15.Text = "Carrier";
            this.xrLabel15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLabel17
            // 
            this.xrLabel17.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrLabel17.LocationFloat = new DevExpress.Utils.PointFloat(425F, 104F);
            this.xrLabel17.Name = "xrLabel17";
            this.xrLabel17.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel17.SizeF = new System.Drawing.SizeF(133F, 20F);
            this.xrLabel17.Text = "On Board Date";
            this.xrLabel17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // txtCarrier
            // 
            this.txtCarrier.CanGrow = false;
            this.txtCarrier.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCarrier.LocationFloat = new DevExpress.Utils.PointFloat(558F, 83F);
            this.txtCarrier.Name = "txtCarrier";
            this.txtCarrier.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.txtCarrier.SerializableRtfString = resources.GetString("txtCarrier.SerializableRtfString");
            this.txtCarrier.SizeF = new System.Drawing.SizeF(192F, 20F);
            // 
            // txtBoardDate
            // 
            this.txtBoardDate.CanGrow = false;
            this.txtBoardDate.Font = new System.Drawing.Font("Arial", 9.75F);
            this.txtBoardDate.LocationFloat = new DevExpress.Utils.PointFloat(558F, 104F);
            this.txtBoardDate.Name = "txtBoardDate";
            this.txtBoardDate.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.txtBoardDate.SerializableRtfString = resources.GetString("txtBoardDate.SerializableRtfString");
            this.txtBoardDate.SizeF = new System.Drawing.SizeF(192F, 20F);
            // 
            // txtRemarks
            // 
            this.txtRemarks.CanShrink = true;
            this.txtRemarks.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemarks.LocationFloat = new DevExpress.Utils.PointFloat(558F, 125F);
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.txtRemarks.SerializableRtfString = resources.GetString("txtRemarks.SerializableRtfString");
            this.txtRemarks.SizeF = new System.Drawing.SizeF(192F, 20F);
            // 
            // topMarginBand1
            // 
            this.topMarginBand1.HeightF = 50F;
            this.topMarginBand1.Name = "topMarginBand1";
            // 
            // bottomMarginBand1
            // 
            this.bottomMarginBand1.HeightF = 50F;
            this.bottomMarginBand1.Name = "bottomMarginBand1";
            // 
            // PackingListXr_Xls
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.PageHeader,
            this.PageFooter,
            this.GroupHeader1,
            this.GroupHeader2,
            this.GroupHeader3,
            this.topMarginBand1,
            this.bottomMarginBand1});
            this.Margins = new System.Drawing.Printing.Margins(50, 0, 50, 50);
            this.PageHeight = 1169;
            this.PageWidth = 827;
            this.PaperKind = System.Drawing.Printing.PaperKind.A4;
            this.Version = "15.2";
            ((System.ComponentModel.ISupportInitialize)(this.txtArticleCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtArticleName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtShippingMark)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHeader)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCustAddr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCustName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtINDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtINNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCarrier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBoardDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRemarks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.PageHeaderBand PageHeader;
        private DevExpress.XtraReports.UI.XRRichText txtHeader;
        private DevExpress.XtraReports.UI.PageFooterBand PageFooter;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader1;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader2;
        private DevExpress.XtraReports.UI.XRLabel xrLabel5;
        private DevExpress.XtraReports.UI.XRRichText txtCustAddr;
        private DevExpress.XtraReports.UI.XRRichText txtCustName;
        private DevExpress.XtraReports.UI.XRLabel xrLabel3;
        private DevExpress.XtraReports.UI.XRLabel xrLabel4;
        private DevExpress.XtraReports.UI.XRRichText txtINDate;
        private DevExpress.XtraReports.UI.XRRichText txtINNumber;

        #region Designer generated code


        #endregion

        private DevExpress.XtraReports.UI.XRRichText txtNo;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader3;
        private DevExpress.XtraReports.UI.XRRichText txtShippingMark;
        private DevExpress.XtraReports.UI.XRLabel xrLabel14;
        private DevExpress.XtraReports.UI.XRLabel xrLabel13;
        private DevExpress.XtraReports.UI.XRLabel xrLabel12;
        private DevExpress.XtraReports.UI.XRLabel xrLabel1;
        private DevExpress.XtraReports.UI.XRLabel xrLabel11;
        private DevExpress.XtraReports.UI.XRLabel xrLabel10;
        private DevExpress.XtraReports.UI.XRLabel xrLabel9;
        private DevExpress.XtraReports.UI.XRLabel xrLabel8;
        private DevExpress.XtraReports.UI.XRLabel xrLabel7;
        private DevExpress.XtraReports.UI.XRLabel xrLabel2;
        private DevExpress.XtraReports.UI.XRLabel txt;
        private DevExpress.XtraReports.UI.XRRichText txtSize;
        private DevExpress.XtraReports.UI.XRRichText txtColor;
        private DevExpress.XtraReports.UI.XRLabel txtUnit;
        private DevExpress.XtraReports.UI.XRRichText txtArticleName;
        private DevExpress.XtraReports.UI.XRLine xrLine1;
        private DevExpress.XtraReports.UI.XRRichText txtArticleCode;
        private DevExpress.XtraReports.UI.XRLabel xrLabel16;
        private DevExpress.XtraReports.UI.XRLabel txtWeightNet;
        private DevExpress.XtraReports.UI.XRLabel txtWeightGross;
        private DevExpress.XtraReports.UI.XRLabel txtQty;
        private DevExpress.XtraReports.UI.XRLabel xrLabel15;
        private DevExpress.XtraReports.UI.XRLabel xrLabel17;
        private DevExpress.XtraReports.UI.XRRichText txtCarrier;
        private DevExpress.XtraReports.UI.XRRichText txtBoardDate;
        private DevExpress.XtraReports.UI.XRRichText txtRemarks;
        private DevExpress.XtraReports.UI.TopMarginBand topMarginBand1;
        private DevExpress.XtraReports.UI.BottomMarginBand bottomMarginBand1;
    }
}
