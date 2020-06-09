namespace User_Registration
{
    partial class ADMINPROPERTY
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ADMINPROPERTY));
            this.loginDBDataSet5 = new User_Registration.LoginDBDataSet5();
            this.sampleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sampleTableAdapter = new User_Registration.LoginDBDataSet5TableAdapters.SampleTableAdapter();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.txt_suburb = new System.Windows.Forms.TextBox();
            this.txt_room = new System.Windows.Forms.TextBox();
            this.txt_rent = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.txt_Status = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Insert = new System.Windows.Forms.Button();
            this.txt_property = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.a = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.loginDBDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sampleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.a.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // loginDBDataSet5
            // 
            this.loginDBDataSet5.DataSetName = "LoginDBDataSet5";
            this.loginDBDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sampleBindingSource
            // 
            this.sampleBindingSource.DataMember = "Sample";
            this.sampleBindingSource.DataSource = this.loginDBDataSet5;
            // 
            // sampleTableAdapter
            // 
            this.sampleTableAdapter.ClearBeforeFill = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 330);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 20);
            this.label6.TabIndex = 34;
            this.label6.Text = "SUBURB";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 274);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 20);
            this.label5.TabIndex = 33;
            this.label5.Text = "ROOMS";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 20);
            this.label4.TabIndex = 32;
            this.label4.Text = "STREET";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 20);
            this.label3.TabIndex = 31;
            this.label3.Text = "RENT";
            // 
            // txt_address
            // 
            this.txt_address.Location = new System.Drawing.Point(141, 220);
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(100, 26);
            this.txt_address.TabIndex = 30;
            // 
            // txt_suburb
            // 
            this.txt_suburb.Location = new System.Drawing.Point(141, 324);
            this.txt_suburb.Name = "txt_suburb";
            this.txt_suburb.Size = new System.Drawing.Size(100, 26);
            this.txt_suburb.TabIndex = 29;
            // 
            // txt_room
            // 
            this.txt_room.Location = new System.Drawing.Point(141, 274);
            this.txt_room.Name = "txt_room";
            this.txt_room.Size = new System.Drawing.Size(100, 26);
            this.txt_room.TabIndex = 28;
            // 
            // txt_rent
            // 
            this.txt_rent.Location = new System.Drawing.Point(141, 169);
            this.txt_rent.Name = "txt_rent";
            this.txt_rent.Size = new System.Drawing.Size(100, 26);
            this.txt_rent.TabIndex = 27;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1134, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 39);
            this.button1.TabIndex = 26;
            this.button1.Text = "BACK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(25, 430);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1278, 175);
            this.dataGridView1.TabIndex = 25;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick_1);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(348, 373);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(127, 35);
            this.btn_Delete.TabIndex = 24;
            this.btn_Delete.Text = "DELETE PROPERTY";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.Btn_Delete_Click_1);
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(190, 373);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(140, 35);
            this.btn_Update.TabIndex = 23;
            this.btn_Update.Text = "UPDATE PROPERTY";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.Btn_Update_Click_1);
            // 
            // txt_Status
            // 
            this.txt_Status.Location = new System.Drawing.Point(141, 118);
            this.txt_Status.Name = "txt_Status";
            this.txt_Status.Size = new System.Drawing.Size(100, 26);
            this.txt_Status.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "STATUS";
            // 
            // btn_Insert
            // 
            this.btn_Insert.Location = new System.Drawing.Point(20, 373);
            this.btn_Insert.Name = "btn_Insert";
            this.btn_Insert.Size = new System.Drawing.Size(159, 35);
            this.btn_Insert.TabIndex = 20;
            this.btn_Insert.Text = "ADD PROPERTY";
            this.btn_Insert.UseVisualStyleBackColor = true;
            this.btn_Insert.Click += new System.EventHandler(this.Btn_Insert_Click_1);
            // 
            // txt_property
            // 
            this.txt_property.Location = new System.Drawing.Point(141, 69);
            this.txt_property.Name = "txt_property";
            this.txt_property.Size = new System.Drawing.Size(100, 26);
            this.txt_property.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "PROPERTY";
            // 
            // a
            // 
            this.a.Controls.Add(this.button2);
            this.a.Controls.Add(this.chart1);
            this.a.Controls.Add(this.label7);
            this.a.Controls.Add(this.dataGridView1);
            this.a.Controls.Add(this.label6);
            this.a.Controls.Add(this.label2);
            this.a.Controls.Add(this.label5);
            this.a.Controls.Add(this.label1);
            this.a.Controls.Add(this.label4);
            this.a.Controls.Add(this.txt_property);
            this.a.Controls.Add(this.label3);
            this.a.Controls.Add(this.btn_Insert);
            this.a.Controls.Add(this.txt_address);
            this.a.Controls.Add(this.txt_Status);
            this.a.Controls.Add(this.txt_suburb);
            this.a.Controls.Add(this.btn_Update);
            this.a.Controls.Add(this.txt_room);
            this.a.Controls.Add(this.btn_Delete);
            this.a.Controls.Add(this.txt_rent);
            this.a.Location = new System.Drawing.Point(12, 71);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(1309, 638);
            this.a.TabIndex = 35;
            this.a.TabStop = false;
            this.a.Enter += new System.EventHandler(this.A_Enter);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1046, 311);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 39);
            this.button2.TabIndex = 37;
            this.button2.Text = "LOAD DATA";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(681, 50);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "chart";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(482, 300);
            this.chart1.TabIndex = 36;
            this.chart1.Text = "chart1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(341, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(523, 37);
            this.label7.TabIndex = 35;
            this.label7.Text = "PROPERTIES ADVERTISEMENT";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(277, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            // 
            // ADMINPROPERTY
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1328, 744);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.a);
            this.Name = "ADMINPROPERTY";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ADMINPROPERTY";
            this.Load += new System.EventHandler(this.ADMINPROPERTY_Load);
            ((System.ComponentModel.ISupportInitialize)(this.loginDBDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sampleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.a.ResumeLayout(false);
            this.a.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private LoginDBDataSet5 loginDBDataSet5;
        private System.Windows.Forms.BindingSource sampleBindingSource;
        private LoginDBDataSet5TableAdapters.SampleTableAdapter sampleTableAdapter;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_address;
        private System.Windows.Forms.TextBox txt_suburb;
        private System.Windows.Forms.TextBox txt_room;
        private System.Windows.Forms.TextBox txt_rent;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.TextBox txt_Status;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Insert;
        private System.Windows.Forms.TextBox txt_property;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox a;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button button2;
    }
}