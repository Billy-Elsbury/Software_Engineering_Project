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

        // Initialize order items DataTable
        private DataTable orderItemsDataTable;

        public frmPlaceOrder()
        {
            InitializeComponent();
        }

        private void frmPlaceOrder_Load(object sender, EventArgs e)
        {
            cboMenuItemType.Items.Add("");
            cboMenuItemType.Items.Add("F");
            cboMenuItemType.Items.Add("B");
            cboMenuItemType.Items.Add("D");

            //refresh Data Grid Views
            menuItemsDataGridView.DataSource = new DataTable();
            orderItemsDataGridView.DataSource = new DataTable();

            // Create Data Grid View
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

            menuItemsDataGridView.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;
            menuItemsDataGridView.AllowUserToAddRows = false;
            menuItemsDataGridView.MultiSelect = false;

            // Ensure columns span whole DataGrid View Table
            menuItemsDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            foreach (DataGridViewColumn column in menuItemsDataGridView.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            //Add OrderID to text box
            txtOrderId.Text = (Convert.ToString(Order.GetNextOrderId()));


            //config orderItems data table

            orderItemsDataTable = new DataTable();
            orderItemsDataTable.Columns.Add("ItemId", typeof(int));
            orderItemsDataTable.Columns.Add("Name", typeof(string));
            orderItemsDataTable.Columns.Add("Type", typeof(string));
            orderItemsDataTable.Columns.Add("Quantity", typeof(int));
            orderItemsDataTable.Columns.Add("Price", typeof(double));

            //config orderItems data grid

            orderItemsDataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            orderItemsDataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            orderItemsDataGridView.ColumnHeadersDefaultCellStyle.Font =
                new Font(orderItemsDataGridView.Font, FontStyle.Bold);

            orderItemsDataGridView.Name = "orderItemsDataGridView";
            orderItemsDataGridView.AutoSizeRowsMode =
                DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            orderItemsDataGridView.ColumnHeadersBorderStyle =
                DataGridViewHeaderBorderStyle.Single;
            orderItemsDataGridView.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            orderItemsDataGridView.GridColor = Color.Black;
            orderItemsDataGridView.RowHeadersVisible = false;

            orderItemsDataGridView.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;
            orderItemsDataGridView.AllowUserToAddRows = false;
            orderItemsDataGridView.MultiSelect = false;

            // Ensure columns span whole DataGrid View Table
            orderItemsDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            foreach (DataGridViewColumn column in orderItemsDataGridView.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

        }

        private void btnSearchMenuItem_Click(object sender, EventArgs e)
        {
            // Validate the search input before filtering
            string errorMessage;

            if (!Utility.ValidationUtility.ValidItemName(txtItemName.Text, out errorMessage))
            {
                MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string sql = MenuItem.GetAvailableMenuItemSummary(cboMenuItemType.Text, txtItemName.Text);

            DataSet dataSet = Utility.GetFilteredResult(sql);

            if (dataSet != null && dataSet.Tables.Count > 0 && dataSet.Tables[0].Rows.Count > 0)
            {
                // Hide the ItemId column in the DataGridView
                menuItemsDataGridView.DataSource = dataSet.Tables[0];
                menuItemsDataGridView.Columns["ItemId"].Visible = false;
            }
            else
            {
                menuItemsDataGridView.DataSource = new DataTable();
             }
        }

        private void btnAddtoOrder_Click(object sender, EventArgs e)
        {
            // Read from menuItem Data Grid View and add to Order Menu Grid View ONLY if an item is selected
            if (menuItemsDataGridView.SelectedRows.Count > 0)
            {
                {
                    string itemName = (menuItemsDataGridView.Rows[menuItemsDataGridView.CurrentRow.Index].Cells["Name"].Value).ToString();
                    double itemPrice = Convert.ToDouble((menuItemsDataGridView.Rows[menuItemsDataGridView.CurrentRow.Index].Cells["Price"].Value).ToString());
                    string itemType = (menuItemsDataGridView.Rows[menuItemsDataGridView.CurrentRow.Index].Cells["Type"].Value).ToString();

                    int itemId = Convert.ToInt32(menuItemsDataGridView.Rows[menuItemsDataGridView.CurrentRow.Index].Cells[0].Value);

                    try
                    {
                        int amountToAdd = Convert.ToInt32(txtAmountToAdd.Text);

                        // Check if item already exists in the order
                        DataRow[] rows = orderItemsDataTable.Select($"ItemId = {itemId}");
                        if (rows.Length > 0)
                        {
                            // Increment quantity
                            rows[0]["Quantity"] = Convert.ToInt32(rows[0]["Quantity"]) + amountToAdd;
                            // Update price
                            rows[0]["Price"] = Convert.ToInt32(rows[0]["Quantity"]) * itemPrice;

                        }
                        else
                        {
                            // Add new row to DataTable
                            DataRow newRow = orderItemsDataTable.NewRow();
                            newRow["ItemId"] = itemId;
                            newRow["Name"] = itemName;
                            newRow["Type"] = itemType;
                            newRow["Quantity"] = amountToAdd;
                            newRow["Price"] = itemPrice * amountToAdd;
                            orderItemsDataTable.Rows.Add(newRow);
                        }

                        // Display confirmation message
                        MessageBox.Show(amountToAdd + " " + itemName + "(s) added to the order.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Reset the UI
                        txtAmountToAdd.Text = "1";
                        menuItemsDataGridView.ClearSelection();
                        


                        // Bind DataTable to DataGridView
                        orderItemsDataGridView.DataSource = orderItemsDataTable;
                        orderItemsDataGridView.Columns["ItemId"].Visible = false;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error while adding Menu Item to Order, \n\nPlease ensure count is a valid number and try again. \n\n ____________________________________ \n\n" + ex.ToString(), "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnCommit_Click(object sender, EventArgs e)
        {
            if (orderItemsDataGridView.Rows.Count != 0)
            {
                Order.CreateOrder();
                Order.AddNewOrderItems(orderItemsDataGridView);
                Order.CalculateOrderPrice(Order.GetNextOrderId()-1);

                orderItemsDataGridView.DataSource = new DataTable();

                //Refresh OrderID text box and clear order data table
                txtOrderId.Text = Convert.ToString(Order.GetNextOrderId());
                orderItemsDataTable.Clear();

                MessageBox.Show("Order has succesfully been comitted", "Order Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error while adding Menu Item to Order, \n\nPlease add at least one Menu Item to the order", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Utility.BackButton(this);
        }
    }
}
