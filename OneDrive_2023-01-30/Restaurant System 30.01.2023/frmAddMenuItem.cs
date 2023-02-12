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
        private Mediator _mediator = new Mediator();

        public frmAddMenuItem()
        {
            InitializeComponent();
        }

        private void frmAddMenuItem_Load(object sender, EventArgs e)
        {
            cboMenuItemType.Items.Add("F - Food");
            cboMenuItemType.Items.Add("B - Beverage");
            cboMenuItemType.Items.Add("D - Dessert");

            

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

            string[] menuItem1 = { "A - Available", "1", "Spaghetti", "F - Food", "Italian", "15.00" };

            menuItemsDataGridView.Rows.Add(menuItem1);
        }

        int idCount = 2;
        private void btnAddMenuItem_Click(object sender, EventArgs e)
        {
            /*{
                //ArrayList Currently non-functioning

                int ID = 1;

                var newMenuitem = new MenuItem
                {
                    Name = txtItemName.Text,
                    Description = txtItemDescription.Text,
                    ID = ID,
                };

                _mediator.MenuItems.Add(newMenuitem);
                ID++;

                //Exchange();
                //-----------------------------------
                txtPrice.Text = "";
                txtItemDescription.Text = "";
                txtItemName.Text = "";
            }*/

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

                if (cboMenuItemType.Text != "") 
            {
                if (txtItemName.Text != "" && txtItemDescription.Text != "")
                {
                    if (!itemNameContainsDigit && !itemDescriptionContainsDigit)
                    {
                        if (itemNameHasNoSpecial && itemDescriptionHasNoSpecial)
                        {
                            if (priceIsParcable)
                            {
                                if (txtPrice.Text != "" && double.Parse(txtPrice.Text) > 0)
                                {
                                    string[] newMenuItem = { "A - Available", idCount.ToString(), txtItemName.Text, cboMenuItemType.Text, txtItemDescription.Text, txtPrice.Text };

                                    menuItemsDataGridView.Rows.Add(newMenuItem);
                                    idCount++;
                                }
                                else { MessageBox.Show("Item Price must be a positive number and cannot be empty.", "Error!"); }
                            }
                            else { MessageBox.Show("Item Price must be a number, cannot include letters.", "Error!"); }
                        }
                        else { MessageBox.Show("Item Name and Description cannot include special characters", "Error!"); }
                    }
                    else { MessageBox.Show("Item Name and Description cannot include numbers", "Error!"); }
                }
                else { MessageBox.Show("Item Name and Description cannot be empty.", "Error!"); };
            }
            else {MessageBox.Show("A Menu Item Type must be selected.", "Error!"); };

            //insert the data into database
            MenuItem anItem = new MenuItem();
        }
    }
}
