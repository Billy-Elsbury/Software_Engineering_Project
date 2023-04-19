
namespace Restuarant_System
{
    partial class frmRevenueAnalysis
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
            this.pictureBoxRevenueAnalysis = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRevenueAnalysis)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxRevenueAnalysis
            // 
            this.pictureBoxRevenueAnalysis.Image = global::Restuarant_System.Properties.Resources.RevenueAnalysisGraphRQ;
            this.pictureBoxRevenueAnalysis.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxRevenueAnalysis.Name = "pictureBoxRevenueAnalysis";
            this.pictureBoxRevenueAnalysis.Size = new System.Drawing.Size(776, 426);
            this.pictureBoxRevenueAnalysis.TabIndex = 0;
            this.pictureBoxRevenueAnalysis.TabStop = false;
            // 
            // frmRevenueAnalysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBoxRevenueAnalysis);
            this.Name = "frmRevenueAnalysis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Revenue Analysis";
            this.Load += new System.EventHandler(this.frmRevenueAnalysis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRevenueAnalysis)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxRevenueAnalysis;
    }
}