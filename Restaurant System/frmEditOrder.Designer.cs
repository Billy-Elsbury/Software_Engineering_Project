
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
            this.btnEditOrder = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ordersDataGridView = new System.Windows.Forms.DataGridView();
            this.btnBack = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cboItemStatus = new System.Windows.Forms.ComboBox();
            this.OrderID = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtOrderName = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ordersDataGridView)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtOrderName);
            this.groupBox1.Controls.Add(this.btnBack);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.OrderID);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btnEditOrder);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.ordersDataGridView);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(460, 576);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Edit Order";
            // 
            // btnEditOrder
            // 
            this.btnEditOrder.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnEditOrder.Location = new System.Drawing.Point(333, 490);
            this.btnEditOrder.Name = "btnEditOrder";
            this.btnEditOrder.Size = new System.Drawing.Size(121, 44);
            this.btnEditOrder.TabIndex = 34;
            this.btnEditOrder.Text = "Confirm Edits";
            this.btnEditOrder.UseVisualStyleBackColor = false;
            this.btnEditOrder.Click += new System.EventHandler(this.btnEditOrder_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Info;
            this.textBox1.Location = new System.Drawing.Point(33, 31);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(401, 20);
            this.textBox1.TabIndex = 33;
            this.textBox1.Text = "Select Order to Edit";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ordersDataGridView
            // 
            this.ordersDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.ordersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ordersDataGridView.Location = new System.Drawing.Point(33, 57);
            this.ordersDataGridView.Name = "ordersDataGridView";
            this.ordersDataGridView.Size = new System.Drawing.Size(401, 348);
            this.ordersDataGridView.TabIndex = 32;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(379, 547);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 48;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.cboItemStatus);
            this.groupBox2.Location = new System.Drawing.Point(36, 484);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(231, 64);
            this.groupBox2.TabIndex = 47;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Editable";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "Order Status";
            // 
            // cboItemStatus
            // 
            this.cboItemStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboItemStatus.FormattingEnabled = true;
            this.cboItemStatus.Location = new System.Drawing.Point(91, 19);
            this.cboItemStatus.Name = "cboItemStatus";
            this.cboItemStatus.Size = new System.Drawing.Size(76, 21);
            this.cboItemStatus.TabIndex = 26;
            // 
            // OrderID
            // 
            this.OrderID.BackColor = System.Drawing.SystemColors.Info;
            this.OrderID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.OrderID.FormattingEnabled = true;
            this.OrderID.Location = new System.Drawing.Point(143, 446);
            this.OrderID.Name = "OrderID";
            this.OrderID.Size = new System.Drawing.Size(57, 21);
            this.OrderID.TabIndex = 46;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label6.Location = new System.Drawing.Point(36, 449);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 13);
            this.label6.TabIndex = 45;
            this.label6.Text = "Search by Order ID:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label5.Location = new System.Drawing.Point(48, 423);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 50;
            this.label5.Text = "Search by Name:";
            // 
            // txtOrderName
            // 
            this.txtOrderName.Location = new System.Drawing.Point(143, 420);
            this.txtOrderName.MaxLength = 20;
            this.txtOrderName.Name = "txtOrderName";
            this.txtOrderName.Size = new System.Drawing.Size(158, 20);
            this.txtOrderName.TabIndex = 49;
            // 
            // frmEditOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 600);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmEditOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Billy\'s Restuarant - [Edit Order]";
            this.Load += new System.EventHandler(this.frmEditOrder_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ordersDataGridView)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnEditOrder;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView ordersDataGridView;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboItemStatus;
        private System.Windows.Forms.ComboBox OrderID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtOrderName;
    }
}