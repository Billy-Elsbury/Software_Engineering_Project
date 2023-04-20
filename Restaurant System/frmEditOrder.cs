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

        private void frmEditOrder_Load(object sender, EventArgs e)
        {
            cboOrderStatus.Items.Add("");
            cboOrderStatus.Items.Add("O - Open");
            cboOrderStatus.Items.Add("C - Closed");
            cboOrderStatus.Items.Add("V - Void");

            cboNewOrderStatus.Items.Add("O - Open");
            cboNewOrderStatus.Items.Add("C - Closed");
            cboNewOrderStatus.Items.Add("V - Void");

            //Populate Data Grid View with information from database

            DataSet dataSet = Order.GetAllOrders();

            ordersDataGridView.DataSource = dataSet.Tables[0];

            //config Data Grid View

            ordersDataGridView.Name = "ordersDataGridView";
            ordersDataGridView.AutoSizeRowsMode =
                DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            ordersDataGridView.ColumnHeadersBorderStyle =
                DataGridViewHeaderBorderStyle.Single;
            ordersDataGridView.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            ordersDataGridView.GridColor = Color.Black;
            ordersDataGridView.RowHeadersVisible = false;

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
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            string orderId = txtOrderId.Text;
            string orderStatus;

            if (string.IsNullOrEmpty(cboOrderStatus.Text))
            {
                orderStatus = "";
            }
            else orderStatus = (cboOrderStatus.Text.Substring(0, 1));

            string sql = Order.GenerateSqlFilterOrderQuery(orderId, orderStatus);

            DataSet dataSet = Utility.GetFilteredResult(sql);

            if (dataSet != null && dataSet.Tables.Count > 0 && dataSet.Tables[0].Rows.Count > 0)
            {
                ordersDataGridView.DataSource = dataSet.Tables[0];
            }
            else
            {
                ordersDataGridView.DataSource = new DataTable();
            }
        }

        private void btnClearFilters_Click(object sender, EventArgs e)
        {
            // Clear text boxes
            txtOrderId.Text = "";

            // Clear combo boxes
            cboOrderStatus.SelectedIndex = 0;
        }

        private void btnEditOrder_Click(object sender, EventArgs e)
        {
            // Get input values from form controls
            string newOrderStatus;

            if (string.IsNullOrEmpty(cboNewOrderStatus.Text))
            {
                newOrderStatus = "";
            }
            else newOrderStatus = (cboNewOrderStatus.Text.Substring(0, 1));

            {
                try
                {
                    int maxOrder = Order.GetNextOrderId();
                    int orderId = Convert.ToInt32((ordersDataGridView.Rows[ordersDataGridView.CurrentRow.Index].Cells[0].Value).ToString());

                    if (orderId >= 1 && orderId < maxOrder)
                    {
                        Order.UpdateOrderStatus(txtOrderId.Text, Convert.ToChar(newOrderStatus));

                        //display confirmation message
                        MessageBox.Show("Product " + txtOrderId.Text + " updated successfully", "Success",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
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
