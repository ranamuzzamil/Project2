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
    public partial class ADMINAPPROVAL : Form
    {

        SqlConnection con = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename=C:\\Users\\Dell\\Desktop\\C# User Registration Form\\User Registration\\User Registration\\LoginDB.mdf;Integrated Security = True; Connect Timeout = 30");
        SqlCommand cmd;
        SqlDataAdapter adapt;

        
        
        public ADMINAPPROVAL()
        {
            InitializeComponent();
            DisplayData();
        }

        private void ADMINAPPROVAL_Load(object sender, EventArgs e)
        {
            
        
          

        }
        private void DisplayData()
        {
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select * from approval", con);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
        private void ClearData()
        {
            txt_property.Text = "";
           
        }
        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd = new SqlCommand("Delete From approval where Id = '"+ txt_property.Text+ "'",con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Application Rejected Sucessfully");
            DisplayData();
            ClearData();





        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.Hide();
            new ADMINHOME().Show();
        }
    }
}
