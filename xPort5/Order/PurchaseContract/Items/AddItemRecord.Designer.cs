namespace xPort5.Order.PurchaseContract.Items
{
    partial class AddItemRecord
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
            Gizmox.WebGUI.Common.Resources.IconResourceHandle iconResourceHandle1 = new Gizmox.WebGUI.Common.Resources.IconResourceHandle();
            this.lblSCNumber = new Gizmox.WebGUI.Forms.Label();
            this.txtSCNumber = new Gizmox.WebGUI.Forms.TextBox();
            this.btnLookForSCNumber = new Gizmox.WebGUI.Forms.Button();
            this.lvItemList = new Gizmox.WebGUI.Forms.ListView();
            this.colOrderPLItemsId = new Gizmox.WebGUI.Forms.ColumnHeader();
            this.colLineNumber = new Gizmox.WebGUI.Forms.ColumnHeader();
            this.colArticleCode = new Gizmox.WebGUI.Forms.ColumnHeader();
            this.colSupplier = new Gizmox.WebGUI.Forms.ColumnHeader();
            this.colPackage = new Gizmox.WebGUI.Forms.ColumnHeader();
            this.colColor = new Gizmox.WebGUI.Forms.ColumnHeader();
            this.colCustRef = new Gizmox.WebGUI.Forms.ColumnHeader();
            this.colResult = new Gizmox.WebGUI.Forms.ColumnHeader();
            this.btnOK = new Gizmox.WebGUI.Forms.Button();
            this.btnClear = new Gizmox.WebGUI.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSCNumber
            // 
            this.lblSCNumber.Location = new System.Drawing.Point(26, 21);
            this.lblSCNumber.Name = "lblSCNumber";
            this.lblSCNumber.Size = new System.Drawing.Size(123, 23);
            this.lblSCNumber.TabIndex = 0;
            this.lblSCNumber.Text = "Sales Contract No.:";
            // 
            // txtSCNumber
            // 
            this.txtSCNumber.Location = new System.Drawing.Point(155, 18);
            this.txtSCNumber.Name = "txtSCNumber";
            this.txtSCNumber.Size = new System.Drawing.Size(181, 20);
            this.txtSCNumber.TabIndex = 1;
            this.txtSCNumber.EnterKeyDown += new Gizmox.WebGUI.Forms.KeyEventHandler(this.txtSCNumber_EnterKeyDown);
            // 
            // btnLookForSCNumber
            // 
            iconResourceHandle1.File = "16x16.16_find.gif";
            this.btnLookForSCNumber.Image = iconResourceHandle1;
            this.btnLookForSCNumber.Location = new System.Drawing.Point(342, 16);
            this.btnLookForSCNumber.Name = "btnLookForSCNumber";
            this.btnLookForSCNumber.Size = new System.Drawing.Size(25, 23);
            this.btnLookForSCNumber.TabIndex = 2;
            this.btnLookForSCNumber.TextImageRelation = Gizmox.WebGUI.Forms.TextImageRelation.ImageAboveText;
            this.btnLookForSCNumber.Click += new System.EventHandler(this.btnLookForSCNumber_Click);
            // 
            // lvItemList
            // 
            this.lvItemList.CheckBoxes = true;
            this.lvItemList.Columns.AddRange(new Gizmox.WebGUI.Forms.ColumnHeader[] {
            this.colOrderPLItemsId,
            this.colLineNumber,
            this.colArticleCode,
            this.colSupplier,
            this.colPackage,
            this.colColor,
            this.colCustRef,
            this.colResult});
            this.lvItemList.DataMember = null;
            this.lvItemList.ItemsPerPage = 20;
            this.lvItemList.Location = new System.Drawing.Point(12, 47);
            this.lvItemList.Name = "lvItemList";
            this.lvItemList.Size = new System.Drawing.Size(404, 407);
            this.lvItemList.TabIndex = 3;
            // 
            // colOrderPLItemsId
            // 
            this.colOrderPLItemsId.Image = null;
            this.colOrderPLItemsId.Text = "ItemId";
            this.colOrderPLItemsId.Visible = false;
            this.colOrderPLItemsId.Width = 150;
            // 
            // colLineNumber
            // 
            this.colLineNumber.Image = null;
            this.colLineNumber.Text = "#";
            this.colLineNumber.TextAlign = Gizmox.WebGUI.Forms.HorizontalAlignment.Center;
            this.colLineNumber.Width = 30;
            // 
            // colArticleCode
            // 
            this.colArticleCode.Image = null;
            this.colArticleCode.Text = "Article Code";
            this.colArticleCode.Width = 80;
            // 
            // colSupplier
            // 
            this.colSupplier.Image = null;
            this.colSupplier.Text = "Supplier";
            this.colSupplier.Width = 100;
            // 
            // colPackage
            // 
            this.colPackage.Image = null;
            this.colPackage.Text = "Package";
            this.colPackage.Width = 100;
            // 
            // colColor
            // 
            this.colColor.Image = null;
            this.colColor.Text = "Color";
            this.colColor.Width = 100;
            // 
            // colCustRef
            // 
            this.colCustRef.Image = null;
            this.colCustRef.Text = "Cust. Ref";
            this.colCustRef.Width = 100;
            // 
            // colResult
            // 
            this.colResult.Image = null;
            this.colResult.Text = "Result";
            this.colResult.Width = 150;
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = Gizmox.WebGUI.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(433, 47);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "OK";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(433, 76);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // AddItemRecord
            // 
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lvItemList);
            this.Controls.Add(this.btnLookForSCNumber);
            this.Controls.Add(this.txtSCNumber);
            this.Controls.Add(this.lblSCNumber);
            this.FormBorderStyle = Gizmox.WebGUI.Forms.FormBorderStyle.FixedDialog;
            this.Size = new System.Drawing.Size(521, 466);
            this.Text = "Add Item Record";
            this.ResumeLayout(false);

        }

        #endregion

        private Gizmox.WebGUI.Forms.Label lblSCNumber;
        private Gizmox.WebGUI.Forms.TextBox txtSCNumber;
        private Gizmox.WebGUI.Forms.Button btnLookForSCNumber;
        private Gizmox.WebGUI.Forms.ListView lvItemList;
        private Gizmox.WebGUI.Forms.Button btnOK;
        private Gizmox.WebGUI.Forms.Button btnClear;
        private Gizmox.WebGUI.Forms.ColumnHeader colOrderPLItemsId;
        private Gizmox.WebGUI.Forms.ColumnHeader colLineNumber;
        private Gizmox.WebGUI.Forms.ColumnHeader colArticleCode;
        private Gizmox.WebGUI.Forms.ColumnHeader colSupplier;
        private Gizmox.WebGUI.Forms.ColumnHeader colPackage;
        private Gizmox.WebGUI.Forms.ColumnHeader colColor;
        private Gizmox.WebGUI.Forms.ColumnHeader colCustRef;
        private Gizmox.WebGUI.Forms.ColumnHeader colResult;


    }
}