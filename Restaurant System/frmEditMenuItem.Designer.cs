
namespace Restuarant_System
{
    partial class frmEditMenuItem
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
            this.grpEditMenuItem = new System.Windows.Forms.GroupBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cboItemAvailability = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboMenuItemType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtItemDescription = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboItemID = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.menuItemsDataGridView = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.btnEditMenuItem = new System.Windows.Forms.Button();
            this.grpEditMenuItem.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuItemsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // grpEditMenuItem
            // 
            this.grpEditMenuItem.Controls.Add(this.btnBack);
            this.grpEditMenuItem.Controls.Add(this.groupBox1);
            this.grpEditMenuItem.Controls.Add(this.cboItemID);
            this.grpEditMenuItem.Controls.Add(this.label6);
            this.grpEditMenuItem.Controls.Add(this.menuItemsDataGridView);
            this.grpEditMenuItem.Controls.Add(this.label3);
            this.grpEditMenuItem.Controls.Add(this.btnEditMenuItem);
            this.grpEditMenuItem.Location = new System.Drawing.Point(16, 15);
            this.grpEditMenuItem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpEditMenuItem.Name = "grpEditMenuItem";
            this.grpEditMenuItem.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpEditMenuItem.Size = new System.Drawing.Size(772, 753);
            this.grpEditMenuItem.TabIndex = 21;
            this.grpEditMenuItem.TabStop = false;
            this.grpEditMenuItem.Text = "Edit Menu Item Details";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(664, 710);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(100, 28);
            this.btnBack.TabIndex = 44;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cboItemAvailability);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtItemName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cboMenuItemType);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtPrice);
            this.groupBox1.Controls.Add(this.txtItemDescription);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(36, 394);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(368, 286);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Editable";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 27);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 17);
            this.label7.TabIndex = 27;
            this.label7.Text = "Item Availability:";
            // 
            // cboItemAvailability
            // 
            this.cboItemAvailability.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboItemAvailability.FormattingEnabled = true;
            this.cboItemAvailability.Location = new System.Drawing.Point(149, 23);
            this.cboItemAvailability.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboItemAvailability.Name = "cboItemAvailability";
            this.cboItemAvailability.Size = new System.Drawing.Size(100, 24);
            this.cboItemAvailability.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(52, 124);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 17);
            this.label5.TabIndex = 21;
            this.label5.Text = "Item Name:";
            // 
            // txtItemName
            // 
            this.txtItemName.Location = new System.Drawing.Point(149, 121);
            this.txtItemName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtItemName.MaxLength = 20;
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(209, 22);
            this.txtItemName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 73);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 19;
            this.label1.Text = "Item Type:";
            // 
            // cboMenuItemType
            // 
            this.cboMenuItemType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMenuItemType.FormattingEnabled = true;
            this.cboMenuItemType.Location = new System.Drawing.Point(149, 69);
            this.cboMenuItemType.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboMenuItemType.Name = "cboMenuItemType";
            this.cboMenuItemType.Size = new System.Drawing.Size(100, 24);
            this.cboMenuItemType.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 175);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 17);
            this.label2.TabIndex = 23;
            this.label2.Text = "Item Description:";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(149, 244);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPrice.MaxLength = 7;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(100, 22);
            this.txtPrice.TabIndex = 25;
            this.txtPrice.Text = "0.00";
            this.txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtItemDescription
            // 
            this.txtItemDescription.Location = new System.Drawing.Point(149, 171);
            this.txtItemDescription.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtItemDescription.MaxLength = 30;
            this.txtItemDescription.Name = "txtItemDescription";
            this.txtItemDescription.Size = new System.Drawing.Size(209, 22);
            this.txtItemDescription.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(89, 247);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 17);
            this.label4.TabIndex = 24;
            this.label4.Text = "Price:";
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
            this.cboItemID.SelectedIndexChanged += new System.EventHandler(this.cboItemID_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label6.Location = new System.Drawing.Point(32, 364);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 17);
            this.label6.TabIndex = 29;
            this.label6.Text = "Select Item ID:";
            // 
            // menuItemsDataGridView
            // 
            this.menuItemsDataGridView.BackgroundColor = System.Drawing.SystemColors.Info;
            this.menuItemsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.menuItemsDataGridView.Location = new System.Drawing.Point(151, 47);
            this.menuItemsDataGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.menuItemsDataGridView.Name = "menuItemsDataGridView";
            this.menuItemsDataGridView.ReadOnly = true;
            this.menuItemsDataGridView.RowHeadersWidth = 51;
            this.menuItemsDataGridView.Size = new System.Drawing.Size(613, 284);
            this.menuItemsDataGridView.TabIndex = 28;
            this.menuItemsDataGridView.Click += new System.EventHandler(this.menuItemsDataGridView_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 62);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 17);
            this.label3.TabIndex = 27;
            this.label3.Text = "Select Menu Item:";
            // 
            // btnEditMenuItem
            // 
            this.btnEditMenuItem.BackColor = System.Drawing.SystemColors.Info;
            this.btnEditMenuItem.Location = new System.Drawing.Point(8, 703);
            this.btnEditMenuItem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEditMenuItem.Name = "btnEditMenuItem";
            this.btnEditMenuItem.Size = new System.Drawing.Size(204, 43);
            this.btnEditMenuItem.TabIndex = 3;
            this.btnEditMenuItem.Text = "Edit Menu Item";
            this.btnEditMenuItem.UseVisualStyleBackColor = false;
            this.btnEditMenuItem.Click += new System.EventHandler(this.btnEditMenuItem_Click);
            // 
            // frmEditMenuItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 783);
            this.Controls.Add(this.grpEditMenuItem);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmEditMenuItem";
            this.Text = "Billy\'s Restuarant - [Edit Menu Item]";
            this.Load += new System.EventHandler(this.frmEditMenuItem_Load);
            this.grpEditMenuItem.ResumeLayout(false);
            this.grpEditMenuItem.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuItemsDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpEditMenuItem;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtItemDescription;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEditMenuItem;
        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView menuItemsDataGridView;
        private System.Windows.Forms.ComboBox cboItemID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboMenuItemType;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboItemAvailability;
        private System.Windows.Forms.Button btnBack;
    }
}