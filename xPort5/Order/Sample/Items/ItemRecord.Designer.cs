namespace xPort5.Order.Sample.Items
{
    partial class ItemRecord
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
            this.ansToolbar = new Gizmox.WebGUI.Forms.ToolBar();
            this.lblLineNumber = new Gizmox.WebGUI.Forms.Label();
            this.txtLineNumber = new Gizmox.WebGUI.Forms.TextBox();
            this.txtArticleCode = new Gizmox.WebGUI.Forms.TextBox();
            this.lblArticleCode = new Gizmox.WebGUI.Forms.Label();
            this.txtQty = new Gizmox.WebGUI.Forms.TextBox();
            this.lblQty = new Gizmox.WebGUI.Forms.Label();
            this.lblUoM = new Gizmox.WebGUI.Forms.Label();
            this.cboUoM = new Gizmox.WebGUI.Forms.ComboBox();
            this.lvwItems = new Gizmox.WebGUI.Forms.ListView();
            this.colQuotedDate = new Gizmox.WebGUI.Forms.ColumnHeader();
            this.colQTNumber = new Gizmox.WebGUI.Forms.ColumnHeader();
            this.colSupplierCode = new Gizmox.WebGUI.Forms.ColumnHeader();
            this.colSupplierName = new Gizmox.WebGUI.Forms.ColumnHeader();
            this.colPackageCode = new Gizmox.WebGUI.Forms.ColumnHeader();
            this.colPackageName = new Gizmox.WebGUI.Forms.ColumnHeader();
            this.colOutStandingSample = new Gizmox.WebGUI.Forms.ColumnHeader();
            this.colOrderQTItemId = new Gizmox.WebGUI.Forms.ColumnHeader();
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
            this.ansToolbar.TabIndex = 0;
            // 
            // lblLineNumber
            // 
            this.lblLineNumber.Location = new System.Drawing.Point(14, 43);
            this.lblLineNumber.Name = "lblLineNumber";
            this.lblLineNumber.Size = new System.Drawing.Size(100, 23);
            this.lblLineNumber.TabIndex = 1;
            this.lblLineNumber.Text = "Line Number:";
            // 
            // txtLineNumber
            // 
            this.txtLineNumber.Location = new System.Drawing.Point(120, 40);
            this.txtLineNumber.Name = "txtLineNumber";
            this.txtLineNumber.Size = new System.Drawing.Size(100, 20);
            this.txtLineNumber.TabIndex = 2;
            // 
            // txtArticleCode
            // 
            this.txtArticleCode.Location = new System.Drawing.Point(120, 66);
            this.txtArticleCode.Name = "txtArticleCode";
            this.txtArticleCode.Size = new System.Drawing.Size(147, 20);
            this.txtArticleCode.TabIndex = 2;
            this.txtArticleCode.TextChanged += new System.EventHandler(this.txtArticleCode_TextChanged);
            // 
            // lblArticleCode
            // 
            this.lblArticleCode.Location = new System.Drawing.Point(14, 69);
            this.lblArticleCode.Name = "lblArticleCode";
            this.lblArticleCode.Size = new System.Drawing.Size(100, 23);
            this.lblArticleCode.TabIndex = 1;
            this.lblArticleCode.Text = "Article Code:";
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(120, 92);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(100, 20);
            this.txtQty.TabIndex = 2;
            this.txtQty.Text = "0.00";
            this.txtQty.TextAlign = Gizmox.WebGUI.Forms.HorizontalAlignment.Right;
            this.txtQty.TextChanged += new System.EventHandler(this.txtQty_TextChanged);
            // 
            // lblQty
            // 
            this.lblQty.Location = new System.Drawing.Point(14, 95);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(100, 23);
            this.lblQty.TabIndex = 1;
            this.lblQty.Text = "Qty:";
            // 
            // lblUoM
            // 
            this.lblUoM.Location = new System.Drawing.Point(14, 121);
            this.lblUoM.Name = "lblUoM";
            this.lblUoM.Size = new System.Drawing.Size(100, 23);
            this.lblUoM.TabIndex = 3;
            this.lblUoM.Text = "Unit:";
            // 
            // cboUoM
            // 
            this.cboUoM.Location = new System.Drawing.Point(120, 118);
            this.cboUoM.Name = "cboUoM";
            this.cboUoM.Size = new System.Drawing.Size(121, 21);
            this.cboUoM.TabIndex = 4;
            // 
            // lvwItems
            // 
            this.lvwItems.Columns.AddRange(new Gizmox.WebGUI.Forms.ColumnHeader[] {
            this.colOrderQTItemId,
            this.colQuotedDate,
            this.colQTNumber,
            this.colSupplierCode,
            this.colSupplierName,
            this.colPackageCode,
            this.colPackageName,
            this.colOutStandingSample});
            this.lvwItems.DataMember = null;
            this.lvwItems.ItemsPerPage = 20;
            this.lvwItems.Location = new System.Drawing.Point(12, 162);
            this.lvwItems.Name = "lvwItems";
            this.lvwItems.Size = new System.Drawing.Size(395, 209);
            this.lvwItems.TabIndex = 5;
            // 
            // colQuotedDate
            // 
            this.colQuotedDate.Image = null;
            this.colQuotedDate.Text = "Quoted Date";
            this.colQuotedDate.Width = 80;
            // 
            // colQTNumber
            // 
            this.colQTNumber.Image = null;
            this.colQTNumber.Text = "Quotation Number";
            this.colQTNumber.Width = 80;
            // 
            // colSupplierCode
            // 
            this.colSupplierCode.Image = null;
            this.colSupplierCode.Text = "Supplier Code";
            this.colSupplierCode.Width = 80;
            // 
            // colSupplierName
            // 
            this.colSupplierName.Image = null;
            this.colSupplierName.Text = "Supplier Name";
            this.colSupplierName.Width = 120;
            // 
            // colPackageCode
            // 
            this.colPackageCode.Image = null;
            this.colPackageCode.Text = "Package Code";
            this.colPackageCode.Width = 80;
            // 
            // colPackageName
            // 
            this.colPackageName.Image = null;
            this.colPackageName.Text = "Package Name";
            this.colPackageName.Width = 120;
            // 
            // colOutStandingSample
            // 
            this.colOutStandingSample.Image = null;
            this.colOutStandingSample.Text = "Sample O/S";
            this.colOutStandingSample.TextAlign = Gizmox.WebGUI.Forms.HorizontalAlignment.Right;
            this.colOutStandingSample.Width = 80;
            // 
            // colOrderQTItemId
            // 
            this.colOrderQTItemId.Image = null;
            this.colOrderQTItemId.Text = "";
            this.colOrderQTItemId.Visible = false;
            this.colOrderQTItemId.Width = 150;
            // 
            // ItemRecord
            // 
            this.Controls.Add(this.lvwItems);
            this.Controls.Add(this.cboUoM);
            this.Controls.Add(this.lblUoM);
            this.Controls.Add(this.lblQty);
            this.Controls.Add(this.txtQty);
            this.Controls.Add(this.lblArticleCode);
            this.Controls.Add(this.txtArticleCode);
            this.Controls.Add(this.txtLineNumber);
            this.Controls.Add(this.lblLineNumber);
            this.Controls.Add(this.ansToolbar);
            this.FormBorderStyle = Gizmox.WebGUI.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Size = new System.Drawing.Size(419, 383);
            this.Text = "ItemRecord";
            this.ResumeLayout(false);

        }

        #endregion

        private Gizmox.WebGUI.Forms.ToolBar ansToolbar;
        private Gizmox.WebGUI.Forms.Label lblLineNumber;
        private Gizmox.WebGUI.Forms.TextBox txtLineNumber;
        private Gizmox.WebGUI.Forms.TextBox txtArticleCode;
        private Gizmox.WebGUI.Forms.Label lblArticleCode;
        private Gizmox.WebGUI.Forms.TextBox txtQty;
        private Gizmox.WebGUI.Forms.Label lblQty;
        private Gizmox.WebGUI.Forms.Label lblUoM;
        private Gizmox.WebGUI.Forms.ComboBox cboUoM;
        private Gizmox.WebGUI.Forms.ListView lvwItems;
        private Gizmox.WebGUI.Forms.ColumnHeader colQuotedDate;
        private Gizmox.WebGUI.Forms.ColumnHeader colQTNumber;
        private Gizmox.WebGUI.Forms.ColumnHeader colSupplierCode;
        private Gizmox.WebGUI.Forms.ColumnHeader colPackageCode;
        private Gizmox.WebGUI.Forms.ColumnHeader colSupplierName;
        private Gizmox.WebGUI.Forms.ColumnHeader colPackageName;
        private Gizmox.WebGUI.Forms.ColumnHeader colOutStandingSample;
        private Gizmox.WebGUI.Forms.ColumnHeader colOrderQTItemId;


    }
}