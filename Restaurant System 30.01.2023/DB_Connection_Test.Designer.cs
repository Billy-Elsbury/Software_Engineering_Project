
namespace Restuarant_System
{
    partial class DB_Connection_Test
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
            this.openConnect = new System.Windows.Forms.Button();
            this.closeConnect = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // openConnect
            // 
            this.openConnect.Location = new System.Drawing.Point(293, 94);
            this.openConnect.Name = "openConnect";
            this.openConnect.Size = new System.Drawing.Size(205, 61);
            this.openConnect.TabIndex = 0;
            this.openConnect.Text = "Open Connection";
            this.openConnect.UseVisualStyleBackColor = true;
            this.openConnect.Click += new System.EventHandler(this.openConnect_Click);
            // 
            // closeConnect
            // 
            this.closeConnect.Location = new System.Drawing.Point(293, 270);
            this.closeConnect.Name = "closeConnect";
            this.closeConnect.Size = new System.Drawing.Size(205, 55);
            this.closeConnect.TabIndex = 1;
            this.closeConnect.Text = "Close Connection";
            this.closeConnect.UseVisualStyleBackColor = true;
            this.closeConnect.Click += new System.EventHandler(this.closeConnect_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(288, 194);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(50, 13);
            this.lblMessage.TabIndex = 2;
            this.lblMessage.Text = "CLOSED";
            // 
            // DB_Connection_Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.closeConnect);
            this.Controls.Add(this.openConnect);
            this.Name = "DB_Connection_Test";
            this.Text = "DB_Connection_Test";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button openConnect;
        private System.Windows.Forms.Button closeConnect;
        private System.Windows.Forms.Label lblMessage;
    }
}