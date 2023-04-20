
namespace Restuarant_System
{
    partial class frmPlaceOrder
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
            this.grpAddMenuItem = new System.Windows.Forms.GroupBox();
            this.cboMenuItemType = new System.Windows.Forms.ComboBox();
            this.lblItemType = new System.Windows.Forms.Label();
            this.btnSearchMenuItem = new System.Windows.Forms.Button();
            this.txtOrderId = new System.Windows.Forms.TextBox();
            this.lblOrderId = new System.Windows.Forms.Label();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.lblItemName = new System.Windows.Forms.Label();
            this.btnCommit = new System.Windows.Forms.Button();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtAmountToAdd = new System.Windows.Forms.TextBox();
            this.txtOrderItems = new System.Windows.Forms.TextBox();
            this.orderItemsDataGridView = new System.Windows.Forms.DataGridView();
            this.menuItemsDataGridView = new System.Windows.Forms.DataGridView();
            this.btnAddtoOrder = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.grpAddMenuItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderItemsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuItemsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // grpAddMenuItem
            // 
            this.grpAddMenuItem.Controls.Add(this.btnBack);
            this.grpAddMenuItem.Controls.Add(this.cboMenuItemType);
            this.grpAddMenuItem.Controls.Add(this.lblItemType);
            this.grpAddMenuItem.Controls.Add(this.btnSearchMenuItem);
            this.grpAddMenuItem.Controls.Add(this.txtOrderId);
            this.grpAddMenuItem.Controls.Add(this.lblOrderId);
            this.grpAddMenuItem.Controls.Add(this.txtItemName);
            this.grpAddMenuItem.Controls.Add(this.lblItemName);
            this.grpAddMenuItem.Controls.Add(this.btnCommit);
            this.grpAddMenuItem.Controls.Add(this.txtQuantity);
            this.grpAddMenuItem.Controls.Add(this.txtAmountToAdd);
            this.grpAddMenuItem.Controls.Add(this.txtOrderItems);
            this.grpAddMenuItem.Controls.Add(this.orderItemsDataGridView);
            this.grpAddMenuItem.Controls.Add(this.menuItemsDataGridView);
            this.grpAddMenuItem.Controls.Add(this.btnAddtoOrder);
            this.grpAddMenuItem.Location = new System.Drawing.Point(12, 12);
            this.grpAddMenuItem.Name = "grpAddMenuItem";
            this.grpAddMenuItem.Size = new System.Drawing.Size(924, 596);
            this.grpAddMenuItem.TabIndex = 21;
            this.grpAddMenuItem.TabStop = false;
            this.grpAddMenuItem.Text = "Place New Order";
            // 
            // cboMenuItemType
            // 
            this.cboMenuItemType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMenuItemType.FormattingEnabled = true;
            this.cboMenuItemType.Location = new System.Drawing.Point(141, 94);
            this.cboMenuItemType.Name = "cboMenuItemType";
            this.cboMenuItemType.Size = new System.Drawing.Size(52, 21);
            this.cboMenuItemType.TabIndex = 50;
            // 
            // lblItemType
            // 
            this.lblItemType.AutoSize = true;
            this.lblItemType.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblItemType.Location = new System.Drawing.Point(22, 97);
            this.lblItemType.Name = "lblItemType";
            this.lblItemType.Size = new System.Drawing.Size(112, 13);
            this.lblItemType.TabIndex = 49;
            this.lblItemType.Text = "Search for - Item Type";
            // 
            // btnSearchMenuItem
            // 
            this.btnSearchMenuItem.Location = new System.Drawing.Point(317, 71);
            this.btnSearchMenuItem.Name = "btnSearchMenuItem";
            this.btnSearchMenuItem.Size = new System.Drawing.Size(121, 44);
            this.btnSearchMenuItem.TabIndex = 47;
            this.btnSearchMenuItem.Text = "Search";
            this.btnSearchMenuItem.UseVisualStyleBackColor = true;
            this.btnSearchMenuItem.Click += new System.EventHandler(this.btnSearchMenuItem_Click);
            // 
            // txtOrderId
            // 
            this.txtOrderId.Location = new System.Drawing.Point(141, 28);
            this.txtOrderId.MaxLength = 20;
            this.txtOrderId.Name = "txtOrderId";
            this.txtOrderId.ReadOnly = true;
            this.txtOrderId.Size = new System.Drawing.Size(52, 20);
            this.txtOrderId.TabIndex = 36;
            // 
            // lblOrderId
            // 
            this.lblOrderId.AutoSize = true;
            this.lblOrderId.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblOrderId.Location = new System.Drawing.Point(80, 31);
            this.lblOrderId.Name = "lblOrderId";
            this.lblOrderId.Size = new System.Drawing.Size(50, 13);
            this.lblOrderId.TabIndex = 37;
            this.lblOrderId.Text = "Order ID:";
            // 
            // txtItemName
            // 
            this.txtItemName.Location = new System.Drawing.Point(141, 63);
            this.txtItemName.MaxLength = 20;
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(158, 20);
            this.txtItemName.TabIndex = 34;
            // 
            // lblItemName
            // 
            this.lblItemName.AutoSize = true;
            this.lblItemName.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblItemName.Location = new System.Drawing.Point(15, 67);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(119, 13);
            this.lblItemName.TabIndex = 35;
            this.lblItemName.Text = "Search for - Item Name:";
            // 
            // btnCommit
            // 
            this.btnCommit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCommit.Location = new System.Drawing.Point(779, 515);
            this.btnCommit.Name = "btnCommit";
            this.btnCommit.Size = new System.Drawing.Size(121, 44);
            this.btnCommit.TabIndex = 31;
            this.btnCommit.Text = "Commit Order";
            this.btnCommit.UseVisualStyleBackColor = false;
            this.btnCommit.Click += new System.EventHandler(this.btnCommit_Click);
            // 
            // txtQuantity
            // 
            this.txtQuantity.BackColor = System.Drawing.SystemColors.Info;
            this.txtQuantity.Location = new System.Drawing.Point(13, 515);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.ReadOnly = true;
            this.txtQuantity.Size = new System.Drawing.Size(56, 20);
            this.txtQuantity.TabIndex = 30;
            this.txtQuantity.Text = "Quantity";
            // 
            // txtAmountToAdd
            // 
            this.txtAmountToAdd.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtAmountToAdd.Location = new System.Drawing.Point(74, 515);
            this.txtAmountToAdd.MaxLength = 2;
            this.txtAmountToAdd.Name = "txtAmountToAdd";
            this.txtAmountToAdd.Size = new System.Drawing.Size(38, 20);
            this.txtAmountToAdd.TabIndex = 29;
            this.txtAmountToAdd.Text = "1";
            this.txtAmountToAdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtOrderItems
            // 
            this.txtOrderItems.BackColor = System.Drawing.SystemColors.Info;
            this.txtOrderItems.Location = new System.Drawing.Point(499, 60);
            this.txtOrderItems.Name = "txtOrderItems";
            this.txtOrderItems.ReadOnly = true;
            this.txtOrderItems.Size = new System.Drawing.Size(401, 20);
            this.txtOrderItems.TabIndex = 28;
            this.txtOrderItems.Text = "Order ITEMS";
            this.txtOrderItems.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // orderItemsDataGridView
            // 
            this.orderItemsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderItemsDataGridView.Location = new System.Drawing.Point(499, 92);
            this.orderItemsDataGridView.Name = "orderItemsDataGridView";
            this.orderItemsDataGridView.ReadOnly = true;
            this.orderItemsDataGridView.Size = new System.Drawing.Size(401, 406);
            this.orderItemsDataGridView.TabIndex = 27;
            // 
            // menuItemsDataGridView
            // 
            this.menuItemsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.menuItemsDataGridView.Location = new System.Drawing.Point(22, 132);
            this.menuItemsDataGridView.Name = "menuItemsDataGridView";
            this.menuItemsDataGridView.ReadOnly = true;
            this.menuItemsDataGridView.Size = new System.Drawing.Size(465, 366);
            this.menuItemsDataGridView.TabIndex = 26;
            // 
            // btnAddtoOrder
            // 
            this.btnAddtoOrder.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAddtoOrder.Location = new System.Drawing.Point(117, 515);
            this.btnAddtoOrder.Name = "btnAddtoOrder";
            this.btnAddtoOrder.Size = new System.Drawing.Size(121, 44);
            this.btnAddtoOrder.TabIndex = 3;
            this.btnAddtoOrder.Text = "Add to Order";
            this.btnAddtoOrder.UseVisualStyleBackColor = false;
            this.btnAddtoOrder.Click += new System.EventHandler(this.btnAddtoOrder_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(825, 567);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 51;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // frmPlaceOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 622);
            this.Controls.Add(this.grpAddMenuItem);
            this.Name = "frmPlaceOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Billy\'s Restuarant - [Place Order]";
            this.Load += new System.EventHandler(this.frmPlaceOrder_Load);
            this.grpAddMenuItem.ResumeLayout(false);
            this.grpAddMenuItem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderItemsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuItemsDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpAddMenuItem;
        private System.Windows.Forms.DataGridView orderItemsDataGridView;
        private System.Windows.Forms.DataGridView menuItemsDataGridView;
        private System.Windows.Forms.Button btnAddtoOrder;
        private System.Windows.Forms.TextBox txtOrderItems;
        private System.Windows.Forms.TextBox txtAmountToAdd;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Button btnCommit;
        private System.Windows.Forms.TextBox txtOrderId;
        private System.Windows.Forms.Label lblOrderId;
        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.Label lblItemName;
        private System.Windows.Forms.Button btnSearchMenuItem;
        private System.Windows.Forms.Label lblItemType;
        private System.Windows.Forms.ComboBox cboMenuItemType;
        private System.Windows.Forms.Button btnBack;
    }
}