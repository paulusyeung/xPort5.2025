using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using Gizmox.WebGUI.Forms;

namespace xPort5.Order.Invoice.Reports
{
    public partial class PackingListWithTotalQtyXr_Xls : DevExpress.XtraReports.UI.XtraReport
    {
        public PackingListWithTotalQtyXr_Xls()
        {
            InitializeComponent();
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

        private void GroupHeader3_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            this.txtCustName.Text = GetCurrentColumnValue("CustName").ToString();
            this.txtCustAddr.Text = GetCurrentColumnValue("CustAddr").ToString();
            this.txtINNumber.Text = ": " + xPort5.Controls.Utility.OrderIN.ConvertToPK(GetCurrentColumnValue("INNumber").ToString());
            this.txtINDate.Text = ": " + Convert.ToDateTime(GetCurrentColumnValue("INDate")).ToString("dd MMM, yyyy");

            this.txtCarrier.Text = ": " + GetCurrentColumnValue("Carrier").ToString();
            this.txtBoardDate.Text = ": " + Convert.ToDateTime(GetCurrentColumnValue("DepartureDate")).ToString("dd MMM., yyyy");

            this.txtRemarks.Text = GetCurrentColumnValue("Remarks").ToString();
            if (this.txtRemarks.Text != String.Empty)
                this.txtRemarks.Text = String.Format(": ({0})", this.txtRemarks.Text);
        }

        private void GroupHeader2_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            //this.txtRe.Text = GetCurrentColumnValue("").ToString();
            this.txtNo.Text = "RE: OUR INVOICE NO.: " + GetCurrentColumnValue("INNumber").ToString();
        }

        private void Detail_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            this.txtShippingMark.Text = GetCurrentColumnValue("ShippingMark").ToString();
            this.txtArticleCode.Text = "CUST. REF.: " + GetCurrentColumnValue("CustRef").ToString() + Environment.NewLine + "ITEM NO.: " + GetCurrentColumnValue("ArticleCode").ToString();
            this.txtArticleName.Text = GetCurrentColumnValue("ArtName").ToString();
            this.txtColor.Text = "COLOR: " + GetCurrentColumnValue("ColorPattern").ToString();
            this.txtQty.Text = Convert.ToInt32(GetCurrentColumnValue("OuterBox")).ToString("n0");
            this.txtUnit.Text = GetCurrentColumnValue("Unit").ToString();
            this.txtTotalQty.Text = Convert.ToInt32(GetCurrentColumnValue("InvoiceQty")).ToString("n0");
            this.txtSize.Text = Convert.ToDecimal(GetCurrentColumnValue("SizeLength_cm")).ToString("n1") + "X" + Convert.ToDecimal(GetCurrentColumnValue("SizeWidth_cm")).ToString("n1") + "X" + Convert.ToDecimal(GetCurrentColumnValue("SizeHeight_cm")).ToString("n1");
            this.txtWeightGross.Text = Convert.ToDecimal(GetCurrentColumnValue("WeightGross_kg")).ToString("n1");
            this.txtWeightNet.Text = Convert.ToDecimal(GetCurrentColumnValue("WeightNet_kg")).ToString("n1");
        }

    }
}
