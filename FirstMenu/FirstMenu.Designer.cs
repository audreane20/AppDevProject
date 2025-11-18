namespace FirstMenu
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
            this.hotDrinksLabel = new System.Windows.Forms.Label();
            this.coldDrinkLabel = new System.Windows.Forms.Label();
            this.pastriesLabel = new System.Windows.Forms.Label();
            this.pastriesIcon = new System.Windows.Forms.PictureBox();
            this.coldDrinkIcon = new System.Windows.Forms.PictureBox();
            this.hotDrinkIcon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pastriesIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coldDrinkIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotDrinkIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // hotDrinksLabel
            // 
            this.hotDrinksLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.hotDrinksLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hotDrinksLabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hotDrinksLabel.Location = new System.Drawing.Point(50, 326);
            this.hotDrinksLabel.Name = "hotDrinksLabel";
            this.hotDrinksLabel.Size = new System.Drawing.Size(200, 37);
            this.hotDrinksLabel.TabIndex = 5;
            this.hotDrinksLabel.Text = "Hot Drinks";
            this.hotDrinksLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.hotDrinksLabel.Click += new System.EventHandler(this.hotDrinksLabel_Click);
            // 
            // coldDrinkLabel
            // 
            this.coldDrinkLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.coldDrinkLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.coldDrinkLabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coldDrinkLabel.Location = new System.Drawing.Point(301, 326);
            this.coldDrinkLabel.Name = "coldDrinkLabel";
            this.coldDrinkLabel.Size = new System.Drawing.Size(200, 37);
            this.coldDrinkLabel.TabIndex = 6;
            this.coldDrinkLabel.Text = "Cold Drinks";
            this.coldDrinkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.coldDrinkLabel.Click += new System.EventHandler(this.coldDrinkLabel_Click);
            // 
            // pastriesLabel
            // 
            this.pastriesLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pastriesLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pastriesLabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pastriesLabel.Location = new System.Drawing.Point(556, 326);
            this.pastriesLabel.Name = "pastriesLabel";
            this.pastriesLabel.Size = new System.Drawing.Size(200, 37);
            this.pastriesLabel.TabIndex = 7;
            this.pastriesLabel.Text = "Pastries";
            this.pastriesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.pastriesLabel.Click += new System.EventHandler(this.pastriesLabel_Click);
            // 
            // pastriesIcon
            // 
            this.pastriesIcon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.pastriesIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pastriesIcon.ErrorImage = null;
            this.pastriesIcon.Image = global::FirstMenu.Properties.Resources.IconPasteries;
            this.pastriesIcon.Location = new System.Drawing.Point(556, 126);
            this.pastriesIcon.Name = "pastriesIcon";
            this.pastriesIcon.Size = new System.Drawing.Size(200, 198);
            this.pastriesIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pastriesIcon.TabIndex = 4;
            this.pastriesIcon.TabStop = false;
            this.pastriesIcon.Click += new System.EventHandler(this.pastriesIcon_Click);
            // 
            // coldDrinkIcon
            // 
            this.coldDrinkIcon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.coldDrinkIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.coldDrinkIcon.ErrorImage = null;
            this.coldDrinkIcon.Image = global::FirstMenu.Properties.Resources.IconColdDrink;
            this.coldDrinkIcon.Location = new System.Drawing.Point(301, 126);
            this.coldDrinkIcon.Name = "coldDrinkIcon";
            this.coldDrinkIcon.Size = new System.Drawing.Size(200, 198);
            this.coldDrinkIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.coldDrinkIcon.TabIndex = 3;
            this.coldDrinkIcon.TabStop = false;
            this.coldDrinkIcon.Click += new System.EventHandler(this.coldDrinkIcon_Click);
            // 
            // hotDrinkIcon
            // 
            this.hotDrinkIcon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.hotDrinkIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hotDrinkIcon.ErrorImage = null;
            this.hotDrinkIcon.Image = global::FirstMenu.Properties.Resources.IconHotDrink;
            this.hotDrinkIcon.Location = new System.Drawing.Point(50, 126);
            this.hotDrinkIcon.Name = "hotDrinkIcon";
            this.hotDrinkIcon.Size = new System.Drawing.Size(200, 198);
            this.hotDrinkIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.hotDrinkIcon.TabIndex = 2;
            this.hotDrinkIcon.TabStop = false;
            this.hotDrinkIcon.Click += new System.EventHandler(this.hotDrinkIcon_Click);
            // 
            // FirstMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(187)))), ((int)(((byte)(129)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pastriesLabel);
            this.Controls.Add(this.coldDrinkLabel);
            this.Controls.Add(this.hotDrinksLabel);
            this.Controls.Add(this.pastriesIcon);
            this.Controls.Add(this.coldDrinkIcon);
            this.Controls.Add(this.hotDrinkIcon);
            this.Name = "FirstMenu";
            this.Text = "Menu";
            ((System.ComponentModel.ISupportInitialize)(this.pastriesIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coldDrinkIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotDrinkIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox hotDrinkIcon;
        private System.Windows.Forms.PictureBox coldDrinkIcon;
        private System.Windows.Forms.PictureBox pastriesIcon;
        private System.Windows.Forms.Label hotDrinksLabel;
        private System.Windows.Forms.Label coldDrinkLabel;
        private System.Windows.Forms.Label pastriesLabel;
    }
}

