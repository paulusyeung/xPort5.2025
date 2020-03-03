namespace xPort5.Order.Coding.Product.Package
{
    partial class PackageList
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
            this.ansPackage = new Gizmox.WebGUI.Forms.ToolBar();
            this.lvwPackage = new Gizmox.WebGUI.Forms.ListView();
            this.colLN = new Gizmox.WebGUI.Forms.ColumnHeader();
            this.colProductPackageId = new Gizmox.WebGUI.Forms.ColumnHeader();
            this.colDescription = new Gizmox.WebGUI.Forms.ColumnHeader();
            this.colUnit = new Gizmox.WebGUI.Forms.ColumnHeader();
            this.colInnerBox = new Gizmox.WebGUI.Forms.ColumnHeader();
            this.colOuterBox = new Gizmox.WebGUI.Forms.ColumnHeader();
            this.colVolumn = new Gizmox.WebGUI.Forms.ColumnHeader();
            this.colGross = new Gizmox.WebGUI.Forms.ColumnHeader();
            this.colNet = new Gizmox.WebGUI.Forms.ColumnHeader();
            this.colModifiedOn = new Gizmox.WebGUI.Forms.ColumnHeader();
            this.colModifiedBy = new Gizmox.WebGUI.Forms.ColumnHeader();
            this.toolTip1 = new Gizmox.WebGUI.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // ansPackage
            // 
            this.ansPackage.Anchor = Gizmox.WebGUI.Forms.AnchorStyles.None;
            this.ansPackage.Appearance = Gizmox.WebGUI.Forms.ToolBarAppearance.Normal;
            this.ansPackage.Dock = Gizmox.WebGUI.Forms.DockStyle.Top;
            this.ansPackage.DragHandle = true;
            this.ansPackage.DropDownArrows = false;
            this.ansPackage.ImageList = null;
            this.ansPackage.Location = new System.Drawing.Point(0, 0);
            this.ansPackage.MenuHandle = true;
            this.ansPackage.Name = "ansPackage";
            this.ansPackage.RightToLeft = Gizmox.WebGUI.Forms.RightToLeft.No;
            this.ansPackage.ShowToolTips = true;
            this.ansPackage.TabIndex = 0;
            // 
            // lvwPackage
            // 
            this.lvwPackage.Anchor = Gizmox.WebGUI.Forms.AnchorStyles.None;
            this.lvwPackage.BorderWidth = 0;
            this.lvwPackage.Columns.AddRange(new Gizmox.WebGUI.Forms.ColumnHeader[] {
            this.colLN,
            this.colProductPackageId,
            this.colDescription,
            this.colUnit,
            this.colInnerBox,
            this.colOuterBox,
            this.colVolumn,
            this.colGross,
            this.colNet,
            this.colModifiedOn,
            this.colModifiedBy});
            this.lvwPackage.DataMember = null;
            this.lvwPackage.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.lvwPackage.ItemsPerPage = 20;
            this.lvwPackage.Location = new System.Drawing.Point(0, 28);
            this.lvwPackage.Name = "lvwPackage";
            this.lvwPackage.Size = new System.Drawing.Size(762, 278);
            this.lvwPackage.TabIndex = 1;
            this.lvwPackage.DoubleClick += new System.EventHandler(this.lvwPackage_DoubleClick);
            // 
            // colLN
            // 
            this.colLN.ContentAlign = Gizmox.WebGUI.Forms.ExtendedHorizontalAlignment.Center;
            this.colLN.Image = null;
            this.colLN.Text = "#";
            this.colLN.Width = 40;
            // 
            // colProductPackageId
            // 
            this.colProductPackageId.Image = null;
            this.colProductPackageId.Text = "";
            this.colProductPackageId.Visible = false;
            this.colProductPackageId.Width = 150;
            // 
            // colDescription
            // 
            this.colDescription.ContentAlign = Gizmox.WebGUI.Forms.ExtendedHorizontalAlignment.Center;
            this.colDescription.Image = null;
            this.colDescription.Text = "Description";
            this.colDescription.Width = 150;
            // 
            // colUnit
            // 
            this.colUnit.ContentAlign = Gizmox.WebGUI.Forms.ExtendedHorizontalAlignment.Center;
            this.colUnit.Image = null;
            this.colUnit.Text = "Unit";
            this.colUnit.Width = 40;
            // 
            // colInnerBox
            // 
            this.colInnerBox.ContentAlign = Gizmox.WebGUI.Forms.ExtendedHorizontalAlignment.Center;
            this.colInnerBox.Image = null;
            this.colInnerBox.Text = "Inner Box";
            this.colInnerBox.TextAlign = Gizmox.WebGUI.Forms.HorizontalAlignment.Right;
            this.colInnerBox.Width = 60;
            // 
            // colOuterBox
            // 
            this.colOuterBox.ContentAlign = Gizmox.WebGUI.Forms.ExtendedHorizontalAlignment.Center;
            this.colOuterBox.Image = null;
            this.colOuterBox.Text = "Outer Box";
            this.colOuterBox.TextAlign = Gizmox.WebGUI.Forms.HorizontalAlignment.Right;
            this.colOuterBox.Width = 60;
            // 
            // colVolumn
            // 
            this.colVolumn.ContentAlign = Gizmox.WebGUI.Forms.ExtendedHorizontalAlignment.Center;
            this.colVolumn.Image = null;
            this.colVolumn.Text = "Volumn";
            this.colVolumn.TextAlign = Gizmox.WebGUI.Forms.HorizontalAlignment.Right;
            this.colVolumn.Width = 60;
            // 
            // colGross
            // 
            this.colGross.ContentAlign = Gizmox.WebGUI.Forms.ExtendedHorizontalAlignment.Center;
            this.colGross.Image = null;
            this.colGross.Text = "Gross";
            this.colGross.TextAlign = Gizmox.WebGUI.Forms.HorizontalAlignment.Right;
            this.colGross.Width = 60;
            // 
            // colNet
            // 
            this.colNet.ContentAlign = Gizmox.WebGUI.Forms.ExtendedHorizontalAlignment.Center;
            this.colNet.Image = null;
            this.colNet.Text = "Net";
            this.colNet.TextAlign = Gizmox.WebGUI.Forms.HorizontalAlignment.Right;
            this.colNet.Width = 60;
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
            // PackageList
            // 
            this.Controls.Add(this.lvwPackage);
            this.Controls.Add(this.ansPackage);
            this.Size = new System.Drawing.Size(762, 306);
            this.Text = "ArticlePackage";
            this.ResumeLayout(false);

        }

        #endregion

        private Gizmox.WebGUI.Forms.ToolBar ansPackage;
        private Gizmox.WebGUI.Forms.ListView lvwPackage;
        private Gizmox.WebGUI.Forms.ColumnHeader colLN;
        private Gizmox.WebGUI.Forms.ColumnHeader colDescription;
        private Gizmox.WebGUI.Forms.ColumnHeader colUnit;
        private Gizmox.WebGUI.Forms.ColumnHeader colInnerBox;
        private Gizmox.WebGUI.Forms.ColumnHeader colOuterBox;
        private Gizmox.WebGUI.Forms.ColumnHeader colVolumn;
        private Gizmox.WebGUI.Forms.ColumnHeader colModifiedOn;
        private Gizmox.WebGUI.Forms.ColumnHeader colModifiedBy;
        private Gizmox.WebGUI.Forms.ColumnHeader colGross;
        private Gizmox.WebGUI.Forms.ColumnHeader colNet;
        private Gizmox.WebGUI.Forms.ToolTip toolTip1;
        private Gizmox.WebGUI.Forms.ColumnHeader colProductPackageId;


    }
}