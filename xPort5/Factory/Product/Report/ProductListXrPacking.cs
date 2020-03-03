using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace xPort5.Factory.Product.Report
{
    public partial class ProductListXrPacking : DevExpress.XtraReports.UI.XtraReport
    {
        private bool _ToggleBackColor = false;

        public bool ToggleBackColor
        {
            set
            {
                _ToggleBackColor = value;
            }
        }

        public ProductListXrPacking()
        {
            InitializeComponent();

            #region item databindings
            this.txtPacking.DataBindings.Add("Text", DataSource, "PackageName");
            this.txtUnit.DataBindings.Add("Text", DataSource, "UomName");
            this.txtInnerBox.DataBindings.Add("Text", DataSource, "InnerBox", "{0:n2}");
            this.txtOuterBox.DataBindings.Add("Text", DataSource, "OuterBox", "{0:n2}");
            this.txtCUFT.DataBindings.Add("Text", DataSource, "CUFT", "{0:n2}");
            this.txtLength.DataBindings.Add("Text", DataSource, "SizeLength_cm", "{0:n2}");
            this.txtWidth.DataBindings.Add("Text", DataSource, "SizeWidth_cm", "{0:n2}");
            this.txtHeight.DataBindings.Add("Text", DataSource, "SizeHeight_cm", "{0:n2}");
            this.txtGross.DataBindings.Add("Text", DataSource, "WeightGross_kg", "{0:n3}");
            this.txtNet.DataBindings.Add("Text", DataSource, "WeightNet_kg", "{0:n3}");
            this.txtTotalQty.DataBindings.Add("Text", DataSource, "ContainerQty", "{0:n2}");
            this.txtContainer.DataBindings.Add("Text", DataSource, "ContainerSize");
            #endregion
        }

        private void ProductListXrPacking_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
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
