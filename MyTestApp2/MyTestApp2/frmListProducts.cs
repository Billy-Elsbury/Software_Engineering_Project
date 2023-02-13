using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MyTestApp2
{
    public partial class frmListProducts : Form
    {
        frmMainForm parent;

        public frmListProducts()
        {
            InitializeComponent();
        }

        public frmListProducts(frmMainForm Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        private void frmListData_Load(object sender, EventArgs e)
        {
            //retrieve all data from Products table
            grdProducts.DataSource = Product.getAllProducts().Tables["prod"];
            
            //grdProducts.DataSource = Product.findProducts("W").Tables["prod"];
        }

        private void mnuBack_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }
    }
}
