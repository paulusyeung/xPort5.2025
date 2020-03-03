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

namespace xPort5.Order.Invoice
{
    public partial class PrintManager : Form
    {
        string xmlSource = System.Web.HttpContext.Current.Server.MapPath("~/Resources/List/ReportList_Invoice.xml");

        public PrintManager()
        {
            InitializeComponent();
        }

        private void customPanel1_Load(object sender, EventArgs e)
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
            if (sender is CustomPanel)
            {
                string tag = ((CustomPanel)sender).Tag.ToString();
                this.ViewReports(tag);
            }
        }

        private void ViewReports(string tag)
        {
            switch (tag.ToLower())
            {
                case "invoice":
                    xPort5.Controls.Reporting.XR.Loader.Invoice(GetWhereValue());
                    break;
                case "packing_list":
                    xPort5.Controls.Reporting.XR.Loader.PackingList(GetWhereValue());
                    break;
                case "packing_listforcf":
                    xPort5.Controls.Reporting.XR.Loader.PackingListForCF(GetWhereValue());
                    break;
                case "packing_listmeasurementininch":
                    xPort5.Controls.Reporting.XR.Loader.PackingListMeasurementInInch(GetWhereValue());
                    break;
                case "packing_listwithoneshippingmark":
                    xPort5.Controls.Reporting.XR.Loader.PackingList(GetWhereValue());
                    break;
                case "packing_list_xls":
                    xPort5.Controls.Reporting.XR.Loader.PackingListXls(GetWhereValue());
                    break;
                case "shipment_advise":
                    xPort5.Controls.Reporting.XR.Loader.ShipmentAdvise(GetWhereValue());
                    break;
            }
        }

        private string GetWhereValue()
        {
            StringBuilder where = new StringBuilder();
            for(int i=0;i<InvoiceList.InNumber.Length;i++)
            {
                if(where.ToString() != string.Empty)
                {
                    where.Append(",");
                }
                where.AppendFormat("'{0}'",InvoiceList.InNumber[i]);
            }
            return where.ToString();
        }

    }
}