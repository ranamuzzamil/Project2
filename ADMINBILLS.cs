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
    public partial class ADMINBILLS : Form
    {
        SqlConnection con = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename=C:\\Users\\Dell\\Desktop\\C# User Registration Form\\User Registration\\User Registration\\LoginDB.mdf;Integrated Security = True; Connect Timeout = 30");
        SqlCommand cmd;
        SqlDataAdapter adapt;
        DataTable dt;
        //ID variable used in Updating and Deleting Record  
        int ID = 0;
        public ADMINBILLS()
        {
            InitializeComponent();
            DisplayData();
            DisplayValue();
        }
        public void DisplayValue()
        {
            con.Open();
            adapt = new SqlDataAdapter("select * from bills", con);
            dt = new DataTable();
            adapt.Fill(dt);
            dataGridView2.DataSource = dt;

            con.Close();
        }
        public void SearchData(string search)
        {
            con.Open();
            string query = "select* from bills where user_name like'%" + search + "%' ";
            adapt = new SqlDataAdapter(query, con);
            dt = new DataTable();
            adapt.Fill(dt);
            dataGridView2.DataSource = dt;


            con.Close();


        }
        private void ADMINBILLS_Load(object sender, EventArgs e)
        {
            

        }
        private void DisplayData()
        {
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select * from bills", con);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
        private void ClearData()
        {
            txt_user.Text = "";
            txt_bill.Text = "";
            ID = 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (txt_user.Text != "" && txt_bill.Text != "")
            {
                cmd = new SqlCommand("insert into bills (ID,user_name,bill) values((Select Max(ID) from bills) + 1,@user,@bill)", con);
                con.Open();
                cmd.Parameters.AddWithValue("@user", txt_user.Text);
                cmd.Parameters.AddWithValue("@bill", txt_bill.Text);
                
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Bill added Successfully");
                DisplayData();
                ClearData();
            }
            else
            {
                MessageBox.Show("Please add Details!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ADMINHOME().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (ID != 0)
            {
                cmd = new SqlCommand("delete bills where ID=@ID", con);
                con.Open();
                cmd.Parameters.AddWithValue("@ID", ID);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Bill Deleted Successfully!");
                DisplayData();
                ClearData();
            }
            else
            {
                MessageBox.Show("Please Select Record to Delete");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (txt_user.Text != "" && txt_bill.Text != "")
            {
                cmd = new SqlCommand("update bills set user_name=@user,bill=@bill where ID=@ID", con);
                con.Open();
                cmd.Parameters.AddWithValue("@ID", ID);
                cmd.Parameters.AddWithValue("@user", txt_user.Text);
                cmd.Parameters.AddWithValue("@bill", txt_bill.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Bill Updated Successfully");
                con.Close();
                DisplayData();
                ClearData();
            }
            else
            {
                MessageBox.Show("Please Select bill to Update");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            txt_user.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_bill.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            SearchData(textBox1.Text);
        }
    }
}
