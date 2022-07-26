namespace xPort5.Controls.Product
{
    partial class FindProduct
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
            this.lblColor = new Gizmox.WebGUI.Forms.Label();
            this.txtColor = new Gizmox.WebGUI.Forms.TextBox();
            this.btnSearch = new Gizmox.WebGUI.Forms.Button();
            this.resultPane = new Gizmox.WebGUI.Forms.Panel();
            this.lvResultList = new Gizmox.WebGUI.Forms.ListView();
            this.colProductId = ((Gizmox.WebGUI.Forms.ColumnHeader)(new Gizmox.WebGUI.Forms.ColumnHeader()));
            this.colProductCode = ((Gizmox.WebGUI.Forms.ColumnHeader)(new Gizmox.WebGUI.Forms.ColumnHeader()));
            this.colColor = ((Gizmox.WebGUI.Forms.ColumnHeader)(new Gizmox.WebGUI.Forms.ColumnHeader()));
            this.colSupplierCode = ((Gizmox.WebGUI.Forms.ColumnHeader)(new Gizmox.WebGUI.Forms.ColumnHeader()));
            this.colPackageCode = ((Gizmox.WebGUI.Forms.ColumnHeader)(new Gizmox.WebGUI.Forms.ColumnHeader()));
            this.colProductName = ((Gizmox.WebGUI.Forms.ColumnHeader)(new Gizmox.WebGUI.Forms.ColumnHeader()));
            this.colSupplierName = ((Gizmox.WebGUI.Forms.ColumnHeader)(new Gizmox.WebGUI.Forms.ColumnHeader()));
            this.colSupplierRef = ((Gizmox.WebGUI.Forms.ColumnHeader)(new Gizmox.WebGUI.Forms.ColumnHeader()));
            this.colPackageName = ((Gizmox.WebGUI.Forms.ColumnHeader)(new Gizmox.WebGUI.Forms.ColumnHeader()));
            this.txtProductCode = new Gizmox.WebGUI.Forms.TextBox();
            this.lblProductCode = new Gizmox.WebGUI.Forms.Label();
            this.toolTip1 = new Gizmox.WebGUI.Forms.ToolTip();
            this.colUnit = ((Gizmox.WebGUI.Forms.ColumnHeader)(new Gizmox.WebGUI.Forms.ColumnHeader()));
            this.colInnerBox = ((Gizmox.WebGUI.Forms.ColumnHeader)(new Gizmox.WebGUI.Forms.ColumnHeader()));
            this.colOuterBox = ((Gizmox.WebGUI.Forms.ColumnHeader)(new Gizmox.WebGUI.Forms.ColumnHeader()));
            this.colCUFT = ((Gizmox.WebGUI.Forms.ColumnHeader)(new Gizmox.WebGUI.Forms.ColumnHeader()));
            this.resultPane.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Location = new System.Drawing.Point(20, 50);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(100, 23);
            this.lblColor.TabIndex = 2;
            this.lblColor.Text = "Color:";
            // 
            // txtColor
            // 
            this.txtColor.Location = new System.Drawing.Point(102, 47);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(148, 20);
            this.txtColor.TabIndex = 3;
            this.txtColor.KeyDown += new Gizmox.WebGUI.Forms.KeyEventHandler(this.txtColor_KeyDown);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(256, 45);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Search";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // resultPane
            // 
            this.resultPane.Controls.Add(this.lvResultList);
            this.resultPane.Dock = Gizmox.WebGUI.Forms.DockStyle.Bottom;
            this.resultPane.DockPadding.All = 3;
            this.resultPane.Location = new System.Drawing.Point(0, 87);
            this.resultPane.Name = "resultPane";
            this.resultPane.Padding = new Gizmox.WebGUI.Forms.Padding(3);
            this.resultPane.Size = new System.Drawing.Size(720, 426);
            this.resultPane.TabIndex = 5;
            // 
            // lvResultList
            // 
            this.lvResultList.Columns.AddRange(new Gizmox.WebGUI.Forms.ColumnHeader[] {
            this.colProductId,
            this.colProductCode,
            this.colColor,
            this.colSupplierCode,
            this.colPackageCode,
            this.colProductName,
            this.colSupplierName,
            this.colSupplierRef,
            this.colPackageName,
            this.colUnit,
            this.colInnerBox,
            this.colOuterBox,
            this.colCUFT});
            this.lvResultList.DataMember = null;
            this.lvResultList.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.lvResultList.Location = new System.Drawing.Point(3, 3);
            this.lvResultList.Name = "lvResultList";
            this.lvResultList.Size = new System.Drawing.Size(714, 420);
            this.lvResultList.TabIndex = 0;
            this.lvResultList.DoubleClick += new System.EventHandler(this.lvResultList_DoubleClick);
            // 
            // colProductId
            // 
            this.colProductId.Text = "";
            this.colProductId.Visible = false;
            this.colProductId.Width = 10;
            // 
            // colProductCode
            // 
            this.colProductCode.Text = "Product Code";
            this.colProductCode.Width = 80;
            // 
            // colColor
            // 
            this.colColor.Text = "Color";
            this.colColor.Width = 80;
            // 
            // colSupplierCode
            // 
            this.colSupplierCode.Text = "SupplierCode";
            this.colSupplierCode.Width = 80;
            // 
            // colPackageCode
            // 
            this.colPackageCode.Text = "Package Code";
            this.colPackageCode.Width = 80;
            // 
            // colProductName
            // 
            this.colProductName.Text = "ProdcutName";
            this.colProductName.Width = 80;
            // 
            // colSupplierName
            // 
            this.colSupplierName.Text = "Supplier Name";
            this.colSupplierName.Width = 80;
            // 
            // colSupplierRef
            // 
            this.colSupplierRef.Text = "Supplier Ref.";
            this.colSupplierRef.Width = 80;
            // 
            // colPackageName
            // 
            this.colPackageName.Text = "Package Name";
            this.colPackageName.Width = 80;
            // 
            // txtProductCode
            // 
            this.txtProductCode.Location = new System.Drawing.Point(102, 21);
            this.txtProductCode.Name = "txtProductCode";
            this.txtProductCode.Size = new System.Drawing.Size(148, 20);
            this.txtProductCode.TabIndex = 3;
            // 
            // lblProductCode
            // 
            this.lblProductCode.AutoSize = true;
            this.lblProductCode.Location = new System.Drawing.Point(20, 24);
            this.lblProductCode.Name = "lblProductCode";
            this.lblProductCode.Size = new System.Drawing.Size(100, 23);
            this.lblProductCode.TabIndex = 2;
            this.lblProductCode.Text = "Product Code:";
            // 
            // colUnit
            // 
            this.colUnit.ContentAlign = Gizmox.WebGUI.Forms.ExtendedHorizontalAlignment.Center;
            this.colUnit.Text = "Unit";
            this.colUnit.TextAlign = Gizmox.WebGUI.Forms.HorizontalAlignment.Center;
            this.colUnit.Width = 40;
            // 
            // colInnerBox
            // 
            this.colInnerBox.ContentAlign = Gizmox.WebGUI.Forms.ExtendedHorizontalAlignment.Center;
            this.colInnerBox.Text = "Inner Box";
            this.colInnerBox.TextAlign = Gizmox.WebGUI.Forms.HorizontalAlignment.Right;
            this.colInnerBox.Width = 80;
            // 
            // colOuterBox
            // 
            this.colOuterBox.ContentAlign = Gizmox.WebGUI.Forms.ExtendedHorizontalAlignment.Center;
            this.colOuterBox.Text = "Outer Box";
            this.colOuterBox.TextAlign = Gizmox.WebGUI.Forms.HorizontalAlignment.Right;
            this.colOuterBox.Width = 80;
            // 
            // colCUFT
            // 
            this.colCUFT.ContentAlign = Gizmox.WebGUI.Forms.ExtendedHorizontalAlignment.Center;
            this.colCUFT.Text = "CUFT";
            this.colCUFT.TextAlign = Gizmox.WebGUI.Forms.HorizontalAlignment.Right;
            this.colCUFT.Width = 80;
            // 
            // FindProduct
            // 
            this.Controls.Add(this.lblProductCode);
            this.Controls.Add(this.txtProductCode);
            this.Controls.Add(this.resultPane);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtColor);
            this.Controls.Add(this.lblColor);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Size = new System.Drawing.Size(720, 513);
            this.Text = "FindProduct";
            this.resultPane.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Gizmox.WebGUI.Forms.Label lblColor;
        private Gizmox.WebGUI.Forms.TextBox txtColor;
        private Gizmox.WebGUI.Forms.Button btnSearch;
        private Gizmox.WebGUI.Forms.Panel resultPane;
        private Gizmox.WebGUI.Forms.ListView lvResultList;
        private Gizmox.WebGUI.Forms.ColumnHeader colProductId;
        private Gizmox.WebGUI.Forms.ColumnHeader colProductCode;
        private Gizmox.WebGUI.Forms.ColumnHeader colSupplierCode;
        private Gizmox.WebGUI.Forms.ColumnHeader colPackageCode;
        private Gizmox.WebGUI.Forms.ColumnHeader colProductName;
        private Gizmox.WebGUI.Forms.ColumnHeader colSupplierName;
        private Gizmox.WebGUI.Forms.ColumnHeader colSupplierRef;
        private Gizmox.WebGUI.Forms.ColumnHeader colPackageName;
        private Gizmox.WebGUI.Forms.ColumnHeader colColor;
        private Gizmox.WebGUI.Forms.TextBox txtProductCode;
        private Gizmox.WebGUI.Forms.Label lblProductCode;
        private Gizmox.WebGUI.Forms.ToolTip toolTip1;
        private Gizmox.WebGUI.Forms.ColumnHeader colUnit;
        private Gizmox.WebGUI.Forms.ColumnHeader colInnerBox;
        private Gizmox.WebGUI.Forms.ColumnHeader colOuterBox;
        private Gizmox.WebGUI.Forms.ColumnHeader colCUFT;
    }
}