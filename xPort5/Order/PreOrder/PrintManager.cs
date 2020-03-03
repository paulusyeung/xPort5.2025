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

namespace xPort5.Order.PreOrder
{
    public partial class PrintManager : Form
    {
        string xmlSource = System.Web.HttpContext.Current.Server.MapPath("~/Resources/List/ReportList_PreOrder.xml");

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

            customPanel1.DataSource = ds.Tables["Report"];
        }

        private void customPanel1_Click(object sender, EventArgs e)
        {
            if(sender is CustomPanel)
            {
                string tag = ((CustomPanel)sender).Tag.ToString();
                ViewReports(tag);
            }
        }

        private void ViewReports(string tag)
        { 
            switch(tag.ToLower())
            {
                case "preorder_list":
                    xPort5.Controls.Reporting.XR.Loader.PreOrderList(PreOrderList.PLNumber);
                    break;
                case "preorder_listforcustomer":
                    xPort5.Controls.Reporting.XR.Loader.PreOrderListForCustomer(PreOrderList.PLNumber);
                    break;
                case "preorder_listforsupplier":
                    xPort5.Controls.Reporting.XR.Loader.PreOrderListForSupplier(PreOrderList.PLNumber);
                    break;
                case "preorder_listforsuppcode":
                    xPort5.Controls.Reporting.XR.Loader.PreOrderListForSuppcode(PreOrderList.PLNumber);
                    break;
                case "confirmation_sheet":
                    xPort5.Controls.Reporting.XR.Loader.ConformationSheet(PreOrderList.PLNumber);
                    break;
                case "preorder_list_xls":
                    xPort5.Controls.Reporting.XR.Loader.PreOrderListXls(PreOrderList.PLNumber);
                    break;
            }
        }

    }
}