using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using Gizmox.WebGUI.Forms;

namespace xPort5.Order.PreOrder.Reports
{
    public partial class PreOrderListForSuppcodeXr_Pdf : DevExpress.XtraReports.UI.XtraReport
    {
        public PreOrderListForSuppcodeXr_Pdf()
        {
            InitializeComponent();

            this.txtPageInfo.Format = ": {0}";

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
            this.txtPLNumber.Text = ": " + GetCurrentColumnValue("PLNumber").ToString();
            this.txtPLDate.Text = ": " + Convert.ToDateTime(GetCurrentColumnValue("PLDate")).ToString("dd MMM yyyy");
        }

        private void Detail_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            this.txtArticleCode.Text = GetCurrentColumnValue("ArticleCode").ToString();
            this.txtCustRef.Text = "[" + GetCurrentColumnValue("SuppRef").ToString() + "]";
            this.txtArticleName.Text = GetCurrentColumnValue("ArtName").ToString();
            this.txtColor.Text = "COLOR:" + GetCurrentColumnValue("ColorPattern").ToString();
            this.txtPacking.Text = "PACKING:" + GetCurrentColumnValue("Package").ToString() + " " + Convert.ToInt32(GetCurrentColumnValue("InnerBox")).ToString("n0") + " " + GetCurrentColumnValue("PackingUnit").ToString() + " / " + Convert.ToInt32(GetCurrentColumnValue("OuterBox")).ToString() + " " + GetCurrentColumnValue("PackingUnit").ToString() + " / " + Convert.ToDecimal(GetCurrentColumnValue("CUFT")).ToString("n2") + " CU.FT.";
            this.txtParticular.Text = GetCurrentColumnValue("Particular").ToString();
            //this.txtSuppName.Text = GetCurrentColumnValue("SuppName").ToString();
            this.txtCostPrice.Text = GetCurrentColumnValue("FactoryCny").ToString() + " " + Convert.ToDecimal(GetCurrentColumnValue("FactoryCost")).ToString("n2") + " / " + GetCurrentColumnValue("OrderedUnit").ToString();
            this.txtOrderQty.Text = Convert.ToInt32(GetCurrentColumnValue("OrderedQty")).ToString("n0") + "  " + GetCurrentColumnValue("OrderedUnit").ToString();
        }

    }
}
