
using System;

namespace Restuarant_System
{
    partial class frmRestaurantTillMenu
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
            this.mnuMainMenu = new System.Windows.Forms.MenuStrip();
            this.addMenuItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAddMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEditMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRemoveMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.queryMenuItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageOrdersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.placeOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.payBillToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.performAdminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemAnalysisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.revenueAnalysisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPictureBox = new System.Windows.Forms.PictureBox();
            this.mnuMainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // mnuMainMenu
            // 
            this.mnuMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addMenuItemToolStripMenuItem,
            this.manageOrdersToolStripMenuItem,
            this.performAdminToolStripMenuItem});
            this.mnuMainMenu.Location = new System.Drawing.Point(0, 0);
            this.mnuMainMenu.Name = "mnuMainMenu";
            this.mnuMainMenu.Size = new System.Drawing.Size(858, 24);
            this.mnuMainMenu.TabIndex = 0;
            this.mnuMainMenu.Text = "menuStrip1";
            // 
            // addMenuItemToolStripMenuItem
            // 
            this.addMenuItemToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAddMenuItem,
            this.mnuEditMenuItem,
            this.mnuRemoveMenuItem,
            this.queryMenuItemToolStripMenuItem});
            this.addMenuItemToolStripMenuItem.Name = "addMenuItemToolStripMenuItem";
            this.addMenuItemToolStripMenuItem.Size = new System.Drawing.Size(128, 20);
            this.addMenuItemToolStripMenuItem.Text = "Manage Menu Items";
            // 
            // mnuAddMenuItem
            // 
            this.mnuAddMenuItem.Name = "mnuAddMenuItem";
            this.mnuAddMenuItem.Size = new System.Drawing.Size(178, 22);
            this.mnuAddMenuItem.Text = "Add Menu Item";
            this.mnuAddMenuItem.Click += new System.EventHandler(this.mnuAddMenuItem_Click);
            // 
            // mnuEditMenuItem
            // 
            this.mnuEditMenuItem.Name = "mnuEditMenuItem";
            this.mnuEditMenuItem.Size = new System.Drawing.Size(178, 22);
            this.mnuEditMenuItem.Text = "Edit Menu Item";
            this.mnuEditMenuItem.Click += new System.EventHandler(this.mnuEditMenuItem_Click);
            // 
            // mnuRemoveMenuItem
            // 
            this.mnuRemoveMenuItem.Name = "mnuRemoveMenuItem";
            this.mnuRemoveMenuItem.Size = new System.Drawing.Size(178, 22);
            this.mnuRemoveMenuItem.Text = "Remove Menu Item";
            this.mnuRemoveMenuItem.Click += new System.EventHandler(this.mnuRemovetMenuItem_Click);
            // 
            // queryMenuItemToolStripMenuItem
            // 
            this.queryMenuItemToolStripMenuItem.Name = "queryMenuItemToolStripMenuItem";
            this.queryMenuItemToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.queryMenuItemToolStripMenuItem.Text = "Query Menu Item";
            this.queryMenuItemToolStripMenuItem.Click += new System.EventHandler(this.mnuQueryMenuItem_Click);
            // 
            // manageOrdersToolStripMenuItem
            // 
            this.manageOrdersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.placeOrderToolStripMenuItem,
            this.editOrderToolStripMenuItem,
            this.cancelOrderToolStripMenuItem,
            this.payBillToolStripMenuItem});
            this.manageOrdersToolStripMenuItem.Name = "manageOrdersToolStripMenuItem";
            this.manageOrdersToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            this.manageOrdersToolStripMenuItem.Text = "Manage Orders";
            // 
            // placeOrderToolStripMenuItem
            // 
            this.placeOrderToolStripMenuItem.Name = "placeOrderToolStripMenuItem";
            this.placeOrderToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.placeOrderToolStripMenuItem.Text = "Place Order";
            this.placeOrderToolStripMenuItem.Click += new System.EventHandler(this.mnuPlaceOrderToolStripMenuItem_Click);
            // 
            // editOrderToolStripMenuItem
            // 
            this.editOrderToolStripMenuItem.Name = "editOrderToolStripMenuItem";
            this.editOrderToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.editOrderToolStripMenuItem.Text = "Edit Order";
            this.editOrderToolStripMenuItem.Click += new System.EventHandler(this.mnuEditOrderToolStripMenuItem_Click);
            // 
            // cancelOrderToolStripMenuItem
            // 
            this.cancelOrderToolStripMenuItem.Name = "cancelOrderToolStripMenuItem";
            this.cancelOrderToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.cancelOrderToolStripMenuItem.Text = "Cancel Order";
            this.cancelOrderToolStripMenuItem.Click += new System.EventHandler(this.mnuCancelOrderToolStripMenuItem_Click);
            // 
            // payBillToolStripMenuItem
            // 
            this.payBillToolStripMenuItem.Name = "payBillToolStripMenuItem";
            this.payBillToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.payBillToolStripMenuItem.Text = "Pay Bill";
            this.payBillToolStripMenuItem.Click += new System.EventHandler(this.mnuPayBillToolStripMenuItem_Click);
            // 
            // performAdminToolStripMenuItem
            // 
            this.performAdminToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemAnalysisToolStripMenuItem,
            this.revenueAnalysisToolStripMenuItem});
            this.performAdminToolStripMenuItem.Name = "performAdminToolStripMenuItem";
            this.performAdminToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.performAdminToolStripMenuItem.Text = "Perform Admin";
            // 
            // menuItemAnalysisToolStripMenuItem
            // 
            this.menuItemAnalysisToolStripMenuItem.Name = "menuItemAnalysisToolStripMenuItem";
            this.menuItemAnalysisToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.menuItemAnalysisToolStripMenuItem.Text = "Menu Item Analysis";
            this.menuItemAnalysisToolStripMenuItem.Click += new System.EventHandler(this.mnuMenuItemAnalysisToolStripMenuItem_Click);
            // 
            // revenueAnalysisToolStripMenuItem
            // 
            this.revenueAnalysisToolStripMenuItem.Name = "revenueAnalysisToolStripMenuItem";
            this.revenueAnalysisToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.revenueAnalysisToolStripMenuItem.Text = "Revenue Analysis";
            this.revenueAnalysisToolStripMenuItem.Click += new System.EventHandler(this.mnuRevenueAnalysisToolStripMenuItem_Click);
            // 
            // menuPictureBox
            // 
            this.menuPictureBox.Image = global::Restuarant_System.Properties.Resources.CatPicture;
            this.menuPictureBox.Location = new System.Drawing.Point(25, 43);
            this.menuPictureBox.Name = "menuPictureBox";
            this.menuPictureBox.Size = new System.Drawing.Size(801, 660);
            this.menuPictureBox.TabIndex = 1;
            this.menuPictureBox.TabStop = false;
            // 
            // frmRestaurantTillMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 725);
            this.Controls.Add(this.menuPictureBox);
            this.Controls.Add(this.mnuMainMenu);
            this.MainMenuStrip = this.mnuMainMenu;
            this.Name = "frmRestaurantTillMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmRestauarantTilMenu_FormClosing);
            this.Load += new System.EventHandler(this.frmRestuarantTillMenu_Load);
            this.mnuMainMenu.ResumeLayout(false);
            this.mnuMainMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

   
        #endregion

        private System.Windows.Forms.MenuStrip mnuMainMenu;
        private System.Windows.Forms.ToolStripMenuItem addMenuItemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuAddMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuEditMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuRemoveMenuItem;
        private System.Windows.Forms.ToolStripMenuItem queryMenuItemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageOrdersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem placeOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancelOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem payBillToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem performAdminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuItemAnalysisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem revenueAnalysisToolStripMenuItem;
        private System.Windows.Forms.PictureBox menuPictureBox;
    }
}