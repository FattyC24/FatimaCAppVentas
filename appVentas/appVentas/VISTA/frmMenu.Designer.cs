﻿namespace appVentas.VISTA
{
    partial class frmMenu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cONTROLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uSUARIOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rOLESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vENDERToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vENDERToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cONTROLToolStripMenuItem,
            this.vENDERToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cONTROLToolStripMenuItem
            // 
            this.cONTROLToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.cONTROLToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uSUARIOSToolStripMenuItem,
            this.rOLESToolStripMenuItem});
            this.cONTROLToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cONTROLToolStripMenuItem.Name = "cONTROLToolStripMenuItem";
            this.cONTROLToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.cONTROLToolStripMenuItem.Text = "CONTROL";
            // 
            // uSUARIOSToolStripMenuItem
            // 
            this.uSUARIOSToolStripMenuItem.Name = "uSUARIOSToolStripMenuItem";
            this.uSUARIOSToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.uSUARIOSToolStripMenuItem.Text = "USUARIOS";
            this.uSUARIOSToolStripMenuItem.Click += new System.EventHandler(this.uSUARIOSToolStripMenuItem_Click_1);
            // 
            // rOLESToolStripMenuItem
            // 
            this.rOLESToolStripMenuItem.Name = "rOLESToolStripMenuItem";
            this.rOLESToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.rOLESToolStripMenuItem.Text = "ROLES";
            this.rOLESToolStripMenuItem.Click += new System.EventHandler(this.rOLESToolStripMenuItem_Click);
            // 
            // vENDERToolStripMenuItem
            // 
            this.vENDERToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.vENDERToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vENDERToolStripMenuItem1});
            this.vENDERToolStripMenuItem.Name = "vENDERToolStripMenuItem";
            this.vENDERToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.vENDERToolStripMenuItem.Text = "VENTA";
            // 
            // vENDERToolStripMenuItem1
            // 
            this.vENDERToolStripMenuItem1.Name = "vENDERToolStripMenuItem1";
            this.vENDERToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.vENDERToolStripMenuItem1.Text = "VENDER";
            this.vENDERToolStripMenuItem1.Click += new System.EventHandler(this.vENDERToolStripMenuItem1_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cONTROLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uSUARIOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rOLESToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vENDERToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vENDERToolStripMenuItem1;
    }
}