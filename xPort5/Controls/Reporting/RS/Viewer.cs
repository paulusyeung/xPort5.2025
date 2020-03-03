using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Web;

using Microsoft.Reporting.WebForms;

using Gizmox.WebGUI.Common;
using Gizmox.WebGUI.Forms;
using Gizmox.WebGUI.Common.Interfaces;

namespace xPort5.Controls.Reporting.RS
{
    public partial class Viewer : Form
    {
        public Viewer()
        {
            InitializeComponent();

            this.RptViewer.Dock = DockStyle.Fill;
        }

        #region Properties
        public enum ReportDestinations { Preview, Printer, ExcelFile, PdfFile }

        private DataTable dataSource = null;
        private Dictionary<string, DataTable> subDataSourceList = new Dictionary<string, DataTable>();
        private DataTable subDataSource;
        private string subDataSourceName;
        private string reportName = string.Empty;
        private string reportDatasourceName = string.Empty;
        private ReportDestinations reportDestination = ReportDestinations.Preview;
        private string[,] parameters;

        /// <summary>
        /// 
        /// </summary>
        public DataTable SubDataSource
        {
            get
            {
                return subDataSource;
            }
            set
            {
                subDataSource = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public string SubDataSourceName
        {
            get
            {
                return subDataSourceName;
            }
            set
            {
                subDataSourceName = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public Dictionary<string, DataTable> SubReportDataSourceList
        {
            get
            {
                return this.subDataSourceList;
            }
            set
            {
                this.subDataSourceList = value;
            }
        }

        /// <summary>
        /// Data Source Name of the Main Report
        /// </summary>
        public DataTable Datasource
        {
            get
            {
                return this.dataSource;
            }
            set
            {
                this.dataSource = value;
            }
        }

        /// <summary>
        /// the class name of the report
        /// </summary>
        public string ReportName
        {
            get
            {
                return this.reportName;
            }
            set
            {
                this.reportName = value;
            }
        }

        public string ReportDatasourceName
        {

            get
            {
                return this.reportDatasourceName;
            }
            set
            {
                this.reportDatasourceName = value;
            }
        }

        /// <summary>
        /// Assigned to one of the following:
        /// Preview = screen (default)
        /// Printer = redirect to printer
        /// ExcelFile = generate Excel file
        /// PdfFile = generate PDF file
        /// </summary>
        public ReportDestinations ReportDestination
        {
            get
            {
                return this.reportDestination;
            }
            set
            {
                this.reportDestination = value;
            }
        }

        /// <summary>
        /// parameters used in the report
        /// string array: name, value
        /// e.g. string [,] param = {{"FromDate", "2008-08-01 00:00:00"}, {"ToDate", "2008-08-31 23:59:59"}}
        /// </summary>
        public string[,] Parameters
        {
            get
            {
                return this.parameters;
            }
            set
            {
                this.parameters = value;
            }
        }
        #endregion

        #region Preview Report
        private void PreviewReport()
        {
            this.RptViewer.ProcessingMode = ProcessingMode.Local;

            if (reportName != string.Empty)
            {
                this.RptViewer.LocalReport.ReportEmbeddedResource = reportName;
            }
            this.RptViewer.LocalReport.DataSources.Clear();

            ReportDataSource ds = new ReportDataSource(reportDatasourceName, dataSource);
            this.RptViewer.LocalReport.DataSources.Add(ds);
            this.RptViewer.LocalReport.EnableExternalImages = true;

            if (this.parameters != null)
            {
                int paramCount = this.parameters.GetLength(0);
                if (paramCount > 0)
                {
                    ReportParameter[] param = new ReportParameter[paramCount];
                    for (int i = 0; i < paramCount; i++)
                    {
                        param[i] = new ReportParameter(parameters[i, 0], parameters[i, 1]);
                    }
                    this.RptViewer.LocalReport.SetParameters(param);
                }
            }

            this.RptViewer.ProcessingMode = ProcessingMode.Local;
            this.RptViewer.Update();
        }
        #endregion

        void RptSubreportProcessingEventHandler(object sender, SubreportProcessingEventArgs e)
        {
            if (this.SubReportDataSourceList != null)
            {
                foreach (KeyValuePair<string, DataTable> kvp in this.SubReportDataSourceList)
                {
                    subDataSource = kvp.Value;
                    subDataSourceName = kvp.Key;

                    e.DataSources.Add(new ReportDataSource(subDataSourceName, subDataSource));
                }
            }
        }

        private void Viewer_Load(object sender, EventArgs e)
        {
        }

        private void RptViewer_HostedPageLoadComplete(object sender, Gizmox.WebGUI.Forms.Hosts.AspPageEventArgs e)
        {
            switch (reportDestination)
            {
                case ReportDestinations.Printer:
                    break;
                case ReportDestinations.ExcelFile:
                    break;
                case ReportDestinations.PdfFile:
                    break;
                case ReportDestinations.Preview:
                default:
                    PreviewReport();
                    break;
            }
        }

        /// <summary>
        /// Handles the HostedControlPreRender event of the RptViewer control.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RptViewer_HostedControlPreRender(object sender, Gizmox.WebGUI.Forms.Hosts.AspControlEventArgs e)
        {
            this.RptViewer.LocalReport.SubreportProcessing += new SubreportProcessingEventHandler(RptSubreportProcessingEventHandler);
        }
    }
}