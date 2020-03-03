namespace xPort5.Order.Coding.Supplier.Address
{
    partial class AddressList
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

        #region Visual WebGui UserControl Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Gizmox.WebGUI.Common.Resources.IconResourceHandle iconResourceHandle1 = new Gizmox.WebGUI.Common.Resources.IconResourceHandle();
            this.ansAddress = new Gizmox.WebGUI.Forms.ToolBar();
            this.lvwAddress = new Gizmox.WebGUI.Forms.ListView();
            this.colLN = new Gizmox.WebGUI.Forms.ColumnHeader();
            this.colUserAddressId = new Gizmox.WebGUI.Forms.ColumnHeader();
            this.colAddressName = new Gizmox.WebGUI.Forms.ColumnHeader();
            this.colMailing = new Gizmox.WebGUI.Forms.ColumnHeader();
            this.colAddress = new Gizmox.WebGUI.Forms.ColumnHeader();
            this.colPhone1 = new Gizmox.WebGUI.Forms.ColumnHeader();
            this.colPhone2 = new Gizmox.WebGUI.Forms.ColumnHeader();
            this.colPhone3 = new Gizmox.WebGUI.Forms.ColumnHeader();
            this.colPhone4 = new Gizmox.WebGUI.Forms.ColumnHeader();
            this.colPhone5 = new Gizmox.WebGUI.Forms.ColumnHeader();
            this.colNotes = new Gizmox.WebGUI.Forms.ColumnHeader();
            this.colModifiedOn = new Gizmox.WebGUI.Forms.ColumnHeader();
            this.colModifiedBy = new Gizmox.WebGUI.Forms.ColumnHeader();
            this.toolTip1 = new Gizmox.WebGUI.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // ansAddress
            // 
            this.ansAddress.Anchor = Gizmox.WebGUI.Forms.AnchorStyles.None;
            this.ansAddress.Appearance = Gizmox.WebGUI.Forms.ToolBarAppearance.Normal;
            this.ansAddress.Dock = Gizmox.WebGUI.Forms.DockStyle.Top;
            this.ansAddress.DragHandle = true;
            this.ansAddress.DropDownArrows = false;
            this.ansAddress.ImageList = null;
            this.ansAddress.Location = new System.Drawing.Point(0, 0);
            this.ansAddress.MenuHandle = true;
            this.ansAddress.Name = "ansAddress";
            this.ansAddress.RightToLeft = Gizmox.WebGUI.Forms.RightToLeft.No;
            this.ansAddress.ShowToolTips = true;
            this.ansAddress.TabIndex = 0;
            // 
            // lvwAddress
            // 
            this.lvwAddress.Anchor = Gizmox.WebGUI.Forms.AnchorStyles.None;
            this.lvwAddress.BorderWidth = 0;
            this.lvwAddress.Columns.AddRange(new Gizmox.WebGUI.Forms.ColumnHeader[] {
            this.colLN,
            this.colUserAddressId,
            this.colAddressName,
            this.colMailing,
            this.colAddress,
            this.colPhone1,
            this.colPhone2,
            this.colPhone3,
            this.colPhone4,
            this.colPhone5,
            this.colNotes,
            this.colModifiedOn,
            this.colModifiedBy});
            this.lvwAddress.DataMember = null;
            this.lvwAddress.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.lvwAddress.ItemsPerPage = 20;
            this.lvwAddress.Location = new System.Drawing.Point(0, 28);
            this.lvwAddress.Name = "lvwAddress";
            this.lvwAddress.Size = new System.Drawing.Size(1028, 278);
            this.lvwAddress.TabIndex = 1;
            this.lvwAddress.DoubleClick += new System.EventHandler(this.lvwSupplier_DoubleClick);
            // 
            // colLN
            // 
            this.colLN.ContentAlign = Gizmox.WebGUI.Forms.ExtendedHorizontalAlignment.Center;
            this.colLN.Image = null;
            this.colLN.Text = "#";
            this.colLN.Width = 40;
            // 
            // colUserAddressId
            // 
            this.colUserAddressId.Image = null;
            this.colUserAddressId.Text = "UserAddressId";
            this.colUserAddressId.Visible = false;
            this.colUserAddressId.Width = 150;
            // 
            // colAddressName
            // 
            this.colAddressName.ContentAlign = Gizmox.WebGUI.Forms.ExtendedHorizontalAlignment.Center;
            this.colAddressName.Image = null;
            this.colAddressName.Text = "Address";
            this.colAddressName.Width = 80;
            // 
            // colMailing
            // 
            this.colMailing.ContentAlign = Gizmox.WebGUI.Forms.ExtendedHorizontalAlignment.Center;
            iconResourceHandle1.File = "16x16.mailing_off_16.png";
            this.colMailing.Image = iconResourceHandle1;
            this.colMailing.Text = "";
            this.colMailing.Type = Gizmox.WebGUI.Forms.ListViewColumnType.Icon;
            this.colMailing.Width = 24;
            // 
            // colAddress
            // 
            this.colAddress.ContentAlign = Gizmox.WebGUI.Forms.ExtendedHorizontalAlignment.Center;
            this.colAddress.Image = null;
            this.colAddress.Text = "";
            this.colAddress.Width = 150;
            // 
            // colPhone1
            // 
            this.colPhone1.ContentAlign = Gizmox.WebGUI.Forms.ExtendedHorizontalAlignment.Center;
            this.colPhone1.Image = null;
            this.colPhone1.Text = "Phone 1";
            this.colPhone1.Width = 80;
            // 
            // colPhone2
            // 
            this.colPhone2.ContentAlign = Gizmox.WebGUI.Forms.ExtendedHorizontalAlignment.Center;
            this.colPhone2.Image = null;
            this.colPhone2.Text = "Phone 2";
            this.colPhone2.Width = 80;
            // 
            // colPhone3
            // 
            this.colPhone3.ContentAlign = Gizmox.WebGUI.Forms.ExtendedHorizontalAlignment.Center;
            this.colPhone3.Image = null;
            this.colPhone3.Text = "Phone 3";
            this.colPhone3.Width = 80;
            // 
            // colPhone4
            // 
            this.colPhone4.ContentAlign = Gizmox.WebGUI.Forms.ExtendedHorizontalAlignment.Center;
            this.colPhone4.Image = null;
            this.colPhone4.Text = "Phone 4";
            this.colPhone4.Width = 80;
            // 
            // colPhone5
            // 
            this.colPhone5.ContentAlign = Gizmox.WebGUI.Forms.ExtendedHorizontalAlignment.Center;
            this.colPhone5.Image = null;
            this.colPhone5.Text = "Phone 5";
            this.colPhone5.Width = 80;
            // 
            // colNotes
            // 
            this.colNotes.ContentAlign = Gizmox.WebGUI.Forms.ExtendedHorizontalAlignment.Center;
            this.colNotes.Image = null;
            this.colNotes.Text = "Notes";
            this.colNotes.Width = 150;
            // 
            // colModifiedOn
            // 
            this.colModifiedOn.ContentAlign = Gizmox.WebGUI.Forms.ExtendedHorizontalAlignment.Center;
            this.colModifiedOn.Image = null;
            this.colModifiedOn.Text = "Modified On";
            this.colModifiedOn.Width = 100;
            // 
            // colModifiedBy
            // 
            this.colModifiedBy.ContentAlign = Gizmox.WebGUI.Forms.ExtendedHorizontalAlignment.Center;
            this.colModifiedBy.Image = null;
            this.colModifiedBy.Text = "Modified By";
            this.colModifiedBy.Width = 80;
            // 
            // AddressList
            // 
            this.Controls.Add(this.lvwAddress);
            this.Controls.Add(this.ansAddress);
            this.Size = new System.Drawing.Size(1028, 306);
            this.Text = "ArticlePackage";
            this.ResumeLayout(false);

        }

        #endregion

        private Gizmox.WebGUI.Forms.ToolBar ansAddress;
        private Gizmox.WebGUI.Forms.ListView lvwAddress;
        private Gizmox.WebGUI.Forms.ColumnHeader colLN;
        private Gizmox.WebGUI.Forms.ColumnHeader colAddress;
        private Gizmox.WebGUI.Forms.ColumnHeader colPhone1;
        private Gizmox.WebGUI.Forms.ColumnHeader colPhone2;
        private Gizmox.WebGUI.Forms.ColumnHeader colPhone3;
        private Gizmox.WebGUI.Forms.ColumnHeader colPhone4;
        private Gizmox.WebGUI.Forms.ColumnHeader colModifiedOn;
        private Gizmox.WebGUI.Forms.ColumnHeader colModifiedBy;
        private Gizmox.WebGUI.Forms.ColumnHeader colPhone5;
        private Gizmox.WebGUI.Forms.ToolTip toolTip1;
        private Gizmox.WebGUI.Forms.ColumnHeader colAddressName;
        private Gizmox.WebGUI.Forms.ColumnHeader colUserAddressId;
        private Gizmox.WebGUI.Forms.ColumnHeader colMailing;
        private Gizmox.WebGUI.Forms.ColumnHeader colNotes;


    }
}