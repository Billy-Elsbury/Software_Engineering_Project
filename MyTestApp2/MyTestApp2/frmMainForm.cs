using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MyTestApp2
{
    public partial class frmMainForm : Form
    {
        public frmMainForm()
        {
            InitializeComponent();
        }

        private void mnuListProd_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmListProducts nextForm = new frmListProducts(this);
            nextForm.Show();
        }

        private void mnuAddProd_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAddProduct nextForm = new frmAddProduct(this);
            nextForm.Show();
        }

        private void mnuUpdProd_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmUpdProduct nextForm = new frmUpdProduct(this);
            nextForm.Show();
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
