namespace xPort5.Admin.Coding.Staff
{
    partial class StaffListAts
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
            this.atsUserList = new Gizmox.WebGUI.Forms.ToolBar();
            this.SuspendLayout();
            // 
            // atsUserList
            // 
            this.atsUserList.Anchor = Gizmox.WebGUI.Forms.AnchorStyles.None;
            this.atsUserList.Appearance = Gizmox.WebGUI.Forms.ToolBarAppearance.Normal;
            this.atsUserList.Dock = Gizmox.WebGUI.Forms.DockStyle.Top;
            this.atsUserList.DragHandle = true;
            this.atsUserList.DropDownArrows = false;
            this.atsUserList.ImageList = null;
            this.atsUserList.Location = new System.Drawing.Point(0, 0);
            this.atsUserList.MenuHandle = true;
            this.atsUserList.Name = "atsUserList";
            this.atsUserList.RightToLeft = Gizmox.WebGUI.Forms.RightToLeft.No;
            this.atsUserList.ShowToolTips = true;
            this.atsUserList.TabIndex = 0;
            // 
            // UserListAts
            // 
            this.Controls.Add(this.atsUserList);
            this.Size = new System.Drawing.Size(391, 306);
            this.Text = "UserListAts";
            this.ResumeLayout(false);

        }

        #endregion

        private Gizmox.WebGUI.Forms.ToolBar atsUserList;


    }
}