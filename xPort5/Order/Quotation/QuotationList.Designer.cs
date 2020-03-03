namespace xPort5.Order.Quotation
{
    partial class QuotationList
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
            this.lksPane = new Gizmox.WebGUI.Forms.Panel();
            this.cmdLookup = new Gizmox.WebGUI.Forms.Button();
            this.lblViews = new Gizmox.WebGUI.Forms.Label();
            this.txtLookup = new Gizmox.WebGUI.Forms.TextBox();
            this.cboViews = new Gizmox.WebGUI.Forms.ComboBox();
            this.lblLookup = new Gizmox.WebGUI.Forms.Label();
            this.leftPane = new Gizmox.WebGUI.Forms.Panel();
            this.tvwCustomer = new Gizmox.WebGUI.Forms.TreeView();
            this.ansTree = new Gizmox.WebGUI.Forms.ToolBar();
            this.splitter1 = new Gizmox.WebGUI.Forms.Splitter();
            this.rightPane = new Gizmox.WebGUI.Forms.Panel();
            this.lvwList = new Gizmox.WebGUI.Forms.ListView();
            this.colItemNumber = new Gizmox.WebGUI.Forms.ColumnHeader();
            this.colItemId = new Gizmox.WebGUI.Forms.ColumnHeader();
            this.colStatus = new Gizmox.WebGUI.Forms.ColumnHeader();
            this.colSample = new Gizmox.WebGUI.Forms.ColumnHeader();
            this.colLN = new Gizmox.WebGUI.Forms.ColumnHeader();
            this.colDate = new Gizmox.WebGUI.Forms.ColumnHeader();
            this.colCustomer = new Gizmox.WebGUI.Forms.ColumnHeader();
            this.colRemarks = new Gizmox.WebGUI.Forms.ColumnHeader();
            this.colCreatedOn = new Gizmox.WebGUI.Forms.ColumnHeader();
            this.colCreatedBy = new Gizmox.WebGUI.Forms.ColumnHeader();
            this.colModifiedOn = new Gizmox.WebGUI.Forms.ColumnHeader();
            this.colModifiedBy = new Gizmox.WebGUI.Forms.ColumnHeader();
            this.ansList = new Gizmox.WebGUI.Forms.ToolBar();
            this.toolTip1 = new Gizmox.WebGUI.Forms.ToolTip(this.components);
            this.colAttachment = new Gizmox.WebGUI.Forms.ColumnHeader();
            this.SuspendLayout();
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
            this.lksPane.Size = new System.Drawing.Size(846, 34);
            this.lksPane.TabIndex = 0;
            // 
            // cmdLookup
            // 
            iconResourceHandle1.File = "16x16.16_find.gif";
            this.cmdLookup.Image = iconResourceHandle1;
            this.cmdLookup.Location = new System.Drawing.Point(183, 6);
            this.cmdLookup.Name = "cmdLookup";
            this.cmdLookup.Size = new System.Drawing.Size(24, 23);
            this.cmdLookup.TabIndex = 4;
            this.cmdLookup.TabStop = false;
            this.cmdLookup.TextImageRelation = Gizmox.WebGUI.Forms.TextImageRelation.ImageAboveText;
            this.cmdLookup.Click += new System.EventHandler(this.cmdLookup_Click);
            // 
            // lblViews
            // 
            this.lblViews.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.lblViews.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblViews.Location = new System.Drawing.Point(662, 10);
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
            this.txtLookup.GotFocus += new System.EventHandler(this.txtLookup_GotFocus);
            this.txtLookup.EnterKeyDown += new Gizmox.WebGUI.Forms.KeyEventHandler(this.txtLookup_EnterKeyDown);
            // 
            // cboViews
            // 
            this.cboViews.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.cboViews.DropDownWidth = 140;
            this.cboViews.Location = new System.Drawing.Point(706, 7);
            this.cboViews.Name = "cboViews";
            this.cboViews.Size = new System.Drawing.Size(140, 21);
            this.cboViews.TabIndex = 1;
            this.cboViews.GotFocus += new System.EventHandler(this.cboViews_GotFocus);
            this.cboViews.SelectedIndexChanged += new System.EventHandler(this.cboViews_SelectedIndexChanged);
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
            // leftPane
            // 
            this.leftPane.Anchor = Gizmox.WebGUI.Forms.AnchorStyles.None;
            this.leftPane.Controls.Add(this.tvwCustomer);
            this.leftPane.Controls.Add(this.ansTree);
            this.leftPane.Dock = Gizmox.WebGUI.Forms.DockStyle.Left;
            this.leftPane.Location = new System.Drawing.Point(0, 34);
            this.leftPane.Name = "leftPane";
            this.leftPane.Size = new System.Drawing.Size(200, 449);
            this.leftPane.TabIndex = 1;
            // 
            // tvwCustomer
            // 
            this.tvwCustomer.Location = new System.Drawing.Point(26, 100);
            this.tvwCustomer.Name = "tvwCustomer";
            this.tvwCustomer.Size = new System.Drawing.Size(121, 97);
            this.tvwCustomer.TabIndex = 2;
            this.tvwCustomer.AfterSelect += new Gizmox.WebGUI.Forms.TreeViewEventHandler(this.tvwCustomer_AfterSelect);
            // 
            // ansTree
            // 
            this.ansTree.Anchor = Gizmox.WebGUI.Forms.AnchorStyles.None;
            this.ansTree.Appearance = Gizmox.WebGUI.Forms.ToolBarAppearance.Normal;
            this.ansTree.Dock = Gizmox.WebGUI.Forms.DockStyle.Top;
            this.ansTree.DragHandle = true;
            this.ansTree.DropDownArrows = false;
            this.ansTree.ImageList = null;
            this.ansTree.Location = new System.Drawing.Point(0, 0);
            this.ansTree.MenuHandle = true;
            this.ansTree.Name = "ansTree";
            this.ansTree.RightToLeft = Gizmox.WebGUI.Forms.RightToLeft.No;
            this.ansTree.ShowToolTips = true;
            this.ansTree.TabIndex = 1;
            // 
            // splitter1
            // 
            this.splitter1.Anchor = Gizmox.WebGUI.Forms.AnchorStyles.None;
            this.splitter1.Dock = Gizmox.WebGUI.Forms.DockStyle.Left;
            this.splitter1.Location = new System.Drawing.Point(200, 34);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(1, 449);
            this.splitter1.TabIndex = 2;
            // 
            // rightPane
            // 
            this.rightPane.Anchor = Gizmox.WebGUI.Forms.AnchorStyles.None;
            this.rightPane.Controls.Add(this.lvwList);
            this.rightPane.Controls.Add(this.ansList);
            this.rightPane.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.rightPane.Location = new System.Drawing.Point(201, 34);
            this.rightPane.Name = "rightPane";
            this.rightPane.Size = new System.Drawing.Size(645, 449);
            this.rightPane.TabIndex = 3;
            // 
            // lvwList
            // 
            this.lvwList.Columns.AddRange(new Gizmox.WebGUI.Forms.ColumnHeader[] {
            this.colItemNumber,
            this.colItemId,
            this.colStatus,
            this.colSample,
            this.colAttachment,
            this.colLN,
            this.colDate,
            this.colCustomer,
            this.colRemarks,
            this.colCreatedOn,
            this.colCreatedBy,
            this.colModifiedOn,
            this.colModifiedBy});
            this.lvwList.DataMember = null;
            this.lvwList.ItemsPerPage = 20;
            this.lvwList.Location = new System.Drawing.Point(55, 100);
            this.lvwList.Name = "lvwList";
            this.lvwList.Size = new System.Drawing.Size(510, 97);
            this.lvwList.TabIndex = 2;
            this.lvwList.SelectedIndexChanged += new System.EventHandler(this.lvwList_SelectedIndexChanged);
            this.lvwList.DoubleClick += new System.EventHandler(this.lvwList_DoubleClick);
            // 
            // colItemNumber
            // 
            this.colItemNumber.ContentAlign = Gizmox.WebGUI.Forms.ExtendedHorizontalAlignment.Center;
            this.colItemNumber.Image = null;
            this.colItemNumber.Text = "Quotation No.";
            this.colItemNumber.Width = 100;
            // 
            // colItemId
            // 
            this.colItemId.ContentAlign = Gizmox.WebGUI.Forms.ExtendedHorizontalAlignment.Center;
            this.colItemId.Image = null;
            this.colItemId.Text = "";
            this.colItemId.Visible = false;
            this.colItemId.Width = 150;
            // 
            // colStatus
            // 
            this.colStatus.ContentAlign = Gizmox.WebGUI.Forms.ExtendedHorizontalAlignment.Center;
            iconResourceHandle2.File = "16x16.flag_lightgrey.png";
            this.colStatus.Image = iconResourceHandle2;
            this.colStatus.Text = "";
            this.colStatus.Type = Gizmox.WebGUI.Forms.ListViewColumnType.Icon;
            this.colStatus.Width = 24;
            // 
            // colSample
            // 
            this.colSample.ContentAlign = Gizmox.WebGUI.Forms.ExtendedHorizontalAlignment.Center;
            iconResourceHandle3.File = "16x16.flower_16_grey.png";
            this.colSample.Image = iconResourceHandle3;
            this.colSample.Text = "";
            this.colSample.Type = Gizmox.WebGUI.Forms.ListViewColumnType.Icon;
            this.colSample.Width = 24;
            // 
            // colLN
            // 
            this.colLN.ContentAlign = Gizmox.WebGUI.Forms.ExtendedHorizontalAlignment.Center;
            this.colLN.Image = null;
            this.colLN.Text = "#";
            this.colLN.Width = 30;
            // 
            // colDate
            // 
            this.colDate.ContentAlign = Gizmox.WebGUI.Forms.ExtendedHorizontalAlignment.Center;
            this.colDate.Image = null;
            this.colDate.Text = "Date";
            this.colDate.Width = 70;
            // 
            // colCustomer
            // 
            this.colCustomer.ContentAlign = Gizmox.WebGUI.Forms.ExtendedHorizontalAlignment.Center;
            this.colCustomer.Image = null;
            this.colCustomer.Text = "Customer";
            this.colCustomer.Width = 100;
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
            this.colCreatedBy.Width = 80;
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
            this.colModifiedBy.Width = 80;
            // 
            // ansList
            // 
            this.ansList.Anchor = Gizmox.WebGUI.Forms.AnchorStyles.None;
            this.ansList.Appearance = Gizmox.WebGUI.Forms.ToolBarAppearance.Normal;
            this.ansList.Dock = Gizmox.WebGUI.Forms.DockStyle.Top;
            this.ansList.DragHandle = true;
            this.ansList.DropDownArrows = false;
            this.ansList.ImageList = null;
            this.ansList.Location = new System.Drawing.Point(0, 0);
            this.ansList.MenuHandle = true;
            this.ansList.Name = "ansList";
            this.ansList.RightToLeft = Gizmox.WebGUI.Forms.RightToLeft.No;
            this.ansList.ShowToolTips = true;
            this.ansList.TabIndex = 1;
            // 
            // colAttachment
            // 
            iconResourceHandle4.File = "16x16.ico_16_1001_d.gif";
            this.colAttachment.Image = iconResourceHandle4;
            this.colAttachment.Text = "";
            this.colAttachment.TextAlign = Gizmox.WebGUI.Forms.HorizontalAlignment.Center;
            this.colAttachment.Type = Gizmox.WebGUI.Forms.ListViewColumnType.Icon;
            this.colAttachment.Width = 24;
            // 
            // QuotationList
            // 
            this.Controls.Add(this.rightPane);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.leftPane);
            this.Controls.Add(this.lksPane);
            this.Size = new System.Drawing.Size(846, 483);
            this.Text = "QuotationList";
            this.Load += new System.EventHandler(this.QuotationList_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Gizmox.WebGUI.Forms.Panel lksPane;
        private Gizmox.WebGUI.Forms.Button cmdLookup;
        private Gizmox.WebGUI.Forms.Label lblViews;
        private Gizmox.WebGUI.Forms.TextBox txtLookup;
        private Gizmox.WebGUI.Forms.ComboBox cboViews;
        private Gizmox.WebGUI.Forms.Label lblLookup;
        private Gizmox.WebGUI.Forms.Panel leftPane;
        private Gizmox.WebGUI.Forms.Splitter splitter1;
        private Gizmox.WebGUI.Forms.Panel rightPane;
        private Gizmox.WebGUI.Forms.ToolBar ansTree;
        private Gizmox.WebGUI.Forms.ToolBar ansList;
        private Gizmox.WebGUI.Forms.TreeView tvwCustomer;
        private Gizmox.WebGUI.Forms.ListView lvwList;
        private Gizmox.WebGUI.Forms.ColumnHeader colItemNumber;
        private Gizmox.WebGUI.Forms.ColumnHeader colItemId;
        private Gizmox.WebGUI.Forms.ColumnHeader colCustomer;
        private Gizmox.WebGUI.Forms.ColumnHeader colRemarks;
        private Gizmox.WebGUI.Forms.ColumnHeader colCreatedOn;
        private Gizmox.WebGUI.Forms.ColumnHeader colCreatedBy;
        private Gizmox.WebGUI.Forms.ColumnHeader colModifiedOn;
        private Gizmox.WebGUI.Forms.ColumnHeader colModifiedBy;
        private Gizmox.WebGUI.Forms.ColumnHeader colStatus;
        private Gizmox.WebGUI.Forms.ColumnHeader colLN;
        private Gizmox.WebGUI.Forms.ColumnHeader colSample;
        private Gizmox.WebGUI.Forms.ToolTip toolTip1;
        private Gizmox.WebGUI.Forms.ColumnHeader colDate;
        private Gizmox.WebGUI.Forms.ColumnHeader colAttachment;


    }
}