using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using Gizmox.WebGUI.Forms;
using System.Data;

namespace xPort5.Order.SalesContract.Reports
{
    public partial class ProformaInvoiceXr_Pdf : DevExpress.XtraReports.UI.XtraReport
    {
        private decimal sum = 0;
        private string shippingmark = "";

        public ProformaInvoiceXr_Pdf(string parameters)
        {
            InitializeComponent();

            #region

            switch (parameters)
            {
                case "proforma_invoicewithoutshippingmark":
                    this.gf2.Visible = false;
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
                txtHeader.LoadFile(rtfFile, XRRichTextStreamType.RtfText);
            }
        }

        private void gh3_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            this.txtCustName.Text = GetCurrentColumnValue("CustName").ToString();
            this.txtCustAddr.Text = GetCurrentColumnValue("CustAddr").ToString();

            this.txtSCNumber.Text = ": " + GetCurrentColumnValue("SCNumber").ToString();
            this.txtSCDate.Text = ": " + Convert.ToDateTime(GetCurrentColumnValue("SCDate")).ToString("dd MMM., yyyy");
            this.txtYourOrderNo.Text = ": " + GetCurrentColumnValue("YourOrderNo").ToString();
        }

        private void gh2_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            this.txtYourRef.Text = ": " + GetCurrentColumnValue("YourRef").ToString();
            this.txtCarrier.Text = ": " + GetCurrentColumnValue("Carrier").ToString();
            this.txtPayTerms.Text = ": " + GetCurrentColumnValue("PayTerms").ToString();
            this.txtPricingTerms.Text = ": " + GetCurrentColumnValue("PricingTerms").ToString();
            this.txtLoadingPort.Text = ": " + GetCurrentColumnValue("LoadingPort").ToString();
            this.txtDischargePort.Text = ": " + GetCurrentColumnValue("DischargePort").ToString();
            this.txtDestination.Text = ": " + GetCurrentColumnValue("Destination").ToString();
            this.txtOrigin.Text = ": " + GetCurrentColumnValue("Origin").ToString();
        }

        private void gh1_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            this.gh1Currency1.Text = GetCurrentColumnValue("CurrencyUsed").ToString();
            this.gh1Currency2.Text = GetCurrentColumnValue("CurrencyUsed").ToString();
        }

        private void Detail_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            this.txtCustRef.Text = GetCurrentColumnValue("CustRef").ToString();
            this.txtArticleCode.Text = "(" + GetCurrentColumnValue("ArticleCode").ToString() + ")";
            this.txtArticleName.Text = GetCurrentColumnValue("ArtName").ToString();
            this.txtPacking.Text = GetCurrentColumnValue("Package").ToString() + " " + Convert.ToInt32(GetCurrentColumnValue("InnerBox")).ToString() + GetCurrentColumnValue("PackageUnit").ToString() + " / " + Convert.ToInt32(GetCurrentColumnValue("OuterBox")).ToString() + GetCurrentColumnValue("PackageUnit").ToString() + " / " + Convert.ToDecimal(GetCurrentColumnValue("CUFT")).ToString("n2") + " CUFT";
            this.txtCarton.Text = Convert.ToInt32(GetCurrentColumnValue("Carton")).ToString("n0") + " Ctn.";
            this.txtQty.Text = Convert.ToInt32(GetCurrentColumnValue("Qty")).ToString("n0");
            this.txtUnit.Text = GetCurrentColumnValue("Unit").ToString();
            this.txtUnitPrice.Text = Convert.ToDecimal(GetCurrentColumnValue("UnitAmt")).ToString("n3");
            this.txtAmount.Text = (Convert.ToInt32(GetCurrentColumnValue("Qty")) * Convert.ToDecimal(GetCurrentColumnValue("UnitAmt"))).ToString("n2");

            if (GetCurrentColumnValue("ShippingMark").ToString().Trim().Length > 0)
                shippingmark = GetCurrentColumnValue("ShippingMark").ToString();
            sum += Convert.ToInt32(GetCurrentColumnValue("Qty")) * Convert.ToDecimal(GetCurrentColumnValue("UnitAmt"));

            #region bind subreport Shipment
            SalesContractXrShipment shipment = new SalesContractXrShipment();
            DataTable dtShipment = xPort5.Controls.Reporting.XR.DataSource.SalesContractShipment(GetCurrentColumnValue("SCNumber").ToString(), GetCurrentColumnValue("SCLineNo").ToString());
            shipment.DataSource = dtShipment;
            this.subShipment.ReportSource = shipment;
            #endregion
        }

        private void gf1_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            this.gf1Currency.Text = String.Format("TOTAL {0} ", GetCurrentColumnValue("CurrencyUsed").ToString());
            this.txtTotalAmount.Text = sum.ToString("n2");
        }

        private void gf2_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            this.txtShippingMark.Text = shippingmark;
        }
    }
}
