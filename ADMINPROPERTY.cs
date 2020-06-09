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
using User_Registration;
using System.Windows.Forms.DataVisualization.Charting;

namespace User_Registration
{
    public partial class ADMINPROPERTY : Form
    {
        SqlConnection con = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename=C:\\Users\\Dell\\Desktop\\C# User Registration Form\\User Registration\\User Registration\\LoginDB.mdf;Integrated Security = True; Connect Timeout = 30");
        SqlCommand cmd;
        SqlDataAdapter adapt;
        //ID variable used in Updating and Deleting Record  
        int ID = 0;
        public ADMINPROPERTY()
        {
            InitializeComponent();
            DisplayData();
        }

        private void ADMINPROPERTY_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'loginDBDataSet5.Sample' table. You can move, or remove it, as needed.
            this.sampleTableAdapter.Fill(this.loginDBDataSet5.Sample);

        }

        private void Btn_Insert_Click(object sender, EventArgs e)
        {

        }
        private void DisplayData()
        {
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select * from property", con);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
        private void ClearData()
        {
            txt_property.Text = "";
            txt_Status.Text = "";
            txt_rent.Text = "";
            txt_address.Text = "";
            txt_room.Text = "";
            txt_suburb.Text = "";
            ID = 0;
        }
        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void Btn_Update_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            if (ID != 0)
            {
                cmd = new SqlCommand("delete Sample where ID=@id", con);
                con.Open();
                cmd.Parameters.AddWithValue("@id", ID);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Deleted Successfully!");
                DisplayData();
                ClearData();
            }
            else
            {
                MessageBox.Show("Please Select Record to Delete");
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ADMINHOME().Show();

        }

        private void Btn_Insert_Click_1(object sender, EventArgs e)
        {
            if (txt_property.Text != "" && txt_Status.Text != "" && txt_rent.Text != "" && txt_address.Text != "" && txt_room.Text != "" && txt_suburb.Text != "")
            {
                cmd = new SqlCommand("insert into property(Id,Property,Status,Rent,Address,Rooms,Suburb) values((Select Max(Id) from property) + 1,@property,@status,@rent,@address,@rooms,@suburb)", con);
                con.Open();
                cmd.Parameters.AddWithValue("@property", txt_property.Text);
                cmd.Parameters.AddWithValue("@status", txt_Status.Text);
                cmd.Parameters.AddWithValue("@rent", txt_rent.Text);
                cmd.Parameters.AddWithValue("@address", txt_address.Text);
                cmd.Parameters.AddWithValue("@rooms", txt_room.Text);
                cmd.Parameters.AddWithValue("@suburb", txt_suburb.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Inserted Successfully");
                DisplayData();
                ClearData();
            }
            else
            {
                MessageBox.Show("Please Provide Details!");
            }
        }

        private void Btn_Update_Click_1(object sender, EventArgs e)
        {
            if (txt_property.Text != "" && txt_Status.Text != "")
            {
                cmd = new SqlCommand("update property set Property=@property,Status=@status,Rent=@rent,Address=@address,Rooms=@rooms,Suburb=@suburb where ID=@Id", con);
                con.Open();
                cmd.Parameters.AddWithValue("@Id", ID);
                cmd.Parameters.AddWithValue("@property", txt_property.Text);
                cmd.Parameters.AddWithValue("@status", txt_Status.Text);
                cmd.Parameters.AddWithValue("@rent", txt_rent.Text);
                cmd.Parameters.AddWithValue("@address", txt_address.Text);
                cmd.Parameters.AddWithValue("@rooms", txt_room.Text);
                cmd.Parameters.AddWithValue("@suburb", txt_suburb.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Updated Successfully");
                con.Close();
                DisplayData();
                ClearData();
            }
            else
            {
                MessageBox.Show("Please Select Record to Update");
            }
        }

        private void Btn_Delete_Click_1(object sender, EventArgs e)
        {
            if (ID != 0)
            {
                cmd = new SqlCommand("delete property where ID=@Id", con);
                con.Open();
                cmd.Parameters.AddWithValue("@Id", ID);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Deleted Successfully!");
                DisplayData();
                ClearData();
            }
            else
            {
                MessageBox.Show("Please Select Record to Delete");
            }
        }

        private void DataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

            ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            txt_property.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_Status.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txt_rent.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txt_address.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            txt_room.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            txt_suburb.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();

        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            new ADMINHOME().Show();
        }

        private void Button2_Click(object sender, EventArgs e)
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
            this.chart1.Titles.Add("PROPERTIES");
            chart1.Series["chart"].ChartType = SeriesChartType.Column;
            chart1.Series["chart"].IsValueShownAsLabel = true;
            con.Close();
        }

        private void A_Enter(object sender, EventArgs e)
        {

        }
    }
}
