namespace xPort5.AtsPane
{
    partial class CodingAts
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
            this.atsCoding = new Gizmox.WebGUI.Forms.ToolBar();
            this.SuspendLayout();
            // 
            // atsCoding
            // 
            this.atsCoding.Anchor = Gizmox.WebGUI.Forms.AnchorStyles.None;
            this.atsCoding.Appearance = Gizmox.WebGUI.Forms.ToolBarAppearance.Normal;
            this.atsCoding.Dock = Gizmox.WebGUI.Forms.DockStyle.Top;
            this.atsCoding.DragHandle = true;
            this.atsCoding.DropDownArrows = false;
            this.atsCoding.ImageList = null;
            this.atsCoding.Location = new System.Drawing.Point(0, 0);
            this.atsCoding.MenuHandle = true;
            this.atsCoding.Name = "atsCoding";
            this.atsCoding.RightToLeft = Gizmox.WebGUI.Forms.RightToLeft.No;
            this.atsCoding.ShowToolTips = true;
            this.atsCoding.TabIndex = 0;
            // 
            // CodingAts
            // 
            this.Controls.Add(this.atsCoding);
            this.Size = new System.Drawing.Size(391, 306);
            this.Text = "Job Order";
            this.ResumeLayout(false);

        }

        #endregion

        private Gizmox.WebGUI.Forms.ToolBar atsCoding;


    }
}