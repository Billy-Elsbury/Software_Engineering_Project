﻿using System;
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

            foreach (DataGridViewColumn column in menuItemsDataGridView.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }


            //Create Order menuItems Data Grid View
            //Populate Data Grid View with information from database

            DataSet orderDataSet = OrderItem.GetAllOrderItems();

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
            // Read from menuItem Data Grid View and add to Order Menu Grid View ONLY if available

            string itemAvailability = (menuItemsDataGridView.Rows[menuItemsDataGridView.CurrentRow.Index].Cells[1].Value).ToString();
            string itemName = (menuItemsDataGridView.Rows[menuItemsDataGridView.CurrentRow.Index].Cells[3].Value).ToString();
            bool itemIsAvailable = false;

            if (itemAvailability.Equals("A"))
            {
                itemIsAvailable = true;
            }

            if (itemIsAvailable)
            {
                int itemId = Convert.ToInt32(menuItemsDataGridView.Rows[menuItemsDataGridView.CurrentRow.Index].Cells[0].Value);

                //try
                {
                    int amountToAdd = Convert.ToInt32(txtAmountToAdd.Text);
                    int orderId = Utility.GetNextOrderItemId();

                    // Create an instance of OrderItem for the selected menu item and quantity
                    OrderItem orderItem = new OrderItem();
                    orderItem.OrderId = orderId;
                    orderItem.ItemId = itemId;
                    orderItem.Quantity = amountToAdd;

                    // Invoke the method to place the order
                    orderItem.SaveOrderItem();

                    // Display confirmation message
                    MessageBox.Show(amountToAdd + " " + itemName + "(s) added to the order.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Reset the UI
                    txtAmountToAdd.Text = "1";
                    menuItemsDataGridView.ClearSelection();
                    
                }
                //catch (Exception ex)
                {
                   // MessageBox.Show("Error while adding Menu Item to Order, \n\nPlease ensure count is a valid number and try again.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
