namespace xPort5.Controls.Product
{
    partial class ImageManager_V2
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
            this.imagePane = new Gizmox.WebGUI.Forms.Panel();
            this.SuspendLayout();
            // 
            // imagePane
            // 
            this.imagePane.Anchor = Gizmox.WebGUI.Forms.AnchorStyles.None;
            this.imagePane.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.imagePane.Location = new System.Drawing.Point(0, 0);
            this.imagePane.Name = "imagePane";
            this.imagePane.Size = new System.Drawing.Size(640, 480);
            this.imagePane.TabIndex = 0;
            // 
            // ImageManager_V2
            // 
            this.Controls.Add(this.imagePane);
            this.FormBorderStyle = Gizmox.WebGUI.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Size = new System.Drawing.Size(640, 480);
            this.Text = "Image Manager";
            this.ResumeLayout(false);

        }

        #endregion

        private Gizmox.WebGUI.Forms.Panel imagePane;


    }
}