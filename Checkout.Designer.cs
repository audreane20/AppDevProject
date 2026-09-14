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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Checkout));
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
            resources.ApplyResources(this.listViewCart, "listViewCart");
            this.listViewCart.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colItem,
            this.colQty,
            this.colPrice});
            this.listViewCart.FullRowSelect = true;
            this.listViewCart.GridLines = true;
            this.listViewCart.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewCart.HideSelection = false;
            this.listViewCart.Name = "listViewCart";
            this.listViewCart.UseCompatibleStateImageBehavior = false;
            this.listViewCart.View = System.Windows.Forms.View.Details;
            // 
            // colItem
            // 
            resources.ApplyResources(this.colItem, "colItem");
            // 
            // colQty
            // 
            resources.ApplyResources(this.colQty, "colQty");
            // 
            // colPrice
            // 
            resources.ApplyResources(this.colPrice, "colPrice");
            // 
            // lblTotal
            // 
            resources.ApplyResources(this.lblTotal, "lblTotal");
            this.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotal.Name = "lblTotal";
            // 
            // payButton
            // 
            resources.ApplyResources(this.payButton, "payButton");
            this.payButton.BackColor = System.Drawing.Color.White;
            this.payButton.Name = "payButton";
            this.payButton.UseVisualStyleBackColor = false;
            this.payButton.Click += new System.EventHandler(this.payButton_Click);
            // 
            // firstNameTextBox
            // 
            resources.ApplyResources(this.firstNameTextBox, "firstNameTextBox");
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.TextChanged += new System.EventHandler(this.firstNameTextBox_TextChanged);
            this.firstNameTextBox.DoubleClick += new System.EventHandler(this.firstNameTextBox_DoubleClick);
            // 
            // detailsLabel
            // 
            resources.ApplyResources(this.detailsLabel, "detailsLabel");
            this.detailsLabel.Name = "detailsLabel";
            this.detailsLabel.Click += new System.EventHandler(this.detailsLabel_Click);
            // 
            // emailTextBox
            // 
            resources.ApplyResources(this.emailTextBox, "emailTextBox");
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.TextChanged += new System.EventHandler(this.emailTextBox_TextChanged);
            this.emailTextBox.DoubleClick += new System.EventHandler(this.emailTextBox_DoubleClick);
            // 
            // addressTextBox
            // 
            resources.ApplyResources(this.addressTextBox, "addressTextBox");
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.TextChanged += new System.EventHandler(this.addressTextBox_TextChanged);
            this.addressTextBox.DoubleClick += new System.EventHandler(this.addressTextBox_DoubleClick);
            // 
            // pickupRadio
            // 
            resources.ApplyResources(this.pickupRadio, "pickupRadio");
            this.pickupRadio.Name = "pickupRadio";
            this.pickupRadio.TabStop = true;
            this.pickupRadio.UseVisualStyleBackColor = true;
            this.pickupRadio.CheckedChanged += new System.EventHandler(this.pickupRadio_CheckedChanged);
            // 
            // deliveryRadio
            // 
            resources.ApplyResources(this.deliveryRadio, "deliveryRadio");
            this.deliveryRadio.Name = "deliveryRadio";
            this.deliveryRadio.TabStop = true;
            this.deliveryRadio.UseVisualStyleBackColor = true;
            this.deliveryRadio.CheckedChanged += new System.EventHandler(this.deliveryRadio_CheckedChanged);
            // 
            // nameLabel
            // 
            resources.ApplyResources(this.nameLabel, "nameLabel");
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Click += new System.EventHandler(this.nameLabel_Click);
            // 
            // emailLabel
            // 
            resources.ApplyResources(this.emailLabel, "emailLabel");
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Click += new System.EventHandler(this.emailLabel_Click);
            // 
            // addressLabel
            // 
            resources.ApplyResources(this.addressLabel, "addressLabel");
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Click += new System.EventHandler(this.addressLabel_Click);
            // 
            // cardLabel
            // 
            resources.ApplyResources(this.cardLabel, "cardLabel");
            this.cardLabel.Name = "cardLabel";
            this.cardLabel.Click += new System.EventHandler(this.cardLabel_Click);
            // 
            // cardTextBox
            // 
            resources.ApplyResources(this.cardTextBox, "cardTextBox");
            this.cardTextBox.Name = "cardTextBox";
            this.cardTextBox.TextChanged += new System.EventHandler(this.cardTextBox_TextChanged);
            this.cardTextBox.DoubleClick += new System.EventHandler(this.cardTextBox_DoubleClick);
            // 
            // expirationTextBox
            // 
            resources.ApplyResources(this.expirationTextBox, "expirationTextBox");
            this.expirationTextBox.Name = "expirationTextBox";
            this.expirationTextBox.TextChanged += new System.EventHandler(this.expirationTextBox_TextChanged);
            this.expirationTextBox.DoubleClick += new System.EventHandler(this.expirationTextBox_DoubleClick);
            // 
            // CVVTextBox
            // 
            resources.ApplyResources(this.CVVTextBox, "CVVTextBox");
            this.CVVTextBox.Name = "CVVTextBox";
            this.CVVTextBox.TextChanged += new System.EventHandler(this.CVVTextBox_TextChanged);
            this.CVVTextBox.DoubleClick += new System.EventHandler(this.CVVTextBox_DoubleClick);
            // 
            // ZIPTextBox
            // 
            resources.ApplyResources(this.ZIPTextBox, "ZIPTextBox");
            this.ZIPTextBox.Name = "ZIPTextBox";
            this.ZIPTextBox.TextChanged += new System.EventHandler(this.ZIPTextBox_TextChanged);
            this.ZIPTextBox.DoubleClick += new System.EventHandler(this.ZIPTextBox_DoubleClick);
            // 
            // lastNameTextBox
            // 
            resources.ApplyResources(this.lastNameTextBox, "lastNameTextBox");
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.TextChanged += new System.EventHandler(this.lastNameTextBox_TextChanged);
            this.lastNameTextBox.DoubleClick += new System.EventHandler(this.lastNameTextBox_DoubleClick);
            // 
            // Checkout
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(187)))), ((int)(((byte)(129)))));
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