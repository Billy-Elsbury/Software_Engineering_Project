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

        private void frmRestuarantTillMenu_Load(object sender, EventArgs e)
        {
            menuPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void mnuAddMenuItem_Click(object sender, EventArgs e)
        {
            GoToForm(typeof(frmAddMenuItem));
        }

        private void mnuEditMenuItem_Click(object sender, EventArgs e)
        {
            GoToForm(typeof(frmEditMenuItem));
        }

        private void mnuRemovetMenuItem_Click(object sender, EventArgs e)
        {
            GoToForm(typeof(frmRemoveMenuItem));
        }

        private void mnuQueryMenuItem_Click(object sender, EventArgs e)
        {
            GoToForm(typeof(frmQueryMenuItem));
        }

        private void mnuPlaceOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GoToForm(typeof(frmPlaceOrder));
        }

        private void mnuEditOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GoToForm(typeof(frmEditOrder));
        }

        private void mnuCancelOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GoToForm(typeof(frmCancelOrder));
        }

        private void mnuPayBillToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GoToForm(typeof(frmPayBill));
        }

        private void mnuMenuItemAnalysisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GoToForm(typeof(frmItemAnalysis));
        }

        private void mnuRevenueAnalysisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GoToForm(typeof(frmRevenueAnalysis));
        }

        //Code to
        private void GoToForm(Type formType)
        {
            Form nextForm = (Form)Activator.CreateInstance(formType);
            Utility.ShowNextForm(this, nextForm);
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
