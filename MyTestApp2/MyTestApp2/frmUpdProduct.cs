using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MyTestApp2
{
    public partial class frmUpdProduct : Form
    {
        frmMainForm parent; 
        Product theProduct = new Product();

        public frmUpdProduct()
        {
            InitializeComponent();
        }
        public frmUpdProduct(frmMainForm Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //validate the name entered

            //find matching products
            grdProducts.DataSource = Product.findProducts(txtSearch.Text).Tables["Prod"];

            if (grdProducts.Rows.Count == 1)
            {
                MessageBox.Show("No Data Found");
                txtSearch.Focus();
                return;
            }

            //make the matching products visible
            grdProducts.Visible = true;
        }

        private void grdProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //extract the ProdID from column zero on the selected row in grid
            int Id = Convert.ToInt32(grdProducts.Rows[grdProducts.CurrentCell.RowIndex].Cells[0].Value.ToString());

            //instantiate aProduct
            theProduct.getProduct(Id);

            //move the instance variable values to the form controls
            txtName.Text = theProduct.getName();
            txtDescription.Text = theProduct.getDescription();
            txtManufacturer.Text = theProduct.getManufacturer();
            txtQty.Text = theProduct.getQty().ToString("000");
            txtPrice.Text = theProduct.getPrice().ToString("###0.00");

            //Load TypeCodes into combo box and set current value
            DataSet ds = Type.getTypes();
            int typeIndex = 0;
            cboTypes.Items.Clear();
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                cboTypes.Items.Add(ds.Tables[0].Rows[i][0] + " - " + ds.Tables[0].Rows[i][1]);
                if (ds.Tables[0].Rows[i][0].Equals(theProduct.getTypeCode())) typeIndex = i;
            }
            cboTypes.SelectedIndex = typeIndex;

            //make the product data availale for updating
            grpProduct.Visible = true;
        }

        private void mnuBack_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

        private void btnUpd_Click(object sender, EventArgs e)
        {
            //validate the data

            //instantiate the object variables
            theProduct.setName(txtName.Text);
            theProduct.setDescription(txtDescription.Text);
            theProduct.setManufacturer(txtManufacturer.Text);
            theProduct.setQty(Convert.ToInt32(txtQty.Text));
            theProduct.setPrice(Convert.ToDecimal(txtPrice.Text));
            theProduct.setTypeCode(cboTypes.Text.Substring(0, 2));

            //update the data in the database
            theProduct.updateProduct();

            //Display confirmation message
            MessageBox.Show("Product Updated", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //Reset UI
            grpProduct.Visible = false;
            grdProducts.Visible = false;
            txtSearch.Clear();
            txtSearch.Focus();
        }
    }
}
