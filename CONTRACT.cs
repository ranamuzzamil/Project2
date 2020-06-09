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
using System.IO;

namespace User_Registration
{
    public partial class CONTRACT : Form
    {
        
        public CONTRACT()
        {
            InitializeComponent();
        }

        private void CONTRACT_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
                MessageBox.Show("please fill  fields");
           
            else
            {

                this.Hide();
                new CONTRACT_1().Show();
            }


        }

    }
}
