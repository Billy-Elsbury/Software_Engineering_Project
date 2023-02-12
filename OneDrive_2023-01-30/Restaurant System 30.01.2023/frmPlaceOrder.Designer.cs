
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
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txtAmounttoAdd = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.orderItemsDataGridView = new System.Windows.Forms.DataGridView();
            this.menuItemsDataGridView = new System.Windows.Forms.DataGridView();
            this.btnAddtoOrder = new System.Windows.Forms.Button();
            this.btnCommit = new System.Windows.Forms.Button();
            this.grpAddMenuItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderItemsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuItemsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // grpAddMenuItem
            // 
            this.grpAddMenuItem.Controls.Add(this.btnCommit);
            this.grpAddMenuItem.Controls.Add(this.textBox2);
            this.grpAddMenuItem.Controls.Add(this.txtAmounttoAdd);
            this.grpAddMenuItem.Controls.Add(this.textBox1);
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
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Info;
            this.textBox2.Location = new System.Drawing.Point(634, 20);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(105, 20);
            this.textBox2.TabIndex = 30;
            this.textBox2.Text = "Please Enter Count:";
            // 
            // txtAmounttoAdd
            // 
            this.txtAmounttoAdd.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtAmounttoAdd.Location = new System.Drawing.Point(633, 46);
            this.txtAmounttoAdd.MaxLength = 2;
            this.txtAmounttoAdd.Name = "txtAmounttoAdd";
            this.txtAmounttoAdd.Size = new System.Drawing.Size(54, 20);
            this.txtAmounttoAdd.TabIndex = 29;
            this.txtAmounttoAdd.Text = "1";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Info;
            this.textBox1.Location = new System.Drawing.Point(506, 246);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(401, 20);
            this.textBox1.TabIndex = 28;
            this.textBox1.Text = "New Order";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // orderItemsDataGridView
            // 
            this.orderItemsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderItemsDataGridView.Location = new System.Drawing.Point(506, 272);
            this.orderItemsDataGridView.Name = "orderItemsDataGridView";
            this.orderItemsDataGridView.ReadOnly = true;
            this.orderItemsDataGridView.Size = new System.Drawing.Size(401, 251);
            this.orderItemsDataGridView.TabIndex = 27;
            // 
            // menuItemsDataGridView
            // 
            this.menuItemsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.menuItemsDataGridView.Location = new System.Drawing.Point(6, 19);
            this.menuItemsDataGridView.Name = "menuItemsDataGridView";
            this.menuItemsDataGridView.ReadOnly = true;
            this.menuItemsDataGridView.Size = new System.Drawing.Size(487, 246);
            this.menuItemsDataGridView.TabIndex = 26;
            // 
            // btnAddtoOrder
            // 
            this.btnAddtoOrder.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAddtoOrder.Location = new System.Drawing.Point(506, 19);
            this.btnAddtoOrder.Name = "btnAddtoOrder";
            this.btnAddtoOrder.Size = new System.Drawing.Size(121, 136);
            this.btnAddtoOrder.TabIndex = 3;
            this.btnAddtoOrder.Text = "Add to Order";
            this.btnAddtoOrder.UseVisualStyleBackColor = false;
            this.btnAddtoOrder.Click += new System.EventHandler(this.btnAddtoOrder_Click);
            // 
            // btnCommit
            // 
            this.btnCommit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCommit.Location = new System.Drawing.Point(786, 529);
            this.btnCommit.Name = "btnCommit";
            this.btnCommit.Size = new System.Drawing.Size(121, 44);
            this.btnCommit.TabIndex = 31;
            this.btnCommit.Text = "Commit Order";
            this.btnCommit.UseVisualStyleBackColor = false;
            this.btnCommit.Click += new System.EventHandler(this.btnCommit_Click);
            // 
            // frmPlaceOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 622);
            this.Controls.Add(this.grpAddMenuItem);
            this.Name = "frmPlaceOrder";
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtAmounttoAdd;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnCommit;
    }
}