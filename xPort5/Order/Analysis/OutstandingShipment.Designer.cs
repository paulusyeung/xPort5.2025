namespace xPort5.Order.Analysis
{
    partial class OutstandingShipment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OutstandingShipment));
            this.splitContainer1 = new Gizmox.WebGUI.Forms.SplitContainer();
            this.tvList = new Gizmox.WebGUI.Forms.TreeView();
            this.tbOsShipment = new Gizmox.WebGUI.Forms.TabControl();
            this.tpCustSupp = new Gizmox.WebGUI.Forms.TabPage();
            this.rbtSupplier = new Gizmox.WebGUI.Forms.RadioButton();
            this.rbtCustomer = new Gizmox.WebGUI.Forms.RadioButton();
            this.lblCustSupp = new Gizmox.WebGUI.Forms.Label();
            this.tpArticle = new Gizmox.WebGUI.Forms.TabPage();
            this.btnFind = new Gizmox.WebGUI.Forms.Button();
            this.txtArticle = new Gizmox.WebGUI.Forms.TextBox();
            this.tpOption = new Gizmox.WebGUI.Forms.TabPage();
            this.gbPeriod = new Gizmox.WebGUI.Forms.GroupBox();
            this.dtpToDate = new Gizmox.WebGUI.Forms.DateTimePicker();
            this.dtpFromDate = new Gizmox.WebGUI.Forms.DateTimePicker();
            this.lblToDatetime = new Gizmox.WebGUI.Forms.Label();
            this.lblFromDatetime = new Gizmox.WebGUI.Forms.Label();
            this.gbColor = new Gizmox.WebGUI.Forms.GroupBox();
            this.txtGreen = new Gizmox.WebGUI.Forms.TextBox();
            this.lblGreen = new Gizmox.WebGUI.Forms.Label();
            this.txtYellow = new Gizmox.WebGUI.Forms.TextBox();
            this.lblYellow = new Gizmox.WebGUI.Forms.Label();
            this.txtRed = new Gizmox.WebGUI.Forms.TextBox();
            this.lblRed = new Gizmox.WebGUI.Forms.Label();
            this.toolBar1 = new Gizmox.WebGUI.Forms.ToolBar();
            this.toolBar2 = new Gizmox.WebGUI.Forms.ToolBar();
            this.lvwList = new Gizmox.WebGUI.Forms.ListView();
            this.colCustomerId = ((Gizmox.WebGUI.Forms.ColumnHeader)(new Gizmox.WebGUI.Forms.ColumnHeader()));
            this.colCustomer = ((Gizmox.WebGUI.Forms.ColumnHeader)(new Gizmox.WebGUI.Forms.ColumnHeader()));
            this.colCustRef = ((Gizmox.WebGUI.Forms.ColumnHeader)(new Gizmox.WebGUI.Forms.ColumnHeader()));
            this.colArticleNo = ((Gizmox.WebGUI.Forms.ColumnHeader)(new Gizmox.WebGUI.Forms.ColumnHeader()));
            this.colArticleName = ((Gizmox.WebGUI.Forms.ColumnHeader)(new Gizmox.WebGUI.Forms.ColumnHeader()));
            this.colCurrency1 = ((Gizmox.WebGUI.Forms.ColumnHeader)(new Gizmox.WebGUI.Forms.ColumnHeader()));
            this.colUnitPrice = ((Gizmox.WebGUI.Forms.ColumnHeader)(new Gizmox.WebGUI.Forms.ColumnHeader()));
            this.colOrderQty = ((Gizmox.WebGUI.Forms.ColumnHeader)(new Gizmox.WebGUI.Forms.ColumnHeader()));
            this.colUnit = ((Gizmox.WebGUI.Forms.ColumnHeader)(new Gizmox.WebGUI.Forms.ColumnHeader()));
            this.colShipmentDate = ((Gizmox.WebGUI.Forms.ColumnHeader)(new Gizmox.WebGUI.Forms.ColumnHeader()));
            this.colScheduledQty = ((Gizmox.WebGUI.Forms.ColumnHeader)(new Gizmox.WebGUI.Forms.ColumnHeader()));
            this.colShippedQty = ((Gizmox.WebGUI.Forms.ColumnHeader)(new Gizmox.WebGUI.Forms.ColumnHeader()));
            this.colOSQty = ((Gizmox.WebGUI.Forms.ColumnHeader)(new Gizmox.WebGUI.Forms.ColumnHeader()));
            this.colOSAmount = ((Gizmox.WebGUI.Forms.ColumnHeader)(new Gizmox.WebGUI.Forms.ColumnHeader()));
            this.colSupplier = ((Gizmox.WebGUI.Forms.ColumnHeader)(new Gizmox.WebGUI.Forms.ColumnHeader()));
            this.colSalesContract = ((Gizmox.WebGUI.Forms.ColumnHeader)(new Gizmox.WebGUI.Forms.ColumnHeader()));
            this.tabPage1 = new Gizmox.WebGUI.Forms.TabPage();
            this.tabPage2 = new Gizmox.WebGUI.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.tbOsShipment)).BeginInit();
            this.tbOsShipment.SuspendLayout();
            this.tpCustSupp.SuspendLayout();
            this.tpArticle.SuspendLayout();
            this.tpOption.SuspendLayout();
            this.gbPeriod.SuspendLayout();
            this.gbColor.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.splitContainer1.BorderColor = new Gizmox.WebGUI.Forms.BorderColor(System.Drawing.Color.BlanchedAlmond);
            this.splitContainer1.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.Clear;
            this.splitContainer1.Dock = Gizmox.WebGUI.Forms.DockStyle.Left;
            this.splitContainer1.FixedPanel = Gizmox.WebGUI.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tvList);
            this.splitContainer1.Panel1.Controls.Add(this.tbOsShipment);
            this.splitContainer1.Panel1.Controls.Add(this.toolBar1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.toolBar2);
            this.splitContainer1.Panel2.Controls.Add(this.lvwList);
            this.splitContainer1.Size = new System.Drawing.Size(793, 520);
            this.splitContainer1.SplitterDistance = 180;
            this.splitContainer1.SplitterWidth = 1;
            this.splitContainer1.TabIndex = 0;
            // 
            // tvList
            // 
            this.tvList.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.tvList.Location = new System.Drawing.Point(0, 218);
            this.tvList.Margin = new Gizmox.WebGUI.Forms.Padding(0, 10, 0, 0);
            this.tvList.Name = "tvList";
            this.tvList.Size = new System.Drawing.Size(180, 288);
            this.tvList.TabIndex = 2;
            this.tvList.AfterSelect += new Gizmox.WebGUI.Forms.TreeViewEventHandler(this.tvList_AfterSelect);
            // 
            // tbOsShipment
            // 
            this.tbOsShipment.Controls.Add(this.tpCustSupp);
            this.tbOsShipment.Controls.Add(this.tpArticle);
            this.tbOsShipment.Controls.Add(this.tpOption);
            this.tbOsShipment.Dock = Gizmox.WebGUI.Forms.DockStyle.Top;
            this.tbOsShipment.Location = new System.Drawing.Point(0, 28);
            this.tbOsShipment.Margin = new Gizmox.WebGUI.Forms.Padding(0, 0, 0, 10);
            this.tbOsShipment.Name = "tbOsShipment";
            this.tbOsShipment.SelectedIndex = 0;
            this.tbOsShipment.Size = new System.Drawing.Size(180, 190);
            this.tbOsShipment.TabIndex = 1;
            // 
            // tpCustSupp
            // 
            this.tpCustSupp.Controls.Add(this.rbtSupplier);
            this.tpCustSupp.Controls.Add(this.rbtCustomer);
            this.tpCustSupp.Controls.Add(this.lblCustSupp);
            this.tpCustSupp.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.tpCustSupp.Location = new System.Drawing.Point(4, 22);
            this.tpCustSupp.Name = "tpCustSupp";
            this.tpCustSupp.Size = new System.Drawing.Size(172, 164);
            this.tpCustSupp.TabIndex = 0;
            this.tpCustSupp.Text = "Cust/Supp";
            // 
            // rbtSupplier
            // 
            this.rbtSupplier.Location = new System.Drawing.Point(19, 102);
            this.rbtSupplier.Name = "rbtSupplier";
            this.rbtSupplier.Size = new System.Drawing.Size(104, 20);
            this.rbtSupplier.TabIndex = 2;
            this.rbtSupplier.Text = "By Supplier";
            this.rbtSupplier.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // rbtCustomer
            // 
            this.rbtCustomer.Checked = true;
            this.rbtCustomer.Location = new System.Drawing.Point(19, 76);
            this.rbtCustomer.Name = "rbtCustomer";
            this.rbtCustomer.Size = new System.Drawing.Size(104, 20);
            this.rbtCustomer.TabIndex = 1;
            this.rbtCustomer.Text = "By Customer";
            this.rbtCustomer.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // lblCustSupp
            // 
            this.lblCustSupp.Location = new System.Drawing.Point(16, 15);
            this.lblCustSupp.Name = "lblCustSupp";
            this.lblCustSupp.Size = new System.Drawing.Size(168, 47);
            this.lblCustSupp.TabIndex = 0;
            this.lblCustSupp.Text = "Pick your selection by drilling\r\ndown the Customer/Supplier\r\ntree below.";
            // 
            // tpArticle
            // 
            this.tpArticle.Controls.Add(this.btnFind);
            this.tpArticle.Controls.Add(this.txtArticle);
            this.tpArticle.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.tpArticle.Location = new System.Drawing.Point(4, 22);
            this.tpArticle.Name = "tpArticle";
            this.tpArticle.Size = new System.Drawing.Size(172, 164);
            this.tpArticle.TabIndex = 0;
            this.tpArticle.Text = "Article";
            // 
            // btnFind
            // 
            this.btnFind.Image = new Gizmox.WebGUI.Common.Resources.IconResourceHandle(resources.GetString("btnFind.Image"));
            this.btnFind.Location = new System.Drawing.Point(125, 55);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(35, 23);
            this.btnFind.TabIndex = 1;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // txtArticle
            // 
            this.txtArticle.Location = new System.Drawing.Point(18, 55);
            this.txtArticle.Name = "txtArticle";
            this.txtArticle.Size = new System.Drawing.Size(100, 20);
            this.txtArticle.TabIndex = 0;
            // 
            // tpOption
            // 
            this.tpOption.Controls.Add(this.gbPeriod);
            this.tpOption.Controls.Add(this.gbColor);
            this.tpOption.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.tpOption.Location = new System.Drawing.Point(4, 22);
            this.tpOption.Name = "tpOption";
            this.tpOption.Size = new System.Drawing.Size(172, 164);
            this.tpOption.TabIndex = 0;
            this.tpOption.Text = "Option";
            // 
            // gbPeriod
            // 
            this.gbPeriod.Controls.Add(this.dtpToDate);
            this.gbPeriod.Controls.Add(this.dtpFromDate);
            this.gbPeriod.Controls.Add(this.lblToDatetime);
            this.gbPeriod.Controls.Add(this.lblFromDatetime);
            this.gbPeriod.FlatStyle = Gizmox.WebGUI.Forms.FlatStyle.Flat;
            this.gbPeriod.Location = new System.Drawing.Point(9, 88);
            this.gbPeriod.Name = "gbPeriod";
            this.gbPeriod.Size = new System.Drawing.Size(160, 70);
            this.gbPeriod.TabIndex = 1;
            this.gbPeriod.TabStop = false;
            this.gbPeriod.Text = "Period";
            // 
            // dtpToDate
            // 
            this.dtpToDate.CustomFormat = "dd MMM yyyy";
            this.dtpToDate.Format = Gizmox.WebGUI.Forms.DateTimePickerFormat.Custom;
            this.dtpToDate.Location = new System.Drawing.Point(52, 41);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.Size = new System.Drawing.Size(98, 20);
            this.dtpToDate.TabIndex = 3;
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.CustomFormat = "dd MMM yyyy";
            this.dtpFromDate.Format = Gizmox.WebGUI.Forms.DateTimePickerFormat.Custom;
            this.dtpFromDate.Location = new System.Drawing.Point(52, 16);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(98, 20);
            this.dtpFromDate.TabIndex = 2;
            // 
            // lblToDatetime
            // 
            this.lblToDatetime.Location = new System.Drawing.Point(15, 41);
            this.lblToDatetime.Name = "lblToDatetime";
            this.lblToDatetime.Size = new System.Drawing.Size(35, 16);
            this.lblToDatetime.TabIndex = 1;
            this.lblToDatetime.Text = "To:";
            // 
            // lblFromDatetime
            // 
            this.lblFromDatetime.Location = new System.Drawing.Point(15, 20);
            this.lblFromDatetime.Name = "lblFromDatetime";
            this.lblFromDatetime.Size = new System.Drawing.Size(35, 16);
            this.lblFromDatetime.TabIndex = 0;
            this.lblFromDatetime.Text = "From:";
            // 
            // gbColor
            // 
            this.gbColor.Controls.Add(this.txtGreen);
            this.gbColor.Controls.Add(this.lblGreen);
            this.gbColor.Controls.Add(this.txtYellow);
            this.gbColor.Controls.Add(this.lblYellow);
            this.gbColor.Controls.Add(this.txtRed);
            this.gbColor.Controls.Add(this.lblRed);
            this.gbColor.FlatStyle = Gizmox.WebGUI.Forms.FlatStyle.Flat;
            this.gbColor.Location = new System.Drawing.Point(9, 3);
            this.gbColor.Name = "gbColor";
            this.gbColor.Size = new System.Drawing.Size(160, 83);
            this.gbColor.TabIndex = 0;
            this.gbColor.TabStop = false;
            this.gbColor.Text = "Color by Number of Days";
            // 
            // txtGreen
            // 
            this.txtGreen.Location = new System.Drawing.Point(109, 44);
            this.txtGreen.Name = "txtGreen";
            this.txtGreen.Size = new System.Drawing.Size(35, 20);
            this.txtGreen.TabIndex = 5;
            this.txtGreen.Text = "90";
            // 
            // lblGreen
            // 
            this.lblGreen.Location = new System.Drawing.Point(109, 25);
            this.lblGreen.Name = "lblGreen";
            this.lblGreen.Size = new System.Drawing.Size(36, 16);
            this.lblGreen.TabIndex = 4;
            this.lblGreen.Text = "Green";
            // 
            // txtYellow
            // 
            this.txtYellow.Location = new System.Drawing.Point(60, 44);
            this.txtYellow.Name = "txtYellow";
            this.txtYellow.Size = new System.Drawing.Size(35, 20);
            this.txtYellow.TabIndex = 3;
            this.txtYellow.Text = "60";
            // 
            // lblYellow
            // 
            this.lblYellow.Location = new System.Drawing.Point(60, 25);
            this.lblYellow.Name = "lblYellow";
            this.lblYellow.Size = new System.Drawing.Size(38, 16);
            this.lblYellow.TabIndex = 2;
            this.lblYellow.Text = "Yellow";
            // 
            // txtRed
            // 
            this.txtRed.Location = new System.Drawing.Point(15, 44);
            this.txtRed.Name = "txtRed";
            this.txtRed.Size = new System.Drawing.Size(35, 20);
            this.txtRed.TabIndex = 1;
            this.txtRed.Text = "30";
            // 
            // lblRed
            // 
            this.lblRed.Location = new System.Drawing.Point(20, 25);
            this.lblRed.Name = "lblRed";
            this.lblRed.Size = new System.Drawing.Size(26, 16);
            this.lblRed.TabIndex = 0;
            this.lblRed.Text = "Red";
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
            this.toolBar1.Size = new System.Drawing.Size(180, 42);
            this.toolBar1.TabIndex = 1;
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
            this.toolBar2.Size = new System.Drawing.Size(612, 42);
            this.toolBar2.TabIndex = 1;
            // 
            // lvwList
            // 
            this.lvwList.Columns.AddRange(new Gizmox.WebGUI.Forms.ColumnHeader[] {
            this.colCustomerId,
            this.colCustomer,
            this.colCustRef,
            this.colArticleNo,
            this.colArticleName,
            this.colCurrency1,
            this.colUnitPrice,
            this.colOrderQty,
            this.colUnit,
            this.colShipmentDate,
            this.colScheduledQty,
            this.colShippedQty,
            this.colOSQty,
            this.colOSAmount,
            this.colSupplier,
            this.colSalesContract});
            this.lvwList.DataMember = null;
            this.lvwList.GridLines = true;
            this.lvwList.ItemsPerPage = 30;
            this.lvwList.Location = new System.Drawing.Point(18, 97);
            this.lvwList.MultiSelect = false;
            this.lvwList.Name = "lvwList";
            this.lvwList.Size = new System.Drawing.Size(540, 140);
            this.lvwList.TabIndex = 0;
            this.lvwList.UseInternalPaging = true;
            // 
            // colCustomerId
            // 
            this.colCustomerId.Text = "CustomerId";
            this.colCustomerId.Visible = false;
            this.colCustomerId.Width = 100;
            // 
            // colCustomer
            // 
            this.colCustomer.Text = "Customer";
            this.colCustomer.Width = 100;
            // 
            // colCustRef
            // 
            this.colCustRef.Text = "Cust. Ref.";
            this.colCustRef.TextAlign = Gizmox.WebGUI.Forms.HorizontalAlignment.Center;
            this.colCustRef.Width = 65;
            // 
            // colArticleNo
            // 
            this.colArticleNo.Text = "Article No.";
            this.colArticleNo.TextAlign = Gizmox.WebGUI.Forms.HorizontalAlignment.Center;
            this.colArticleNo.Width = 65;
            // 
            // colArticleName
            // 
            this.colArticleName.Text = "Article Name";
            this.colArticleName.Width = 80;
            // 
            // colCurrency1
            // 
            this.colCurrency1.Text = "";
            this.colCurrency1.TextAlign = Gizmox.WebGUI.Forms.HorizontalAlignment.Center;
            this.colCurrency1.Width = 30;
            // 
            // colUnitPrice
            // 
            this.colUnitPrice.Text = "Unit Price";
            this.colUnitPrice.TextAlign = Gizmox.WebGUI.Forms.HorizontalAlignment.Right;
            this.colUnitPrice.Width = 60;
            // 
            // colOrderQty
            // 
            this.colOrderQty.Text = "Order Qty";
            this.colOrderQty.TextAlign = Gizmox.WebGUI.Forms.HorizontalAlignment.Right;
            this.colOrderQty.Width = 60;
            // 
            // colUnit
            // 
            this.colUnit.Text = "Unit";
            this.colUnit.TextAlign = Gizmox.WebGUI.Forms.HorizontalAlignment.Center;
            this.colUnit.Width = 30;
            // 
            // colShipmentDate
            // 
            this.colShipmentDate.Text = "Shipment Date";
            this.colShipmentDate.TextAlign = Gizmox.WebGUI.Forms.HorizontalAlignment.Center;
            this.colShipmentDate.Width = 80;
            // 
            // colScheduledQty
            // 
            this.colScheduledQty.Text = "Scheduled Qty";
            this.colScheduledQty.TextAlign = Gizmox.WebGUI.Forms.HorizontalAlignment.Right;
            this.colScheduledQty.Width = 80;
            // 
            // colShippedQty
            // 
            this.colShippedQty.Text = "Shipped Qty";
            this.colShippedQty.TextAlign = Gizmox.WebGUI.Forms.HorizontalAlignment.Right;
            this.colShippedQty.Width = 70;
            // 
            // colOSQty
            // 
            this.colOSQty.Text = "O/S Qty";
            this.colOSQty.TextAlign = Gizmox.WebGUI.Forms.HorizontalAlignment.Right;
            this.colOSQty.Width = 60;
            // 
            // colOSAmount
            // 
            this.colOSAmount.Text = "O/S Amount";
            this.colOSAmount.TextAlign = Gizmox.WebGUI.Forms.HorizontalAlignment.Right;
            this.colOSAmount.Width = 80;
            // 
            // colSupplier
            // 
            this.colSupplier.Text = "Supplier";
            this.colSupplier.Width = 80;
            // 
            // colSalesContract
            // 
            this.colSalesContract.Text = "Sales Contract";
            this.colSalesContract.TextAlign = Gizmox.WebGUI.Forms.HorizontalAlignment.Center;
            this.colSalesContract.Width = 80;
            // 
            // tabPage1
            // 
            this.tabPage1.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(192, 74);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            // 
            // tabPage2
            // 
            this.tabPage2.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(100, 100);
            this.tabPage2.TabIndex = 0;
            this.tabPage2.Text = "tabPage2";
            // 
            // OutstandingShipment
            // 
            this.Controls.Add(this.splitContainer1);
            this.Size = new System.Drawing.Size(793, 520);
            this.Text = "OutstandingShipment";
            ((System.ComponentModel.ISupportInitialize)(this.tbOsShipment)).EndInit();
            this.tbOsShipment.ResumeLayout(false);
            this.tpCustSupp.ResumeLayout(false);
            this.tpArticle.ResumeLayout(false);
            this.tpOption.ResumeLayout(false);
            this.gbPeriod.ResumeLayout(false);
            this.gbColor.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Gizmox.WebGUI.Forms.SplitContainer splitContainer1;
        private Gizmox.WebGUI.Forms.ListView lvwList;
        private Gizmox.WebGUI.Forms.ToolBar toolBar1;
        private Gizmox.WebGUI.Forms.ToolBar toolBar2;
        private Gizmox.WebGUI.Forms.TabControl tbOsShipment;
        private Gizmox.WebGUI.Forms.TabPage tpCustSupp;
        private Gizmox.WebGUI.Forms.TabPage tpArticle;
        private Gizmox.WebGUI.Forms.TabPage tpOption;
        private Gizmox.WebGUI.Forms.ColumnHeader colCustomer;
        private Gizmox.WebGUI.Forms.ColumnHeader colCustRef;
        private Gizmox.WebGUI.Forms.ColumnHeader colArticleNo;
        private Gizmox.WebGUI.Forms.ColumnHeader colArticleName;
        private Gizmox.WebGUI.Forms.ColumnHeader colCurrency1;
        private Gizmox.WebGUI.Forms.ColumnHeader colUnitPrice;
        private Gizmox.WebGUI.Forms.ColumnHeader colOrderQty;
        private Gizmox.WebGUI.Forms.ColumnHeader colUnit;
        private Gizmox.WebGUI.Forms.ColumnHeader colShipmentDate;
        private Gizmox.WebGUI.Forms.ColumnHeader colScheduledQty;
        private Gizmox.WebGUI.Forms.ColumnHeader colOSQty;
        private Gizmox.WebGUI.Forms.ColumnHeader colOSAmount;
        private Gizmox.WebGUI.Forms.ColumnHeader colSupplier;
        private Gizmox.WebGUI.Forms.ColumnHeader colSalesContract;
        private Gizmox.WebGUI.Forms.ColumnHeader colShippedQty;
        private Gizmox.WebGUI.Forms.Button btnFind;
        private Gizmox.WebGUI.Forms.TextBox txtArticle;
        private Gizmox.WebGUI.Forms.RadioButton rbtSupplier;
        private Gizmox.WebGUI.Forms.RadioButton rbtCustomer;
        private Gizmox.WebGUI.Forms.Label lblCustSupp;
        private Gizmox.WebGUI.Forms.GroupBox gbColor;
        private Gizmox.WebGUI.Forms.Label lblRed;
        private Gizmox.WebGUI.Forms.TextBox txtRed;
        private Gizmox.WebGUI.Forms.Label lblYellow;
        private Gizmox.WebGUI.Forms.TextBox txtYellow;
        private Gizmox.WebGUI.Forms.TextBox txtGreen;
        private Gizmox.WebGUI.Forms.Label lblGreen;
        private Gizmox.WebGUI.Forms.GroupBox gbPeriod;
        private Gizmox.WebGUI.Forms.Label lblToDatetime;
        private Gizmox.WebGUI.Forms.Label lblFromDatetime;
        private Gizmox.WebGUI.Forms.DateTimePicker dtpFromDate;
        private Gizmox.WebGUI.Forms.DateTimePicker dtpToDate;
        private Gizmox.WebGUI.Forms.TreeView tvList;
        private Gizmox.WebGUI.Forms.ColumnHeader colCustomerId;
        private Gizmox.WebGUI.Forms.TabPage tabPage1;
        private Gizmox.WebGUI.Forms.TabPage tabPage2;
    }
}