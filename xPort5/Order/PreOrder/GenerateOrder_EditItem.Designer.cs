namespace xPort5.Order.PreOrder
{
    partial class GenerateOrder_EditItem
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
            this.lblSupplierCode = new Gizmox.WebGUI.Forms.Label();
            this.txtSupplierCode = new Gizmox.WebGUI.Forms.TextBox();
            this.txtSupplierName = new Gizmox.WebGUI.Forms.TextBox();
            this.lblSupplierName = new Gizmox.WebGUI.Forms.Label();
            this.txtContractNumber = new Gizmox.WebGUI.Forms.TextBox();
            this.lblContractNumber = new Gizmox.WebGUI.Forms.Label();
            this.cmdOK = new Gizmox.WebGUI.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSupplierCode
            // 
            this.lblSupplierCode.Location = new System.Drawing.Point(12, 16);
            this.lblSupplierCode.Name = "lblSupplierCode";
            this.lblSupplierCode.Size = new System.Drawing.Size(100, 20);
            this.lblSupplierCode.TabIndex = 0;
            this.lblSupplierCode.Text = "Supplier Code:";
            // 
            // txtSupplierCode
            // 
            this.txtSupplierCode.Location = new System.Drawing.Point(112, 16);
            this.txtSupplierCode.Name = "txtSupplierCode";
            this.txtSupplierCode.Size = new System.Drawing.Size(128, 20);
            this.txtSupplierCode.TabIndex = 1;
            // 
            // txtSupplierName
            // 
            this.txtSupplierName.Location = new System.Drawing.Point(112, 42);
            this.txtSupplierName.Name = "txtSupplierName";
            this.txtSupplierName.Size = new System.Drawing.Size(295, 20);
            this.txtSupplierName.TabIndex = 1;
            // 
            // lblSupplierName
            // 
            this.lblSupplierName.Location = new System.Drawing.Point(12, 42);
            this.lblSupplierName.Name = "lblSupplierName";
            this.lblSupplierName.Size = new System.Drawing.Size(100, 20);
            this.lblSupplierName.TabIndex = 0;
            this.lblSupplierName.Text = "Supplier Name:";
            // 
            // txtContractNumber
            // 
            this.txtContractNumber.Location = new System.Drawing.Point(112, 68);
            this.txtContractNumber.Name = "txtContractNumber";
            this.txtContractNumber.Size = new System.Drawing.Size(128, 20);
            this.txtContractNumber.TabIndex = 1;
            // 
            // lblContractNumber
            // 
            this.lblContractNumber.Location = new System.Drawing.Point(12, 68);
            this.lblContractNumber.Name = "lblContractNumber";
            this.lblContractNumber.Size = new System.Drawing.Size(100, 20);
            this.lblContractNumber.TabIndex = 0;
            this.lblContractNumber.Text = "Contract Number:";
            // 
            // cmdOK
            // 
            this.cmdOK.Location = new System.Drawing.Point(112, 129);
            this.cmdOK.Name = "cmdOK";
            this.cmdOK.Size = new System.Drawing.Size(80, 24);
            this.cmdOK.TabIndex = 2;
            this.cmdOK.Text = "OK";
            this.cmdOK.Click += new System.EventHandler(this.cmdOK_Click);
            // 
            // GenerateOrder_EditItem
            // 
            this.AcceptButton = this.cmdOK;
            this.Controls.Add(this.cmdOK);
            this.Controls.Add(this.lblContractNumber);
            this.Controls.Add(this.txtContractNumber);
            this.Controls.Add(this.lblSupplierName);
            this.Controls.Add(this.txtSupplierName);
            this.Controls.Add(this.txtSupplierCode);
            this.Controls.Add(this.lblSupplierCode);
            this.FormBorderStyle = Gizmox.WebGUI.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Size = new System.Drawing.Size(419, 162);
            this.Text = "GenerateOrder_EditItem";
            this.Load += new System.EventHandler(this.GenerateOrder_EditItem_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Gizmox.WebGUI.Forms.Label lblSupplierCode;
        private Gizmox.WebGUI.Forms.TextBox txtSupplierCode;
        private Gizmox.WebGUI.Forms.TextBox txtSupplierName;
        private Gizmox.WebGUI.Forms.Label lblSupplierName;
        private Gizmox.WebGUI.Forms.TextBox txtContractNumber;
        private Gizmox.WebGUI.Forms.Label lblContractNumber;
        private Gizmox.WebGUI.Forms.Button cmdOK;


    }
}