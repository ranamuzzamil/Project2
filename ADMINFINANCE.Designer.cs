namespace User_Registration
{
    partial class ADMINFINANCE
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ADMINFINANCE));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.financeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.loginDBDataSet3 = new User_Registration.LoginDBDataSet3();
            this.financeTableAdapter = new User_Registration.LoginDBDataSet3TableAdapters.FinanceTableAdapter();
            this.loginDBDataSet3BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.loginDBDataSet3BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.loginDBDataSet4 = new User_Registration.LoginDBDataSet4();
            this.financeBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.financeTableAdapter1 = new User_Registration.LoginDBDataSet4TableAdapters.FinanceTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.financeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginDBDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginDBDataSet3BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginDBDataSet3BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginDBDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.financeBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(506, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(277, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // financeBindingSource
            // 
            this.financeBindingSource.DataMember = "Finance";
            this.financeBindingSource.DataSource = this.loginDBDataSet3;
            // 
            // loginDBDataSet3
            // 
            this.loginDBDataSet3.DataSetName = "LoginDBDataSet3";
            this.loginDBDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // financeTableAdapter
            // 
            this.financeTableAdapter.ClearBeforeFill = true;
            // 
            // loginDBDataSet3BindingSource
            // 
            this.loginDBDataSet3BindingSource.DataSource = this.loginDBDataSet3;
            this.loginDBDataSet3BindingSource.Position = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(59, 175);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1233, 207);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // loginDBDataSet3BindingSource1
            // 
            this.loginDBDataSet3BindingSource1.DataSource = this.loginDBDataSet3;
            this.loginDBDataSet3BindingSource1.Position = 0;
            // 
            // loginDBDataSet4
            // 
            this.loginDBDataSet4.DataSetName = "LoginDBDataSet4";
            this.loginDBDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // financeBindingSource1
            // 
            this.financeBindingSource1.DataMember = "Finance";
            this.financeBindingSource1.DataSource = this.loginDBDataSet4;
            // 
            // financeTableAdapter1
            // 
            this.financeTableAdapter1.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1132, 52);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 32);
            this.button1.TabIndex = 4;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(551, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(184, 26);
            this.label5.TabIndex = 63;
            this.label5.Text = "APPLICATIONS";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1217, 403);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 32);
            this.button2.TabIndex = 64;
            this.button2.Text = "REJECT";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1100, 403);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(107, 32);
            this.button3.TabIndex = 65;
            this.button3.Text = "APPROVE";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // ADMINFINANCE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1328, 744);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ADMINFINANCE";
            this.Text = "ADMINFINANCE";
            this.Load += new System.EventHandler(this.ADMINFINANCE_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.financeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginDBDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginDBDataSet3BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginDBDataSet3BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginDBDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.financeBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private LoginDBDataSet3 loginDBDataSet3;
        private System.Windows.Forms.BindingSource financeBindingSource;
        private LoginDBDataSet3TableAdapters.FinanceTableAdapter financeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn fIRSTNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lASTNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pROPERTYADDRESSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iNCOMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pERSONALCONTACTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pOSTCODEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMPLOYEENODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pASSPORTNODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jOBADDRESSDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource loginDBDataSet3BindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource loginDBDataSet3BindingSource1;
        private LoginDBDataSet4 loginDBDataSet4;
        private System.Windows.Forms.BindingSource financeBindingSource1;
        private LoginDBDataSet4TableAdapters.FinanceTableAdapter financeTableAdapter1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}