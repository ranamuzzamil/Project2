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

namespace User_Registration
{
    public partial class ADMINFINANCE : Form
    {

        SqlConnection con = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename=C:\\Users\\Dell\\Desktop\\C# User Registration Form\\User Registration\\User Registration\\LoginDB.mdf;Integrated Security = True; Connect Timeout = 30");
      
        DataTable dt;
        SqlDataAdapter adpt;


        string connectionString = ("Data Source =(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Dell\\Desktop\\C# User Registration Form\\User Registration\\User Registration\\LoginDB.mdf;Integrated Security = True; Connect Timeout = 30");
        public ADMINFINANCE()
        {
            InitializeComponent();
            DisplayValue();
        }
        public void DisplayValue()
        {
            con.Open();
            adpt = new SqlDataAdapter("select * from Finance", con);
            dt = new DataTable();
            adpt.Fill(dt);
            dataGridView1.DataSource = dt;

            con.Close();
        }

        private void ADMINFINANCE_Load(object sender, EventArgs e)
        {
         
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ADMINHOME().Show();
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
