namespace xPort5.Order.Invoice.Reports
{
    partial class PackingListXr_Pdf
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
            DevExpress.XtraPrinting.Shape.ShapeRectangle shapeRectangle5 = new DevExpress.XtraPrinting.Shape.ShapeRectangle();
            DevExpress.XtraPrinting.Shape.ShapeRectangle shapeRectangle6 = new DevExpress.XtraPrinting.Shape.ShapeRectangle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PackingListXr_Pdf));
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
            this.xrShape1 = new DevExpress.XtraReports.UI.XRShape();
            this.GroupHeader2 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.txtNo = new DevExpress.XtraReports.UI.XRRichText();
            this.xrLabel6 = new DevExpress.XtraReports.UI.XRLabel();
            this.txtPageInfo = new DevExpress.XtraReports.UI.XRPageInfo();
            this.xrLabel5 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrShape2 = new DevExpress.XtraReports.UI.XRShape();
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
            this.Detail.Height = 90;
            this.Detail.Name = "Detail";
            this.Detail.ParentStyleUsing.UseFont = false;
            this.Detail.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.Detail_BeforePrint);
            // 
            // txtWeightNet
            // 
            this.txtWeightNet.Font = new System.Drawing.Font("Arial", 9.75F);
            this.txtWeightNet.Location = new System.Drawing.Point(685, 0);
            this.txtWeightNet.Name = "txtWeightNet";
            this.txtWeightNet.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.txtWeightNet.ParentStyleUsing.UseFont = false;
            this.txtWeightNet.Size = new System.Drawing.Size(50, 17);
            this.txtWeightNet.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // txtWeightGross
            // 
            this.txtWeightGross.Font = new System.Drawing.Font("Arial", 9.75F);
            this.txtWeightGross.Location = new System.Drawing.Point(633, 0);
            this.txtWeightGross.Name = "txtWeightGross";
            this.txtWeightGross.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.txtWeightGross.ParentStyleUsing.UseFont = false;
            this.txtWeightGross.Size = new System.Drawing.Size(50, 17);
            this.txtWeightGross.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // txtQty
            // 
            this.txtQty.Font = new System.Drawing.Font("Arial", 9.75F);
            this.txtQty.Location = new System.Drawing.Point(442, 0);
            this.txtQty.Name = "txtQty";
            this.txtQty.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.txtQty.ParentStyleUsing.UseFont = false;
            this.txtQty.Size = new System.Drawing.Size(40, 17);
            this.txtQty.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // xrLine1
            // 
            this.xrLine1.Location = new System.Drawing.Point(108, 77);
            this.xrLine1.Name = "xrLine1";
            this.xrLine1.Size = new System.Drawing.Size(642, 9);
            // 
            // txtArticleCode
            // 
            this.txtArticleCode.Font = new System.Drawing.Font("Arial", 9.75F);
            this.txtArticleCode.Location = new System.Drawing.Point(242, 0);
            this.txtArticleCode.Name = "txtArticleCode";
            this.txtArticleCode.ParentStyleUsing.UseFont = false;
            this.txtArticleCode.Size = new System.Drawing.Size(200, 17);
            // 
            // txtSize
            // 
            this.txtSize.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F);
            this.txtSize.Location = new System.Drawing.Point(522, 0);
            this.txtSize.Name = "txtSize";
            this.txtSize.ParentStyleUsing.UseFont = false;
            this.txtSize.Size = new System.Drawing.Size(110, 17);
            // 
            // txtColor
            // 
            this.txtColor.Font = new System.Drawing.Font("Arial", 9.75F);
            this.txtColor.Location = new System.Drawing.Point(242, 57);
            this.txtColor.Name = "txtColor";
            this.txtColor.ParentStyleUsing.UseFont = false;
            this.txtColor.Size = new System.Drawing.Size(200, 20);
            // 
            // txtUnit
            // 
            this.txtUnit.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUnit.Location = new System.Drawing.Point(482, 0);
            this.txtUnit.Name = "txtUnit";
            this.txtUnit.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.txtUnit.ParentStyleUsing.UseFont = false;
            this.txtUnit.Size = new System.Drawing.Size(40, 17);
            // 
            // txtArticleName
            // 
            this.txtArticleName.Font = new System.Drawing.Font("Arial", 9.75F);
            this.txtArticleName.Location = new System.Drawing.Point(242, 17);
            this.txtArticleName.Name = "txtArticleName";
            this.txtArticleName.ParentStyleUsing.UseFont = false;
            this.txtArticleName.Size = new System.Drawing.Size(200, 40);
            // 
            // txtShippingMark
            // 
            this.txtShippingMark.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F);
            this.txtShippingMark.Location = new System.Drawing.Point(0, 0);
            this.txtShippingMark.Name = "txtShippingMark";
            this.txtShippingMark.ParentStyleUsing.UseFont = false;
            this.txtShippingMark.Size = new System.Drawing.Size(100, 25);
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
            this.txtHeader.Size = new System.Drawing.Size(750, 100);
            this.txtHeader.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.txtHeader_BeforePrint);
            // 
            // PageFooter
            // 
            this.PageFooter.Height = 0;
            this.PageFooter.Name = "PageFooter";
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
            this.txt,
            this.xrShape1});
            this.GroupHeader1.Height = 58;
            this.GroupHeader1.Name = "GroupHeader1";
            this.GroupHeader1.RepeatEveryPage = true;
            // 
            // xrLabel16
            // 
            this.xrLabel16.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel16.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrLabel16.Location = new System.Drawing.Point(625, 26);
            this.xrLabel16.Name = "xrLabel16";
            this.xrLabel16.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel16.ParentStyleUsing.UseBorders = false;
            this.xrLabel16.ParentStyleUsing.UseFont = false;
            this.xrLabel16.Size = new System.Drawing.Size(56, 18);
            this.xrLabel16.Text = "IN KGS";
            // 
            // xrLabel14
            // 
            this.xrLabel14.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel14.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrLabel14.Location = new System.Drawing.Point(685, 26);
            this.xrLabel14.Name = "xrLabel14";
            this.xrLabel14.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel14.ParentStyleUsing.UseBorders = false;
            this.xrLabel14.ParentStyleUsing.UseFont = false;
            this.xrLabel14.Size = new System.Drawing.Size(59, 18);
            this.xrLabel14.Text = "IN KGS";
            // 
            // xrLabel13
            // 
            this.xrLabel13.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel13.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrLabel13.Location = new System.Drawing.Point(522, 26);
            this.xrLabel13.Name = "xrLabel13";
            this.xrLabel13.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel13.ParentStyleUsing.UseBorders = false;
            this.xrLabel13.ParentStyleUsing.UseFont = false;
            this.xrLabel13.Size = new System.Drawing.Size(50, 18);
            this.xrLabel13.Text = "IN CM";
            // 
            // xrLabel12
            // 
            this.xrLabel12.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrLabel12.Location = new System.Drawing.Point(117, 26);
            this.xrLabel12.Name = "xrLabel12";
            this.xrLabel12.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel12.ParentStyleUsing.UseFont = false;
            this.xrLabel12.Size = new System.Drawing.Size(41, 18);
            this.xrLabel12.Text = "NO.";
            // 
            // xrLabel1
            // 
            this.xrLabel1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrLabel1.Location = new System.Drawing.Point(685, 8);
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel1.ParentStyleUsing.UseFont = false;
            this.xrLabel1.Size = new System.Drawing.Size(59, 18);
            this.xrLabel1.Text = "N.W.";
            // 
            // xrLabel11
            // 
            this.xrLabel11.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrLabel11.Location = new System.Drawing.Point(623, 8);
            this.xrLabel11.Name = "xrLabel11";
            this.xrLabel11.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel11.ParentStyleUsing.UseFont = false;
            this.xrLabel11.Size = new System.Drawing.Size(58, 18);
            this.xrLabel11.Text = "G.W.";
            // 
            // xrLabel10
            // 
            this.xrLabel10.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrLabel10.Location = new System.Drawing.Point(522, 8);
            this.xrLabel10.Name = "xrLabel10";
            this.xrLabel10.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel10.ParentStyleUsing.UseFont = false;
            this.xrLabel10.Size = new System.Drawing.Size(50, 18);
            this.xrLabel10.Text = "MEAS.";
            // 
            // xrLabel9
            // 
            this.xrLabel9.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrLabel9.Location = new System.Drawing.Point(442, 17);
            this.xrLabel9.Name = "xrLabel9";
            this.xrLabel9.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel9.ParentStyleUsing.UseFont = false;
            this.xrLabel9.Size = new System.Drawing.Size(80, 21);
            this.xrLabel9.Text = "QTY/PKG";
            // 
            // xrLabel8
            // 
            this.xrLabel8.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrLabel8.Location = new System.Drawing.Point(242, 17);
            this.xrLabel8.Name = "xrLabel8";
            this.xrLabel8.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel8.ParentStyleUsing.UseFont = false;
            this.xrLabel8.Size = new System.Drawing.Size(183, 21);
            this.xrLabel8.Text = "DESCRIPTION OF GOODS";
            // 
            // xrLabel7
            // 
            this.xrLabel7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrLabel7.Location = new System.Drawing.Point(158, 17);
            this.xrLabel7.Name = "xrLabel7";
            this.xrLabel7.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel7.ParentStyleUsing.UseFont = false;
            this.xrLabel7.Size = new System.Drawing.Size(84, 21);
            this.xrLabel7.Text = "NO. OF PK";
            // 
            // xrLabel2
            // 
            this.xrLabel2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrLabel2.Location = new System.Drawing.Point(117, 8);
            this.xrLabel2.Name = "xrLabel2";
            this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel2.ParentStyleUsing.UseFont = false;
            this.xrLabel2.Size = new System.Drawing.Size(41, 18);
            this.xrLabel2.Text = "CTN.";
            // 
            // txt
            // 
            this.txt.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.txt.Location = new System.Drawing.Point(0, 15);
            this.txt.Name = "txt";
            this.txt.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.txt.ParentStyleUsing.UseFont = false;
            this.txt.Size = new System.Drawing.Size(117, 20);
            this.txt.Text = "MARKS & NOS.";
            // 
            // xrShape1
            // 
            this.xrShape1.BackColor = System.Drawing.Color.Silver;
            this.xrShape1.Location = new System.Drawing.Point(0, 0);
            this.xrShape1.Name = "xrShape1";
            this.xrShape1.ParentStyleUsing.UseBackColor = false;
            this.xrShape1.ParentStyleUsing.UseBorders = false;
            this.xrShape1.Shape = shapeRectangle5;
            this.xrShape1.Size = new System.Drawing.Size(750, 58);
            // 
            // GroupHeader2
            // 
            this.GroupHeader2.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.txtNo,
            this.xrLabel6,
            this.txtPageInfo});
            this.GroupHeader2.Height = 22;
            this.GroupHeader2.Level = 1;
            this.GroupHeader2.Name = "GroupHeader2";
            this.GroupHeader2.RepeatEveryPage = true;
            this.GroupHeader2.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.GroupHeader2_BeforePrint);
            // 
            // txtNo
            // 
            this.txtNo.Font = new System.Drawing.Font("Arial", 9.75F);
            this.txtNo.Location = new System.Drawing.Point(17, 0);
            this.txtNo.Name = "txtNo";
            this.txtNo.ParentStyleUsing.UseFont = false;
            this.txtNo.Size = new System.Drawing.Size(366, 20);
            // 
            // xrLabel6
            // 
            this.xrLabel6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel6.Location = new System.Drawing.Point(425, 0);
            this.xrLabel6.Name = "xrLabel6";
            this.xrLabel6.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel6.ParentStyleUsing.UseFont = false;
            this.xrLabel6.Size = new System.Drawing.Size(133, 20);
            this.xrLabel6.Text = "PAGE";
            // 
            // txtPageInfo
            // 
            this.txtPageInfo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPageInfo.Location = new System.Drawing.Point(558, 0);
            this.txtPageInfo.Name = "txtPageInfo";
            this.txtPageInfo.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.txtPageInfo.ParentStyleUsing.UseFont = false;
            this.txtPageInfo.Size = new System.Drawing.Size(192, 20);
            // 
            // xrLabel5
            // 
            this.xrLabel5.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.xrLabel5.Location = new System.Drawing.Point(0, 0);
            this.xrLabel5.Name = "xrLabel5";
            this.xrLabel5.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel5.ParentStyleUsing.UseFont = false;
            this.xrLabel5.Size = new System.Drawing.Size(750, 33);
            this.xrLabel5.Text = "PACKING LIST";
            this.xrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrShape2
            // 
            this.xrShape2.Location = new System.Drawing.Point(8, 33);
            this.xrShape2.Name = "xrShape2";
            this.xrShape2.Shape = shapeRectangle6;
            this.xrShape2.Size = new System.Drawing.Size(380, 120);
            // 
            // txtCustAddr
            // 
            this.txtCustAddr.CanGrow = false;
            this.txtCustAddr.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F);
            this.txtCustAddr.Location = new System.Drawing.Point(25, 50);
            this.txtCustAddr.Name = "txtCustAddr";
            this.txtCustAddr.ParentStyleUsing.UseFont = false;
            this.txtCustAddr.Size = new System.Drawing.Size(359, 66);
            // 
            // txtCustName
            // 
            this.txtCustName.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F);
            this.txtCustName.Location = new System.Drawing.Point(25, 33);
            this.txtCustName.Name = "txtCustName";
            this.txtCustName.ParentStyleUsing.UseFont = false;
            this.txtCustName.Size = new System.Drawing.Size(359, 20);
            // 
            // xrLabel3
            // 
            this.xrLabel3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel3.Location = new System.Drawing.Point(425, 42);
            this.xrLabel3.Name = "xrLabel3";
            this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel3.ParentStyleUsing.UseFont = false;
            this.xrLabel3.Size = new System.Drawing.Size(133, 20);
            this.xrLabel3.Text = "PACKING LIST NO.";
            // 
            // xrLabel4
            // 
            this.xrLabel4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel4.Location = new System.Drawing.Point(425, 62);
            this.xrLabel4.Name = "xrLabel4";
            this.xrLabel4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel4.ParentStyleUsing.UseFont = false;
            this.xrLabel4.Size = new System.Drawing.Size(133, 20);
            this.xrLabel4.Text = "DATE";
            // 
            // txtINDate
            // 
            this.txtINDate.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtINDate.Location = new System.Drawing.Point(558, 62);
            this.txtINDate.Name = "txtINDate";
            this.txtINDate.ParentStyleUsing.UseFont = false;
            this.txtINDate.Size = new System.Drawing.Size(192, 20);
            // 
            // txtINNumber
            // 
            this.txtINNumber.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtINNumber.Location = new System.Drawing.Point(558, 42);
            this.txtINNumber.Name = "txtINNumber";
            this.txtINNumber.ParentStyleUsing.UseFont = false;
            this.txtINNumber.Size = new System.Drawing.Size(192, 20);
            // 
            // GroupHeader3
            // 
            this.GroupHeader3.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.txtRemarks,
            this.txtBoardDate,
            this.txtCarrier,
            this.xrLabel17,
            this.xrLabel15,
            this.txtINNumber,
            this.xrShape2,
            this.txtCustAddr,
            this.txtCustName,
            this.xrLabel3,
            this.xrLabel4,
            this.txtINDate,
            this.xrLabel5});
            this.GroupHeader3.Height = 160;
            this.GroupHeader3.Level = 2;
            this.GroupHeader3.Name = "GroupHeader3";
            this.GroupHeader3.RepeatEveryPage = true;
            this.GroupHeader3.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.GroupHeader3_BeforePrint);
            // 
            // xrLabel15
            // 
            this.xrLabel15.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrLabel15.Location = new System.Drawing.Point(425, 83);
            this.xrLabel15.Name = "xrLabel15";
            this.xrLabel15.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel15.ParentStyleUsing.UseFont = false;
            this.xrLabel15.Size = new System.Drawing.Size(133, 20);
            this.xrLabel15.Text = "Carrier";
            // 
            // xrLabel17
            // 
            this.xrLabel17.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrLabel17.Location = new System.Drawing.Point(425, 104);
            this.xrLabel17.Name = "xrLabel17";
            this.xrLabel17.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel17.ParentStyleUsing.UseFont = false;
            this.xrLabel17.Size = new System.Drawing.Size(133, 20);
            this.xrLabel17.Text = "On Board Date";
            // 
            // txtCarrier
            // 
            this.txtCarrier.CanGrow = false;
            this.txtCarrier.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCarrier.Location = new System.Drawing.Point(558, 83);
            this.txtCarrier.Name = "txtCarrier";
            this.txtCarrier.ParentStyleUsing.UseFont = false;
            this.txtCarrier.RtfText = ((DevExpress.XtraReports.UI.SerializableString)(resources.GetObject("txtCarrier.RtfText")));
            this.txtCarrier.Size = new System.Drawing.Size(213, 20);
            // 
            // txtBoardDate
            // 
            this.txtBoardDate.CanGrow = false;
            this.txtBoardDate.Font = new System.Drawing.Font("Arial", 9.75F);
            this.txtBoardDate.Location = new System.Drawing.Point(558, 104);
            this.txtBoardDate.Name = "txtBoardDate";
            this.txtBoardDate.ParentStyleUsing.UseFont = false;
            this.txtBoardDate.RtfText = ((DevExpress.XtraReports.UI.SerializableString)(resources.GetObject("txtBoardDate.RtfText")));
            this.txtBoardDate.Size = new System.Drawing.Size(213, 20);
            // 
            // txtRemarks
            // 
            this.txtRemarks.CanShrink = true;
            this.txtRemarks.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemarks.Location = new System.Drawing.Point(558, 125);
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.ParentStyleUsing.UseFont = false;
            this.txtRemarks.RtfText = ((DevExpress.XtraReports.UI.SerializableString)(resources.GetObject("txtRemarks.RtfText")));
            this.txtRemarks.Size = new System.Drawing.Size(213, 20);
            // 
            // PackingListXr_Pdf
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.PageHeader,
            this.PageFooter,
            this.GroupHeader1,
            this.GroupHeader2,
            this.GroupHeader3});
            this.Margins = new System.Drawing.Printing.Margins(50, 0, 50, 50);
            this.PageHeight = 1169;
            this.PageWidth = 827;
            this.PaperKind = System.Drawing.Printing.PaperKind.A4;
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
        private DevExpress.XtraReports.UI.XRLabel xrLabel6;
        private DevExpress.XtraReports.UI.XRPageInfo txtPageInfo;
        private DevExpress.XtraReports.UI.XRLabel xrLabel5;
        private DevExpress.XtraReports.UI.XRShape xrShape2;
        private DevExpress.XtraReports.UI.XRRichText txtCustAddr;
        private DevExpress.XtraReports.UI.XRRichText txtCustName;
        private DevExpress.XtraReports.UI.XRLabel xrLabel3;
        private DevExpress.XtraReports.UI.XRLabel xrLabel4;
        private DevExpress.XtraReports.UI.XRRichText txtINDate;
        private DevExpress.XtraReports.UI.XRRichText txtINNumber;

        #region Designer generated code


        #endregion

        private DevExpress.XtraReports.UI.XRShape xrShape1;
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
        private DevExpress.XtraReports.UI.XRRichText txtBoardDate;
        private DevExpress.XtraReports.UI.XRRichText txtCarrier;
        private DevExpress.XtraReports.UI.XRLabel xrLabel17;
        private DevExpress.XtraReports.UI.XRLabel xrLabel15;
        private DevExpress.XtraReports.UI.XRRichText txtRemarks;
    }
}
