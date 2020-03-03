using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using Gizmox.WebGUI.Forms;
using System.Data;

namespace xPort5.Order.PurchaseContract.Reports
{
    public partial class PurchaseContractXr_Pdf : DevExpress.XtraReports.UI.XtraReport
    {
        private decimal sum = 0;
        private string shippingmark = "";

        public PurchaseContractXr_Pdf(string parameters)
        {
            InitializeComponent();

            if (parameters == "purchase_contractnoshippinginfo")
            {
                subShipment.Visible = false;
            }

            #region

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
            this.txtCustName.Text = GetCurrentColumnValue("SuppName").ToString();
            this.txtCustAddr.Text = GetCurrentColumnValue("SuppAddr").ToString();
            this.txtTel.Text = "Tel.: " + GetCurrentColumnValue("Phone1_Text").ToString();
            this.txtFax.Text = "Fax.: " + GetCurrentColumnValue("Phone3_Text").ToString();

            this.txtPCNumber.Text = ": " + GetCurrentColumnValue("PCNumber").ToString();
            this.txtPCDate.Text = ": " + Convert.ToDateTime(GetCurrentColumnValue("PCDate")).ToString("dd MMM., yyyy");
        }

        private void gh2_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            this.txtYourRef.Text = ": " + GetCurrentColumnValue("YourRef").ToString();
            this.txtCarrier.Text = ": " + GetCurrentColumnValue("Carrier").ToString();
            this.txtPayTerms.Text = ": " + GetCurrentColumnValue("PayTerms").ToString();
            this.txtPricingTerms.Text = ": " + GetCurrentColumnValue("PricingTerms").ToString();
        }

        private void gh1_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            this.gh1Currency1.Text = GetCurrentColumnValue("CostCny").ToString();
            this.gh1Currency2.Text = GetCurrentColumnValue("CostCny").ToString();
        }

        private void gf1_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            this.gf1Currency.Text = String.Format("TOTAL {0} ", GetCurrentColumnValue("CostCny").ToString());
            this.txtTotalAmount.Text = sum.ToString("n2");

            this.txtRemarks.Text = GetCurrentColumnValue("Remarks").ToString();
            this.txtRemarks2.Text = GetCurrentColumnValue("Remarks2").ToString();
            this.txtRemarks3.Text = GetCurrentColumnValue("Remarks3").ToString();
        }

        private void gf2_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            this.txtShippingMark.Text = shippingmark;
        }

        private void Detail_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            this.txtCustRef.Text = "(" + GetCurrentColumnValue("CustRef").ToString() + ")";
            this.txtArticleCode.Text = GetCurrentColumnValue("ArticleCode").ToString();
            if (GetCurrentColumnValue("SuppRef").ToString() != string.Empty)
            {
                this.txtSuppRef.Text = "[" + GetCurrentColumnValue("SuppRef").ToString() + "]";
            }
            this.txtArticleName.Text = GetCurrentColumnValue("ArtName").ToString();
            this.txtColor.Text = "COLOR: " + GetCurrentColumnValue("ColorPattern").ToString();
            this.txtPacking.Text = "PACKING: " + GetCurrentColumnValue("Package").ToString() + " " + Convert.ToInt32(GetCurrentColumnValue("InnerBox")).ToString() + GetCurrentColumnValue("PackUnit").ToString() + " / " + Convert.ToInt32(GetCurrentColumnValue("OuterBox")).ToString() + GetCurrentColumnValue("PackUnit").ToString() + " / " + Convert.ToDecimal(GetCurrentColumnValue("CUFT")).ToString("n2") + " CUFT.";
            this.txtParticular.Text = GetCurrentColumnValue("Particular").ToString();
            //this.txtCarton.Text = Convert.ToInt32(GetCurrentColumnValue("Carton")).ToString("n0") + " Ctn.";
            this.txtQty.Text = Convert.ToInt32(GetCurrentColumnValue("OrderedQty")).ToString("n0");
            this.txtUnit.Text = GetCurrentColumnValue("OrderedUnit").ToString();
            this.txtUnitPrice.Text = Convert.ToDecimal(GetCurrentColumnValue("UnitCost")).ToString("n3");
            this.txtAmount.Text = (Convert.ToInt32(GetCurrentColumnValue("OrderedQty")) * Convert.ToDecimal(GetCurrentColumnValue("UnitCost"))).ToString("n2");

            if (GetCurrentColumnValue("ShippingMark").ToString().Trim().Length > 0)
                shippingmark = GetCurrentColumnValue("ShippingMark").ToString();
            sum += Convert.ToInt32(GetCurrentColumnValue("OrderedQty")) * Convert.ToDecimal(GetCurrentColumnValue("UnitCost"));

            #region

            xPort5.Order.PurchaseContract.Reports.PurchaseContractXrShipment shipment = new xPort5.Order.PurchaseContract.Reports.PurchaseContractXrShipment();
            DataTable dtShipmtent = xPort5.Controls.Reporting.XR.DataSource.PurchaseContractShipment( GetCurrentColumnValue("PCNumber").ToString(),GetCurrentColumnValue("PCLineNo").ToString());
            shipment.DataSource = dtShipmtent;

            this.subShipment.ReportSource = shipment;

            #endregion
        }

    }
}
