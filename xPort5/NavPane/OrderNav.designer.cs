namespace xPort5.NavPane
{
    partial class OrderNav
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

        #region Visual WebGui UserControl Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.navOrder = new Gizmox.WebGUI.Forms.TreeView();
            this.SuspendLayout();
            // 
            // navOrder
            // 
            this.navOrder.Anchor = Gizmox.WebGUI.Forms.AnchorStyles.None;
            this.navOrder.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.None;
            this.navOrder.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.navOrder.Location = new System.Drawing.Point(0, 0);
            this.navOrder.Name = "navOrder";
            this.navOrder.ShowLines = false;
            this.navOrder.Size = new System.Drawing.Size(391, 306);
            this.navOrder.TabIndex = 0;
            this.navOrder.AfterSelect += new Gizmox.WebGUI.Forms.TreeViewEventHandler(this.navPurchase_AfterSelect);
            // 
            // OrderNav
            // 
            this.Controls.Add(this.navOrder);
            this.Size = new System.Drawing.Size(391, 306);
            this.Text = "Accounting";
            this.ResumeLayout(false);

        }

        #endregion

        private Gizmox.WebGUI.Forms.TreeView navOrder;


    }
}