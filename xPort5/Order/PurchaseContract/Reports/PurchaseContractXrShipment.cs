using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace xPort5.Order.PurchaseContract.Reports
{
    public partial class PurchaseContractXrShipment : DevExpress.XtraReports.UI.XtraReport
    {
        public PurchaseContractXrShipment()
        {
            InitializeComponent();
        }

        private void Detail_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            this.txtShippedOn.Text = Convert.ToDateTime(GetCurrentColumnValue("DateShipped")).ToString("dd MMM., yyyy");
            this.lblQtyShipped.Text = Convert.ToInt32(GetCurrentColumnValue("QtyOrdered")).ToString("n0");
        }

    }
}
