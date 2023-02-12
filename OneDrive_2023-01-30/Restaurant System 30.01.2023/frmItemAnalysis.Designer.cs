
namespace Restuarant_System
{
    partial class frmItemAnalysis
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
            this.pictureBoxMenuItemAnalysis = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMenuItemAnalysis)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxMenuItemAnalysis
            // 
            this.pictureBoxMenuItemAnalysis.Image = global::Restuarant_System.Properties.Resources.ItemSalesGraphRQ;
            this.pictureBoxMenuItemAnalysis.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxMenuItemAnalysis.Name = "pictureBoxMenuItemAnalysis";
            this.pictureBoxMenuItemAnalysis.Size = new System.Drawing.Size(776, 426);
            this.pictureBoxMenuItemAnalysis.TabIndex = 0;
            this.pictureBoxMenuItemAnalysis.TabStop = false;
            // 
            // frmItemAnalysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBoxMenuItemAnalysis);
            this.Name = "frmItemAnalysis";
            this.Text = "Menu Item Analysis";
            this.Load += new System.EventHandler(this.frmItemAnalysis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMenuItemAnalysis)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxMenuItemAnalysis;
    }
}