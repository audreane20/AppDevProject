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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuSetup));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HotDrinksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ColdDrinksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.PastriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            resources.ApplyResources(this.menuStrip, "menuStrip");
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.cartToolStripMenuItem,
            this.checkoutToolStripMenuItem});
            this.menuStrip.Name = "menuStrip";
            // 
            // menuToolStripMenuItem
            // 
            resources.ApplyResources(this.menuToolStripMenuItem, "menuToolStripMenuItem");
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HotDrinksToolStripMenuItem,
            this.ColdDrinksToolStripMenuItem,
            this.toolStripSeparator1,
            this.PastriesToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            // 
            // HotDrinksToolStripMenuItem
            // 
            resources.ApplyResources(this.HotDrinksToolStripMenuItem, "HotDrinksToolStripMenuItem");
            this.HotDrinksToolStripMenuItem.Image = global::MenuSetup.Properties.Resources.Hot;
            this.HotDrinksToolStripMenuItem.Name = "HotDrinksToolStripMenuItem";
            this.HotDrinksToolStripMenuItem.Click += new System.EventHandler(this.HotDrinksToolStripMenuItem_Click);
            // 
            // ColdDrinksToolStripMenuItem
            // 
            resources.ApplyResources(this.ColdDrinksToolStripMenuItem, "ColdDrinksToolStripMenuItem");
            this.ColdDrinksToolStripMenuItem.Image = global::MenuSetup.Properties.Resources.Cold;
            this.ColdDrinksToolStripMenuItem.Name = "ColdDrinksToolStripMenuItem";
            this.ColdDrinksToolStripMenuItem.Click += new System.EventHandler(this.ColdDrinksToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            // 
            // PastriesToolStripMenuItem
            // 
            resources.ApplyResources(this.PastriesToolStripMenuItem, "PastriesToolStripMenuItem");
            this.PastriesToolStripMenuItem.Image = global::MenuSetup.Properties.Resources.Pastry;
            this.PastriesToolStripMenuItem.Name = "PastriesToolStripMenuItem";
            this.PastriesToolStripMenuItem.Click += new System.EventHandler(this.PastriesToolStripMenuItem_Click);
            // 
            // cartToolStripMenuItem
            // 
            resources.ApplyResources(this.cartToolStripMenuItem, "cartToolStripMenuItem");
            this.cartToolStripMenuItem.Name = "cartToolStripMenuItem";
            this.cartToolStripMenuItem.Click += new System.EventHandler(this.cartToolStripMenuItem_Click);
            // 
            // checkoutToolStripMenuItem
            // 
            resources.ApplyResources(this.checkoutToolStripMenuItem, "checkoutToolStripMenuItem");
            this.checkoutToolStripMenuItem.Name = "checkoutToolStripMenuItem";
            this.checkoutToolStripMenuItem.Click += new System.EventHandler(this.CheckoutToolStripMenuItem_Click);
            // 
            // MenuSetup
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MenuSetup";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HotDrinksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ColdDrinksToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem PastriesToolStripMenuItem;
    }
}

