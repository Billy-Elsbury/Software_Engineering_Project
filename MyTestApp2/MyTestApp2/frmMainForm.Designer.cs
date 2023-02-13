
namespace MyTestApp2
{
    partial class frmMainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainForm));
            this.picMain = new System.Windows.Forms.PictureBox();
            this.mnuStrip = new System.Windows.Forms.MenuStrip();
            this.mnuProducts = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAddProd = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUpdProd = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuListProd = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.picMain)).BeginInit();
            this.mnuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // picMain
            // 
            this.picMain.Image = ((System.Drawing.Image)(resources.GetObject("picMain.Image")));
            this.picMain.Location = new System.Drawing.Point(88, 61);
            this.picMain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picMain.Name = "picMain";
            this.picMain.Size = new System.Drawing.Size(531, 260);
            this.picMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMain.TabIndex = 0;
            this.picMain.TabStop = false;
            // 
            // mnuStrip
            // 
            this.mnuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuProducts,
            this.mnuExit});
            this.mnuStrip.Location = new System.Drawing.Point(0, 0);
            this.mnuStrip.Name = "mnuStrip";
            this.mnuStrip.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.mnuStrip.Size = new System.Drawing.Size(700, 24);
            this.mnuStrip.TabIndex = 1;
            this.mnuStrip.Text = "menuStrip1";
            // 
            // mnuProducts
            // 
            this.mnuProducts.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAddProd,
            this.mnuUpdProd,
            this.mnuListProd});
            this.mnuProducts.Name = "mnuProducts";
            this.mnuProducts.Size = new System.Drawing.Size(66, 20);
            this.mnuProducts.Text = "Products";
            // 
            // mnuAddProd
            // 
            this.mnuAddProd.Name = "mnuAddProd";
            this.mnuAddProd.Size = new System.Drawing.Size(157, 22);
            this.mnuAddProd.Text = "Add Product";
            this.mnuAddProd.Click += new System.EventHandler(this.mnuAddProd_Click);
            // 
            // mnuUpdProd
            // 
            this.mnuUpdProd.Name = "mnuUpdProd";
            this.mnuUpdProd.Size = new System.Drawing.Size(157, 22);
            this.mnuUpdProd.Text = "Update Product";
            this.mnuUpdProd.Click += new System.EventHandler(this.mnuUpdProd_Click);
            // 
            // mnuListProd
            // 
            this.mnuListProd.Name = "mnuListProd";
            this.mnuListProd.Size = new System.Drawing.Size(157, 22);
            this.mnuListProd.Text = "List Products";
            this.mnuListProd.Click += new System.EventHandler(this.mnuListProd_Click);
            // 
            // mnuExit
            // 
            this.mnuExit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(38, 20);
            this.mnuExit.Text = "Exit";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // frmMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 338);
            this.Controls.Add(this.picMain);
            this.Controls.Add(this.mnuStrip);
            this.MainMenuStrip = this.mnuStrip;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmMainForm";
            this.Text = "Database Connections - Main Form";
            ((System.ComponentModel.ISupportInitialize)(this.picMain)).EndInit();
            this.mnuStrip.ResumeLayout(false);
            this.mnuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picMain;
        private System.Windows.Forms.MenuStrip mnuStrip;
        private System.Windows.Forms.ToolStripMenuItem mnuProducts;
        private System.Windows.Forms.ToolStripMenuItem mnuAddProd;
        private System.Windows.Forms.ToolStripMenuItem mnuUpdProd;
        private System.Windows.Forms.ToolStripMenuItem mnuListProd;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
    }
}