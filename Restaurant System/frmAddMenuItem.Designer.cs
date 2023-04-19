
namespace Restuarant_System
{
    partial class frmAddMenuItem
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
            this.cboMenuItemType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddMenuItem = new System.Windows.Forms.Button();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.grpAddMenuItem = new System.Windows.Forms.GroupBox();
            this.txtItemId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.menuItemsDataGridView = new System.Windows.Forms.DataGridView();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtItemDescription = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.grpAddMenuItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuItemsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // cboMenuItemType
            // 
            this.cboMenuItemType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMenuItemType.FormattingEnabled = true;
            this.cboMenuItemType.Location = new System.Drawing.Point(148, 71);
            this.cboMenuItemType.Name = "cboMenuItemType";
            this.cboMenuItemType.Size = new System.Drawing.Size(158, 21);
            this.cboMenuItemType.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(79, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Item Type:";
            // 
            // btnAddMenuItem
            // 
            this.btnAddMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAddMenuItem.Location = new System.Drawing.Point(6, 238);
            this.btnAddMenuItem.Name = "btnAddMenuItem";
            this.btnAddMenuItem.Size = new System.Drawing.Size(153, 35);
            this.btnAddMenuItem.TabIndex = 3;
            this.btnAddMenuItem.Text = "Add Menu Item";
            this.btnAddMenuItem.UseVisualStyleBackColor = false;
            this.btnAddMenuItem.Click += new System.EventHandler(this.btnAddMenuItem_Click);
            // 
            // txtItemName
            // 
            this.txtItemName.Location = new System.Drawing.Point(148, 115);
            this.txtItemName.MaxLength = 20;
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(158, 20);
            this.txtItemName.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.Location = new System.Drawing.Point(75, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Item Name:";
            // 
            // grpAddMenuItem
            // 
            this.grpAddMenuItem.Controls.Add(this.txtItemId);
            this.grpAddMenuItem.Controls.Add(this.label3);
            this.grpAddMenuItem.Controls.Add(this.menuItemsDataGridView);
            this.grpAddMenuItem.Controls.Add(this.txtPrice);
            this.grpAddMenuItem.Controls.Add(this.label4);
            this.grpAddMenuItem.Controls.Add(this.txtItemDescription);
            this.grpAddMenuItem.Controls.Add(this.label2);
            this.grpAddMenuItem.Controls.Add(this.cboMenuItemType);
            this.grpAddMenuItem.Controls.Add(this.label1);
            this.grpAddMenuItem.Controls.Add(this.btnAddMenuItem);
            this.grpAddMenuItem.Controls.Add(this.txtItemName);
            this.grpAddMenuItem.Controls.Add(this.label5);
            this.grpAddMenuItem.Location = new System.Drawing.Point(12, 12);
            this.grpAddMenuItem.Name = "grpAddMenuItem";
            this.grpAddMenuItem.Size = new System.Drawing.Size(534, 609);
            this.grpAddMenuItem.TabIndex = 20;
            this.grpAddMenuItem.TabStop = false;
            this.grpAddMenuItem.Text = "Enter New Menu Item Details";
            // 
            // txtItemId
            // 
            this.txtItemId.Location = new System.Drawing.Point(148, 32);
            this.txtItemId.MaxLength = 20;
            this.txtItemId.Name = "txtItemId";
            this.txtItemId.ReadOnly = true;
            this.txtItemId.Size = new System.Drawing.Size(52, 20);
            this.txtItemId.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Location = new System.Drawing.Point(92, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Item ID:";
            // 
            // menuItemsDataGridView
            // 
            this.menuItemsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.menuItemsDataGridView.Location = new System.Drawing.Point(6, 299);
            this.menuItemsDataGridView.Name = "menuItemsDataGridView";
            this.menuItemsDataGridView.ReadOnly = true;
            this.menuItemsDataGridView.Size = new System.Drawing.Size(521, 304);
            this.menuItemsDataGridView.TabIndex = 26;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(148, 189);
            this.txtPrice.MaxLength = 7;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(76, 20);
            this.txtPrice.TabIndex = 25;
            this.txtPrice.Text = "0.00";
            this.txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Location = new System.Drawing.Point(103, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Price:";
            // 
            // txtItemDescription
            // 
            this.txtItemDescription.Location = new System.Drawing.Point(148, 152);
            this.txtItemDescription.MaxLength = 30;
            this.txtItemDescription.Name = "txtItemDescription";
            this.txtItemDescription.Size = new System.Drawing.Size(291, 20);
            this.txtItemDescription.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(50, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Item Description:";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(471, 634);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 45;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // frmAddMenuItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 669);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.grpAddMenuItem);
            this.Name = "frmAddMenuItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Billy\'s Restuarant - [Add Menu Item]";
            this.Load += new System.EventHandler(this.frmAddMenuItem_Load);
            this.grpAddMenuItem.ResumeLayout(false);
            this.grpAddMenuItem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuItemsDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cboMenuItemType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddMenuItem;
        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox grpAddMenuItem;
        private System.Windows.Forms.TextBox txtItemDescription;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView menuItemsDataGridView;
        private System.Windows.Forms.TextBox txtItemId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBack;
    }
}

