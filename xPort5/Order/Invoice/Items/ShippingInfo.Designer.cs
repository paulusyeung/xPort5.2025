namespace xPort5.Order.Invoice.Items
{
    partial class ShippingInfo
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
            Gizmox.WebGUI.Common.Resources.IconResourceHandle iconResourceHandle11 = new Gizmox.WebGUI.Common.Resources.IconResourceHandle();
            Gizmox.WebGUI.Common.Resources.IconResourceHandle iconResourceHandle12 = new Gizmox.WebGUI.Common.Resources.IconResourceHandle();
            Gizmox.WebGUI.Common.Resources.IconResourceHandle iconResourceHandle13 = new Gizmox.WebGUI.Common.Resources.IconResourceHandle();
            Gizmox.WebGUI.Common.Resources.IconResourceHandle iconResourceHandle14 = new Gizmox.WebGUI.Common.Resources.IconResourceHandle();
            Gizmox.WebGUI.Common.Resources.IconResourceHandle iconResourceHandle15 = new Gizmox.WebGUI.Common.Resources.IconResourceHandle();
            this.boxWeight = new Gizmox.WebGUI.Forms.GroupBox();
            this.cmdConvertToKg = new Gizmox.WebGUI.Forms.Button();
            this.cmdConvertToLb = new Gizmox.WebGUI.Forms.Button();
            this.txtNetKG = new Gizmox.WebGUI.Forms.TextBox();
            this.txtGrossKG = new Gizmox.WebGUI.Forms.TextBox();
            this.lblInKG = new Gizmox.WebGUI.Forms.Label();
            this.txtNetLB = new Gizmox.WebGUI.Forms.TextBox();
            this.txtGrossLB = new Gizmox.WebGUI.Forms.TextBox();
            this.lblInLB = new Gizmox.WebGUI.Forms.Label();
            this.lblNet = new Gizmox.WebGUI.Forms.Label();
            this.lblGross = new Gizmox.WebGUI.Forms.Label();
            this.boxDimension = new Gizmox.WebGUI.Forms.GroupBox();
            this.cmdConvertToVolumn = new Gizmox.WebGUI.Forms.Button();
            this.cmdConvertToCm = new Gizmox.WebGUI.Forms.Button();
            this.cmdConvertToInch = new Gizmox.WebGUI.Forms.Button();
            this.lblCUFT = new Gizmox.WebGUI.Forms.Label();
            this.txtVolumn = new Gizmox.WebGUI.Forms.TextBox();
            this.lblVolum = new Gizmox.WebGUI.Forms.Label();
            this.txtHeightCm = new Gizmox.WebGUI.Forms.TextBox();
            this.txtWidthCm = new Gizmox.WebGUI.Forms.TextBox();
            this.txtLengthCm = new Gizmox.WebGUI.Forms.TextBox();
            this.lblInCm = new Gizmox.WebGUI.Forms.Label();
            this.txtHeightInch = new Gizmox.WebGUI.Forms.TextBox();
            this.txtWidthInch = new Gizmox.WebGUI.Forms.TextBox();
            this.txtLengthInch = new Gizmox.WebGUI.Forms.TextBox();
            this.lblInInch = new Gizmox.WebGUI.Forms.Label();
            this.lblHeight = new Gizmox.WebGUI.Forms.Label();
            this.lblWidth = new Gizmox.WebGUI.Forms.Label();
            this.lblLength = new Gizmox.WebGUI.Forms.Label();
            this.lblOuterBox = new Gizmox.WebGUI.Forms.Label();
            this.txtOuterBox = new Gizmox.WebGUI.Forms.TextBox();
            this.lblInnerBox = new Gizmox.WebGUI.Forms.Label();
            this.txtInnerBox = new Gizmox.WebGUI.Forms.TextBox();
            this.gbShippingInfo = new Gizmox.WebGUI.Forms.GroupBox();
            this.txtLineNumber = new Gizmox.WebGUI.Forms.TextBox();
            this.lblLineNumber = new Gizmox.WebGUI.Forms.Label();
            this.cboShippingMark = new Gizmox.WebGUI.Forms.ComboBox();
            this.txtShippingMark = new Gizmox.WebGUI.Forms.TextBox();
            this.lblShippingMark = new Gizmox.WebGUI.Forms.Label();
            this.gbPacking = new Gizmox.WebGUI.Forms.GroupBox();
            this.lblUnitOfOuterBox = new Gizmox.WebGUI.Forms.Label();
            this.lblUnitOfInnerBox = new Gizmox.WebGUI.Forms.Label();
            this.ansToolbar = new Gizmox.WebGUI.Forms.ToolBar();
            this.toolTip1 = new Gizmox.WebGUI.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // boxWeight
            // 
            this.boxWeight.Controls.Add(this.cmdConvertToKg);
            this.boxWeight.Controls.Add(this.cmdConvertToLb);
            this.boxWeight.Controls.Add(this.txtNetKG);
            this.boxWeight.Controls.Add(this.txtGrossKG);
            this.boxWeight.Controls.Add(this.lblInKG);
            this.boxWeight.Controls.Add(this.txtNetLB);
            this.boxWeight.Controls.Add(this.txtGrossLB);
            this.boxWeight.Controls.Add(this.lblInLB);
            this.boxWeight.Controls.Add(this.lblNet);
            this.boxWeight.Controls.Add(this.lblGross);
            this.boxWeight.FlatStyle = Gizmox.WebGUI.Forms.FlatStyle.Flat;
            this.boxWeight.Location = new System.Drawing.Point(12, 399);
            this.boxWeight.Name = "boxWeight";
            this.boxWeight.Size = new System.Drawing.Size(399, 87);
            this.boxWeight.TabIndex = 15;
            this.boxWeight.Text = "Weight";
            // 
            // cmdConvertToKg
            // 
            iconResourceHandle11.File = "16x16.lightning.png";
            this.cmdConvertToKg.Image = iconResourceHandle11;
            this.cmdConvertToKg.Location = new System.Drawing.Point(68, 58);
            this.cmdConvertToKg.Name = "cmdConvertToKg";
            this.cmdConvertToKg.Size = new System.Drawing.Size(24, 23);
            this.cmdConvertToKg.TabIndex = 7;
            this.cmdConvertToKg.TabStop = false;
            this.cmdConvertToKg.TextImageRelation = Gizmox.WebGUI.Forms.TextImageRelation.ImageAboveText;
            this.cmdConvertToKg.Click += new System.EventHandler(this.cmdConvertToKg_Click);
            // 
            // cmdConvertToLb
            // 
            iconResourceHandle12.File = "16x16.lightning.png";
            this.cmdConvertToLb.Image = iconResourceHandle12;
            this.cmdConvertToLb.Location = new System.Drawing.Point(68, 33);
            this.cmdConvertToLb.Name = "cmdConvertToLb";
            this.cmdConvertToLb.Size = new System.Drawing.Size(24, 23);
            this.cmdConvertToLb.TabIndex = 3;
            this.cmdConvertToLb.TabStop = false;
            this.cmdConvertToLb.TextImageRelation = Gizmox.WebGUI.Forms.TextImageRelation.ImageAboveText;
            this.cmdConvertToLb.Click += new System.EventHandler(this.cmdConvertToLb_Click);
            // 
            // txtNetKG
            // 
            this.txtNetKG.Location = new System.Drawing.Point(192, 59);
            this.txtNetKG.Name = "txtNetKG";
            this.txtNetKG.Size = new System.Drawing.Size(100, 20);
            this.txtNetKG.TabIndex = 9;
            this.txtNetKG.TextAlign = Gizmox.WebGUI.Forms.HorizontalAlignment.Right;
            this.txtNetKG.GotFocus += new System.EventHandler(this.txtNetKG_GotFocus);
            // 
            // txtGrossKG
            // 
            this.txtGrossKG.Location = new System.Drawing.Point(92, 59);
            this.txtGrossKG.Name = "txtGrossKG";
            this.txtGrossKG.Size = new System.Drawing.Size(100, 20);
            this.txtGrossKG.TabIndex = 8;
            this.txtGrossKG.TextAlign = Gizmox.WebGUI.Forms.HorizontalAlignment.Right;
            this.txtGrossKG.GotFocus += new System.EventHandler(this.txtGrossKG_GotFocus);
            // 
            // lblInKG
            // 
            this.lblInKG.Location = new System.Drawing.Point(4, 59);
            this.lblInKG.Name = "lblInKG";
            this.lblInKG.Size = new System.Drawing.Size(64, 21);
            this.lblInKG.TabIndex = 6;
            this.lblInKG.Text = "In KG:";
            this.lblInKG.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtNetLB
            // 
            this.txtNetLB.Location = new System.Drawing.Point(192, 34);
            this.txtNetLB.Name = "txtNetLB";
            this.txtNetLB.Size = new System.Drawing.Size(100, 20);
            this.txtNetLB.TabIndex = 5;
            this.txtNetLB.TextAlign = Gizmox.WebGUI.Forms.HorizontalAlignment.Right;
            this.txtNetLB.GotFocus += new System.EventHandler(this.txtNetLB_GotFocus);
            // 
            // txtGrossLB
            // 
            this.txtGrossLB.Location = new System.Drawing.Point(92, 34);
            this.txtGrossLB.Name = "txtGrossLB";
            this.txtGrossLB.Size = new System.Drawing.Size(100, 20);
            this.txtGrossLB.TabIndex = 4;
            this.txtGrossLB.TextAlign = Gizmox.WebGUI.Forms.HorizontalAlignment.Right;
            this.txtGrossLB.GotFocus += new System.EventHandler(this.txtGrossLB_GotFocus);
            // 
            // lblInLB
            // 
            this.lblInLB.Location = new System.Drawing.Point(4, 34);
            this.lblInLB.Name = "lblInLB";
            this.lblInLB.Size = new System.Drawing.Size(64, 21);
            this.lblInLB.TabIndex = 2;
            this.lblInLB.Text = "In LB:";
            this.lblInLB.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblNet
            // 
            this.lblNet.Location = new System.Drawing.Point(192, 13);
            this.lblNet.Name = "lblNet";
            this.lblNet.Size = new System.Drawing.Size(100, 21);
            this.lblNet.TabIndex = 1;
            this.lblNet.Text = "Net";
            this.lblNet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGross
            // 
            this.lblGross.Location = new System.Drawing.Point(92, 13);
            this.lblGross.Name = "lblGross";
            this.lblGross.Size = new System.Drawing.Size(100, 21);
            this.lblGross.TabIndex = 0;
            this.lblGross.Text = "Gross";
            this.lblGross.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // boxDimension
            // 
            this.boxDimension.Controls.Add(this.cmdConvertToVolumn);
            this.boxDimension.Controls.Add(this.cmdConvertToCm);
            this.boxDimension.Controls.Add(this.cmdConvertToInch);
            this.boxDimension.Controls.Add(this.lblCUFT);
            this.boxDimension.Controls.Add(this.txtVolumn);
            this.boxDimension.Controls.Add(this.lblVolum);
            this.boxDimension.Controls.Add(this.txtHeightCm);
            this.boxDimension.Controls.Add(this.txtWidthCm);
            this.boxDimension.Controls.Add(this.txtLengthCm);
            this.boxDimension.Controls.Add(this.lblInCm);
            this.boxDimension.Controls.Add(this.txtHeightInch);
            this.boxDimension.Controls.Add(this.txtWidthInch);
            this.boxDimension.Controls.Add(this.txtLengthInch);
            this.boxDimension.Controls.Add(this.lblInInch);
            this.boxDimension.Controls.Add(this.lblHeight);
            this.boxDimension.Controls.Add(this.lblWidth);
            this.boxDimension.Controls.Add(this.lblLength);
            this.boxDimension.FlatStyle = Gizmox.WebGUI.Forms.FlatStyle.Flat;
            this.boxDimension.Location = new System.Drawing.Point(12, 282);
            this.boxDimension.Name = "boxDimension";
            this.boxDimension.Size = new System.Drawing.Size(399, 109);
            this.boxDimension.TabIndex = 14;
            this.boxDimension.Text = "Dimension";
            // 
            // cmdConvertToVolumn
            // 
            iconResourceHandle13.File = "16x16.lightning.png";
            this.cmdConvertToVolumn.Image = iconResourceHandle13;
            this.cmdConvertToVolumn.Location = new System.Drawing.Point(68, 81);
            this.cmdConvertToVolumn.Name = "cmdConvertToVolumn";
            this.cmdConvertToVolumn.Size = new System.Drawing.Size(24, 23);
            this.cmdConvertToVolumn.TabIndex = 14;
            this.cmdConvertToVolumn.TabStop = false;
            this.cmdConvertToVolumn.TextImageRelation = Gizmox.WebGUI.Forms.TextImageRelation.ImageAboveText;
            this.cmdConvertToVolumn.Click += new System.EventHandler(this.cmdConvertToVolumn_Click);
            // 
            // cmdConvertToCm
            // 
            iconResourceHandle14.File = "16x16.lightning.png";
            this.cmdConvertToCm.Image = iconResourceHandle14;
            this.cmdConvertToCm.Location = new System.Drawing.Point(68, 57);
            this.cmdConvertToCm.Name = "cmdConvertToCm";
            this.cmdConvertToCm.Size = new System.Drawing.Size(24, 23);
            this.cmdConvertToCm.TabIndex = 9;
            this.cmdConvertToCm.TabStop = false;
            this.cmdConvertToCm.TextImageRelation = Gizmox.WebGUI.Forms.TextImageRelation.ImageAboveText;
            this.cmdConvertToCm.Click += new System.EventHandler(this.cmdConvertToCm_Click);
            // 
            // cmdConvertToInch
            // 
            iconResourceHandle15.File = "16x16.lightning.png";
            this.cmdConvertToInch.Image = iconResourceHandle15;
            this.cmdConvertToInch.Location = new System.Drawing.Point(68, 33);
            this.cmdConvertToInch.Name = "cmdConvertToInch";
            this.cmdConvertToInch.Size = new System.Drawing.Size(24, 23);
            this.cmdConvertToInch.TabIndex = 4;
            this.cmdConvertToInch.TabStop = false;
            this.cmdConvertToInch.TextImageRelation = Gizmox.WebGUI.Forms.TextImageRelation.ImageAboveText;
            this.cmdConvertToInch.Click += new System.EventHandler(this.cmdConvertToInch_Click);
            // 
            // lblCUFT
            // 
            this.lblCUFT.Location = new System.Drawing.Point(194, 82);
            this.lblCUFT.Name = "lblCUFT";
            this.lblCUFT.Size = new System.Drawing.Size(100, 21);
            this.lblCUFT.TabIndex = 16;
            this.lblCUFT.Text = "(CUFT)";
            this.lblCUFT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtVolumn
            // 
            this.txtVolumn.Location = new System.Drawing.Point(92, 82);
            this.txtVolumn.Name = "txtVolumn";
            this.txtVolumn.Size = new System.Drawing.Size(100, 20);
            this.txtVolumn.TabIndex = 15;
            this.txtVolumn.TextAlign = Gizmox.WebGUI.Forms.HorizontalAlignment.Right;
            this.txtVolumn.GotFocus += new System.EventHandler(this.txtVolumn_GotFocus);
            // 
            // lblVolum
            // 
            this.lblVolum.Location = new System.Drawing.Point(4, 82);
            this.lblVolum.Name = "lblVolum";
            this.lblVolum.Size = new System.Drawing.Size(64, 21);
            this.lblVolum.TabIndex = 13;
            this.lblVolum.Text = "Volumn:";
            this.lblVolum.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtHeightCm
            // 
            this.txtHeightCm.Location = new System.Drawing.Point(292, 58);
            this.txtHeightCm.Name = "txtHeightCm";
            this.txtHeightCm.Size = new System.Drawing.Size(100, 20);
            this.txtHeightCm.TabIndex = 12;
            this.txtHeightCm.TextAlign = Gizmox.WebGUI.Forms.HorizontalAlignment.Right;
            this.txtHeightCm.GotFocus += new System.EventHandler(this.txtHeightCm_GotFocus);
            // 
            // txtWidthCm
            // 
            this.txtWidthCm.Location = new System.Drawing.Point(192, 58);
            this.txtWidthCm.Name = "txtWidthCm";
            this.txtWidthCm.Size = new System.Drawing.Size(100, 20);
            this.txtWidthCm.TabIndex = 11;
            this.txtWidthCm.TextAlign = Gizmox.WebGUI.Forms.HorizontalAlignment.Right;
            this.txtWidthCm.GotFocus += new System.EventHandler(this.txtWidthCm_GotFocus);
            // 
            // txtLengthCm
            // 
            this.txtLengthCm.Location = new System.Drawing.Point(92, 58);
            this.txtLengthCm.Name = "txtLengthCm";
            this.txtLengthCm.Size = new System.Drawing.Size(100, 20);
            this.txtLengthCm.TabIndex = 10;
            this.txtLengthCm.TextAlign = Gizmox.WebGUI.Forms.HorizontalAlignment.Right;
            this.txtLengthCm.GotFocus += new System.EventHandler(this.txtLengthCm_GotFocus);
            // 
            // lblInCm
            // 
            this.lblInCm.Location = new System.Drawing.Point(4, 58);
            this.lblInCm.Name = "lblInCm";
            this.lblInCm.Size = new System.Drawing.Size(64, 21);
            this.lblInCm.TabIndex = 8;
            this.lblInCm.Text = "In cm:";
            this.lblInCm.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtHeightInch
            // 
            this.txtHeightInch.Location = new System.Drawing.Point(292, 34);
            this.txtHeightInch.Name = "txtHeightInch";
            this.txtHeightInch.Size = new System.Drawing.Size(100, 20);
            this.txtHeightInch.TabIndex = 7;
            this.txtHeightInch.TextAlign = Gizmox.WebGUI.Forms.HorizontalAlignment.Right;
            this.txtHeightInch.GotFocus += new System.EventHandler(this.txtHeightInch_GotFocus);
            // 
            // txtWidthInch
            // 
            this.txtWidthInch.Location = new System.Drawing.Point(192, 34);
            this.txtWidthInch.Name = "txtWidthInch";
            this.txtWidthInch.Size = new System.Drawing.Size(100, 20);
            this.txtWidthInch.TabIndex = 6;
            this.txtWidthInch.TextAlign = Gizmox.WebGUI.Forms.HorizontalAlignment.Right;
            this.txtWidthInch.GotFocus += new System.EventHandler(this.txtWidthInch_GotFocus);
            // 
            // txtLengthInch
            // 
            this.txtLengthInch.Location = new System.Drawing.Point(92, 34);
            this.txtLengthInch.Name = "txtLengthInch";
            this.txtLengthInch.Size = new System.Drawing.Size(100, 20);
            this.txtLengthInch.TabIndex = 5;
            this.txtLengthInch.TextAlign = Gizmox.WebGUI.Forms.HorizontalAlignment.Right;
            this.txtLengthInch.GotFocus += new System.EventHandler(this.txtLengthInch_GotFocus);
            // 
            // lblInInch
            // 
            this.lblInInch.Location = new System.Drawing.Point(4, 34);
            this.lblInInch.Name = "lblInInch";
            this.lblInInch.Size = new System.Drawing.Size(64, 21);
            this.lblInInch.TabIndex = 3;
            this.lblInInch.Text = "In Inch:";
            this.lblInInch.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblHeight
            // 
            this.lblHeight.Location = new System.Drawing.Point(292, 13);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(100, 21);
            this.lblHeight.TabIndex = 2;
            this.lblHeight.Text = "Height";
            this.lblHeight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblWidth
            // 
            this.lblWidth.Location = new System.Drawing.Point(192, 13);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(100, 21);
            this.lblWidth.TabIndex = 1;
            this.lblWidth.Text = "Width";
            this.lblWidth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLength
            // 
            this.lblLength.Location = new System.Drawing.Point(92, 13);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(100, 21);
            this.lblLength.TabIndex = 0;
            this.lblLength.Text = "Length";
            this.lblLength.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOuterBox
            // 
            this.lblOuterBox.Location = new System.Drawing.Point(4, 62);
            this.lblOuterBox.Name = "lblOuterBox";
            this.lblOuterBox.Size = new System.Drawing.Size(64, 21);
            this.lblOuterBox.TabIndex = 12;
            this.lblOuterBox.Text = "Outer Box:";
            this.lblOuterBox.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtOuterBox
            // 
            this.txtOuterBox.Location = new System.Drawing.Point(91, 59);
            this.txtOuterBox.Name = "txtOuterBox";
            this.txtOuterBox.Size = new System.Drawing.Size(100, 20);
            this.txtOuterBox.TabIndex = 13;
            this.txtOuterBox.TextAlign = Gizmox.WebGUI.Forms.HorizontalAlignment.Right;
            // 
            // lblInnerBox
            // 
            this.lblInnerBox.Location = new System.Drawing.Point(4, 34);
            this.lblInnerBox.Name = "lblInnerBox";
            this.lblInnerBox.Size = new System.Drawing.Size(64, 21);
            this.lblInnerBox.TabIndex = 10;
            this.lblInnerBox.Text = "Inner Box:";
            this.lblInnerBox.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtInnerBox
            // 
            this.txtInnerBox.Location = new System.Drawing.Point(92, 34);
            this.txtInnerBox.Name = "txtInnerBox";
            this.txtInnerBox.Size = new System.Drawing.Size(100, 20);
            this.txtInnerBox.TabIndex = 11;
            this.txtInnerBox.TextAlign = Gizmox.WebGUI.Forms.HorizontalAlignment.Right;
            // 
            // gbShippingInfo
            // 
            this.gbShippingInfo.Controls.Add(this.txtLineNumber);
            this.gbShippingInfo.Controls.Add(this.lblLineNumber);
            this.gbShippingInfo.Controls.Add(this.cboShippingMark);
            this.gbShippingInfo.Controls.Add(this.txtShippingMark);
            this.gbShippingInfo.Controls.Add(this.lblShippingMark);
            this.gbShippingInfo.FlatStyle = Gizmox.WebGUI.Forms.FlatStyle.Flat;
            this.gbShippingInfo.Location = new System.Drawing.Point(12, 34);
            this.gbShippingInfo.Name = "gbShippingInfo";
            this.gbShippingInfo.Size = new System.Drawing.Size(399, 146);
            this.gbShippingInfo.TabIndex = 16;
            this.gbShippingInfo.Text = "Shipping Info";
            // 
            // txtLineNumber
            // 
            this.txtLineNumber.Enabled = false;
            this.txtLineNumber.Location = new System.Drawing.Point(91, 31);
            this.txtLineNumber.Name = "txtLineNumber";
            this.txtLineNumber.Size = new System.Drawing.Size(100, 20);
            this.txtLineNumber.TabIndex = 11;
            // 
            // lblLineNumber
            // 
            this.lblLineNumber.Location = new System.Drawing.Point(6, 34);
            this.lblLineNumber.Name = "lblLineNumber";
            this.lblLineNumber.Size = new System.Drawing.Size(79, 21);
            this.lblLineNumber.TabIndex = 10;
            this.lblLineNumber.Text = "Line Number:";
            this.lblLineNumber.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cboShippingMark
            // 
            this.cboShippingMark.DropDownStyle = Gizmox.WebGUI.Forms.ComboBoxStyle.DropDownList;
            this.cboShippingMark.DropDownWidth = 100;
            this.cboShippingMark.Location = new System.Drawing.Point(68, 86);
            this.cboShippingMark.Name = "cboShippingMark";
            this.cboShippingMark.Size = new System.Drawing.Size(19, 21);
            this.cboShippingMark.TabIndex = 10;
            this.cboShippingMark.SelectedIndexChanged += new System.EventHandler(this.cboShippingMark_SelectedIndexChanged);
            // 
            // txtShippingMark
            // 
            this.txtShippingMark.Location = new System.Drawing.Point(92, 57);
            this.txtShippingMark.Multiline = true;
            this.txtShippingMark.Name = "txtShippingMark";
            this.txtShippingMark.ScrollBars = Gizmox.WebGUI.Forms.ScrollBars.Vertical;
            this.txtShippingMark.Size = new System.Drawing.Size(300, 81);
            this.txtShippingMark.TabIndex = 1;
            // 
            // lblShippingMark
            // 
            this.lblShippingMark.Location = new System.Drawing.Point(6, 60);
            this.lblShippingMark.Name = "lblShippingMark";
            this.lblShippingMark.Size = new System.Drawing.Size(79, 21);
            this.lblShippingMark.TabIndex = 0;
            this.lblShippingMark.Text = "Shipping Mark:";
            this.lblShippingMark.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // gbPacking
            // 
            this.gbPacking.Controls.Add(this.lblUnitOfOuterBox);
            this.gbPacking.Controls.Add(this.lblUnitOfInnerBox);
            this.gbPacking.Controls.Add(this.lblInnerBox);
            this.gbPacking.Controls.Add(this.lblOuterBox);
            this.gbPacking.Controls.Add(this.txtOuterBox);
            this.gbPacking.Controls.Add(this.txtInnerBox);
            this.gbPacking.FlatStyle = Gizmox.WebGUI.Forms.FlatStyle.Flat;
            this.gbPacking.Location = new System.Drawing.Point(12, 188);
            this.gbPacking.Name = "gbPacking";
            this.gbPacking.Size = new System.Drawing.Size(399, 86);
            this.gbPacking.TabIndex = 18;
            this.gbPacking.Text = "Packing";
            // 
            // lblUnitOfOuterBox
            // 
            this.lblUnitOfOuterBox.Location = new System.Drawing.Point(197, 62);
            this.lblUnitOfOuterBox.Name = "lblUnitOfOuterBox";
            this.lblUnitOfOuterBox.Size = new System.Drawing.Size(100, 23);
            this.lblUnitOfOuterBox.TabIndex = 15;
            this.lblUnitOfOuterBox.Text = "Unit";
            // 
            // lblUnitOfInnerBox
            // 
            this.lblUnitOfInnerBox.Location = new System.Drawing.Point(198, 37);
            this.lblUnitOfInnerBox.Name = "lblUnitOfInnerBox";
            this.lblUnitOfInnerBox.Size = new System.Drawing.Size(100, 23);
            this.lblUnitOfInnerBox.TabIndex = 14;
            this.lblUnitOfInnerBox.Text = "Unit";
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
            this.ansToolbar.TabIndex = 17;
            // 
            // ShippingInfo
            // 
            this.Controls.Add(this.gbPacking);
            this.Controls.Add(this.ansToolbar);
            this.Controls.Add(this.gbShippingInfo);
            this.Controls.Add(this.boxDimension);
            this.Controls.Add(this.boxWeight);
            this.FormBorderStyle = Gizmox.WebGUI.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Size = new System.Drawing.Size(424, 498);
            this.Text = "ShippingInfo";
            this.ResumeLayout(false);

        }

        #endregion

        private Gizmox.WebGUI.Forms.GroupBox boxWeight;
        private Gizmox.WebGUI.Forms.Button cmdConvertToKg;
        private Gizmox.WebGUI.Forms.Button cmdConvertToLb;
        private Gizmox.WebGUI.Forms.TextBox txtNetKG;
        private Gizmox.WebGUI.Forms.TextBox txtGrossKG;
        private Gizmox.WebGUI.Forms.Label lblInKG;
        private Gizmox.WebGUI.Forms.TextBox txtNetLB;
        private Gizmox.WebGUI.Forms.TextBox txtGrossLB;
        private Gizmox.WebGUI.Forms.Label lblInLB;
        private Gizmox.WebGUI.Forms.Label lblNet;
        private Gizmox.WebGUI.Forms.Label lblGross;
        private Gizmox.WebGUI.Forms.GroupBox boxDimension;
        private Gizmox.WebGUI.Forms.Button cmdConvertToVolumn;
        private Gizmox.WebGUI.Forms.Button cmdConvertToCm;
        private Gizmox.WebGUI.Forms.Button cmdConvertToInch;
        private Gizmox.WebGUI.Forms.Label lblCUFT;
        private Gizmox.WebGUI.Forms.TextBox txtVolumn;
        private Gizmox.WebGUI.Forms.Label lblVolum;
        private Gizmox.WebGUI.Forms.TextBox txtHeightCm;
        private Gizmox.WebGUI.Forms.TextBox txtWidthCm;
        private Gizmox.WebGUI.Forms.TextBox txtLengthCm;
        private Gizmox.WebGUI.Forms.Label lblInCm;
        private Gizmox.WebGUI.Forms.TextBox txtHeightInch;
        private Gizmox.WebGUI.Forms.TextBox txtWidthInch;
        private Gizmox.WebGUI.Forms.TextBox txtLengthInch;
        private Gizmox.WebGUI.Forms.Label lblInInch;
        private Gizmox.WebGUI.Forms.Label lblHeight;
        private Gizmox.WebGUI.Forms.Label lblWidth;
        private Gizmox.WebGUI.Forms.Label lblLength;
        private Gizmox.WebGUI.Forms.Label lblOuterBox;
        private Gizmox.WebGUI.Forms.TextBox txtOuterBox;
        private Gizmox.WebGUI.Forms.Label lblInnerBox;
        private Gizmox.WebGUI.Forms.TextBox txtInnerBox;
        private Gizmox.WebGUI.Forms.GroupBox gbShippingInfo;
        private Gizmox.WebGUI.Forms.GroupBox gbPacking;
        private Gizmox.WebGUI.Forms.ToolBar ansToolbar;
        private Gizmox.WebGUI.Forms.ComboBox cboShippingMark;
        private Gizmox.WebGUI.Forms.TextBox txtShippingMark;
        private Gizmox.WebGUI.Forms.Label lblShippingMark;
        private Gizmox.WebGUI.Forms.Label lblUnitOfOuterBox;
        private Gizmox.WebGUI.Forms.Label lblUnitOfInnerBox;
        private Gizmox.WebGUI.Forms.TextBox txtLineNumber;
        private Gizmox.WebGUI.Forms.Label lblLineNumber;
        private Gizmox.WebGUI.Forms.ToolTip toolTip1;


    }
}