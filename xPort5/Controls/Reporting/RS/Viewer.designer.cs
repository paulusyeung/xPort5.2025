namespace xPort5.Controls.Reporting.RS
{
    partial class Viewer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Viewer));
            this.RptViewer = new xPort5.Controls.Reporting.RS.ReportViewer();
            this.SuspendLayout();
            // 
            // RptViewer
            // 
            this.RptViewer.Anchor = Gizmox.WebGUI.Forms.AnchorStyles.None;
            this.RptViewer.AsyncRendering = false;
            this.RptViewer.AutoScroll = false;
            this.RptViewer.ControlCode = resources.GetString("RptViewer.ControlCode");
            this.RptViewer.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.RptViewer.Location = new System.Drawing.Point(0, 0);
            this.RptViewer.Name = "RptViewer";
            this.RptViewer.Size = new System.Drawing.Size(750, 620);
            this.RptViewer.TabIndex = 0;
            this.RptViewer.ZoomMode = Microsoft.Reporting.WebForms.ZoomMode.PageWidth;
            this.RptViewer.HostedControlPreRender += new Gizmox.WebGUI.Forms.Hosts.AspControlEventHandler(this.RptViewer_HostedControlPreRender);
            this.RptViewer.HostedPageLoadComplete += new Gizmox.WebGUI.Forms.Hosts.AspPageEventHandler(this.RptViewer_HostedPageLoadComplete);
            // 
            // Viewer
            // 
            this.Controls.Add(this.RptViewer);
            this.Size = new System.Drawing.Size(750, 620);
            this.Text = "Report Viewer";
            this.Load += new System.EventHandler(this.Viewer_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private RS.ReportViewer RptViewer;



    }
}