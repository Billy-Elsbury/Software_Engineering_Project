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
            cboItemStatus.Items.Add("O - Open");
            cboItemStatus.Items.Add("C - Closed");
            cboItemStatus.Items.Add("V - Void");

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

        private void btnEditOrder_Click(object sender, EventArgs e)
        {
            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Utility.BackButton(this);
        }
    }
}
