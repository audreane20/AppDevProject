namespace Menus
{
    partial class Checkout
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
            this.listViewCart = new System.Windows.Forms.ListView();
            this.colItem = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colQty = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblTotal = new System.Windows.Forms.Label();
            this.payButton = new System.Windows.Forms.Button();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.detailsLabel = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.pickupRadio = new System.Windows.Forms.RadioButton();
            this.deliveryRadio = new System.Windows.Forms.RadioButton();
            this.nameLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.cardLabel = new System.Windows.Forms.Label();
            this.cardTextBox = new System.Windows.Forms.TextBox();
            this.expirationTextBox = new System.Windows.Forms.TextBox();
            this.CVVTextBox = new System.Windows.Forms.TextBox();
            this.ZIPTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listViewCart
            // 
            this.listViewCart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listViewCart.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colItem,
            this.colQty,
            this.colPrice});
            this.listViewCart.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewCart.FullRowSelect = true;
            this.listViewCart.GridLines = true;
            this.listViewCart.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewCart.HideSelection = false;
            this.listViewCart.Location = new System.Drawing.Point(280, 41);
            this.listViewCart.Margin = new System.Windows.Forms.Padding(2);
            this.listViewCart.Name = "listViewCart";
            this.listViewCart.Size = new System.Drawing.Size(239, 248);
            this.listViewCart.TabIndex = 1;
            this.listViewCart.UseCompatibleStateImageBehavior = false;
            this.listViewCart.View = System.Windows.Forms.View.Details;
            // 
            // colItem
            // 
            this.colItem.Text = "Item";
            this.colItem.Width = 133;
            // 
            // colQty
            // 
            this.colQty.Text = "Qty";
            this.colQty.Width = 41;
            // 
            // colPrice
            // 
            this.colPrice.Text = "Price";
            this.colPrice.Width = 100;
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblTotal.Location = new System.Drawing.Point(280, 307);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(239, 41);
            this.lblTotal.TabIndex = 3;
            this.lblTotal.Text = "Total: $0.00";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // payButton
            // 
            this.payButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.payButton.BackColor = System.Drawing.Color.White;
            this.payButton.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payButton.Location = new System.Drawing.Point(11, 307);
            this.payButton.Margin = new System.Windows.Forms.Padding(2);
            this.payButton.Name = "payButton";
            this.payButton.Size = new System.Drawing.Size(258, 41);
            this.payButton.TabIndex = 5;
            this.payButton.Text = "&Pay";
            this.payButton.UseVisualStyleBackColor = false;
            this.payButton.Click += new System.EventHandler(this.payButton_Click);
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(15, 74);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(117, 20);
            this.firstNameTextBox.TabIndex = 6;
            this.firstNameTextBox.TextChanged += new System.EventHandler(this.firstNameTextBox_TextChanged);
            this.firstNameTextBox.DoubleClick += new System.EventHandler(this.firstNameTextBox_DoubleClick);
            // 
            // detailsLabel
            // 
            this.detailsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detailsLabel.Location = new System.Drawing.Point(12, 31);
            this.detailsLabel.Name = "detailsLabel";
            this.detailsLabel.Size = new System.Drawing.Size(168, 20);
            this.detailsLabel.TabIndex = 7;
            this.detailsLabel.Text = "Customer details";
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(15, 122);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(247, 20);
            this.emailTextBox.TabIndex = 8;
            this.emailTextBox.TextChanged += new System.EventHandler(this.emailTextBox_TextChanged);
            this.emailTextBox.DoubleClick += new System.EventHandler(this.emailTextBox_DoubleClick);
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(15, 171);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(247, 20);
            this.addressTextBox.TabIndex = 9;
            this.addressTextBox.TextChanged += new System.EventHandler(this.addressTextBox_TextChanged);
            this.addressTextBox.DoubleClick += new System.EventHandler(this.addressTextBox_DoubleClick);
            // 
            // pickupRadio
            // 
            this.pickupRadio.AutoSize = true;
            this.pickupRadio.Location = new System.Drawing.Point(15, 272);
            this.pickupRadio.Name = "pickupRadio";
            this.pickupRadio.Size = new System.Drawing.Size(58, 17);
            this.pickupRadio.TabIndex = 10;
            this.pickupRadio.TabStop = true;
            this.pickupRadio.Text = "Pickup";
            this.pickupRadio.UseVisualStyleBackColor = true;
            this.pickupRadio.CheckedChanged += new System.EventHandler(this.pickupRadio_CheckedChanged);
            // 
            // deliveryRadio
            // 
            this.deliveryRadio.AutoSize = true;
            this.deliveryRadio.Location = new System.Drawing.Point(118, 272);
            this.deliveryRadio.Name = "deliveryRadio";
            this.deliveryRadio.Size = new System.Drawing.Size(63, 17);
            this.deliveryRadio.TabIndex = 11;
            this.deliveryRadio.TabStop = true;
            this.deliveryRadio.Text = "Delivery";
            this.deliveryRadio.UseVisualStyleBackColor = true;
            this.deliveryRadio.CheckedChanged += new System.EventHandler(this.deliveryRadio_CheckedChanged);
            // 
            // nameLabel
            // 
            this.nameLabel.Location = new System.Drawing.Point(15, 51);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(227, 17);
            this.nameLabel.TabIndex = 12;
            this.nameLabel.Text = "Name";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(15, 106);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(32, 13);
            this.emailLabel.TabIndex = 13;
            this.emailLabel.Text = "Email";
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Location = new System.Drawing.Point(15, 155);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(45, 13);
            this.addressLabel.TabIndex = 14;
            this.addressLabel.Text = "Address";
            // 
            // cardLabel
            // 
            this.cardLabel.AutoSize = true;
            this.cardLabel.Location = new System.Drawing.Point(15, 198);
            this.cardLabel.Name = "cardLabel";
            this.cardLabel.Size = new System.Drawing.Size(96, 13);
            this.cardLabel.TabIndex = 16;
            this.cardLabel.Text = "Credit or debit card";
            // 
            // cardTextBox
            // 
            this.cardTextBox.AccessibleName = "";
            this.cardTextBox.Location = new System.Drawing.Point(15, 214);
            this.cardTextBox.Name = "cardTextBox";
            this.cardTextBox.Size = new System.Drawing.Size(247, 20);
            this.cardTextBox.TabIndex = 15;
            this.cardTextBox.TextChanged += new System.EventHandler(this.cardTextBox_TextChanged);
            this.cardTextBox.DoubleClick += new System.EventHandler(this.cardTextBox_DoubleClick);
            // 
            // expirationTextBox
            // 
            this.expirationTextBox.Location = new System.Drawing.Point(15, 240);
            this.expirationTextBox.Name = "expirationTextBox";
            this.expirationTextBox.Size = new System.Drawing.Size(59, 20);
            this.expirationTextBox.TabIndex = 17;
            this.expirationTextBox.TextChanged += new System.EventHandler(this.expirationTextBox_TextChanged);
            this.expirationTextBox.DoubleClick += new System.EventHandler(this.expirationTextBox_DoubleClick);
            // 
            // CVVTextBox
            // 
            this.CVVTextBox.Location = new System.Drawing.Point(80, 240);
            this.CVVTextBox.Name = "CVVTextBox";
            this.CVVTextBox.Size = new System.Drawing.Size(59, 20);
            this.CVVTextBox.TabIndex = 18;
            this.CVVTextBox.TextChanged += new System.EventHandler(this.CVVTextBox_TextChanged);
            this.CVVTextBox.DoubleClick += new System.EventHandler(this.CVVTextBox_DoubleClick);
            // 
            // ZIPTextBox
            // 
            this.ZIPTextBox.Location = new System.Drawing.Point(145, 240);
            this.ZIPTextBox.Name = "ZIPTextBox";
            this.ZIPTextBox.Size = new System.Drawing.Size(117, 20);
            this.ZIPTextBox.TabIndex = 19;
            this.ZIPTextBox.TextChanged += new System.EventHandler(this.ZIPTextBox_TextChanged);
            this.ZIPTextBox.DoubleClick += new System.EventHandler(this.ZIPTextBox_DoubleClick);
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(138, 74);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(124, 20);
            this.lastNameTextBox.TabIndex = 20;
            this.lastNameTextBox.TextChanged += new System.EventHandler(this.lastNameTextBox_TextChanged);
            this.lastNameTextBox.DoubleClick += new System.EventHandler(this.lastNameTextBox_DoubleClick);
            // 
            // Checkout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(187)))), ((int)(((byte)(129)))));
            this.ClientSize = new System.Drawing.Size(530, 379);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.ZIPTextBox);
            this.Controls.Add(this.CVVTextBox);
            this.Controls.Add(this.expirationTextBox);
            this.Controls.Add(this.cardLabel);
            this.Controls.Add(this.cardTextBox);
            this.Controls.Add(this.addressLabel);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.deliveryRadio);
            this.Controls.Add(this.pickupRadio);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.detailsLabel);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.payButton);
            this.Controls.Add(this.listViewCart);
            this.Name = "Checkout";
            this.Text = "Checkout";
            this.Load += new System.EventHandler(this.Checkout_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewCart;
        private System.Windows.Forms.ColumnHeader colItem;
        private System.Windows.Forms.ColumnHeader colQty;
        private System.Windows.Forms.ColumnHeader colPrice;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button payButton;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.Label detailsLabel;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.RadioButton pickupRadio;
        private System.Windows.Forms.RadioButton deliveryRadio;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Label cardLabel;
        private System.Windows.Forms.TextBox cardTextBox;
        private System.Windows.Forms.TextBox expirationTextBox;
        private System.Windows.Forms.TextBox CVVTextBox;
        private System.Windows.Forms.TextBox ZIPTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
    }
}