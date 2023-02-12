
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
            this.label5 = new System.Windows.Forms.Label();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtItemDescription = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtItemType = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtItemAvailability = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.menuItemsDataGridView)).BeginInit();
            this.grpQueryMenuItem.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuItemsDataGridView
            // 
            this.menuItemsDataGridView.BackgroundColor = System.Drawing.SystemColors.Info;
            this.menuItemsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.menuItemsDataGridView.Location = new System.Drawing.Point(113, 38);
            this.menuItemsDataGridView.Name = "menuItemsDataGridView";
            this.menuItemsDataGridView.ReadOnly = true;
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
            // cboItemID
            // 
            this.cboItemID.BackColor = System.Drawing.SystemColors.Info;
            this.cboItemID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboItemID.FormattingEnabled = true;
            this.cboItemID.Location = new System.Drawing.Point(113, 293);
            this.cboItemID.Name = "cboItemID";
            this.cboItemID.Size = new System.Drawing.Size(57, 21);
            this.cboItemID.TabIndex = 30;
            this.cboItemID.SelectionChangeCommitted += new System.EventHandler(this.cboItemID_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label6.Location = new System.Drawing.Point(24, 296);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "Select Item ID:";
            // 
            // grpQueryMenuItem
            // 
            this.grpQueryMenuItem.Controls.Add(this.txtItemAvailability);
            this.grpQueryMenuItem.Controls.Add(this.label7);
            this.grpQueryMenuItem.Controls.Add(this.txtItemType);
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
            this.grpQueryMenuItem.Location = new System.Drawing.Point(12, 12);
            this.grpQueryMenuItem.Name = "grpQueryMenuItem";
            this.grpQueryMenuItem.Size = new System.Drawing.Size(579, 557);
            this.grpQueryMenuItem.TabIndex = 22;
            this.grpQueryMenuItem.TabStop = false;
            this.grpQueryMenuItem.Text = "Query Menu Item";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Info;
            this.label5.Location = new System.Drawing.Point(40, 376);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 34;
            this.label5.Text = "Item Name:";
            // 
            // txtItemName
            // 
            this.txtItemName.Location = new System.Drawing.Point(113, 373);
            this.txtItemName.MaxLength = 20;
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.ReadOnly = true;
            this.txtItemName.Size = new System.Drawing.Size(158, 20);
            this.txtItemName.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(44, 416);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "Item Type:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Info;
            this.label2.Location = new System.Drawing.Point(15, 458);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 36;
            this.label2.Text = "Item Description:";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(113, 492);
            this.txtPrice.MaxLength = 7;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.ReadOnly = true;
            this.txtPrice.Size = new System.Drawing.Size(76, 20);
            this.txtPrice.TabIndex = 38;
            this.txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtItemDescription
            // 
            this.txtItemDescription.Location = new System.Drawing.Point(113, 455);
            this.txtItemDescription.MaxLength = 30;
            this.txtItemDescription.Name = "txtItemDescription";
            this.txtItemDescription.ReadOnly = true;
            this.txtItemDescription.Size = new System.Drawing.Size(158, 20);
            this.txtItemDescription.TabIndex = 35;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Info;
            this.label4.Location = new System.Drawing.Point(68, 495);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 37;
            this.label4.Text = "Price:";
            // 
            // txtItemType
            // 
            this.txtItemType.Location = new System.Drawing.Point(113, 416);
            this.txtItemType.MaxLength = 20;
            this.txtItemType.Name = "txtItemType";
            this.txtItemType.ReadOnly = true;
            this.txtItemType.Size = new System.Drawing.Size(158, 20);
            this.txtItemType.TabIndex = 39;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.Info;
            this.label7.Location = new System.Drawing.Point(20, 337);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 13);
            this.label7.TabIndex = 41;
            this.label7.Text = "Item Availability:";
            // 
            // txtItemAvailability
            // 
            this.txtItemAvailability.Location = new System.Drawing.Point(113, 334);
            this.txtItemAvailability.MaxLength = 20;
            this.txtItemAvailability.Name = "txtItemAvailability";
            this.txtItemAvailability.ReadOnly = true;
            this.txtItemAvailability.Size = new System.Drawing.Size(158, 20);
            this.txtItemAvailability.TabIndex = 42;
            // 
            // frmQueryMenuItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 581);
            this.Controls.Add(this.grpQueryMenuItem);
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
        private System.Windows.Forms.TextBox txtItemType;
        private System.Windows.Forms.TextBox txtItemAvailability;
        private System.Windows.Forms.Label label7;
    }
}