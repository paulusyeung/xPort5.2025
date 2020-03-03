namespace xPort5.Order.Coding.Product
{
    partial class ProductRecord
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
            this.components = new System.ComponentModel.Container();
            Gizmox.WebGUI.Common.Resources.IconResourceHandle iconResourceHandle1 = new Gizmox.WebGUI.Common.Resources.IconResourceHandle();
            Gizmox.WebGUI.Common.Resources.IconResourceHandle iconResourceHandle2 = new Gizmox.WebGUI.Common.Resources.IconResourceHandle();
            Gizmox.WebGUI.Common.Resources.ImageResourceHandle imageResourceHandle1 = new Gizmox.WebGUI.Common.Resources.ImageResourceHandle();
            this.ansToolbar = new Gizmox.WebGUI.Forms.ToolBar();
            this.wspBackground = new Gizmox.WebGUI.Forms.Panel();
            this.cboColor = new xPort5.Controls.CheckedComboBox();
            this.cmdSmartProductCode = new Gizmox.WebGUI.Forms.Button();
            this.cmdSmartSKU = new Gizmox.WebGUI.Forms.Button();
            this.boxLogs = new Gizmox.WebGUI.Forms.GroupBox();
            this.lblModifiedOn = new Gizmox.WebGUI.Forms.Label();
            this.txtModifiedOn = new Gizmox.WebGUI.Forms.Label();
            this.txtModifiedBy = new Gizmox.WebGUI.Forms.Label();
            this.lblModifiedBy = new Gizmox.WebGUI.Forms.Label();
            this.lblCreatedBy = new Gizmox.WebGUI.Forms.Label();
            this.txtCreatedBy = new Gizmox.WebGUI.Forms.Label();
            this.txtCreatedOn = new Gizmox.WebGUI.Forms.Label();
            this.lblCreatedOn = new Gizmox.WebGUI.Forms.Label();
            this.tabArticle = new Gizmox.WebGUI.Forms.TabControl();
            this.tabPackage = new Gizmox.WebGUI.Forms.TabPage();
            this.tabSupplier = new Gizmox.WebGUI.Forms.TabPage();
            this.boxPicture = new Gizmox.WebGUI.Forms.GroupBox();
            this.imgProduct = new xPort5.Controls.ProductImage();
            this.txtRemarks = new Gizmox.WebGUI.Forms.TextBox();
            this.lblRemarks = new Gizmox.WebGUI.Forms.Label();
            this.cboOrigin = new Gizmox.WebGUI.Forms.ComboBox();
            this.lblOrigin = new Gizmox.WebGUI.Forms.Label();
            this.lblColor = new Gizmox.WebGUI.Forms.Label();
            this.lblCategory = new Gizmox.WebGUI.Forms.Label();
            this.txtBarcode = new Gizmox.WebGUI.Forms.TextBox();
            this.lblBarcode = new Gizmox.WebGUI.Forms.Label();
            this.txtDescription = new Gizmox.WebGUI.Forms.TextBox();
            this.lblProductName = new Gizmox.WebGUI.Forms.Label();
            this.txtItemCode = new Gizmox.WebGUI.Forms.TextBox();
            this.lblProductCode = new Gizmox.WebGUI.Forms.Label();
            this.txtItemSKU = new Gizmox.WebGUI.Forms.TextBox();
            this.lblSKU = new Gizmox.WebGUI.Forms.Label();
            this.colDept = new Gizmox.WebGUI.Forms.ColumnHeader();
            this.colClass = new Gizmox.WebGUI.Forms.ColumnHeader();
            this.colCategory = new Gizmox.WebGUI.Forms.ColumnHeader();
            this.colCategoryId = new Gizmox.WebGUI.Forms.ColumnHeader();
            this.toolTip1 = new Gizmox.WebGUI.Forms.ToolTip(this.components);
            this.cboCategory = new Gizmox.WebGUI.Forms.ComboBox();
            this.SuspendLayout();
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
            this.ansToolbar.TabIndex = 1;
            // 
            // wspBackground
            // 
            this.wspBackground.Anchor = Gizmox.WebGUI.Forms.AnchorStyles.None;
            this.wspBackground.Controls.Add(this.cboCategory);
            this.wspBackground.Controls.Add(this.cboColor);
            this.wspBackground.Controls.Add(this.cmdSmartProductCode);
            this.wspBackground.Controls.Add(this.cmdSmartSKU);
            this.wspBackground.Controls.Add(this.boxLogs);
            this.wspBackground.Controls.Add(this.tabArticle);
            this.wspBackground.Controls.Add(this.boxPicture);
            this.wspBackground.Controls.Add(this.txtRemarks);
            this.wspBackground.Controls.Add(this.lblRemarks);
            this.wspBackground.Controls.Add(this.cboOrigin);
            this.wspBackground.Controls.Add(this.lblOrigin);
            this.wspBackground.Controls.Add(this.lblColor);
            this.wspBackground.Controls.Add(this.lblCategory);
            this.wspBackground.Controls.Add(this.txtBarcode);
            this.wspBackground.Controls.Add(this.lblBarcode);
            this.wspBackground.Controls.Add(this.txtDescription);
            this.wspBackground.Controls.Add(this.lblProductName);
            this.wspBackground.Controls.Add(this.txtItemCode);
            this.wspBackground.Controls.Add(this.lblProductCode);
            this.wspBackground.Controls.Add(this.txtItemSKU);
            this.wspBackground.Controls.Add(this.lblSKU);
            this.wspBackground.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.wspBackground.DockPadding.All = 6;
            this.wspBackground.Location = new System.Drawing.Point(0, 28);
            this.wspBackground.Name = "wspBackground";
            this.wspBackground.Size = new System.Drawing.Size(627, 482);
            this.wspBackground.TabIndex = 0;
            // 
            // cboColor
            // 
            this.cboColor.Location = new System.Drawing.Point(98, 205);
            this.cboColor.Name = "cboColor";
            this.cboColor.Size = new System.Drawing.Size(297, 21);
            this.cboColor.TabIndex = 13;
            // 
            // cmdSmartProductCode
            // 
            iconResourceHandle1.File = "16x16.lightbulb.png";
            this.cmdSmartProductCode.Image = iconResourceHandle1;
            this.cmdSmartProductCode.Location = new System.Drawing.Point(371, 29);
            this.cmdSmartProductCode.Name = "cmdSmartProductCode";
            this.cmdSmartProductCode.Size = new System.Drawing.Size(24, 23);
            this.cmdSmartProductCode.TabIndex = 5;
            this.cmdSmartProductCode.TextImageRelation = Gizmox.WebGUI.Forms.TextImageRelation.ImageAboveText;
            this.cmdSmartProductCode.Visible = false;
            this.cmdSmartProductCode.Click += new System.EventHandler(this.cmdSmartProductCode_Click);
            // 
            // cmdSmartSKU
            // 
            iconResourceHandle2.File = "16x16.lightbulb.png";
            this.cmdSmartSKU.Image = iconResourceHandle2;
            this.cmdSmartSKU.Location = new System.Drawing.Point(371, 4);
            this.cmdSmartSKU.Name = "cmdSmartSKU";
            this.cmdSmartSKU.Size = new System.Drawing.Size(24, 23);
            this.cmdSmartSKU.TabIndex = 2;
            this.cmdSmartSKU.TextImageRelation = Gizmox.WebGUI.Forms.TextImageRelation.ImageAboveText;
            this.cmdSmartSKU.Visible = false;
            this.cmdSmartSKU.Click += new System.EventHandler(this.cmdSmartSKU_Click);
            // 
            // boxLogs
            // 
            this.boxLogs.Controls.Add(this.lblModifiedOn);
            this.boxLogs.Controls.Add(this.txtModifiedOn);
            this.boxLogs.Controls.Add(this.txtModifiedBy);
            this.boxLogs.Controls.Add(this.lblModifiedBy);
            this.boxLogs.Controls.Add(this.lblCreatedBy);
            this.boxLogs.Controls.Add(this.txtCreatedBy);
            this.boxLogs.Controls.Add(this.txtCreatedOn);
            this.boxLogs.Controls.Add(this.lblCreatedOn);
            this.boxLogs.FlatStyle = Gizmox.WebGUI.Forms.FlatStyle.Flat;
            this.boxLogs.Location = new System.Drawing.Point(405, 213);
            this.boxLogs.Name = "boxLogs";
            this.boxLogs.Size = new System.Drawing.Size(214, 106);
            this.boxLogs.TabIndex = 20;
            this.boxLogs.Text = "Logs";
            this.boxLogs.Visible = false;
            // 
            // lblModifiedOn
            // 
            this.lblModifiedOn.Location = new System.Drawing.Point(7, 61);
            this.lblModifiedOn.Name = "lblModifiedOn";
            this.lblModifiedOn.Size = new System.Drawing.Size(74, 21);
            this.lblModifiedOn.TabIndex = 4;
            this.lblModifiedOn.Text = "Modified On:";
            // 
            // txtModifiedOn
            // 
            this.txtModifiedOn.Location = new System.Drawing.Point(81, 61);
            this.txtModifiedOn.Name = "txtModifiedOn";
            this.txtModifiedOn.Size = new System.Drawing.Size(127, 21);
            this.txtModifiedOn.TabIndex = 5;
            this.txtModifiedOn.Text = "txtModifiedOn";
            // 
            // txtModifiedBy
            // 
            this.txtModifiedBy.Location = new System.Drawing.Point(81, 82);
            this.txtModifiedBy.Name = "txtModifiedBy";
            this.txtModifiedBy.Size = new System.Drawing.Size(127, 21);
            this.txtModifiedBy.TabIndex = 7;
            this.txtModifiedBy.Text = "txtModifiedBy";
            // 
            // lblModifiedBy
            // 
            this.lblModifiedBy.Location = new System.Drawing.Point(7, 82);
            this.lblModifiedBy.Name = "lblModifiedBy";
            this.lblModifiedBy.Size = new System.Drawing.Size(74, 21);
            this.lblModifiedBy.TabIndex = 6;
            this.lblModifiedBy.Text = "Modified By:";
            // 
            // lblCreatedBy
            // 
            this.lblCreatedBy.Location = new System.Drawing.Point(7, 40);
            this.lblCreatedBy.Name = "lblCreatedBy";
            this.lblCreatedBy.Size = new System.Drawing.Size(74, 21);
            this.lblCreatedBy.TabIndex = 2;
            this.lblCreatedBy.Text = "Created By:";
            // 
            // txtCreatedBy
            // 
            this.txtCreatedBy.Location = new System.Drawing.Point(81, 40);
            this.txtCreatedBy.Name = "txtCreatedBy";
            this.txtCreatedBy.Size = new System.Drawing.Size(127, 21);
            this.txtCreatedBy.TabIndex = 3;
            this.txtCreatedBy.Text = "txtCreatedBy";
            // 
            // txtCreatedOn
            // 
            this.txtCreatedOn.Location = new System.Drawing.Point(81, 19);
            this.txtCreatedOn.Name = "txtCreatedOn";
            this.txtCreatedOn.Size = new System.Drawing.Size(127, 21);
            this.txtCreatedOn.TabIndex = 1;
            this.txtCreatedOn.Text = "txtCreatedOn";
            // 
            // lblCreatedOn
            // 
            this.lblCreatedOn.Location = new System.Drawing.Point(7, 19);
            this.lblCreatedOn.Name = "lblCreatedOn";
            this.lblCreatedOn.Size = new System.Drawing.Size(74, 21);
            this.lblCreatedOn.TabIndex = 0;
            this.lblCreatedOn.Text = "Created On:";
            // 
            // tabArticle
            // 
            this.tabArticle.Anchor = Gizmox.WebGUI.Forms.AnchorStyles.None;
            this.tabArticle.Controls.Add(this.tabPackage);
            this.tabArticle.Controls.Add(this.tabSupplier);
            this.tabArticle.Dock = Gizmox.WebGUI.Forms.DockStyle.Bottom;
            this.tabArticle.Location = new System.Drawing.Point(6, 326);
            this.tabArticle.Multiline = false;
            this.tabArticle.Name = "tabArticle";
            this.tabArticle.SelectedIndex = 0;
            this.tabArticle.Size = new System.Drawing.Size(615, 150);
            this.tabArticle.TabIndex = 18;
            // 
            // tabPackage
            // 
            this.tabPackage.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.tabPackage.Location = new System.Drawing.Point(4, 22);
            this.tabPackage.Name = "tabPackage";
            this.tabPackage.Size = new System.Drawing.Size(607, 124);
            this.tabPackage.TabIndex = 0;
            this.tabPackage.Text = "Package";
            // 
            // tabSupplier
            // 
            this.tabSupplier.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.tabSupplier.Location = new System.Drawing.Point(4, 22);
            this.tabSupplier.Name = "tabSupplier";
            this.tabSupplier.Size = new System.Drawing.Size(607, 124);
            this.tabSupplier.TabIndex = 0;
            this.tabSupplier.Text = "Supplier";
            // 
            // boxPicture
            // 
            this.boxPicture.Controls.Add(this.imgProduct);
            this.boxPicture.FlatStyle = Gizmox.WebGUI.Forms.FlatStyle.Flat;
            this.boxPicture.Location = new System.Drawing.Point(405, 6);
            this.boxPicture.Name = "boxPicture";
            this.boxPicture.Size = new System.Drawing.Size(214, 200);
            this.boxPicture.TabIndex = 19;
            this.boxPicture.Text = "Picture";
            // 
            // imgProduct
            // 
            imageResourceHandle1.File = "no_photo.jpg";
            this.imgProduct.Image = imageResourceHandle1;
            this.imgProduct.Location = new System.Drawing.Point(6, 28);
            this.imgProduct.Name = "imgProduct";
            this.imgProduct.ProductId = new System.Guid("00000000-0000-0000-0000-000000000000");
            this.imgProduct.Size = new System.Drawing.Size(202, 151);
            this.imgProduct.SizeMode = Gizmox.WebGUI.Forms.PictureBoxSizeMode.StretchImage;
            this.imgProduct.TabIndex = 3;
            // 
            // txtRemarks
            // 
            this.txtRemarks.Location = new System.Drawing.Point(98, 259);
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.ScrollBars = Gizmox.WebGUI.Forms.ScrollBars.Vertical;
            this.txtRemarks.Size = new System.Drawing.Size(297, 60);
            this.txtRemarks.TabIndex = 17;
            // 
            // lblRemarks
            // 
            this.lblRemarks.Location = new System.Drawing.Point(6, 259);
            this.lblRemarks.Name = "lblRemarks";
            this.lblRemarks.Size = new System.Drawing.Size(90, 21);
            this.lblRemarks.TabIndex = 16;
            this.lblRemarks.Text = "Remarks:";
            // 
            // cboOrigin
            // 
            this.cboOrigin.DropDownStyle = Gizmox.WebGUI.Forms.ComboBoxStyle.DropDownList;
            this.cboOrigin.Location = new System.Drawing.Point(98, 232);
            this.cboOrigin.MaxDropDownItems = 10;
            this.cboOrigin.Name = "cboOrigin";
            this.cboOrigin.Size = new System.Drawing.Size(297, 21);
            this.cboOrigin.TabIndex = 15;
            // 
            // lblOrigin
            // 
            this.lblOrigin.Location = new System.Drawing.Point(6, 232);
            this.lblOrigin.Name = "lblOrigin";
            this.lblOrigin.Size = new System.Drawing.Size(90, 21);
            this.lblOrigin.TabIndex = 14;
            this.lblOrigin.Text = "Origin:";
            // 
            // lblColor
            // 
            this.lblColor.Location = new System.Drawing.Point(6, 205);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(90, 21);
            this.lblColor.TabIndex = 12;
            this.lblColor.Text = "Color:";
            // 
            // lblCategory
            // 
            this.lblCategory.Location = new System.Drawing.Point(6, 178);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(90, 21);
            this.lblCategory.TabIndex = 10;
            this.lblCategory.Text = "Category:";
            // 
            // txtBarcode
            // 
            this.txtBarcode.Location = new System.Drawing.Point(98, 152);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(297, 20);
            this.txtBarcode.TabIndex = 9;
            // 
            // lblBarcode
            // 
            this.lblBarcode.Location = new System.Drawing.Point(6, 152);
            this.lblBarcode.Name = "lblBarcode";
            this.lblBarcode.Size = new System.Drawing.Size(90, 21);
            this.lblBarcode.TabIndex = 8;
            this.lblBarcode.Text = "Barcode:";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(98, 56);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ScrollBars = Gizmox.WebGUI.Forms.ScrollBars.Vertical;
            this.txtDescription.Size = new System.Drawing.Size(297, 90);
            this.txtDescription.TabIndex = 7;
            // 
            // lblProductName
            // 
            this.lblProductName.Location = new System.Drawing.Point(6, 56);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(90, 21);
            this.lblProductName.TabIndex = 6;
            this.lblProductName.Text = "Description:";
            // 
            // txtItemCode
            // 
            this.txtItemCode.Location = new System.Drawing.Point(98, 31);
            this.txtItemCode.Name = "txtItemCode";
            this.txtItemCode.Size = new System.Drawing.Size(297, 20);
            this.txtItemCode.TabIndex = 4;
            // 
            // lblProductCode
            // 
            this.lblProductCode.Location = new System.Drawing.Point(6, 31);
            this.lblProductCode.Name = "lblProductCode";
            this.lblProductCode.Size = new System.Drawing.Size(90, 21);
            this.lblProductCode.TabIndex = 3;
            this.lblProductCode.Text = "Product Code:";
            // 
            // txtItemSKU
            // 
            this.txtItemSKU.Location = new System.Drawing.Point(98, 6);
            this.txtItemSKU.Name = "txtItemSKU";
            this.txtItemSKU.Size = new System.Drawing.Size(297, 20);
            this.txtItemSKU.TabIndex = 1;
            // 
            // lblSKU
            // 
            this.lblSKU.Location = new System.Drawing.Point(6, 6);
            this.lblSKU.Name = "lblSKU";
            this.lblSKU.Size = new System.Drawing.Size(90, 21);
            this.lblSKU.TabIndex = 0;
            this.lblSKU.Text = "SKU:";
            // 
            // colDept
            // 
            this.colDept.ContentAlign = Gizmox.WebGUI.Forms.ExtendedHorizontalAlignment.Center;
            this.colDept.Image = null;
            this.colDept.Text = "Department";
            this.colDept.Width = 100;
            // 
            // colClass
            // 
            this.colClass.ContentAlign = Gizmox.WebGUI.Forms.ExtendedHorizontalAlignment.Center;
            this.colClass.Image = null;
            this.colClass.Text = "Class";
            this.colClass.Width = 100;
            // 
            // colCategory
            // 
            this.colCategory.ContentAlign = Gizmox.WebGUI.Forms.ExtendedHorizontalAlignment.Center;
            this.colCategory.Image = null;
            this.colCategory.Text = "Cateogry";
            this.colCategory.Width = 100;
            // 
            // colCategoryId
            // 
            this.colCategoryId.Image = null;
            this.colCategoryId.Text = "Category Id";
            this.colCategoryId.Visible = false;
            this.colCategoryId.Width = 150;
            // 
            // cboCategory
            // 
            this.cboCategory.DropDownStyle = Gizmox.WebGUI.Forms.ComboBoxStyle.DropDownList;
            this.cboCategory.Location = new System.Drawing.Point(98, 178);
            this.cboCategory.Name = "cboCategory";
            this.cboCategory.Size = new System.Drawing.Size(297, 21);
            this.cboCategory.TabIndex = 21;
            // 
            // ProductRecord
            // 
            this.Controls.Add(this.wspBackground);
            this.Controls.Add(this.ansToolbar);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Size = new System.Drawing.Size(627, 510);
            this.StartPosition = Gizmox.WebGUI.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product Record";
            this.Load += new System.EventHandler(this.ArticleRecord_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Gizmox.WebGUI.Forms.ToolBar ansToolbar;
        private Gizmox.WebGUI.Forms.Panel wspBackground;
        private Gizmox.WebGUI.Forms.TextBox txtItemSKU;
        private Gizmox.WebGUI.Forms.Label lblSKU;
        private Gizmox.WebGUI.Forms.TextBox txtBarcode;
        private Gizmox.WebGUI.Forms.Label lblBarcode;
        private Gizmox.WebGUI.Forms.TextBox txtDescription;
        private Gizmox.WebGUI.Forms.Label lblProductName;
        private Gizmox.WebGUI.Forms.TextBox txtItemCode;
        private Gizmox.WebGUI.Forms.Label lblProductCode;
        private Gizmox.WebGUI.Forms.Label lblCategory;
        private Gizmox.WebGUI.Forms.ToolTip toolTip1;
        private Gizmox.WebGUI.Forms.Label lblColor;
        private Gizmox.WebGUI.Forms.TextBox txtRemarks;
        private Gizmox.WebGUI.Forms.Label lblRemarks;
        private Gizmox.WebGUI.Forms.ComboBox cboOrigin;
        private Gizmox.WebGUI.Forms.Label lblOrigin;
        private Gizmox.WebGUI.Forms.GroupBox boxPicture;
        private xPort5.Controls.ProductImage imgProduct;
        private Gizmox.WebGUI.Forms.TabControl tabArticle;
        private Gizmox.WebGUI.Forms.TabPage tabPackage;
        private Gizmox.WebGUI.Forms.TabPage tabSupplier;
        private Gizmox.WebGUI.Forms.ColumnHeader colDept;
        private Gizmox.WebGUI.Forms.ColumnHeader colClass;
        private Gizmox.WebGUI.Forms.ColumnHeader colCategory;
        private Gizmox.WebGUI.Forms.ColumnHeader colCategoryId;
        private Gizmox.WebGUI.Forms.GroupBox boxLogs;
        private Gizmox.WebGUI.Forms.Label lblModifiedOn;
        private Gizmox.WebGUI.Forms.Label txtModifiedOn;
        private Gizmox.WebGUI.Forms.Label txtModifiedBy;
        private Gizmox.WebGUI.Forms.Label lblModifiedBy;
        private Gizmox.WebGUI.Forms.Label lblCreatedBy;
        private Gizmox.WebGUI.Forms.Label txtCreatedBy;
        private Gizmox.WebGUI.Forms.Label txtCreatedOn;
        private Gizmox.WebGUI.Forms.Label lblCreatedOn;
        private Gizmox.WebGUI.Forms.Button cmdSmartSKU;
        private Gizmox.WebGUI.Forms.Button cmdSmartProductCode;
        private xPort5.Controls.CheckedComboBox cboColor;
        private Gizmox.WebGUI.Forms.ComboBox cboCategory;


    }
}