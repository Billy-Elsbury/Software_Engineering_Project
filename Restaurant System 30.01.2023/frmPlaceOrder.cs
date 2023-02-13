using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restuarant_System
{
    public partial class frmPlaceOrder : Form
    {
        public frmPlaceOrder()
        {
            InitializeComponent();
        }

        private void frmPlaceOrder_Load(object sender, EventArgs e)
        {
            //Create menuItems Data Grid View

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
                new Font(menuItemsDataGridView.DefaultCellStyle.Font, FontStyle.Bold);

            menuItemsDataGridView.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;
            menuItemsDataGridView.AllowUserToAddRows = false;
            menuItemsDataGridView.MultiSelect = false;

            foreach (DataGridViewColumn column in menuItemsDataGridView.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            //ensure columns span whole DataGrid View Table
            menuItemsDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            menuItemsDataGridView.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            menuItemsDataGridView.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            menuItemsDataGridView.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            menuItemsDataGridView.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;


            //Populate Data Grid View with default information

            string[] menuItem1 = { "A - Available", "1", "Spaghetti", "F - Food", "Italian", "14.00" };
            string[] menuItem2 = { "A - Available", "2", "Sushi", "F - Food", "Japanese", "12.50" };
            string[] menuItem3 = { "U - Unvailable", "3", "Guiness", "B - Beverage", "Irish", "4.90" };
            string[] menuItem4 = { "A - Available", "4", "CheeseCake", "D - Dessert", "Greek", "7.50" };
            string[] menuItem5 = { "A - Available", "5", "Chips", "F - Food", "Belgium", "6.00" };
            string[] menuItem6 = { "U - Unvailable", "6", "Apple-Pie", "D - Dessert", "English", "5.40" };
            string[] menuItem7 = { "U - Unvailable", "7", "Bloody Mary", "B - Beverage", "French", "9.75" };
            string[] menuItem8 = { "A - Available", "8", "Vindaloo", "F - Food", "Portuguese", "12.00" };
            string[] menuItem9 = { "U - Unvailable", "9", "Mojito", "B - Beverage", "Cuban", "4.90" };
            string[] menuItem10 = { "A - Available", "10", "Biryani", "F - Food", "Persian", "9.99" };
            string[] menuItem11 = { "A - Available", "11", "Quesadilla", "F - Food", "Mexican", "6.50" };
            string[] menuItem12 = { "U - Unvailable", "12", "Chow Mein", "F - Food", "Chinese", "10.75" };

            menuItemsDataGridView.Rows.Add(menuItem1);
            menuItemsDataGridView.Rows.Add(menuItem2);
            menuItemsDataGridView.Rows.Add(menuItem3);
            menuItemsDataGridView.Rows.Add(menuItem4);
            menuItemsDataGridView.Rows.Add(menuItem5);
            menuItemsDataGridView.Rows.Add(menuItem6);
            menuItemsDataGridView.Rows.Add(menuItem7);
            menuItemsDataGridView.Rows.Add(menuItem8);
            menuItemsDataGridView.Rows.Add(menuItem9);
            menuItemsDataGridView.Rows.Add(menuItem10);
            menuItemsDataGridView.Rows.Add(menuItem11);
            menuItemsDataGridView.Rows.Add(menuItem12);


            //Create Order menuItems Data Grid View

            orderItemsDataGridView.ColumnCount = 5;

            orderItemsDataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            orderItemsDataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            orderItemsDataGridView.ColumnHeadersDefaultCellStyle.Font =
                new Font(orderItemsDataGridView.Font, FontStyle.Bold);

            orderItemsDataGridView.Name = "menuItemsDataGridView";
            orderItemsDataGridView.AutoSizeRowsMode =
                DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            orderItemsDataGridView.ColumnHeadersBorderStyle =
                DataGridViewHeaderBorderStyle.Single;
            orderItemsDataGridView.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            orderItemsDataGridView.GridColor = Color.Black;
            orderItemsDataGridView.RowHeadersVisible = false;

            orderItemsDataGridView.Columns[0].Name = "Item ID";
            orderItemsDataGridView.Columns[1].Name = "Name";
            orderItemsDataGridView.Columns[2].Name = "Type";
            orderItemsDataGridView.Columns[3].Name = "Description";
            orderItemsDataGridView.Columns[4].Name = "Price";

            orderItemsDataGridView.Columns[4].DefaultCellStyle.Font =
                new Font(orderItemsDataGridView.DefaultCellStyle.Font, FontStyle.Italic);

            orderItemsDataGridView.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;
            orderItemsDataGridView.AllowUserToAddRows = false;
            orderItemsDataGridView.MultiSelect = false;

            foreach (DataGridViewColumn column in menuItemsDataGridView.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            //ensure columns span whole DataGrid View Table
            orderItemsDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            orderItemsDataGridView.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            orderItemsDataGridView.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            orderItemsDataGridView.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

        }
        private void btnAddtoOrder_Click(object sender, EventArgs e)
        {
            //Read from menuItem Data Grid View and add to Order Menu Grid View ONLY if available

            String itemAvailability = (menuItemsDataGridView.Rows[menuItemsDataGridView.CurrentRow.Index].Cells[0].Value).ToString();
            bool itemIsAvailable = false;

            if (itemAvailability.Equals("A - Available"))
            {
                itemIsAvailable = true;
            }

            if (itemIsAvailable) 
            {

                String itemID = (menuItemsDataGridView.Rows[menuItemsDataGridView.CurrentRow.Index].Cells[1].Value).ToString();

                String itemName = (menuItemsDataGridView.Rows[menuItemsDataGridView.CurrentRow.Index].Cells[2].Value).ToString();

                String itemType = (menuItemsDataGridView.Rows[menuItemsDataGridView.CurrentRow.Index].Cells[3].Value).ToString();

                String itemDescription = (menuItemsDataGridView.Rows[menuItemsDataGridView.CurrentRow.Index].Cells[4].Value).ToString();

                String itemPrice = (menuItemsDataGridView.Rows[menuItemsDataGridView.CurrentRow.Index].Cells[5].Value).ToString();

                string[] newMenuItem = { itemID, itemName, itemType, itemDescription, itemPrice };

                try
                {
                    int amountToAdd = Convert.ToInt32(txtAmounttoAdd.Text);

                    for (int i = 0; i < amountToAdd; i++)
                    {
                        orderItemsDataGridView.Rows.Add(newMenuItem);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error while adding Menu Item to Order, \n\nPlease ensure count is a valid number and try again.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Error while adding Menu Item to Order, \n\nPlease ensure the item is Available.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnCommit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Order has succesfully been comitted", "Add Order", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
