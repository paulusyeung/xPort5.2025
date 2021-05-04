namespace xPort5.Order.PurchaseContract
{
    partial class PurchaseContractList
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
            this.topPanel = new Gizmox.WebGUI.Forms.Panel();
            this.lblLookup = new Gizmox.WebGUI.Forms.Label();
            this.btnFind = new Gizmox.WebGUI.Forms.Button();
            this.cboViews = new Gizmox.WebGUI.Forms.ComboBox();
            this.txtContractNo = new Gizmox.WebGUI.Forms.TextBox();
            this.lblView = new Gizmox.WebGUI.Forms.Label();
            this.leftPanel = new Gizmox.WebGUI.Forms.Panel();
            this.tvList = new Gizmox.WebGUI.Forms.TreeView();
            this.ansTree = new Gizmox.WebGUI.Forms.ToolBar();
            this.splitter1 = new Gizmox.WebGUI.Forms.Splitter();
            this.rightPanel = new Gizmox.WebGUI.Forms.Panel();
            this.lvwList = new Gizmox.WebGUI.Forms.ListView();
            this.colItemNumber = new Gizmox.WebGUI.Forms.ColumnHeader();
            this.colStatus = new Gizmox.WebGUI.Forms.ColumnHeader();
            this.colSample = new Gizmox.WebGUI.Forms.ColumnHeader();
            this.colItemId = new Gizmox.WebGUI.Forms.ColumnHeader();
            this.colLN = new Gizmox.WebGUI.Forms.ColumnHeader();
            this.colSupplier = new Gizmox.WebGUI.Forms.ColumnHeader();
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
            // topPanel
            // 
            this.topPanel.Anchor = Gizmox.WebGUI.Forms.AnchorStyles.None;
            this.topPanel.Controls.Add(this.lblLookup);
            this.topPanel.Controls.Add(this.btnFind);
            this.topPanel.Controls.Add(this.cboViews);
            this.topPanel.Controls.Add(this.txtContractNo);
            this.topPanel.Controls.Add(this.lblView);
            this.topPanel.Dock = Gizmox.WebGUI.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(846, 34);
            this.topPanel.TabIndex = 2;
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
            // btnFind
            // 
            iconResourceHandle1.File = "16x16.16_find.gif";
            this.btnFind.Image = iconResourceHandle1;
            this.btnFind.Location = new System.Drawing.Point(183, 6);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(24, 23);
            this.btnFind.TabIndex = 1;
            this.btnFind.TextImageRelation = Gizmox.WebGUI.Forms.TextImageRelation.ImageAboveText;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // cboViews
            // 
            this.cboViews.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.cboViews.Location = new System.Drawing.Point(706, 7);
            this.cboViews.Name = "cboViews";
            this.cboViews.Size = new System.Drawing.Size(140, 21);
            this.cboViews.TabIndex = 1;
            this.cboViews.GotFocus += new System.EventHandler(this.cboViews_GotFocus);
            this.cboViews.SelectedIndexChanged += new System.EventHandler(this.cboViews_SelectedIndexChanged);
            // 
            // txtContractNo
            // 
            this.txtContractNo.Location = new System.Drawing.Point(63, 7);
            this.txtContractNo.Name = "txtContractNo";
            this.txtContractNo.Size = new System.Drawing.Size(120, 20);
            this.txtContractNo.TabIndex = 0;
            this.txtContractNo.GotFocus += new System.EventHandler(this.txtContractNo_GotFocus);
            this.txtContractNo.EnterKeyDown += new Gizmox.WebGUI.Forms.KeyEventHandler(this.txtContractNo_EnterKeyDown);
            // 
            // lblView
            // 
            this.lblView.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.lblView.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblView.Location = new System.Drawing.Point(662, 10);
            this.lblView.Name = "lblView";
            this.lblView.Size = new System.Drawing.Size(44, 17);
            this.lblView.TabIndex = 0;
            this.lblView.Text = "View:";
            // 
            // leftPanel
            // 
            this.leftPanel.Anchor = Gizmox.WebGUI.Forms.AnchorStyles.None;
            this.leftPanel.Controls.Add(this.tvList);
            this.leftPanel.Controls.Add(this.ansTree);
            this.leftPanel.Dock = Gizmox.WebGUI.Forms.DockStyle.Left;
            this.leftPanel.Location = new System.Drawing.Point(0, 30);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(200, 453);
            this.leftPanel.TabIndex = 3;
            // 
            // tvList
            // 
            this.tvList.Anchor = Gizmox.WebGUI.Forms.AnchorStyles.None;
            this.tvList.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.tvList.Location = new System.Drawing.Point(0, 28);
            this.tvList.Name = "tvList";
            this.tvList.Size = new System.Drawing.Size(200, 425);
            this.tvList.TabIndex = 2;
            this.tvList.AfterSelect += new Gizmox.WebGUI.Forms.TreeViewEventHandler(this.tvList_AfterSelect);
            // 
            // ansTree
            // 
            this.ansTree.Anchor = Gizmox.WebGUI.Forms.AnchorStyles.None;
            this.ansTree.Appearance = Gizmox.WebGUI.Forms.ToolBarAppearance.Normal;
            this.ansTree.Dock = Gizmox.WebGUI.Forms.DockStyle.Top;
            this.ansTree.DragHandle = false;
            this.ansTree.DropDownArrows = false;
            this.ansTree.ImageList = null;
            this.ansTree.Location = new System.Drawing.Point(0, 0);
            this.ansTree.MenuHandle = false;
            this.ansTree.Name = "ansTree";
            this.ansTree.RightToLeft = Gizmox.WebGUI.Forms.RightToLeft.No;
            this.ansTree.ShowToolTips = true;
            this.ansTree.TabIndex = 0;
            // 
            // splitter1
            // 
            this.splitter1.Anchor = Gizmox.WebGUI.Forms.AnchorStyles.None;
            this.splitter1.Dock = Gizmox.WebGUI.Forms.DockStyle.Left;
            this.splitter1.Location = new System.Drawing.Point(200, 30);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(1, 453);
            this.splitter1.TabIndex = 4;
            // 
            // rightPanel
            // 
            this.rightPanel.Anchor = Gizmox.WebGUI.Forms.AnchorStyles.None;
            this.rightPanel.Controls.Add(this.lvwList);
            this.rightPanel.Controls.Add(this.ansList);
            this.rightPanel.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.rightPanel.Location = new System.Drawing.Point(201, 30);
            this.rightPanel.Name = "rightPanel";
            this.rightPanel.Size = new System.Drawing.Size(645, 453);
            this.rightPanel.TabIndex = 5;
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
            this.colSupplier,
            this.colRemarks,
            this.colCreatedOn,
            this.colCreatedBy,
            this.colModifiedOn,
            this.colModifiedBy});
            this.lvwList.DataMember = null;
            this.lvwList.ItemsPerPage = 20;
            this.lvwList.Location = new System.Drawing.Point(55, 112);
            this.lvwList.Name = "lvwList";
            this.lvwList.Size = new System.Drawing.Size(510, 97);
            this.lvwList.TabIndex = 2;
            this.lvwList.SelectedIndexChanged += new System.EventHandler(this.lvwList_SelectedIndexChanged);
            this.lvwList.DoubleClick += new System.EventHandler(this.lvwList_DoubleClick);
            this.lvwList.ColumnClick += new Gizmox.WebGUI.Forms.ColumnClickEventHandler(this.lvwList_ColumnClick);
            // 
            // colItemNumber
            // 
            this.colItemNumber.ContentAlign = Gizmox.WebGUI.Forms.ExtendedHorizontalAlignment.Center;
            this.colItemNumber.Image = null;
            this.colItemNumber.Text = "Purchase Contract No.";
            this.colItemNumber.Width = 130;
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
            // colItemId
            // 
            this.colItemId.ContentAlign = Gizmox.WebGUI.Forms.ExtendedHorizontalAlignment.Center;
            this.colItemId.Image = null;
            this.colItemId.Text = "";
            this.colItemId.Visible = false;
            this.colItemId.Width = 100;
            // 
            // colLN
            // 
            this.colLN.ContentAlign = Gizmox.WebGUI.Forms.ExtendedHorizontalAlignment.Center;
            this.colLN.Image = null;
            this.colLN.Tag = "Numeric";
            this.colLN.Text = "#";
            this.colLN.Width = 40;
            // 
            // colSupplier
            // 
            this.colSupplier.ContentAlign = Gizmox.WebGUI.Forms.ExtendedHorizontalAlignment.Center;
            this.colSupplier.Image = null;
            this.colSupplier.Text = "Supplier";
            this.colSupplier.Width = 100;
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
            this.ansList.DragHandle = false;
            this.ansList.DropDownArrows = false;
            this.ansList.ImageList = null;
            this.ansList.Location = new System.Drawing.Point(0, 0);
            this.ansList.MenuHandle = false;
            this.ansList.Name = "ansList";
            this.ansList.RightToLeft = Gizmox.WebGUI.Forms.RightToLeft.No;
            this.ansList.ShowToolTips = true;
            this.ansList.TabIndex = 0;
            this.ansList.ButtonClick += new Gizmox.WebGUI.Forms.ToolBarButtonClickEventHandler(this.ansList_ButtonClick);
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
            // PurchaseContractList
            // 
            this.Controls.Add(this.rightPanel);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.leftPanel);
            this.Controls.Add(this.topPanel);
            this.Location = new System.Drawing.Point(5, 15);
            this.Size = new System.Drawing.Size(846, 483);
            this.Text = "PurchaseContractList";
            this.Load += new System.EventHandler(this.PurchaseContractList_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Gizmox.WebGUI.Forms.Panel topPanel;
        private Gizmox.WebGUI.Forms.ComboBox cboViews;
        private Gizmox.WebGUI.Forms.Label lblView;
        private Gizmox.WebGUI.Forms.Panel leftPanel;
        private Gizmox.WebGUI.Forms.ToolBar ansTree;
        private Gizmox.WebGUI.Forms.Splitter splitter1;
        private Gizmox.WebGUI.Forms.Panel rightPanel;
        private Gizmox.WebGUI.Forms.ToolBar ansList;
        private Gizmox.WebGUI.Forms.Button btnFind;
        private Gizmox.WebGUI.Forms.TextBox txtContractNo;
        private Gizmox.WebGUI.Forms.TreeView tvList;
        private Gizmox.WebGUI.Forms.ListView lvwList;
        private Gizmox.WebGUI.Forms.ColumnHeader colItemNumber;
        private Gizmox.WebGUI.Forms.ColumnHeader colItemId;
        private Gizmox.WebGUI.Forms.ColumnHeader colStatus;
        private Gizmox.WebGUI.Forms.ColumnHeader colSample;
        private Gizmox.WebGUI.Forms.ColumnHeader colLN;
        private Gizmox.WebGUI.Forms.ColumnHeader colSupplier;
        private Gizmox.WebGUI.Forms.ColumnHeader colRemarks;
        private Gizmox.WebGUI.Forms.ColumnHeader colCreatedOn;
        private Gizmox.WebGUI.Forms.ColumnHeader colCreatedBy;
        private Gizmox.WebGUI.Forms.ColumnHeader colModifiedOn;
        private Gizmox.WebGUI.Forms.ColumnHeader colModifiedBy;
        private Gizmox.WebGUI.Forms.ToolTip toolTip1;
        private Gizmox.WebGUI.Forms.Label lblLookup;
        private Gizmox.WebGUI.Forms.ColumnHeader colAttachment;

    }
}