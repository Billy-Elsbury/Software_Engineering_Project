using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MyTestApp2
{
    public partial class frmAddProduct : Form
    {
        frmMainForm parent;

        public frmAddProduct()
        {
            InitializeComponent();
        }

        public frmAddProduct(frmMainForm Parent)
        {
            InitializeComponent();
            parent = Parent;
        }


        private void mnuBack_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

        private void frmAddItem_Load(object sender, EventArgs e)
        {
            //get next Product ID
            txtProdId.Text = Product.getNextProdID().ToString("0000");

            //Load TypeCodes into ComboBox
            DataSet ds = Type.getTypes();
            cboTypes.Items.Clear();
            for (int i=0; i < ds.Tables[0].Rows.Count; i++)
            {
                cboTypes.Items.Add(ds.Tables[0].Rows[i][0] + " - " + ds.Tables[0].Rows[i][1]);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Validate ALL the input data

            //Create an instance of Product and instantiate with values from form controls
            Product aProduct = new Product(Convert.ToInt32(txtProdId.Text), txtName.Text, txtDescription.Text,
                txtManufacturer.Text, Convert.ToInt32(txtQty.Text), Convert.ToDecimal(txtPrice.Text), 
                cboTypes.Text.Substring(0, 2));

            //invoke the method to add the data to the Products table
            aProduct.addProduct();

            //display confirmation message
            MessageBox.Show("Product " + txtProdId.Text + " added successfully", "Success",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            //reset UI
            txtProdId.Text = Product.getNextProdID().ToString("0000");
            txtName.Clear();
            txtDescription.Clear();
            txtManufacturer.Clear();
            txtQty.Clear();
            txtPrice.Text = "0.00";
            cboTypes.SelectedIndex = -1;
            txtName.Focus();

        }
    }
}
