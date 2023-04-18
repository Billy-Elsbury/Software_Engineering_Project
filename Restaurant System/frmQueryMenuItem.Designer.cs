
namespace Restuarant_System
{
    partial class frmQueryMenuItem
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuItemsDataGridView = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.cboItemID = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.grpQueryMenuItem = new System.Windows.Forms.GroupBox();
            this.btnClearFilters = new System.Windows.Forms.Button();
            this.btnFilter = new System.Windows.Forms.Button();
            this.cboItemAvailability = new System.Windows.Forms.ComboBox();
            this.cboMenuItemType = new System.Windows.Forms.ComboBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtItemDescription = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.menuItemsDataGridView)).BeginInit();
            this.grpQueryMenuItem.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuItemsDataGridView
            // 
            this.menuItemsDataGridView.BackgroundColor = System.Drawing.SystemColors.Info;
            this.menuItemsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.menuItemsDataGridView.Location = new System.Drawing.Point(151, 47);
            this.menuItemsDataGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.menuItemsDataGridView.Name = "menuItemsDataGridView";
            this.menuItemsDataGridView.ReadOnly = true;
            this.menuItemsDataGridView.Size = new System.Drawing.Size(613, 284);
            this.menuItemsDataGridView.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 62);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 16);
            this.label3.TabIndex = 27;
            this.label3.Text = "Select Menu Item:";
            // 
            // cboItemID
            // 
            this.cboItemID.BackColor = System.Drawing.SystemColors.Info;
            this.cboItemID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboItemID.FormattingEnabled = true;
            this.cboItemID.Location = new System.Drawing.Point(151, 361);
            this.cboItemID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboItemID.Name = "cboItemID";
            this.cboItemID.Size = new System.Drawing.Size(75, 24);
            this.cboItemID.TabIndex = 30;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label6.Location = new System.Drawing.Point(32, 364);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 16);
            this.label6.TabIndex = 29;
            this.label6.Text = "Select Item ID:";
            // 
            // grpQueryMenuItem
            // 
            this.grpQueryMenuItem.Controls.Add(this.btnClearFilters);
            this.grpQueryMenuItem.Controls.Add(this.btnFilter);
            this.grpQueryMenuItem.Controls.Add(this.cboItemAvailability);
            this.grpQueryMenuItem.Controls.Add(this.cboMenuItemType);
            this.grpQueryMenuItem.Controls.Add(this.btnBack);
            this.grpQueryMenuItem.Controls.Add(this.label7);
            this.grpQueryMenuItem.Controls.Add(this.label5);
            this.grpQueryMenuItem.Controls.Add(this.txtItemName);
            this.grpQueryMenuItem.Controls.Add(this.label1);
            this.grpQueryMenuItem.Controls.Add(this.label2);
            this.grpQueryMenuItem.Controls.Add(this.txtPrice);
            this.grpQueryMenuItem.Controls.Add(this.txtItemDescription);
            this.grpQueryMenuItem.Controls.Add(this.label4);
            this.grpQueryMenuItem.Controls.Add(this.cboItemID);
            this.grpQueryMenuItem.Controls.Add(this.label6);
            this.grpQueryMenuItem.Controls.Add(this.menuItemsDataGridView);
            this.grpQueryMenuItem.Controls.Add(this.label3);
            this.grpQueryMenuItem.Location = new System.Drawing.Point(16, 15);
            this.grpQueryMenuItem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpQueryMenuItem.Name = "grpQueryMenuItem";
            this.grpQueryMenuItem.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpQueryMenuItem.Size = new System.Drawing.Size(772, 686);
            this.grpQueryMenuItem.TabIndex = 22;
            this.grpQueryMenuItem.TabStop = false;
            this.grpQueryMenuItem.Text = "Query Menu Item";
            // 
            // btnClearFilters
            // 
            this.btnClearFilters.Location = new System.Drawing.Point(663, 465);
            this.btnClearFilters.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClearFilters.Name = "btnClearFilters";
            this.btnClearFilters.Size = new System.Drawing.Size(100, 70);
            this.btnClearFilters.TabIndex = 47;
            this.btnClearFilters.Text = "Clear";
            this.btnClearFilters.UseVisualStyleBackColor = true;
            this.btnClearFilters.Click += new System.EventHandler(this.btnClearFilters_Click);
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(663, 560);
            this.btnFilter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(100, 70);
            this.btnFilter.TabIndex = 46;
            this.btnFilter.Text = "Filter";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // cboItemAvailability
            // 
            this.cboItemAvailability.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboItemAvailability.FormattingEnabled = true;
            this.cboItemAvailability.Location = new System.Drawing.Point(151, 412);
            this.cboItemAvailability.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboItemAvailability.Name = "cboItemAvailability";
            this.cboItemAvailability.Size = new System.Drawing.Size(100, 24);
            this.cboItemAvailability.TabIndex = 45;
            // 
            // cboMenuItemType
            // 
            this.cboMenuItemType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMenuItemType.FormattingEnabled = true;
            this.cboMenuItemType.Location = new System.Drawing.Point(151, 458);
            this.cboMenuItemType.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboMenuItemType.Name = "cboMenuItemType";
            this.cboMenuItemType.Size = new System.Drawing.Size(100, 24);
            this.cboMenuItemType.TabIndex = 44;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(663, 650);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(100, 28);
            this.btnBack.TabIndex = 43;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.Info;
            this.label7.Location = new System.Drawing.Point(27, 415);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 16);
            this.label7.TabIndex = 41;
            this.label7.Text = "Item Availability:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Info;
            this.label5.Location = new System.Drawing.Point(53, 514);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 16);
            this.label5.TabIndex = 34;
            this.label5.Text = "Item Name:";
            // 
            // txtItemName
            // 
            this.txtItemName.Location = new System.Drawing.Point(151, 511);
            this.txtItemName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtItemName.MaxLength = 20;
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(209, 22);
            this.txtItemName.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(59, 462);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 16);
            this.label1.TabIndex = 33;
            this.label1.Text = "Item Type:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Info;
            this.label2.Location = new System.Drawing.Point(20, 564);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 16);
            this.label2.TabIndex = 36;
            this.label2.Text = "Item Description:";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(151, 606);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPrice.MaxLength = 7;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(100, 22);
            this.txtPrice.TabIndex = 38;
            this.txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtItemDescription
            // 
            this.txtItemDescription.Location = new System.Drawing.Point(151, 560);
            this.txtItemDescription.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtItemDescription.MaxLength = 30;
            this.txtItemDescription.Name = "txtItemDescription";
            this.txtItemDescription.Size = new System.Drawing.Size(335, 22);
            this.txtItemDescription.TabIndex = 35;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Info;
            this.label4.Location = new System.Drawing.Point(91, 609);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 16);
            this.label4.TabIndex = 37;
            this.label4.Text = "Price:";
            // 
            // frmQueryMenuItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 715);
            this.Controls.Add(this.grpQueryMenuItem);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmQueryMenuItem";
            this.Text = "frmQueryMenuItem";
            this.Load += new System.EventHandler(this.frmQueryMenuItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.menuItemsDataGridView)).EndInit();
            this.grpQueryMenuItem.ResumeLayout(false);
            this.grpQueryMenuItem.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView menuItemsDataGridView;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboItemID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox grpQueryMenuItem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtItemDescription;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ComboBox cboItemAvailability;
        private System.Windows.Forms.ComboBox cboMenuItemType;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Button btnClearFilters;
    }
}