namespace xPort5.Order.PreOrder
{
    partial class PreOrderList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PreOrderList));
            this.topPanel = new Gizmox.WebGUI.Forms.Panel();
            this.lblLookup = new Gizmox.WebGUI.Forms.Label();
            this.btnFind = new Gizmox.WebGUI.Forms.Button();
            this.cboViews = new Gizmox.WebGUI.Forms.ComboBox();
            this.txtPreOrderNo = new Gizmox.WebGUI.Forms.TextBox();
            this.lblView = new Gizmox.WebGUI.Forms.Label();
            this.tvList = new Gizmox.WebGUI.Forms.TreeView();
            this.ansTree = new Gizmox.WebGUI.Forms.ToolBar();
            this.lvwList = new Gizmox.WebGUI.Forms.ListView();
            this.colItemNumber = ((Gizmox.WebGUI.Forms.ColumnHeader)(new Gizmox.WebGUI.Forms.ColumnHeader()));
            this.colItemId = ((Gizmox.WebGUI.Forms.ColumnHeader)(new Gizmox.WebGUI.Forms.ColumnHeader()));
            this.colStatus = ((Gizmox.WebGUI.Forms.ColumnHeader)(new Gizmox.WebGUI.Forms.ColumnHeader()));
            this.colSample = ((Gizmox.WebGUI.Forms.ColumnHeader)(new Gizmox.WebGUI.Forms.ColumnHeader()));
            this.colAttachment = ((Gizmox.WebGUI.Forms.ColumnHeader)(new Gizmox.WebGUI.Forms.ColumnHeader()));
            this.colLN = ((Gizmox.WebGUI.Forms.ColumnHeader)(new Gizmox.WebGUI.Forms.ColumnHeader()));
            this.colCustomer = ((Gizmox.WebGUI.Forms.ColumnHeader)(new Gizmox.WebGUI.Forms.ColumnHeader()));
            this.colRemarks = ((Gizmox.WebGUI.Forms.ColumnHeader)(new Gizmox.WebGUI.Forms.ColumnHeader()));
            this.colCreatedOn = ((Gizmox.WebGUI.Forms.ColumnHeader)(new Gizmox.WebGUI.Forms.ColumnHeader()));
            this.colCreatedBy = ((Gizmox.WebGUI.Forms.ColumnHeader)(new Gizmox.WebGUI.Forms.ColumnHeader()));
            this.colModifiedOn = ((Gizmox.WebGUI.Forms.ColumnHeader)(new Gizmox.WebGUI.Forms.ColumnHeader()));
            this.colModifiedBy = ((Gizmox.WebGUI.Forms.ColumnHeader)(new Gizmox.WebGUI.Forms.ColumnHeader()));
            this.ansList = new Gizmox.WebGUI.Forms.ToolBar();
            this.toolTip1 = new Gizmox.WebGUI.Forms.ToolTip();
            this.lowerPanel = new Gizmox.WebGUI.Forms.Panel();
            this.splitContainer1 = new Gizmox.WebGUI.Forms.SplitContainer();
            this.topPanel.SuspendLayout();
            this.lowerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.Controls.Add(this.lblLookup);
            this.topPanel.Controls.Add(this.btnFind);
            this.topPanel.Controls.Add(this.cboViews);
            this.topPanel.Controls.Add(this.txtPreOrderNo);
            this.topPanel.Controls.Add(this.lblView);
            this.topPanel.Dock = Gizmox.WebGUI.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(846, 36);
            this.topPanel.TabIndex = 0;
            // 
            // lblLookup
            // 
            this.lblLookup.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblLookup.Location = new System.Drawing.Point(0, 9);
            this.lblLookup.Name = "lblLookup";
            this.lblLookup.Size = new System.Drawing.Size(61, 18);
            this.lblLookup.TabIndex = 0;
            this.lblLookup.Text = "Look for:";
            // 
            // btnFind
            // 
            this.btnFind.Image = new Gizmox.WebGUI.Common.Resources.IconResourceHandle(resources.GetString("btnFind.Image"));
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
            this.cboViews.SelectedIndexChanged += new System.EventHandler(this.cboViews_SelectedIndexChanged);
            this.cboViews.GotFocus += new System.EventHandler(this.cboViews_GotFocus);
            // 
            // txtPreOrderNo
            // 
            this.txtPreOrderNo.Location = new System.Drawing.Point(63, 7);
            this.txtPreOrderNo.Name = "txtPreOrderNo";
            this.txtPreOrderNo.Size = new System.Drawing.Size(120, 20);
            this.txtPreOrderNo.TabIndex = 0;
            this.txtPreOrderNo.EnterKeyDown += new Gizmox.WebGUI.Forms.KeyEventHandler(this.txtPreOrderNo_EnterKeyDown);
            this.txtPreOrderNo.GotFocus += new System.EventHandler(this.txtPreOrderNo_GotFocus);
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
            // tvList
            // 
            this.tvList.Location = new System.Drawing.Point(31, 224);
            this.tvList.Name = "tvList";
            this.tvList.Size = new System.Drawing.Size(133, 123);
            this.tvList.TabIndex = 2;
            this.tvList.AfterSelect += new Gizmox.WebGUI.Forms.TreeViewEventHandler(this.tvList_AfterSelect);
            // 
            // ansTree
            // 
            this.ansTree.ButtonSize = new System.Drawing.Size(24, 22);
            this.ansTree.Dock = Gizmox.WebGUI.Forms.DockStyle.None;
            this.ansTree.DragHandle = true;
            this.ansTree.DropDownArrows = true;
            this.ansTree.ImageSize = new System.Drawing.Size(16, 16);
            this.ansTree.Location = new System.Drawing.Point(50, 112);
            this.ansTree.MenuHandle = true;
            this.ansTree.Name = "ansTree";
            this.ansTree.RightToLeft = Gizmox.WebGUI.Forms.RightToLeft.No;
            this.ansTree.ShowToolTips = true;
            this.ansTree.Size = new System.Drawing.Size(100, 24);
            this.ansTree.TabIndex = 0;
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
            this.colCustomer,
            this.colRemarks,
            this.colCreatedOn,
            this.colCreatedBy,
            this.colModifiedOn,
            this.colModifiedBy});
            this.lvwList.DataMember = null;
            this.lvwList.Location = new System.Drawing.Point(82, 199);
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
            this.colItemNumber.Text = "Pre-Order No.";
            this.colItemNumber.Width = 130;
            // 
            // colItemId
            // 
            this.colItemId.ContentAlign = Gizmox.WebGUI.Forms.ExtendedHorizontalAlignment.Center;
            this.colItemId.Text = "";
            this.colItemId.Visible = false;
            this.colItemId.Width = 100;
            // 
            // colStatus
            // 
            this.colStatus.ContentAlign = Gizmox.WebGUI.Forms.ExtendedHorizontalAlignment.Center;
            this.colStatus.Image = new Gizmox.WebGUI.Common.Resources.IconResourceHandle(resources.GetString("colStatus.Image"));
            this.colStatus.Text = "";
            this.colStatus.Type = Gizmox.WebGUI.Forms.ListViewColumnType.Icon;
            this.colStatus.Width = 24;
            // 
            // colSample
            // 
            this.colSample.ContentAlign = Gizmox.WebGUI.Forms.ExtendedHorizontalAlignment.Center;
            this.colSample.Image = new Gizmox.WebGUI.Common.Resources.IconResourceHandle(resources.GetString("colSample.Image"));
            this.colSample.Text = "";
            this.colSample.Type = Gizmox.WebGUI.Forms.ListViewColumnType.Icon;
            this.colSample.Width = 24;
            // 
            // colAttachment
            // 
            this.colAttachment.Image = new Gizmox.WebGUI.Common.Resources.IconResourceHandle(resources.GetString("colAttachment.Image"));
            this.colAttachment.Text = "";
            this.colAttachment.TextAlign = Gizmox.WebGUI.Forms.HorizontalAlignment.Center;
            this.colAttachment.Type = Gizmox.WebGUI.Forms.ListViewColumnType.Icon;
            this.colAttachment.Width = 24;
            // 
            // colLN
            // 
            this.colLN.ContentAlign = Gizmox.WebGUI.Forms.ExtendedHorizontalAlignment.Center;
            this.colLN.Tag = "Numeric";
            this.colLN.Text = "#";
            this.colLN.Width = 40;
            // 
            // colCustomer
            // 
            this.colCustomer.ContentAlign = Gizmox.WebGUI.Forms.ExtendedHorizontalAlignment.Center;
            this.colCustomer.Text = "Customer";
            this.colCustomer.Width = 100;
            // 
            // colRemarks
            // 
            this.colRemarks.ContentAlign = Gizmox.WebGUI.Forms.ExtendedHorizontalAlignment.Center;
            this.colRemarks.Text = "Remarks";
            this.colRemarks.Width = 150;
            // 
            // colCreatedOn
            // 
            this.colCreatedOn.ContentAlign = Gizmox.WebGUI.Forms.ExtendedHorizontalAlignment.Center;
            this.colCreatedOn.Text = "Created On";
            this.colCreatedOn.Width = 100;
            // 
            // colCreatedBy
            // 
            this.colCreatedBy.ContentAlign = Gizmox.WebGUI.Forms.ExtendedHorizontalAlignment.Center;
            this.colCreatedBy.Text = "Created By";
            this.colCreatedBy.Width = 80;
            // 
            // colModifiedOn
            // 
            this.colModifiedOn.ContentAlign = Gizmox.WebGUI.Forms.ExtendedHorizontalAlignment.Center;
            this.colModifiedOn.Text = "Modified On";
            this.colModifiedOn.Width = 100;
            // 
            // colModifiedBy
            // 
            this.colModifiedBy.ContentAlign = Gizmox.WebGUI.Forms.ExtendedHorizontalAlignment.Center;
            this.colModifiedBy.Text = "Modified By";
            this.colModifiedBy.Width = 80;
            // 
            // ansList
            // 
            this.ansList.ButtonSize = new System.Drawing.Size(24, 22);
            this.ansList.Dock = Gizmox.WebGUI.Forms.DockStyle.None;
            this.ansList.DragHandle = true;
            this.ansList.DropDownArrows = true;
            this.ansList.ImageSize = new System.Drawing.Size(16, 16);
            this.ansList.Location = new System.Drawing.Point(164, 78);
            this.ansList.MenuHandle = true;
            this.ansList.Name = "ansList";
            this.ansList.RightToLeft = Gizmox.WebGUI.Forms.RightToLeft.No;
            this.ansList.ShowToolTips = true;
            this.ansList.Size = new System.Drawing.Size(300, 24);
            this.ansList.TabIndex = 0;
            this.ansList.ButtonClick += new Gizmox.WebGUI.Forms.ToolBarButtonClickEventHandler(this.ansList_ButtonClick);
            // 
            // lowerPanel
            // 
            this.lowerPanel.Controls.Add(this.splitContainer1);
            this.lowerPanel.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.lowerPanel.Location = new System.Drawing.Point(0, 36);
            this.lowerPanel.Name = "lowerPanel";
            this.lowerPanel.Size = new System.Drawing.Size(846, 447);
            this.lowerPanel.TabIndex = 1;
            // 
            // splitContainer1
            // 
            this.splitContainer1.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.splitContainer1.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tvList);
            this.splitContainer1.Panel1.Controls.Add(this.ansTree);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lvwList);
            this.splitContainer1.Panel2.Controls.Add(this.ansList);
            this.splitContainer1.Size = new System.Drawing.Size(846, 447);
            this.splitContainer1.SplitterDistance = 200;
            this.splitContainer1.SplitterWidth = 2;
            this.splitContainer1.TabIndex = 3;
            // 
            // PreOrderList
            // 
            this.Controls.Add(this.lowerPanel);
            this.Controls.Add(this.topPanel);
            this.Size = new System.Drawing.Size(846, 483);
            this.Text = "PreOrderList";
            this.topPanel.ResumeLayout(false);
            this.lowerPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Gizmox.WebGUI.Forms.Panel topPanel;
        private Gizmox.WebGUI.Forms.Label lblLookup;
        private Gizmox.WebGUI.Forms.Button btnFind;
        private Gizmox.WebGUI.Forms.ComboBox cboViews;
        private Gizmox.WebGUI.Forms.TextBox txtPreOrderNo;
        private Gizmox.WebGUI.Forms.Label lblView;
        private Gizmox.WebGUI.Forms.TreeView tvList;
        private Gizmox.WebGUI.Forms.ToolBar ansTree;
        private Gizmox.WebGUI.Forms.ListView lvwList;
        private Gizmox.WebGUI.Forms.ColumnHeader colItemNumber;
        private Gizmox.WebGUI.Forms.ColumnHeader colStatus;
        private Gizmox.WebGUI.Forms.ColumnHeader colSample;
        private Gizmox.WebGUI.Forms.ColumnHeader colItemId;
        private Gizmox.WebGUI.Forms.ColumnHeader colLN;
        private Gizmox.WebGUI.Forms.ColumnHeader colCustomer;
        private Gizmox.WebGUI.Forms.ColumnHeader colRemarks;
        private Gizmox.WebGUI.Forms.ColumnHeader colCreatedOn;
        private Gizmox.WebGUI.Forms.ColumnHeader colCreatedBy;
        private Gizmox.WebGUI.Forms.ColumnHeader colModifiedOn;
        private Gizmox.WebGUI.Forms.ColumnHeader colModifiedBy;
        private Gizmox.WebGUI.Forms.ToolBar ansList;
        private Gizmox.WebGUI.Forms.ToolTip toolTip1;
        private Gizmox.WebGUI.Forms.ColumnHeader colAttachment;
        private Gizmox.WebGUI.Forms.Panel lowerPanel;
        private Gizmox.WebGUI.Forms.SplitContainer splitContainer1;
    }
}