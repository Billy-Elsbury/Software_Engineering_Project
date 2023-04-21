
namespace Restuarant_System
{
    partial class frmEditOrder
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtOrderTotalPrice = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtAmountToAdd = new System.Windows.Forms.TextBox();
            this.btnAddtoOrder = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.cboMenuItemType = new System.Windows.Forms.ComboBox();
            this.lblItemType = new System.Windows.Forms.Label();
            this.btnSearchMenuItem = new System.Windows.Forms.Button();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.lblItemName = new System.Windows.Forms.Label();
            this.menuItemsDataGridView = new System.Windows.Forms.DataGridView();
            this.btnSearchOrder = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtOrderId = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnRemoveItemFromOrder = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.orderItemsDataGridView = new System.Windows.Forms.DataGridView();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuItemsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderItemsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.txtOrderTotalPrice);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.txtQuantity);
            this.groupBox1.Controls.Add(this.txtAmountToAdd);
            this.groupBox1.Controls.Add(this.btnAddtoOrder);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.cboMenuItemType);
            this.groupBox1.Controls.Add(this.lblItemType);
            this.groupBox1.Controls.Add(this.btnSearchMenuItem);
            this.groupBox1.Controls.Add(this.txtItemName);
            this.groupBox1.Controls.Add(this.lblItemName);
            this.groupBox1.Controls.Add(this.menuItemsDataGridView);
            this.groupBox1.Controls.Add(this.btnSearchOrder);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtOrderId);
            this.groupBox1.Controls.Add(this.btnBack);
            this.groupBox1.Controls.Add(this.btnRemoveItemFromOrder);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.orderItemsDataGridView);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(999, 636);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Edit Order";
            // 
            // txtOrderTotalPrice
            // 
            this.txtOrderTotalPrice.BackColor = System.Drawing.SystemColors.Info;
            this.txtOrderTotalPrice.Location = new System.Drawing.Point(132, 525);
            this.txtOrderTotalPrice.MaxLength = 20;
            this.txtOrderTotalPrice.Name = "txtOrderTotalPrice";
            this.txtOrderTotalPrice.ReadOnly = true;
            this.txtOrderTotalPrice.Size = new System.Drawing.Size(78, 20);
            this.txtOrderTotalPrice.TabIndex = 66;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Info;
            this.textBox2.Location = new System.Drawing.Point(507, 91);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(463, 20);
            this.textBox2.TabIndex = 65;
            this.textBox2.Text = "Menu Items";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtQuantity
            // 
            this.txtQuantity.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtQuantity.Location = new System.Drawing.Point(507, 541);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.ReadOnly = true;
            this.txtQuantity.Size = new System.Drawing.Size(56, 20);
            this.txtQuantity.TabIndex = 64;
            this.txtQuantity.Text = "Quantity:";
            // 
            // txtAmountToAdd
            // 
            this.txtAmountToAdd.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtAmountToAdd.Location = new System.Drawing.Point(569, 541);
            this.txtAmountToAdd.MaxLength = 2;
            this.txtAmountToAdd.Name = "txtAmountToAdd";
            this.txtAmountToAdd.Size = new System.Drawing.Size(38, 20);
            this.txtAmountToAdd.TabIndex = 63;
            this.txtAmountToAdd.Text = "1";
            this.txtAmountToAdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnAddtoOrder
            // 
            this.btnAddtoOrder.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAddtoOrder.Location = new System.Drawing.Point(849, 525);
            this.btnAddtoOrder.Name = "btnAddtoOrder";
            this.btnAddtoOrder.Size = new System.Drawing.Size(121, 44);
            this.btnAddtoOrder.TabIndex = 62;
            this.btnAddtoOrder.Text = "Add to Order";
            this.btnAddtoOrder.UseVisualStyleBackColor = false;
            this.btnAddtoOrder.Click += new System.EventHandler(this.btnAddtoOrder_Click);
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.Info;
            this.textBox3.Location = new System.Drawing.Point(36, 19);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(176, 20);
            this.textBox3.TabIndex = 61;
            this.textBox3.Text = "Order";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cboMenuItemType
            // 
            this.cboMenuItemType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMenuItemType.FormattingEnabled = true;
            this.cboMenuItemType.Location = new System.Drawing.Point(627, 50);
            this.cboMenuItemType.Name = "cboMenuItemType";
            this.cboMenuItemType.Size = new System.Drawing.Size(52, 21);
            this.cboMenuItemType.TabIndex = 60;
            // 
            // lblItemType
            // 
            this.lblItemType.AutoSize = true;
            this.lblItemType.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblItemType.Location = new System.Drawing.Point(508, 53);
            this.lblItemType.Name = "lblItemType";
            this.lblItemType.Size = new System.Drawing.Size(112, 13);
            this.lblItemType.TabIndex = 59;
            this.lblItemType.Text = "Search for - Item Type";
            // 
            // btnSearchMenuItem
            // 
            this.btnSearchMenuItem.Location = new System.Drawing.Point(902, 19);
            this.btnSearchMenuItem.Name = "btnSearchMenuItem";
            this.btnSearchMenuItem.Size = new System.Drawing.Size(68, 57);
            this.btnSearchMenuItem.TabIndex = 58;
            this.btnSearchMenuItem.Text = "Search";
            this.btnSearchMenuItem.UseVisualStyleBackColor = true;
            this.btnSearchMenuItem.Click += new System.EventHandler(this.btnSearchMenuItem_Click);
            // 
            // txtItemName
            // 
            this.txtItemName.Location = new System.Drawing.Point(627, 19);
            this.txtItemName.MaxLength = 20;
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(131, 20);
            this.txtItemName.TabIndex = 54;
            // 
            // lblItemName
            // 
            this.lblItemName.AutoSize = true;
            this.lblItemName.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblItemName.Location = new System.Drawing.Point(501, 23);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(119, 13);
            this.lblItemName.TabIndex = 55;
            this.lblItemName.Text = "Search for - Item Name:";
            // 
            // menuItemsDataGridView
            // 
            this.menuItemsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.menuItemsDataGridView.Location = new System.Drawing.Point(505, 117);
            this.menuItemsDataGridView.Name = "menuItemsDataGridView";
            this.menuItemsDataGridView.ReadOnly = true;
            this.menuItemsDataGridView.Size = new System.Drawing.Size(465, 402);
            this.menuItemsDataGridView.TabIndex = 53;
            // 
            // btnSearchOrder
            // 
            this.btnSearchOrder.Location = new System.Drawing.Point(368, 19);
            this.btnSearchOrder.Name = "btnSearchOrder";
            this.btnSearchOrder.Size = new System.Drawing.Size(68, 57);
            this.btnSearchOrder.TabIndex = 51;
            this.btnSearchOrder.Text = "Search";
            this.btnSearchOrder.UseVisualStyleBackColor = true;
            this.btnSearchOrder.Click += new System.EventHandler(this.btnSearchOrder_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label5.Location = new System.Drawing.Point(33, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 50;
            this.label5.Text = "Order ID:";
            // 
            // txtOrderId
            // 
            this.txtOrderId.Location = new System.Drawing.Point(89, 56);
            this.txtOrderId.MaxLength = 20;
            this.txtOrderId.Name = "txtOrderId";
            this.txtOrderId.Size = new System.Drawing.Size(132, 20);
            this.txtOrderId.TabIndex = 49;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(895, 607);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 48;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnRemoveItemFromOrder
            // 
            this.btnRemoveItemFromOrder.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnRemoveItemFromOrder.Location = new System.Drawing.Point(315, 525);
            this.btnRemoveItemFromOrder.Name = "btnRemoveItemFromOrder";
            this.btnRemoveItemFromOrder.Size = new System.Drawing.Size(121, 44);
            this.btnRemoveItemFromOrder.TabIndex = 34;
            this.btnRemoveItemFromOrder.Text = "Remove From Order";
            this.btnRemoveItemFromOrder.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Info;
            this.textBox1.Location = new System.Drawing.Point(36, 91);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(401, 20);
            this.textBox1.TabIndex = 33;
            this.textBox1.Text = "Order Items";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // orderItemsDataGridView
            // 
            this.orderItemsDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.orderItemsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderItemsDataGridView.Location = new System.Drawing.Point(35, 117);
            this.orderItemsDataGridView.Name = "orderItemsDataGridView";
            this.orderItemsDataGridView.ReadOnly = true;
            this.orderItemsDataGridView.Size = new System.Drawing.Size(401, 402);
            this.orderItemsDataGridView.TabIndex = 32;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.Info;
            this.textBox4.Location = new System.Drawing.Point(35, 525);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(91, 20);
            this.textBox4.TabIndex = 67;
            this.textBox4.Text = "Order Total Price:";
            // 
            // frmEditOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 660);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmEditOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Billy\'s Restuarant - [Edit Order]";
            this.Load += new System.EventHandler(this.frmEditOrder_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuItemsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderItemsDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnRemoveItemFromOrder;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView orderItemsDataGridView;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtOrderId;
        private System.Windows.Forms.Button btnSearchOrder;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.ComboBox cboMenuItemType;
        private System.Windows.Forms.Label lblItemType;
        private System.Windows.Forms.Button btnSearchMenuItem;
        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.Label lblItemName;
        private System.Windows.Forms.DataGridView menuItemsDataGridView;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtAmountToAdd;
        private System.Windows.Forms.Button btnAddtoOrder;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox txtOrderTotalPrice;
        private System.Windows.Forms.TextBox textBox4;
    }
}