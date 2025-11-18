namespace MenuSetup
{
    partial class MenuSetup
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hotDrinksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.coldDrinksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.pastriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.AutoSize = false;
            this.menuStrip.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.cartToolStripMenuItem,
            this.checkoutToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip.Size = new System.Drawing.Size(800, 56);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hotDrinksToolStripMenuItem,
            this.coldDrinksToolStripMenuItem,
            this.toolStripSeparator1,
            this.pastriesToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(85, 52);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // hotDrinksToolStripMenuItem
            // 
            this.hotDrinksToolStripMenuItem.Image = global::MenuSetup.Properties.Resources.Hot;
            this.hotDrinksToolStripMenuItem.Name = "hotDrinksToolStripMenuItem";
            this.hotDrinksToolStripMenuItem.Size = new System.Drawing.Size(225, 36);
            this.hotDrinksToolStripMenuItem.Text = "Hot Drinks";
            this.hotDrinksToolStripMenuItem.Click += new System.EventHandler(this.hotDrinksToolStripMenuItem_Click);
            // 
            // coldDrinksToolStripMenuItem
            // 
            this.coldDrinksToolStripMenuItem.Image = global::MenuSetup.Properties.Resources.Cold;
            this.coldDrinksToolStripMenuItem.Name = "coldDrinksToolStripMenuItem";
            this.coldDrinksToolStripMenuItem.Size = new System.Drawing.Size(225, 36);
            this.coldDrinksToolStripMenuItem.Text = "Cold Drinks";
            this.coldDrinksToolStripMenuItem.Click += new System.EventHandler(this.coldDrinksToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(222, 6);
            // 
            // pastriesToolStripMenuItem
            // 
            this.pastriesToolStripMenuItem.Image = global::MenuSetup.Properties.Resources.Pastery;
            this.pastriesToolStripMenuItem.Name = "pastriesToolStripMenuItem";
            this.pastriesToolStripMenuItem.Size = new System.Drawing.Size(225, 36);
            this.pastriesToolStripMenuItem.Text = "Pastries";
            this.pastriesToolStripMenuItem.Click += new System.EventHandler(this.pastriesToolStripMenuItem_Click);
            // 
            // cartToolStripMenuItem
            // 
            this.cartToolStripMenuItem.Enabled = false;
            this.cartToolStripMenuItem.Name = "cartToolStripMenuItem";
            this.cartToolStripMenuItem.Size = new System.Drawing.Size(75, 52);
            this.cartToolStripMenuItem.Text = "Cart";
            // 
            // checkoutToolStripMenuItem
            // 
            this.checkoutToolStripMenuItem.Enabled = false;
            this.checkoutToolStripMenuItem.Name = "checkoutToolStripMenuItem";
            this.checkoutToolStripMenuItem.Size = new System.Drawing.Size(127, 52);
            this.checkoutToolStripMenuItem.Text = "Checkout";
            // 
            // MenuSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(187)))), ((int)(((byte)(129)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MenuSetup";
            this.Text = "MenuSetup";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hotDrinksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem coldDrinksToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem pastriesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkoutToolStripMenuItem;
    }
}

