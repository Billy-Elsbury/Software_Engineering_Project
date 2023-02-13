using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MyTestApp2
{
    public partial class frmFindProducts : Form
    {
        public frmFindProducts()
        {
            InitializeComponent();
        }

        private void frmFindProducts_Load(object sender, EventArgs e)
        {
            //Load TypeCodes into ComboBox
            DataSet ds = Type.getTypes();

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                cboTypes.Items.Add(ds.Tables[0].Rows[i][0] + " - " + ds.Tables[0].Rows[i][1]);
            }
        }

        private void cboTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            grdProducts.Visible = false;

            //retrieve all data from Products table
            grdProducts.DataSource = Product.getAllProducts(cboTypes.Text.Substring(0,2)).Tables["prod"];

            //if no matches found
            if(grdProducts.Rows.Count==0)
            {
                MessageBox.Show("No products found");
                return;
            }

            grdProducts.Visible = true;
        }
    }
}
