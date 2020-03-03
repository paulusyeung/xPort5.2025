namespace xPort5.Order.Analysis
{
    partial class PurchaseHistory
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
            this.splitContainer = new Gizmox.WebGUI.Forms.SplitContainer();
            this.panelTree = new Gizmox.WebGUI.Forms.Panel();
            this.tvList = new Gizmox.WebGUI.Forms.TreeView();
            this.panelTabs = new Gizmox.WebGUI.Forms.Panel();
            this.btnOK = new Gizmox.WebGUI.Forms.Button();
            this.btnClearSelection = new Gizmox.WebGUI.Forms.Button();
            this.tabOptions = new Gizmox.WebGUI.Forms.TabControl();
            this.tpOption = new Gizmox.WebGUI.Forms.TabPage();
            this.gbSelectionBy = new Gizmox.WebGUI.Forms.GroupBox();
            this.rbtnCustomer = new Gizmox.WebGUI.Forms.RadioButton();
            this.rbtnSupplier = new Gizmox.WebGUI.Forms.RadioButton();
            this.tpPeriod = new Gizmox.WebGUI.Forms.TabPage();
            this.gbReportingPeriod = new Gizmox.WebGUI.Forms.GroupBox();
            this.cboCurrency = new Gizmox.WebGUI.Forms.ComboBox();
            this.dtpTo = new Gizmox.WebGUI.Forms.DateTimePicker();
            this.lblCurrency = new Gizmox.WebGUI.Forms.Label();
            this.lblTo = new Gizmox.WebGUI.Forms.Label();
            this.dtpFrom = new Gizmox.WebGUI.Forms.DateTimePicker();
            this.lblFrom = new Gizmox.WebGUI.Forms.Label();
            this.btnSelectionAll = new Gizmox.WebGUI.Forms.Button();
            this.toolBar1 = new Gizmox.WebGUI.Forms.ToolBar();
            this.lvwList = new Gizmox.WebGUI.Forms.ListView();
            this.colCustomerId = ((Gizmox.WebGUI.Forms.ColumnHeader)(new Gizmox.WebGUI.Forms.ColumnHeader()));
            this.colSupplier = ((Gizmox.WebGUI.Forms.ColumnHeader)(new Gizmox.WebGUI.Forms.ColumnHeader()));
            this.colContractNo = ((Gizmox.WebGUI.Forms.ColumnHeader)(new Gizmox.WebGUI.Forms.ColumnHeader()));
            this.colCustomer = ((Gizmox.WebGUI.Forms.ColumnHeader)(new Gizmox.WebGUI.Forms.ColumnHeader()));
            this.colCustRef = ((Gizmox.WebGUI.Forms.ColumnHeader)(new Gizmox.WebGUI.Forms.ColumnHeader()));
            this.colArticleCode = ((Gizmox.WebGUI.Forms.ColumnHeader)(new Gizmox.WebGUI.Forms.ColumnHeader()));
            this.colDescription = ((Gizmox.WebGUI.Forms.ColumnHeader)(new Gizmox.WebGUI.Forms.ColumnHeader()));
            this.colPacking = ((Gizmox.WebGUI.Forms.ColumnHeader)(new Gizmox.WebGUI.Forms.ColumnHeader()));
            this.colScheduledQty = ((Gizmox.WebGUI.Forms.ColumnHeader)(new Gizmox.WebGUI.Forms.ColumnHeader()));
            this.colCurrency = ((Gizmox.WebGUI.Forms.ColumnHeader)(new Gizmox.WebGUI.Forms.ColumnHeader()));
            this.colSellingPrice = ((Gizmox.WebGUI.Forms.ColumnHeader)(new Gizmox.WebGUI.Forms.ColumnHeader()));
            this.colUnit = ((Gizmox.WebGUI.Forms.ColumnHeader)(new Gizmox.WebGUI.Forms.ColumnHeader()));
            this.colCurrency2 = ((Gizmox.WebGUI.Forms.ColumnHeader)(new Gizmox.WebGUI.Forms.ColumnHeader()));
            this.colPurchaseCost = ((Gizmox.WebGUI.Forms.ColumnHeader)(new Gizmox.WebGUI.Forms.ColumnHeader()));
            this.colUnit2 = ((Gizmox.WebGUI.Forms.ColumnHeader)(new Gizmox.WebGUI.Forms.ColumnHeader()));
            this.colScheduledDate = ((Gizmox.WebGUI.Forms.ColumnHeader)(new Gizmox.WebGUI.Forms.ColumnHeader()));
            this.toolBar2 = new Gizmox.WebGUI.Forms.ToolBar();
            this.panelTree.SuspendLayout();
            this.panelTabs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabOptions)).BeginInit();
            this.tabOptions.SuspendLayout();
            this.tpOption.SuspendLayout();
            this.gbSelectionBy.SuspendLayout();
            this.tpPeriod.SuspendLayout();
            this.gbReportingPeriod.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer
            // 
            this.splitContainer.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.splitContainer.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.Clear;
            this.splitContainer.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.panelTree);
            this.splitContainer.Panel1.Controls.Add(this.panelTabs);
            this.splitContainer.Panel1.Controls.Add(this.toolBar1);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.lvwList);
            this.splitContainer.Panel2.Controls.Add(this.toolBar2);
            this.splitContainer.Size = new System.Drawing.Size(764, 481);
            this.splitContainer.SplitterDistance = 190;
            this.splitContainer.SplitterWidth = 1;
            this.splitContainer.TabIndex = 0;
            // 
            // panelTree
            // 
            this.panelTree.Controls.Add(this.tvList);
            this.panelTree.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.panelTree.Location = new System.Drawing.Point(0, 198);
            this.panelTree.Name = "panelTree";
            this.panelTree.Size = new System.Drawing.Size(190, 269);
            this.panelTree.TabIndex = 1;
            // 
            // tvList
            // 
            this.tvList.CheckBoxes = true;
            this.tvList.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.tvList.Location = new System.Drawing.Point(0, 0);
            this.tvList.Name = "tvList";
            this.tvList.Size = new System.Drawing.Size(190, 269);
            this.tvList.TabIndex = 1;
            this.tvList.Click += new System.EventHandler(this.tvList_Click);
            // 
            // panelTabs
            // 
            this.panelTabs.Controls.Add(this.btnOK);
            this.panelTabs.Controls.Add(this.btnClearSelection);
            this.panelTabs.Controls.Add(this.tabOptions);
            this.panelTabs.Controls.Add(this.btnSelectionAll);
            this.panelTabs.Dock = Gizmox.WebGUI.Forms.DockStyle.Top;
            this.panelTabs.Location = new System.Drawing.Point(0, 28);
            this.panelTabs.Name = "panelTabs";
            this.panelTabs.Size = new System.Drawing.Size(190, 170);
            this.panelTabs.TabIndex = 1;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(140, 138);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(45, 23);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "OK";
            this.btnOK.Click += new System.EventHandler(this.Button_Click);
            // 
            // btnClearSelection
            // 
            this.btnClearSelection.Location = new System.Drawing.Point(80, 138);
            this.btnClearSelection.Name = "btnClearSelection";
            this.btnClearSelection.Size = new System.Drawing.Size(45, 23);
            this.btnClearSelection.TabIndex = 2;
            this.btnClearSelection.Text = "Clear";
            this.btnClearSelection.Click += new System.EventHandler(this.Button_Click);
            // 
            // tabOptions
            // 
            this.tabOptions.Controls.Add(this.tpOption);
            this.tabOptions.Controls.Add(this.tpPeriod);
            this.tabOptions.Dock = Gizmox.WebGUI.Forms.DockStyle.Top;
            this.tabOptions.Location = new System.Drawing.Point(0, 0);
            this.tabOptions.Name = "tabOptions";
            this.tabOptions.SelectedIndex = 0;
            this.tabOptions.Size = new System.Drawing.Size(190, 132);
            this.tabOptions.TabIndex = 1;
            // 
            // tpOption
            // 
            this.tpOption.Controls.Add(this.gbSelectionBy);
            this.tpOption.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.tpOption.Location = new System.Drawing.Point(4, 22);
            this.tpOption.Name = "tpOption";
            this.tpOption.Size = new System.Drawing.Size(182, 106);
            this.tpOption.TabIndex = 0;
            this.tpOption.Text = "Option";
            // 
            // gbSelectionBy
            // 
            this.gbSelectionBy.Controls.Add(this.rbtnCustomer);
            this.gbSelectionBy.Controls.Add(this.rbtnSupplier);
            this.gbSelectionBy.FlatStyle = Gizmox.WebGUI.Forms.FlatStyle.Flat;
            this.gbSelectionBy.Location = new System.Drawing.Point(10, 10);
            this.gbSelectionBy.Name = "gbSelectionBy";
            this.gbSelectionBy.Size = new System.Drawing.Size(162, 85);
            this.gbSelectionBy.TabIndex = 1;
            this.gbSelectionBy.TabStop = false;
            this.gbSelectionBy.Text = "Selection by";
            // 
            // rbtnCustomer
            // 
            this.rbtnCustomer.Checked = true;
            this.rbtnCustomer.Location = new System.Drawing.Point(25, 31);
            this.rbtnCustomer.Name = "rbtnCustomer";
            this.rbtnCustomer.Size = new System.Drawing.Size(104, 24);
            this.rbtnCustomer.TabIndex = 1;
            this.rbtnCustomer.Text = "Customer Name";
            this.rbtnCustomer.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // rbtnSupplier
            // 
            this.rbtnSupplier.Location = new System.Drawing.Point(25, 56);
            this.rbtnSupplier.Name = "rbtnSupplier";
            this.rbtnSupplier.Size = new System.Drawing.Size(104, 24);
            this.rbtnSupplier.TabIndex = 2;
            this.rbtnSupplier.Text = "Supplier Name";
            this.rbtnSupplier.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // tpPeriod
            // 
            this.tpPeriod.Controls.Add(this.gbReportingPeriod);
            this.tpPeriod.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.tpPeriod.Location = new System.Drawing.Point(4, 22);
            this.tpPeriod.Name = "tpPeriod";
            this.tpPeriod.Size = new System.Drawing.Size(182, 106);
            this.tpPeriod.TabIndex = 0;
            this.tpPeriod.Text = "Period";
            // 
            // gbReportingPeriod
            // 
            this.gbReportingPeriod.Controls.Add(this.cboCurrency);
            this.gbReportingPeriod.Controls.Add(this.dtpTo);
            this.gbReportingPeriod.Controls.Add(this.lblCurrency);
            this.gbReportingPeriod.Controls.Add(this.lblTo);
            this.gbReportingPeriod.Controls.Add(this.dtpFrom);
            this.gbReportingPeriod.Controls.Add(this.lblFrom);
            this.gbReportingPeriod.FlatStyle = Gizmox.WebGUI.Forms.FlatStyle.Flat;
            this.gbReportingPeriod.Location = new System.Drawing.Point(10, 11);
            this.gbReportingPeriod.Name = "gbReportingPeriod";
            this.gbReportingPeriod.Size = new System.Drawing.Size(182, 85);
            this.gbReportingPeriod.TabIndex = 1;
            this.gbReportingPeriod.TabStop = false;
            this.gbReportingPeriod.Text = "Reporting Period";
            // 
            // cboCurrency
            // 
            this.cboCurrency.Location = new System.Drawing.Point(66, 52);
            this.cboCurrency.Name = "cboCurrency";
            this.cboCurrency.Size = new System.Drawing.Size(95, 21);
            this.cboCurrency.TabIndex = 1;
            this.cboCurrency.Visible = false;
            // 
            // dtpTo
            // 
            this.dtpTo.CustomFormat = "dd/MM/yyyy";
            this.dtpTo.Format = Gizmox.WebGUI.Forms.DateTimePickerFormat.Custom;
            this.dtpTo.Location = new System.Drawing.Point(66, 53);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(95, 20);
            this.dtpTo.TabIndex = 2;
            // 
            // lblCurrency
            // 
            this.lblCurrency.AutoSize = true;
            this.lblCurrency.Location = new System.Drawing.Point(14, 55);
            this.lblCurrency.Name = "lblCurrency";
            this.lblCurrency.Size = new System.Drawing.Size(33, 13);
            this.lblCurrency.TabIndex = 0;
            this.lblCurrency.Text = "Cny: ";
            this.lblCurrency.Visible = false;
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Location = new System.Drawing.Point(26, 59);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(26, 13);
            this.lblTo.TabIndex = 2;
            this.lblTo.Text = "To: ";
            // 
            // dtpFrom
            // 
            this.dtpFrom.CustomFormat = "dd/MM/yyyy";
            this.dtpFrom.Format = Gizmox.WebGUI.Forms.DateTimePickerFormat.Custom;
            this.dtpFrom.Location = new System.Drawing.Point(66, 26);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(95, 20);
            this.dtpFrom.TabIndex = 1;
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Location = new System.Drawing.Point(14, 32);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(38, 13);
            this.lblFrom.TabIndex = 1;
            this.lblFrom.Text = "From: ";
            // 
            // btnSelectionAll
            // 
            this.btnSelectionAll.Location = new System.Drawing.Point(21, 138);
            this.btnSelectionAll.Name = "btnSelectionAll";
            this.btnSelectionAll.Size = new System.Drawing.Size(45, 23);
            this.btnSelectionAll.TabIndex = 1;
            this.btnSelectionAll.Text = "All";
            this.btnSelectionAll.Click += new System.EventHandler(this.Button_Click);
            // 
            // toolBar1
            // 
            this.toolBar1.DragHandle = true;
            this.toolBar1.DropDownArrows = true;
            this.toolBar1.ImageSize = new System.Drawing.Size(16, 16);
            this.toolBar1.Location = new System.Drawing.Point(0, 0);
            this.toolBar1.MenuHandle = true;
            this.toolBar1.Name = "toolBar1";
            this.toolBar1.RightToLeft = Gizmox.WebGUI.Forms.RightToLeft.No;
            this.toolBar1.ShowToolTips = true;
            this.toolBar1.Size = new System.Drawing.Size(190, 42);
            this.toolBar1.TabIndex = 0;
            // 
            // lvwList
            // 
            this.lvwList.Columns.AddRange(new Gizmox.WebGUI.Forms.ColumnHeader[] {
            this.colCustomerId,
            this.colSupplier,
            this.colContractNo,
            this.colCustomer,
            this.colCustRef,
            this.colArticleCode,
            this.colDescription,
            this.colPacking,
            this.colScheduledQty,
            this.colCurrency,
            this.colSellingPrice,
            this.colUnit,
            this.colCurrency2,
            this.colPurchaseCost,
            this.colUnit2,
            this.colScheduledDate});
            this.lvwList.DataMember = null;
            this.lvwList.GridLines = true;
            this.lvwList.ItemsPerPage = 30;
            this.lvwList.Location = new System.Drawing.Point(48, 95);
            this.lvwList.Name = "lvwList";
            this.lvwList.Size = new System.Drawing.Size(462, 97);
            this.lvwList.TabIndex = 1;
            this.lvwList.UseInternalPaging = true;
            // 
            // colCustomerId
            // 
            this.colCustomerId.Text = "CustomerId";
            this.colCustomerId.Visible = false;
            this.colCustomerId.Width = 120;
            // 
            // colSupplier
            // 
            this.colSupplier.Text = "Supplier";
            this.colSupplier.Width = 110;
            // 
            // colContractNo
            // 
            this.colContractNo.Text = "Contract No.";
            this.colContractNo.Width = 75;
            // 
            // colCustomer
            // 
            this.colCustomer.Text = "Customer";
            this.colCustomer.Width = 80;
            // 
            // colCustRef
            // 
            this.colCustRef.Text = "Cust. Ref.";
            this.colCustRef.Width = 60;
            // 
            // colArticleCode
            // 
            this.colArticleCode.Text = "Article Code";
            this.colArticleCode.Width = 70;
            // 
            // colDescription
            // 
            this.colDescription.Text = "Description";
            this.colDescription.Width = 100;
            // 
            // colPacking
            // 
            this.colPacking.Text = "Packing";
            this.colPacking.Width = 100;
            // 
            // colScheduledQty
            // 
            this.colScheduledQty.Text = "Scheduled Qty";
            this.colScheduledQty.TextAlign = Gizmox.WebGUI.Forms.HorizontalAlignment.Right;
            this.colScheduledQty.Width = 80;
            // 
            // colCurrency
            // 
            this.colCurrency.Text = "";
            this.colCurrency.Width = 30;
            // 
            // colSellingPrice
            // 
            this.colSellingPrice.Text = "Selling Price";
            this.colSellingPrice.TextAlign = Gizmox.WebGUI.Forms.HorizontalAlignment.Right;
            this.colSellingPrice.Width = 60;
            // 
            // colUnit
            // 
            this.colUnit.Text = "Unit";
            this.colUnit.Width = 30;
            // 
            // colCurrency2
            // 
            this.colCurrency2.Text = "";
            this.colCurrency2.Width = 30;
            // 
            // colPurchaseCost
            // 
            this.colPurchaseCost.Text = "Purchase Cost";
            this.colPurchaseCost.TextAlign = Gizmox.WebGUI.Forms.HorizontalAlignment.Right;
            this.colPurchaseCost.Width = 75;
            // 
            // colUnit2
            // 
            this.colUnit2.Text = "Unit";
            this.colUnit2.Width = 30;
            // 
            // colScheduledDate
            // 
            this.colScheduledDate.Text = "Scheduled Date";
            this.colScheduledDate.TextAlign = Gizmox.WebGUI.Forms.HorizontalAlignment.Right;
            this.colScheduledDate.Width = 80;
            // 
            // toolBar2
            // 
            this.toolBar2.DragHandle = true;
            this.toolBar2.DropDownArrows = true;
            this.toolBar2.ImageSize = new System.Drawing.Size(16, 16);
            this.toolBar2.Location = new System.Drawing.Point(0, 0);
            this.toolBar2.MenuHandle = true;
            this.toolBar2.Name = "toolBar2";
            this.toolBar2.RightToLeft = Gizmox.WebGUI.Forms.RightToLeft.No;
            this.toolBar2.ShowToolTips = true;
            this.toolBar2.Size = new System.Drawing.Size(573, 42);
            this.toolBar2.TabIndex = 0;
            // 
            // PurchaseHistory
            // 
            this.Controls.Add(this.splitContainer);
            this.Size = new System.Drawing.Size(764, 481);
            this.Text = "PurchaseHistory";
            this.panelTree.ResumeLayout(false);
            this.panelTabs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabOptions)).EndInit();
            this.tabOptions.ResumeLayout(false);
            this.tpOption.ResumeLayout(false);
            this.gbSelectionBy.ResumeLayout(false);
            this.tpPeriod.ResumeLayout(false);
            this.gbReportingPeriod.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Gizmox.WebGUI.Forms.SplitContainer splitContainer;
        private Gizmox.WebGUI.Forms.ToolBar toolBar1;
        private Gizmox.WebGUI.Forms.ToolBar toolBar2;
        private Gizmox.WebGUI.Forms.Panel panelTabs;
        private Gizmox.WebGUI.Forms.Button btnOK;
        private Gizmox.WebGUI.Forms.Button btnClearSelection;
        private Gizmox.WebGUI.Forms.TabControl tabOptions;
        private Gizmox.WebGUI.Forms.TabPage tpOption;
        private Gizmox.WebGUI.Forms.GroupBox gbSelectionBy;
        private Gizmox.WebGUI.Forms.RadioButton rbtnCustomer;
        private Gizmox.WebGUI.Forms.RadioButton rbtnSupplier;
        private Gizmox.WebGUI.Forms.TabPage tpPeriod;
        private Gizmox.WebGUI.Forms.GroupBox gbReportingPeriod;
        private Gizmox.WebGUI.Forms.ComboBox cboCurrency;
        private Gizmox.WebGUI.Forms.DateTimePicker dtpTo;
        private Gizmox.WebGUI.Forms.Label lblCurrency;
        private Gizmox.WebGUI.Forms.Label lblTo;
        private Gizmox.WebGUI.Forms.DateTimePicker dtpFrom;
        private Gizmox.WebGUI.Forms.Label lblFrom;
        private Gizmox.WebGUI.Forms.Button btnSelectionAll;
        private Gizmox.WebGUI.Forms.Panel panelTree;
        private Gizmox.WebGUI.Forms.TreeView tvList;
        private Gizmox.WebGUI.Forms.ListView lvwList;
        private Gizmox.WebGUI.Forms.ColumnHeader colCustomerId;
        private Gizmox.WebGUI.Forms.ColumnHeader colSupplier;
        private Gizmox.WebGUI.Forms.ColumnHeader colContractNo;
        private Gizmox.WebGUI.Forms.ColumnHeader colCustomer;
        private Gizmox.WebGUI.Forms.ColumnHeader colCustRef;
        private Gizmox.WebGUI.Forms.ColumnHeader colArticleCode;
        private Gizmox.WebGUI.Forms.ColumnHeader colDescription;
        private Gizmox.WebGUI.Forms.ColumnHeader colPacking;
        private Gizmox.WebGUI.Forms.ColumnHeader colScheduledQty;
        private Gizmox.WebGUI.Forms.ColumnHeader colCurrency;
        private Gizmox.WebGUI.Forms.ColumnHeader colSellingPrice;
        private Gizmox.WebGUI.Forms.ColumnHeader colUnit;
        private Gizmox.WebGUI.Forms.ColumnHeader colCurrency2;
        private Gizmox.WebGUI.Forms.ColumnHeader colPurchaseCost;
        private Gizmox.WebGUI.Forms.ColumnHeader colUnit2;
        private Gizmox.WebGUI.Forms.ColumnHeader colScheduledDate;


    }
}