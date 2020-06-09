namespace User_Registration
{
    partial class A_NOTIFICATION
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(A_NOTIFICATION));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_user = new System.Windows.Forms.TextBox();
            this.txt_bill = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.loginDBDataSet8 = new User_Registration.LoginDBDataSet8();
            this.loginDBDataSet8BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.notificationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.notificationTableAdapter = new User_Registration.LoginDBDataSet8TableAdapters.notificationTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maintananceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.utilituesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginDBDataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginDBDataSet8BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.notificationBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(277, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_user);
            this.groupBox1.Controls.Add(this.txt_bill);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Location = new System.Drawing.Point(74, 137);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(935, 415);
            this.groupBox1.TabIndex = 80;
            this.groupBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.usernameDataGridViewTextBoxColumn,
            this.maintananceDataGridViewTextBoxColumn,
            this.utilituesDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.notificationBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(10, 131);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(889, 237);
            this.dataGridView1.TabIndex = 85;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 20);
            this.label2.TabIndex = 82;
            this.label2.Text = "MAINTAINANCE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.TabIndex = 80;
            this.label1.Text = "UTILITIES";
            // 
            // txt_user
            // 
            this.txt_user.Location = new System.Drawing.Point(178, 54);
            this.txt_user.Name = "txt_user";
            this.txt_user.Size = new System.Drawing.Size(611, 26);
            this.txt_user.TabIndex = 81;
            // 
            // txt_bill
            // 
            this.txt_bill.Location = new System.Drawing.Point(178, 14);
            this.txt_bill.Name = "txt_bill";
            this.txt_bill.Size = new System.Drawing.Size(611, 26);
            this.txt_bill.TabIndex = 83;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(792, 374);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(107, 32);
            this.button3.TabIndex = 79;
            this.button3.Text = "SEND";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // loginDBDataSet8
            // 
            this.loginDBDataSet8.DataSetName = "LoginDBDataSet8";
            this.loginDBDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // loginDBDataSet8BindingSource
            // 
            this.loginDBDataSet8BindingSource.DataSource = this.loginDBDataSet8;
            this.loginDBDataSet8BindingSource.Position = 0;
            // 
            // notificationBindingSource
            // 
            this.notificationBindingSource.DataMember = "notification";
            this.notificationBindingSource.DataSource = this.loginDBDataSet8BindingSource;
            // 
            // notificationTableAdapter
            // 
            this.notificationTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Width = 150;
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "user_name";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "user_name";
            this.usernameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            this.usernameDataGridViewTextBoxColumn.Width = 150;
            // 
            // maintananceDataGridViewTextBoxColumn
            // 
            this.maintananceDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.maintananceDataGridViewTextBoxColumn.DataPropertyName = "maintanance";
            this.maintananceDataGridViewTextBoxColumn.HeaderText = "maintanance";
            this.maintananceDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.maintananceDataGridViewTextBoxColumn.Name = "maintananceDataGridViewTextBoxColumn";
            // 
            // utilituesDataGridViewTextBoxColumn
            // 
            this.utilituesDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.utilituesDataGridViewTextBoxColumn.DataPropertyName = "utilitues";
            this.utilituesDataGridViewTextBoxColumn.HeaderText = "utilitues";
            this.utilituesDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.utilituesDataGridViewTextBoxColumn.Name = "utilituesDataGridViewTextBoxColumn";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1051, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 32);
            this.button1.TabIndex = 81;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // A_NOTIFICATION
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1328, 744);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "A_NOTIFICATION";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "A_NOTIFICATION";
            this.Load += new System.EventHandler(this.A_NOTIFICATION_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginDBDataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginDBDataSet8BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.notificationBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_user;
        private System.Windows.Forms.TextBox txt_bill;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.BindingSource loginDBDataSet8BindingSource;
        private LoginDBDataSet8 loginDBDataSet8;
        private System.Windows.Forms.BindingSource notificationBindingSource;
        private LoginDBDataSet8TableAdapters.notificationTableAdapter notificationTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maintananceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn utilituesDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
    }
}