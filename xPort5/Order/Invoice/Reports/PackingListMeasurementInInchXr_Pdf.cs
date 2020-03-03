using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using Gizmox.WebGUI.Forms;

namespace xPort5.Order.Invoice.Reports
{
    public partial class PackingListMeasurementInInchXr_Pdf : DevExpress.XtraReports.UI.XtraReport
    {
        public PackingListMeasurementInInchXr_Pdf()
        {
            InitializeComponent();

            this.txtPageInfo.Format = ": {0} of {1}";

        }

        private void txtHeader_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            string rtfFile = VWGContext.Current.Server.MapPath("~\\Resources\\UserData\\ContractHeader.rtf");
            XRRichText txtHeader = sender as XRRichText;

            if (txtHeader != null)
            {
                txtHeader.LoadFile(rtfFile,XRRichTextStreamType.RtfText);
            }
        }

        private void Detail_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            this.txtShippingMark.Text = GetCurrentColumnValue("ShippingMark").ToString();
            this.txtArticleCode.Text = "ITEM NO.: " + GetCurrentColumnValue("ArticleCode").ToString();
            this.txtArticleName.Text = GetCurrentColumnValue("ArtName").ToString();
            this.txtColor.Text = "COLOR: " + GetCurrentColumnValue("ColorPattern").ToString();
            this.txtQty.Text = Convert.ToInt32(GetCurrentColumnValue("OuterBox")).ToString("n0");
            this.txtUnit.Text = GetCurrentColumnValue("Unit").ToString();
            this.txtSize.Text = Convert.ToDecimal(GetCurrentColumnValue("SizeLength_in")).ToString("n1") + "X" + Convert.ToDecimal(GetCurrentColumnValue("SizeWidth_in")).ToString("n1") + "X" + Convert.ToDecimal(GetCurrentColumnValue("SizeHeight_in")).ToString("n1");
            this.txtWeightGross.Text = Convert.ToDecimal(GetCurrentColumnValue("WeightGross_kg")).ToString("n1");
            this.txtWeightNet.Text = Convert.ToDecimal(GetCurrentColumnValue("WeightNet_kg")).ToString("n1");
        }

        private void gh2_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            this.txtNo.Text = "RE: OUR INVOICE NO.: " + GetCurrentColumnValue("INNumber").ToString();
        }

        private void gh3_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            this.txtCustName.Text = GetCurrentColumnValue("CustName").ToString();
            this.txtCustAddr.Text = GetCurrentColumnValue("CustAddr").ToString();
            this.txtINNumber.Text = ": " + xPort5.Controls.Utility.OrderIN.ConvertToPK(GetCurrentColumnValue("INNumber").ToString());
            this.txtINDate.Text = ": " + Convert.ToDateTime(GetCurrentColumnValue("INDate")).ToString("dd MMM, yyyy");
        }

        private void InitializeComponent()
        {
            DevExpress.XtraPrinting.Shape.ShapeRectangle shapeRectangle1 = new DevExpress.XtraPrinting.Shape.ShapeRectangle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PackingListMeasurementInInchXr_Pdf));
            DevExpress.XtraPrinting.Shape.ShapeRectangle shapeRectangle2 = new DevExpress.XtraPrinting.Shape.ShapeRectangle();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.txtShippingMark = new DevExpress.XtraReports.UI.XRRichText();
            this.txtArticleName = new DevExpress.XtraReports.UI.XRRichText();
            this.txtUnit = new DevExpress.XtraReports.UI.XRLabel();
            this.txtColor = new DevExpress.XtraReports.UI.XRRichText();
            this.txtSize = new DevExpress.XtraReports.UI.XRRichText();
            this.txtArticleCode = new DevExpress.XtraReports.UI.XRRichText();
            this.xrLine1 = new DevExpress.XtraReports.UI.XRLine();
            this.txtQty = new DevExpress.XtraReports.UI.XRLabel();
            this.txtWeightGross = new DevExpress.XtraReports.UI.XRLabel();
            this.txtWeightNet = new DevExpress.XtraReports.UI.XRLabel();
            this.PageHeader = new DevExpress.XtraReports.UI.PageHeaderBand();
            this.txtHeader = new DevExpress.XtraReports.UI.XRRichText();
            this.PageFooter = new DevExpress.XtraReports.UI.PageFooterBand();
            this.gh1 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.txt = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel7 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel8 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel9 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel10 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel11 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel12 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel13 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel14 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel16 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrShape1 = new DevExpress.XtraReports.UI.XRShape();
            this.gh2 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.txtPageInfo = new DevExpress.XtraReports.UI.XRPageInfo();
            this.xrLabel6 = new DevExpress.XtraReports.UI.XRLabel();
            this.txtNo = new DevExpress.XtraReports.UI.XRRichText();
            this.gh3 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.xrLabel5 = new DevExpress.XtraReports.UI.XRLabel();
            this.txtINDate = new DevExpress.XtraReports.UI.XRRichText();
            this.xrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
            this.txtCustName = new DevExpress.XtraReports.UI.XRRichText();
            this.txtCustAddr = new DevExpress.XtraReports.UI.XRRichText();
            this.xrShape2 = new DevExpress.XtraReports.UI.XRShape();
            this.txtINNumber = new DevExpress.XtraReports.UI.XRRichText();
            ((System.ComponentModel.ISupportInitialize)(this.txtShippingMark)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtArticleName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtArticleCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHeader)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtINDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCustName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCustAddr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtINNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.txtShippingMark,
            this.txtArticleName,
            this.txtUnit,
            this.txtColor,
            this.txtSize,
            this.txtArticleCode,
            this.xrLine1,
            this.txtQty,
            this.txtWeightGross,
            this.txtWeightNet});
            this.Detail.Height = 86;
            this.Detail.Name = "Detail";
            this.Detail.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.Detail_BeforePrint);
            // 
            // txtShippingMark
            // 
            this.txtShippingMark.Font = new System.Drawing.Font("Arial", 9.75F);
            this.txtShippingMark.Location = new System.Drawing.Point(0, 0);
            this.txtShippingMark.Name = "txtShippingMark";
            this.txtShippingMark.ParentStyleUsing.UseFont = false;
            this.txtShippingMark.Size = new System.Drawing.Size(100, 25);
            // 
            // txtArticleName
            // 
            this.txtArticleName.Font = new System.Drawing.Font("Arial", 9.75F);
            this.txtArticleName.Location = new System.Drawing.Point(242, 17);
            this.txtArticleName.Name = "txtArticleName";
            this.txtArticleName.ParentStyleUsing.UseFont = false;
            this.txtArticleName.Size = new System.Drawing.Size(200, 40);
            // 
            // txtUnit
            // 
            this.txtUnit.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUnit.Location = new System.Drawing.Point(483, 0);
            this.txtUnit.Name = "txtUnit";
            this.txtUnit.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.txtUnit.ParentStyleUsing.UseFont = false;
            this.txtUnit.Size = new System.Drawing.Size(40, 17);
            // 
            // txtColor
            // 
            this.txtColor.Font = new System.Drawing.Font("Arial", 9.75F);
            this.txtColor.Location = new System.Drawing.Point(242, 57);
            this.txtColor.Name = "txtColor";
            this.txtColor.ParentStyleUsing.UseFont = false;
            this.txtColor.Size = new System.Drawing.Size(200, 20);
            // 
            // txtSize
            // 
            this.txtSize.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F);
            this.txtSize.Location = new System.Drawing.Point(525, 0);
            this.txtSize.Name = "txtSize";
            this.txtSize.ParentStyleUsing.UseFont = false;
            this.txtSize.Size = new System.Drawing.Size(110, 17);
            // 
            // txtArticleCode
            // 
            this.txtArticleCode.Font = new System.Drawing.Font("Arial", 9.75F);
            this.txtArticleCode.Location = new System.Drawing.Point(242, 0);
            this.txtArticleCode.Name = "txtArticleCode";
            this.txtArticleCode.ParentStyleUsing.UseFont = false;
            this.txtArticleCode.Size = new System.Drawing.Size(200, 17);
            // 
            // xrLine1
            // 
            this.xrLine1.Location = new System.Drawing.Point(117, 77);
            this.xrLine1.Name = "xrLine1";
            this.xrLine1.Size = new System.Drawing.Size(633, 9);
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
            // txtWeightNet
            // 
            this.txtWeightNet.Font = new System.Drawing.Font("Arial", 9.75F);
            this.txtWeightNet.Location = new System.Drawing.Point(690, 0);
            this.txtWeightNet.Name = "txtWeightNet";
            this.txtWeightNet.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.txtWeightNet.ParentStyleUsing.UseFont = false;
            this.txtWeightNet.Size = new System.Drawing.Size(50, 17);
            this.txtWeightNet.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
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
            // gh1
            // 
            this.gh1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.txt,
            this.xrLabel2,
            this.xrLabel7,
            this.xrLabel8,
            this.xrLabel9,
            this.xrLabel10,
            this.xrLabel11,
            this.xrLabel1,
            this.xrLabel12,
            this.xrLabel13,
            this.xrLabel14,
            this.xrLabel16,
            this.xrShape1});
            this.gh1.Height = 58;
            this.gh1.Name = "gh1";
            this.gh1.RepeatEveryPage = true;
            // 
            // txt
            // 
            this.txt.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.txt.Location = new System.Drawing.Point(0, 17);
            this.txt.Name = "txt";
            this.txt.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.txt.ParentStyleUsing.UseFont = false;
            this.txt.Size = new System.Drawing.Size(125, 21);
            this.txt.Text = "MARKS & NOS.";
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
            this.xrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel7
            // 
            this.xrLabel7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrLabel7.Location = new System.Drawing.Point(158, 17);
            this.xrLabel7.Name = "xrLabel7";
            this.xrLabel7.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel7.ParentStyleUsing.UseFont = false;
            this.xrLabel7.Size = new System.Drawing.Size(84, 21);
            this.xrLabel7.Text = "NO. OF FK";
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
            // xrLabel10
            // 
            this.xrLabel10.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrLabel10.Location = new System.Drawing.Point(525, 8);
            this.xrLabel10.Name = "xrLabel10";
            this.xrLabel10.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel10.ParentStyleUsing.UseFont = false;
            this.xrLabel10.Size = new System.Drawing.Size(58, 18);
            this.xrLabel10.Text = "MEAS.";
            // 
            // xrLabel11
            // 
            this.xrLabel11.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrLabel11.Location = new System.Drawing.Point(628, 8);
            this.xrLabel11.Name = "xrLabel11";
            this.xrLabel11.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel11.ParentStyleUsing.UseFont = false;
            this.xrLabel11.Size = new System.Drawing.Size(55, 18);
            this.xrLabel11.Text = "G.W.";
            // 
            // xrLabel1
            // 
            this.xrLabel1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrLabel1.Location = new System.Drawing.Point(690, 8);
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel1.ParentStyleUsing.UseFont = false;
            this.xrLabel1.Size = new System.Drawing.Size(55, 18);
            this.xrLabel1.Text = "N.W.";
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
            this.xrLabel12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel13
            // 
            this.xrLabel13.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel13.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrLabel13.Location = new System.Drawing.Point(525, 26);
            this.xrLabel13.Name = "xrLabel13";
            this.xrLabel13.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel13.ParentStyleUsing.UseBorders = false;
            this.xrLabel13.ParentStyleUsing.UseFont = false;
            this.xrLabel13.Size = new System.Drawing.Size(58, 18);
            this.xrLabel13.Text = "IN INCH";
            // 
            // xrLabel14
            // 
            this.xrLabel14.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel14.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrLabel14.Location = new System.Drawing.Point(690, 26);
            this.xrLabel14.Name = "xrLabel14";
            this.xrLabel14.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel14.ParentStyleUsing.UseBorders = false;
            this.xrLabel14.ParentStyleUsing.UseFont = false;
            this.xrLabel14.Size = new System.Drawing.Size(55, 18);
            this.xrLabel14.Text = "IN KGS";
            // 
            // xrLabel16
            // 
            this.xrLabel16.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel16.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrLabel16.Location = new System.Drawing.Point(628, 26);
            this.xrLabel16.Name = "xrLabel16";
            this.xrLabel16.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel16.ParentStyleUsing.UseBorders = false;
            this.xrLabel16.ParentStyleUsing.UseFont = false;
            this.xrLabel16.Size = new System.Drawing.Size(55, 18);
            this.xrLabel16.Text = "IN KGS";
            // 
            // xrShape1
            // 
            this.xrShape1.BackColor = System.Drawing.Color.Silver;
            this.xrShape1.Location = new System.Drawing.Point(0, 0);
            this.xrShape1.Name = "xrShape1";
            this.xrShape1.ParentStyleUsing.UseBackColor = false;
            this.xrShape1.ParentStyleUsing.UseBorders = false;
            this.xrShape1.Shape = shapeRectangle1;
            this.xrShape1.Size = new System.Drawing.Size(750, 58);
            // 
            // gh2
            // 
            this.gh2.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.txtPageInfo,
            this.xrLabel6,
            this.txtNo});
            this.gh2.Height = 24;
            this.gh2.Level = 1;
            this.gh2.Name = "gh2";
            this.gh2.RepeatEveryPage = true;
            this.gh2.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.gh2_BeforePrint);
            // 
            // txtPageInfo
            // 
            this.txtPageInfo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPageInfo.Location = new System.Drawing.Point(588, 0);
            this.txtPageInfo.Name = "txtPageInfo";
            this.txtPageInfo.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.txtPageInfo.ParentStyleUsing.UseFont = false;
            this.txtPageInfo.Size = new System.Drawing.Size(150, 20);
            // 
            // xrLabel6
            // 
            this.xrLabel6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel6.Location = new System.Drawing.Point(425, 0);
            this.xrLabel6.Name = "xrLabel6";
            this.xrLabel6.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel6.ParentStyleUsing.UseFont = false;
            this.xrLabel6.Size = new System.Drawing.Size(163, 20);
            this.xrLabel6.Text = "PAGE";
            // 
            // txtNo
            // 
            this.txtNo.Font = new System.Drawing.Font("Arial", 9.75F);
            this.txtNo.Location = new System.Drawing.Point(17, 0);
            this.txtNo.Name = "txtNo";
            this.txtNo.ParentStyleUsing.UseFont = false;
            this.txtNo.RtfText = ((DevExpress.XtraReports.UI.SerializableString)(resources.GetObject("txtNo.RtfText")));
            this.txtNo.Size = new System.Drawing.Size(367, 20);
            // 
            // gh3
            // 
            this.gh3.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel5,
            this.txtINDate,
            this.xrLabel4,
            this.xrLabel3,
            this.txtCustName,
            this.txtCustAddr,
            this.xrShape2,
            this.txtINNumber});
            this.gh3.Height = 159;
            this.gh3.Level = 2;
            this.gh3.Name = "gh3";
            this.gh3.RepeatEveryPage = true;
            this.gh3.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.gh3_BeforePrint);
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
            // txtINDate
            // 
            this.txtINDate.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtINDate.Location = new System.Drawing.Point(588, 62);
            this.txtINDate.Name = "txtINDate";
            this.txtINDate.ParentStyleUsing.UseFont = false;
            this.txtINDate.Size = new System.Drawing.Size(150, 20);
            // 
            // xrLabel4
            // 
            this.xrLabel4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel4.Location = new System.Drawing.Point(425, 62);
            this.xrLabel4.Name = "xrLabel4";
            this.xrLabel4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel4.ParentStyleUsing.UseFont = false;
            this.xrLabel4.Size = new System.Drawing.Size(163, 20);
            this.xrLabel4.Text = "DATE";
            // 
            // xrLabel3
            // 
            this.xrLabel3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel3.Location = new System.Drawing.Point(425, 42);
            this.xrLabel3.Name = "xrLabel3";
            this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel3.ParentStyleUsing.UseFont = false;
            this.xrLabel3.Size = new System.Drawing.Size(163, 20);
            this.xrLabel3.Text = "PACKING LIST NO.";
            // 
            // txtCustName
            // 
            this.txtCustName.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F);
            this.txtCustName.Location = new System.Drawing.Point(25, 33);
            this.txtCustName.Name = "txtCustName";
            this.txtCustName.ParentStyleUsing.UseFont = false;
            this.txtCustName.Size = new System.Drawing.Size(359, 20);
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
            // xrShape2
            // 
            this.xrShape2.Location = new System.Drawing.Point(8, 33);
            this.xrShape2.Name = "xrShape2";
            this.xrShape2.Shape = shapeRectangle2;
            this.xrShape2.Size = new System.Drawing.Size(380, 120);
            // 
            // txtINNumber
            // 
            this.txtINNumber.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtINNumber.Location = new System.Drawing.Point(588, 42);
            this.txtINNumber.Name = "txtINNumber";
            this.txtINNumber.ParentStyleUsing.UseFont = false;
            this.txtINNumber.Size = new System.Drawing.Size(150, 20);
            // 
            // PackingListMeasurementInInchXr_Pdf
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.PageHeader,
            this.PageFooter,
            this.gh1,
            this.gh2,
            this.gh3});
            this.Margins = new System.Drawing.Printing.Margins(50, 0, 50, 50);
            this.PageHeight = 1169;
            this.PageWidth = 827;
            this.PaperKind = System.Drawing.Printing.PaperKind.A4;
            ((System.ComponentModel.ISupportInitialize)(this.txtShippingMark)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtArticleName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtArticleCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHeader)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtINDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCustName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCustAddr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtINNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

    }
}
