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
    public partial class AD : Form
    {
        public AD()
        {
            InitializeComponent();
        }

        private void AD_Load(object sender, EventArgs e)
        {
            using(LoginDBEntities db = new LoginDBEntities())
            {
                imageBindingSource.DataSource = db.images.ToList();            
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
