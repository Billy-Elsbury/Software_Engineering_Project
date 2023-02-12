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
    public partial class frmEditMenuItem : Form
    {
        public frmEditMenuItem()
        {
            InitializeComponent();
        }

        private void frmEditMenuItem_Load(object sender, EventArgs e)
        {
            cboMenuItemType.Items.Add("F - Food");
            cboMenuItemType.Items.Add("B - Beverage");
            cboMenuItemType.Items.Add("D - Dessert");

            cboItemAvailability.Items.Add("A - Available");
            cboItemAvailability.Items.Add("U - Unvailable");

            for (int i = 1; i < 13; i++)
                cboItemID.Items.Add(i);


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

            foreach (DataGridViewColumn column in menuItemsDataGridView.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

        private void cboItemID_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedID = cboItemID.SelectedIndex;

            String itemAvailability = (menuItemsDataGridView.Rows[selectedID].Cells[0].Value).ToString();
            cboItemAvailability.Text = itemAvailability;

            String itemName = (menuItemsDataGridView.Rows[selectedID].Cells[2].Value).ToString();
            txtItemName.Text = Convert.ToString(itemName);

            String itemType = (menuItemsDataGridView.Rows[selectedID].Cells[3].Value).ToString();
            cboMenuItemType.Text = itemType;

            String itemDescription = (menuItemsDataGridView.Rows[selectedID].Cells[4].Value).ToString();
            txtItemDescription.Text = itemDescription;

            String itemPrice = (menuItemsDataGridView.Rows[selectedID].Cells[5].Value).ToString();
            txtPrice.Text = itemPrice;

            menuItemsDataGridView.Rows[selectedID].Selected = true;
        }

        private void menuItemsDataGridView_Click(object sender, EventArgs e)
        {
            //Read from Data Grid View and display on form
            
            String itemAvailability = (menuItemsDataGridView.Rows[menuItemsDataGridView.CurrentRow.Index].Cells[0].Value).ToString();
            cboItemAvailability.Text = itemAvailability;

            int itemID = Convert.ToInt32(menuItemsDataGridView.Rows[menuItemsDataGridView.CurrentRow.Index].Cells[1].Value);
            cboItemID.Text = Convert.ToString(itemID);

            String itemName = (menuItemsDataGridView.Rows[menuItemsDataGridView.CurrentRow.Index].Cells[2].Value).ToString();
            txtItemName.Text = itemName;

            String itemType = (menuItemsDataGridView.Rows[menuItemsDataGridView.CurrentRow.Index].Cells[3].Value).ToString();
            cboMenuItemType.Text = itemType;

            String itemDescription = (menuItemsDataGridView.Rows[menuItemsDataGridView.CurrentRow.Index].Cells[4].Value).ToString();
            txtItemDescription.Text = itemDescription;

            String itemPrice = (menuItemsDataGridView.Rows[menuItemsDataGridView.CurrentRow.Index].Cells[5].Value).ToString();
            txtPrice.Text = itemPrice;
        }

        private void btnEditMenuItem_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    int selectedID = cboItemID.SelectedIndex;
                    String newItemName = txtItemName.Text;

                    DataGridViewRow newDataRow = menuItemsDataGridView.Rows[selectedID];
                    newDataRow.Cells[0].Value = cboItemAvailability.Text;
                    newDataRow.Cells[1].Value = cboItemID.Text;
                    newDataRow.Cells[2].Value = txtItemName.Text;
                    newDataRow.Cells[3].Value = cboMenuItemType.Text;
                    newDataRow.Cells[4].Value = txtItemDescription.Text;
                    newDataRow.Cells[5].Value = txtPrice.Text;
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Error in Update, Please try again.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
