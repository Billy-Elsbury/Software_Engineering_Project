using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace Restuarant_System
{
    public partial class frmEditOrder : Form
    {
        public frmEditOrder()
        {
            InitializeComponent();
        }

        // Initialize order items DataTable
        private DataTable orderItemsDataTable;

        private void frmEditOrder_Load(object sender, EventArgs e)
        {
            cboMenuItemType.Items.Add("");
            cboMenuItemType.Items.Add("F");
            cboMenuItemType.Items.Add("B");
            cboMenuItemType.Items.Add("D");

            //refresh Data Grid Views
            menuItemsDataGridView.DataSource = new DataTable();
            orderItemsDataGridView.DataSource = new DataTable();

            //config Orders Data Grid View

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


            //config orderItems data table

            orderItemsDataTable = new DataTable();
            orderItemsDataTable.Columns.Add("ItemId", typeof(int));
            orderItemsDataTable.Columns.Add("OrderId", typeof(int));
            orderItemsDataTable.Columns.Add("Name", typeof(string));
            orderItemsDataTable.Columns.Add("Type", typeof(string));
            orderItemsDataTable.Columns.Add("Quantity", typeof(int));
            orderItemsDataTable.Columns.Add("Price", typeof(double));

            //config Order Items Data Grid View

            orderItemsDataGridView.Name = "ordersItemsDataGridView";
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


            orderItemsDataGridView.DataSource = new DataTable();

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

        private void btnSearchOrder_Click(object sender, EventArgs e)
        {
            try
            {
                int maxOrder = Order.GetNextOrderId();

                int orderId = Convert.ToInt32(txtOrderId.Text);

                if (orderId >= 1 && orderId < maxOrder)
                {
                    DataTable dt = Order.GetOrderItemsByOrderId(orderId);
                    orderItemsDataGridView.DataSource = dt;

                    txtOrderTotalPrice.Text = Convert.ToString(Order.CalculateOrderPrice(orderId));

                    //ensure columns span whole DataGrid View Table
                    orderItemsDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    orderItemsDataGridView.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    orderItemsDataGridView.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                }
                else MessageBox.Show("Id out of range \n\nThere are currently: " + (maxOrder - 1) + " order(s)", "Information!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Please enter a valid number Id", "Information!", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    int orderId = Convert.ToInt32(txtOrderId.Text);
                    int itemId = Convert.ToInt32(menuItemsDataGridView.Rows[menuItemsDataGridView.CurrentRow.Index].Cells[0].Value);

                    try
                    {
                        int amountToAdd = Convert.ToInt32(txtAmountToAdd.Text);

                        //check if there is any order selected in the table
                        if (orderItemsDataGridView.Rows.Count != 0)
                        {
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
                                // maybe change to dataGridView if time permits

                                // Add new row to DataTable
                                DataRow newRow = orderItemsDataTable.NewRow();
                                newRow["OrderId"] = orderId;
                                newRow["ItemId"] = itemId;
                                newRow["Price"] = itemPrice * amountToAdd;
                                newRow["Quantity"] = amountToAdd;
                                
                                orderItemsDataTable.Rows.Add(newRow);

                                string insertOrderItemSql = "INSERT INTO OrderItems (OrderId, ItemId, UnitPrice, Quantity) VALUES (:OrderId, :ItemId, :UnitPrice, :Quantity)";

                            }


                            // Display confirmation message
                            MessageBox.Show(amountToAdd + " " + itemName + "(s) added to the order.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Reset the UI
                            txtAmountToAdd.Text = "1";
                            menuItemsDataGridView.ClearSelection();

                            //Order.AddOrderItems(orderItemsDataGridView);

                            // Bind DataTable to DataGridView
                            DataTable dt = Order.GetOrderItemsByOrderId(orderId);
                            orderItemsDataGridView.DataSource = dt;

                            txtOrderTotalPrice.Text = Convert.ToString(Order.CalculateOrderPrice(orderId));

                        }

                        else
                        {
                            MessageBox.Show("Please select an order", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error while adding Menu Item to Order", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            Utility.BackButton(this);
        }
    }
}
