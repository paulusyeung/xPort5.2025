using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using Gizmox.WebGUI.Forms;
using System.Data;

namespace xPort5.Order.Quotation.Reports
{
    public partial class PriceListXr_Pdf : DevExpress.XtraReports.UI.XtraReport
    {
        private decimal sum = 0;
        private string shippingmark = "";

        public PriceListXr_Pdf(string parameters)
        {
            InitializeComponent();

            #region formating

            switch(parameters)
            {
                case "price_list":
                    break;
                case "sales_contractwithoneshippingmark":
                    break;
                case "sales_contractwithoutshippingmark":
                    break;
            }

            this.txtPageInfo.Format = ": Page {0} of {1}";
            
            #endregion
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

        private void gh3_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            this.txtCustName.Text = GetCurrentColumnValue("CustName").ToString();
            this.txtCustAddr.Text = GetCurrentColumnValue("CustAddr").ToString();
            this.txtTel.Text = "Tel.: "+GetCurrentColumnValue("Phone1_Text").ToString();
            this.txtFax.Text = "Fax.: "+GetCurrentColumnValue("Phone3_Text").ToString();

            this.txtSCNumber.Text = ": " + GetCurrentColumnValue("QTNumber").ToString();
            this.txtSCDate.Text = ": " + Convert.ToDateTime(GetCurrentColumnValue("QTDate")).ToString("dd MMM., yyyy");
        }

        private void gh2_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            this.txtTerms.Text = GetCurrentColumnValue("PayTerms").ToString().ToUpper();
        }

        private void gh1_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            this.gh1Currency1.Text = String.Format("( {0} )", GetCurrentColumnValue("CurrencyUsed").ToString());
        }

        private void Detail_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            this.txtArticleCode.Text = GetCurrentColumnValue("ArticleCode").ToString();
            this.txtCustRef.Text = "(" + GetCurrentColumnValue("CustRef").ToString() + ")";

            this.txtArticleName.Text = GetCurrentColumnValue("ArtName").ToString();
            this.txtColor.Text = "COLOR: " + GetCurrentColumnValue("ColorPattern").ToString();
            this.txtPacking.Text = "PACKING: " + GetCurrentColumnValue("Package").ToString() + " " + Convert.ToInt32(GetCurrentColumnValue("InnerBox")).ToString() + GetCurrentColumnValue("PackageUnit").ToString() + " / " + Convert.ToInt32(GetCurrentColumnValue("OuterBox")).ToString() + GetCurrentColumnValue("PackageUnit").ToString() + " / " + Convert.ToDecimal(GetCurrentColumnValue("CUFT")).ToString("n2") + " CUFT";
            this.txtParticular.Text = GetCurrentColumnValue("Particular").ToString();

            this.txtUnit.Text = GetCurrentColumnValue("Unit").ToString();
            this.txtUnitPrice.Text = "$" + Convert.ToDecimal(GetCurrentColumnValue("UnitAmt")).ToString("n3");
        }

        private void gf1_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            this.txtRemarks.Text = GetCurrentColumnValue("Remarks").ToString();
            this.txtRemarks2.Text = GetCurrentColumnValue("Remarks2").ToString();
            this.txtRemarks3.Text = GetCurrentColumnValue("Remarks3").ToString();
        }
    }
}
