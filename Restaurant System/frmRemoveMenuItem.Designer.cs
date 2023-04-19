
namespace Restuarant_System
{
    partial class frmRemoveMenuItem
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
            this.menuItemsDataGridView = new System.Windows.Forms.DataGridView();
            this.btnRemoveMenuItem = new System.Windows.Forms.Button();
            this.grpEditMenuItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuItemsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // grpEditMenuItem
            // 
            this.grpEditMenuItem.Controls.Add(this.btnBack);
            this.grpEditMenuItem.Controls.Add(this.menuItemsDataGridView);
            this.grpEditMenuItem.Controls.Add(this.btnRemoveMenuItem);
            this.grpEditMenuItem.Location = new System.Drawing.Point(12, 12);
            this.grpEditMenuItem.Name = "grpEditMenuItem";
            this.grpEditMenuItem.Size = new System.Drawing.Size(489, 432);
            this.grpEditMenuItem.TabIndex = 22;
            this.grpEditMenuItem.TabStop = false;
            this.grpEditMenuItem.Text = "Remove Menu Item Details";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(399, 397);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 44;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // menuItemsDataGridView
            // 
            this.menuItemsDataGridView.BackgroundColor = System.Drawing.SystemColors.Highlight;
            this.menuItemsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.menuItemsDataGridView.Location = new System.Drawing.Point(14, 33);
            this.menuItemsDataGridView.Name = "menuItemsDataGridView";
            this.menuItemsDataGridView.ReadOnly = true;
            this.menuItemsDataGridView.Size = new System.Drawing.Size(460, 318);
            this.menuItemsDataGridView.TabIndex = 30;
            // 
            // btnRemoveMenuItem
            // 
            this.btnRemoveMenuItem.Location = new System.Drawing.Point(6, 391);
            this.btnRemoveMenuItem.Name = "btnRemoveMenuItem";
            this.btnRemoveMenuItem.Size = new System.Drawing.Size(153, 35);
            this.btnRemoveMenuItem.TabIndex = 3;
            this.btnRemoveMenuItem.Text = "Remove Menu Item";
            this.btnRemoveMenuItem.UseVisualStyleBackColor = true;
            this.btnRemoveMenuItem.Click += new System.EventHandler(this.btnRemoveMenuItem_Click);
            // 
            // frmRemoveMenuItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 450);
            this.Controls.Add(this.grpEditMenuItem);
            this.Name = "frmRemoveMenuItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Billy\'s Restuarant - [Remove Menu Item]";
            this.Load += new System.EventHandler(this.frmRemoveMenuItem_Load);
            this.grpEditMenuItem.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.menuItemsDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpEditMenuItem;
        private System.Windows.Forms.Button btnRemoveMenuItem;
        private System.Windows.Forms.DataGridView menuItemsDataGridView;
        private System.Windows.Forms.Button btnBack;
    }
}