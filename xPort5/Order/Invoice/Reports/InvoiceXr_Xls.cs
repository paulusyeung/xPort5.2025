using System;
using System.Data;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using Gizmox.WebGUI.Forms;

namespace xPort5.Order.Invoice.Reports
{
    public partial class InvoiceXr_Xls : DevExpress.XtraReports.UI.XtraReport
    {
        private decimal sum = 0;

        public InvoiceXr_Xls()
        {
            InitializeComponent();

            #region formating

            this.txtPageInfo.Format = ": Page {0} of {1}";

            #endregion
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

        private void gd4_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            this.txtCustName.Text = GetCurrentColumnValue("CustName").ToString();
            this.txtCustAddr.Text = GetCurrentColumnValue("CustAddr").ToString();
            this.txtTel.Text = "Tel.: " + GetCurrentColumnValue("Phone1_Text").ToString();
            this.txtFax.Text = "Fax.: " + GetCurrentColumnValue("Phone3_Text").ToString();

            this.txtINNumber.Text = ": " + GetCurrentColumnValue("INNumber").ToString();
            this.txtINDate.Text = ": " + Convert.ToDateTime(GetCurrentColumnValue("INDate")).ToString("dd MMM., yyyy");
        }

        private void gh3_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            this.txtYourRef.Text = ": " + GetCurrentColumnValue("YourOrderNo").ToString();
            this.txtCarrier.Text = ": " + GetCurrentColumnValue("Carrier").ToString();
            this.txtBoardDate.Text = ": " + Convert.ToDateTime(GetCurrentColumnValue("DepartureDate")).ToString("dd MMM., yyyy");
            this.txtPayTerms.Text = ": " + GetCurrentColumnValue("PayTerms").ToString();
            this.txtPricingTerms.Text = ": " + GetCurrentColumnValue("PricingTerms").ToString();
            this.txtOurSCNo.Text = ": " + GetCurrentColumnValue("SCNumber").ToString();
            this.txtLoadingPort.Text = ": " + GetCurrentColumnValue("LoadingPort").ToString();
            this.txtDischargePort.Text = ": " + GetCurrentColumnValue("DischargePort").ToString();
            this.txtDestination.Text = ": " + GetCurrentColumnValue("Destination").ToString();
            this.txtOrigin.Text = ": " + GetCurrentColumnValue("Origin").ToString();
        }

        private void gh2_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            this.gh1Currency1.Text = GetCurrentColumnValue("CurrencyUsed").ToString();
            this.gh1Currency2.Text = GetCurrentColumnValue("CurrencyUsed").ToString();
        }

        private void gh1_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            this.txtRemarks.Text = GetCurrentColumnValue("Remarks").ToString();
            if (this.txtRemarks.Text == String.Empty)
                gh1.Visible = false;

            #region bind extra charges
            InvoiceXrCharges charges = new InvoiceXrCharges();
            DataTable dtCharges = xPort5.Controls.Reporting.XR.DataSource.InvoiceCharges(GetCurrentColumnValue("INNumber").ToString());
            if (dtCharges.Rows.Count > 0)
            {
                charges.DataSource = dtCharges;
                this.subCharges.ReportSource = charges;
            }
            else
            {
                this.subCharges.Visible = false;
                this.gf1.Height = 0;
            }
            #endregion
        }

        private void Detail_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            this.lblYourRef.Text = GetCurrentColumnValue("CustRef").ToString();
            this.txtArticleCode.Text = "(" + GetCurrentColumnValue("ArticleCode").ToString() + ")";
            this.txtArticleName.Text = GetCurrentColumnValue("ArtName").ToString();
            this.txtColor.Text = "COLOR: " + GetCurrentColumnValue("ColorPattern").ToString();
            this.txtPacking.Text = "PACKING: " + GetCurrentColumnValue("Package").ToString() + " " + Convert.ToInt32(GetCurrentColumnValue("InnerBox")).ToString() + GetCurrentColumnValue("UoM").ToString() + " / " + Convert.ToInt32(GetCurrentColumnValue("OuterBox")).ToString() + GetCurrentColumnValue("UoM").ToString() + " / " + Convert.ToDecimal(GetCurrentColumnValue("CUFT")).ToString("n2") + " CUFT.";
            this.txtParticular.Text = GetCurrentColumnValue("Particular").ToString();
            //this.txtCarton.Text = Convert.ToInt32(GetCurrentColumnValue("Carton")).ToString("n0") + " Ctn.";
            this.txtQty.Text = Convert.ToInt32(GetCurrentColumnValue("InvoiceQty")).ToString("n0");
            this.txtUnit.Text = GetCurrentColumnValue("Unit").ToString();
            this.txtUnitPrice.Text = Convert.ToDecimal(GetCurrentColumnValue("UnitAmount")).ToString("n3");
            this.txtAmount.Text = (Convert.ToInt32(GetCurrentColumnValue("InvoiceQty")) * Convert.ToDecimal(GetCurrentColumnValue("UnitAmount"))).ToString("n2");

            sum += Convert.ToInt32(GetCurrentColumnValue("InvoiceQty")) * Convert.ToDecimal(GetCurrentColumnValue("UnitAmount"));
        }

        private void gf1_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
        }

        private void PageHeader_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {

        }

        private void gf2_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            sum += xPort5.Controls.Utility.OrderIN.TotalCharges(GetCurrentColumnValue("INNumber").ToString());

            this.txtTotalAmount.Text = sum.ToString("n2");
            this.gf1Currency.Text = String.Format("TOTAL {0} ", GetCurrentColumnValue("CurrencyUsed").ToString());

            xPort5.Controls.CurrencyTranslator txlator = new xPort5.Controls.CurrencyTranslator();

            this.txtTotalAmountWords.Text = String.Format("TOTAL: {0} {1} ({2}{3}) ONLY.",
                xPort5.Controls.Utility.Currency.GetCurrencyName(GetCurrentColumnValue("CurrencyUsed").ToString()).ToUpper(),
                (txlator.TranslateCurrency(sum)).ToUpper(),
                GetCurrentColumnValue("CurrencyUsed").ToString(),
                sum.ToString("n2"));
        }

        private void gf3_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            this.lblRemarks2.Text = GetCurrentColumnValue("Remarks2").ToString();
            this.lblRemarks3.Text = GetCurrentColumnValue("Remarks3").ToString();
        }
    }
}
