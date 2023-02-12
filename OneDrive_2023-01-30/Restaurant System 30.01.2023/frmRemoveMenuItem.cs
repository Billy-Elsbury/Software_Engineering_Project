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

            menuItemsDataGridView.ColumnCount = 5;

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

            menuItemsDataGridView.Columns[0].Name = "ID";
            menuItemsDataGridView.Columns[1].Name = "Name";
            menuItemsDataGridView.Columns[2].Name = "Type";
            menuItemsDataGridView.Columns[3].Name = "Description";
            menuItemsDataGridView.Columns[4].Name = "Price";
            menuItemsDataGridView.Columns[0].DefaultCellStyle.Font =
                new Font(menuItemsDataGridView.DefaultCellStyle.Font, FontStyle.Italic);

            menuItemsDataGridView.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;
            menuItemsDataGridView.AllowUserToAddRows = false;
            menuItemsDataGridView.MultiSelect = false;

            //ensure columns span whole DataGrid View Table
            menuItemsDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            menuItemsDataGridView.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;


            //Populate Data Grid View with default information

            string[] menuItem1 = { "1", "Spaghetti", "F - Food", "Italian", "14.00" };
            string[] menuItem2 = { "2", "Sushi", "F - Food", "Japanese", "12.50" };
            string[] menuItem3 = { "3", "Guiness", "B - Beverage", "Irish", "4.90" };
            string[] menuItem4 = { "4", "CheeseCake", "D - Dessert", "Greek", "7.50" };
            string[] menuItem5 = { "5", "Chips", "F - Food", "Belgium", "6.00" };
            string[] menuItem6 = { "6", "Apple-Pie", "D - Dessert", "English", "5.40" };
            string[] menuItem7 = { "7", "Bloody Mary", "B - Beverage", "French", "9.75" };
            string[] menuItem8 = { "8", "Vindaloo", "F - Food", "Portuguese", "12.00" };
            string[] menuItem9 = { "9", "Mojito", "B - Beverage", "Cuban", "4.90" };
            string[] menuItem10 = { "10", "Biryani", "F - Food", "Persian", "9.99" };
            string[] menuItem11 = { "11", "Quesadilla", "F - Food", "Mexican", "6.50" };
            string[] menuItem12 = { "12", "Chow Mein", "F - Food", "Chinese", "10.75" };

            menuItemsDataGridView.Rows.Add(menuItem1);
            menuItemsDataGridView.Rows.Add(menuItem2);
            menuItemsDataGridView.Rows.Add(menuItem3);
            menuItemsDataGridView.Rows.Add(menuItem4);
            menuItemsDataGridView.Rows.Add(menuItem5);
            menuItemsDataGridView.Rows.Add(menuItem6);
            menuItemsDataGridView.Rows.Add(menuItem7);
            menuItemsDataGridView.Rows.Add(menuItem8);
            menuItemsDataGridView.Rows.Add(menuItem9);
            menuItemsDataGridView.Rows.Add(menuItem10);
            menuItemsDataGridView.Rows.Add(menuItem11);
            menuItemsDataGridView.Rows.Add(menuItem12);

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
                    int selectedRow = menuItemsDataGridView.Rows.GetFirstRow(DataGridViewElementStates.Selected);
                    menuItemsDataGridView.Rows.RemoveAt(selectedRow);
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Error in Remove Function, Please try again.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
