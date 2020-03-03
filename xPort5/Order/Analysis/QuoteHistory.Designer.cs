namespace xPort5.Order.Analysis
{
    partial class QuoteHistory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuoteHistory));
            this.splitContainer1 = new Gizmox.WebGUI.Forms.SplitContainer();
            this.tbQuote = new Gizmox.WebGUI.Forms.TabControl();
            this.tabPage1 = new Gizmox.WebGUI.Forms.TabPage();
            this.gbOurRef = new Gizmox.WebGUI.Forms.GroupBox();
            this.btnClear = new Gizmox.WebGUI.Forms.Button();
            this.btnFind = new Gizmox.WebGUI.Forms.Button();
            this.txtArticleCode = new Gizmox.WebGUI.Forms.TextBox();
            this.lblArticleCode = new Gizmox.WebGUI.Forms.Label();
            this.custRefPage = new Gizmox.WebGUI.Forms.TabPage();
            this.groupBox1 = new Gizmox.WebGUI.Forms.GroupBox();
            this.btnCustomerClear = new Gizmox.WebGUI.Forms.Button();
            this.btnCustomerFind = new Gizmox.WebGUI.Forms.Button();
            this.txtCustArticleCode = new Gizmox.WebGUI.Forms.TextBox();
            this.lblCustArticleCode = new Gizmox.WebGUI.Forms.Label();
            this.SupplierPage = new Gizmox.WebGUI.Forms.TabPage();
            this.gbSupplierCode = new Gizmox.WebGUI.Forms.GroupBox();
            this.btnSupplierClear = new Gizmox.WebGUI.Forms.Button();
            this.btnSupplierFind = new Gizmox.WebGUI.Forms.Button();
            this.txtSupplierCode = new Gizmox.WebGUI.Forms.TextBox();
            this.lblSupplierCode = new Gizmox.WebGUI.Forms.Label();
            this.ansTree = new Gizmox.WebGUI.Forms.ToolBar();
            this.ansList = new Gizmox.WebGUI.Forms.ToolBar();
            this.lvwList = new Gizmox.WebGUI.Forms.ListView();
            this.colOrderQTItemId = ((Gizmox.WebGUI.Forms.ColumnHeader)(new Gizmox.WebGUI.Forms.ColumnHeader()));
            this.colArticleCode = ((Gizmox.WebGUI.Forms.ColumnHeader)(new Gizmox.WebGUI.Forms.ColumnHeader()));
            this.colSupplierCode = ((Gizmox.WebGUI.Forms.ColumnHeader)(new Gizmox.WebGUI.Forms.ColumnHeader()));
            this.colPackageCode = ((Gizmox.WebGUI.Forms.ColumnHeader)(new Gizmox.WebGUI.Forms.ColumnHeader()));
            this.colCustomerName = ((Gizmox.WebGUI.Forms.ColumnHeader)(new Gizmox.WebGUI.Forms.ColumnHeader()));
            this.colCustomerRef = ((Gizmox.WebGUI.Forms.ColumnHeader)(new Gizmox.WebGUI.Forms.ColumnHeader()));
            this.colQuoteDate = ((Gizmox.WebGUI.Forms.ColumnHeader)(new Gizmox.WebGUI.Forms.ColumnHeader()));
            this.colPriceListNO = ((Gizmox.WebGUI.Forms.ColumnHeader)(new Gizmox.WebGUI.Forms.ColumnHeader()));
            this.colMargin = ((Gizmox.WebGUI.Forms.ColumnHeader)(new Gizmox.WebGUI.Forms.ColumnHeader()));
            this.colType = ((Gizmox.WebGUI.Forms.ColumnHeader)(new Gizmox.WebGUI.Forms.ColumnHeader()));
            this.colUnitPrice = ((Gizmox.WebGUI.Forms.ColumnHeader)(new Gizmox.WebGUI.Forms.ColumnHeader()));
            this.colCurrency1 = ((Gizmox.WebGUI.Forms.ColumnHeader)(new Gizmox.WebGUI.Forms.ColumnHeader()));
            this.colUnitCost = ((Gizmox.WebGUI.Forms.ColumnHeader)(new Gizmox.WebGUI.Forms.ColumnHeader()));
            this.colCurrencyr2 = ((Gizmox.WebGUI.Forms.ColumnHeader)(new Gizmox.WebGUI.Forms.ColumnHeader()));
            this.colInnerBox = ((Gizmox.WebGUI.Forms.ColumnHeader)(new Gizmox.WebGUI.Forms.ColumnHeader()));
            this.colOuterBox = ((Gizmox.WebGUI.Forms.ColumnHeader)(new Gizmox.WebGUI.Forms.ColumnHeader()));
            this.colCUFT = ((Gizmox.WebGUI.Forms.ColumnHeader)(new Gizmox.WebGUI.Forms.ColumnHeader()));
            this.colUnit = ((Gizmox.WebGUI.Forms.ColumnHeader)(new Gizmox.WebGUI.Forms.ColumnHeader()));
            this.colSKU = ((Gizmox.WebGUI.Forms.ColumnHeader)(new Gizmox.WebGUI.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.tbQuote)).BeginInit();
            this.tbQuote.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.gbOurRef.SuspendLayout();
            this.custRefPage.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SupplierPage.SuspendLayout();
            this.gbSupplierCode.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.splitContainer1.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.Clear;
            this.splitContainer1.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = Gizmox.WebGUI.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tbQuote);
            this.splitContainer1.Panel1.Controls.Add(this.ansTree);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.ansList);
            this.splitContainer1.Panel2.Controls.Add(this.lvwList);
            this.splitContainer1.Size = new System.Drawing.Size(831, 501);
            this.splitContainer1.SplitterDistance = 190;
            this.splitContainer1.SplitterWidth = 2;
            this.splitContainer1.TabIndex = 1;
            // 
            // tbQuote
            // 
            this.tbQuote.Controls.Add(this.tabPage1);
            this.tbQuote.Controls.Add(this.custRefPage);
            this.tbQuote.Controls.Add(this.SupplierPage);
            this.tbQuote.Location = new System.Drawing.Point(0, 92);
            this.tbQuote.Name = "tbQuote";
            this.tbQuote.SelectedIndex = 0;
            this.tbQuote.Size = new System.Drawing.Size(190, 200);
            this.tbQuote.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.gbOurRef);
            this.tabPage1.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(182, 174);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Our Ref";
            // 
            // gbOurRef
            // 
            this.gbOurRef.Controls.Add(this.btnClear);
            this.gbOurRef.Controls.Add(this.btnFind);
            this.gbOurRef.Controls.Add(this.txtArticleCode);
            this.gbOurRef.Controls.Add(this.lblArticleCode);
            this.gbOurRef.FlatStyle = Gizmox.WebGUI.Forms.FlatStyle.Flat;
            this.gbOurRef.Location = new System.Drawing.Point(12, 18);
            this.gbOurRef.Name = "gbOurRef";
            this.gbOurRef.Size = new System.Drawing.Size(156, 137);
            this.gbOurRef.TabIndex = 0;
            this.gbOurRef.TabStop = false;
            this.gbOurRef.Text = "Select By";
            // 
            // btnClear
            // 
            this.btnClear.Image = new Gizmox.WebGUI.Common.Resources.IconResourceHandle(resources.GetString("btnClear.Image"));
            this.btnClear.Location = new System.Drawing.Point(81, 85);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(60, 23);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear";
            this.btnClear.TextImageRelation = Gizmox.WebGUI.Forms.TextImageRelation.ImageBeforeText;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnFind
            // 
            this.btnFind.Image = new Gizmox.WebGUI.Common.Resources.IconResourceHandle(resources.GetString("btnFind.Image"));
            this.btnFind.Location = new System.Drawing.Point(18, 85);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(60, 23);
            this.btnFind.TabIndex = 2;
            this.btnFind.Text = "Find";
            this.btnFind.TextImageRelation = Gizmox.WebGUI.Forms.TextImageRelation.ImageBeforeText;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // txtArticleCode
            // 
            this.txtArticleCode.Location = new System.Drawing.Point(18, 47);
            this.txtArticleCode.Name = "txtArticleCode";
            this.txtArticleCode.Size = new System.Drawing.Size(123, 20);
            this.txtArticleCode.TabIndex = 1;
            // 
            // lblArticleCode
            // 
            this.lblArticleCode.Location = new System.Drawing.Point(18, 27);
            this.lblArticleCode.Name = "lblArticleCode";
            this.lblArticleCode.Size = new System.Drawing.Size(100, 17);
            this.lblArticleCode.TabIndex = 0;
            this.lblArticleCode.Text = "Article Code:";
            // 
            // custRefPage
            // 
            this.custRefPage.Controls.Add(this.groupBox1);
            this.custRefPage.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.custRefPage.Location = new System.Drawing.Point(4, 22);
            this.custRefPage.Name = "custRefPage";
            this.custRefPage.Size = new System.Drawing.Size(182, 174);
            this.custRefPage.TabIndex = 0;
            this.custRefPage.Text = "Cust. Ref.";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCustomerClear);
            this.groupBox1.Controls.Add(this.btnCustomerFind);
            this.groupBox1.Controls.Add(this.txtCustArticleCode);
            this.groupBox1.Controls.Add(this.lblCustArticleCode);
            this.groupBox1.FlatStyle = Gizmox.WebGUI.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(12, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(156, 137);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select By";
            // 
            // btnCustomerClear
            // 
            this.btnCustomerClear.Image = new Gizmox.WebGUI.Common.Resources.IconResourceHandle(resources.GetString("btnCustomerClear.Image"));
            this.btnCustomerClear.Location = new System.Drawing.Point(81, 85);
            this.btnCustomerClear.Name = "btnCustomerClear";
            this.btnCustomerClear.Size = new System.Drawing.Size(60, 23);
            this.btnCustomerClear.TabIndex = 3;
            this.btnCustomerClear.Text = "Clear";
            this.btnCustomerClear.TextImageRelation = Gizmox.WebGUI.Forms.TextImageRelation.ImageBeforeText;
            this.btnCustomerClear.Click += new System.EventHandler(this.btnCustomerClear_Click);
            // 
            // btnCustomerFind
            // 
            this.btnCustomerFind.Image = new Gizmox.WebGUI.Common.Resources.IconResourceHandle(resources.GetString("btnCustomerFind.Image"));
            this.btnCustomerFind.Location = new System.Drawing.Point(18, 85);
            this.btnCustomerFind.Name = "btnCustomerFind";
            this.btnCustomerFind.Size = new System.Drawing.Size(60, 23);
            this.btnCustomerFind.TabIndex = 2;
            this.btnCustomerFind.Text = "Find";
            this.btnCustomerFind.TextImageRelation = Gizmox.WebGUI.Forms.TextImageRelation.ImageBeforeText;
            this.btnCustomerFind.Click += new System.EventHandler(this.btnCustomerFind_Click);
            // 
            // txtCustArticleCode
            // 
            this.txtCustArticleCode.Location = new System.Drawing.Point(18, 47);
            this.txtCustArticleCode.Name = "txtCustArticleCode";
            this.txtCustArticleCode.Size = new System.Drawing.Size(123, 20);
            this.txtCustArticleCode.TabIndex = 1;
            // 
            // lblCustArticleCode
            // 
            this.lblCustArticleCode.Location = new System.Drawing.Point(18, 27);
            this.lblCustArticleCode.Name = "lblCustArticleCode";
            this.lblCustArticleCode.Size = new System.Drawing.Size(123, 17);
            this.lblCustArticleCode.TabIndex = 0;
            this.lblCustArticleCode.Text = "Customer Article Code:";
            // 
            // SupplierPage
            // 
            this.SupplierPage.Controls.Add(this.gbSupplierCode);
            this.SupplierPage.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.SupplierPage.Location = new System.Drawing.Point(4, 22);
            this.SupplierPage.Name = "SupplierPage";
            this.SupplierPage.Size = new System.Drawing.Size(182, 174);
            this.SupplierPage.TabIndex = 0;
            this.SupplierPage.Text = "Supplier";
            // 
            // gbSupplierCode
            // 
            this.gbSupplierCode.Controls.Add(this.btnSupplierClear);
            this.gbSupplierCode.Controls.Add(this.btnSupplierFind);
            this.gbSupplierCode.Controls.Add(this.txtSupplierCode);
            this.gbSupplierCode.Controls.Add(this.lblSupplierCode);
            this.gbSupplierCode.FlatStyle = Gizmox.WebGUI.Forms.FlatStyle.Flat;
            this.gbSupplierCode.Location = new System.Drawing.Point(12, 18);
            this.gbSupplierCode.Name = "gbSupplierCode";
            this.gbSupplierCode.Size = new System.Drawing.Size(156, 137);
            this.gbSupplierCode.TabIndex = 0;
            this.gbSupplierCode.TabStop = false;
            this.gbSupplierCode.Text = "Select By";
            // 
            // btnSupplierClear
            // 
            this.btnSupplierClear.Image = new Gizmox.WebGUI.Common.Resources.IconResourceHandle(resources.GetString("btnSupplierClear.Image"));
            this.btnSupplierClear.Location = new System.Drawing.Point(81, 85);
            this.btnSupplierClear.Name = "btnSupplierClear";
            this.btnSupplierClear.Size = new System.Drawing.Size(60, 23);
            this.btnSupplierClear.TabIndex = 3;
            this.btnSupplierClear.Text = "Clear";
            this.btnSupplierClear.TextImageRelation = Gizmox.WebGUI.Forms.TextImageRelation.ImageBeforeText;
            this.btnSupplierClear.Click += new System.EventHandler(this.btnSupplierClear_Click);
            // 
            // btnSupplierFind
            // 
            this.btnSupplierFind.Image = new Gizmox.WebGUI.Common.Resources.IconResourceHandle(resources.GetString("btnSupplierFind.Image"));
            this.btnSupplierFind.Location = new System.Drawing.Point(18, 85);
            this.btnSupplierFind.Name = "btnSupplierFind";
            this.btnSupplierFind.Size = new System.Drawing.Size(60, 23);
            this.btnSupplierFind.TabIndex = 2;
            this.btnSupplierFind.Text = "Find";
            this.btnSupplierFind.TextImageRelation = Gizmox.WebGUI.Forms.TextImageRelation.ImageBeforeText;
            this.btnSupplierFind.Click += new System.EventHandler(this.btnSupplierFind_Click);
            // 
            // txtSupplierCode
            // 
            this.txtSupplierCode.Location = new System.Drawing.Point(18, 47);
            this.txtSupplierCode.Name = "txtSupplierCode";
            this.txtSupplierCode.Size = new System.Drawing.Size(123, 20);
            this.txtSupplierCode.TabIndex = 1;
            // 
            // lblSupplierCode
            // 
            this.lblSupplierCode.Location = new System.Drawing.Point(18, 27);
            this.lblSupplierCode.Name = "lblSupplierCode";
            this.lblSupplierCode.Size = new System.Drawing.Size(100, 17);
            this.lblSupplierCode.TabIndex = 0;
            this.lblSupplierCode.Text = "Supplier Code:";
            // 
            // ansTree
            // 
            this.ansTree.Dock = Gizmox.WebGUI.Forms.DockStyle.None;
            this.ansTree.DragHandle = true;
            this.ansTree.DropDownArrows = true;
            this.ansTree.ImageSize = new System.Drawing.Size(16, 16);
            this.ansTree.Location = new System.Drawing.Point(57, 42);
            this.ansTree.MenuHandle = true;
            this.ansTree.Name = "ansTree";
            this.ansTree.RightToLeft = Gizmox.WebGUI.Forms.RightToLeft.No;
            this.ansTree.ShowToolTips = true;
            this.ansTree.Size = new System.Drawing.Size(100, 24);
            this.ansTree.TabIndex = 0;
            // 
            // ansList
            // 
            this.ansList.Dock = Gizmox.WebGUI.Forms.DockStyle.None;
            this.ansList.DragHandle = true;
            this.ansList.DropDownArrows = true;
            this.ansList.ImageSize = new System.Drawing.Size(16, 16);
            this.ansList.Location = new System.Drawing.Point(215, 42);
            this.ansList.MenuHandle = true;
            this.ansList.Name = "ansList";
            this.ansList.RightToLeft = Gizmox.WebGUI.Forms.RightToLeft.No;
            this.ansList.ShowToolTips = true;
            this.ansList.Size = new System.Drawing.Size(140, 42);
            this.ansList.TabIndex = 1;
            this.ansList.ButtonClick += new Gizmox.WebGUI.Forms.ToolBarButtonClickEventHandler(this.ansList_ButtonClick);
            // 
            // lvwList
            // 
            this.lvwList.Columns.AddRange(new Gizmox.WebGUI.Forms.ColumnHeader[] {
            this.colOrderQTItemId,
            this.colArticleCode,
            this.colSupplierCode,
            this.colPackageCode,
            this.colCustomerName,
            this.colCustomerRef,
            this.colQuoteDate,
            this.colPriceListNO,
            this.colMargin,
            this.colType,
            this.colUnitPrice,
            this.colCurrency1,
            this.colUnitCost,
            this.colCurrencyr2,
            this.colInnerBox,
            this.colOuterBox,
            this.colCUFT,
            this.colUnit,
            this.colSKU});
            this.lvwList.DataMember = null;
            this.lvwList.GridLines = true;
            this.lvwList.ItemsPerPage = 30;
            this.lvwList.Location = new System.Drawing.Point(33, 141);
            this.lvwList.Margin = new Gizmox.WebGUI.Forms.Padding(0, 24, 0, 0);
            this.lvwList.MultiSelect = false;
            this.lvwList.Name = "lvwList";
            this.lvwList.Size = new System.Drawing.Size(571, 97);
            this.lvwList.TabIndex = 0;
            this.lvwList.UseInternalPaging = true;
            // 
            // colOrderQTItemId
            // 
            this.colOrderQTItemId.Text = "OrderQtItemId";
            this.colOrderQTItemId.Visible = false;
            this.colOrderQTItemId.Width = 100;
            // 
            // colArticleCode
            // 
            this.colArticleCode.Text = "Article Code";
            this.colArticleCode.TextAlign = Gizmox.WebGUI.Forms.HorizontalAlignment.Center;
            this.colArticleCode.Width = 80;
            // 
            // colSupplierCode
            // 
            this.colSupplierCode.Text = "Supplier Code";
            this.colSupplierCode.TextAlign = Gizmox.WebGUI.Forms.HorizontalAlignment.Center;
            this.colSupplierCode.Width = 80;
            // 
            // colPackageCode
            // 
            this.colPackageCode.Text = "Package Code";
            this.colPackageCode.TextAlign = Gizmox.WebGUI.Forms.HorizontalAlignment.Center;
            this.colPackageCode.Width = 80;
            // 
            // colCustomerName
            // 
            this.colCustomerName.Text = "Customer Name";
            this.colCustomerName.Width = 120;
            // 
            // colCustomerRef
            // 
            this.colCustomerRef.Text = "Customer Ref.";
            this.colCustomerRef.TextAlign = Gizmox.WebGUI.Forms.HorizontalAlignment.Center;
            this.colCustomerRef.Width = 100;
            // 
            // colQuoteDate
            // 
            this.colQuoteDate.Text = "Quote Date";
            this.colQuoteDate.TextAlign = Gizmox.WebGUI.Forms.HorizontalAlignment.Center;
            this.colQuoteDate.Width = 80;
            // 
            // colPriceListNO
            // 
            this.colPriceListNO.Text = "Price List No.";
            this.colPriceListNO.TextAlign = Gizmox.WebGUI.Forms.HorizontalAlignment.Center;
            this.colPriceListNO.Width = 80;
            // 
            // colMargin
            // 
            this.colMargin.Text = "Margin %";
            this.colMargin.TextAlign = Gizmox.WebGUI.Forms.HorizontalAlignment.Center;
            this.colMargin.Width = 60;
            // 
            // colType
            // 
            this.colType.Text = "T";
            this.colType.Width = 15;
            // 
            // colUnitPrice
            // 
            this.colUnitPrice.Text = "Unit Price";
            this.colUnitPrice.TextAlign = Gizmox.WebGUI.Forms.HorizontalAlignment.Center;
            this.colUnitPrice.Width = 80;
            // 
            // colCurrency1
            // 
            this.colCurrency1.Text = "";
            this.colCurrency1.TextAlign = Gizmox.WebGUI.Forms.HorizontalAlignment.Center;
            this.colCurrency1.Width = 30;
            // 
            // colUnitCost
            // 
            this.colUnitCost.Text = "Unit Cost";
            this.colUnitCost.TextAlign = Gizmox.WebGUI.Forms.HorizontalAlignment.Center;
            this.colUnitCost.Width = 80;
            // 
            // colCurrencyr2
            // 
            this.colCurrencyr2.Text = "";
            this.colCurrencyr2.TextAlign = Gizmox.WebGUI.Forms.HorizontalAlignment.Center;
            this.colCurrencyr2.Width = 30;
            // 
            // colInnerBox
            // 
            this.colInnerBox.Text = "Inner Box";
            this.colInnerBox.TextAlign = Gizmox.WebGUI.Forms.HorizontalAlignment.Center;
            this.colInnerBox.Width = 70;
            // 
            // colOuterBox
            // 
            this.colOuterBox.Text = "Outer Box";
            this.colOuterBox.TextAlign = Gizmox.WebGUI.Forms.HorizontalAlignment.Center;
            this.colOuterBox.Width = 70;
            // 
            // colCUFT
            // 
            this.colCUFT.Text = "CUFT";
            this.colCUFT.TextAlign = Gizmox.WebGUI.Forms.HorizontalAlignment.Center;
            this.colCUFT.Width = 70;
            // 
            // colUnit
            // 
            this.colUnit.Text = "Unit";
            this.colUnit.TextAlign = Gizmox.WebGUI.Forms.HorizontalAlignment.Center;
            this.colUnit.Width = 50;
            // 
            // colSKU
            // 
            this.colSKU.Text = "SKU";
            this.colSKU.TextAlign = Gizmox.WebGUI.Forms.HorizontalAlignment.Center;
            this.colSKU.Width = 60;
            // 
            // QuoteHistory
            // 
            this.Controls.Add(this.splitContainer1);
            this.Size = new System.Drawing.Size(831, 501);
            this.Text = "QuoteHistory";
            ((System.ComponentModel.ISupportInitialize)(this.tbQuote)).EndInit();
            this.tbQuote.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.gbOurRef.ResumeLayout(false);
            this.custRefPage.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.SupplierPage.ResumeLayout(false);
            this.gbSupplierCode.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Gizmox.WebGUI.Forms.SplitContainer splitContainer1;
        private Gizmox.WebGUI.Forms.ToolBar ansTree;
        private Gizmox.WebGUI.Forms.ToolBar ansList;
        private Gizmox.WebGUI.Forms.ListView lvwList;
        private Gizmox.WebGUI.Forms.TabControl tbQuote;
        private Gizmox.WebGUI.Forms.TabPage tabPage1;
        private Gizmox.WebGUI.Forms.TabPage custRefPage;
        private Gizmox.WebGUI.Forms.TabPage SupplierPage;
        private Gizmox.WebGUI.Forms.ColumnHeader colArticleCode;
        private Gizmox.WebGUI.Forms.ColumnHeader colSupplierCode;
        private Gizmox.WebGUI.Forms.ColumnHeader colPackageCode;
        private Gizmox.WebGUI.Forms.ColumnHeader colCustomerName;
        private Gizmox.WebGUI.Forms.ColumnHeader colCustomerRef;
        private Gizmox.WebGUI.Forms.ColumnHeader colQuoteDate;
        private Gizmox.WebGUI.Forms.ColumnHeader colPriceListNO;
        private Gizmox.WebGUI.Forms.ColumnHeader colMargin;
        private Gizmox.WebGUI.Forms.ColumnHeader colUnitPrice;
        private Gizmox.WebGUI.Forms.ColumnHeader colUnitCost;
        private Gizmox.WebGUI.Forms.ColumnHeader colInnerBox;
        private Gizmox.WebGUI.Forms.ColumnHeader colOuterBox;
        private Gizmox.WebGUI.Forms.ColumnHeader colCUFT;
        private Gizmox.WebGUI.Forms.ColumnHeader colUnit;
        private Gizmox.WebGUI.Forms.ColumnHeader colSKU;
        private Gizmox.WebGUI.Forms.GroupBox gbOurRef;
        private Gizmox.WebGUI.Forms.Button btnClear;
        private Gizmox.WebGUI.Forms.Button btnFind;
        private Gizmox.WebGUI.Forms.TextBox txtArticleCode;
        private Gizmox.WebGUI.Forms.Label lblArticleCode;
        private Gizmox.WebGUI.Forms.ColumnHeader colCurrency1;
        private Gizmox.WebGUI.Forms.ColumnHeader colCurrencyr2;
        private Gizmox.WebGUI.Forms.ColumnHeader colOrderQTItemId;
        private Gizmox.WebGUI.Forms.ColumnHeader colType;
        private Gizmox.WebGUI.Forms.GroupBox groupBox1;
        private Gizmox.WebGUI.Forms.Button btnCustomerClear;
        private Gizmox.WebGUI.Forms.Button btnCustomerFind;
        private Gizmox.WebGUI.Forms.TextBox txtCustArticleCode;
        private Gizmox.WebGUI.Forms.Label lblCustArticleCode;
        private Gizmox.WebGUI.Forms.GroupBox gbSupplierCode;
        private Gizmox.WebGUI.Forms.Button btnSupplierClear;
        private Gizmox.WebGUI.Forms.Button btnSupplierFind;
        private Gizmox.WebGUI.Forms.TextBox txtSupplierCode;
        private Gizmox.WebGUI.Forms.Label lblSupplierCode;


    }
}