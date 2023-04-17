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
            // Populate Data Grid View with information from database
            DataSet dataSet = MenuItem.GetAllMenuItems();
            menuItemsDataGridView.DataSource = dataSet.Tables[0];

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

            menuItemsDataGridView.Columns[0].DefaultCellStyle.Font =
                new Font(menuItemsDataGridView.DefaultCellStyle.Font, FontStyle.Italic);

            menuItemsDataGridView.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;
            menuItemsDataGridView.AllowUserToAddRows = false;
            menuItemsDataGridView.MultiSelect = false;

            // Ensure columns span whole DataGrid View Table
            menuItemsDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            menuItemsDataGridView.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            foreach (DataGridViewColumn column in menuItemsDataGridView.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }



            // Populate Data Grid View with information from database
            DataSet orderDataSet = OrderItems.GetActiveOrderItems(Utility.GetNextOrderItemId() -1);

            orderItemsDataGridView.DataSource = orderDataSet.Tables[0];

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
            orderItemsDataGridView.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            foreach (DataGridViewColumn column in orderItemsDataGridView.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

        }

        private void btnAddtoOrder_Click(object sender, EventArgs e)
        {
            // Read from menuItem Data Grid View and add to Order Menu Grid View ONLY if available

            char itemAvailability = Convert.ToChar((menuItemsDataGridView.Rows[menuItemsDataGridView.CurrentRow.Index].Cells[1].Value).ToString());
            string itemName = (menuItemsDataGridView.Rows[menuItemsDataGridView.CurrentRow.Index].Cells[3].Value).ToString();
            double itemPrice = Convert.ToDouble((menuItemsDataGridView.Rows[menuItemsDataGridView.CurrentRow.Index].Cells[5].Value).ToString());

            bool itemIsAvailable = false;

            if (itemAvailability == 'A')
            {
                itemIsAvailable = true;
            }

            if (itemIsAvailable)
            {
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
                    DataSet orderDataSet = OrderItems.GetActiveOrderItems(Utility.GetNextOrderItemId()-1);
                    orderItemsDataGridView.DataSource = orderDataSet.Tables[0];

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
            MessageBox.Show("Order has succesfully been comitted", "Order Added", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Order.PlaceOrder();

            DataSet orderDataSet = OrderItems.GetActiveOrderItems(Utility.GetNextOrderItemId());
            orderItemsDataGridView.DataSource = orderDataSet.Tables[0];
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
