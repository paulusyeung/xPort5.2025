namespace xPort5.Order.Analysis
{
    partial class ActualShipments
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
            this.lvwList = new Gizmox.WebGUI.Forms.ListView();
            this.colOrderQtItemId = new Gizmox.WebGUI.Forms.ColumnHeader();
            this.colShippedDate = new Gizmox.WebGUI.Forms.ColumnHeader();
            this.colShippedQty = new Gizmox.WebGUI.Forms.ColumnHeader();
            this.colUnit = new Gizmox.WebGUI.Forms.ColumnHeader();
            this.colInvoiceNo = new Gizmox.WebGUI.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // lvwList
            // 
            this.lvwList.Anchor = Gizmox.WebGUI.Forms.AnchorStyles.None;
            this.lvwList.Columns.AddRange(new Gizmox.WebGUI.Forms.ColumnHeader[] {
            this.colOrderQtItemId,
            this.colShippedDate,
            this.colShippedQty,
            this.colUnit,
            this.colInvoiceNo});
            this.lvwList.DataMember = null;
            this.lvwList.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.lvwList.GridLines = true;
            this.lvwList.ItemsPerPage = 20;
            this.lvwList.Location = new System.Drawing.Point(0, 0);
            this.lvwList.MultiSelect = false;
            this.lvwList.Name = "lvwList";
            this.lvwList.Size = new System.Drawing.Size(309, 116);
            this.lvwList.TabIndex = 0;
            // 
            // colOrderQtItemId
            // 
            this.colOrderQtItemId.Image = null;
            this.colOrderQtItemId.Text = "OrderQtItemId";
            this.colOrderQtItemId.Visible = false;
            this.colOrderQtItemId.Width = 100;
            // 
            // colShippedDate
            // 
            this.colShippedDate.Image = null;
            this.colShippedDate.Text = "Shipped Date";
            this.colShippedDate.TextAlign = Gizmox.WebGUI.Forms.HorizontalAlignment.Right;
            this.colShippedDate.Width = 80;
            // 
            // colShippedQty
            // 
            this.colShippedQty.Image = null;
            this.colShippedQty.Text = "Shipped Qty";
            this.colShippedQty.TextAlign = Gizmox.WebGUI.Forms.HorizontalAlignment.Right;
            this.colShippedQty.Width = 70;
            // 
            // colUnit
            // 
            this.colUnit.Image = null;
            this.colUnit.Text = "Unit";
            this.colUnit.TextAlign = Gizmox.WebGUI.Forms.HorizontalAlignment.Center;
            this.colUnit.Width = 30;
            // 
            // colInvoiceNo
            // 
            this.colInvoiceNo.Image = null;
            this.colInvoiceNo.Text = "Invoice No.";
            this.colInvoiceNo.Width = 80;
            // 
            // ActualShipments
            // 
            this.Controls.Add(this.lvwList);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Size = new System.Drawing.Size(309, 116);
            this.StartPosition = Gizmox.WebGUI.Forms.FormStartPosition.CenterParent;
            this.Text = "ActualShipments";
            this.ResumeLayout(false);

        }

        #endregion

        private Gizmox.WebGUI.Forms.ListView lvwList;
        private Gizmox.WebGUI.Forms.ColumnHeader colShippedDate;
        private Gizmox.WebGUI.Forms.ColumnHeader colShippedQty;
        private Gizmox.WebGUI.Forms.ColumnHeader colUnit;
        private Gizmox.WebGUI.Forms.ColumnHeader colInvoiceNo;
        private Gizmox.WebGUI.Forms.ColumnHeader colOrderQtItemId;


    }
}