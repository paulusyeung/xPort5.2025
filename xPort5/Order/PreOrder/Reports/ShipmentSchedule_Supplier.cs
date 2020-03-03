using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace xPort5.Order.PreOrder.Reports
{
    public partial class ShipmentSchedule_Supplier : DevExpress.XtraReports.UI.XtraReport
    {
        public ShipmentSchedule_Supplier()
        {
            InitializeComponent();
        }

        private void Detail_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            this.txtShippedOn.Text = Convert.ToDateTime(GetCurrentColumnValue("DateShipped")).ToString("dd MMM., yyyy");
            this.txtShippedQty.Text = Convert.ToInt32(GetCurrentColumnValue("QtyOrdered")).ToString("n0");
        }

    }
}
