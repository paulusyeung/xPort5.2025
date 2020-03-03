namespace xPort5.Order.PreOrder
{
    partial class GenerateOrder
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
            Gizmox.WebGUI.Common.Resources.IconResourceHandle iconResourceHandle5 = new Gizmox.WebGUI.Common.Resources.IconResourceHandle();
            Gizmox.WebGUI.Common.Resources.IconResourceHandle iconResourceHandle6 = new Gizmox.WebGUI.Common.Resources.IconResourceHandle();
            this.lblSalesContractNumber = new Gizmox.WebGUI.Forms.Label();
            this.cmdNextContractNumber = new Gizmox.WebGUI.Forms.Button();
            this.txtSalesContractNumber = new Gizmox.WebGUI.Forms.TextBox();
            this.boxCustomerInfo = new Gizmox.WebGUI.Forms.GroupBox();
            this.txtCustomerName = new Gizmox.WebGUI.Forms.TextBox();
            this.lblCustomerName = new Gizmox.WebGUI.Forms.Label();
            this.boxSupplierInfo = new Gizmox.WebGUI.Forms.GroupBox();
            this.lvwSupplierList = new Gizmox.WebGUI.Forms.ListView();
            this.colSupplierId = new Gizmox.WebGUI.Forms.ColumnHeader();
            this.colSupplierCode = new Gizmox.WebGUI.Forms.ColumnHeader();
            this.colSupplierName = new Gizmox.WebGUI.Forms.ColumnHeader();
            this.colContractNumber = new Gizmox.WebGUI.Forms.ColumnHeader();
            this.btnOK = new Gizmox.WebGUI.Forms.Button();
            this.btnClear = new Gizmox.WebGUI.Forms.Button();
            this.toolTip1 = new Gizmox.WebGUI.Forms.ToolTip(this.components);
            this.cmdFillPONumber = new Gizmox.WebGUI.Forms.Button();
            this.txtPurchaseContractNumber = new Gizmox.WebGUI.Forms.TextBox();
            this.lblPurchaseContractNumber = new Gizmox.WebGUI.Forms.Label();
            this.SuspendLayout();
            // 
            // lblSalesContractNumber
            // 
            this.lblSalesContractNumber.Location = new System.Drawing.Point(24, 16);
            this.lblSalesContractNumber.Name = "lblSalesContractNumber";
            this.lblSalesContractNumber.Size = new System.Drawing.Size(122, 21);
            this.lblSalesContractNumber.TabIndex = 0;
            this.lblSalesContractNumber.TabStop = false;
            this.lblSalesContractNumber.Text = "Sales Contract No.:";
            // 
            // cmdNextContractNumber
            // 
            iconResourceHandle5.File = "16x16.lightbulb.png";
            this.cmdNextContractNumber.Image = iconResourceHandle5;
            this.cmdNextContractNumber.Location = new System.Drawing.Point(325, 11);
            this.cmdNextContractNumber.Name = "cmdNextContractNumber";
            this.cmdNextContractNumber.Size = new System.Drawing.Size(24, 23);
            this.cmdNextContractNumber.TabIndex = 2;
            this.cmdNextContractNumber.TabStop = false;
            this.cmdNextContractNumber.TextImageRelation = Gizmox.WebGUI.Forms.TextImageRelation.ImageAboveText;
            this.cmdNextContractNumber.Click += new System.EventHandler(this.cmdNextContractNumber_Click);
            // 
            // txtSalesContractNumber
            // 
            this.txtSalesContractNumber.Location = new System.Drawing.Point(152, 13);
            this.txtSalesContractNumber.Name = "txtSalesContractNumber";
            this.txtSalesContractNumber.Size = new System.Drawing.Size(167, 20);
            this.txtSalesContractNumber.TabIndex = 1;
            this.txtSalesContractNumber.Enter += new System.EventHandler(this.txtSalesContractNumber_Enter);
            this.txtSalesContractNumber.TextChanged += new System.EventHandler(this.txtSalesContractNumber_TextChanged);
            // 
            // boxCustomerInfo
            // 
            this.boxCustomerInfo.Controls.Add(this.txtCustomerName);
            this.boxCustomerInfo.Controls.Add(this.lblCustomerName);
            this.boxCustomerInfo.FlatStyle = Gizmox.WebGUI.Forms.FlatStyle.Flat;
            this.boxCustomerInfo.Location = new System.Drawing.Point(16, 73);
            this.boxCustomerInfo.Name = "boxCustomerInfo";
            this.boxCustomerInfo.Size = new System.Drawing.Size(470, 74);
            this.boxCustomerInfo.TabIndex = 6;
            this.boxCustomerInfo.TabStop = false;
            this.boxCustomerInfo.Text = "Customer Info.";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(136, 29);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(315, 20);
            this.txtCustomerName.TabIndex = 1;
            this.txtCustomerName.TabStop = false;
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.Location = new System.Drawing.Point(12, 32);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(122, 23);
            this.lblCustomerName.TabIndex = 0;
            this.lblCustomerName.TabStop = false;
            this.lblCustomerName.Text = "Customer Name:";
            // 
            // boxSupplierInfo
            // 
            this.boxSupplierInfo.Controls.Add(this.lvwSupplierList);
            this.boxSupplierInfo.FlatStyle = Gizmox.WebGUI.Forms.FlatStyle.Flat;
            this.boxSupplierInfo.Location = new System.Drawing.Point(16, 153);
            this.boxSupplierInfo.Name = "boxSupplierInfo";
            this.boxSupplierInfo.Size = new System.Drawing.Size(470, 291);
            this.boxSupplierInfo.TabIndex = 7;
            this.boxSupplierInfo.TabStop = false;
            this.boxSupplierInfo.Text = "Supplier Info.";
            // 
            // lvwSupplierList
            // 
            this.lvwSupplierList.Anchor = Gizmox.WebGUI.Forms.AnchorStyles.None;
            this.lvwSupplierList.Columns.AddRange(new Gizmox.WebGUI.Forms.ColumnHeader[] {
            this.colSupplierId,
            this.colSupplierCode,
            this.colSupplierName,
            this.colContractNumber});
            this.lvwSupplierList.DataMember = null;
            this.lvwSupplierList.ItemsPerPage = 20;
            this.lvwSupplierList.Location = new System.Drawing.Point(11, 20);
            this.lvwSupplierList.Name = "lvwSupplierList";
            this.lvwSupplierList.Size = new System.Drawing.Size(440, 253);
            this.lvwSupplierList.TabIndex = 0;
            this.lvwSupplierList.TabStop = false;
            this.lvwSupplierList.DoubleClick += new System.EventHandler(this.lvwSupplierList_DoubleClick);
            // 
            // colSupplierId
            // 
            this.colSupplierId.Image = null;
            this.colSupplierId.Text = "";
            this.colSupplierId.Visible = false;
            this.colSupplierId.Width = 150;
            // 
            // colSupplierCode
            // 
            this.colSupplierCode.Image = null;
            this.colSupplierCode.Text = "Code";
            this.colSupplierCode.Width = 80;
            // 
            // colSupplierName
            // 
            this.colSupplierName.Image = null;
            this.colSupplierName.Text = "Name";
            this.colSupplierName.Width = 230;
            // 
            // colContractNumber
            // 
            this.colContractNumber.Image = null;
            this.colContractNumber.Text = "Contract No.";
            this.colContractNumber.Width = 100;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(529, 73);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 8;
            this.btnOK.Text = "OK";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(529, 114);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Clear";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // cmdFillPONumber
            // 
            iconResourceHandle6.File = "16x16.lightning.png";
            this.cmdFillPONumber.Image = iconResourceHandle6;
            this.cmdFillPONumber.Location = new System.Drawing.Point(325, 41);
            this.cmdFillPONumber.Name = "cmdFillPONumber";
            this.cmdFillPONumber.Size = new System.Drawing.Size(24, 23);
            this.cmdFillPONumber.TabIndex = 5;
            this.cmdFillPONumber.TabStop = false;
            this.cmdFillPONumber.TextImageRelation = Gizmox.WebGUI.Forms.TextImageRelation.ImageAboveText;
            this.cmdFillPONumber.Click += new System.EventHandler(this.cmdFillPONumber_Click);
            // 
            // txtPurchaseContractNumber
            // 
            this.txtPurchaseContractNumber.Location = new System.Drawing.Point(152, 43);
            this.txtPurchaseContractNumber.Name = "txtPurchaseContractNumber";
            this.txtPurchaseContractNumber.Size = new System.Drawing.Size(167, 20);
            this.txtPurchaseContractNumber.TabIndex = 4;
            this.txtPurchaseContractNumber.Enter += new System.EventHandler(this.txtPurchaseContractNumber_Enter);
            this.txtPurchaseContractNumber.TextChanged += new System.EventHandler(this.txtPurchaseContractNumber_TextChanged);
            // 
            // lblPurchaseContractNumber
            // 
            this.lblPurchaseContractNumber.Location = new System.Drawing.Point(24, 46);
            this.lblPurchaseContractNumber.Name = "lblPurchaseContractNumber";
            this.lblPurchaseContractNumber.Size = new System.Drawing.Size(122, 21);
            this.lblPurchaseContractNumber.TabIndex = 3;
            this.lblPurchaseContractNumber.TabStop = false;
            this.lblPurchaseContractNumber.Text = "Purchase Contract No.:";
            // 
            // GenerateOrder
            // 
            this.Controls.Add(this.lblPurchaseContractNumber);
            this.Controls.Add(this.txtPurchaseContractNumber);
            this.Controls.Add(this.cmdFillPONumber);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.boxSupplierInfo);
            this.Controls.Add(this.boxCustomerInfo);
            this.Controls.Add(this.txtSalesContractNumber);
            this.Controls.Add(this.cmdNextContractNumber);
            this.Controls.Add(this.lblSalesContractNumber);
            this.FormBorderStyle = Gizmox.WebGUI.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Size = new System.Drawing.Size(638, 456);
            this.Text = "GenerateOrder";
            this.ResumeLayout(false);

        }

        #endregion

        private Gizmox.WebGUI.Forms.Label lblSalesContractNumber;
        private Gizmox.WebGUI.Forms.Button cmdNextContractNumber;
        private Gizmox.WebGUI.Forms.TextBox txtSalesContractNumber;
        private Gizmox.WebGUI.Forms.GroupBox boxCustomerInfo;
        private Gizmox.WebGUI.Forms.GroupBox boxSupplierInfo;
        private Gizmox.WebGUI.Forms.TextBox txtCustomerName;
        private Gizmox.WebGUI.Forms.Label lblCustomerName;
        private Gizmox.WebGUI.Forms.Button btnOK;
        private Gizmox.WebGUI.Forms.Button btnClear;
        private Gizmox.WebGUI.Forms.ListView lvwSupplierList;
        private Gizmox.WebGUI.Forms.ColumnHeader colSupplierId;
        private Gizmox.WebGUI.Forms.ColumnHeader colSupplierCode;
        private Gizmox.WebGUI.Forms.ColumnHeader colSupplierName;
        private Gizmox.WebGUI.Forms.ColumnHeader colContractNumber;
        private Gizmox.WebGUI.Forms.ToolTip toolTip1;
        private Gizmox.WebGUI.Forms.Button cmdFillPONumber;
        private Gizmox.WebGUI.Forms.TextBox txtPurchaseContractNumber;
        private Gizmox.WebGUI.Forms.Label lblPurchaseContractNumber;


    }
}