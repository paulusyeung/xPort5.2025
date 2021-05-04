namespace xPort5.Order.SalesContract.Items
{
    partial class ItemList
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
            this.lvwItems = new Gizmox.WebGUI.Forms.ListView();
            this.colItemCode = new Gizmox.WebGUI.Forms.ColumnHeader();
            this.colItemId = new Gizmox.WebGUI.Forms.ColumnHeader();
            this.colLN = new Gizmox.WebGUI.Forms.ColumnHeader();
            this.colSupplier = new Gizmox.WebGUI.Forms.ColumnHeader();
            this.colPackage = new Gizmox.WebGUI.Forms.ColumnHeader();
            this.colCustomerRef = new Gizmox.WebGUI.Forms.ColumnHeader();
            this.colDescription = new Gizmox.WebGUI.Forms.ColumnHeader();
            this.colQty = new Gizmox.WebGUI.Forms.ColumnHeader();
            this.colUnit = new Gizmox.WebGUI.Forms.ColumnHeader();
            this.colFactoryCost = new Gizmox.WebGUI.Forms.ColumnHeader();
            this.colAmount = new Gizmox.WebGUI.Forms.ColumnHeader();
            this.colCurrency = new Gizmox.WebGUI.Forms.ColumnHeader();
            this.ansItems = new Gizmox.WebGUI.Forms.ToolBar();
            this.toolTip1 = new Gizmox.WebGUI.Forms.ToolTip(this.components);
            this.flpImageList = new Gizmox.WebGUI.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // lvwItems
            // 
            this.lvwItems.BorderWidth = 0;
            this.lvwItems.Columns.AddRange(new Gizmox.WebGUI.Forms.ColumnHeader[] {
            this.colItemCode,
            this.colItemId,
            this.colLN,
            this.colSupplier,
            this.colPackage,
            this.colCustomerRef,
            this.colDescription,
            this.colQty,
            this.colUnit,
            this.colFactoryCost,
            this.colAmount,
            this.colCurrency});
            this.lvwItems.DataMember = null;
            this.lvwItems.ItemsPerPage = 20;
            this.lvwItems.Location = new System.Drawing.Point(67, 51);
            this.lvwItems.Name = "lvwItems";
            this.lvwItems.Size = new System.Drawing.Size(300, 200);
            this.lvwItems.TabIndex = 1;
            this.lvwItems.DoubleClick += new System.EventHandler(this.lvwList_DoubleClick);
            this.lvwItems.ColumnClick += new Gizmox.WebGUI.Forms.ColumnClickEventHandler(this.lvwItems_ColumnClick);
            // 
            // colItemCode
            // 
            this.colItemCode.ContentAlign = Gizmox.WebGUI.Forms.ExtendedHorizontalAlignment.Center;
            this.colItemCode.Image = null;
            this.colItemCode.Text = "Product Code";
            this.colItemCode.Width = 100;
            // 
            // colItemId
            // 
            this.colItemId.Image = null;
            this.colItemId.Text = "ItemId";
            this.colItemId.Visible = false;
            this.colItemId.Width = 150;
            // 
            // colLN
            // 
            this.colLN.ContentAlign = Gizmox.WebGUI.Forms.ExtendedHorizontalAlignment.Center;
            this.colLN.Image = null;
            this.colLN.Tag = "Numeric";
            this.colLN.Text = "#";
            this.colLN.Width = 30;
            // 
            // colSupplier
            // 
            this.colSupplier.ContentAlign = Gizmox.WebGUI.Forms.ExtendedHorizontalAlignment.Center;
            this.colSupplier.Image = null;
            this.colSupplier.Text = "Supplier";
            this.colSupplier.Width = 60;
            // 
            // colPackage
            // 
            this.colPackage.ContentAlign = Gizmox.WebGUI.Forms.ExtendedHorizontalAlignment.Center;
            this.colPackage.Image = null;
            this.colPackage.Text = "Package";
            this.colPackage.Width = 60;
            // 
            // colCustomerRef
            // 
            this.colCustomerRef.ContentAlign = Gizmox.WebGUI.Forms.ExtendedHorizontalAlignment.Center;
            this.colCustomerRef.Image = null;
            this.colCustomerRef.Text = "Cust. Ref.";
            this.colCustomerRef.Width = 100;
            // 
            // colDescription
            // 
            this.colDescription.ContentAlign = Gizmox.WebGUI.Forms.ExtendedHorizontalAlignment.Center;
            this.colDescription.Image = null;
            this.colDescription.Text = "Description";
            this.colDescription.Width = 150;
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
            this.colUnit.ContentAlign = Gizmox.WebGUI.Forms.ExtendedHorizontalAlignment.Center;
            this.colUnit.Image = null;
            this.colUnit.Text = "Unit";
            this.colUnit.TextAlign = Gizmox.WebGUI.Forms.HorizontalAlignment.Center;
            this.colUnit.Width = 50;
            // 
            // colFactoryCost
            // 
            this.colFactoryCost.ContentAlign = Gizmox.WebGUI.Forms.ExtendedHorizontalAlignment.Center;
            this.colFactoryCost.Image = null;
            this.colFactoryCost.Text = "Factory Cost";
            this.colFactoryCost.TextAlign = Gizmox.WebGUI.Forms.HorizontalAlignment.Right;
            this.colFactoryCost.Width = 80;
            // 
            // colAmount
            // 
            this.colAmount.ContentAlign = Gizmox.WebGUI.Forms.ExtendedHorizontalAlignment.Center;
            this.colAmount.Image = null;
            this.colAmount.Text = "Amount";
            this.colAmount.TextAlign = Gizmox.WebGUI.Forms.HorizontalAlignment.Right;
            this.colAmount.Width = 80;
            // 
            // colCurrency
            // 
            this.colCurrency.ContentAlign = Gizmox.WebGUI.Forms.ExtendedHorizontalAlignment.Center;
            this.colCurrency.Image = null;
            this.colCurrency.Text = "Currency";
            this.colCurrency.TextAlign = Gizmox.WebGUI.Forms.HorizontalAlignment.Center;
            this.colCurrency.Width = 80;
            // 
            // ansItems
            // 
            this.ansItems.Anchor = Gizmox.WebGUI.Forms.AnchorStyles.None;
            this.ansItems.Appearance = Gizmox.WebGUI.Forms.ToolBarAppearance.Normal;
            this.ansItems.Dock = Gizmox.WebGUI.Forms.DockStyle.Top;
            this.ansItems.DragHandle = true;
            this.ansItems.DropDownArrows = false;
            this.ansItems.ImageList = null;
            this.ansItems.Location = new System.Drawing.Point(0, 0);
            this.ansItems.MenuHandle = true;
            this.ansItems.Name = "ansItems";
            this.ansItems.RightToLeft = Gizmox.WebGUI.Forms.RightToLeft.No;
            this.ansItems.ShowToolTips = true;
            this.ansItems.TabIndex = 0;
            // 
            // flpImageList
            // 
            this.flpImageList.Anchor = Gizmox.WebGUI.Forms.AnchorStyles.None;
            this.flpImageList.FlowDirection = Gizmox.WebGUI.Forms.FlowDirection.LeftToRight;
            this.flpImageList.Location = new System.Drawing.Point(404, 51);
            this.flpImageList.Name = "flpImageList";
            this.flpImageList.Size = new System.Drawing.Size(278, 200);
            this.flpImageList.TabIndex = 2;
            this.flpImageList.WrapContents = false;
            // 
            // ItemList
            // 
            this.Controls.Add(this.flpImageList);
            this.Controls.Add(this.ansItems);
            this.Controls.Add(this.lvwItems);
            this.Size = new System.Drawing.Size(746, 306);
            this.Text = "ItemList";
            this.ResumeLayout(false);

        }

        #endregion

        private Gizmox.WebGUI.Forms.ListView lvwItems;
        private Gizmox.WebGUI.Forms.ColumnHeader colItemCode;
        private Gizmox.WebGUI.Forms.ColumnHeader colItemId;
        private Gizmox.WebGUI.Forms.ColumnHeader colLN;
        private Gizmox.WebGUI.Forms.ColumnHeader colSupplier;
        private Gizmox.WebGUI.Forms.ColumnHeader colPackage;
        private Gizmox.WebGUI.Forms.ColumnHeader colDescription;
        private Gizmox.WebGUI.Forms.ColumnHeader colCustomerRef;
        private Gizmox.WebGUI.Forms.ColumnHeader colFactoryCost;
        private Gizmox.WebGUI.Forms.ColumnHeader colCurrency;
        private Gizmox.WebGUI.Forms.ColumnHeader colUnit;
        private Gizmox.WebGUI.Forms.ColumnHeader colAmount;
        private Gizmox.WebGUI.Forms.ToolBar ansItems;
        private Gizmox.WebGUI.Forms.ToolTip toolTip1;
        private Gizmox.WebGUI.Forms.ColumnHeader colQty;
        private Gizmox.WebGUI.Forms.FlowLayoutPanel flpImageList;


    }
}