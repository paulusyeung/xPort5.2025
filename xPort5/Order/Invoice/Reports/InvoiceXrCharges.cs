using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace xPort5.Order.Invoice.Reports
{
    public partial class InvoiceXrCharges : DevExpress.XtraReports.UI.XtraReport
    {
        public InvoiceXrCharges()
        {
            InitializeComponent();
        }

        private void InvoiceXrCharges_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
        }

        private void Detail_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            this.lblDescription.Text = GetCurrentColumnValue("Description").ToString();
            this.txtAmount.Text = Convert.ToDecimal(GetCurrentColumnValue("Amount")).ToString("N2");
        }
    }
}
