namespace xPort5.Order.Invoice.Items
{
    partial class AdditionalCharges
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
            this.lblCharge = new Gizmox.WebGUI.Forms.Label();
            this.cboCharge = new Gizmox.WebGUI.Forms.ComboBox();
            this.lblDescription = new Gizmox.WebGUI.Forms.Label();
            this.txtDescription = new Gizmox.WebGUI.Forms.TextBox();
            this.lblAmount = new Gizmox.WebGUI.Forms.Label();
            this.txtAmount = new Gizmox.WebGUI.Forms.TextBox();
            this.btnAdd = new Gizmox.WebGUI.Forms.Button();
            this.lvwChargeList = new Gizmox.WebGUI.Forms.ListView();
            this.colOrderINChargeId = new Gizmox.WebGUI.Forms.ColumnHeader();
            this.colChargeCode = new Gizmox.WebGUI.Forms.ColumnHeader();
            this.colDescription = new Gizmox.WebGUI.Forms.ColumnHeader();
            this.colAmount = new Gizmox.WebGUI.Forms.ColumnHeader();
            this.btnEdit = new Gizmox.WebGUI.Forms.Button();
            this.cmdDelete = new Gizmox.WebGUI.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCharge
            // 
            this.lblCharge.Location = new System.Drawing.Point(18, 17);
            this.lblCharge.Name = "lblCharge";
            this.lblCharge.Size = new System.Drawing.Size(77, 23);
            this.lblCharge.TabIndex = 0;
            this.lblCharge.Text = "Charge:";
            // 
            // cboCharge
            // 
            this.cboCharge.Location = new System.Drawing.Point(101, 14);
            this.cboCharge.Name = "cboCharge";
            this.cboCharge.Size = new System.Drawing.Size(104, 21);
            this.cboCharge.TabIndex = 1;
            this.cboCharge.SelectedIndexChanged += new System.EventHandler(this.cboCharge_SelectedIndexChanged);
            // 
            // lblDescription
            // 
            this.lblDescription.Location = new System.Drawing.Point(18, 44);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(100, 23);
            this.lblDescription.TabIndex = 2;
            this.lblDescription.Text = "Description:";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(101, 41);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(238, 20);
            this.txtDescription.TabIndex = 3;
            // 
            // lblAmount
            // 
            this.lblAmount.Location = new System.Drawing.Point(18, 70);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(100, 23);
            this.lblAmount.TabIndex = 4;
            this.lblAmount.Text = "Amount:";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(101, 67);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(100, 20);
            this.txtAmount.TabIndex = 5;
            this.txtAmount.Text = "0.00";
            this.txtAmount.TextAlign = Gizmox.WebGUI.Forms.HorizontalAlignment.Right;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(406, 9);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lvwChargeList
            // 
            this.lvwChargeList.Columns.AddRange(new Gizmox.WebGUI.Forms.ColumnHeader[] {
            this.colOrderINChargeId,
            this.colChargeCode,
            this.colDescription,
            this.colAmount});
            this.lvwChargeList.DataMember = null;
            this.lvwChargeList.ItemsPerPage = 20;
            this.lvwChargeList.Location = new System.Drawing.Point(12, 96);
            this.lvwChargeList.Name = "lvwChargeList";
            this.lvwChargeList.Size = new System.Drawing.Size(487, 171);
            this.lvwChargeList.TabIndex = 7;
            this.lvwChargeList.SelectedIndexChanged += new System.EventHandler(this.lvwChargeList_SelectedIndexChanged);
            // 
            // colOrderINChargeId
            // 
            this.colOrderINChargeId.Image = null;
            this.colOrderINChargeId.Text = "";
            this.colOrderINChargeId.Visible = false;
            this.colOrderINChargeId.Width = 150;
            // 
            // colChargeCode
            // 
            this.colChargeCode.Image = null;
            this.colChargeCode.Text = "Code";
            this.colChargeCode.Width = 60;
            // 
            // colDescription
            // 
            this.colDescription.Image = null;
            this.colDescription.Text = "Description";
            this.colDescription.Width = 210;
            // 
            // colAmount
            // 
            this.colAmount.Image = null;
            this.colAmount.Text = "Amount";
            this.colAmount.TextAlign = Gizmox.WebGUI.Forms.HorizontalAlignment.Right;
            this.colAmount.Width = 80;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(406, 38);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 8;
            this.btnEdit.Text = "Edit";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // cmdDelete
            // 
            this.cmdDelete.Location = new System.Drawing.Point(406, 67);
            this.cmdDelete.Name = "cmdDelete";
            this.cmdDelete.Size = new System.Drawing.Size(75, 23);
            this.cmdDelete.TabIndex = 8;
            this.cmdDelete.Text = "Delete";
            this.cmdDelete.Click += new System.EventHandler(this.cmdDelete_Click);
            // 
            // AdditionalCharges
            // 
            this.Controls.Add(this.cmdDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.lvwChargeList);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.cboCharge);
            this.Controls.Add(this.lblCharge);
            this.FormBorderStyle = Gizmox.WebGUI.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Size = new System.Drawing.Size(511, 279);
            this.Text = "AdditionalCharges";
            this.ResumeLayout(false);

        }

        #endregion

        private Gizmox.WebGUI.Forms.Label lblCharge;
        private Gizmox.WebGUI.Forms.ComboBox cboCharge;
        private Gizmox.WebGUI.Forms.Label lblDescription;
        private Gizmox.WebGUI.Forms.TextBox txtDescription;
        private Gizmox.WebGUI.Forms.Label lblAmount;
        private Gizmox.WebGUI.Forms.TextBox txtAmount;
        private Gizmox.WebGUI.Forms.Button btnAdd;
        private Gizmox.WebGUI.Forms.ListView lvwChargeList;
        private Gizmox.WebGUI.Forms.ColumnHeader colOrderINChargeId;
        private Gizmox.WebGUI.Forms.ColumnHeader colChargeCode;
        private Gizmox.WebGUI.Forms.ColumnHeader colDescription;
        private Gizmox.WebGUI.Forms.ColumnHeader colAmount;
        private Gizmox.WebGUI.Forms.Button btnEdit;
        private Gizmox.WebGUI.Forms.Button cmdDelete;


    }
}