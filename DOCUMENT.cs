﻿using System;
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
    public partial class DOCUMENT : Form
    {
        public DOCUMENT()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form4().Show();
        }

        private void Button12_Click(object sender, EventArgs e)
        {
            this.Hide();
            new HOME().Show();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new HOME().Show();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            new PAYMENT().Show();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            new PAYMENT().Show();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            new MAINTAINANCE().Show();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            new DOCUMENT().Show();
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ABOUTUS().Show();
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            new LEASE().Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
            new TRANSACTIONS().Show();
        }
    }
}
