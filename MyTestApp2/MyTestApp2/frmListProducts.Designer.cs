
namespace MyTestApp2
{
    partial class frmListProducts
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
            this.mnuListItems = new System.Windows.Forms.MenuStrip();
            this.mnuBack = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.grdProducts)).BeginInit();
            this.mnuListItems.SuspendLayout();
            this.SuspendLayout();
            // 
            // grdProducts
            // 
            this.grdProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdProducts.Location = new System.Drawing.Point(49, 121);
            this.grdProducts.Name = "grdProducts";
            this.grdProducts.RowHeadersWidth = 51;
            this.grdProducts.RowTemplate.Height = 29;
            this.grdProducts.Size = new System.Drawing.Size(696, 157);
            this.grdProducts.TabIndex = 0;
            // 
            // mnuListItems
            // 
            this.mnuListItems.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuListItems.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuBack});
            this.mnuListItems.Location = new System.Drawing.Point(0, 0);
            this.mnuListItems.Name = "mnuListItems";
            this.mnuListItems.Size = new System.Drawing.Size(800, 28);
            this.mnuListItems.TabIndex = 1;
            this.mnuListItems.Text = "menuStrip1";
            // 
            // mnuBack
            // 
            this.mnuBack.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mnuBack.Name = "mnuBack";
            this.mnuBack.Size = new System.Drawing.Size(54, 24);
            this.mnuBack.Text = "Back";
            this.mnuBack.Click += new System.EventHandler(this.mnuBack_Click);
            // 
            // frmListItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grdProducts);
            this.Controls.Add(this.mnuListItems);
            this.MainMenuStrip = this.mnuListItems;
            this.Name = "frmListItems";
            this.Text = "List Data in a Table";
            this.Load += new System.EventHandler(this.frmListData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdProducts)).EndInit();
            this.mnuListItems.ResumeLayout(false);
            this.mnuListItems.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdProducts;
        private System.Windows.Forms.MenuStrip mnuListItems;
        private System.Windows.Forms.ToolStripMenuItem mnuBack;
    }
}