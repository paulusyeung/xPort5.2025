namespace xPort5.Order.PurchaseContract.Items
{
    partial class AddCustShipping
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
            this.btnOK = new Gizmox.WebGUI.Forms.Button();
            this.txtCQty = new Gizmox.WebGUI.Forms.TextBox();
            this.lblCDate = new Gizmox.WebGUI.Forms.Label();
            this.lblCQty = new Gizmox.WebGUI.Forms.Label();
            this.dtpDate = new Gizmox.WebGUI.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(226, 16);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "OK";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // txtCQty
            // 
            this.txtCQty.Location = new System.Drawing.Point(94, 16);
            this.txtCQty.Name = "txtCQty";
            this.txtCQty.Size = new System.Drawing.Size(100, 20);
            this.txtCQty.TabIndex = 2;
            // 
            // lblCDate
            // 
            this.lblCDate.Location = new System.Drawing.Point(21, 45);
            this.lblCDate.Name = "lblCDate";
            this.lblCDate.Size = new System.Drawing.Size(67, 23);
            this.lblCDate.TabIndex = 1;
            this.lblCDate.Text = "Date";
            // 
            // lblCQty
            // 
            this.lblCQty.Location = new System.Drawing.Point(21, 19);
            this.lblCQty.Name = "lblCQty";
            this.lblCQty.Size = new System.Drawing.Size(67, 23);
            this.lblCQty.TabIndex = 0;
            this.lblCQty.Text = "Qty";
            // 
            // dtpDate
            // 
            this.dtpDate.CalendarFirstDayOfWeek = Gizmox.WebGUI.Forms.Day.Default;
            this.dtpDate.CustomFormat = "yyyy-MM-dd";
            this.dtpDate.Format = Gizmox.WebGUI.Forms.DateTimePickerFormat.Custom;
            this.dtpDate.Location = new System.Drawing.Point(94, 41);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(99, 20);
            this.dtpDate.TabIndex = 5;
            // 
            // AddCustShipping
            // 
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.lblCQty);
            this.Controls.Add(this.lblCDate);
            this.Controls.Add(this.txtCQty);
            this.Controls.Add(this.btnOK);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Size = new System.Drawing.Size(328, 89);
            this.Text = "AddCustShipping";
            this.Load += new System.EventHandler(this.AddCustShipping_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Gizmox.WebGUI.Forms.Button btnOK;
        private Gizmox.WebGUI.Forms.TextBox txtCQty;
        private Gizmox.WebGUI.Forms.Label lblCDate;
        private Gizmox.WebGUI.Forms.Label lblCQty;
        private Gizmox.WebGUI.Forms.DateTimePicker dtpDate;


    }
}