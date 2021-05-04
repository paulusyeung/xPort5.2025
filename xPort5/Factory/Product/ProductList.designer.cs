namespace xPort5.Factory.Product
{
    partial class ProductList
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
            Gizmox.WebGUI.Common.Resources.IconResourceHandle iconResourceHandle1 = new Gizmox.WebGUI.Common.Resources.IconResourceHandle();
            Gizmox.WebGUI.Common.Resources.IconResourceHandle iconResourceHandle2 = new Gizmox.WebGUI.Common.Resources.IconResourceHandle();
            Gizmox.WebGUI.Common.Resources.IconResourceHandle iconResourceHandle3 = new Gizmox.WebGUI.Common.Resources.IconResourceHandle();
            Gizmox.WebGUI.Common.Resources.IconResourceHandle iconResourceHandle4 = new Gizmox.WebGUI.Common.Resources.IconResourceHandle();
            this.colProductCode = new Gizmox.WebGUI.Forms.ColumnHeader();
            this.cboViews = new Gizmox.WebGUI.Forms.ComboBox();
            this.colLN = new Gizmox.WebGUI.Forms.ColumnHeader();
            this.splitContainer = new Gizmox.WebGUI.Forms.SplitContainer();
            this.ansProductList = new Gizmox.WebGUI.Forms.ToolBar();
            this.lksPane = new Gizmox.WebGUI.Forms.Panel();
            this.cmdLookup = new Gizmox.WebGUI.Forms.Button();
            this.lblViews = new Gizmox.WebGUI.Forms.Label();
            this.txtLookup = new Gizmox.WebGUI.Forms.TextBox();
            this.lblLookup = new Gizmox.WebGUI.Forms.Label();
            this.flpImageList = new Gizmox.WebGUI.Forms.FlowLayoutPanel();
            this.lvwProductList = new Gizmox.WebGUI.Forms.ListView();
            this.colProductId = new Gizmox.WebGUI.Forms.ColumnHeader();
            this.colStatus = new Gizmox.WebGUI.Forms.ColumnHeader();
            this.colSupplier = new Gizmox.WebGUI.Forms.ColumnHeader();
            this.colPackage = new Gizmox.WebGUI.Forms.ColumnHeader();
            this.colDescription = new Gizmox.WebGUI.Forms.ColumnHeader();
            this.colCategory = new Gizmox.WebGUI.Forms.ColumnHeader();
            this.colColor = new Gizmox.WebGUI.Forms.ColumnHeader();
            this.colOrigin = new Gizmox.WebGUI.Forms.ColumnHeader();
            this.colRemarks = new Gizmox.WebGUI.Forms.ColumnHeader();
            this.colCreatedOn = new Gizmox.WebGUI.Forms.ColumnHeader();
            this.colCreatedBy = new Gizmox.WebGUI.Forms.ColumnHeader();
            this.colModifiedOn = new Gizmox.WebGUI.Forms.ColumnHeader();
            this.colModifiedBy = new Gizmox.WebGUI.Forms.ColumnHeader();
            this.toolTip1 = new Gizmox.WebGUI.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // colProductCode
            // 
            this.colProductCode.ContentAlign = Gizmox.WebGUI.Forms.ExtendedHorizontalAlignment.Center;
            this.colProductCode.Image = null;
            this.colProductCode.Text = "Product Code";
            this.colProductCode.Width = 90;
            // 
            // cboViews
            // 
            this.cboViews.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.cboViews.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.Fixed3D;
            this.cboViews.DropDownWidth = 140;
            this.cboViews.Location = new System.Drawing.Point(891, 7);
            this.cboViews.Name = "cboViews";
            this.cboViews.Size = new System.Drawing.Size(140, 21);
            this.cboViews.TabIndex = 1;
            this.cboViews.SelectedIndexChanged += new System.EventHandler(this.cboViews_SelectedIndexChanged);
            // 
            // colLN
            // 
            this.colLN.ContentAlign = Gizmox.WebGUI.Forms.ExtendedHorizontalAlignment.Center;
            this.colLN.Image = null;
            this.colLN.Tag = "Numeric";
            this.colLN.Text = "#";
            this.colLN.TextAlign = Gizmox.WebGUI.Forms.HorizontalAlignment.Center;
            this.colLN.Width = 30;
            // 
            // splitContainer
            // 
            this.splitContainer.Anchor = Gizmox.WebGUI.Forms.AnchorStyles.None;
            this.splitContainer.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.Clear;
            this.splitContainer.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.splitContainer.FixedPanel = Gizmox.WebGUI.Forms.FixedPanel.Panel1;
            this.splitContainer.IsSplitterFixed = true;
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
            this.splitContainer.Name = "splitContainer";
            this.splitContainer.Orientation = Gizmox.WebGUI.Forms.Orientation.Horizontal;
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.ansProductList);
            this.splitContainer.Panel1.Controls.Add(this.lksPane);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.flpImageList);
            this.splitContainer.Panel2.Controls.Add(this.lvwProductList);
            this.splitContainer.Size = new System.Drawing.Size(1031, 405);
            this.splitContainer.SplitterDistance = 60;
            this.splitContainer.SplitterWidth = 1;
            this.splitContainer.TabIndex = 0;
            // 
            // ansProductList
            // 
            this.ansProductList.Anchor = Gizmox.WebGUI.Forms.AnchorStyles.None;
            this.ansProductList.Appearance = Gizmox.WebGUI.Forms.ToolBarAppearance.Normal;
            this.ansProductList.Dock = Gizmox.WebGUI.Forms.DockStyle.Top;
            this.ansProductList.DragHandle = true;
            this.ansProductList.DropDownArrows = false;
            this.ansProductList.ImageList = null;
            this.ansProductList.Location = new System.Drawing.Point(0, 34);
            this.ansProductList.MenuHandle = true;
            this.ansProductList.Name = "ansProductList";
            this.ansProductList.RightToLeft = Gizmox.WebGUI.Forms.RightToLeft.No;
            this.ansProductList.ShowToolTips = true;
            this.ansProductList.TabIndex = 1;
            // 
            // lksPane
            // 
            this.lksPane.Anchor = Gizmox.WebGUI.Forms.AnchorStyles.None;
            this.lksPane.AutoSizeMode = Gizmox.WebGUI.Forms.AutoSizeMode.GrowAndShrink;
            this.lksPane.Controls.Add(this.cmdLookup);
            this.lksPane.Controls.Add(this.lblViews);
            this.lksPane.Controls.Add(this.txtLookup);
            this.lksPane.Controls.Add(this.cboViews);
            this.lksPane.Controls.Add(this.lblLookup);
            this.lksPane.Dock = Gizmox.WebGUI.Forms.DockStyle.Top;
            this.lksPane.Location = new System.Drawing.Point(0, 0);
            this.lksPane.Name = "lksPane";
            this.lksPane.Size = new System.Drawing.Size(1031, 34);
            this.lksPane.TabIndex = 0;
            // 
            // cmdLookup
            // 
            iconResourceHandle1.File = "16x16.16_find.gif";
            this.cmdLookup.Image = iconResourceHandle1;
            this.cmdLookup.Location = new System.Drawing.Point(183, 6);
            this.cmdLookup.Name = "cmdLookup";
            this.cmdLookup.Size = new System.Drawing.Size(22, 22);
            this.cmdLookup.TabIndex = 4;
            this.cmdLookup.TabStop = false;
            this.cmdLookup.TextImageRelation = Gizmox.WebGUI.Forms.TextImageRelation.ImageAboveText;
            this.cmdLookup.Click += new System.EventHandler(this.cmdLookup_Click);
            // 
            // lblViews
            // 
            this.lblViews.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.lblViews.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblViews.Location = new System.Drawing.Point(847, 10);
            this.lblViews.Name = "lblViews";
            this.lblViews.Size = new System.Drawing.Size(44, 17);
            this.lblViews.TabIndex = 3;
            this.lblViews.Text = "Views:";
            // 
            // txtLookup
            // 
            this.txtLookup.Location = new System.Drawing.Point(63, 7);
            this.txtLookup.Name = "txtLookup";
            this.txtLookup.Size = new System.Drawing.Size(120, 20);
            this.txtLookup.TabIndex = 2;
            this.txtLookup.EnterKeyDown += new Gizmox.WebGUI.Forms.KeyEventHandler(this.txtLookup_EnterKeyDown);
            // 
            // lblLookup
            // 
            this.lblLookup.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblLookup.Location = new System.Drawing.Point(2, 9);
            this.lblLookup.Name = "lblLookup";
            this.lblLookup.Size = new System.Drawing.Size(61, 18);
            this.lblLookup.TabIndex = 0;
            this.lblLookup.Text = "Look for:";
            // 
            // flpImageList
            // 
            this.flpImageList.BackColor = System.Drawing.Color.White;
            this.flpImageList.FlowDirection = Gizmox.WebGUI.Forms.FlowDirection.LeftToRight;
            this.flpImageList.Location = new System.Drawing.Point(310, 0);
            this.flpImageList.Name = "flpImageList";
            this.flpImageList.Size = new System.Drawing.Size(300, 300);
            this.flpImageList.TabIndex = 1;
            this.flpImageList.Visible = false;
            this.flpImageList.WrapContents = false;
            // 
            // lvwProductList
            // 
            this.lvwProductList.Columns.AddRange(new Gizmox.WebGUI.Forms.ColumnHeader[] {
            this.colProductCode,
            this.colProductId,
            this.colStatus,
            this.colSupplier,
            this.colPackage,
            this.colLN,
            this.colDescription,
            this.colCategory,
            this.colColor,
            this.colOrigin,
            this.colRemarks,
            this.colCreatedOn,
            this.colCreatedBy,
            this.colModifiedOn,
            this.colModifiedBy});
            this.lvwProductList.DataMember = null;
            this.lvwProductList.GridLines = true;
            this.lvwProductList.ItemsPerPage = 500;
            this.lvwProductList.Location = new System.Drawing.Point(0, 0);
            this.lvwProductList.MultiSelect = false;
            this.lvwProductList.Name = "lvwProductList";
            this.lvwProductList.Size = new System.Drawing.Size(300, 300);
            this.lvwProductList.TabIndex = 0;
            this.lvwProductList.UseInternalPaging = true;
            this.lvwProductList.DoubleClick += new System.EventHandler(this.lvwProductList_DoubleClick);
            this.lvwProductList.ColumnClick += new Gizmox.WebGUI.Forms.ColumnClickEventHandler(this.lvwProductList_ColumnClick);
            // 
            // colProductId
            // 
            this.colProductId.Image = null;
            this.colProductId.Text = "ProductId";
            this.colProductId.Visible = false;
            this.colProductId.Width = 150;
            // 
            // colStatus
            // 
            this.colStatus.ContentAlign = Gizmox.WebGUI.Forms.ExtendedHorizontalAlignment.Center;
            iconResourceHandle2.File = "16x16.flag_grey.png";
            this.colStatus.Image = iconResourceHandle2;
            this.colStatus.Text = "";
            this.colStatus.Type = Gizmox.WebGUI.Forms.ListViewColumnType.Icon;
            this.colStatus.Width = 24;
            // 
            // colSupplier
            // 
            this.colSupplier.ContentAlign = Gizmox.WebGUI.Forms.ExtendedHorizontalAlignment.Center;
            iconResourceHandle3.File = "16x16.supplierSingleGrey_16.gif";
            this.colSupplier.Image = iconResourceHandle3;
            this.colSupplier.Text = "";
            this.colSupplier.Type = Gizmox.WebGUI.Forms.ListViewColumnType.Icon;
            this.colSupplier.Width = 24;
            // 
            // colPackage
            // 
            this.colPackage.ContentAlign = Gizmox.WebGUI.Forms.ExtendedHorizontalAlignment.Center;
            iconResourceHandle4.File = "16x16.packageGrey_16.png";
            this.colPackage.Image = iconResourceHandle4;
            this.colPackage.Text = "";
            this.colPackage.Type = Gizmox.WebGUI.Forms.ListViewColumnType.Icon;
            this.colPackage.Width = 24;
            // 
            // colDescription
            // 
            this.colDescription.ContentAlign = Gizmox.WebGUI.Forms.ExtendedHorizontalAlignment.Center;
            this.colDescription.Image = null;
            this.colDescription.Text = "Description";
            this.colDescription.Width = 150;
            // 
            // colCategory
            // 
            this.colCategory.ContentAlign = Gizmox.WebGUI.Forms.ExtendedHorizontalAlignment.Center;
            this.colCategory.Image = null;
            this.colCategory.Text = "Category";
            this.colCategory.Width = 100;
            // 
            // colColor
            // 
            this.colColor.ContentAlign = Gizmox.WebGUI.Forms.ExtendedHorizontalAlignment.Center;
            this.colColor.Image = null;
            this.colColor.Text = "Color";
            this.colColor.Width = 100;
            // 
            // colOrigin
            // 
            this.colOrigin.ContentAlign = Gizmox.WebGUI.Forms.ExtendedHorizontalAlignment.Center;
            this.colOrigin.Image = null;
            this.colOrigin.Text = "Origin";
            this.colOrigin.Width = 100;
            // 
            // colRemarks
            // 
            this.colRemarks.ContentAlign = Gizmox.WebGUI.Forms.ExtendedHorizontalAlignment.Center;
            this.colRemarks.Image = null;
            this.colRemarks.Text = "Remarks";
            this.colRemarks.Width = 150;
            // 
            // colCreatedOn
            // 
            this.colCreatedOn.ContentAlign = Gizmox.WebGUI.Forms.ExtendedHorizontalAlignment.Center;
            this.colCreatedOn.Image = null;
            this.colCreatedOn.Text = "Created On";
            this.colCreatedOn.Width = 100;
            // 
            // colCreatedBy
            // 
            this.colCreatedBy.ContentAlign = Gizmox.WebGUI.Forms.ExtendedHorizontalAlignment.Center;
            this.colCreatedBy.Image = null;
            this.colCreatedBy.Text = "Created By";
            this.colCreatedBy.Width = 70;
            // 
            // colModifiedOn
            // 
            this.colModifiedOn.ContentAlign = Gizmox.WebGUI.Forms.ExtendedHorizontalAlignment.Center;
            this.colModifiedOn.Image = null;
            this.colModifiedOn.Text = "Modified On";
            this.colModifiedOn.Width = 100;
            // 
            // colModifiedBy
            // 
            this.colModifiedBy.ContentAlign = Gizmox.WebGUI.Forms.ExtendedHorizontalAlignment.Center;
            this.colModifiedBy.Image = null;
            this.colModifiedBy.Text = "Modified By";
            this.colModifiedBy.Width = 70;
            // 
            // ProductList
            // 
            this.Controls.Add(this.splitContainer);
            this.Size = new System.Drawing.Size(1031, 405);
            this.Text = "Job Order Default Workspace";
            this.ResumeLayout(false);

        }

        #endregion

        private Gizmox.WebGUI.Forms.ColumnHeader colProductCode;
        private Gizmox.WebGUI.Forms.ComboBox cboViews;
        private Gizmox.WebGUI.Forms.ColumnHeader colLN;
        private Gizmox.WebGUI.Forms.SplitContainer splitContainer;
        private Gizmox.WebGUI.Forms.ToolBar ansProductList;
        private Gizmox.WebGUI.Forms.Panel lksPane;
        private Gizmox.WebGUI.Forms.Button cmdLookup;
        private Gizmox.WebGUI.Forms.Label lblViews;
        private Gizmox.WebGUI.Forms.TextBox txtLookup;
        private Gizmox.WebGUI.Forms.Label lblLookup;
        private Gizmox.WebGUI.Forms.ListView lvwProductList;
        private Gizmox.WebGUI.Forms.ColumnHeader colDescription;
        private Gizmox.WebGUI.Forms.ColumnHeader colCategory;
        private Gizmox.WebGUI.Forms.ColumnHeader colCreatedOn;
        private Gizmox.WebGUI.Forms.ColumnHeader colCreatedBy;
        private Gizmox.WebGUI.Forms.ColumnHeader colModifiedOn;
        private Gizmox.WebGUI.Forms.ColumnHeader colColor;
        private Gizmox.WebGUI.Forms.ColumnHeader colOrigin;
        private Gizmox.WebGUI.Forms.ColumnHeader colRemarks;
        private Gizmox.WebGUI.Forms.ColumnHeader colModifiedBy;
        private Gizmox.WebGUI.Forms.ColumnHeader colStatus;
        private Gizmox.WebGUI.Forms.ToolTip toolTip1;
        private Gizmox.WebGUI.Forms.ColumnHeader colProductId;
        private Gizmox.WebGUI.Forms.ColumnHeader colSupplier;
        private Gizmox.WebGUI.Forms.ColumnHeader colPackage;
        private Gizmox.WebGUI.Forms.FlowLayoutPanel flpImageList;

    }
}