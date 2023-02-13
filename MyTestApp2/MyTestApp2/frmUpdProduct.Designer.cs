
namespace MyTestApp2
{
    partial class frmUpdProduct
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
            this.grdProducts = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.grpProduct = new System.Windows.Forms.GroupBox();
            this.cboTypes = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtManufacturer = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnUpd = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.mnuAddItem = new System.Windows.Forms.MenuStrip();
            this.mnuBack = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.grdProducts)).BeginInit();
            this.grpProduct.SuspendLayout();
            this.mnuAddItem.SuspendLayout();
            this.SuspendLayout();
            // 
            // grdProducts
            // 
            this.grdProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdProducts.Location = new System.Drawing.Point(56, 100);
            this.grdProducts.Name = "grdProducts";
            this.grdProducts.RowHeadersWidth = 51;
            this.grdProducts.RowTemplate.Height = 29;
            this.grdProducts.Size = new System.Drawing.Size(651, 154);
            this.grdProducts.TabIndex = 0;
            this.grdProducts.Visible = false;
            this.grdProducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdProducts_CellClick);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(561, 30);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(146, 36);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter product name (or part of)";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(264, 39);
            this.txtSearch.MaxLength = 20;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(273, 27);
            this.txtSearch.TabIndex = 3;
            // 
            // grpProduct
            // 
            this.grpProduct.Controls.Add(this.cboTypes);
            this.grpProduct.Controls.Add(this.label7);
            this.grpProduct.Controls.Add(this.txtPrice);
            this.grpProduct.Controls.Add(this.label6);
            this.grpProduct.Controls.Add(this.txtQty);
            this.grpProduct.Controls.Add(this.label5);
            this.grpProduct.Controls.Add(this.txtManufacturer);
            this.grpProduct.Controls.Add(this.label4);
            this.grpProduct.Controls.Add(this.txtDescription);
            this.grpProduct.Controls.Add(this.label3);
            this.grpProduct.Controls.Add(this.btnUpd);
            this.grpProduct.Controls.Add(this.txtName);
            this.grpProduct.Controls.Add(this.label2);
            this.grpProduct.Location = new System.Drawing.Point(56, 272);
            this.grpProduct.Name = "grpProduct";
            this.grpProduct.Size = new System.Drawing.Size(651, 344);
            this.grpProduct.TabIndex = 4;
            this.grpProduct.TabStop = false;
            this.grpProduct.Text = "Update Product Details";
            this.grpProduct.Visible = false;
            // 
            // cboTypes
            // 
            this.cboTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTypes.FormattingEnabled = true;
            this.cboTypes.ItemHeight = 20;
            this.cboTypes.Location = new System.Drawing.Point(128, 246);
            this.cboTypes.Name = "cboTypes";
            this.cboTypes.Size = new System.Drawing.Size(207, 28);
            this.cboTypes.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(60, 246);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "Type";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(128, 205);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(81, 27);
            this.txtPrice.TabIndex = 4;
            this.txtPrice.Text = "0.00";
            this.txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(59, 207);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Price";
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(128, 162);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(53, 27);
            this.txtQty.TabIndex = 3;
            this.txtQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(59, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Quantity";
            // 
            // txtManufacturer
            // 
            this.txtManufacturer.Location = new System.Drawing.Point(128, 119);
            this.txtManufacturer.Name = "txtManufacturer";
            this.txtManufacturer.Size = new System.Drawing.Size(241, 27);
            this.txtManufacturer.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Manufacturer";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(128, 77);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(241, 27);
            this.txtDescription.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Description";
            // 
            // btnUpd
            // 
            this.btnUpd.Location = new System.Drawing.Point(128, 296);
            this.btnUpd.Name = "btnUpd";
            this.btnUpd.Size = new System.Drawing.Size(207, 31);
            this.btnUpd.TabIndex = 6;
            this.btnUpd.Text = "Update Product";
            this.btnUpd.UseVisualStyleBackColor = true;
            this.btnUpd.Click += new System.EventHandler(this.btnUpd_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(128, 36);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(241, 27);
            this.txtName.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Name";
            // 
            // mnuAddItem
            // 
            this.mnuAddItem.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuAddItem.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuBack});
            this.mnuAddItem.Location = new System.Drawing.Point(0, 0);
            this.mnuAddItem.Name = "mnuAddItem";
            this.mnuAddItem.Size = new System.Drawing.Size(800, 28);
            this.mnuAddItem.TabIndex = 5;
            this.mnuAddItem.Text = "menuStrip1";
            // 
            // mnuBack
            // 
            this.mnuBack.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mnuBack.Name = "mnuBack";
            this.mnuBack.Size = new System.Drawing.Size(54, 24);
            this.mnuBack.Text = "Back";
            this.mnuBack.Click += new System.EventHandler(this.mnuBack_Click);
            // 
            // frmUpdProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 645);
            this.Controls.Add(this.mnuAddItem);
            this.Controls.Add(this.grpProduct);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.grdProducts);
            this.Name = "frmUpdProduct";
            this.Text = "frmUpdProduct";
            ((System.ComponentModel.ISupportInitialize)(this.grdProducts)).EndInit();
            this.grpProduct.ResumeLayout(false);
            this.grpProduct.PerformLayout();
            this.mnuAddItem.ResumeLayout(false);
            this.mnuAddItem.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdProducts;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.GroupBox grpProduct;
        private System.Windows.Forms.ComboBox cboTypes;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtManufacturer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnUpd;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip mnuAddItem;
        private System.Windows.Forms.ToolStripMenuItem mnuBack;
    }
}