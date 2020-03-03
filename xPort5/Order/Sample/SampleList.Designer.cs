namespace xPort5.Order.Sample
{
    partial class SampleList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SampleList));
            this.lksPane = new Gizmox.WebGUI.Forms.Panel();
            this.cmdLookup = new Gizmox.WebGUI.Forms.Button();
            this.lblViews = new Gizmox.WebGUI.Forms.Label();
            this.txtLookup = new Gizmox.WebGUI.Forms.TextBox();
            this.cboViews = new Gizmox.WebGUI.Forms.ComboBox();
            this.lblLookup = new Gizmox.WebGUI.Forms.Label();
            this.tvwCustomer = new Gizmox.WebGUI.Forms.TreeView();
            this.ansTree = new Gizmox.WebGUI.Forms.ToolBar();
            this.lvwList = new Gizmox.WebGUI.Forms.ListView();
            this.colItemNumber = ((Gizmox.WebGUI.Forms.ColumnHeader)(new Gizmox.WebGUI.Forms.ColumnHeader()));
            this.colItemId = ((Gizmox.WebGUI.Forms.ColumnHeader)(new Gizmox.WebGUI.Forms.ColumnHeader()));
            this.colStatus = ((Gizmox.WebGUI.Forms.ColumnHeader)(new Gizmox.WebGUI.Forms.ColumnHeader()));
            this.colSample = ((Gizmox.WebGUI.Forms.ColumnHeader)(new Gizmox.WebGUI.Forms.ColumnHeader()));
            this.colAttachment = ((Gizmox.WebGUI.Forms.ColumnHeader)(new Gizmox.WebGUI.Forms.ColumnHeader()));
            this.colLN = ((Gizmox.WebGUI.Forms.ColumnHeader)(new Gizmox.WebGUI.Forms.ColumnHeader()));
            this.colDate = ((Gizmox.WebGUI.Forms.ColumnHeader)(new Gizmox.WebGUI.Forms.ColumnHeader()));
            this.colCustomer = ((Gizmox.WebGUI.Forms.ColumnHeader)(new Gizmox.WebGUI.Forms.ColumnHeader()));
            this.colRemarks = ((Gizmox.WebGUI.Forms.ColumnHeader)(new Gizmox.WebGUI.Forms.ColumnHeader()));
            this.colCreatedOn = ((Gizmox.WebGUI.Forms.ColumnHeader)(new Gizmox.WebGUI.Forms.ColumnHeader()));
            this.colCreatedBy = ((Gizmox.WebGUI.Forms.ColumnHeader)(new Gizmox.WebGUI.Forms.ColumnHeader()));
            this.colModifiedOn = ((Gizmox.WebGUI.Forms.ColumnHeader)(new Gizmox.WebGUI.Forms.ColumnHeader()));
            this.colModifiedBy = ((Gizmox.WebGUI.Forms.ColumnHeader)(new Gizmox.WebGUI.Forms.ColumnHeader()));
            this.ansList = new Gizmox.WebGUI.Forms.ToolBar();
            this.toolTip1 = new Gizmox.WebGUI.Forms.ToolTip();
            this.splitContainer1 = new Gizmox.WebGUI.Forms.SplitContainer();
            this.lksPane.SuspendLayout();
            this.SuspendLayout();
            // 
            // lksPane
            // 
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
            this.cmdLookup.Image = new Gizmox.WebGUI.Common.Resources.IconResourceHandle(resources.GetString("cmdLookup.Image"));
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
            this.txtLookup.EnterKeyDown += new Gizmox.WebGUI.Forms.KeyEventHandler(this.txtLookup_EnterKeyDown);
            this.txtLookup.GotFocus += new System.EventHandler(this.txtLookup_GotFocus);
            // 
            // cboViews
            // 
            this.cboViews.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.cboViews.DropDownWidth = 140;
            this.cboViews.Location = new System.Drawing.Point(706, 7);
            this.cboViews.Name = "cboViews";
            this.cboViews.Size = new System.Drawing.Size(140, 21);
            this.cboViews.TabIndex = 1;
            this.cboViews.SelectedIndexChanged += new System.EventHandler(this.cboViews_SelectedIndexChanged);
            this.cboViews.GotFocus += new System.EventHandler(this.cboViews_GotFocus);
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
            // tvwCustomer
            // 
            this.tvwCustomer.Location = new System.Drawing.Point(44, 66);
            this.tvwCustomer.Name = "tvwCustomer";
            this.tvwCustomer.Size = new System.Drawing.Size(121, 97);
            this.tvwCustomer.TabIndex = 2;
            this.tvwCustomer.AfterSelect += new Gizmox.WebGUI.Forms.TreeViewEventHandler(this.tvwCustomer_AfterSelect);
            // 
            // ansTree
            // 
            this.ansTree.Dock = Gizmox.WebGUI.Forms.DockStyle.None;
            this.ansTree.DragHandle = true;
            this.ansTree.DropDownArrows = true;
            this.ansTree.ImageSize = new System.Drawing.Size(16, 16);
            this.ansTree.Location = new System.Drawing.Point(44, 24);
            this.ansTree.MenuHandle = true;
            this.ansTree.Name = "ansTree";
            this.ansTree.RightToLeft = Gizmox.WebGUI.Forms.RightToLeft.No;
            this.ansTree.ShowToolTips = true;
            this.ansTree.Size = new System.Drawing.Size(100, 42);
            this.ansTree.TabIndex = 1;
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
            this.lvwList.Location = new System.Drawing.Point(33, 66);
            this.lvwList.Name = "lvwList";
            this.lvwList.Size = new System.Drawing.Size(343, 97);
            this.lvwList.TabIndex = 2;
            this.lvwList.SelectedIndexChanged += new System.EventHandler(this.lvwList_SelectedIndexChanged);
            this.lvwList.DoubleClick += new System.EventHandler(this.lvwList_DoubleClick);
            // 
            // colItemNumber
            // 
            this.colItemNumber.ContentAlign = Gizmox.WebGUI.Forms.ExtendedHorizontalAlignment.Center;
            this.colItemNumber.Text = "Sample No.";
            this.colItemNumber.Width = 100;
            // 
            // colItemId
            // 
            this.colItemId.ContentAlign = Gizmox.WebGUI.Forms.ExtendedHorizontalAlignment.Center;
            this.colItemId.Text = "";
            this.colItemId.Visible = false;
            this.colItemId.Width = 150;
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
            this.colLN.Text = "#";
            this.colLN.Width = 30;
            // 
            // colDate
            // 
            this.colDate.ContentAlign = Gizmox.WebGUI.Forms.ExtendedHorizontalAlignment.Center;
            this.colDate.Text = "Date";
            this.colDate.Width = 70;
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
            this.ansList.Dock = Gizmox.WebGUI.Forms.DockStyle.None;
            this.ansList.DragHandle = true;
            this.ansList.DropDownArrows = true;
            this.ansList.ImageSize = new System.Drawing.Size(16, 16);
            this.ansList.Location = new System.Drawing.Point(33, 24);
            this.ansList.MenuHandle = true;
            this.ansList.Name = "ansList";
            this.ansList.RightToLeft = Gizmox.WebGUI.Forms.RightToLeft.No;
            this.ansList.ShowToolTips = true;
            this.ansList.Size = new System.Drawing.Size(100, 42);
            this.ansList.TabIndex = 1;
            // 
            // splitContainer1
            // 
            this.splitContainer1.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.splitContainer1.Location = new System.Drawing.Point(63, 77);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tvwCustomer);
            this.splitContainer1.Panel1.Controls.Add(this.ansTree);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lvwList);
            this.splitContainer1.Panel2.Controls.Add(this.ansList);
            this.splitContainer1.Size = new System.Drawing.Size(690, 188);
            this.splitContainer1.SplitterDistance = 230;
            this.splitContainer1.TabIndex = 4;
            // 
            // SampleList
            // 
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.lksPane);
            this.Size = new System.Drawing.Size(846, 483);
            this.Text = "SampleList";
            this.lksPane.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Gizmox.WebGUI.Forms.Panel lksPane;
        private Gizmox.WebGUI.Forms.Button cmdLookup;
        private Gizmox.WebGUI.Forms.Label lblViews;
        private Gizmox.WebGUI.Forms.TextBox txtLookup;
        private Gizmox.WebGUI.Forms.ComboBox cboViews;
        private Gizmox.WebGUI.Forms.Label lblLookup;
        private Gizmox.WebGUI.Forms.TreeView tvwCustomer;
        private Gizmox.WebGUI.Forms.ToolBar ansTree;
        private Gizmox.WebGUI.Forms.ListView lvwList;
        private Gizmox.WebGUI.Forms.ColumnHeader colItemNumber;
        private Gizmox.WebGUI.Forms.ColumnHeader colItemId;
        private Gizmox.WebGUI.Forms.ColumnHeader colStatus;
        private Gizmox.WebGUI.Forms.ColumnHeader colSample;
        private Gizmox.WebGUI.Forms.ColumnHeader colLN;
        private Gizmox.WebGUI.Forms.ColumnHeader colDate;
        private Gizmox.WebGUI.Forms.ColumnHeader colCustomer;
        private Gizmox.WebGUI.Forms.ColumnHeader colRemarks;
        private Gizmox.WebGUI.Forms.ColumnHeader colCreatedOn;
        private Gizmox.WebGUI.Forms.ColumnHeader colCreatedBy;
        private Gizmox.WebGUI.Forms.ColumnHeader colModifiedOn;
        private Gizmox.WebGUI.Forms.ColumnHeader colModifiedBy;
        private Gizmox.WebGUI.Forms.ToolBar ansList;
        private Gizmox.WebGUI.Forms.ToolTip toolTip1;
        private Gizmox.WebGUI.Forms.ColumnHeader colAttachment;
        private Gizmox.WebGUI.Forms.SplitContainer splitContainer1;
    }
}