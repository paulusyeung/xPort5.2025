namespace xPort5.Controls
{
    partial class ProductImage_AllInOne
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
            this.components = new System.ComponentModel.Container();
            Gizmox.WebGUI.Forms.ImageList imageList1 = new Gizmox.WebGUI.Forms.ImageList();
            Gizmox.WebGUI.Common.Resources.IconResourceHandle iconResourceHandle1 = new Gizmox.WebGUI.Common.Resources.IconResourceHandle();
            Gizmox.WebGUI.Common.Resources.IconResourceHandle iconResourceHandle2 = new Gizmox.WebGUI.Common.Resources.IconResourceHandle();
            Gizmox.WebGUI.Common.Resources.IconResourceHandle iconResourceHandle3 = new Gizmox.WebGUI.Common.Resources.IconResourceHandle();
            Gizmox.WebGUI.Common.Resources.IconResourceHandle iconResourceHandle4 = new Gizmox.WebGUI.Common.Resources.IconResourceHandle();
            this.bottomPane = new Gizmox.WebGUI.Forms.Panel();
            this.thumbnailsPane = new Gizmox.WebGUI.Forms.FlowLayoutPanel();
            this.mainPane = new Gizmox.WebGUI.Forms.Panel();
            this.splitContainer = new Gizmox.WebGUI.Forms.SplitContainer();
            this.imagePane = new Gizmox.WebGUI.Forms.Panel();
            this.productImage = new xPort5.Controls.ProductImage();
            this.btnPrimary = new Gizmox.WebGUI.Forms.Button();
            this.btnDelete = new Gizmox.WebGUI.Forms.Button();
            this.btnAdd = new Gizmox.WebGUI.Forms.Button();
            this.btnZoom = new Gizmox.WebGUI.Forms.Button();
            this.topPane = new Gizmox.WebGUI.Forms.Panel();
            this.lblPictureName = new Gizmox.WebGUI.Forms.Label();
            this.toolTip1 = new Gizmox.WebGUI.Forms.ToolTip(this.components);
            this.openFileDialog = new Gizmox.WebGUI.Forms.OpenFileDialog();
            this.SuspendLayout();
            iconResourceHandle1.File = "16x16.magnify.gif";
            iconResourceHandle2.File = "16x16.plus.gif";
            iconResourceHandle3.File = "16x16.minus.gif";
            iconResourceHandle4.File = "16x16.key.gif";
            imageList1.Images.AddRange(new Gizmox.WebGUI.Common.Resources.ResourceHandle[] {
            iconResourceHandle1,
            iconResourceHandle2,
            iconResourceHandle3,
            iconResourceHandle4});
            imageList1.ImageSize = new System.Drawing.Size(16, 16);
            imageList1.Images.SetKeyName(0, "16x16.magnify.gif");
            imageList1.Images.SetKeyName(1, "16x16.plus.gif");
            imageList1.Images.SetKeyName(2, "16x16.minus.gif");
            imageList1.Images.SetKeyName(3, "16x16.key.gif");
            // 
            // bottomPane
            // 
            this.bottomPane.Anchor = Gizmox.WebGUI.Forms.AnchorStyles.None;
            this.bottomPane.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.FixedSingle;
            this.bottomPane.Controls.Add(this.thumbnailsPane);
            this.bottomPane.Dock = Gizmox.WebGUI.Forms.DockStyle.Bottom;
            this.bottomPane.Location = new System.Drawing.Point(0, 523);
            this.bottomPane.Name = "bottomPane";
            this.bottomPane.Size = new System.Drawing.Size(671, 64);
            this.bottomPane.TabIndex = 0;
            // 
            // thumbnailsPane
            // 
            this.thumbnailsPane.Anchor = Gizmox.WebGUI.Forms.AnchorStyles.None;
            this.thumbnailsPane.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.thumbnailsPane.DockPadding.All = 6;
            this.thumbnailsPane.FlowDirection = Gizmox.WebGUI.Forms.FlowDirection.LeftToRight;
            this.thumbnailsPane.Location = new System.Drawing.Point(0, 0);
            this.thumbnailsPane.Name = "thumbnailsPane";
            this.thumbnailsPane.Size = new System.Drawing.Size(669, 62);
            this.thumbnailsPane.TabIndex = 0;
            this.thumbnailsPane.WrapContents = false;
            // 
            // mainPane
            // 
            this.mainPane.Anchor = Gizmox.WebGUI.Forms.AnchorStyles.None;
            this.mainPane.Controls.Add(this.splitContainer);
            this.mainPane.Controls.Add(this.topPane);
            this.mainPane.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.mainPane.Location = new System.Drawing.Point(0, 0);
            this.mainPane.Name = "mainPane";
            this.mainPane.Size = new System.Drawing.Size(671, 523);
            this.mainPane.TabIndex = 1;
            // 
            // splitContainer
            // 
            this.splitContainer.Anchor = Gizmox.WebGUI.Forms.AnchorStyles.None;
            this.splitContainer.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.None;
            this.splitContainer.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.splitContainer.FixedPanel = Gizmox.WebGUI.Forms.FixedPanel.Panel2;
            this.splitContainer.Location = new System.Drawing.Point(0, 25);
            this.splitContainer.Name = "splitContainer";
            this.splitContainer.Orientation = Gizmox.WebGUI.Forms.Orientation.Vertical;
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.imagePane);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.btnPrimary);
            this.splitContainer.Panel2.Controls.Add(this.btnDelete);
            this.splitContainer.Panel2.Controls.Add(this.btnAdd);
            this.splitContainer.Panel2.Controls.Add(this.btnZoom);
            this.splitContainer.Size = new System.Drawing.Size(671, 498);
            this.splitContainer.SplitterDistance = 628;
            this.splitContainer.SplitterWidth = 1;
            this.splitContainer.TabIndex = 0;
            // 
            // imagePane
            // 
            this.imagePane.Anchor = Gizmox.WebGUI.Forms.AnchorStyles.None;
            this.imagePane.Controls.Add(this.productImage);
            this.imagePane.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.imagePane.Location = new System.Drawing.Point(0, 0);
            this.imagePane.Name = "imagePane";
            this.imagePane.Size = new System.Drawing.Size(628, 498);
            this.imagePane.TabIndex = 1;
            // 
            // productImage
            // 
            this.productImage.Image = null;
            this.productImage.Location = new System.Drawing.Point(36, 32);
            this.productImage.Name = "productImage";
            this.productImage.ProductId = new System.Guid("00000000-0000-0000-0000-000000000000");
            this.productImage.Size = new System.Drawing.Size(223, 228);
            this.productImage.SizeMode = Gizmox.WebGUI.Forms.PictureBoxSizeMode.Normal;
            this.productImage.TabIndex = 0;
            // 
            // btnPrimary
            // 
            this.btnPrimary.ImageKey = "16x16.key.gif";
            this.btnPrimary.ImageList = imageList1;
            this.btnPrimary.Location = new System.Drawing.Point(9, 76);
            this.btnPrimary.Name = "btnPrimary";
            this.btnPrimary.Size = new System.Drawing.Size(25, 23);
            this.btnPrimary.TabIndex = 0;
            this.btnPrimary.Click += new System.EventHandler(this.btnPrimary_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.ImageKey = "16x16.minus.gif";
            this.btnDelete.ImageList = imageList1;
            this.btnDelete.Location = new System.Drawing.Point(9, 53);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(25, 23);
            this.btnDelete.TabIndex = 0;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.ImageKey = "16x16.plus.gif";
            this.btnAdd.ImageList = imageList1;
            this.btnAdd.Location = new System.Drawing.Point(9, 30);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(25, 23);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnZoom
            // 
            this.btnZoom.ImageKey = "16x16.magnify.gif";
            this.btnZoom.ImageList = imageList1;
            this.btnZoom.Location = new System.Drawing.Point(9, 7);
            this.btnZoom.Name = "btnZoom";
            this.btnZoom.Size = new System.Drawing.Size(25, 23);
            this.btnZoom.TabIndex = 0;
            this.btnZoom.Click += new System.EventHandler(this.btnZoom_Click);
            // 
            // topPane
            // 
            this.topPane.Anchor = Gizmox.WebGUI.Forms.AnchorStyles.None;
            this.topPane.Controls.Add(this.lblPictureName);
            this.topPane.Dock = Gizmox.WebGUI.Forms.DockStyle.Top;
            this.topPane.Location = new System.Drawing.Point(0, 0);
            this.topPane.Name = "topPane";
            this.topPane.Size = new System.Drawing.Size(671, 25);
            this.topPane.TabIndex = 1;
            // 
            // lblPictureName
            // 
            this.lblPictureName.AutoSize = true;
            this.lblPictureName.Location = new System.Drawing.Point(11, 6);
            this.lblPictureName.Name = "lblPictureName";
            this.lblPictureName.Size = new System.Drawing.Size(100, 23);
            this.lblPictureName.TabIndex = 0;
            this.lblPictureName.Text = "Image file name";
            // 
            // openFileDialog
            // 
            this.openFileDialog.MaxFileSize = 10240;
            this.openFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog_FileOk);
            // 
            // ProductImage_AllInOne
            // 
            this.Controls.Add(this.mainPane);
            this.Controls.Add(this.bottomPane);
            this.Size = new System.Drawing.Size(671, 587);
            this.Text = "ProductImage_AllInOne";
            this.ResumeLayout(false);

        }

        #endregion

        private Gizmox.WebGUI.Forms.Panel bottomPane;
        private Gizmox.WebGUI.Forms.Panel mainPane;
        private Gizmox.WebGUI.Forms.SplitContainer splitContainer;
        private Gizmox.WebGUI.Forms.Button btnZoom;
        private Gizmox.WebGUI.Forms.Button btnPrimary;
        private Gizmox.WebGUI.Forms.Button btnDelete;
        private Gizmox.WebGUI.Forms.Button btnAdd;
        private ProductImage productImage;
        private Gizmox.WebGUI.Forms.FlowLayoutPanel thumbnailsPane;
        private Gizmox.WebGUI.Forms.Panel topPane;
        private Gizmox.WebGUI.Forms.Label lblPictureName;
        private Gizmox.WebGUI.Forms.ToolTip toolTip1;
        private Gizmox.WebGUI.Forms.OpenFileDialog openFileDialog;
        private Gizmox.WebGUI.Forms.Panel imagePane;


    }
}