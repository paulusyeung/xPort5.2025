using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using Gizmox.WebGUI.Forms;

namespace xPort5.Order.Invoice.Reports
{
    public partial class ShipmentAdviseXr_Pdf : DevExpress.XtraReports.UI.XtraReport
    {
        private decimal sum = 0;
        private int totalCarton = 0;

        public ShipmentAdviseXr_Pdf()
        {
            InitializeComponent();
            
            GroupField gfInvoice = new GroupField("INNumber", XRColumnSortOrder.Ascending);
            this.GroupHeader2.GroupFields.Add(gfInvoice);

            this.txtTotalCartons.DataBindings.Add("Text", this.DataSource, "Carton", "{0:#,#}");
            this.txtTotalCartons.Summary = new XRSummary(SummaryRunning.Group, SummaryFunc.Sum, "{0:#,#}");
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

        private void Detail_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            this.txtSCNumber.Text = GetCurrentColumnValue("SCNumber").ToString();
            this.txtCustRef.Text = GetCurrentColumnValue("CustRef").ToString();
            this.txtArticleCode.Text = GetCurrentColumnValue("OurRef").ToString();
            this.txtCartons.Text = Convert.ToInt32(GetCurrentColumnValue("Carton")).ToString("n0") + " CTNS.";
            this.txtInvoiceQty.Text = Convert.ToInt32(GetCurrentColumnValue("InvoicedQty")).ToString("n0") + " " + GetCurrentColumnValue("UoM").ToString();
            this.txtAmount.Text =  Convert.ToDecimal(GetCurrentColumnValue("Amount")).ToString("n2");

            sum += Convert.ToDecimal(GetCurrentColumnValue("Amount"));
        }

        private void GroupHeader3_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            this.txtCustName.Text = GetCurrentColumnValue("CustName").ToString();
            this.txtLoadingPort.Text = GetCurrentColumnValue("FromPort").ToString();
            this.txtDischargePort.Text = GetCurrentColumnValue("ToPort").ToString();
            this.txtShipmentDate.Text = Convert.ToDateTime(GetCurrentColumnValue("ShipmentDate")).ToString("dd MMM., yyyy");
            this.txtCarrier.Text = GetCurrentColumnValue("Carrier").ToString();
        }

        private void GroupHeader2_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            sum = 0;
            
            this.txtINNumber.Text = GetCurrentColumnValue("INNumber").ToString();
            this.txtPricingTerms.Text = GetCurrentColumnValue("PricingTerms").ToString();
            this.txtCurrencyUsed.Text = GetCurrentColumnValue("CurrencyUsed").ToString();

            //this.txtTotalCartons.Text = GetCurrentColumnValue("Carton").ToString();
        }

        private void GroupFooter1_BeforePrint_1(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            this.txtTotalAmount.Text = sum.ToString("n2");
        }

    }
}
