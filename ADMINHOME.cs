using InsertUpdateDeleteDemo;
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
    public partial class ADMINHOME : Form
    {
        public ADMINHOME()
        {
            InitializeComponent();
        }

        private void ADMINHOME_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form4().Show();
        }

        private void Button8_Click(object sender, EventArgs e)
        {
           
        }

        private void Button2_Click(object sender, EventArgs e)
        {
           
        }

        private void Button3_Click(object sender, EventArgs e)
        {

        }

        private void USERACCESSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void EDITDASHBOARDToolStripMenuItem_Click(object sender, EventArgs e)
        {

            
        }

        private void ADDPROPERTYToolStripMenuItem_Click(object sender, EventArgs e)
        {


          
        }

        private void Button2_Click_1(object sender, EventArgs e)
        {

        }

        private void PatientRegistrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            USERACCESS obj = new USERACCESS();
            obj.ShowDialog();
        }

        private void PatientInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EDITDASHBOARD obj = new EDITDASHBOARD();
            obj.ShowDialog();
        }

        private void FINANCEAPPLICATIONSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ADMINFINANCE obj = new ADMINFINANCE();
            obj.ShowDialog();
        }

        private void RoomInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

        }

        private void Button2_Click_2(object sender, EventArgs e)
        {
            this.Hide();
            new frmMain().Show();
        }

        private void Button3_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            new ADMINPROPERTY().Show();
        }

        private void viewCheckoutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cLIENTSBILLSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ADMINBILLS().Show();
        }

        private void checkoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FEEDBACK obj = new FEEDBACK();
            obj.ShowDialog();
        }

        private void aDDPROPERTIESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ADMINPROPERTY obj = new ADMINPROPERTY();
            obj.ShowDialog();
        }

        private void lEASEBUYAPPLICATIONSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ADMINAPPROVAL obj = new ADMINAPPROVAL();
            obj.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pROPERTIESDETAILSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            P_DETAILS obj = new P_DETAILS ();
            obj.ShowDialog();
        }

        private void iNCOMEANALYSISToolStripMenuItem_Click(object sender, EventArgs e)
        {
            INCOME obj = new INCOME();
            obj.ShowDialog();
        }

        private void nOTIFICATIONSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            A_NOTIFICATION obj = new A_NOTIFICATION();
            obj.ShowDialog();
        }
    }
}
