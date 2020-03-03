namespace xPort5.Order.PreOrder
{
    partial class PreOrderRecord
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
            Gizmox.WebGUI.Common.Resources.IconResourceHandle iconResourceHandle1 = new Gizmox.WebGUI.Common.Resources.IconResourceHandle();
            this.ansToolbar = new Gizmox.WebGUI.Forms.ToolBar();
            this.headerPane = new Gizmox.WebGUI.Forms.Panel();
            this.cmdNextPLNumber = new Gizmox.WebGUI.Forms.Button();
            this.cboRemarks = new Gizmox.WebGUI.Forms.ComboBox();
            this.lblRemarks = new Gizmox.WebGUI.Forms.Label();
            this.txtRemarks = new Gizmox.WebGUI.Forms.TextBox();
            this.cboSalesperson = new Gizmox.WebGUI.Forms.ComboBox();
            this.cboCustomer = new Gizmox.WebGUI.Forms.ComboBox();
            this.dtpDate = new Gizmox.WebGUI.Forms.DateTimePicker();
            this.txtPLNumber = new Gizmox.WebGUI.Forms.TextBox();
            this.lblSalesperson = new Gizmox.WebGUI.Forms.Label();
            this.lblCustomer = new Gizmox.WebGUI.Forms.Label();
            this.lblDate = new Gizmox.WebGUI.Forms.Label();
            this.lblPreOrderNumber = new Gizmox.WebGUI.Forms.Label();
            this.itemPane = new Gizmox.WebGUI.Forms.Panel();
            this.toolTip1 = new Gizmox.WebGUI.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // ansToolbar
            // 
            this.ansToolbar.Anchor = Gizmox.WebGUI.Forms.AnchorStyles.None;
            this.ansToolbar.Appearance = Gizmox.WebGUI.Forms.ToolBarAppearance.Normal;
            this.ansToolbar.Dock = Gizmox.WebGUI.Forms.DockStyle.Top;
            this.ansToolbar.DragHandle = true;
            this.ansToolbar.DropDownArrows = false;
            this.ansToolbar.ImageList = null;
            this.ansToolbar.Location = new System.Drawing.Point(0, 0);
            this.ansToolbar.MenuHandle = true;
            this.ansToolbar.Name = "ansToolbar";
            this.ansToolbar.RightToLeft = Gizmox.WebGUI.Forms.RightToLeft.No;
            this.ansToolbar.ShowToolTips = true;
            this.ansToolbar.TabIndex = 0;
            // 
            // headerPane
            // 
            this.headerPane.Anchor = Gizmox.WebGUI.Forms.AnchorStyles.None;
            this.headerPane.Controls.Add(this.cmdNextPLNumber);
            this.headerPane.Controls.Add(this.cboRemarks);
            this.headerPane.Controls.Add(this.lblRemarks);
            this.headerPane.Controls.Add(this.txtRemarks);
            this.headerPane.Controls.Add(this.cboSalesperson);
            this.headerPane.Controls.Add(this.cboCustomer);
            this.headerPane.Controls.Add(this.dtpDate);
            this.headerPane.Controls.Add(this.txtPLNumber);
            this.headerPane.Controls.Add(this.lblSalesperson);
            this.headerPane.Controls.Add(this.lblCustomer);
            this.headerPane.Controls.Add(this.lblDate);
            this.headerPane.Controls.Add(this.lblPreOrderNumber);
            this.headerPane.Dock = Gizmox.WebGUI.Forms.DockStyle.Top;
            this.headerPane.Location = new System.Drawing.Point(0, 28);
            this.headerPane.Name = "headerPane";
            this.headerPane.Size = new System.Drawing.Size(842, 181);
            this.headerPane.TabIndex = 1;
            // 
            // cmdNextPLNumber
            // 
            iconResourceHandle1.File = "16x16.lightbulb.png";
            this.cmdNextPLNumber.Image = iconResourceHandle1;
            this.cmdNextPLNumber.Location = new System.Drawing.Point(385, 1);
            this.cmdNextPLNumber.Name = "cmdNextPLNumber";
            this.cmdNextPLNumber.Size = new System.Drawing.Size(24, 23);
            this.cmdNextPLNumber.TabIndex = 2;
            this.cmdNextPLNumber.TextImageRelation = Gizmox.WebGUI.Forms.TextImageRelation.ImageAboveText;
            this.cmdNextPLNumber.Visible = false;
            this.cmdNextPLNumber.Click += new System.EventHandler(this.cmdNextPLNumber_Click);
            // 
            // cboRemarks
            // 
            this.cboRemarks.DropDownStyle = Gizmox.WebGUI.Forms.ComboBoxStyle.DropDownList;
            this.cboRemarks.DropDownWidth = 100;
            this.cboRemarks.Location = new System.Drawing.Point(87, 109);
            this.cboRemarks.Name = "cboRemarks";
            this.cboRemarks.Size = new System.Drawing.Size(19, 21);
            this.cboRemarks.TabIndex = 10;
            this.cboRemarks.SelectedIndexChanged += new System.EventHandler(this.cboRemarks_SelectedIndexChanged);
            // 
            // lblRemarks
            // 
            this.lblRemarks.Location = new System.Drawing.Point(6, 112);
            this.lblRemarks.Name = "lblRemarks";
            this.lblRemarks.Size = new System.Drawing.Size(100, 21);
            this.lblRemarks.TabIndex = 9;
            this.lblRemarks.Text = "Remarks:";
            // 
            // txtRemarks
            // 
            this.txtRemarks.Location = new System.Drawing.Point(112, 109);
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.ScrollBars = Gizmox.WebGUI.Forms.ScrollBars.Vertical;
            this.txtRemarks.Size = new System.Drawing.Size(297, 60);
            this.txtRemarks.TabIndex = 11;
            // 
            // cboSalesperson
            // 
            this.cboSalesperson.DropDownStyle = Gizmox.WebGUI.Forms.ComboBoxStyle.DropDownList;
            this.cboSalesperson.Location = new System.Drawing.Point(112, 82);
            this.cboSalesperson.Name = "cboSalesperson";
            this.cboSalesperson.Size = new System.Drawing.Size(297, 21);
            this.cboSalesperson.TabIndex = 8;
            // 
            // cboCustomer
            // 
            this.cboCustomer.DropDownStyle = Gizmox.WebGUI.Forms.ComboBoxStyle.DropDownList;
            this.cboCustomer.Location = new System.Drawing.Point(112, 55);
            this.cboCustomer.Name = "cboCustomer";
            this.cboCustomer.Size = new System.Drawing.Size(297, 21);
            this.cboCustomer.TabIndex = 7;
            // 
            // dtpDate
            // 
            this.dtpDate.CalendarFirstDayOfWeek = Gizmox.WebGUI.Forms.Day.Default;
            this.dtpDate.CustomFormat = "dd/MM/yyyy";
            this.dtpDate.Format = Gizmox.WebGUI.Forms.DateTimePickerFormat.Custom;
            this.dtpDate.Location = new System.Drawing.Point(112, 29);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(297, 20);
            this.dtpDate.TabIndex = 6;
            // 
            // txtPLNumber
            // 
            this.txtPLNumber.Location = new System.Drawing.Point(112, 3);
            this.txtPLNumber.Name = "txtPLNumber";
            this.txtPLNumber.Size = new System.Drawing.Size(297, 20);
            this.txtPLNumber.TabIndex = 5;
            // 
            // lblSalesperson
            // 
            this.lblSalesperson.Location = new System.Drawing.Point(6, 85);
            this.lblSalesperson.Name = "lblSalesperson";
            this.lblSalesperson.Size = new System.Drawing.Size(100, 23);
            this.lblSalesperson.TabIndex = 3;
            this.lblSalesperson.Text = "Salesperson:";
            // 
            // lblCustomer
            // 
            this.lblCustomer.Location = new System.Drawing.Point(6, 58);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(100, 23);
            this.lblCustomer.TabIndex = 2;
            this.lblCustomer.Text = "Customer:";
            // 
            // lblDate
            // 
            this.lblDate.Location = new System.Drawing.Point(6, 32);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(100, 23);
            this.lblDate.TabIndex = 1;
            this.lblDate.Text = "Date:";
            // 
            // lblPreOrderNumber
            // 
            this.lblPreOrderNumber.Location = new System.Drawing.Point(6, 6);
            this.lblPreOrderNumber.Name = "lblPreOrderNumber";
            this.lblPreOrderNumber.Size = new System.Drawing.Size(100, 23);
            this.lblPreOrderNumber.TabIndex = 0;
            this.lblPreOrderNumber.Text = "Pre-Order Number:";
            // 
            // itemPane
            // 
            this.itemPane.Anchor = Gizmox.WebGUI.Forms.AnchorStyles.None;
            this.itemPane.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.itemPane.Location = new System.Drawing.Point(0, 209);
            this.itemPane.Name = "itemPane";
            this.itemPane.Size = new System.Drawing.Size(842, 332);
            this.itemPane.TabIndex = 2;
            // 
            // PreOrderRecord
            // 
            this.Controls.Add(this.itemPane);
            this.Controls.Add(this.headerPane);
            this.Controls.Add(this.ansToolbar);
            this.Size = new System.Drawing.Size(842, 541);
            this.Text = "Pre-Order Record";
            this.ResumeLayout(false);

        }

        #endregion

        private Gizmox.WebGUI.Forms.ToolBar ansToolbar;
        private Gizmox.WebGUI.Forms.Panel headerPane;
        private Gizmox.WebGUI.Forms.Label lblSalesperson;
        private Gizmox.WebGUI.Forms.Label lblCustomer;
        private Gizmox.WebGUI.Forms.Label lblDate;
        private Gizmox.WebGUI.Forms.Label lblPreOrderNumber;
        private Gizmox.WebGUI.Forms.Panel itemPane;
        private Gizmox.WebGUI.Forms.TextBox txtPLNumber;
        private Gizmox.WebGUI.Forms.DateTimePicker dtpDate;
        private Gizmox.WebGUI.Forms.ComboBox cboCustomer;
        private Gizmox.WebGUI.Forms.ComboBox cboSalesperson;
        private Gizmox.WebGUI.Forms.ComboBox cboRemarks;
        private Gizmox.WebGUI.Forms.Label lblRemarks;
        private Gizmox.WebGUI.Forms.TextBox txtRemarks;
        private Gizmox.WebGUI.Forms.Button cmdNextPLNumber;
        private Gizmox.WebGUI.Forms.ToolTip toolTip1;


    }
}