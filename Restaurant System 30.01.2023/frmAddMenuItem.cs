using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Restuarant_System
{
    public partial class frmAddMenuItem : Form
    {
        //Retrieve itemID from database
        String itemId = MenuItem.getNextmenuItemId().ToString("0000");


        public frmAddMenuItem()
        {
            InitializeComponent();
        }



        private void frmAddMenuItem_Load(object sender, EventArgs e)
        {

            cboMenuItemType.Items.Add("F");
            cboMenuItemType.Items.Add("B");
            cboMenuItemType.Items.Add("D");

            txtItemId.Text = itemId;

            //Create Data Grid View

            menuItemsDataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            menuItemsDataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            menuItemsDataGridView.ColumnHeadersDefaultCellStyle.Font =
                new Font(menuItemsDataGridView.Font, FontStyle.Bold);

            menuItemsDataGridView.Name = "menuItemsDataGridView";
            menuItemsDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            menuItemsDataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            menuItemsDataGridView.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            menuItemsDataGridView.GridColor = Color.Black;
            menuItemsDataGridView.RowHeadersVisible = false;
            menuItemsDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            menuItemsDataGridView.AllowUserToAddRows = false;
            menuItemsDataGridView.MultiSelect = false;

            //ensure columns span whole DataGrid View Table
            menuItemsDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


            //Populate Data Grid View with information from database

            DataSet dataSet = MenuItem.getAllMenuItems(); 
                
            menuItemsDataGridView.DataSource = dataSet.Tables[0];

        }

        private void btnAddMenuItem_Click(object sender, EventArgs e)
        {
            //Add to Data Grid View with inputted information ----After validating

            double numberDouble;

            bool priceIsParcable = double.TryParse(txtPrice.Text, out numberDouble);

            bool itemNameContainsDigit = txtItemName.Text.Any(char.IsDigit);
            bool itemDescriptionContainsDigit = txtItemDescription.Text.Any(char.IsDigit);
            bool itemNameHasNoSpecial = txtItemName.Text.All(char.IsLetter);
            bool itemDescriptionHasNoSpecial = txtItemDescription.Text.All(char.IsLetter);

            if (cboMenuItemType.SelectedIndex==-1)
            {
                MessageBox.Show("A Menu Item Type must be selected.", "Error!", MessageBoxButtons.OK,MessageBoxIcon.Error);
                cboMenuItemType.Focus();
                return;
            }

            if(txtItemName.Text.Equals(""))
            {
                MessageBox.Show("Name must be entered.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtItemName.Focus();
                return;
            }

            switch (cboMenuItemType.Text)
            {
                case "":
                    MessageBox.Show("A Menu Item Type must be selected.", "Error!");
                    break;
                default:

                    switch (txtItemName.Text)
                    {
                        case "":
                            MessageBox.Show("Item Name cannot be empty.", "Error!");
                            break;
                        default:

                            switch (txtItemDescription.Text)
                            {
                                case "":
                                    MessageBox.Show("Item Description cannot be empty.", "Error!");
                                    break;
                                default:

                                    switch (itemNameContainsDigit || itemDescriptionContainsDigit)
                                    {
                                        case true:
                                            MessageBox.Show("Item Name and Description cannot include numbers", "Error!");
                                            break;
                                        case false:
                                            switch (itemNameHasNoSpecial || itemDescriptionHasNoSpecial)
                                            {
                                                case false:
                                                    MessageBox.Show("Item Name and Description cannot include special characters", "Error!");
                                                    break;
                                                case true:
                                                    switch (priceIsParcable)
                                                    {
                                                        case false:
                                                            MessageBox.Show("Item Price must be a number, cannot include letters.", "Error!");
                                                            break;
                                                        case true:
                                                            switch (txtPrice.Text)
                                                            {
                                                                case "":
                                                                    MessageBox.Show("Item Price cannot be empty.", "Error!");
                                                                    break;
                                                                default:
                                                                    switch (double.Parse(txtPrice.Text) <= 0)
                                                                    {
                                                                        case true:
                                                                            MessageBox.Show("Item Price must be a positive number.", "Error!");
                                                                            break;
                                                                        case false:

                                                                            //insert the data into database

                                                                            //Create an instance of a Menu Item and instantiate with values from form controls
                                                                            MenuItem aMenuItem = new MenuItem('A', Convert.ToInt32(itemId), cboMenuItemType.Text, txtItemName.Text, txtItemDescription.Text,
                                                                                Convert.ToDecimal(txtPrice.Text));

                                                                            //invoke the method to add the data to the MenuItems table
                                                                            aMenuItem.addMenuItems();

                                                                            //display confirmation message
                                                                            MessageBox.Show("Product " + txtItemId.Text + " added successfully", "Success",
                                                                                MessageBoxButtons.OK, MessageBoxIcon.Information);


                                                                            break;
                                                                    }
                                                                    break;
                                                            }
                                                            break;
                                                    }
                                                    break;
                                            }
                                            break;
                                    }
                                    break;
                            }
                            break;
                    }
                    break;
            }

            

            //reset UI
            txtItemId.Text = MenuItem.getNextmenuItemId().ToString("0000");
            txtItemName.Clear();
            cboMenuItemType.SelectedIndex = -1;
            txtItemDescription.Clear();
            txtPrice.Text = "0.00";
            cboMenuItemType.Focus();

            //update table

            DataSet dataSet = MenuItem.getAllMenuItems();

            menuItemsDataGridView.DataSource = dataSet.Tables[0];
        }
    }
}
