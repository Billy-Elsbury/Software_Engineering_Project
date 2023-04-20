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
            cboMenuItemType.Items.Add("F");
            cboMenuItemType.Items.Add("B");
            cboMenuItemType.Items.Add("D");

            cboItemAvailability.Items.Add("A");
            cboItemAvailability.Items.Add("U");

            //Retrieve itemID from database
            int itemIdCount = Convert.ToInt32(Utility.GetNextMenuItemId().ToString("0000"));

            for (int i = 1; i < itemIdCount; i++)
                cboItemID.Items.Add(i);


            //Create Data Grid View

            //Populate Data Grid View with information from database

            DataSet dataSet = MenuItem.GetAllMenuItems();

            menuItemsDataGridView.DataSource = dataSet.Tables[0];

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


            menuItemsDataGridView.Columns[0].DefaultCellStyle.Font =
                new Font(menuItemsDataGridView.DefaultCellStyle.Font, FontStyle.Italic);

            menuItemsDataGridView.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;
            menuItemsDataGridView.AllowUserToAddRows = false;
            menuItemsDataGridView.MultiSelect = false;

            //ensure columns span whole DataGrid View Table
            menuItemsDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            menuItemsDataGridView.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            foreach (DataGridViewColumn column in menuItemsDataGridView.Columns)
            
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
        }

        private void cboItemID_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedID = cboItemID.SelectedIndex;

            String itemAvailability = (menuItemsDataGridView.Rows[selectedID].Cells[1].Value).ToString();
            cboItemAvailability.Text = itemAvailability;

            String itemType = (menuItemsDataGridView.Rows[selectedID].Cells[2].Value).ToString();
            cboMenuItemType.Text = itemType;

            String itemName = (menuItemsDataGridView.Rows[selectedID].Cells[3].Value).ToString();
            txtItemName.Text = Convert.ToString(itemName);

            String itemDescription = (menuItemsDataGridView.Rows[selectedID].Cells[4].Value).ToString();
            txtItemDescription.Text = itemDescription;

            String itemPrice = (menuItemsDataGridView.Rows[selectedID].Cells[5].Value).ToString();
            txtPrice.Text = itemPrice;

            menuItemsDataGridView.Rows[selectedID].Selected = true;
        }

        private void menuItemsDataGridView_Click(object sender, EventArgs e)
        {
            if (menuItemsDataGridView.SelectedRows.Count > 0) // Check if a row is selected first to avoid crash when selecting empty part of grid view
            {
                //Read from Data Grid View and display on form

                int itemID = Convert.ToInt32(menuItemsDataGridView.Rows[menuItemsDataGridView.CurrentRow.Index].Cells[0].Value);
                cboItemID.Text = Convert.ToString(itemID);

                String itemAvailability = (menuItemsDataGridView.Rows[menuItemsDataGridView.CurrentRow.Index].Cells[1].Value).ToString();
                cboItemAvailability.Text = itemAvailability;

                String itemType = (menuItemsDataGridView.Rows[menuItemsDataGridView.CurrentRow.Index].Cells[2].Value).ToString();
                cboMenuItemType.Text = itemType;

                String itemName = (menuItemsDataGridView.Rows[menuItemsDataGridView.CurrentRow.Index].Cells[3].Value).ToString();
                txtItemName.Text = itemName;

                String itemDescription = (menuItemsDataGridView.Rows[menuItemsDataGridView.CurrentRow.Index].Cells[4].Value).ToString();
                txtItemDescription.Text = itemDescription;

                String itemPrice = (menuItemsDataGridView.Rows[menuItemsDataGridView.CurrentRow.Index].Cells[5].Value).ToString();
                txtPrice.Text = itemPrice;
            }
        }

        private void btnEditMenuItem_Click(object sender, EventArgs e)
        {
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
            {
                try
                {
                    int selectedID = cboItemID.SelectedIndex;
                    String newItemName = txtItemName.Text;

                    MenuItem.UpdateMenuItem(Convert.ToInt32(cboItemID.Text), cboItemAvailability.Text, cboMenuItemType.Text, txtItemName.Text, txtItemDescription.Text, Decimal.Parse(txtPrice.Text));

                    DataGridViewRow newDataRow = menuItemsDataGridView.Rows[selectedID];
                    newDataRow.Cells[1].Value = cboItemAvailability.Text;
                    newDataRow.Cells[2].Value = cboMenuItemType.Text;
                    newDataRow.Cells[3].Value = txtItemName.Text;
                    newDataRow.Cells[4].Value = txtItemDescription.Text;
                    newDataRow.Cells[5].Value = txtPrice.Text;

                    //display confirmation message
                    MessageBox.Show("Product " + cboItemID.Text + " updated successfully", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                catch (Exception ex)
                {
                   MessageBox.Show("Error in Update \n\n ____________________________________ \n\n" + ex.ToString(), "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Utility.BackButton(this);
        }
    }
}
