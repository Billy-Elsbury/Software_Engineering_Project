
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.chtRevenueAnalysis = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cboSelectedYear = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.chtRevenueAnalysis)).BeginInit();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // chtRevenueAnalysis
            // 
            chartArea1.Name = "ChartArea1";
            this.chtRevenueAnalysis.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chtRevenueAnalysis.Legends.Add(legend1);
            this.chtRevenueAnalysis.Location = new System.Drawing.Point(12, 88);
            this.chtRevenueAnalysis.Name = "chtRevenueAnalysis";
            this.chtRevenueAnalysis.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chtRevenueAnalysis.Series.Add(series1);
            this.chtRevenueAnalysis.Size = new System.Drawing.Size(886, 547);
            this.chtRevenueAnalysis.TabIndex = 0;
            this.chtRevenueAnalysis.Text = "chart1";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(12, 38);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(100, 26);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Select Year:";
            // 
            // cboSelectedYear
            // 
            this.cboSelectedYear.FormattingEnabled = true;
            this.cboSelectedYear.Location = new System.Drawing.Point(129, 38);
            this.cboSelectedYear.Name = "cboSelectedYear";
            this.cboSelectedYear.Size = new System.Drawing.Size(121, 24);
            this.cboSelectedYear.TabIndex = 2;
            this.cboSelectedYear.SelectedIndexChanged += new System.EventHandler(this.cboSelectedYear_SelectedIndexChanged);
            // 
            // frmRevenueAnalysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 652);
            this.Controls.Add(this.cboSelectedYear);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.chtRevenueAnalysis);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmRevenueAnalysis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Revenue Analysis";
            this.Load += new System.EventHandler(this.frmRevenueAnalysis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chtRevenueAnalysis)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtRevenueAnalysis;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox cboSelectedYear;
    }
}