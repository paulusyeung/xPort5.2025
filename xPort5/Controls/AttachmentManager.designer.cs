namespace xPort5.Controls
{
    partial class AttachmentManager
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
            this.paneAttachmentList = new Gizmox.WebGUI.Forms.FlowLayoutPanel();
            this.ansToolbar = new Gizmox.WebGUI.Forms.ToolBar();
            this.openFileDialog = new Gizmox.WebGUI.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // paneAttachmentList
            // 
            this.paneAttachmentList.Anchor = Gizmox.WebGUI.Forms.AnchorStyles.None;
            this.paneAttachmentList.AutoScroll = true;
            this.paneAttachmentList.AutoSizeMode = Gizmox.WebGUI.Forms.AutoSizeMode.GrowAndShrink;
            this.paneAttachmentList.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.paneAttachmentList.FlowDirection = Gizmox.WebGUI.Forms.FlowDirection.LeftToRight;
            this.paneAttachmentList.Location = new System.Drawing.Point(0, 28);
            this.paneAttachmentList.Name = "paneAttachmentList";
            this.paneAttachmentList.Size = new System.Drawing.Size(640, 452);
            this.paneAttachmentList.TabIndex = 1;
            this.paneAttachmentList.WrapContents = false;
            // 
            // ansToolbar
            // 
            this.ansToolbar.Anchor = Gizmox.WebGUI.Forms.AnchorStyles.None;
            this.ansToolbar.Appearance = Gizmox.WebGUI.Forms.ToolBarAppearance.Normal;
            this.ansToolbar.Dock = Gizmox.WebGUI.Forms.DockStyle.Top;
            this.ansToolbar.DragHandle = true;
            this.ansToolbar.DropDownArrows = false;
            this.ansToolbar.ImageList = null;
            this.ansToolbar.Location = new System.Drawing.Point(0, 0);
            this.ansToolbar.MenuHandle = true;
            this.ansToolbar.Name = "ansToolbar";
            this.ansToolbar.RightToLeft = Gizmox.WebGUI.Forms.RightToLeft.No;
            this.ansToolbar.ShowToolTips = true;
            this.ansToolbar.TabIndex = 0;
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "All files|*.*";
            this.openFileDialog.MaxFileSize = 10240;
            this.openFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog_FileOk);
            // 
            // AttachmentManager
            // 
            this.Controls.Add(this.paneAttachmentList);
            this.Controls.Add(this.ansToolbar);
            this.Size = new System.Drawing.Size(640, 480);
            this.Text = "AttachmentManager";
            this.ResumeLayout(false);

        }

        #endregion

        private Gizmox.WebGUI.Forms.FlowLayoutPanel paneAttachmentList;
        private Gizmox.WebGUI.Forms.ToolBar ansToolbar;
        private Gizmox.WebGUI.Forms.OpenFileDialog openFileDialog;


    }
}