
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
            this.grpEditMenuItem.Location = new System.Drawing.Point(12, 12);
            this.grpEditMenuItem.Name = "grpEditMenuItem";
            this.grpEditMenuItem.Size = new System.Drawing.Size(579, 612);
            this.grpEditMenuItem.TabIndex = 21;
            this.grpEditMenuItem.TabStop = false;
            this.grpEditMenuItem.Text = "Edit Menu Item Details";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(498, 577);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
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
            this.groupBox1.Location = new System.Drawing.Point(27, 320);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(408, 232);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Editable";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "Item Availability:";
            // 
            // cboItemAvailability
            // 
            this.cboItemAvailability.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboItemAvailability.FormattingEnabled = true;
            this.cboItemAvailability.Location = new System.Drawing.Point(112, 19);
            this.cboItemAvailability.Name = "cboItemAvailability";
            this.cboItemAvailability.Size = new System.Drawing.Size(76, 21);
            this.cboItemAvailability.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Item Name:";
            // 
            // txtItemName
            // 
            this.txtItemName.Location = new System.Drawing.Point(112, 98);
            this.txtItemName.MaxLength = 20;
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(158, 20);
            this.txtItemName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Item Type:";
            // 
            // cboMenuItemType
            // 
            this.cboMenuItemType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMenuItemType.FormattingEnabled = true;
            this.cboMenuItemType.Location = new System.Drawing.Point(112, 56);
            this.cboMenuItemType.Name = "cboMenuItemType";
            this.cboMenuItemType.Size = new System.Drawing.Size(76, 21);
            this.cboMenuItemType.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Item Description:";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(112, 198);
            this.txtPrice.MaxLength = 7;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(76, 20);
            this.txtPrice.TabIndex = 25;
            this.txtPrice.Text = "0.00";
            this.txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtItemDescription
            // 
            this.txtItemDescription.Location = new System.Drawing.Point(112, 139);
            this.txtItemDescription.MaxLength = 30;
            this.txtItemDescription.Name = "txtItemDescription";
            this.txtItemDescription.Size = new System.Drawing.Size(290, 20);
            this.txtItemDescription.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(67, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Price:";
            // 
            // cboItemID
            // 
            this.cboItemID.BackColor = System.Drawing.SystemColors.Info;
            this.cboItemID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboItemID.FormattingEnabled = true;
            this.cboItemID.Location = new System.Drawing.Point(113, 293);
            this.cboItemID.Name = "cboItemID";
            this.cboItemID.Size = new System.Drawing.Size(57, 21);
            this.cboItemID.TabIndex = 30;
            this.cboItemID.SelectedIndexChanged += new System.EventHandler(this.cboItemID_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label6.Location = new System.Drawing.Point(24, 296);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "Select Item ID:";
            // 
            // menuItemsDataGridView
            // 
            this.menuItemsDataGridView.BackgroundColor = System.Drawing.SystemColors.Info;
            this.menuItemsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.menuItemsDataGridView.Location = new System.Drawing.Point(113, 38);
            this.menuItemsDataGridView.Name = "menuItemsDataGridView";
            this.menuItemsDataGridView.ReadOnly = true;
            this.menuItemsDataGridView.RowHeadersWidth = 51;
            this.menuItemsDataGridView.Size = new System.Drawing.Size(460, 231);
            this.menuItemsDataGridView.TabIndex = 28;
            this.menuItemsDataGridView.Click += new System.EventHandler(this.menuItemsDataGridView_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Select Menu Item:";
            // 
            // btnEditMenuItem
            // 
            this.btnEditMenuItem.BackColor = System.Drawing.SystemColors.Info;
            this.btnEditMenuItem.Location = new System.Drawing.Point(6, 571);
            this.btnEditMenuItem.Name = "btnEditMenuItem";
            this.btnEditMenuItem.Size = new System.Drawing.Size(153, 35);
            this.btnEditMenuItem.TabIndex = 3;
            this.btnEditMenuItem.Text = "Edit Menu Item";
            this.btnEditMenuItem.UseVisualStyleBackColor = false;
            this.btnEditMenuItem.Click += new System.EventHandler(this.btnEditMenuItem_Click);
            // 
            // frmEditMenuItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 636);
            this.Controls.Add(this.grpEditMenuItem);
            this.Name = "frmEditMenuItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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