namespace Menus
{
    partial class DeliveryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeliveryForm));
            this.deliveryLabel = new System.Windows.Forms.Label();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.aptTextBox = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.ZIPTextBox = new System.Windows.Forms.TextBox();
            this.confirmButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // deliveryLabel
            // 
            resources.ApplyResources(this.deliveryLabel, "deliveryLabel");
            this.deliveryLabel.Name = "deliveryLabel";
            // 
            // firstNameTextBox
            // 
            resources.ApplyResources(this.firstNameTextBox, "firstNameTextBox");
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.DoubleClick += new System.EventHandler(this.firstNameTextBox_DoubleClick);
            // 
            // lastNameTextBox
            // 
            resources.ApplyResources(this.lastNameTextBox, "lastNameTextBox");
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.DoubleClick += new System.EventHandler(this.lastNameTextBox_DoubleClick);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // addressLabel
            // 
            resources.ApplyResources(this.addressLabel, "addressLabel");
            this.addressLabel.Name = "addressLabel";
            // 
            // addressTextBox
            // 
            resources.ApplyResources(this.addressTextBox, "addressTextBox");
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.DoubleClick += new System.EventHandler(this.addressTextBox_DoubleClick);
            // 
            // aptTextBox
            // 
            resources.ApplyResources(this.aptTextBox, "aptTextBox");
            this.aptTextBox.Name = "aptTextBox";
            this.aptTextBox.DoubleClick += new System.EventHandler(this.aptTextBox_DoubleClick);
            // 
            // phoneTextBox
            // 
            resources.ApplyResources(this.phoneTextBox, "phoneTextBox");
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.DoubleClick += new System.EventHandler(this.phoneTextBox_DoubleClick);
            // 
            // ZIPTextBox
            // 
            resources.ApplyResources(this.ZIPTextBox, "ZIPTextBox");
            this.ZIPTextBox.Name = "ZIPTextBox";
            this.ZIPTextBox.DoubleClick += new System.EventHandler(this.ZIPTextBox_DoubleClick);
            // 
            // confirmButton
            // 
            resources.ApplyResources(this.confirmButton, "confirmButton");
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // DeliveryForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(187)))), ((int)(((byte)(129)))));
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.ZIPTextBox);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(this.aptTextBox);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(this.addressLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.deliveryLabel);
            this.Name = "DeliveryForm";
            this.Load += new System.EventHandler(this.DeliveryForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label deliveryLabel;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox aptTextBox;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.TextBox ZIPTextBox;
        private System.Windows.Forms.Button confirmButton;
    }
}