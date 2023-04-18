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
    public partial class frmCancelOrder : Form
    {
        public frmCancelOrder()
        {
            InitializeComponent();
        }

        private void frmCancelOrder_Load(object sender, EventArgs e)
        {
            //Create menuItems Data Grid View

            ordersDataGridView.ColumnCount = 4;

            ordersDataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            ordersDataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            ordersDataGridView.ColumnHeadersDefaultCellStyle.Font =
                new Font(ordersDataGridView.Font, FontStyle.Bold);

            ordersDataGridView.Name = "ordersDataGridView";
            ordersDataGridView.AutoSizeRowsMode =
                DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            ordersDataGridView.ColumnHeadersBorderStyle =
                DataGridViewHeaderBorderStyle.Single;
            ordersDataGridView.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            ordersDataGridView.GridColor = Color.Black;
            ordersDataGridView.RowHeadersVisible = false;

            ordersDataGridView.Columns[0].Name = "Order ID";
            ordersDataGridView.Columns[1].Name = "Order Date";
            ordersDataGridView.Columns[2].Name = "Order Price";
            ordersDataGridView.Columns[3].Name = "Order Status";

            ordersDataGridView.Columns[0].DefaultCellStyle.Font =
                new Font(ordersDataGridView.DefaultCellStyle.Font, FontStyle.Bold);

            ordersDataGridView.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;
            ordersDataGridView.AllowUserToAddRows = false;
            ordersDataGridView.MultiSelect = false;

            foreach (DataGridViewColumn column in ordersDataGridView.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            //ensure columns span whole DataGrid View Table
            ordersDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ordersDataGridView.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            ordersDataGridView.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            //Populate Data Grid View with default information

            //get Current System Time
            String orderDate = DateTime.Now.ToString("MM/dd/yyyy h:mm tt");

            // { "Order ID", "Order Date", "Order Price", "Order Status" };

            string[] menuItem1 = { "1", orderDate, "14.00", "A - Available" };
            string[] menuItem2 = { "2", orderDate, "12.50", "U - Unavailable" };
            string[] menuItem3 = { "3", orderDate, "19.10", "A - Available" };
            string[] menuItem4 = { "4", orderDate, "47.50", "U - Unavailable" };
            string[] menuItem5 = { "5", orderDate, "106.50", "A - Available" };
            string[] menuItem6 = { "6", orderDate, "245.00", "A - Available" };
            string[] menuItem7 = { "7", orderDate, "9.60", "A - Available" };
            string[] menuItem8 = { "8", orderDate, "3.50", "U - Unavailable" };
            string[] menuItem9 = { "9", orderDate, "38.00", "A - Available" };
            string[] menuItem10 = { "10", orderDate, "15.20", "A - Available" };
            string[] menuItem11 = { "11", orderDate, "71.50", "U - Unavailable" };
            string[] menuItem12 = { "12", orderDate, "19.99", "A - Available" };

            ordersDataGridView.Rows.Add(menuItem1);
            ordersDataGridView.Rows.Add(menuItem2);
            ordersDataGridView.Rows.Add(menuItem3);
            ordersDataGridView.Rows.Add(menuItem4);
            ordersDataGridView.Rows.Add(menuItem5);
            ordersDataGridView.Rows.Add(menuItem6);
            ordersDataGridView.Rows.Add(menuItem7);
            ordersDataGridView.Rows.Add(menuItem8);
            ordersDataGridView.Rows.Add(menuItem9);
            ordersDataGridView.Rows.Add(menuItem10);
            ordersDataGridView.Rows.Add(menuItem11);
            ordersDataGridView.Rows.Add(menuItem12);
        }

        private void btnVoidOrder_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    int selectedRow = ordersDataGridView.Rows.GetFirstRow(DataGridViewElementStates.Selected);
                    ordersDataGridView.Rows.RemoveAt(selectedRow);
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Error in Void Order Function, Please try again. \n\n ____________________________________ \n\n" + ex.ToString(), "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
