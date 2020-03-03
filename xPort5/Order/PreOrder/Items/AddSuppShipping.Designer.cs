namespace xPort5.Order.PreOrder.Items
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
            this.dtpDate = new Gizmox.WebGUI.Forms.DateTimePicker();
            this.btnOK = new Gizmox.WebGUI.Forms.Button();
            this.txtSQty = new Gizmox.WebGUI.Forms.TextBox();
            this.lblSDate = new Gizmox.WebGUI.Forms.Label();
            this.lblSQty = new Gizmox.WebGUI.Forms.Label();
            this.SuspendLayout();
            // 
            // dtpDate
            // 
            this.dtpDate.CalendarFirstDayOfWeek = Gizmox.WebGUI.Forms.Day.Default;
            this.dtpDate.Cursor = Gizmox.WebGUI.Forms.Cursors.Arrow;
            this.dtpDate.CustomFormat = "yyyy-MM-dd";
            this.dtpDate.Format = Gizmox.WebGUI.Forms.DateTimePickerFormat.Custom;
            this.dtpDate.Location = new System.Drawing.Point(100, 46);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(100, 20);
            this.dtpDate.TabIndex = 5;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(232, 21);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "OK";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // txtSQty
            // 
            this.txtSQty.Location = new System.Drawing.Point(100, 21);
            this.txtSQty.Name = "txtSQty";
            this.txtSQty.Size = new System.Drawing.Size(100, 20);
            this.txtSQty.TabIndex = 2;
            // 
            // lblSDate
            // 
            this.lblSDate.Location = new System.Drawing.Point(27, 50);
            this.lblSDate.Name = "lblSDate";
            this.lblSDate.Size = new System.Drawing.Size(67, 23);
            this.lblSDate.TabIndex = 1;
            this.lblSDate.Text = "Date";
            // 
            // lblSQty
            // 
            this.lblSQty.Location = new System.Drawing.Point(27, 24);
            this.lblSQty.Name = "lblSQty";
            this.lblSQty.Size = new System.Drawing.Size(67, 23);
            this.lblSQty.TabIndex = 0;
            this.lblSQty.Text = "Qty";
            // 
            // AddSuppShipping
            // 
            this.Controls.Add(this.lblSQty);
            this.Controls.Add(this.lblSDate);
            this.Controls.Add(this.txtSQty);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.dtpDate);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Size = new System.Drawing.Size(340, 95);
            this.Text = "AddSuppShipping";
            this.Load += new System.EventHandler(this.AddSuppShipping_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Gizmox.WebGUI.Forms.DateTimePicker dtpDate;
        private Gizmox.WebGUI.Forms.Button btnOK;
        private Gizmox.WebGUI.Forms.TextBox txtSQty;
        private Gizmox.WebGUI.Forms.Label lblSDate;
        private Gizmox.WebGUI.Forms.Label lblSQty;


    }
}