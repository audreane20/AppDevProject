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
            this.deliveryLabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deliveryLabel.Location = new System.Drawing.Point(13, 13);
            this.deliveryLabel.Name = "deliveryLabel";
            this.deliveryLabel.Size = new System.Drawing.Size(198, 27);
            this.deliveryLabel.TabIndex = 0;
            this.deliveryLabel.Text = "Delivery Address";
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(17, 61);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(141, 20);
            this.firstNameTextBox.TabIndex = 1;
            this.firstNameTextBox.DoubleClick += new System.EventHandler(this.firstNameTextBox_DoubleClick);
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(164, 61);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(141, 20);
            this.lastNameTextBox.TabIndex = 2;
            this.lastNameTextBox.DoubleClick += new System.EventHandler(this.lastNameTextBox_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name";
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Location = new System.Drawing.Point(17, 93);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(86, 13);
            this.addressLabel.TabIndex = 4;
            this.addressLabel.Text = "Delivery Address";
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(17, 109);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(288, 20);
            this.addressTextBox.TabIndex = 5;
            this.addressTextBox.DoubleClick += new System.EventHandler(this.addressTextBox_DoubleClick);
            // 
            // aptTextBox
            // 
            this.aptTextBox.Location = new System.Drawing.Point(17, 136);
            this.aptTextBox.Name = "aptTextBox";
            this.aptTextBox.Size = new System.Drawing.Size(288, 20);
            this.aptTextBox.TabIndex = 7;
            this.aptTextBox.DoubleClick += new System.EventHandler(this.aptTextBox_DoubleClick);
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Location = new System.Drawing.Point(17, 162);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(176, 20);
            this.phoneTextBox.TabIndex = 8;
            this.phoneTextBox.DoubleClick += new System.EventHandler(this.phoneTextBox_DoubleClick);
            // 
            // ZIPTextBox
            // 
            this.ZIPTextBox.Location = new System.Drawing.Point(199, 162);
            this.ZIPTextBox.Name = "ZIPTextBox";
            this.ZIPTextBox.Size = new System.Drawing.Size(106, 20);
            this.ZIPTextBox.TabIndex = 9;
            this.ZIPTextBox.DoubleClick += new System.EventHandler(this.ZIPTextBox_DoubleClick);
            // 
            // confirmButton
            // 
            this.confirmButton.Location = new System.Drawing.Point(127, 192);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(75, 23);
            this.confirmButton.TabIndex = 10;
            this.confirmButton.Text = "Confirm";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // DeliveryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 227);
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
            this.Text = "Delivery";
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