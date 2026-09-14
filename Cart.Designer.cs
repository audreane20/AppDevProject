namespace Menus
{
    partial class Cart
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ListView listViewCart;
        private System.Windows.Forms.ColumnHeader colItem;
        private System.Windows.Forms.ColumnHeader colQty;
        private System.Windows.Forms.ColumnHeader colPrice;
        private System.Windows.Forms.ColumnHeader colSubtotal;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnEditQuantity;
        private System.Windows.Forms.Label lblTotal;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cart));
            this.listViewCart = new System.Windows.Forms.ListView();
            this.colItem = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colQty = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSubtotal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnEditQuantity = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.proceedButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listViewCart
            // 
            resources.ApplyResources(this.listViewCart, "listViewCart");
            this.listViewCart.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colItem,
            this.colQty,
            this.colPrice,
            this.colSubtotal});
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
            // colSubtotal
            // 
            resources.ApplyResources(this.colSubtotal, "colSubtotal");
            // 
            // btnRemove
            // 
            resources.ApplyResources(this.btnRemove, "btnRemove");
            this.btnRemove.BackColor = System.Drawing.Color.White;
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.UseMnemonic = false;
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnEditQuantity
            // 
            resources.ApplyResources(this.btnEditQuantity, "btnEditQuantity");
            this.btnEditQuantity.BackColor = System.Drawing.Color.White;
            this.btnEditQuantity.Name = "btnEditQuantity";
            this.btnEditQuantity.UseMnemonic = false;
            this.btnEditQuantity.UseVisualStyleBackColor = false;
            this.btnEditQuantity.Click += new System.EventHandler(this.btnEditQuantity_Click);
            // 
            // lblTotal
            // 
            resources.ApplyResources(this.lblTotal, "lblTotal");
            this.lblTotal.Name = "lblTotal";
            // 
            // proceedButton
            // 
            resources.ApplyResources(this.proceedButton, "proceedButton");
            this.proceedButton.BackColor = System.Drawing.Color.White;
            this.proceedButton.Name = "proceedButton";
            this.proceedButton.UseVisualStyleBackColor = false;
            this.proceedButton.Click += new System.EventHandler(this.proceedButton_Click);
            // 
            // Cart
            // 
            resources.ApplyResources(this, "$this");
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(187)))), ((int)(((byte)(129)))));
            this.Controls.Add(this.proceedButton);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnEditQuantity);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.listViewCart);
            this.Name = "Cart";
            this.Controls.SetChildIndex(this.listViewCart, 0);
            this.Controls.SetChildIndex(this.btnRemove, 0);
            this.Controls.SetChildIndex(this.btnEditQuantity, 0);
            this.Controls.SetChildIndex(this.lblTotal, 0);
            this.Controls.SetChildIndex(this.proceedButton, 0);
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Button proceedButton;
    }
}
