namespace xPort5.NavPane
{
    partial class CodingNav
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
            this.navCoding = new Gizmox.WebGUI.Forms.TreeView();
            this.SuspendLayout();
            // 
            // navCoding
            // 
            this.navCoding.Anchor = Gizmox.WebGUI.Forms.AnchorStyles.None;
            this.navCoding.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.None;
            this.navCoding.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.navCoding.Location = new System.Drawing.Point(0, 0);
            this.navCoding.Name = "navCoding";
            this.navCoding.ShowLines = false;
            this.navCoding.Size = new System.Drawing.Size(391, 306);
            this.navCoding.TabIndex = 0;
            this.navCoding.AfterSelect += new Gizmox.WebGUI.Forms.TreeViewEventHandler(this.navInvt_AfterSelect);
            // 
            // CodingNav
            // 
            this.Controls.Add(this.navCoding);
            this.Size = new System.Drawing.Size(391, 306);
            this.Text = "Job Order";
            this.ResumeLayout(false);

        }

        #endregion

        private Gizmox.WebGUI.Forms.TreeView navCoding;


    }
}