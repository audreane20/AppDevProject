namespace Comfy_Cozy_Cafe
{
    partial class FirstMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FirstMenu));
            this.HotDrinksLabel = new System.Windows.Forms.Label();
            this.ColdDrinkLabel = new System.Windows.Forms.Label();
            this.PastryLabel = new System.Windows.Forms.Label();
            this.PastryIcon = new System.Windows.Forms.PictureBox();
            this.ColdDrinkIcon = new System.Windows.Forms.PictureBox();
            this.HotDrinkIcon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PastryIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColdDrinkIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HotDrinkIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // HotDrinksLabel
            // 
            resources.ApplyResources(this.HotDrinksLabel, "HotDrinksLabel");
            this.HotDrinksLabel.AllowDrop = true;
            this.HotDrinksLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HotDrinksLabel.Name = "HotDrinksLabel";
            this.HotDrinksLabel.Click += new System.EventHandler(this.HotDrinksLabel_Click);
            // 
            // ColdDrinkLabel
            // 
            resources.ApplyResources(this.ColdDrinkLabel, "ColdDrinkLabel");
            this.ColdDrinkLabel.AllowDrop = true;
            this.ColdDrinkLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ColdDrinkLabel.Name = "ColdDrinkLabel";
            this.ColdDrinkLabel.Click += new System.EventHandler(this.ColdDrinkLabel_Click);
            // 
            // PastryLabel
            // 
            resources.ApplyResources(this.PastryLabel, "PastryLabel");
            this.PastryLabel.AllowDrop = true;
            this.PastryLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PastryLabel.Name = "PastryLabel";
            this.PastryLabel.Click += new System.EventHandler(this.PastryLabel_Click_1);
            // 
            // PastryIcon
            // 
            resources.ApplyResources(this.PastryIcon, "PastryIcon");
            this.PastryIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PastryIcon.Image = global::Comfy_Cozy_Cafe.Properties.Resources.IconPasteries;
            this.PastryIcon.Name = "PastryIcon";
            this.PastryIcon.TabStop = false;
            this.PastryIcon.Click += new System.EventHandler(this.PastryIcon_Click);
            // 
            // ColdDrinkIcon
            // 
            resources.ApplyResources(this.ColdDrinkIcon, "ColdDrinkIcon");
            this.ColdDrinkIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ColdDrinkIcon.Image = global::Comfy_Cozy_Cafe.Properties.Resources.IconColdDrink;
            this.ColdDrinkIcon.Name = "ColdDrinkIcon";
            this.ColdDrinkIcon.TabStop = false;
            this.ColdDrinkIcon.Click += new System.EventHandler(this.ColdDrinkIcon_Click_1);
            // 
            // HotDrinkIcon
            // 
            resources.ApplyResources(this.HotDrinkIcon, "HotDrinkIcon");
            this.HotDrinkIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HotDrinkIcon.Image = global::Comfy_Cozy_Cafe.Properties.Resources.IconHotDrink;
            this.HotDrinkIcon.Name = "HotDrinkIcon";
            this.HotDrinkIcon.TabStop = false;
            this.HotDrinkIcon.Click += new System.EventHandler(this.HotDrinkIcon_Click);
            // 
            // FirstMenu
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(187)))), ((int)(((byte)(129)))));
            this.Controls.Add(this.PastryLabel);
            this.Controls.Add(this.ColdDrinkLabel);
            this.Controls.Add(this.HotDrinksLabel);
            this.Controls.Add(this.PastryIcon);
            this.Controls.Add(this.ColdDrinkIcon);
            this.Controls.Add(this.HotDrinkIcon);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "FirstMenu";
            ((System.ComponentModel.ISupportInitialize)(this.PastryIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColdDrinkIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HotDrinkIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox HotDrinkIcon;
        private System.Windows.Forms.PictureBox ColdDrinkIcon;
        private System.Windows.Forms.PictureBox PastryIcon;
        private System.Windows.Forms.Label HotDrinksLabel;
        private System.Windows.Forms.Label ColdDrinkLabel;
        private System.Windows.Forms.Label PastryLabel;
    }
}