using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Windows.Forms.DataVisualization.Charting;

namespace User_Registration
{
    public partial class APPLY : Form
    {
        SqlConnection con = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename=C:\\Users\\Dell\\Desktop\\C# User Registration Form\\User Registration\\User Registration\\LoginDB.mdf;Integrated Security = True; Connect Timeout = 30");
        SqlCommand cmd;
        SqlDataAdapter adapt;
        
        public APPLY()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "" && textBox6.Text != "")
            {
                cmd = new SqlCommand("insert into approval(Id,property_id,status,rent,address,applicant_name,applicant_contact) values((Select Max(Id) from approval) + 1 ,@property_id,@status,@rent,@address,@name,@contact)", con);
                con.Open();
                cmd.Parameters.AddWithValue("@property_id", textBox1.Text);
                cmd.Parameters.AddWithValue("@status", textBox2.Text);
                cmd.Parameters.AddWithValue("@rent", textBox3.Text);
                cmd.Parameters.AddWithValue("@address", textBox4.Text);
                cmd.Parameters.AddWithValue("@name", textBox5.Text);
                cmd.Parameters.AddWithValue("@contact", textBox6.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Applied Successfully");
                this.Hide();
                new HOME().Show();
            }
            else
            {
                MessageBox.Show("Please Provide Your Details!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new HOME().Show();
        }

        private void APPLY_Load(object sender, EventArgs e)
        {

        }
    }
}
