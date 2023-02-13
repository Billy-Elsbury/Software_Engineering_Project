using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace Restuarant_System
{
    public partial class frmRestaurantTillMenu : Form
    {

        public frmRestaurantTillMenu()
        {
            InitializeComponent();
        }

        private void addMenuItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void frmRestuarantTillMenu_Load(object sender, EventArgs e)
        {
            menuPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void mnuAddMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAddMenuItem nextForm = new frmAddMenuItem();
            nextForm.ShowDialog();
            this.Show();
        }
        private void mnuEditMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmEditMenuItem nextForm = new frmEditMenuItem();
            nextForm.ShowDialog();
            this.Show();
        }

        private void mnuRemovetMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmRemoveMenuItem nextForm = new frmRemoveMenuItem();
            nextForm.ShowDialog();
            this.Show();
        }

        private void mnuQueryMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmQueryMenuItem nextForm = new frmQueryMenuItem();
            nextForm.ShowDialog();
            this.Show();
        }

        private void mnuPlaceOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmPlaceOrder nextForm = new frmPlaceOrder();
            nextForm.ShowDialog();
            this.Show();
        }

        private void mnuEditOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmEditOrder nextForm = new frmEditOrder();
            nextForm.ShowDialog();
            this.Show();
        }

        private void mnuCancelOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCancelOrder nextForm = new frmCancelOrder();
            nextForm.ShowDialog();
            this.Show();
        }

        private void mnuPayBillToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmPayBill nextForm = new frmPayBill();
            nextForm.ShowDialog();
            this.Show();
        }

        private void mnuMenuItemAnalysisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmItemAnalysis nextForm = new frmItemAnalysis();
            nextForm.ShowDialog();
            this.Show();
        }

        private void mnuRevenueAnalysisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmRevenueAnalysis nextForm = new frmRevenueAnalysis();
            nextForm.ShowDialog();
            this.Show();
        }

        private void frmRestauarantTilMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult result = MessageBox.Show("Do you really want to exit? Any unsaved information will be lost!", "Exit System", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    Environment.Exit(0);
                }
                else
                {
                    e.Cancel = true;
                }
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}
