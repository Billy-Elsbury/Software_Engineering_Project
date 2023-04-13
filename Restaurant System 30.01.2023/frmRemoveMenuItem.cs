using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Restuarant_System
{
    public partial class frmRemoveMenuItem : Form
    {
        public frmRemoveMenuItem()
        {
            InitializeComponent();
        }

        private void frmRemoveMenuItem_Load(object sender, EventArgs e)
        {
            //Create Data Grid View

            menuItemsDataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            menuItemsDataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            menuItemsDataGridView.ColumnHeadersDefaultCellStyle.Font = new Font(menuItemsDataGridView.Font, FontStyle.Bold);

            menuItemsDataGridView.Name = "menuItemsDataGridView";
            menuItemsDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            menuItemsDataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            menuItemsDataGridView.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            menuItemsDataGridView.GridColor = Color.Black;
            menuItemsDataGridView.ForeColor = Color.Black;
            menuItemsDataGridView.RowHeadersVisible = false;
            menuItemsDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            menuItemsDataGridView.AllowUserToAddRows = false;
            menuItemsDataGridView.MultiSelect = false;

            //ensure columns span whole DataGrid View Table
            menuItemsDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


            //Populate Data Grid View with information from database

            DataSet dataSet = MenuItem.getSummarisedMenuItems();

            menuItemsDataGridView.DataSource = dataSet.Tables[0];


            foreach (DataGridViewColumn column in menuItemsDataGridView.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

        private void btnRemoveMenuItem_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    //Retrieve itemID
                    
                    int selectedId = menuItemsDataGridView.CurrentCell.RowIndex;

                    //remove item from database

                    //MenuItem.UpdateMenuItem(Convert.ToInt32(selectedId));

                    //display confirmation message
                    //MessageBox.Show("Product Id: " + selectedId + " removed from available Menu Items successfully", "Success",
                    //MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //update data grid view table.
                    DataSet dataSet = MenuItem.getSummarisedMenuItems();
                    menuItemsDataGridView.DataSource = dataSet.Tables[0];
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Error in Remove Function, Please try again.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void menuItemsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure", "Some Title", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                MenuItem.RemoveItem(Convert.ToInt32(menuItemsDataGridView.Rows[menuItemsDataGridView.CurrentCell.RowIndex].Cells[0].Value));

                MessageBox.Show("Product Id: " + menuItemsDataGridView.Rows[menuItemsDataGridView.CurrentCell.RowIndex].Cells[0].Value + " removed from available Menu Items successfully", "Success");
            }
        }

        private void grpEditMenuItem_Enter(object sender, EventArgs e)
        {

        }
    }
}
