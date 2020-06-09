namespace User_Registration
{
    partial class ADMINAPPROVAL
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ADMINAPPROVAL));
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.propertyidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.applicantnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.applicantcontactDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.approvalBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.approval = new User_Registration.approval();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_property = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.approvalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.approvalTableAdapter = new User_Registration.approvalTableAdapters.approvalTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.approvalBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.approval)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.approvalBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1209, 213);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(107, 32);
            this.button3.TabIndex = 71;
            this.button3.Text = "APPROVE";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1212, 398);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 32);
            this.button2.TabIndex = 70;
            this.button2.Text = "REJECT";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(531, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(184, 26);
            this.label5.TabIndex = 69;
            this.label5.Text = "APPLICATIONS";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1112, 128);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 32);
            this.button1.TabIndex = 68;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.propertyidDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.rentDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.applicantnameDataGridViewTextBoxColumn,
            this.applicantcontactDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.approvalBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(39, 251);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1277, 138);
            this.dataGridView1.TabIndex = 67;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Width = 150;
            // 
            // propertyidDataGridViewTextBoxColumn
            // 
            this.propertyidDataGridViewTextBoxColumn.DataPropertyName = "property_id";
            this.propertyidDataGridViewTextBoxColumn.HeaderText = "property_id";
            this.propertyidDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.propertyidDataGridViewTextBoxColumn.Name = "propertyidDataGridViewTextBoxColumn";
            this.propertyidDataGridViewTextBoxColumn.Width = 150;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "status";
            this.statusDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.Width = 150;
            // 
            // rentDataGridViewTextBoxColumn
            // 
            this.rentDataGridViewTextBoxColumn.DataPropertyName = "rent";
            this.rentDataGridViewTextBoxColumn.HeaderText = "rent";
            this.rentDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.rentDataGridViewTextBoxColumn.Name = "rentDataGridViewTextBoxColumn";
            this.rentDataGridViewTextBoxColumn.Width = 150;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "address";
            this.addressDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.Width = 150;
            // 
            // applicantnameDataGridViewTextBoxColumn
            // 
            this.applicantnameDataGridViewTextBoxColumn.DataPropertyName = "applicant_name";
            this.applicantnameDataGridViewTextBoxColumn.HeaderText = "applicant_name";
            this.applicantnameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.applicantnameDataGridViewTextBoxColumn.Name = "applicantnameDataGridViewTextBoxColumn";
            this.applicantnameDataGridViewTextBoxColumn.Width = 150;
            // 
            // applicantcontactDataGridViewTextBoxColumn
            // 
            this.applicantcontactDataGridViewTextBoxColumn.DataPropertyName = "applicant_contact";
            this.applicantcontactDataGridViewTextBoxColumn.HeaderText = "applicant_contact";
            this.applicantcontactDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.applicantcontactDataGridViewTextBoxColumn.Name = "applicantcontactDataGridViewTextBoxColumn";
            this.applicantcontactDataGridViewTextBoxColumn.Width = 150;
            // 
            // approvalBindingSource1
            // 
            this.approvalBindingSource1.DataMember = "approval";
            this.approvalBindingSource1.DataSource = this.approval;
            // 
            // approval
            // 
            this.approval.DataSetName = "approval";
            this.approval.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(486, 88);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(277, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 66;
            this.pictureBox1.TabStop = false;
            // 
            // txt_property
            // 
            this.txt_property.Location = new System.Drawing.Point(1106, 401);
            this.txt_property.Name = "txt_property";
            this.txt_property.Size = new System.Drawing.Size(100, 26);
            this.txt_property.TabIndex = 73;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(1004, 399);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 26);
            this.label8.TabIndex = 84;
            this.label8.Text = "Enter Id";
            // 
            // approvalBindingSource
            // 
            this.approvalBindingSource.DataMember = "approval";
            this.approvalBindingSource.DataSource = this.approval;
            // 
            // approvalTableAdapter
            // 
            this.approvalTableAdapter.ClearBeforeFill = true;
            // 
            // ADMINAPPROVAL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1528, 744);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_property);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ADMINAPPROVAL";
            this.Text = "ADMINAPPROVAL";
            this.Load += new System.EventHandler(this.ADMINAPPROVAL_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.approvalBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.approval)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.approvalBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private approval approval;
        private System.Windows.Forms.BindingSource approvalBindingSource;
        private approvalTableAdapters.approvalTableAdapter approvalTableAdapter;
        private System.Windows.Forms.TextBox txt_property;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn propertyidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn applicantnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn applicantcontactDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource approvalBindingSource1;
    }
}