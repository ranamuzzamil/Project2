using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace User_Registration
{
    public partial class A_NOTIFICATION : Form
    {
        public A_NOTIFICATION()
        {
            InitializeComponent();
        }

        private void A_NOTIFICATION_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'loginDBDataSet8.notification' table. You can move, or remove it, as needed.
            this.notificationTableAdapter.Fill(this.loginDBDataSet8.notification);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ADMINHOME().Show();
        }
    }
}
