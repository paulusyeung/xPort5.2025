namespace xPort5.Order.Invoice.Items
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddItemRecord));
            Gizmox.WebGUI.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new Gizmox.WebGUI.Forms.DataGridViewCellStyle();
            Gizmox.WebGUI.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new Gizmox.WebGUI.Forms.DataGridViewCellStyle();
            Gizmox.WebGUI.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new Gizmox.WebGUI.Forms.DataGridViewCellStyle();
            Gizmox.WebGUI.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new Gizmox.WebGUI.Forms.DataGridViewCellStyle();
            Gizmox.WebGUI.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new Gizmox.WebGUI.Forms.DataGridViewCellStyle();
            Gizmox.WebGUI.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new Gizmox.WebGUI.Forms.DataGridViewCellStyle();
            Gizmox.WebGUI.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new Gizmox.WebGUI.Forms.DataGridViewCellStyle();
            Gizmox.WebGUI.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new Gizmox.WebGUI.Forms.DataGridViewCellStyle();
            Gizmox.WebGUI.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new Gizmox.WebGUI.Forms.DataGridViewCellStyle();
            Gizmox.WebGUI.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new Gizmox.WebGUI.Forms.DataGridViewCellStyle();
            this.lblSCNumber = new Gizmox.WebGUI.Forms.Label();
            this.txtSCNumber = new Gizmox.WebGUI.Forms.TextBox();
            this.btnOK = new Gizmox.WebGUI.Forms.Button();
            this.btnClear = new Gizmox.WebGUI.Forms.Button();
            this.btnSearch = new Gizmox.WebGUI.Forms.Button();
            this.lblShipmentSchedule = new Gizmox.WebGUI.Forms.Label();
            this.dgvQTList = new Gizmox.WebGUI.Forms.DataGridView();
            this.colOrderQTItemId = new Gizmox.WebGUI.Forms.DataGridViewTextBoxColumn();
            this.colLineNumber = new Gizmox.WebGUI.Forms.DataGridViewTextBoxColumn();
            this.colArticleCode = new Gizmox.WebGUI.Forms.DataGridViewTextBoxColumn();
            this.colColor = new Gizmox.WebGUI.Forms.DataGridViewTextBoxColumn();
            this.colCustRef = new Gizmox.WebGUI.Forms.DataGridViewTextBoxColumn();
            this.colOutstandingQty = new Gizmox.WebGUI.Forms.DataGridViewTextBoxColumn();
            this.colInvoicedQty = new Gizmox.WebGUI.Forms.DataGridViewTextBoxColumn();
            this.dgvShipmentList = new Gizmox.WebGUI.Forms.DataGridView();
            this.colScheduledDate = new Gizmox.WebGUI.Forms.DataGridViewTextBoxColumn();
            this.colOSQty = new Gizmox.WebGUI.Forms.DataGridViewTextBoxColumn();
            this.colThisShipment = new Gizmox.WebGUI.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQTList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShipmentList)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSCNumber
            // 
            this.lblSCNumber.Location = new System.Drawing.Point(12, 16);
            this.lblSCNumber.Name = "lblSCNumber";
            this.lblSCNumber.Size = new System.Drawing.Size(100, 23);
            this.lblSCNumber.TabIndex = 0;
            this.lblSCNumber.Text = "SCNumber:";
            // 
            // txtSCNumber
            // 
            this.txtSCNumber.Location = new System.Drawing.Point(118, 13);
            this.txtSCNumber.Name = "txtSCNumber";
            this.txtSCNumber.Size = new System.Drawing.Size(156, 20);
            this.txtSCNumber.TabIndex = 1;
            this.txtSCNumber.TextChanged += new System.EventHandler(this.txtSCNumber_TextChanged);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(482, 40);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "OK";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(482, 69);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Image = new Gizmox.WebGUI.Common.Resources.IconResourceHandle(resources.GetString("btnSearch.Image"));
            this.btnSearch.Location = new System.Drawing.Point(280, 11);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(33, 23);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.TextImageRelation = Gizmox.WebGUI.Forms.TextImageRelation.ImageAboveText;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblShipmentSchedule
            // 
            this.lblShipmentSchedule.Location = new System.Drawing.Point(12, 260);
            this.lblShipmentSchedule.Name = "lblShipmentSchedule";
            this.lblShipmentSchedule.Size = new System.Drawing.Size(335, 23);
            this.lblShipmentSchedule.TabIndex = 6;
            this.lblShipmentSchedule.Text = "Shipment Schedule:";
            // 
            // dgvQTList
            // 
            this.dgvQTList.AllowUserToAddRows = false;
            this.dgvQTList.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = Gizmox.WebGUI.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.FormatProvider = new System.Globalization.CultureInfo("en-US");
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = Gizmox.WebGUI.Forms.DataGridViewTriState.True;
            this.dgvQTList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvQTList.Columns.AddRange(new Gizmox.WebGUI.Forms.DataGridViewColumn[] {
            this.colOrderQTItemId,
            this.colLineNumber,
            this.colArticleCode,
            this.colColor,
            this.colCustRef,
            this.colOutstandingQty,
            this.colInvoicedQty});
            this.dgvQTList.Location = new System.Drawing.Point(12, 42);
            this.dgvQTList.MultiSelect = false;
            this.dgvQTList.Name = "dgvQTList";
            this.dgvQTList.RowHeadersWidth = 5;
            this.dgvQTList.RowTemplate.Height = 23;
            this.dgvQTList.SelectionMode = Gizmox.WebGUI.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvQTList.Size = new System.Drawing.Size(461, 204);
            this.dgvQTList.TabIndex = 8;
            this.dgvQTList.UseInternalPaging = false;
            this.dgvQTList.SelectionChanged += new System.EventHandler(this.dgvQTList_SelectionChanged);
            // 
            // colOrderQTItemId
            // 
            this.colOrderQTItemId.DataPropertyName = "OrderSCItemsId";
            this.colOrderQTItemId.DefaultCellStyle = dataGridViewCellStyle2;
            this.colOrderQTItemId.DefaultHeaderCellType = typeof(Gizmox.WebGUI.Forms.DataGridViewColumnHeaderCell);
            this.colOrderQTItemId.Name = "colOrderQTItemId";
            this.colOrderQTItemId.Resizable = Gizmox.WebGUI.Forms.DataGridViewTriState.True;
            this.colOrderQTItemId.Visible = false;
            // 
            // colLineNumber
            // 
            this.colLineNumber.DataPropertyName = "SCLineNo";
            this.colLineNumber.DefaultHeaderCellType = typeof(Gizmox.WebGUI.Forms.DataGridViewColumnHeaderCell);
            this.colLineNumber.FillWeight = 40F;
            this.colLineNumber.HeaderText = "#";
            this.colLineNumber.Name = "colLineNumber";
            this.colLineNumber.ReadOnly = true;
            this.colLineNumber.Resizable = Gizmox.WebGUI.Forms.DataGridViewTriState.True;
            this.colLineNumber.Width = 40;
            // 
            // colArticleCode
            // 
            this.colArticleCode.DataPropertyName = "ArticleCode";
            this.colArticleCode.DefaultHeaderCellType = typeof(Gizmox.WebGUI.Forms.DataGridViewColumnHeaderCell);
            this.colArticleCode.HeaderText = "Article Code";
            this.colArticleCode.Name = "colArticleCode";
            this.colArticleCode.ReadOnly = true;
            this.colArticleCode.Resizable = Gizmox.WebGUI.Forms.DataGridViewTriState.True;
            // 
            // colColor
            // 
            this.colColor.DataPropertyName = "Color";
            this.colColor.DefaultCellStyle = dataGridViewCellStyle3;
            this.colColor.DefaultHeaderCellType = typeof(Gizmox.WebGUI.Forms.DataGridViewColumnHeaderCell);
            this.colColor.HeaderText = "Color";
            this.colColor.Name = "colColor";
            this.colColor.ReadOnly = true;
            this.colColor.Resizable = Gizmox.WebGUI.Forms.DataGridViewTriState.True;
            // 
            // colCustRef
            // 
            this.colCustRef.DataPropertyName = "CustRef";
            this.colCustRef.DefaultCellStyle = dataGridViewCellStyle4;
            this.colCustRef.DefaultHeaderCellType = typeof(Gizmox.WebGUI.Forms.DataGridViewColumnHeaderCell);
            this.colCustRef.Name = "colCustRef";
            this.colCustRef.ReadOnly = true;
            this.colCustRef.Resizable = Gizmox.WebGUI.Forms.DataGridViewTriState.True;
            // 
            // colOutstandingQty
            // 
            this.colOutstandingQty.DataPropertyName = "OSQty";
            dataGridViewCellStyle5.Alignment = Gizmox.WebGUI.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "#,###0";
            dataGridViewCellStyle5.FormatProvider = new System.Globalization.CultureInfo("en-US");
            dataGridViewCellStyle5.NullValue = "0";
            this.colOutstandingQty.DefaultCellStyle = dataGridViewCellStyle5;
            this.colOutstandingQty.DefaultHeaderCellType = typeof(Gizmox.WebGUI.Forms.DataGridViewColumnHeaderCell);
            this.colOutstandingQty.FillWeight = 80F;
            this.colOutstandingQty.HeaderText = "O/S Qty";
            this.colOutstandingQty.Name = "colOutstandingQty";
            this.colOutstandingQty.ReadOnly = true;
            this.colOutstandingQty.Resizable = Gizmox.WebGUI.Forms.DataGridViewTriState.True;
            this.colOutstandingQty.Width = 80;
            // 
            // colInvoicedQty
            // 
            this.colInvoicedQty.DataPropertyName = "InvoicedQty";
            dataGridViewCellStyle6.Alignment = Gizmox.WebGUI.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Format = "#,###0";
            dataGridViewCellStyle6.FormatProvider = new System.Globalization.CultureInfo("en-US");
            dataGridViewCellStyle6.NullValue = "0";
            this.colInvoicedQty.DefaultCellStyle = dataGridViewCellStyle6;
            this.colInvoicedQty.DefaultHeaderCellType = typeof(Gizmox.WebGUI.Forms.DataGridViewColumnHeaderCell);
            this.colInvoicedQty.FillWeight = 80F;
            this.colInvoicedQty.HeaderText = "Invoiced Qty";
            this.colInvoicedQty.Name = "colInvoicedQty";
            this.colInvoicedQty.Resizable = Gizmox.WebGUI.Forms.DataGridViewTriState.True;
            this.colInvoicedQty.Width = 80;
            // 
            // dgvShipmentList
            // 
            this.dgvShipmentList.AllowUserToAddRows = false;
            this.dgvShipmentList.AllowUserToDeleteRows = false;
            dataGridViewCellStyle7.Alignment = Gizmox.WebGUI.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Tahoma", 8.25F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.FormatProvider = new System.Globalization.CultureInfo("en-US");
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = Gizmox.WebGUI.Forms.DataGridViewTriState.True;
            this.dgvShipmentList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvShipmentList.Columns.AddRange(new Gizmox.WebGUI.Forms.DataGridViewColumn[] {
            this.colScheduledDate,
            this.colOSQty,
            this.colThisShipment});
            this.dgvShipmentList.Location = new System.Drawing.Point(12, 287);
            this.dgvShipmentList.Name = "dgvShipmentList";
            this.dgvShipmentList.RowHeadersWidth = 5;
            this.dgvShipmentList.RowTemplate.Height = 23;
            this.dgvShipmentList.Size = new System.Drawing.Size(461, 120);
            this.dgvShipmentList.TabIndex = 9;
            this.dgvShipmentList.UseInternalPaging = false;
            this.dgvShipmentList.CellEndEdit += new Gizmox.WebGUI.Forms.DataGridViewCellEventHandler(this.dgvShipmentList_CellEndEdit);
            // 
            // colScheduledDate
            // 
            this.colScheduledDate.DataPropertyName = "ShippedOn";
            dataGridViewCellStyle8.Format = "dd/MM/yyyy";
            dataGridViewCellStyle8.FormatProvider = new System.Globalization.CultureInfo("en-US");
            dataGridViewCellStyle8.NullValue = null;
            this.colScheduledDate.DefaultCellStyle = dataGridViewCellStyle8;
            this.colScheduledDate.DefaultHeaderCellType = typeof(Gizmox.WebGUI.Forms.DataGridViewColumnHeaderCell);
            this.colScheduledDate.HeaderText = "Scheduled Date";
            this.colScheduledDate.Name = "colScheduledDate";
            this.colScheduledDate.ReadOnly = true;
            this.colScheduledDate.Resizable = Gizmox.WebGUI.Forms.DataGridViewTriState.True;
            // 
            // colOSQty
            // 
            this.colOSQty.DataPropertyName = "OSQty";
            dataGridViewCellStyle9.Alignment = Gizmox.WebGUI.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle9.Format = "#,###0";
            dataGridViewCellStyle9.FormatProvider = new System.Globalization.CultureInfo("en-US");
            dataGridViewCellStyle9.NullValue = "0";
            this.colOSQty.DefaultCellStyle = dataGridViewCellStyle9;
            this.colOSQty.DefaultHeaderCellType = typeof(Gizmox.WebGUI.Forms.DataGridViewColumnHeaderCell);
            this.colOSQty.HeaderText = "O/S Qty";
            this.colOSQty.Name = "colOSQty";
            this.colOSQty.ReadOnly = true;
            this.colOSQty.Resizable = Gizmox.WebGUI.Forms.DataGridViewTriState.True;
            // 
            // colThisShipment
            // 
            this.colThisShipment.DataPropertyName = "ThisShipment";
            dataGridViewCellStyle10.Alignment = Gizmox.WebGUI.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle10.Format = "#,###0";
            dataGridViewCellStyle10.FormatProvider = new System.Globalization.CultureInfo("en-US");
            dataGridViewCellStyle10.NullValue = "0";
            this.colThisShipment.DefaultCellStyle = dataGridViewCellStyle10;
            this.colThisShipment.DefaultHeaderCellType = typeof(Gizmox.WebGUI.Forms.DataGridViewColumnHeaderCell);
            this.colThisShipment.HeaderText = "This Shipment";
            this.colThisShipment.Name = "colThisShipment";
            this.colThisShipment.Resizable = Gizmox.WebGUI.Forms.DataGridViewTriState.True;
            // 
            // AddItemRecord
            // 
            this.Controls.Add(this.dgvShipmentList);
            this.Controls.Add(this.dgvQTList);
            this.Controls.Add(this.lblShipmentSchedule);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtSCNumber);
            this.Controls.Add(this.lblSCNumber);
            this.FormBorderStyle = Gizmox.WebGUI.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Size = new System.Drawing.Size(568, 419);
            this.Text = "ItemRecord";
            ((System.ComponentModel.ISupportInitialize)(this.dgvQTList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShipmentList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Gizmox.WebGUI.Forms.Label lblSCNumber;
        private Gizmox.WebGUI.Forms.TextBox txtSCNumber;
        private Gizmox.WebGUI.Forms.Button btnOK;
        private Gizmox.WebGUI.Forms.Button btnClear;
        private Gizmox.WebGUI.Forms.Button btnSearch;
        private Gizmox.WebGUI.Forms.Label lblShipmentSchedule;
        private Gizmox.WebGUI.Forms.DataGridView dgvQTList;
        private Gizmox.WebGUI.Forms.DataGridViewTextBoxColumn colOrderQTItemId;
        private Gizmox.WebGUI.Forms.DataGridViewTextBoxColumn colLineNumber;
        private Gizmox.WebGUI.Forms.DataGridViewTextBoxColumn colArticleCode;
        private Gizmox.WebGUI.Forms.DataGridViewTextBoxColumn colOutstandingQty;
        private Gizmox.WebGUI.Forms.DataGridViewTextBoxColumn colInvoicedQty;
        private Gizmox.WebGUI.Forms.DataGridView dgvShipmentList;
        private Gizmox.WebGUI.Forms.DataGridViewTextBoxColumn colScheduledDate;
        private Gizmox.WebGUI.Forms.DataGridViewTextBoxColumn colOSQty;
        private Gizmox.WebGUI.Forms.DataGridViewTextBoxColumn colThisShipment;
        private Gizmox.WebGUI.Forms.DataGridViewTextBoxColumn colColor;
        private Gizmox.WebGUI.Forms.DataGridViewTextBoxColumn colCustRef;


    }
}