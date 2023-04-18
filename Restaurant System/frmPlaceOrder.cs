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
            cboMenuItemType.Items.Add("");
            cboMenuItemType.Items.Add("F");
            cboMenuItemType.Items.Add("B");
            cboMenuItemType.Items.Add("D");

            menuItemsDataGridView.DataSource = new DataTable();

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
            txtOrderId.Text = (Convert.ToString(Utility.GetNextOrderItemId()));

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

        private void btnAddtoOrder_Click(object sender, EventArgs e)
        {
            // Read from menuItem Data Grid View and add to Order Menu Grid View ONLY if available
            {
                string itemName = (menuItemsDataGridView.Rows[menuItemsDataGridView.CurrentRow.Index].Cells["Name"].Value).ToString();
                double itemPrice = Convert.ToDouble((menuItemsDataGridView.Rows[menuItemsDataGridView.CurrentRow.Index].Cells["Price"].Value).ToString());

                int itemId = Convert.ToInt32(menuItemsDataGridView.Rows[menuItemsDataGridView.CurrentRow.Index].Cells[0].Value);

                try
                {
                    int amountToAdd = Convert.ToInt32(txtAmountToAdd.Text);
                    int orderId = Utility.GetNextOrderItemId();

                    // Create an instance of OrderItem for the selected menu item and quantity
                    OrderItems orderItem = new OrderItems();
                    orderItem.OrderId = orderId;
                    orderItem.ItemId = itemId;
                    orderItem.Quantity = amountToAdd;
                    orderItem.OrderItemPrice = itemPrice;

                    // Invoke the method to save the order item to order items
                    orderItem.SaveOrderItem();

                    // Display confirmation message
                    MessageBox.Show(amountToAdd + " " + itemName + "(s) added to the order.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Reset the UI
                    txtAmountToAdd.Text = "1";
                    menuItemsDataGridView.ClearSelection();

                    // Update Data Grid View with information from database
                    DataSet orderDataSet = OrderItems.GetActiveOrderItems(Utility.GetNextOrderItemId() - 1);
                    orderItemsDataGridView.DataSource = orderDataSet.Tables[0];

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error while adding Menu Item to Order, \n\nPlease ensure count is a valid number and try again. \n\n ____________________________________ \n\n" + ex.ToString(), "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void btnCommit_Click(object sender, EventArgs e)
        {
            if (orderItemsDataGridView.Rows.Count != 0)
            {
                MessageBox.Show("Order has succesfully been comitted", "Order Added", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Order.PlaceOrder();

                DataSet orderDataSet = OrderItems.GetActiveOrderItems(Utility.GetNextOrderItemId());
                orderItemsDataGridView.DataSource = orderDataSet.Tables[0];

                //Update OrderID to text box
                txtOrderId.Text = (Convert.ToString(Utility.GetNextOrderItemId()));
            }
            else 
            {
                MessageBox.Show("Error while adding Menu Item to Order, \n\nPlease add at least one Menu Item to the order", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            //1=1 is always true so allows more concise sql
            //https://stackoverflow.com/questions/1264681/what-is-the-purpose-of-using-where-1-1-in-sql-statements

            //cleaner method of constructing sql string allowing variable using {variable}
            //https://learn.microsoft.com/en-us/dotnet/visual-basic/programming-guide/language-features/strings/interpolated-strings

            string sql = "SELECT ItemId, Name, Type, Price FROM MenuItems WHERE Availability = 'A'";

            if (!string.IsNullOrEmpty(cboMenuItemType.Text))
            {
                sql += $" AND Type = '{cboMenuItemType.Text}'";
            }
            if (!string.IsNullOrEmpty(txtItemName.Text))
            {
                sql += $" AND LOWER(Name) LIKE '%{txtItemName.Text}%'";
            }

            sql += " ORDER BY Name";

            DataSet dataSet = MenuItem.FilterMenuItems(sql);

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

    }
}
