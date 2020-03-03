namespace xPort5.Settings.Coding
{
    partial class MigrateProductPicture
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
            this.wsp = new Gizmox.WebGUI.Forms.Panel();
            this.pbProgress = new Gizmox.WebGUI.Forms.ProgressBar();
            this.cmdMigrate = new Gizmox.WebGUI.Forms.Button();
            this.gbResult = new Gizmox.WebGUI.Forms.GroupBox();
            this.lblExistedPicures = new Gizmox.WebGUI.Forms.Label();
            this.lblMissedPicture = new Gizmox.WebGUI.Forms.Label();
            this.txtExistedPicture = new Gizmox.WebGUI.Forms.Label();
            this.label2 = new Gizmox.WebGUI.Forms.Label();
            this.txtMissedPicture = new Gizmox.WebGUI.Forms.Label();
            this.SuspendLayout();
            // 
            // wsp
            // 
            this.wsp.Anchor = Gizmox.WebGUI.Forms.AnchorStyles.None;
            this.wsp.BackColor = System.Drawing.Color.White;
            this.wsp.Controls.Add(this.label2);
            this.wsp.Controls.Add(this.gbResult);
            this.wsp.Controls.Add(this.pbProgress);
            this.wsp.Controls.Add(this.cmdMigrate);
            this.wsp.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.wsp.Location = new System.Drawing.Point(0, 0);
            this.wsp.Name = "wsp";
            this.wsp.Size = new System.Drawing.Size(471, 387);
            this.wsp.TabIndex = 25;
            // 
            // pbProgress
            // 
            this.pbProgress.Location = new System.Drawing.Point(32, 70);
            this.pbProgress.Name = "pbProgress";
            this.pbProgress.Size = new System.Drawing.Size(180, 23);
            this.pbProgress.TabIndex = 25;
            // 
            // cmdMigrate
            // 
            this.cmdMigrate.Location = new System.Drawing.Point(32, 27);
            this.cmdMigrate.Name = "cmdMigrate";
            this.cmdMigrate.Size = new System.Drawing.Size(180, 21);
            this.cmdMigrate.TabIndex = 24;
            this.cmdMigrate.Text = "Migrate Product Picture";
            this.cmdMigrate.Click += new System.EventHandler(this.cmdMigrate_Click);
            // 
            // gbResult
            // 
            this.gbResult.Controls.Add(this.txtMissedPicture);
            this.gbResult.Controls.Add(this.txtExistedPicture);
            this.gbResult.Controls.Add(this.lblMissedPicture);
            this.gbResult.Controls.Add(this.lblExistedPicures);
            this.gbResult.FlatStyle = Gizmox.WebGUI.Forms.FlatStyle.Flat;
            this.gbResult.Location = new System.Drawing.Point(32, 126);
            this.gbResult.Name = "gbResult";
            this.gbResult.Size = new System.Drawing.Size(260, 125);
            this.gbResult.TabIndex = 26;
            this.gbResult.Text = "Result";
            this.gbResult.Visible = false;
            // 
            // lblExistedPicures
            // 
            this.lblExistedPicures.Location = new System.Drawing.Point(24, 36);
            this.lblExistedPicures.Name = "lblExistedPicures";
            this.lblExistedPicures.Size = new System.Drawing.Size(54, 23);
            this.lblExistedPicures.TabIndex = 0;
            this.lblExistedPicures.Text = "Exists:";
            // 
            // lblMissedPicture
            // 
            this.lblMissedPicture.Location = new System.Drawing.Point(24, 72);
            this.lblMissedPicture.Name = "lblMissedPicture";
            this.lblMissedPicture.Size = new System.Drawing.Size(54, 23);
            this.lblMissedPicture.TabIndex = 1;
            this.lblMissedPicture.Text = "Missing:";
            // 
            // txtExistedPicture
            // 
            this.txtExistedPicture.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.txtExistedPicture.ForeColor = System.Drawing.Color.Blue;
            this.txtExistedPicture.Location = new System.Drawing.Point(84, 34);
            this.txtExistedPicture.Name = "txtExistedPicture";
            this.txtExistedPicture.Size = new System.Drawing.Size(151, 23);
            this.txtExistedPicture.TabIndex = 2;
            this.txtExistedPicture.Text = "0";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(-15, -15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 27;
            this.label2.Text = "label2";
            // 
            // txtMissedPicture
            // 
            this.txtMissedPicture.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.txtMissedPicture.ForeColor = System.Drawing.Color.Red;
            this.txtMissedPicture.Location = new System.Drawing.Point(84, 70);
            this.txtMissedPicture.Name = "txtMissedPicture";
            this.txtMissedPicture.Size = new System.Drawing.Size(151, 23);
            this.txtMissedPicture.TabIndex = 2;
            this.txtMissedPicture.Text = "0";
            // 
            // MigrateProductPicture
            // 
            this.Controls.Add(this.wsp);
            this.Size = new System.Drawing.Size(471, 387);
            this.Text = "Migrate Product Picture";
            this.ResumeLayout(false);

        }

        #endregion

        private Gizmox.WebGUI.Forms.Panel wsp;
        private Gizmox.WebGUI.Forms.Button cmdMigrate;
        private Gizmox.WebGUI.Forms.ProgressBar pbProgress;
        private Gizmox.WebGUI.Forms.GroupBox gbResult;
        private Gizmox.WebGUI.Forms.Label lblMissedPicture;
        private Gizmox.WebGUI.Forms.Label lblExistedPicures;
        private Gizmox.WebGUI.Forms.Label label2;
        private Gizmox.WebGUI.Forms.Label txtMissedPicture;
        private Gizmox.WebGUI.Forms.Label txtExistedPicture;


    }
}