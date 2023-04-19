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
        
        


        public frmAddMenuItem()
        {
            InitializeComponent();
        }



        private void frmAddMenuItem_Load(object sender, EventArgs e)
        {

            cboMenuItemType.Items.Add("F");
            cboMenuItemType.Items.Add("B");
            cboMenuItemType.Items.Add("D");

            //Retrieve itemID from database
            txtItemId.Text = Utility.GetNextMenuItemId().ToString("0000");

            //Create Data Grid View

            menuItemsDataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            menuItemsDataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            menuItemsDataGridView.ColumnHeadersDefaultCellStyle.Font =
                new Font(menuItemsDataGridView.Font, FontStyle.Bold);

            menuItemsDataGridView.Name = "menuItemsDataGridView";
            menuItemsDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;            menuItemsDataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            menuItemsDataGridView.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            menuItemsDataGridView.GridColor = Color.Black;
            menuItemsDataGridView.RowHeadersVisible = false;
            menuItemsDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            menuItemsDataGridView.AllowUserToAddRows = false;
            menuItemsDataGridView.MultiSelect = false;

            //ensure columns span whole DataGrid View Table
            menuItemsDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


            //Populate Data Grid View with information from database

            DataSet dataSet = MenuItem.GetSummarisedMenuItems(); 
                
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

            // Get input values from form controls
            string itemType = cboMenuItemType.Text;
            string itemName = txtItemName.Text;
            string itemDescription = txtItemDescription.Text;
            string price = txtPrice.Text;

            // Validate input using the ValidationUtility class
            string errorMessage;
            if (!Utility.ValidationUtility.IsMenuItemValid(itemType, itemName, itemDescription, price, out errorMessage))
            {
                // Display error message and return if input is invalid
                MessageBox.Show(errorMessage, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // If input is valid, proceed with adding the menu item to the database and updating the UI

            //update item Id
            string itemId = Utility.GetNextMenuItemId().ToString("0000");

            // Create an instance of a Menu Item and instantiate with values from form controls
            MenuItem aMenuItem = new MenuItem(Convert.ToInt32(itemId), 'A', itemType, itemName, itemDescription, Convert.ToDecimal(price));

            // Invoke the method to add the data to the MenuItems table
            aMenuItem.AddMenuItems();

            // Display confirmation message
            MessageBox.Show("Product '" + txtItemName.Text + "' added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);



            //reset UI
            txtItemId.Text = Utility.GetNextMenuItemId().ToString("0000");
            txtItemName.Clear();
            cboMenuItemType.SelectedIndex = -1;
            txtItemDescription.Clear();
            txtPrice.Text = "0.00";
            cboMenuItemType.Focus();

            //update data view grid table

            DataSet dataSet = MenuItem.GetSummarisedMenuItems();

            menuItemsDataGridView.DataSource = dataSet.Tables[0];

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Utility.BackButton(this);
        }
    }
}
