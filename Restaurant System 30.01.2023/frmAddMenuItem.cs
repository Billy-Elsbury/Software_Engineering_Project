using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            //get next Product ID
            txtItemId.Text = MenuItem.getNextmenuItemId().ToString("0000");

            cboMenuItemType.Items.Add("F");
            cboMenuItemType.Items.Add("B");
            cboMenuItemType.Items.Add("D");

            

            //Create Data Grid View

            menuItemsDataGridView.ColumnCount = 6;

            menuItemsDataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            menuItemsDataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            menuItemsDataGridView.ColumnHeadersDefaultCellStyle.Font =
                new Font(menuItemsDataGridView.Font, FontStyle.Bold);

            menuItemsDataGridView.Name = "menuItemsDataGridView";
            menuItemsDataGridView.AutoSizeRowsMode =
                DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            menuItemsDataGridView.ColumnHeadersBorderStyle =
                DataGridViewHeaderBorderStyle.Single;
            menuItemsDataGridView.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            menuItemsDataGridView.GridColor = Color.Black;
            menuItemsDataGridView.RowHeadersVisible = false;

            menuItemsDataGridView.Columns[0].Name = "Availability"; 
            menuItemsDataGridView.Columns[1].Name = "ID";
            menuItemsDataGridView.Columns[2].Name = "Name";
            menuItemsDataGridView.Columns[3].Name = "Type";
            menuItemsDataGridView.Columns[4].Name = "Description";
            menuItemsDataGridView.Columns[5].Name = "Price";

            menuItemsDataGridView.Columns[0].DefaultCellStyle.Font =
                new Font(menuItemsDataGridView.DefaultCellStyle.Font, FontStyle.Italic);

            menuItemsDataGridView.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;
            menuItemsDataGridView.AllowUserToAddRows = false;
            menuItemsDataGridView.MultiSelect = false;

            //ensure columns span whole DataGrid View Table
            menuItemsDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            menuItemsDataGridView.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            menuItemsDataGridView.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            menuItemsDataGridView.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            menuItemsDataGridView.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;


            //Populate Data Grid View with default information

            string[] menuItem1 = { "A - Available", "1", "Spaghetti", "F", "Italian", "15.00" };

            menuItemsDataGridView.Rows.Add(menuItem1);
        }

        int idCount = 2;
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
                                                                            string[] newMenuItem = { "A - Available", idCount.ToString(), txtItemName.Text, cboMenuItemType.Text, txtItemDescription.Text, txtPrice.Text };
                                                                            menuItemsDataGridView.Rows.Add(newMenuItem);
                                                                            idCount++;
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

            //insert the data into database
            MenuItem anItem = new MenuItem();

            //Create an instance of a Menu Item and instantiate with values from form controls
            MenuItem aMenuItem = new MenuItem(Convert.ToInt32(txtItemId.Text), cboMenuItemType.Text,txtItemName.Text, txtItemDescription.Text,
                Convert.ToDecimal(txtPrice.Text));

            //invoke the method to add the data to the MenuItems table
            aMenuItem.addMenuItems();

            //display confirmation message
            MessageBox.Show("Product " + txtItemId.Text + " added successfully", "Success",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            //reset UI
            txtItemName.Text = MenuItem.getNextmenuItemId().ToString("0000");
            txtItemName.Clear();
            cboMenuItemType.SelectedIndex = -1;
            txtItemDescription.Clear();
            txtPrice.Text = "0.00";
            cboMenuItemType.Focus();

        }
    }
}
