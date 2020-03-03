#region Using

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Web;
using System.Web.UI;

using Gizmox.WebGUI.Common;
using Gizmox.WebGUI.Forms;
using Gizmox.WebGUI.Common.Interfaces;
using Gizmox.WebGUI.Common.Gateways;
using Gizmox.WebGUI.Common.Resources;

#endregion

namespace xPort5.Controls.Reporting.XR
{
    public partial class Viewer : Form, IGatewayComponent
    {
        private string _ReportName = String.Empty;
        private MemoryStream _BinarySource = null;
        private string _ReportFormat = "pdf";

        public Viewer()
        {
            InitializeComponent();
        }

        #region public properties
        public string ReportName
        {
            set
            {
                _ReportName = value;
            }
        }
        public MemoryStream BinarySource
        {
            set
            {
                _BinarySource = value;
            }
        }
        public string ReportFormat
        {
            set
            {
                _ReportFormat = value;
            }
        }
        #endregion

        #region IGatewayControl
        void IGatewayComponent.ProcessRequest(IContext objContext, string strAction)
        {
            // Trt to get the gateway handler
            IGatewayHandler objGatewayHandler = ProcessGatewayRequest(objContext.HttpContext, strAction);

            if (objGatewayHandler != null)
            {
                objGatewayHandler.ProcessGatewayRequest(objContext, this);
            }
        }

        protected override IGatewayHandler ProcessGatewayRequest(HttpContext objHttpContext, string strAction)
        {
            IGatewayHandler objGH = null;

            if (!String.IsNullOrEmpty(strAction) && strAction.Equals("FileContent"))
            {
                if (objHttpContext != null &&
                    objHttpContext != null &&
                    objHttpContext.Response != null)
                {
                    // Disable cache.
                    objHttpContext.Response.Expires = -1;

                    // Set Headers for the Pdf attachment
                    switch (_ReportFormat.ToLower())
                    {
                        case "excel":
                            if (_ReportName.ToLower().IndexOf(".xls") == -1)
                            {
                                _ReportName += ".xls";
                            }
                            objHttpContext.Response.ContentType = "application/vnd.ms-excel";
                            objHttpContext.Response.AddHeader("Content-Disposition", String.Format("attachment;filename={0};", _ReportName));
                            break;
                        case "pdf":
                        default:
                            if (_ReportName.ToLower().IndexOf(".pdf") == -1)
                            {
                                _ReportName += ".pdf";
                            }
                            objHttpContext.Response.ContentType = "application/pdf";
                            objHttpContext.Response.AddHeader("Content-Disposition", String.Format("inline;filename={0};", _ReportName));
                            break;
                    }

                    objHttpContext.Response.BinaryWrite(_BinarySource.ToArray());
                    objHttpContext.Response.Flush();
                    objHttpContext.Response.End();
                }
            }

            return objGH;
        }
        #endregion

        private void Viewer_Load(object sender, EventArgs e)
        {
            htmlBox1.Resource = new GatewayResourceHandle(new GatewayReference(this, "FileContent"));
            htmlBox1.Update();
        }
    }
}