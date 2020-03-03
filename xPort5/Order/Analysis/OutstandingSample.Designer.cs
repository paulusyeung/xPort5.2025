namespace xPort5.Order.Analysis
{
    partial class OutstandingSample
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OutstandingSample));
            this.splitContainer = new Gizmox.WebGUI.Forms.SplitContainer();
            this.tvList = new Gizmox.WebGUI.Forms.TreeView();
            this.tabOSSample = new Gizmox.WebGUI.Forms.TabControl();
            this.tpCustomer = new Gizmox.WebGUI.Forms.TabPage();
            this.lblCustomer = new Gizmox.WebGUI.Forms.Label();
            this.tpArticle = new Gizmox.WebGUI.Forms.TabPage();
            this.txtArticle = new Gizmox.WebGUI.Forms.TextBox();
            this.btnFind = new Gizmox.WebGUI.Forms.Button();
            this.toolBar1 = new Gizmox.WebGUI.Forms.ToolBar();
            this.lvwList = new Gizmox.WebGUI.Forms.ListView();
            this.colCustomerId = ((Gizmox.WebGUI.Forms.ColumnHeader)(new Gizmox.WebGUI.Forms.ColumnHeader()));
            this.colCustomer = ((Gizmox.WebGUI.Forms.ColumnHeader)(new Gizmox.WebGUI.Forms.ColumnHeader()));
            this.colCustRef = ((Gizmox.WebGUI.Forms.ColumnHeader)(new Gizmox.WebGUI.Forms.ColumnHeader()));
            this.colArticleCode = ((Gizmox.WebGUI.Forms.ColumnHeader)(new Gizmox.WebGUI.Forms.ColumnHeader()));
            this.colArticleName = ((Gizmox.WebGUI.Forms.ColumnHeader)(new Gizmox.WebGUI.Forms.ColumnHeader()));
            this.colUnitPrice = ((Gizmox.WebGUI.Forms.ColumnHeader)(new Gizmox.WebGUI.Forms.ColumnHeader()));
            this.colSampleQty = ((Gizmox.WebGUI.Forms.ColumnHeader)(new Gizmox.WebGUI.Forms.ColumnHeader()));
            this.colUnit = ((Gizmox.WebGUI.Forms.ColumnHeader)(new Gizmox.WebGUI.Forms.ColumnHeader()));
            this.colSupplier = ((Gizmox.WebGUI.Forms.ColumnHeader)(new Gizmox.WebGUI.Forms.ColumnHeader()));
            this.colPriceListN = ((Gizmox.WebGUI.Forms.ColumnHeader)(new Gizmox.WebGUI.Forms.ColumnHeader()));
            this.toolBar2 = new Gizmox.WebGUI.Forms.ToolBar();
            ((System.ComponentModel.ISupportInitialize)(this.tabOSSample)).BeginInit();
            this.tabOSSample.SuspendLayout();
            this.tpCustomer.SuspendLayout();
            this.tpArticle.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer
            // 
            this.splitContainer.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.splitContainer.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.Clear;
            this.splitContainer.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.splitContainer.FixedPanel = Gizmox.WebGUI.Forms.FixedPanel.Panel1;
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.tvList);
            this.splitContainer.Panel1.Controls.Add(this.tabOSSample);
            this.splitContainer.Panel1.Controls.Add(this.toolBar1);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.lvwList);
            this.splitContainer.Panel2.Controls.Add(this.toolBar2);
            this.splitContainer.Size = new System.Drawing.Size(768, 462);
            this.splitContainer.SplitterDistance = 180;
            this.splitContainer.SplitterWidth = 1;
            this.splitContainer.TabIndex = 0;
            // 
            // tvList
            // 
            this.tvList.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.tvList.Location = new System.Drawing.Point(0, 122);
            this.tvList.Margin = new Gizmox.WebGUI.Forms.Padding(0, 10, 0, 0);
            this.tvList.Name = "tvList";
            this.tvList.Size = new System.Drawing.Size(180, 326);
            this.tvList.TabIndex = 4;
            this.tvList.AfterSelect += new Gizmox.WebGUI.Forms.TreeViewEventHandler(this.tvList_AfterSelect);
            // 
            // tabOSSample
            // 
            this.tabOSSample.Controls.Add(this.tpCustomer);
            this.tabOSSample.Controls.Add(this.tpArticle);
            this.tabOSSample.Dock = Gizmox.WebGUI.Forms.DockStyle.Top;
            this.tabOSSample.Location = new System.Drawing.Point(0, 28);
            this.tabOSSample.Margin = new Gizmox.WebGUI.Forms.Padding(0, 0, 0, 10);
            this.tabOSSample.Name = "tabOSSample";
            this.tabOSSample.SelectedIndex = 0;
            this.tabOSSample.Size = new System.Drawing.Size(180, 94);
            this.tabOSSample.TabIndex = 3;
            this.tabOSSample.SelectedIndexChanged += new System.EventHandler(this.tabOSSample_SelectedIndexChanged);
            // 
            // tpCustomer
            // 
            this.tpCustomer.Controls.Add(this.lblCustomer);
            this.tpCustomer.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.tpCustomer.Location = new System.Drawing.Point(4, 22);
            this.tpCustomer.Name = "tpCustomer";
            this.tpCustomer.Size = new System.Drawing.Size(172, 68);
            this.tpCustomer.TabIndex = 0;
            this.tpCustomer.Text = "Customer";
            // 
            // lblCustomer
            // 
            this.lblCustomer.Location = new System.Drawing.Point(15, 17);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(147, 34);
            this.lblCustomer.TabIndex = 0;
            this.lblCustomer.Text = "Pick your selection by Drilling\r\ndown the tree below.";
            // 
            // tpArticle
            // 
            this.tpArticle.Controls.Add(this.txtArticle);
            this.tpArticle.Controls.Add(this.btnFind);
            this.tpArticle.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.tpArticle.Location = new System.Drawing.Point(4, 22);
            this.tpArticle.Name = "tpArticle";
            this.tpArticle.Size = new System.Drawing.Size(172, 68);
            this.tpArticle.TabIndex = 0;
            this.tpArticle.Text = "Article";
            // 
            // txtArticle
            // 
            this.txtArticle.Location = new System.Drawing.Point(14, 25);
            this.txtArticle.Name = "txtArticle";
            this.txtArticle.Size = new System.Drawing.Size(100, 20);
            this.txtArticle.TabIndex = 0;
            // 
            // btnFind
            // 
            this.btnFind.Image = new Gizmox.WebGUI.Common.Resources.IconResourceHandle(resources.GetString("btnFind.Image"));
            this.btnFind.Location = new System.Drawing.Point(121, 25);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(35, 23);
            this.btnFind.TabIndex = 1;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // toolBar1
            // 
            this.toolBar1.DragHandle = true;
            this.toolBar1.DropDownArrows = true;
            this.toolBar1.ImageSize = new System.Drawing.Size(16, 16);
            this.toolBar1.Location = new System.Drawing.Point(0, 0);
            this.toolBar1.MenuHandle = true;
            this.toolBar1.Name = "toolBar1";
            this.toolBar1.RightToLeft = Gizmox.WebGUI.Forms.RightToLeft.No;
            this.toolBar1.ShowToolTips = true;
            this.toolBar1.Size = new System.Drawing.Size(180, 42);
            this.toolBar1.TabIndex = 2;
            // 
            // lvwList
            // 
            this.lvwList.Columns.AddRange(new Gizmox.WebGUI.Forms.ColumnHeader[] {
            this.colCustomerId,
            this.colCustomer,
            this.colCustRef,
            this.colArticleCode,
            this.colArticleName,
            this.colUnitPrice,
            this.colSampleQty,
            this.colUnit,
            this.colSupplier,
            this.colPriceListN});
            this.lvwList.DataMember = null;
            this.lvwList.GridLines = true;
            this.lvwList.ItemsPerPage = 30;
            this.lvwList.Location = new System.Drawing.Point(71, 93);
            this.lvwList.Name = "lvwList";
            this.lvwList.Size = new System.Drawing.Size(446, 115);
            this.lvwList.TabIndex = 2;
            this.lvwList.UseInternalPaging = true;
            // 
            // colCustomerId
            // 
            this.colCustomerId.Text = "CustomerId";
            this.colCustomerId.Visible = false;
            this.colCustomerId.Width = 100;
            // 
            // colCustomer
            // 
            this.colCustomer.Text = "Customer";
            this.colCustomer.Width = 150;
            // 
            // colCustRef
            // 
            this.colCustRef.Text = "Cust. Ref.";
            this.colCustRef.TextAlign = Gizmox.WebGUI.Forms.HorizontalAlignment.Center;
            this.colCustRef.Width = 80;
            // 
            // colArticleCode
            // 
            this.colArticleCode.Text = "Article No.";
            this.colArticleCode.TextAlign = Gizmox.WebGUI.Forms.HorizontalAlignment.Center;
            this.colArticleCode.Width = 80;
            // 
            // colArticleName
            // 
            this.colArticleName.Text = "Article Name";
            this.colArticleName.Width = 150;
            // 
            // colUnitPrice
            // 
            this.colUnitPrice.Text = "Unit Price";
            this.colUnitPrice.TextAlign = Gizmox.WebGUI.Forms.HorizontalAlignment.Right;
            this.colUnitPrice.Width = 80;
            // 
            // colSampleQty
            // 
            this.colSampleQty.Text = "Sample Qty";
            this.colSampleQty.TextAlign = Gizmox.WebGUI.Forms.HorizontalAlignment.Right;
            this.colSampleQty.Width = 60;
            // 
            // colUnit
            // 
            this.colUnit.Text = "Unit";
            this.colUnit.TextAlign = Gizmox.WebGUI.Forms.HorizontalAlignment.Center;
            this.colUnit.Width = 30;
            // 
            // colSupplier
            // 
            this.colSupplier.Text = "Supplier";
            this.colSupplier.Width = 150;
            // 
            // colPriceListN
            // 
            this.colPriceListN.Text = "Price List No.";
            this.colPriceListN.TextAlign = Gizmox.WebGUI.Forms.HorizontalAlignment.Center;
            this.colPriceListN.Width = 80;
            // 
            // toolBar2
            // 
            this.toolBar2.DragHandle = true;
            this.toolBar2.DropDownArrows = true;
            this.toolBar2.ImageSize = new System.Drawing.Size(16, 16);
            this.toolBar2.Location = new System.Drawing.Point(0, 0);
            this.toolBar2.MenuHandle = true;
            this.toolBar2.Name = "toolBar2";
            this.toolBar2.RightToLeft = Gizmox.WebGUI.Forms.RightToLeft.No;
            this.toolBar2.ShowToolTips = true;
            this.toolBar2.Size = new System.Drawing.Size(587, 42);
            this.toolBar2.TabIndex = 1;
            // 
            // OutstandingSample
            // 
            this.Controls.Add(this.splitContainer);
            this.Size = new System.Drawing.Size(768, 462);
            this.Text = "OutstandingSample";
            ((System.ComponentModel.ISupportInitialize)(this.tabOSSample)).EndInit();
            this.tabOSSample.ResumeLayout(false);
            this.tpCustomer.ResumeLayout(false);
            this.tpArticle.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Gizmox.WebGUI.Forms.SplitContainer splitContainer;
        private Gizmox.WebGUI.Forms.ToolBar toolBar1;
        private Gizmox.WebGUI.Forms.ToolBar toolBar2;
        private Gizmox.WebGUI.Forms.TreeView tvList;
        private Gizmox.WebGUI.Forms.TabControl tabOSSample;
        private Gizmox.WebGUI.Forms.TabPage tpCustomer;
        private Gizmox.WebGUI.Forms.TabPage tpArticle;
        private Gizmox.WebGUI.Forms.ListView lvwList;
        private Gizmox.WebGUI.Forms.ColumnHeader colCustomer;
        private Gizmox.WebGUI.Forms.ColumnHeader colCustRef;
        private Gizmox.WebGUI.Forms.ColumnHeader colArticleCode;
        private Gizmox.WebGUI.Forms.ColumnHeader colArticleName;
        private Gizmox.WebGUI.Forms.ColumnHeader colUnitPrice;
        private Gizmox.WebGUI.Forms.ColumnHeader colSampleQty;
        private Gizmox.WebGUI.Forms.ColumnHeader colUnit;
        private Gizmox.WebGUI.Forms.ColumnHeader colSupplier;
        private Gizmox.WebGUI.Forms.ColumnHeader colPriceListN;
        private Gizmox.WebGUI.Forms.Button btnFind;
        private Gizmox.WebGUI.Forms.TextBox txtArticle;
        private Gizmox.WebGUI.Forms.Label lblCustomer;
        private Gizmox.WebGUI.Forms.ColumnHeader colCustomerId;


    }
}