namespace xPort5.Admin.Coding.City
{
    partial class CityRecord
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
            Gizmox.WebGUI.Common.Resources.IconResourceHandle iconResourceHandle3 = new Gizmox.WebGUI.Common.Resources.IconResourceHandle();
            Gizmox.WebGUI.Common.Resources.IconResourceHandle iconResourceHandle4 = new Gizmox.WebGUI.Common.Resources.IconResourceHandle();
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
            this.colDept = new Gizmox.WebGUI.Forms.ColumnHeader();
            this.colClass = new Gizmox.WebGUI.Forms.ColumnHeader();
            this.colCategory = new Gizmox.WebGUI.Forms.ColumnHeader();
            this.colCategoryId = new Gizmox.WebGUI.Forms.ColumnHeader();
            this.toolTip1 = new Gizmox.WebGUI.Forms.ToolTip(this.components);
            this.lblCountry = new Gizmox.WebGUI.Forms.Label();
            this.lblProvince = new Gizmox.WebGUI.Forms.Label();
            this.cboCountry = new Gizmox.WebGUI.Forms.ComboBox();
            this.cboProvince = new Gizmox.WebGUI.Forms.ComboBox();
            this.lblPhoneCode = new Gizmox.WebGUI.Forms.Label();
            this.txtPhoneCode = new Gizmox.WebGUI.Forms.TextBox();
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
            // wspBackground
            // 
            this.wspBackground.Anchor = Gizmox.WebGUI.Forms.AnchorStyles.None;
            this.wspBackground.Controls.Add(this.txtPhoneCode);
            this.wspBackground.Controls.Add(this.lblPhoneCode);
            this.wspBackground.Controls.Add(this.cboProvince);
            this.wspBackground.Controls.Add(this.cboCountry);
            this.wspBackground.Controls.Add(this.lblProvince);
            this.wspBackground.Controls.Add(this.lblCountry);
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
            this.wspBackground.Size = new System.Drawing.Size(627, 207);
            this.wspBackground.TabIndex = 1;
            // 
            // cmdConvertToCht
            // 
            iconResourceHandle3.File = "16x16.lightning.png";
            this.cmdConvertToCht.Image = iconResourceHandle3;
            this.cmdConvertToCht.Location = new System.Drawing.Point(72, 134);
            this.cmdConvertToCht.Name = "cmdConvertToCht";
            this.cmdConvertToCht.Size = new System.Drawing.Size(24, 23);
            this.cmdConvertToCht.TabIndex = 12;
            this.cmdConvertToCht.TabStop = false;
            this.cmdConvertToCht.TextImageRelation = Gizmox.WebGUI.Forms.TextImageRelation.ImageAboveText;
            this.cmdConvertToCht.Click += new System.EventHandler(this.cmdConvertToCht_Click);
            // 
            // cmdConvertToChs
            // 
            iconResourceHandle4.File = "16x16.lightning.png";
            this.cmdConvertToChs.Image = iconResourceHandle4;
            this.cmdConvertToChs.Location = new System.Drawing.Point(72, 109);
            this.cmdConvertToChs.Name = "cmdConvertToChs";
            this.cmdConvertToChs.Size = new System.Drawing.Size(24, 23);
            this.cmdConvertToChs.TabIndex = 9;
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
            this.boxLogs.TabIndex = 16;
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
            this.txtName_Cht.Location = new System.Drawing.Point(98, 136);
            this.txtName_Cht.Name = "txtName_Cht";
            this.txtName_Cht.Size = new System.Drawing.Size(297, 20);
            this.txtName_Cht.TabIndex = 13;
            // 
            // lblName_Cht
            // 
            this.lblName_Cht.Location = new System.Drawing.Point(6, 136);
            this.lblName_Cht.Name = "lblName_Cht";
            this.lblName_Cht.Size = new System.Drawing.Size(90, 21);
            this.lblName_Cht.TabIndex = 11;
            this.lblName_Cht.Text = "Name (Cht):";
            // 
            // txtName_Chs
            // 
            this.txtName_Chs.Location = new System.Drawing.Point(98, 110);
            this.txtName_Chs.Name = "txtName_Chs";
            this.txtName_Chs.ScrollBars = Gizmox.WebGUI.Forms.ScrollBars.Vertical;
            this.txtName_Chs.Size = new System.Drawing.Size(297, 20);
            this.txtName_Chs.TabIndex = 10;
            // 
            // lblName_Chs
            // 
            this.lblName_Chs.Location = new System.Drawing.Point(6, 110);
            this.lblName_Chs.Name = "lblName_Chs";
            this.lblName_Chs.Size = new System.Drawing.Size(90, 21);
            this.lblName_Chs.TabIndex = 8;
            this.lblName_Chs.Text = "Name (Chs):";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(98, 85);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(297, 20);
            this.txtName.TabIndex = 7;
            // 
            // lblName
            // 
            this.lblName.Location = new System.Drawing.Point(6, 85);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(90, 21);
            this.lblName.TabIndex = 6;
            this.lblName.Text = "Name:";
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(98, 6);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(297, 20);
            this.txtCode.TabIndex = 1;
            // 
            // lblCode
            // 
            this.lblCode.Location = new System.Drawing.Point(6, 6);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(90, 21);
            this.lblCode.TabIndex = 0;
            this.lblCode.Text = "Code:";
            // 
            // colDept
            // 
            this.colDept.ContentAlign = Gizmox.WebGUI.Forms.ExtendedHorizontalAlignment.Center;
            this.colDept.Image = null;
            this.colDept.Text = "Department";
            this.colDept.Width = 100;
            // 
            // colClass
            // 
            this.colClass.ContentAlign = Gizmox.WebGUI.Forms.ExtendedHorizontalAlignment.Center;
            this.colClass.Image = null;
            this.colClass.Text = "Class";
            this.colClass.Width = 100;
            // 
            // colCategory
            // 
            this.colCategory.ContentAlign = Gizmox.WebGUI.Forms.ExtendedHorizontalAlignment.Center;
            this.colCategory.Image = null;
            this.colCategory.Text = "Cateogry";
            this.colCategory.Width = 100;
            // 
            // colCategoryId
            // 
            this.colCategoryId.Image = null;
            this.colCategoryId.Text = "Category Id";
            this.colCategoryId.Visible = false;
            this.colCategoryId.Width = 150;
            // 
            // lblCountry
            // 
            this.lblCountry.Location = new System.Drawing.Point(6, 31);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(90, 21);
            this.lblCountry.TabIndex = 2;
            this.lblCountry.Text = "Country:";
            // 
            // lblProvince
            // 
            this.lblProvince.Location = new System.Drawing.Point(6, 58);
            this.lblProvince.Name = "lblProvince";
            this.lblProvince.Size = new System.Drawing.Size(90, 21);
            this.lblProvince.TabIndex = 4;
            this.lblProvince.Text = "Province:";
            // 
            // cboCountry
            // 
            this.cboCountry.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.Fixed3D;
            this.cboCountry.DropDownStyle = Gizmox.WebGUI.Forms.ComboBoxStyle.DropDownList;
            this.cboCountry.Location = new System.Drawing.Point(98, 31);
            this.cboCountry.Name = "cboCountry";
            this.cboCountry.Size = new System.Drawing.Size(297, 21);
            this.cboCountry.TabIndex = 3;
            // 
            // cboProvince
            // 
            this.cboProvince.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.Fixed3D;
            this.cboProvince.DropDownStyle = Gizmox.WebGUI.Forms.ComboBoxStyle.DropDownList;
            this.cboProvince.Location = new System.Drawing.Point(98, 58);
            this.cboProvince.Name = "cboProvince";
            this.cboProvince.Size = new System.Drawing.Size(297, 21);
            this.cboProvince.TabIndex = 5;
            // 
            // lblPhoneCode
            // 
            this.lblPhoneCode.Location = new System.Drawing.Point(6, 161);
            this.lblPhoneCode.Name = "lblPhoneCode";
            this.lblPhoneCode.Size = new System.Drawing.Size(90, 21);
            this.lblPhoneCode.TabIndex = 14;
            this.lblPhoneCode.Text = "Area Code:";
            // 
            // txtPhoneCode
            // 
            this.txtPhoneCode.Location = new System.Drawing.Point(98, 161);
            this.txtPhoneCode.Name = "txtPhoneCode";
            this.txtPhoneCode.Size = new System.Drawing.Size(297, 20);
            this.txtPhoneCode.TabIndex = 15;
            // 
            // CityRecord
            // 
            this.Controls.Add(this.wspBackground);
            this.Controls.Add(this.ansToolbar);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Size = new System.Drawing.Size(627, 235);
            this.StartPosition = Gizmox.WebGUI.Forms.FormStartPosition.CenterScreen;
            this.Text = "City Record";
            this.Load += new System.EventHandler(this.SupplierRecord_Load);
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
        private Gizmox.WebGUI.Forms.Label lblProvince;
        private Gizmox.WebGUI.Forms.Label lblCountry;
        private Gizmox.WebGUI.Forms.TextBox txtPhoneCode;
        private Gizmox.WebGUI.Forms.Label lblPhoneCode;
        private Gizmox.WebGUI.Forms.ComboBox cboProvince;
        private Gizmox.WebGUI.Forms.ComboBox cboCountry;


    }
}