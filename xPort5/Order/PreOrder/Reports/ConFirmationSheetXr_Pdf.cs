using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using Gizmox.WebGUI.Forms;

namespace xPort5.Order.PreOrder.Reports
{
    public partial class ConFirmationSheetXr_Pdf : DevExpress.XtraReports.UI.XtraReport
    {
        public ConFirmationSheetXr_Pdf()
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

        private void gh2_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            this.txtCustName.Text = GetCurrentColumnValue("CustName").ToString();
            this.txtCustAddr.Text = GetCurrentColumnValue("CustAddr").ToString();
            this.txtTel.Text = "Tel.: " + GetCurrentColumnValue("Phone1_Text").ToString();
            this.txtFax.Text = "Fax.: " + GetCurrentColumnValue("Phone3_Text").ToString();

            this.txtPLNumber.Text = ": " + GetCurrentColumnValue("PLNumber").ToString();
            this.txtPLDate.Text = ": " + Convert.ToDateTime(GetCurrentColumnValue("PLDate")).ToString("dd MMM., yyyy");
        }

        private void gh1_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            this.gh1Currency1.Text = GetCurrentColumnValue("OrderedCny").ToString();
            this.gh1Unit.Text = GetCurrentColumnValue("OrderedUnit").ToString();
        }

        private void Detail_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            this.lblYourRef.Text = GetCurrentColumnValue("CustRef").ToString();
            this.txtArticleCode.Text = GetCurrentColumnValue("ArticleCode").ToString();
            this.txtSuppName.Text = GetCurrentColumnValue("SuppName").ToString();
            this.txtQty.Text = Convert.ToInt32(GetCurrentColumnValue("OrderedQty")).ToString("n0");
            this.txtUnitPrice.Text = Convert.ToDecimal(GetCurrentColumnValue("QuotedUnitAmt")).ToString("n4");
        }

    }
}
