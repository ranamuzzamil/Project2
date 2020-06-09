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
    public partial class DASHBOARD : Form
    {

        SqlConnection con = new SqlConnection("Data Source =(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Dell\\Desktop\\C# User Registration Form\\User Registration\\User Registration\\LoginDB.mdf;Integrated Security = True; Connect Timeout = 30");
      
        DataTable dt;
        SqlDataAdapter adpt;

        
        public DASHBOARD()
        {
            
            InitializeComponent();
            
            DisplayValue();

        }
        public void DisplayValue()
        {
            con.Open();
            adpt = new SqlDataAdapter("select * from property", con);
            dt = new DataTable();
            adpt.Fill(dt);
            dataGridView1.DataSource = dt;

            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new HOME().Show();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void txtSearchBox_TextChanged(object sender, EventArgs e)
        {
            SearchData(txtSearchBox.Text);
        }
        public void SearchData(string search)
        {
            con.Open();
            string query = "select* from property where Property like'%" + search + "%' ";
            adpt = new SqlDataAdapter(query, con);
            dt = new DataTable();
            adpt.Fill(dt);
            dataGridView1.DataSource = dt;


            con.Close();


        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source =(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Dell\\Desktop\\C# User Registration Form\\User Registration\\User Registration\\LoginDB.mdf;Integrated Security = True; Connect Timeout = 30");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from PropertyNo", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet st = new DataSet();
            sda.Fill(st, "chart");

            chart1.DataSource = st.Tables["chart"];
            chart1.Series["chart"].XValueMember = "Property";
            chart1.Series["chart"].YValueMembers = "Total";
            this.chart1.Titles.Add("PROPERTIES ANALYTICS");
            chart1.Series["chart"].ChartType = SeriesChartType.Pie;
            chart1.Series["chart"].IsValueShownAsLabel = true;
            con.Close();
        }
    }
}
