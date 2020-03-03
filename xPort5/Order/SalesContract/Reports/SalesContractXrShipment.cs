using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace xPort5.Order.SalesContract.Reports
{
    public partial class SalesContractXrShipment : DevExpress.XtraReports.UI.XtraReport
    {
        public SalesContractXrShipment()
        {
            InitializeComponent();

            #region
            //this.txtShippedOn.DataBindings.Add("Text", DataSource, "SCNumber");
            //this.txtQtyShipped.DataBindings.Add("Text", DataSource, "QtyShipped");
            #endregion
            
        }

        private void Detail_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            this.txtShippedOn.Text = Convert.ToDateTime(GetCurrentColumnValue("ShippedOn")).ToString("dd MMM., yyyy");
            this.lblQtyShipped.Text = Convert.ToInt32(GetCurrentColumnValue("QtyOrdered")).ToString("n0");
        }

    }
}
