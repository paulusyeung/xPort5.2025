namespace xPort5.Order.PurchaseContract
{
    partial class PrintManager
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
            this.customPanel1 = new xPort5.Controls.CustomPanel.CustomPanel();
            this.SuspendLayout();
            // 
            // customPanel1
            // 
            this.customPanel1.Anchor = Gizmox.WebGUI.Forms.AnchorStyles.None;
            this.customPanel1.AutoScroll = true;
            this.customPanel1.DataSource = null;
            this.customPanel1.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.customPanel1.DockPadding.Top = 20;
            this.customPanel1.Location = new System.Drawing.Point(0, 0);
            this.customPanel1.Name = "customPanel1";
            this.customPanel1.PanelType = xPort5.Controls.CustomPanel.PanelEnums.PanelViews.CardView;
            this.customPanel1.Size = new System.Drawing.Size(860, 455);
            this.customPanel1.TabIndex = 0;
            this.customPanel1.Text = "PanelList";
            this.customPanel1.Click += new System.EventHandler(this.customPanel1_Click);
            // 
            // PrintManager
            // 
            this.Controls.Add(this.customPanel1);
            this.MaximizeBox = false;
            this.Size = new System.Drawing.Size(860, 455);
            this.Text = "PrintManager";
            this.Load += new System.EventHandler(this.PrintManager_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private xPort5.Controls.CustomPanel.CustomPanel customPanel1;



    }
}