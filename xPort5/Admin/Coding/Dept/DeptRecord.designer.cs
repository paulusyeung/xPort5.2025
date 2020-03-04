namespace xPort5.Admin.Coding.Dept
{
    partial class DeptRecord
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeptRecord));
            this.ansToolbar = new Gizmox.WebGUI.Forms.ToolBar();
            this.wspBackground = new Gizmox.WebGUI.Forms.Panel();
            this.cmdConvertToCht = new Gizmox.WebGUI.Forms.Button();
            this.cmdConvertToChs = new Gizmox.WebGUI.Forms.Button();
            this.boxLogs = new Gizmox.WebGUI.Forms.GroupBox();
            this.lblModifiedOb = new Gizmox.WebGUI.Forms.Label();
            this.txtModifiedOn = new Gizmox.WebGUI.Forms.Label();
            this.txtModifiedBy = new Gizmox.WebGUI.Forms.Label();
            this.lblModifiedBy = new Gizmox.WebGUI.Forms.Label();
            this.lblCreatedBy = new Gizmox.WebGUI.Forms.Label();
            this.txtCreatedBy = new Gizmox.WebGUI.Forms.Label();
            this.txtCreatedOn = new Gizmox.WebGUI.Forms.Label();
            this.lblCreatedOn = new Gizmox.WebGUI.Forms.Label();
            this.txtName_Cht = new Gizmox.WebGUI.Forms.TextBox();
            this.lblName_Cht = new Gizmox.WebGUI.Forms.Label();
            this.txtName_Chs = new Gizmox.WebGUI.Forms.TextBox();
            this.lblName_Chs = new Gizmox.WebGUI.Forms.Label();
            this.txtName = new Gizmox.WebGUI.Forms.TextBox();
            this.lblName = new Gizmox.WebGUI.Forms.Label();
            this.txtCode = new Gizmox.WebGUI.Forms.TextBox();
            this.lblCode = new Gizmox.WebGUI.Forms.Label();
            this.colDept = ((Gizmox.WebGUI.Forms.ColumnHeader)(new Gizmox.WebGUI.Forms.ColumnHeader()));
            this.colClass = ((Gizmox.WebGUI.Forms.ColumnHeader)(new Gizmox.WebGUI.Forms.ColumnHeader()));
            this.colCategory = ((Gizmox.WebGUI.Forms.ColumnHeader)(new Gizmox.WebGUI.Forms.ColumnHeader()));
            this.colCategoryId = ((Gizmox.WebGUI.Forms.ColumnHeader)(new Gizmox.WebGUI.Forms.ColumnHeader()));
            this.toolTip1 = new Gizmox.WebGUI.Forms.ToolTip();
            this.wspBackground.SuspendLayout();
            this.boxLogs.SuspendLayout();
            this.SuspendLayout();
            // 
            // ansToolbar
            // 
            this.ansToolbar.DragHandle = true;
            this.ansToolbar.DropDownArrows = true;
            this.ansToolbar.ImageSize = new System.Drawing.Size(16, 16);
            this.ansToolbar.Location = new System.Drawing.Point(0, 0);
            this.ansToolbar.MenuHandle = true;
            this.ansToolbar.Name = "ansToolbar";
            this.ansToolbar.RightToLeft = Gizmox.WebGUI.Forms.RightToLeft.No;
            this.ansToolbar.ShowToolTips = true;
            this.ansToolbar.Size = new System.Drawing.Size(100, 22);
            this.ansToolbar.TabIndex = 0;
            // 
            // wspBackground
            // 
            this.wspBackground.Controls.Add(this.cmdConvertToCht);
            this.wspBackground.Controls.Add(this.cmdConvertToChs);
            this.wspBackground.Controls.Add(this.boxLogs);
            this.wspBackground.Controls.Add(this.txtName_Cht);
            this.wspBackground.Controls.Add(this.lblName_Cht);
            this.wspBackground.Controls.Add(this.txtName_Chs);
            this.wspBackground.Controls.Add(this.lblName_Chs);
            this.wspBackground.Controls.Add(this.txtName);
            this.wspBackground.Controls.Add(this.lblName);
            this.wspBackground.Controls.Add(this.txtCode);
            this.wspBackground.Controls.Add(this.lblCode);
            this.wspBackground.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.wspBackground.DockPadding.All = 6;
            this.wspBackground.Location = new System.Drawing.Point(0, 28);
            this.wspBackground.Name = "wspBackground";
            this.wspBackground.Padding = new Gizmox.WebGUI.Forms.Padding(6);
            this.wspBackground.Size = new System.Drawing.Size(627, 129);
            this.wspBackground.TabIndex = 1;
            // 
            // cmdConvertToCht
            // 
            this.cmdConvertToCht.Image = new Gizmox.WebGUI.Common.Resources.IconResourceHandle(resources.GetString("cmdConvertToCht.Image"));
            this.cmdConvertToCht.Location = new System.Drawing.Point(123, 80);
            this.cmdConvertToCht.Name = "cmdConvertToCht";
            this.cmdConvertToCht.Size = new System.Drawing.Size(24, 23);
            this.cmdConvertToCht.TabIndex = 4;
            this.cmdConvertToCht.TabStop = false;
            this.cmdConvertToCht.TextImageRelation = Gizmox.WebGUI.Forms.TextImageRelation.ImageAboveText;
            this.cmdConvertToCht.Click += new System.EventHandler(this.cmdConvertToCht_Click);
            // 
            // cmdConvertToChs
            // 
            this.cmdConvertToChs.Image = new Gizmox.WebGUI.Common.Resources.IconResourceHandle(resources.GetString("cmdConvertToChs.Image"));
            this.cmdConvertToChs.Location = new System.Drawing.Point(123, 55);
            this.cmdConvertToChs.Name = "cmdConvertToChs";
            this.cmdConvertToChs.Size = new System.Drawing.Size(24, 23);
            this.cmdConvertToChs.TabIndex = 4;
            this.cmdConvertToChs.TabStop = false;
            this.cmdConvertToChs.TextImageRelation = Gizmox.WebGUI.Forms.TextImageRelation.ImageAboveText;
            this.cmdConvertToChs.Click += new System.EventHandler(this.cmdConvertToChs_Click);
            // 
            // boxLogs
            // 
            this.boxLogs.Controls.Add(this.lblModifiedOb);
            this.boxLogs.Controls.Add(this.txtModifiedOn);
            this.boxLogs.Controls.Add(this.txtModifiedBy);
            this.boxLogs.Controls.Add(this.lblModifiedBy);
            this.boxLogs.Controls.Add(this.lblCreatedBy);
            this.boxLogs.Controls.Add(this.txtCreatedBy);
            this.boxLogs.Controls.Add(this.txtCreatedOn);
            this.boxLogs.Controls.Add(this.lblCreatedOn);
            this.boxLogs.FlatStyle = Gizmox.WebGUI.Forms.FlatStyle.Flat;
            this.boxLogs.Location = new System.Drawing.Point(401, 9);
            this.boxLogs.Name = "boxLogs";
            this.boxLogs.Size = new System.Drawing.Size(214, 106);
            this.boxLogs.TabIndex = 8;
            this.boxLogs.TabStop = false;
            this.boxLogs.Text = "Logs";
            this.boxLogs.Visible = false;
            // 
            // lblModifiedOb
            // 
            this.lblModifiedOb.Location = new System.Drawing.Point(7, 61);
            this.lblModifiedOb.Name = "lblModifiedOb";
            this.lblModifiedOb.Size = new System.Drawing.Size(74, 21);
            this.lblModifiedOb.TabIndex = 4;
            this.lblModifiedOb.Text = "Modified On:";
            // 
            // txtModifiedOn
            // 
            this.txtModifiedOn.Location = new System.Drawing.Point(81, 61);
            this.txtModifiedOn.Name = "txtModifiedOn";
            this.txtModifiedOn.Size = new System.Drawing.Size(127, 21);
            this.txtModifiedOn.TabIndex = 5;
            this.txtModifiedOn.Text = "txtModifiedOn";
            // 
            // txtModifiedBy
            // 
            this.txtModifiedBy.Location = new System.Drawing.Point(81, 82);
            this.txtModifiedBy.Name = "txtModifiedBy";
            this.txtModifiedBy.Size = new System.Drawing.Size(127, 21);
            this.txtModifiedBy.TabIndex = 7;
            this.txtModifiedBy.Text = "txtModifiedBy";
            // 
            // lblModifiedBy
            // 
            this.lblModifiedBy.Location = new System.Drawing.Point(7, 82);
            this.lblModifiedBy.Name = "lblModifiedBy";
            this.lblModifiedBy.Size = new System.Drawing.Size(74, 21);
            this.lblModifiedBy.TabIndex = 6;
            this.lblModifiedBy.Text = "Modified By:";
            // 
            // lblCreatedBy
            // 
            this.lblCreatedBy.Location = new System.Drawing.Point(7, 40);
            this.lblCreatedBy.Name = "lblCreatedBy";
            this.lblCreatedBy.Size = new System.Drawing.Size(74, 21);
            this.lblCreatedBy.TabIndex = 2;
            this.lblCreatedBy.Text = "Created By:";
            // 
            // txtCreatedBy
            // 
            this.txtCreatedBy.Location = new System.Drawing.Point(81, 40);
            this.txtCreatedBy.Name = "txtCreatedBy";
            this.txtCreatedBy.Size = new System.Drawing.Size(127, 21);
            this.txtCreatedBy.TabIndex = 3;
            this.txtCreatedBy.Text = "txtCreatedBy";
            // 
            // txtCreatedOn
            // 
            this.txtCreatedOn.Location = new System.Drawing.Point(81, 19);
            this.txtCreatedOn.Name = "txtCreatedOn";
            this.txtCreatedOn.Size = new System.Drawing.Size(127, 21);
            this.txtCreatedOn.TabIndex = 1;
            this.txtCreatedOn.Text = "txtCreatedOn";
            // 
            // lblCreatedOn
            // 
            this.lblCreatedOn.Location = new System.Drawing.Point(7, 19);
            this.lblCreatedOn.Name = "lblCreatedOn";
            this.lblCreatedOn.Size = new System.Drawing.Size(74, 21);
            this.lblCreatedOn.TabIndex = 0;
            this.lblCreatedOn.Text = "Created On:";
            // 
            // txtName_Cht
            // 
            this.txtName_Cht.Location = new System.Drawing.Point(148, 82);
            this.txtName_Cht.Name = "txtName_Cht";
            this.txtName_Cht.Size = new System.Drawing.Size(247, 20);
            this.txtName_Cht.TabIndex = 7;
            // 
            // lblName_Cht
            // 
            this.lblName_Cht.Location = new System.Drawing.Point(6, 82);
            this.lblName_Cht.Name = "lblName_Cht";
            this.lblName_Cht.Size = new System.Drawing.Size(117, 21);
            this.lblName_Cht.TabIndex = 6;
            this.lblName_Cht.Text = "Name (Cht):";
            // 
            // txtName_Chs
            // 
            this.txtName_Chs.Location = new System.Drawing.Point(148, 56);
            this.txtName_Chs.Name = "txtName_Chs";
            this.txtName_Chs.ScrollBars = Gizmox.WebGUI.Forms.ScrollBars.Vertical;
            this.txtName_Chs.Size = new System.Drawing.Size(247, 20);
            this.txtName_Chs.TabIndex = 5;
            // 
            // lblName_Chs
            // 
            this.lblName_Chs.Location = new System.Drawing.Point(6, 56);
            this.lblName_Chs.Name = "lblName_Chs";
            this.lblName_Chs.Size = new System.Drawing.Size(117, 21);
            this.lblName_Chs.TabIndex = 4;
            this.lblName_Chs.Text = "Name (Chs):";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(148, 31);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(247, 20);
            this.txtName.TabIndex = 3;
            // 
            // lblName
            // 
            this.lblName.Location = new System.Drawing.Point(6, 31);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(117, 21);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Name:";
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(148, 6);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(247, 20);
            this.txtCode.TabIndex = 1;
            // 
            // lblCode
            // 
            this.lblCode.Location = new System.Drawing.Point(6, 6);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(117, 21);
            this.lblCode.TabIndex = 0;
            this.lblCode.Text = "Code:";
            // 
            // colDept
            // 
            this.colDept.ContentAlign = Gizmox.WebGUI.Forms.ExtendedHorizontalAlignment.Center;
            this.colDept.Text = "Department";
            this.colDept.Width = 100;
            // 
            // colClass
            // 
            this.colClass.ContentAlign = Gizmox.WebGUI.Forms.ExtendedHorizontalAlignment.Center;
            this.colClass.Text = "Class";
            this.colClass.Width = 100;
            // 
            // colCategory
            // 
            this.colCategory.ContentAlign = Gizmox.WebGUI.Forms.ExtendedHorizontalAlignment.Center;
            this.colCategory.Text = "Cateogry";
            this.colCategory.Width = 100;
            // 
            // colCategoryId
            // 
            this.colCategoryId.Text = "Category Id";
            this.colCategoryId.Visible = false;
            this.colCategoryId.Width = 150;
            // 
            // DeptRecord
            // 
            this.Controls.Add(this.wspBackground);
            this.Controls.Add(this.ansToolbar);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Size = new System.Drawing.Size(627, 157);
            this.StartPosition = Gizmox.WebGUI.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dept Record";
            this.Load += new System.EventHandler(this.SupplierRecord_Load);
            this.wspBackground.ResumeLayout(false);
            this.boxLogs.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Gizmox.WebGUI.Forms.ToolBar ansToolbar;
        private Gizmox.WebGUI.Forms.Panel wspBackground;
        private Gizmox.WebGUI.Forms.TextBox txtCode;
        private Gizmox.WebGUI.Forms.Label lblCode;
        private Gizmox.WebGUI.Forms.TextBox txtName_Cht;
        private Gizmox.WebGUI.Forms.Label lblName_Cht;
        private Gizmox.WebGUI.Forms.TextBox txtName_Chs;
        private Gizmox.WebGUI.Forms.Label lblName_Chs;
        private Gizmox.WebGUI.Forms.TextBox txtName;
        private Gizmox.WebGUI.Forms.Label lblName;
        private Gizmox.WebGUI.Forms.ToolTip toolTip1;
        private Gizmox.WebGUI.Forms.ColumnHeader colDept;
        private Gizmox.WebGUI.Forms.ColumnHeader colClass;
        private Gizmox.WebGUI.Forms.ColumnHeader colCategory;
        private Gizmox.WebGUI.Forms.ColumnHeader colCategoryId;
        private Gizmox.WebGUI.Forms.GroupBox boxLogs;
        private Gizmox.WebGUI.Forms.Label lblModifiedOb;
        private Gizmox.WebGUI.Forms.Label txtModifiedOn;
        private Gizmox.WebGUI.Forms.Label txtModifiedBy;
        private Gizmox.WebGUI.Forms.Label lblModifiedBy;
        private Gizmox.WebGUI.Forms.Label lblCreatedBy;
        private Gizmox.WebGUI.Forms.Label txtCreatedBy;
        private Gizmox.WebGUI.Forms.Label txtCreatedOn;
        private Gizmox.WebGUI.Forms.Label lblCreatedOn;
        private Gizmox.WebGUI.Forms.Button cmdConvertToCht;
        private Gizmox.WebGUI.Forms.Button cmdConvertToChs;


    }
}