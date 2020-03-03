namespace xPort5.Order.Coding.Customer
{
    partial class CustomerRecord
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
            Gizmox.WebGUI.Common.Resources.IconResourceHandle iconResourceHandle3 = new Gizmox.WebGUI.Common.Resources.IconResourceHandle();
            Gizmox.WebGUI.Common.Resources.IconResourceHandle iconResourceHandle2 = new Gizmox.WebGUI.Common.Resources.IconResourceHandle();
            Gizmox.WebGUI.Common.Resources.IconResourceHandle iconResourceHandle1 = new Gizmox.WebGUI.Common.Resources.IconResourceHandle();
            this.ansToolbar = new Gizmox.WebGUI.Forms.ToolBar();
            this.wspBackground = new Gizmox.WebGUI.Forms.Panel();
            this.chkBlacklisted = new Gizmox.WebGUI.Forms.CheckBox();
            this.lblBlacklisted = new Gizmox.WebGUI.Forms.Label();
            this.txtProfitMargin = new Gizmox.WebGUI.Forms.TextBox();
            this.lblProfitMargin = new Gizmox.WebGUI.Forms.Label();
            this.cboRegion = new Gizmox.WebGUI.Forms.ComboBox();
            this.cmdNextCustomerCode = new Gizmox.WebGUI.Forms.Button();
            this.boxLogs = new Gizmox.WebGUI.Forms.GroupBox();
            this.lblModifiedOb = new Gizmox.WebGUI.Forms.Label();
            this.txtModifiedOn = new Gizmox.WebGUI.Forms.Label();
            this.txtModifiedBy = new Gizmox.WebGUI.Forms.Label();
            this.lblModifiedBy = new Gizmox.WebGUI.Forms.Label();
            this.lblCreatedBy = new Gizmox.WebGUI.Forms.Label();
            this.txtCreatedBy = new Gizmox.WebGUI.Forms.Label();
            this.txtCreatedOn = new Gizmox.WebGUI.Forms.Label();
            this.lblCreatedOn = new Gizmox.WebGUI.Forms.Label();
            this.tabCustomer = new Gizmox.WebGUI.Forms.TabControl();
            this.tabContact = new Gizmox.WebGUI.Forms.TabPage();
            this.tabAddress = new Gizmox.WebGUI.Forms.TabPage();
            this.txtRemarks = new Gizmox.WebGUI.Forms.TextBox();
            this.lblRemarks = new Gizmox.WebGUI.Forms.Label();
            this.cboCurrency = new Gizmox.WebGUI.Forms.ComboBox();
            this.lblCurrency = new Gizmox.WebGUI.Forms.Label();
            this.lblTerms = new Gizmox.WebGUI.Forms.Label();
            this.cboTerms = new Gizmox.WebGUI.Forms.ComboBox();
            this.lblRegion = new Gizmox.WebGUI.Forms.Label();
            this.txtCreditLimit = new Gizmox.WebGUI.Forms.TextBox();
            this.lblCreditLimit = new Gizmox.WebGUI.Forms.Label();
            this.txtACNumber = new Gizmox.WebGUI.Forms.TextBox();
            this.lblAccountName = new Gizmox.WebGUI.Forms.Label();
            this.txtName = new Gizmox.WebGUI.Forms.TextBox();
            this.lblName = new Gizmox.WebGUI.Forms.Label();
            this.txtCustomerCode = new Gizmox.WebGUI.Forms.TextBox();
            this.lblCode = new Gizmox.WebGUI.Forms.Label();
            this.colDept = new Gizmox.WebGUI.Forms.ColumnHeader();
            this.colClass = new Gizmox.WebGUI.Forms.ColumnHeader();
            this.colCategory = new Gizmox.WebGUI.Forms.ColumnHeader();
            this.colCategoryId = new Gizmox.WebGUI.Forms.ColumnHeader();
            this.toolTip1 = new Gizmox.WebGUI.Forms.ToolTip(this.components);
            this.lblName_Chs = new Gizmox.WebGUI.Forms.Label();
            this.lblName_Cht = new Gizmox.WebGUI.Forms.Label();
            this.txtName_Chs = new Gizmox.WebGUI.Forms.TextBox();
            this.txtName_Cht = new Gizmox.WebGUI.Forms.TextBox();
            this.cmdConvertToCht = new Gizmox.WebGUI.Forms.Button();
            this.cmdConvertToChs = new Gizmox.WebGUI.Forms.Button();
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
            this.wspBackground.Controls.Add(this.cmdConvertToChs);
            this.wspBackground.Controls.Add(this.cmdConvertToCht);
            this.wspBackground.Controls.Add(this.txtName_Cht);
            this.wspBackground.Controls.Add(this.txtName_Chs);
            this.wspBackground.Controls.Add(this.lblName_Cht);
            this.wspBackground.Controls.Add(this.lblName_Chs);
            this.wspBackground.Controls.Add(this.chkBlacklisted);
            this.wspBackground.Controls.Add(this.lblBlacklisted);
            this.wspBackground.Controls.Add(this.txtProfitMargin);
            this.wspBackground.Controls.Add(this.lblProfitMargin);
            this.wspBackground.Controls.Add(this.cboRegion);
            this.wspBackground.Controls.Add(this.cmdNextCustomerCode);
            this.wspBackground.Controls.Add(this.boxLogs);
            this.wspBackground.Controls.Add(this.tabCustomer);
            this.wspBackground.Controls.Add(this.txtRemarks);
            this.wspBackground.Controls.Add(this.lblRemarks);
            this.wspBackground.Controls.Add(this.cboCurrency);
            this.wspBackground.Controls.Add(this.lblCurrency);
            this.wspBackground.Controls.Add(this.lblTerms);
            this.wspBackground.Controls.Add(this.cboTerms);
            this.wspBackground.Controls.Add(this.lblRegion);
            this.wspBackground.Controls.Add(this.txtCreditLimit);
            this.wspBackground.Controls.Add(this.lblCreditLimit);
            this.wspBackground.Controls.Add(this.txtACNumber);
            this.wspBackground.Controls.Add(this.lblAccountName);
            this.wspBackground.Controls.Add(this.txtName);
            this.wspBackground.Controls.Add(this.lblName);
            this.wspBackground.Controls.Add(this.txtCustomerCode);
            this.wspBackground.Controls.Add(this.lblCode);
            this.wspBackground.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.wspBackground.DockPadding.All = 6;
            this.wspBackground.Location = new System.Drawing.Point(0, 28);
            this.wspBackground.Name = "wspBackground";
            this.wspBackground.Size = new System.Drawing.Size(627, 516);
            this.wspBackground.TabIndex = 0;
            // 
            // chkBlacklisted
            // 
            this.chkBlacklisted.Checked = false;
            this.chkBlacklisted.CheckState = Gizmox.WebGUI.Forms.CheckState.Unchecked;
            this.chkBlacklisted.FlatStyle = Gizmox.WebGUI.Forms.FlatStyle.Standard;
            this.chkBlacklisted.Location = new System.Drawing.Point(98, 266);
            this.chkBlacklisted.Name = "chkBlacklisted";
            this.chkBlacklisted.Size = new System.Drawing.Size(104, 20);
            this.chkBlacklisted.TabIndex = 25;
            this.chkBlacklisted.ThreeState = false;
            // 
            // lblBlacklisted
            // 
            this.lblBlacklisted.Location = new System.Drawing.Point(6, 266);
            this.lblBlacklisted.Name = "lblBlacklisted";
            this.lblBlacklisted.Size = new System.Drawing.Size(90, 21);
            this.lblBlacklisted.TabIndex = 24;
            this.lblBlacklisted.Text = "Blacklisted:";
            // 
            // txtProfitMargin
            // 
            this.txtProfitMargin.Location = new System.Drawing.Point(98, 241);
            this.txtProfitMargin.Name = "txtProfitMargin";
            this.txtProfitMargin.Size = new System.Drawing.Size(297, 20);
            this.txtProfitMargin.TabIndex = 23;
            // 
            // lblProfitMargin
            // 
            this.lblProfitMargin.Location = new System.Drawing.Point(6, 241);
            this.lblProfitMargin.Name = "lblProfitMargin";
            this.lblProfitMargin.Size = new System.Drawing.Size(90, 21);
            this.lblProfitMargin.TabIndex = 22;
            this.lblProfitMargin.Text = "Margin (%):";
            // 
            // cboRegion
            // 
            this.cboRegion.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.Fixed3D;
            this.cboRegion.DropDownStyle = Gizmox.WebGUI.Forms.ComboBoxStyle.DropDownList;
            this.cboRegion.Location = new System.Drawing.Point(98, 134);
            this.cboRegion.Name = "cboRegion";
            this.cboRegion.Size = new System.Drawing.Size(297, 21);
            this.cboRegion.TabIndex = 21;
            // 
            // cmdNextCustomerCode
            // 
            iconResourceHandle3.File = "16x16.lightbulb.png";
            this.cmdNextCustomerCode.Image = iconResourceHandle3;
            this.cmdNextCustomerCode.Location = new System.Drawing.Point(371, 4);
            this.cmdNextCustomerCode.Name = "cmdNextCustomerCode";
            this.cmdNextCustomerCode.Size = new System.Drawing.Size(24, 23);
            this.cmdNextCustomerCode.TabIndex = 2;
            this.cmdNextCustomerCode.TextImageRelation = Gizmox.WebGUI.Forms.TextImageRelation.ImageAboveText;
            this.cmdNextCustomerCode.Visible = false;
            this.cmdNextCustomerCode.Click += new System.EventHandler(this.cmdNextCustomerCode_Click);
            // 
            // boxLogs
            // 
            this.boxLogs.Controls.Add(this.lblModifiedOb);
            this.boxLogs.Controls.Add(this.txtModifiedOn);
            this.boxLogs.Controls.Add(this.txtModifiedBy);
            this.boxLogs.Controls.Add(this.lblModifiedBy);
            this.boxLogs.Controls.Add(this.lblCreatedBy);
            this.boxLogs.Controls.Add(this.txtCreatedBy);
            this.boxLogs.Controls.Add(this.txtCreatedOn);
            this.boxLogs.Controls.Add(this.lblCreatedOn);
            this.boxLogs.FlatStyle = Gizmox.WebGUI.Forms.FlatStyle.Flat;
            this.boxLogs.Location = new System.Drawing.Point(404, 246);
            this.boxLogs.Name = "boxLogs";
            this.boxLogs.Size = new System.Drawing.Size(214, 106);
            this.boxLogs.TabIndex = 20;
            this.boxLogs.Text = "Logs";
            this.boxLogs.Visible = false;
            // 
            // lblModifiedOb
            // 
            this.lblModifiedOb.Location = new System.Drawing.Point(7, 61);
            this.lblModifiedOb.Name = "lblModifiedOb";
            this.lblModifiedOb.Size = new System.Drawing.Size(74, 21);
            this.lblModifiedOb.TabIndex = 4;
            this.lblModifiedOb.Text = "Modified On:";
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
            // tabCustomer
            // 
            this.tabCustomer.Anchor = Gizmox.WebGUI.Forms.AnchorStyles.None;
            this.tabCustomer.Controls.Add(this.tabContact);
            this.tabCustomer.Controls.Add(this.tabAddress);
            this.tabCustomer.Dock = Gizmox.WebGUI.Forms.DockStyle.Bottom;
            this.tabCustomer.Location = new System.Drawing.Point(6, 360);
            this.tabCustomer.Multiline = false;
            this.tabCustomer.Name = "tabCustomer";
            this.tabCustomer.SelectedIndex = 0;
            this.tabCustomer.Size = new System.Drawing.Size(615, 150);
            this.tabCustomer.TabIndex = 18;
            // 
            // tabContact
            // 
            this.tabContact.Location = new System.Drawing.Point(4, 22);
            this.tabContact.Name = "tabContact";
            this.tabContact.Size = new System.Drawing.Size(607, 124);
            this.tabContact.TabIndex = 0;
            this.tabContact.Text = "Contact";
            // 
            // tabAddress
            // 
            this.tabAddress.Location = new System.Drawing.Point(4, 22);
            this.tabAddress.Name = "tabAddress";
            this.tabAddress.Size = new System.Drawing.Size(607, 124);
            this.tabAddress.TabIndex = 0;
            this.tabAddress.Text = "Address";
            // 
            // txtRemarks
            // 
            this.txtRemarks.Location = new System.Drawing.Point(98, 292);
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.ScrollBars = Gizmox.WebGUI.Forms.ScrollBars.Vertical;
            this.txtRemarks.Size = new System.Drawing.Size(297, 60);
            this.txtRemarks.TabIndex = 17;
            // 
            // lblRemarks
            // 
            this.lblRemarks.Location = new System.Drawing.Point(6, 292);
            this.lblRemarks.Name = "lblRemarks";
            this.lblRemarks.Size = new System.Drawing.Size(90, 21);
            this.lblRemarks.TabIndex = 16;
            this.lblRemarks.Text = "Remarks:";
            // 
            // cboCurrency
            // 
            this.cboCurrency.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.Fixed3D;
            this.cboCurrency.DropDownStyle = Gizmox.WebGUI.Forms.ComboBoxStyle.DropDownList;
            this.cboCurrency.Location = new System.Drawing.Point(98, 189);
            this.cboCurrency.MaxDropDownItems = 10;
            this.cboCurrency.Name = "cboCurrency";
            this.cboCurrency.Size = new System.Drawing.Size(297, 21);
            this.cboCurrency.TabIndex = 15;
            // 
            // lblCurrency
            // 
            this.lblCurrency.Location = new System.Drawing.Point(6, 189);
            this.lblCurrency.Name = "lblCurrency";
            this.lblCurrency.Size = new System.Drawing.Size(90, 21);
            this.lblCurrency.TabIndex = 14;
            this.lblCurrency.Text = "Currency:";
            // 
            // lblTerms
            // 
            this.lblTerms.Location = new System.Drawing.Point(6, 162);
            this.lblTerms.Name = "lblTerms";
            this.lblTerms.Size = new System.Drawing.Size(90, 21);
            this.lblTerms.TabIndex = 12;
            this.lblTerms.Text = "Terms:";
            // 
            // cboTerms
            // 
            this.cboTerms.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.Fixed3D;
            this.cboTerms.DropDownStyle = Gizmox.WebGUI.Forms.ComboBoxStyle.DropDownList;
            this.cboTerms.Location = new System.Drawing.Point(98, 162);
            this.cboTerms.MaxDropDownItems = 10;
            this.cboTerms.Name = "cboTerms";
            this.cboTerms.Size = new System.Drawing.Size(297, 21);
            this.cboTerms.TabIndex = 13;
            // 
            // lblRegion
            // 
            this.lblRegion.Location = new System.Drawing.Point(6, 135);
            this.lblRegion.Name = "lblRegion";
            this.lblRegion.Size = new System.Drawing.Size(90, 21);
            this.lblRegion.TabIndex = 10;
            this.lblRegion.Text = "Region:";
            // 
            // txtCreditLimit
            // 
            this.txtCreditLimit.Location = new System.Drawing.Point(98, 216);
            this.txtCreditLimit.Name = "txtCreditLimit";
            this.txtCreditLimit.Size = new System.Drawing.Size(297, 20);
            this.txtCreditLimit.TabIndex = 9;
            // 
            // lblCreditLimit
            // 
            this.lblCreditLimit.Location = new System.Drawing.Point(6, 216);
            this.lblCreditLimit.Name = "lblCreditLimit";
            this.lblCreditLimit.Size = new System.Drawing.Size(90, 21);
            this.lblCreditLimit.TabIndex = 8;
            this.lblCreditLimit.Text = "Credit Limit ($):";
            // 
            // txtACNumber
            // 
            this.txtACNumber.Location = new System.Drawing.Point(98, 109);
            this.txtACNumber.Name = "txtACNumber";
            this.txtACNumber.Size = new System.Drawing.Size(297, 20);
            this.txtACNumber.TabIndex = 7;
            // 
            // lblAccountName
            // 
            this.lblAccountName.Location = new System.Drawing.Point(6, 109);
            this.lblAccountName.Name = "lblAccountName";
            this.lblAccountName.Size = new System.Drawing.Size(90, 21);
            this.lblAccountName.TabIndex = 6;
            this.lblAccountName.Text = "A/C Number:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(98, 31);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(297, 20);
            this.txtName.TabIndex = 4;
            // 
            // lblName
            // 
            this.lblName.Location = new System.Drawing.Point(6, 31);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(90, 21);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Name:";
            // 
            // txtCustomerCode
            // 
            this.txtCustomerCode.Location = new System.Drawing.Point(98, 6);
            this.txtCustomerCode.Name = "txtCustomerCode";
            this.txtCustomerCode.Size = new System.Drawing.Size(297, 20);
            this.txtCustomerCode.TabIndex = 1;
            // 
            // lblCode
            // 
            this.lblCode.Location = new System.Drawing.Point(6, 6);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(90, 21);
            this.lblCode.TabIndex = 0;
            this.lblCode.Text = "Code:";
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
            // lblName_Chs
            // 
            this.lblName_Chs.Location = new System.Drawing.Point(6, 56);
            this.lblName_Chs.Name = "lblName_Chs";
            this.lblName_Chs.Size = new System.Drawing.Size(90, 21);
            this.lblName_Chs.TabIndex = 26;
            this.lblName_Chs.Text = "Name (Chs):";
            // 
            // lblName_Cht
            // 
            this.lblName_Cht.Location = new System.Drawing.Point(6, 83);
            this.lblName_Cht.Name = "lblName_Cht";
            this.lblName_Cht.Size = new System.Drawing.Size(90, 21);
            this.lblName_Cht.TabIndex = 27;
            this.lblName_Cht.Text = "Name (Cht):";
            // 
            // txtName_Chs
            // 
            this.txtName_Chs.Location = new System.Drawing.Point(98, 56);
            this.txtName_Chs.Name = "txtName_Chs";
            this.txtName_Chs.Size = new System.Drawing.Size(297, 20);
            this.txtName_Chs.TabIndex = 28;
            // 
            // txtName_Cht
            // 
            this.txtName_Cht.Location = new System.Drawing.Point(98, 83);
            this.txtName_Cht.Name = "txtName_Cht";
            this.txtName_Cht.Size = new System.Drawing.Size(297, 20);
            this.txtName_Cht.TabIndex = 29;
            // 
            // cmdConvertToCht
            // 
            iconResourceHandle2.File = "16x16.lightning.png";
            this.cmdConvertToCht.Image = iconResourceHandle2;
            this.cmdConvertToCht.Location = new System.Drawing.Point(72, 82);
            this.cmdConvertToCht.Name = "cmdConvertToCht";
            this.cmdConvertToCht.Size = new System.Drawing.Size(24, 23);
            this.cmdConvertToCht.TabIndex = 8;
            this.cmdConvertToCht.TabStop = false;
            this.cmdConvertToCht.TextImageRelation = Gizmox.WebGUI.Forms.TextImageRelation.ImageAboveText;
            this.cmdConvertToCht.Click += new System.EventHandler(this.cmdConvertToCht_Click);
            // 
            // cmdConvertToChs
            // 
            iconResourceHandle1.File = "16x16.lightning.png";
            this.cmdConvertToChs.Image = iconResourceHandle1;
            this.cmdConvertToChs.Location = new System.Drawing.Point(72, 56);
            this.cmdConvertToChs.Name = "cmdConvertToChs";
            this.cmdConvertToChs.Size = new System.Drawing.Size(24, 23);
            this.cmdConvertToChs.TabIndex = 5;
            this.cmdConvertToChs.TabStop = false;
            this.cmdConvertToChs.TextImageRelation = Gizmox.WebGUI.Forms.TextImageRelation.ImageAboveText;
            this.cmdConvertToChs.Click += new System.EventHandler(this.cmdConvertToChs_Click);
            // 
            // CustomerRecord
            // 
            this.Controls.Add(this.wspBackground);
            this.Controls.Add(this.ansToolbar);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Size = new System.Drawing.Size(627, 544);
            this.StartPosition = Gizmox.WebGUI.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer Record";
            this.Load += new System.EventHandler(this.ArticleRecord_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Gizmox.WebGUI.Forms.ToolBar ansToolbar;
        private Gizmox.WebGUI.Forms.Panel wspBackground;
        private Gizmox.WebGUI.Forms.TextBox txtCustomerCode;
        private Gizmox.WebGUI.Forms.Label lblCode;
        private Gizmox.WebGUI.Forms.TextBox txtCreditLimit;
        private Gizmox.WebGUI.Forms.Label lblCreditLimit;
        private Gizmox.WebGUI.Forms.TextBox txtACNumber;
        private Gizmox.WebGUI.Forms.Label lblAccountName;
        private Gizmox.WebGUI.Forms.TextBox txtName;
        private Gizmox.WebGUI.Forms.Label lblName;
        private Gizmox.WebGUI.Forms.Label lblRegion;
        private Gizmox.WebGUI.Forms.ToolTip toolTip1;
        private Gizmox.WebGUI.Forms.Label lblTerms;
        private Gizmox.WebGUI.Forms.ComboBox cboTerms;
        private Gizmox.WebGUI.Forms.TextBox txtRemarks;
        private Gizmox.WebGUI.Forms.Label lblRemarks;
        private Gizmox.WebGUI.Forms.ComboBox cboCurrency;
        private Gizmox.WebGUI.Forms.Label lblCurrency;
        private Gizmox.WebGUI.Forms.TabControl tabCustomer;
        private Gizmox.WebGUI.Forms.TabPage tabContact;
        private Gizmox.WebGUI.Forms.TabPage tabAddress;
        private Gizmox.WebGUI.Forms.ColumnHeader colDept;
        private Gizmox.WebGUI.Forms.ColumnHeader colClass;
        private Gizmox.WebGUI.Forms.ColumnHeader colCategory;
        private Gizmox.WebGUI.Forms.ColumnHeader colCategoryId;
        private Gizmox.WebGUI.Forms.GroupBox boxLogs;
        private Gizmox.WebGUI.Forms.Label lblModifiedOb;
        private Gizmox.WebGUI.Forms.Label txtModifiedOn;
        private Gizmox.WebGUI.Forms.Label txtModifiedBy;
        private Gizmox.WebGUI.Forms.Label lblModifiedBy;
        private Gizmox.WebGUI.Forms.Label lblCreatedBy;
        private Gizmox.WebGUI.Forms.Label txtCreatedBy;
        private Gizmox.WebGUI.Forms.Label txtCreatedOn;
        private Gizmox.WebGUI.Forms.Label lblCreatedOn;
        private Gizmox.WebGUI.Forms.Button cmdNextCustomerCode;
        private Gizmox.WebGUI.Forms.ComboBox cboRegion;
        private Gizmox.WebGUI.Forms.CheckBox chkBlacklisted;
        private Gizmox.WebGUI.Forms.Label lblBlacklisted;
        private Gizmox.WebGUI.Forms.TextBox txtProfitMargin;
        private Gizmox.WebGUI.Forms.Label lblProfitMargin;
        private Gizmox.WebGUI.Forms.TextBox txtName_Cht;
        private Gizmox.WebGUI.Forms.TextBox txtName_Chs;
        private Gizmox.WebGUI.Forms.Label lblName_Cht;
        private Gizmox.WebGUI.Forms.Label lblName_Chs;
        private Gizmox.WebGUI.Forms.Button cmdConvertToCht;
        private Gizmox.WebGUI.Forms.Button cmdConvertToChs;


    }
}