namespace xPort5.Order.Coding.Product.Supplier
{
    partial class SupplierList
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
            this.ansSupplier = new Gizmox.WebGUI.Forms.ToolBar();
            this.lvwSupplier = new Gizmox.WebGUI.Forms.ListView();
            this.colLN = new Gizmox.WebGUI.Forms.ColumnHeader();
            this.colProductSupplierId = new Gizmox.WebGUI.Forms.ColumnHeader();
            this.colSupplier = new Gizmox.WebGUI.Forms.ColumnHeader();
            this.colRefNumber = new Gizmox.WebGUI.Forms.ColumnHeader();
            this.colFCL = new Gizmox.WebGUI.Forms.ColumnHeader();
            this.colLCL = new Gizmox.WebGUI.Forms.ColumnHeader();
            this.colUnitCode = new Gizmox.WebGUI.Forms.ColumnHeader();
            this.colCurrency = new Gizmox.WebGUI.Forms.ColumnHeader();
            this.colNotes = new Gizmox.WebGUI.Forms.ColumnHeader();
            this.colModifiedOn = new Gizmox.WebGUI.Forms.ColumnHeader();
            this.colModifiedBy = new Gizmox.WebGUI.Forms.ColumnHeader();
            this.toolTip1 = new Gizmox.WebGUI.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // ansSupplier
            // 
            this.ansSupplier.Anchor = Gizmox.WebGUI.Forms.AnchorStyles.None;
            this.ansSupplier.Appearance = Gizmox.WebGUI.Forms.ToolBarAppearance.Normal;
            this.ansSupplier.Dock = Gizmox.WebGUI.Forms.DockStyle.Top;
            this.ansSupplier.DragHandle = true;
            this.ansSupplier.DropDownArrows = false;
            this.ansSupplier.ImageList = null;
            this.ansSupplier.Location = new System.Drawing.Point(0, 0);
            this.ansSupplier.MenuHandle = true;
            this.ansSupplier.Name = "ansSupplier";
            this.ansSupplier.RightToLeft = Gizmox.WebGUI.Forms.RightToLeft.No;
            this.ansSupplier.ShowToolTips = true;
            this.ansSupplier.TabIndex = 0;
            // 
            // lvwSupplier
            // 
            this.lvwSupplier.Anchor = Gizmox.WebGUI.Forms.AnchorStyles.None;
            this.lvwSupplier.BorderWidth = 0;
            this.lvwSupplier.Columns.AddRange(new Gizmox.WebGUI.Forms.ColumnHeader[] {
            this.colLN,
            this.colProductSupplierId,
            this.colSupplier,
            this.colRefNumber,
            this.colFCL,
            this.colLCL,
            this.colUnitCode,
            this.colCurrency,
            this.colNotes,
            this.colModifiedOn,
            this.colModifiedBy});
            this.lvwSupplier.DataMember = null;
            this.lvwSupplier.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.lvwSupplier.ItemsPerPage = 20;
            this.lvwSupplier.Location = new System.Drawing.Point(0, 28);
            this.lvwSupplier.Name = "lvwSupplier";
            this.lvwSupplier.Size = new System.Drawing.Size(762, 278);
            this.lvwSupplier.TabIndex = 1;
            this.lvwSupplier.DoubleClick += new System.EventHandler(this.lvwSupplier_DoubleClick);
            // 
            // colLN
            // 
            this.colLN.ContentAlign = Gizmox.WebGUI.Forms.ExtendedHorizontalAlignment.Center;
            this.colLN.Image = null;
            this.colLN.Text = "#";
            this.colLN.Width = 40;
            // 
            // colProductSupplierId
            // 
            this.colProductSupplierId.Image = null;
            this.colProductSupplierId.Text = "";
            this.colProductSupplierId.Visible = false;
            this.colProductSupplierId.Width = 150;
            // 
            // colSupplier
            // 
            this.colSupplier.ContentAlign = Gizmox.WebGUI.Forms.ExtendedHorizontalAlignment.Center;
            this.colSupplier.Image = null;
            this.colSupplier.Text = "Supplier";
            this.colSupplier.Width = 150;
            // 
            // colRefNumber
            // 
            this.colRefNumber.ContentAlign = Gizmox.WebGUI.Forms.ExtendedHorizontalAlignment.Center;
            this.colRefNumber.Image = null;
            this.colRefNumber.Text = "Ref. No.";
            this.colRefNumber.Width = 80;
            // 
            // colFCL
            // 
            this.colFCL.ContentAlign = Gizmox.WebGUI.Forms.ExtendedHorizontalAlignment.Center;
            this.colFCL.Image = null;
            this.colFCL.Text = "FCL";
            this.colFCL.TextAlign = Gizmox.WebGUI.Forms.HorizontalAlignment.Right;
            this.colFCL.Width = 60;
            // 
            // colLCL
            // 
            this.colLCL.ContentAlign = Gizmox.WebGUI.Forms.ExtendedHorizontalAlignment.Center;
            this.colLCL.Image = null;
            this.colLCL.Text = "LCL";
            this.colLCL.TextAlign = Gizmox.WebGUI.Forms.HorizontalAlignment.Right;
            this.colLCL.Width = 60;
            // 
            // colUnitCode
            // 
            this.colUnitCode.ContentAlign = Gizmox.WebGUI.Forms.ExtendedHorizontalAlignment.Center;
            this.colUnitCode.Image = null;
            this.colUnitCode.Text = "Unit Cost";
            this.colUnitCode.TextAlign = Gizmox.WebGUI.Forms.HorizontalAlignment.Right;
            this.colUnitCode.Width = 60;
            // 
            // colCurrency
            // 
            this.colCurrency.ContentAlign = Gizmox.WebGUI.Forms.ExtendedHorizontalAlignment.Center;
            this.colCurrency.Image = null;
            this.colCurrency.Text = "Currency";
            this.colCurrency.Width = 60;
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
            // SupplierList
            // 
            this.Controls.Add(this.lvwSupplier);
            this.Controls.Add(this.ansSupplier);
            this.Size = new System.Drawing.Size(762, 306);
            this.Text = "ArticlePackage";
            this.ResumeLayout(false);

        }

        #endregion

        private Gizmox.WebGUI.Forms.ToolBar ansSupplier;
        private Gizmox.WebGUI.Forms.ListView lvwSupplier;
        private Gizmox.WebGUI.Forms.ColumnHeader colLN;
        private Gizmox.WebGUI.Forms.ColumnHeader colSupplier;
        private Gizmox.WebGUI.Forms.ColumnHeader colRefNumber;
        private Gizmox.WebGUI.Forms.ColumnHeader colFCL;
        private Gizmox.WebGUI.Forms.ColumnHeader colLCL;
        private Gizmox.WebGUI.Forms.ColumnHeader colUnitCode;
        private Gizmox.WebGUI.Forms.ColumnHeader colModifiedOn;
        private Gizmox.WebGUI.Forms.ColumnHeader colModifiedBy;
        private Gizmox.WebGUI.Forms.ColumnHeader colCurrency;
        private Gizmox.WebGUI.Forms.ToolTip toolTip1;
        private Gizmox.WebGUI.Forms.ColumnHeader colNotes;
        private Gizmox.WebGUI.Forms.ColumnHeader colProductSupplierId;


    }
}