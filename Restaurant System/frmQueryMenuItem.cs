﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restuarant_System
{
    public partial class frmQueryMenuItem : Form
    {
        public List<MenuItem> MenuItems { get; set; }

        public frmQueryMenuItem()
        {
            InitializeComponent();
        }

        private void frmQueryMenuItem_Load(object sender, EventArgs e)
        {
            //Retrieve itemID from database
            int itemIdCount = Convert.ToInt32(Utility.GetNextmenuItemId().ToString("0000"));

            cboItemID.Items.Add("");

            for (int i = 1; i < itemIdCount; i++)
                cboItemID.Items.Add(i);

            cboMenuItemType.Items.Add("");
            cboMenuItemType.Items.Add("F");
            cboMenuItemType.Items.Add("B");
            cboMenuItemType.Items.Add("D");

            cboItemAvailability.Items.Add("");
            cboItemAvailability.Items.Add("A");
            cboItemAvailability.Items.Add("U");

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
        }

        private void cboItemID_SelectedIndexChanged(object sender, EventArgs e)
        {
            //int selectedID = cboItemID.SelectedIndex;

            //String itemAvailability = (menuItemsDataGridView.Rows[selectedID].Cells[0].Value).ToString();
            //cboItemAvailability.Text = Convert.ToString(itemAvailability);

            //String itemType = (menuItemsDataGridView.Rows[selectedID].Cells[1].Value).ToString();
            //cboMenuItemType.Text = Convert.ToString(itemType);

            //String itemName = (menuItemsDataGridView.Rows[selectedID].Cells[2].Value).ToString();
            //txtItemName.Text = Convert.ToString(itemName);

            //String itemDescription = (menuItemsDataGridView.Rows[selectedID].Cells[4].Value).ToString();
            //txtItemDescription.Text = itemDescription;

            //String itemPrice = (menuItemsDataGridView.Rows[selectedID].Cells[5].Value).ToString();
            //txtPrice.Text = itemPrice;

            //menuItemsDataGridView.Rows[selectedID].Selected = true;
        }

        private void menuItemsDataGridView_Click(object sender, EventArgs e)
        {
            if (menuItemsDataGridView.SelectedRows.Count > 0) // Check if a row is selected first to avoid crash when selecting empty part of grid view
            {
                //Read from Data Grid View and display on form

                int itemID = Convert.ToInt32(menuItemsDataGridView.Rows[menuItemsDataGridView.CurrentRow.Index].Cells[0].Value);
                cboItemID.Text = Convert.ToString(itemID);

                String itemAvailability = (menuItemsDataGridView.Rows[menuItemsDataGridView.CurrentRow.Index].Cells[1].Value).ToString();
                cboItemAvailability.Text = itemAvailability;

                String itemType = (menuItemsDataGridView.Rows[menuItemsDataGridView.CurrentRow.Index].Cells[2].Value).ToString();
                cboMenuItemType.Text = itemType;

                String itemName = (menuItemsDataGridView.Rows[menuItemsDataGridView.CurrentRow.Index].Cells[3].Value).ToString();
                txtItemName.Text = Convert.ToString(itemName);

                String itemDescription = (menuItemsDataGridView.Rows[menuItemsDataGridView.CurrentRow.Index].Cells[4].Value).ToString();
                txtItemDescription.Text = itemDescription;

                String itemPrice = (menuItemsDataGridView.Rows[menuItemsDataGridView.CurrentRow.Index].Cells[5].Value).ToString();
                txtPrice.Text = itemPrice;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Utility.BackButton(this);
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            // Validate the input before filtering
            string errorMessage;

            if (!Utility.ValidationUtility.QueryValidFilter(txtItemName.Text, txtItemDescription.Text, txtPrice.Text, out errorMessage))
            {
                MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //https://stackoverflow.com/questions/1264681/what-is-the-purpose-of-using-where-1-1-in-sql-statements

            string sql = "SELECT * FROM MenuItems WHERE 1=1";
            if (!string.IsNullOrEmpty(cboItemID.Text))
            {
                sql += $" AND ItemId = {cboItemID.Text}";
            }
            if (!string.IsNullOrEmpty(cboItemAvailability.Text))
            {
                sql += $" AND Availability = '{cboItemAvailability.Text}'";
            }
            if (!string.IsNullOrEmpty(cboMenuItemType.Text))
            {
                sql += $" AND Type = '{cboMenuItemType.Text}'";
            }
            if (!string.IsNullOrEmpty(txtItemName.Text))
            {
                sql += $" AND Name LIKE '%{txtItemName.Text}%'";
            }
            if (!string.IsNullOrEmpty(txtItemDescription.Text))
            {
                sql += $" AND Description LIKE '%{txtItemDescription.Text}%'";
            }
            if (!string.IsNullOrEmpty(txtPrice.Text))
            {
                sql += $" AND Price LIKE '{txtPrice.Text}%'";
            }
            DataSet dataSet = MenuItem.FilterMenuItems(sql);


            if (dataSet != null && dataSet.Tables.Count > 0 && dataSet.Tables[0].Rows.Count > 0)
            {
                menuItemsDataGridView.DataSource = dataSet.Tables[0];
            }
            else
            {
                menuItemsDataGridView.DataSource = new DataTable();
            }
        }

        private void btnClearFilters_Click(object sender, EventArgs e)
        {
            // Clear text boxes
            txtItemName.Text = "";
            txtItemDescription.Text = "";
            txtPrice.Text = "";

            // Clear combo boxes
            cboItemID.SelectedIndex = 0;
            cboItemAvailability.SelectedIndex = 0;
            cboMenuItemType.SelectedIndex = 0;
        }

    }
}
