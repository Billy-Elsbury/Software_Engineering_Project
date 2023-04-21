
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.cboSelectedYear = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.chtItemAnalysis = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chtItemAnalysis)).BeginInit();
            this.SuspendLayout();
            // 
            // cboSelectedYear
            // 
            this.cboSelectedYear.FormattingEnabled = true;
            this.cboSelectedYear.Location = new System.Drawing.Point(142, 26);
            this.cboSelectedYear.Name = "cboSelectedYear";
            this.cboSelectedYear.Size = new System.Drawing.Size(121, 24);
            this.cboSelectedYear.TabIndex = 5;
            this.cboSelectedYear.SelectedIndexChanged += new System.EventHandler(this.cboSelectedYear_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(25, 26);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(100, 26);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "Select Year:";
            // 
            // chtItemAnalysis
            // 
            chartArea3.Name = "ChartArea1";
            this.chtItemAnalysis.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chtItemAnalysis.Legends.Add(legend3);
            this.chtItemAnalysis.Location = new System.Drawing.Point(25, 76);
            this.chtItemAnalysis.Name = "chtItemAnalysis";
            this.chtItemAnalysis.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chtItemAnalysis.Series.Add(series3);
            this.chtItemAnalysis.Size = new System.Drawing.Size(886, 547);
            this.chtItemAnalysis.TabIndex = 3;
            this.chtItemAnalysis.Text = "chart1";
            // 
            // frmItemAnalysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 642);
            this.Controls.Add(this.cboSelectedYear);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.chtItemAnalysis);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmItemAnalysis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Item Analysis";
            this.Load += new System.EventHandler(this.frmItemAnalysis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chtItemAnalysis)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboSelectedYear;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtItemAnalysis;
    }
}