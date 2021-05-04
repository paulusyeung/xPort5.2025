namespace xPort5.Order.PurchaseContract.Items
{
    partial class ItemsList
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
            this.ansItems = new Gizmox.WebGUI.Forms.ToolBar();
            this.flpImageList = new Gizmox.WebGUI.Forms.FlowLayoutPanel();
            this.lvwItems = new Gizmox.WebGUI.Forms.ListView();
            this.colArticleCode = new Gizmox.WebGUI.Forms.ColumnHeader();
            this.colItemId = new Gizmox.WebGUI.Forms.ColumnHeader();
            this.colSuppShippingId = new Gizmox.WebGUI.Forms.ColumnHeader();
            this.colCustShippingId = new Gizmox.WebGUI.Forms.ColumnHeader();
            this.colLineNum = new Gizmox.WebGUI.Forms.ColumnHeader();
            this.colPackageCode = new Gizmox.WebGUI.Forms.ColumnHeader();
            this.colCustRef = new Gizmox.WebGUI.Forms.ColumnHeader();
            this.colSupplierRef = new Gizmox.WebGUI.Forms.ColumnHeader();
            this.colDescription = new Gizmox.WebGUI.Forms.ColumnHeader();
            this.colQty = new Gizmox.WebGUI.Forms.ColumnHeader();
            this.colUnit = new Gizmox.WebGUI.Forms.ColumnHeader();
            this.colAmount = new Gizmox.WebGUI.Forms.ColumnHeader();
            this.colCurrency = new Gizmox.WebGUI.Forms.ColumnHeader();
            this.toolTip1 = new Gizmox.WebGUI.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // ansItems
            // 
            this.ansItems.Anchor = Gizmox.WebGUI.Forms.AnchorStyles.None;
            this.ansItems.Appearance = Gizmox.WebGUI.Forms.ToolBarAppearance.Normal;
            this.ansItems.Dock = Gizmox.WebGUI.Forms.DockStyle.Top;
            this.ansItems.DragHandle = false;
            this.ansItems.DropDownArrows = false;
            this.ansItems.ImageList = null;
            this.ansItems.Location = new System.Drawing.Point(0, 0);
            this.ansItems.MenuHandle = false;
            this.ansItems.Name = "ansItems";
            this.ansItems.RightToLeft = Gizmox.WebGUI.Forms.RightToLeft.No;
            this.ansItems.ShowToolTips = true;
            this.ansItems.TabIndex = 0;
            // 
            // flpImageList
            // 
            this.flpImageList.FlowDirection = Gizmox.WebGUI.Forms.FlowDirection.LeftToRight;
            this.flpImageList.Location = new System.Drawing.Point(407, 53);
            this.flpImageList.Name = "flpImageList";
            this.flpImageList.Size = new System.Drawing.Size(278, 200);
            this.flpImageList.TabIndex = 2;
            this.flpImageList.WrapContents = false;
            // 
            // lvwItems
            // 
            this.lvwItems.BorderWidth = 0;
            this.lvwItems.Columns.AddRange(new Gizmox.WebGUI.Forms.ColumnHeader[] {
            this.colArticleCode,
            this.colItemId,
            this.colLineNum,
            this.colPackageCode,
            this.colCustRef,
            this.colSupplierRef,
            this.colDescription,
            this.colQty,
            this.colUnit,
            this.colAmount,
            this.colCurrency});
            this.lvwItems.DataMember = null;
            this.lvwItems.ItemsPerPage = 20;
            this.lvwItems.Location = new System.Drawing.Point(77, 53);
            this.lvwItems.Name = "lvwItems";
            this.lvwItems.Size = new System.Drawing.Size(300, 200);
            this.lvwItems.TabIndex = 1;
            this.lvwItems.DoubleClick += new System.EventHandler(this.lvwItems_DoubleClick);
            this.lvwItems.ColumnClick += new Gizmox.WebGUI.Forms.ColumnClickEventHandler(this.lvwItems_ColumnClick);
            // 
            // colArticleCode
            // 
            this.colArticleCode.Image = null;
            this.colArticleCode.Text = "ArticleCode";
            this.colArticleCode.Width = 80;
            // 
            // colItemId
            // 
            this.colItemId.Image = null;
            this.colItemId.Text = "ItemId";
            this.colItemId.Visible = false;
            this.colItemId.Width = 150;
            // 
            // colLineNum
            // 
            this.colLineNum.Image = null;
            this.colLineNum.Tag = "Numeric";
            this.colLineNum.Text = "#";
            this.colLineNum.Width = 20;
            // 
            // colPackageCode
            // 
            this.colPackageCode.Image = null;
            this.colPackageCode.Text = "Package Code";
            this.colPackageCode.Width = 100;
            // 
            // colCustRef
            // 
            this.colCustRef.Image = null;
            this.colCustRef.Text = "Cust. Ref.";
            this.colCustRef.Width = 100;
            // 
            // colSupplierRef
            // 
            this.colSupplierRef.Image = null;
            this.colSupplierRef.Text = "Supplier Ref.";
            this.colSupplierRef.Width = 100;
            // 
            // colDescription
            // 
            this.colDescription.Image = null;
            this.colDescription.Text = "Description";
            this.colDescription.Width = 100;
            // 
            // colQty
            // 
            this.colQty.Image = null;
            this.colQty.Text = "Qty";
            this.colQty.TextAlign = Gizmox.WebGUI.Forms.HorizontalAlignment.Right;
            this.colQty.Width = 60;
            // 
            // colUnit
            // 
            this.colUnit.Image = null;
            this.colUnit.Text = "Unit";
            this.colUnit.TextAlign = Gizmox.WebGUI.Forms.HorizontalAlignment.Center;
            this.colUnit.Width = 60;
            // 
            // colAmount
            // 
            this.colAmount.Image = null;
            this.colAmount.Text = "Amount";
            this.colAmount.TextAlign = Gizmox.WebGUI.Forms.HorizontalAlignment.Right;
            this.colAmount.Width = 60;
            // 
            // colCurrency
            // 
            this.colCurrency.Image = null;
            this.colCurrency.Text = "Currency";
            this.colCurrency.TextAlign = Gizmox.WebGUI.Forms.HorizontalAlignment.Right;
            this.colCurrency.Width = 50;
            // 
            // ItemsList
            // 
            this.Controls.Add(this.lvwItems);
            this.Controls.Add(this.flpImageList);
            this.Controls.Add(this.ansItems);
            this.Size = new System.Drawing.Size(746, 306);
            this.Text = "ItemsList";
            this.ResumeLayout(false);

        }

        #endregion

        private Gizmox.WebGUI.Forms.ToolBar ansItems;
        private Gizmox.WebGUI.Forms.FlowLayoutPanel flpImageList;
        private Gizmox.WebGUI.Forms.ListView lvwItems;
        private Gizmox.WebGUI.Forms.ToolTip toolTip1;
        private Gizmox.WebGUI.Forms.ColumnHeader colItemId;
        private Gizmox.WebGUI.Forms.ColumnHeader colLineNum;
        private Gizmox.WebGUI.Forms.ColumnHeader colArticleCode;
        private Gizmox.WebGUI.Forms.ColumnHeader colCustRef;
        private Gizmox.WebGUI.Forms.ColumnHeader colSupplierRef;
        private Gizmox.WebGUI.Forms.ColumnHeader colPackageCode;
        private Gizmox.WebGUI.Forms.ColumnHeader colDescription;
        private Gizmox.WebGUI.Forms.ColumnHeader colQty;
        private Gizmox.WebGUI.Forms.ColumnHeader colUnit;
        private Gizmox.WebGUI.Forms.ColumnHeader colAmount;
        private Gizmox.WebGUI.Forms.ColumnHeader colCurrency;
        private Gizmox.WebGUI.Forms.ColumnHeader colSuppShippingId;
        private Gizmox.WebGUI.Forms.ColumnHeader colCustShippingId;


    }
}