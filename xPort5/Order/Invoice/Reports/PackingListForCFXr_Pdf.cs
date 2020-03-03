using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using Gizmox.WebGUI.Forms;

namespace xPort5.Order.Invoice.Reports
{
    public partial class PackingListForCFXr_Pdf : DevExpress.XtraReports.UI.XtraReport
    {
        public PackingListForCFXr_Pdf()
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
                txtHeader.LoadFile(rtfFile, XRRichTextStreamType.RtfText);
            }
        }

        private void GroupHeader2_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            this.txtCustName.Text = ": " + GetCurrentColumnValue("CustName").ToString();
            this.txtCustAddr.Text = ": " + GetCurrentColumnValue("CustAddr").ToString();
            this.txtINNumber.Text = ": " + GetCurrentColumnValue("INNumber").ToString();
            this.txtINDate.Text = ": " + Convert.ToDateTime(GetCurrentColumnValue("INDate")).ToString("dd MMM, yyyy");
            this.txtSS.Text = ": " + GetCurrentColumnValue("Carrier").ToString();
            this.txtOn.Text = ": " + Convert.ToDateTime(GetCurrentColumnValue("DepartureDate")).ToString("dd MMM, yyyy");
        }

        private void Detail_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            this.txtShippingMark.Text = GetCurrentColumnValue("ShippingMark").ToString();
            this.txtArticleCode.Text = "ITEM NO.: " + GetCurrentColumnValue("ArticleCode").ToString();
            this.txtArticleName.Text = GetCurrentColumnValue("ArtName").ToString();
            this.txtColor.Text = "COLOR: " + GetCurrentColumnValue("ColorPattern").ToString();
            this.txtQty.Text = Convert.ToInt32(GetCurrentColumnValue("OuterBox")).ToString("n0");
            this.txtUnit.Text = GetCurrentColumnValue("Unit").ToString();
            this.txtWeightGross.Text = Convert.ToDecimal(GetCurrentColumnValue("WeightGross_kg")).ToString("n1");
            this.txtWeightNet.Text = Convert.ToDecimal(GetCurrentColumnValue("WeightNet_kg")).ToString("n1");
        }

    }
}
