using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace xPort5.Factory.Product.Report
{
    public partial class ProductListXrSupplier : DevExpress.XtraReports.UI.XtraReport
    {
        private bool _ToggleBackColor = false;

        public bool ToggleBackColor
        {
            set
            {
                _ToggleBackColor = value;
            }
        }

        public ProductListXrSupplier()
        {
            InitializeComponent();

            #region item databindings
            this.txtSupplier.DataBindings.Add("Text", DataSource, "SupplierName");
            this.txtSuppRef.DataBindings.Add("Text", DataSource, "SuppRef");
            this.txtFCLCost.DataBindings.Add("Text", DataSource, "FCLCost", "{0:n4}");
            this.txtLCLCost.DataBindings.Add("Text", DataSource, "LCLCost", "{0:n4}");
            this.txtUnitCost.DataBindings.Add("Text", DataSource, "UnitCost", "{0:n4}");
            this.txtCurrency.DataBindings.Add("Text", DataSource, "CurrencyCode");
            #endregion
        }

        private void Detail_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            #region toggle background color
            if (_ToggleBackColor)
            {
//                this.paneDetail.BackColor = Color.WhiteSmoke;
            }
            else
            {
                this.paneDetail.BackColor = Color.Transparent;
            }
            #endregion
        }

    }
}
