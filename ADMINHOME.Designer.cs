namespace User_Registration
{
    partial class ADMINHOME
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ADMINHOME));
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.patientRegistrationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.patientInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.roomInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aDDPROPERTIESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lEASEBUYAPPLICATIONSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pROPERTIESDETAILSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addStaffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fINANCEAPPLICATIONSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewCheckoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cLIENTSBILLSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.iNCOMEANALYSISToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nOTIFICATIONSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.AllowDrop = true;
            this.button1.Location = new System.Drawing.Point(1126, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 55);
            this.button1.TabIndex = 0;
            this.button1.Text = "SIGN OUT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(461, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(277, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // patientRegistrationToolStripMenuItem
            // 
            this.patientRegistrationToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientRegistrationToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.patientRegistrationToolStripMenuItem.Name = "patientRegistrationToolStripMenuItem";
            this.patientRegistrationToolStripMenuItem.Size = new System.Drawing.Size(132, 33);
            this.patientRegistrationToolStripMenuItem.Text = "ACCESS";
            this.patientRegistrationToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.patientRegistrationToolStripMenuItem.Click += new System.EventHandler(this.PatientRegistrationToolStripMenuItem_Click);
            // 
            // patientInformationToolStripMenuItem
            // 
            this.patientInformationToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientInformationToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.patientInformationToolStripMenuItem.Name = "patientInformationToolStripMenuItem";
            this.patientInformationToolStripMenuItem.Size = new System.Drawing.Size(187, 33);
            this.patientInformationToolStripMenuItem.Text = "DASHBOARD";
            this.patientInformationToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.patientInformationToolStripMenuItem.Click += new System.EventHandler(this.PatientInformationToolStripMenuItem_Click);
            // 
            // roomInfoToolStripMenuItem
            // 
            this.roomInfoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aDDPROPERTIESToolStripMenuItem,
            this.lEASEBUYAPPLICATIONSToolStripMenuItem,
            this.pROPERTIESDETAILSToolStripMenuItem});
            this.roomInfoToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomInfoToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.roomInfoToolStripMenuItem.Name = "roomInfoToolStripMenuItem";
            this.roomInfoToolStripMenuItem.Size = new System.Drawing.Size(194, 33);
            this.roomInfoToolStripMenuItem.Text = "PROPERTIES";
            this.roomInfoToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.roomInfoToolStripMenuItem.Click += new System.EventHandler(this.RoomInfoToolStripMenuItem_Click);
            // 
            // aDDPROPERTIESToolStripMenuItem
            // 
            this.aDDPROPERTIESToolStripMenuItem.Name = "aDDPROPERTIESToolStripMenuItem";
            this.aDDPROPERTIESToolStripMenuItem.Size = new System.Drawing.Size(449, 38);
            this.aDDPROPERTIESToolStripMenuItem.Text = "ADD PROPERTIES";
            this.aDDPROPERTIESToolStripMenuItem.Click += new System.EventHandler(this.aDDPROPERTIESToolStripMenuItem_Click);
            // 
            // lEASEBUYAPPLICATIONSToolStripMenuItem
            // 
            this.lEASEBUYAPPLICATIONSToolStripMenuItem.Name = "lEASEBUYAPPLICATIONSToolStripMenuItem";
            this.lEASEBUYAPPLICATIONSToolStripMenuItem.Size = new System.Drawing.Size(449, 38);
            this.lEASEBUYAPPLICATIONSToolStripMenuItem.Text = "LEASE/BUY APPLICATIONS";
            this.lEASEBUYAPPLICATIONSToolStripMenuItem.Click += new System.EventHandler(this.lEASEBUYAPPLICATIONSToolStripMenuItem_Click);
            // 
            // pROPERTIESDETAILSToolStripMenuItem
            // 
            this.pROPERTIESDETAILSToolStripMenuItem.Name = "pROPERTIESDETAILSToolStripMenuItem";
            this.pROPERTIESDETAILSToolStripMenuItem.Size = new System.Drawing.Size(449, 38);
            this.pROPERTIESDETAILSToolStripMenuItem.Text = "PROPERTIES DETAILS";
            this.pROPERTIESDETAILSToolStripMenuItem.Click += new System.EventHandler(this.pROPERTIESDETAILSToolStripMenuItem_Click);
            // 
            // addStaffToolStripMenuItem
            // 
            this.addStaffToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fINANCEAPPLICATIONSToolStripMenuItem});
            this.addStaffToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addStaffToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.addStaffToolStripMenuItem.Name = "addStaffToolStripMenuItem";
            this.addStaffToolStripMenuItem.Size = new System.Drawing.Size(141, 33);
            this.addStaffToolStripMenuItem.Text = "FINANCE";
            this.addStaffToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // fINANCEAPPLICATIONSToolStripMenuItem
            // 
            this.fINANCEAPPLICATIONSToolStripMenuItem.Name = "fINANCEAPPLICATIONSToolStripMenuItem";
            this.fINANCEAPPLICATIONSToolStripMenuItem.Size = new System.Drawing.Size(420, 38);
            this.fINANCEAPPLICATIONSToolStripMenuItem.Text = "FINANCE APPLICATIONS";
            this.fINANCEAPPLICATIONSToolStripMenuItem.Click += new System.EventHandler(this.FINANCEAPPLICATIONSToolStripMenuItem_Click);
            // 
            // viewCheckoutToolStripMenuItem
            // 
            this.viewCheckoutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cLIENTSBILLSToolStripMenuItem});
            this.viewCheckoutToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewCheckoutToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.viewCheckoutToolStripMenuItem.Name = "viewCheckoutToolStripMenuItem";
            this.viewCheckoutToolStripMenuItem.Size = new System.Drawing.Size(98, 33);
            this.viewCheckoutToolStripMenuItem.Text = "BILLS";
            this.viewCheckoutToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.viewCheckoutToolStripMenuItem.Click += new System.EventHandler(this.viewCheckoutToolStripMenuItem_Click);
            // 
            // cLIENTSBILLSToolStripMenuItem
            // 
            this.cLIENTSBILLSToolStripMenuItem.Name = "cLIENTSBILLSToolStripMenuItem";
            this.cLIENTSBILLSToolStripMenuItem.Size = new System.Drawing.Size(301, 38);
            this.cLIENTSBILLSToolStripMenuItem.Text = "CLIENTS BILLS";
            this.cLIENTSBILLSToolStripMenuItem.Click += new System.EventHandler(this.cLIENTSBILLSToolStripMenuItem_Click);
            // 
            // checkoutToolStripMenuItem
            // 
            this.checkoutToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkoutToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.checkoutToolStripMenuItem.Name = "checkoutToolStripMenuItem";
            this.checkoutToolStripMenuItem.Size = new System.Drawing.Size(182, 33);
            this.checkoutToolStripMenuItem.Text = "FEEDBACKS";
            this.checkoutToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.checkoutToolStripMenuItem.Click += new System.EventHandler(this.checkoutToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.patientRegistrationToolStripMenuItem,
            this.patientInformationToolStripMenuItem,
            this.roomInfoToolStripMenuItem,
            this.addStaffToolStripMenuItem,
            this.viewCheckoutToolStripMenuItem,
            this.checkoutToolStripMenuItem,
            this.iNCOMEANALYSISToolStripMenuItem,
            this.nOTIFICATIONSToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Table;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.ShowItemToolTips = true;
            this.menuStrip1.Size = new System.Drawing.Size(253, 744);
            this.menuStrip1.Stretch = false;
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // iNCOMEANALYSISToolStripMenuItem
            // 
            this.iNCOMEANALYSISToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iNCOMEANALYSISToolStripMenuItem.Name = "iNCOMEANALYSISToolStripMenuItem";
            this.iNCOMEANALYSISToolStripMenuItem.Size = new System.Drawing.Size(247, 30);
            this.iNCOMEANALYSISToolStripMenuItem.Text = "INCOME ANALYSIS";
            this.iNCOMEANALYSISToolStripMenuItem.Click += new System.EventHandler(this.iNCOMEANALYSISToolStripMenuItem_Click);
            // 
            // nOTIFICATIONSToolStripMenuItem
            // 
            this.nOTIFICATIONSToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nOTIFICATIONSToolStripMenuItem.Name = "nOTIFICATIONSToolStripMenuItem";
            this.nOTIFICATIONSToolStripMenuItem.Size = new System.Drawing.Size(229, 33);
            this.nOTIFICATIONSToolStripMenuItem.Text = "NOTIFICATIONS";
            this.nOTIFICATIONSToolStripMenuItem.Click += new System.EventHandler(this.nOTIFICATIONSToolStripMenuItem_Click);
            // 
            // ADMINHOME
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1278, 744);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Name = "ADMINHOME";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ADMINHOME";
            this.MinimumSizeChanged += new System.EventHandler(this.ADMINHOME_Load);
            this.Load += new System.EventHandler(this.ADMINHOME_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem patientRegistrationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem patientInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem roomInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addStaffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fINANCEAPPLICATIONSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewCheckoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkoutToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cLIENTSBILLSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aDDPROPERTIESToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lEASEBUYAPPLICATIONSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pROPERTIESDETAILSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iNCOMEANALYSISToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nOTIFICATIONSToolStripMenuItem;
    }
}