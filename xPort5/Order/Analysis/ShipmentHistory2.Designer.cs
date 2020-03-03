namespace xPort5.Order.Analysis
{
    partial class ShipmentHistory2
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
            Gizmox.WebGUI.Common.Resources.IconResourceHandle iconResourceHandle2 = new Gizmox.WebGUI.Common.Resources.IconResourceHandle();
            this.splitContainer = new Gizmox.WebGUI.Forms.SplitContainer();
            this.tabShipment = new Gizmox.WebGUI.Forms.TabControl();
            this.tpName = new Gizmox.WebGUI.Forms.TabPage();
            this.tvList = new Gizmox.WebGUI.Forms.TreeView();
            this.panelByName = new Gizmox.WebGUI.Forms.Panel();
            this.rbtnBySupplier = new Gizmox.WebGUI.Forms.RadioButton();
            this.rbtnByCustomer = new Gizmox.WebGUI.Forms.RadioButton();
            this.tpSearch = new Gizmox.WebGUI.Forms.TabPage();
            this.btnSearch = new Gizmox.WebGUI.Forms.Button();
            this.gbByCode = new Gizmox.WebGUI.Forms.GroupBox();
            this.txtToCode = new Gizmox.WebGUI.Forms.TextBox();
            this.lblToCode = new Gizmox.WebGUI.Forms.Label();
            this.txtFromCode = new Gizmox.WebGUI.Forms.TextBox();
            this.lblFromCode = new Gizmox.WebGUI.Forms.Label();
            this.rbtnSuppRef = new Gizmox.WebGUI.Forms.RadioButton();
            this.rbtnCustRef = new Gizmox.WebGUI.Forms.RadioButton();
            this.rbtnArticleCode = new Gizmox.WebGUI.Forms.RadioButton();
            this.gbDate = new Gizmox.WebGUI.Forms.GroupBox();
            this.dtpDateTo = new Gizmox.WebGUI.Forms.DateTimePicker();
            this.lblDateTo = new Gizmox.WebGUI.Forms.Label();
            this.dtpDateFrom = new Gizmox.WebGUI.Forms.DateTimePicker();
            this.lblDateFrom = new Gizmox.WebGUI.Forms.Label();
            this.toolBar1 = new Gizmox.WebGUI.Forms.ToolBar();
            this.lvwList = new Gizmox.WebGUI.Forms.ListView();
            this.colOrderQTItemId = new Gizmox.WebGUI.Forms.ColumnHeader();
            this.colArticleCode = new Gizmox.WebGUI.Forms.ColumnHeader();
            this.colSupplierCode = new Gizmox.WebGUI.Forms.ColumnHeader();
            this.colPackageCode = new Gizmox.WebGUI.Forms.ColumnHeader();
            this.colCustomerRef = new Gizmox.WebGUI.Forms.ColumnHeader();
            this.colSupplierRef = new Gizmox.WebGUI.Forms.ColumnHeader();
            this.colCustomerName = new Gizmox.WebGUI.Forms.ColumnHeader();
            this.colSupplierName = new Gizmox.WebGUI.Forms.ColumnHeader();
            this.colSalesContract = new Gizmox.WebGUI.Forms.ColumnHeader();
            this.colScheduledDate = new Gizmox.WebGUI.Forms.ColumnHeader();
            this.colScheduledQty = new Gizmox.WebGUI.Forms.ColumnHeader();
            this.colUnit = new Gizmox.WebGUI.Forms.ColumnHeader();
            this.colShippedQty = new Gizmox.WebGUI.Forms.ColumnHeader();
            this.colOSQty = new Gizmox.WebGUI.Forms.ColumnHeader();
            this.toolBar2 = new Gizmox.WebGUI.Forms.ToolBar();
            this.SuspendLayout();
            // 
            // splitContainer
            // 
            this.splitContainer.Anchor = Gizmox.WebGUI.Forms.AnchorStyles.None;
            this.splitContainer.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.Clear;
            this.splitContainer.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.splitContainer.FixedPanel = Gizmox.WebGUI.Forms.FixedPanel.Panel1;
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
            this.splitContainer.Name = "splitContainer";
            this.splitContainer.Orientation = Gizmox.WebGUI.Forms.Orientation.Vertical;
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.tabShipment);
            this.splitContainer.Panel1.Controls.Add(this.toolBar1);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.lvwList);
            this.splitContainer.Panel2.Controls.Add(this.toolBar2);
            this.splitContainer.Size = new System.Drawing.Size(831, 501);
            this.splitContainer.SplitterDistance = 190;
            this.splitContainer.SplitterWidth = 1;
            this.splitContainer.TabIndex = 1;
            // 
            // tabShipment
            // 
            this.tabShipment.Anchor = Gizmox.WebGUI.Forms.AnchorStyles.None;
            this.tabShipment.Controls.Add(this.tpName);
            this.tabShipment.Controls.Add(this.tpSearch);
            this.tabShipment.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.tabShipment.Location = new System.Drawing.Point(0, 28);
            this.tabShipment.Multiline = false;
            this.tabShipment.Name = "tabShipment";
            this.tabShipment.SelectedIndex = 0;
            this.tabShipment.Size = new System.Drawing.Size(190, 473);
            this.tabShipment.TabIndex = 1;
            // 
            // tpName
            // 
            this.tpName.Controls.Add(this.tvList);
            this.tpName.Controls.Add(this.panelByName);
            this.tpName.Location = new System.Drawing.Point(4, 22);
            this.tpName.Name = "tpName";
            this.tpName.Size = new System.Drawing.Size(182, 447);
            this.tpName.TabIndex = 0;
            this.tpName.Text = "Cust./Supp.";
            // 
            // tvList
            // 
            this.tvList.Anchor = Gizmox.WebGUI.Forms.AnchorStyles.None;
            this.tvList.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.tvList.Location = new System.Drawing.Point(0, 79);
            this.tvList.Name = "tvList";
            this.tvList.Size = new System.Drawing.Size(182, 368);
            this.tvList.TabIndex = 1;
            this.tvList.AfterSelect += new Gizmox.WebGUI.Forms.TreeViewEventHandler(this.tvList_AfterSelect);
            // 
            // panelByName
            // 
            this.panelByName.Anchor = Gizmox.WebGUI.Forms.AnchorStyles.None;
            this.panelByName.Controls.Add(this.rbtnBySupplier);
            this.panelByName.Controls.Add(this.rbtnByCustomer);
            this.panelByName.Dock = Gizmox.WebGUI.Forms.DockStyle.Top;
            this.panelByName.Location = new System.Drawing.Point(0, 0);
            this.panelByName.Name = "panelByName";
            this.panelByName.Size = new System.Drawing.Size(182, 79);
            this.panelByName.TabIndex = 0;
            // 
            // rbtnBySupplier
            // 
            this.rbtnBySupplier.Location = new System.Drawing.Point(21, 41);
            this.rbtnBySupplier.Name = "rbtnBySupplier";
            this.rbtnBySupplier.Size = new System.Drawing.Size(104, 24);
            this.rbtnBySupplier.TabIndex = 2;
            this.rbtnBySupplier.Text = "By Supplier";
            this.rbtnBySupplier.CheckedChanged += new System.EventHandler(this.RadionButton_CheckedChanged);
            // 
            // rbtnByCustomer
            // 
            this.rbtnByCustomer.Checked = true;
            this.rbtnByCustomer.Location = new System.Drawing.Point(21, 16);
            this.rbtnByCustomer.Name = "rbtnByCustomer";
            this.rbtnByCustomer.Size = new System.Drawing.Size(104, 24);
            this.rbtnByCustomer.TabIndex = 1;
            this.rbtnByCustomer.Text = "By Customer ";
            this.rbtnByCustomer.CheckedChanged += new System.EventHandler(this.RadionButton_CheckedChanged);
            // 
            // tpSearch
            // 
            this.tpSearch.Controls.Add(this.btnSearch);
            this.tpSearch.Controls.Add(this.gbByCode);
            this.tpSearch.Controls.Add(this.gbDate);
            this.tpSearch.Location = new System.Drawing.Point(4, 22);
            this.tpSearch.Name = "tpSearch";
            this.tpSearch.Size = new System.Drawing.Size(182, 447);
            this.tpSearch.TabIndex = 0;
            this.tpSearch.Text = "Search";
            // 
            // btnSearch
            // 
            iconResourceHandle2.File = "16x16.16_find.gif";
            this.btnSearch.Image = iconResourceHandle2;
            this.btnSearch.Location = new System.Drawing.Point(104, 333);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.TextImageRelation = Gizmox.WebGUI.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // gbByCode
            // 
            this.gbByCode.Controls.Add(this.txtToCode);
            this.gbByCode.Controls.Add(this.lblToCode);
            this.gbByCode.Controls.Add(this.txtFromCode);
            this.gbByCode.Controls.Add(this.lblFromCode);
            this.gbByCode.Controls.Add(this.rbtnSuppRef);
            this.gbByCode.Controls.Add(this.rbtnCustRef);
            this.gbByCode.Controls.Add(this.rbtnArticleCode);
            this.gbByCode.FlatStyle = Gizmox.WebGUI.Forms.FlatStyle.Flat;
            this.gbByCode.Location = new System.Drawing.Point(4, 139);
            this.gbByCode.Name = "gbByCode";
            this.gbByCode.Size = new System.Drawing.Size(175, 181);
            this.gbByCode.TabIndex = 1;
            this.gbByCode.Text = "Select by";
            // 
            // txtToCode
            // 
            this.txtToCode.Location = new System.Drawing.Point(10, 152);
            this.txtToCode.Name = "txtToCode";
            this.txtToCode.Size = new System.Drawing.Size(141, 20);
            this.txtToCode.TabIndex = 6;
            // 
            // lblToCode
            // 
            this.lblToCode.Location = new System.Drawing.Point(10, 133);
            this.lblToCode.Name = "lblToCode";
            this.lblToCode.Size = new System.Drawing.Size(100, 17);
            this.lblToCode.TabIndex = 5;
            this.lblToCode.Text = "To Code:";
            // 
            // txtFromCode
            // 
            this.txtFromCode.Location = new System.Drawing.Point(10, 111);
            this.txtFromCode.Name = "txtFromCode";
            this.txtFromCode.Size = new System.Drawing.Size(141, 20);
            this.txtFromCode.TabIndex = 4;
            // 
            // lblFromCode
            // 
            this.lblFromCode.Location = new System.Drawing.Point(10, 92);
            this.lblFromCode.Name = "lblFromCode";
            this.lblFromCode.Size = new System.Drawing.Size(100, 17);
            this.lblFromCode.TabIndex = 3;
            this.lblFromCode.Text = "From Code:";
            // 
            // rbtnSuppRef
            // 
            this.rbtnSuppRef.Location = new System.Drawing.Point(10, 65);
            this.rbtnSuppRef.Name = "rbtnSuppRef";
            this.rbtnSuppRef.Size = new System.Drawing.Size(141, 17);
            this.rbtnSuppRef.TabIndex = 2;
            this.rbtnSuppRef.Text = "Supplier Ref. Code";
            // 
            // rbtnCustRef
            // 
            this.rbtnCustRef.Location = new System.Drawing.Point(10, 46);
            this.rbtnCustRef.Name = "rbtnCustRef";
            this.rbtnCustRef.Size = new System.Drawing.Size(141, 17);
            this.rbtnCustRef.TabIndex = 1;
            this.rbtnCustRef.Text = "Customer Ref.Code";
            // 
            // rbtnArticleCode
            // 
            this.rbtnArticleCode.Checked = true;
            this.rbtnArticleCode.Location = new System.Drawing.Point(10, 26);
            this.rbtnArticleCode.Name = "rbtnArticleCode";
            this.rbtnArticleCode.Size = new System.Drawing.Size(141, 17);
            this.rbtnArticleCode.TabIndex = 0;
            this.rbtnArticleCode.Text = "Article Code";
            // 
            // gbDate
            // 
            this.gbDate.Controls.Add(this.dtpDateTo);
            this.gbDate.Controls.Add(this.lblDateTo);
            this.gbDate.Controls.Add(this.dtpDateFrom);
            this.gbDate.Controls.Add(this.lblDateFrom);
            this.gbDate.FlatStyle = Gizmox.WebGUI.Forms.FlatStyle.Flat;
            this.gbDate.Location = new System.Drawing.Point(4, 15);
            this.gbDate.Name = "gbDate";
            this.gbDate.Size = new System.Drawing.Size(175, 121);
            this.gbDate.TabIndex = 0;
            this.gbDate.Text = "Select Date Range";
            // 
            // dtpDateTo
            // 
            this.dtpDateTo.CalendarFirstDayOfWeek = Gizmox.WebGUI.Forms.Day.Default;
            this.dtpDateTo.CustomFormat = "MM/dd/yyyy";
            this.dtpDateTo.Format = Gizmox.WebGUI.Forms.DateTimePickerFormat.Custom;
            this.dtpDateTo.Location = new System.Drawing.Point(10, 84);
            this.dtpDateTo.Name = "dtpDateTo";
            this.dtpDateTo.Size = new System.Drawing.Size(141, 20);
            this.dtpDateTo.TabIndex = 3;
            // 
            // lblDateTo
            // 
            this.lblDateTo.Location = new System.Drawing.Point(10, 65);
            this.lblDateTo.Name = "lblDateTo";
            this.lblDateTo.Size = new System.Drawing.Size(100, 17);
            this.lblDateTo.TabIndex = 2;
            this.lblDateTo.Text = "To:";
            // 
            // dtpDateFrom
            // 
            this.dtpDateFrom.CalendarFirstDayOfWeek = Gizmox.WebGUI.Forms.Day.Default;
            this.dtpDateFrom.CustomFormat = "MM/dd/yyyy";
            this.dtpDateFrom.Format = Gizmox.WebGUI.Forms.DateTimePickerFormat.Custom;
            this.dtpDateFrom.Location = new System.Drawing.Point(10, 40);
            this.dtpDateFrom.Name = "dtpDateFrom";
            this.dtpDateFrom.Size = new System.Drawing.Size(141, 20);
            this.dtpDateFrom.TabIndex = 1;
            // 
            // lblDateFrom
            // 
            this.lblDateFrom.Location = new System.Drawing.Point(10, 20);
            this.lblDateFrom.Name = "lblDateFrom";
            this.lblDateFrom.Size = new System.Drawing.Size(100, 17);
            this.lblDateFrom.TabIndex = 0;
            this.lblDateFrom.Text = "From:";
            // 
            // toolBar1
            // 
            this.toolBar1.Anchor = Gizmox.WebGUI.Forms.AnchorStyles.None;
            this.toolBar1.Appearance = Gizmox.WebGUI.Forms.ToolBarAppearance.Normal;
            this.toolBar1.Dock = Gizmox.WebGUI.Forms.DockStyle.Top;
            this.toolBar1.DragHandle = false;
            this.toolBar1.DropDownArrows = false;
            this.toolBar1.ImageList = null;
            this.toolBar1.Location = new System.Drawing.Point(0, 0);
            this.toolBar1.MenuHandle = false;
            this.toolBar1.Name = "toolBar1";
            this.toolBar1.RightToLeft = Gizmox.WebGUI.Forms.RightToLeft.No;
            this.toolBar1.ShowToolTips = true;
            this.toolBar1.TabIndex = 0;
            // 
            // lvwList
            // 
            this.lvwList.Columns.AddRange(new Gizmox.WebGUI.Forms.ColumnHeader[] {
            this.colOrderQTItemId,
            this.colArticleCode,
            this.colSupplierCode,
            this.colPackageCode,
            this.colCustomerRef,
            this.colSupplierRef,
            this.colCustomerName,
            this.colSupplierName,
            this.colSalesContract,
            this.colScheduledDate,
            this.colScheduledQty,
            this.colUnit,
            this.colShippedQty,
            this.colOSQty});
            this.lvwList.DataMember = null;
            this.lvwList.GridLines = true;
            this.lvwList.ItemsPerPage = 30;
            this.lvwList.Location = new System.Drawing.Point(53, 122);
            this.lvwList.MultiSelect = false;
            this.lvwList.Name = "lvwList";
            this.lvwList.Size = new System.Drawing.Size(512, 97);
            this.lvwList.TabIndex = 2;
            this.lvwList.UseInternalPaging = true;
            this.lvwList.DoubleClick += new System.EventHandler(this.lvwList_DoubleClick);
            // 
            // colOrderQTItemId
            // 
            this.colOrderQTItemId.Image = null;
            this.colOrderQTItemId.Text = "OrderQTItemId";
            this.colOrderQTItemId.Visible = false;
            this.colOrderQTItemId.Width = 100;
            // 
            // colArticleCode
            // 
            this.colArticleCode.Image = null;
            this.colArticleCode.Text = "ArticleCode";
            this.colArticleCode.Width = 80;
            // 
            // colSupplierCode
            // 
            this.colSupplierCode.Image = null;
            this.colSupplierCode.Text = "Supplier Code";
            this.colSupplierCode.Width = 80;
            // 
            // colPackageCode
            // 
            this.colPackageCode.Image = null;
            this.colPackageCode.Text = "Package Code";
            this.colPackageCode.Width = 80;
            // 
            // colCustomerRef
            // 
            this.colCustomerRef.Image = null;
            this.colCustomerRef.Text = "Customer Ref.";
            this.colCustomerRef.Width = 80;
            // 
            // colSupplierRef
            // 
            this.colSupplierRef.Image = null;
            this.colSupplierRef.Text = "Supplier Ref.";
            this.colSupplierRef.Width = 80;
            // 
            // colCustomerName
            // 
            this.colCustomerName.Image = null;
            this.colCustomerName.Text = "Customer Name";
            this.colCustomerName.Width = 100;
            // 
            // colSupplierName
            // 
            this.colSupplierName.Image = null;
            this.colSupplierName.Text = "Supplier Name";
            this.colSupplierName.Width = 100;
            // 
            // colSalesContract
            // 
            this.colSalesContract.Image = null;
            this.colSalesContract.Text = "Sales Contract";
            this.colSalesContract.Width = 80;
            // 
            // colScheduledDate
            // 
            this.colScheduledDate.Image = null;
            this.colScheduledDate.Text = "Scheduled Date";
            this.colScheduledDate.TextAlign = Gizmox.WebGUI.Forms.HorizontalAlignment.Right;
            this.colScheduledDate.Width = 80;
            // 
            // colScheduledQty
            // 
            this.colScheduledQty.Image = null;
            this.colScheduledQty.Text = "Scheduled Qty";
            this.colScheduledQty.TextAlign = Gizmox.WebGUI.Forms.HorizontalAlignment.Right;
            this.colScheduledQty.Width = 80;
            // 
            // colUnit
            // 
            this.colUnit.Image = null;
            this.colUnit.Text = "Unit";
            this.colUnit.Width = 30;
            // 
            // colShippedQty
            // 
            this.colShippedQty.Image = null;
            this.colShippedQty.Text = "Shipped Qty";
            this.colShippedQty.TextAlign = Gizmox.WebGUI.Forms.HorizontalAlignment.Right;
            this.colShippedQty.Width = 80;
            // 
            // colOSQty
            // 
            this.colOSQty.Image = null;
            this.colOSQty.Text = "O/S Qty";
            this.colOSQty.TextAlign = Gizmox.WebGUI.Forms.HorizontalAlignment.Right;
            this.colOSQty.Width = 50;
            // 
            // toolBar2
            // 
            this.toolBar2.Anchor = Gizmox.WebGUI.Forms.AnchorStyles.None;
            this.toolBar2.Appearance = Gizmox.WebGUI.Forms.ToolBarAppearance.Normal;
            this.toolBar2.Dock = Gizmox.WebGUI.Forms.DockStyle.Top;
            this.toolBar2.DragHandle = false;
            this.toolBar2.DropDownArrows = false;
            this.toolBar2.ImageList = null;
            this.toolBar2.Location = new System.Drawing.Point(0, 0);
            this.toolBar2.MenuHandle = false;
            this.toolBar2.Name = "toolBar2";
            this.toolBar2.RightToLeft = Gizmox.WebGUI.Forms.RightToLeft.No;
            this.toolBar2.ShowToolTips = true;
            this.toolBar2.TabIndex = 1;
            // 
            // ShipmentHistory2
            // 
            this.Controls.Add(this.splitContainer);
            this.Size = new System.Drawing.Size(831, 501);
            this.Text = "QuoteHistory";
            this.ResumeLayout(false);

        }

        #endregion

        private Gizmox.WebGUI.Forms.SplitContainer splitContainer;
        private Gizmox.WebGUI.Forms.ToolBar toolBar1;
        private Gizmox.WebGUI.Forms.ToolBar toolBar2;
        private Gizmox.WebGUI.Forms.TabControl tabShipment;
        private Gizmox.WebGUI.Forms.TabPage tpName;
        private Gizmox.WebGUI.Forms.TabPage tpSearch;
        private Gizmox.WebGUI.Forms.RadioButton rbtnByCustomer;
        private Gizmox.WebGUI.Forms.RadioButton rbtnBySupplier;
        private Gizmox.WebGUI.Forms.TreeView tvList;
        private Gizmox.WebGUI.Forms.Panel panelByName;
        private Gizmox.WebGUI.Forms.Button btnSearch;
        private Gizmox.WebGUI.Forms.GroupBox gbByCode;
        private Gizmox.WebGUI.Forms.GroupBox gbDate;
        private Gizmox.WebGUI.Forms.TextBox txtToCode;
        private Gizmox.WebGUI.Forms.Label lblToCode;
        private Gizmox.WebGUI.Forms.TextBox txtFromCode;
        private Gizmox.WebGUI.Forms.Label lblFromCode;
        private Gizmox.WebGUI.Forms.RadioButton rbtnSuppRef;
        private Gizmox.WebGUI.Forms.RadioButton rbtnCustRef;
        private Gizmox.WebGUI.Forms.RadioButton rbtnArticleCode;
        private Gizmox.WebGUI.Forms.DateTimePicker dtpDateTo;
        private Gizmox.WebGUI.Forms.Label lblDateTo;
        private Gizmox.WebGUI.Forms.DateTimePicker dtpDateFrom;
        private Gizmox.WebGUI.Forms.Label lblDateFrom;
        private Gizmox.WebGUI.Forms.ListView lvwList;
        private Gizmox.WebGUI.Forms.ColumnHeader colOrderQTItemId;
        private Gizmox.WebGUI.Forms.ColumnHeader colArticleCode;
        private Gizmox.WebGUI.Forms.ColumnHeader colSupplierCode;
        private Gizmox.WebGUI.Forms.ColumnHeader colPackageCode;
        private Gizmox.WebGUI.Forms.ColumnHeader colCustomerRef;
        private Gizmox.WebGUI.Forms.ColumnHeader colSupplierRef;
        private Gizmox.WebGUI.Forms.ColumnHeader colCustomerName;
        private Gizmox.WebGUI.Forms.ColumnHeader colSupplierName;
        private Gizmox.WebGUI.Forms.ColumnHeader colSalesContract;
        private Gizmox.WebGUI.Forms.ColumnHeader colScheduledDate;
        private Gizmox.WebGUI.Forms.ColumnHeader colScheduledQty;
        private Gizmox.WebGUI.Forms.ColumnHeader colUnit;
        private Gizmox.WebGUI.Forms.ColumnHeader colShippedQty;
        private Gizmox.WebGUI.Forms.ColumnHeader colOSQty;


    }
}