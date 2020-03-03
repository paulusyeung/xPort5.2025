#region Using

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;

using Gizmox.WebGUI.Common;
using Gizmox.WebGUI.Forms;
using xPort5.Controls.CustomPanel;

#endregion

namespace xPort5.Order.PurchaseContract
{
    public partial class PrintManager : Form
    {
        string xmlSource = System.Web.HttpContext.Current.Server.MapPath("~/Resources/List/ReportList_PurchaseContract.xml");

        public PrintManager()
        {
            InitializeComponent();
        }

        private void PrintManager_Load(object sender, EventArgs e)
        {
            Binding();
        }

        private void Binding()
        {
            DataSet ds = new DataSet();
            ds.ReadXml(xmlSource);

            this.customPanel1.DataSource = ds.Tables["Report"];
        }

        private void customPanel1_Click(object sender, EventArgs e)
        {
            if (sender is CustomPanel)
            {
                string tag = ((CustomPanel)sender).Tag.ToString();
                this.ViewReports(tag);
            }
        }

        private void ViewReports(string tag)
        { 
            switch(tag.ToLower())
            {
                case "purchase_contract":
                    xPort5.Controls.Reporting.XR.Loader.PurchaseContract(PurchaseContractList.PurchaseContractNum, tag.ToLower());
                    break;
                case "purchase_contractmark":
                    xPort5.Controls.Reporting.XR.Loader.PurchaseContractMark(PurchaseContractList.PurchaseContractNum, tag.ToLower());
                    break;
                case "purchase_contractnoshippinginfo":
                    xPort5.Controls.Reporting.XR.Loader.PurchaseContract(PurchaseContractList.PurchaseContractNum, tag.ToLower());
                    break;
                case "purchase_contract_xls":
                    xPort5.Controls.Reporting.XR.Loader.PurchaseContractXls(PurchaseContractList.PurchaseContractNum);
                    break;
            }
        }

    }
}