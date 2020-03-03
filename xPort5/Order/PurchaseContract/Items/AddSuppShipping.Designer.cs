namespace xPort5.Order.PurchaseContract.Items
{
    partial class AddSuppShipping
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
            this.lblSQty = new Gizmox.WebGUI.Forms.Label();
            this.lblSDate = new Gizmox.WebGUI.Forms.Label();
            this.txtSQty = new Gizmox.WebGUI.Forms.TextBox();
            this.btnOK = new Gizmox.WebGUI.Forms.Button();
            this.dtpDate = new Gizmox.WebGUI.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // lblSQty
            // 
            this.lblSQty.Location = new System.Drawing.Point(29, 28);
            this.lblSQty.Name = "lblSQty";
            this.lblSQty.Size = new System.Drawing.Size(67, 23);
            this.lblSQty.TabIndex = 0;
            this.lblSQty.Text = "Qty";
            // 
            // lblSDate
            // 
            this.lblSDate.Location = new System.Drawing.Point(29, 54);
            this.lblSDate.Name = "lblSDate";
            this.lblSDate.Size = new System.Drawing.Size(67, 23);
            this.lblSDate.TabIndex = 1;
            this.lblSDate.Text = "Date";
            // 
            // txtSQty
            // 
            this.txtSQty.Location = new System.Drawing.Point(102, 25);
            this.txtSQty.Name = "txtSQty";
            this.txtSQty.Size = new System.Drawing.Size(100, 20);
            this.txtSQty.TabIndex = 2;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(234, 25);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "OK";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // dtpDate
            // 
            this.dtpDate.CalendarFirstDayOfWeek = Gizmox.WebGUI.Forms.Day.Default;
            this.dtpDate.Cursor = Gizmox.WebGUI.Forms.Cursors.Arrow;
            this.dtpDate.CustomFormat = "yyyy-MM-dd";
            this.dtpDate.Format = Gizmox.WebGUI.Forms.DateTimePickerFormat.Custom;
            this.dtpDate.Location = new System.Drawing.Point(102, 50);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(100, 20);
            this.dtpDate.TabIndex = 5;
            // 
            // AddSuppShipping
            // 
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtSQty);
            this.Controls.Add(this.lblSDate);
            this.Controls.Add(this.lblSQty);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Size = new System.Drawing.Size(341, 103);
            this.Text = "AddSuppShipping";
            this.Load += new System.EventHandler(this.AddSuppShipping_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Gizmox.WebGUI.Forms.Label lblSQty;
        private Gizmox.WebGUI.Forms.Label lblSDate;
        private Gizmox.WebGUI.Forms.TextBox txtSQty;
        private Gizmox.WebGUI.Forms.Button btnOK;
        private Gizmox.WebGUI.Forms.DateTimePicker dtpDate;


    }
}