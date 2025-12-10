using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Menus.Cart;
using static Menus.Checkout;

namespace Menus
{
    public partial class Checkout : Form
    {

        Double total;
        public List<CartItem> CartItems => Menus.Cart.CartItems;
        public Checkout(double total)
        {
            InitializeComponent();
            this.total = total;
            LoadCartItems();
            
        }


        private void LoadCartItems()
        {
            listViewCart.BeginUpdate();
            listViewCart.Items.Clear();
            listViewCart.Groups.Clear();

            // Create category groups
            var coldGroup = new ListViewGroup("Cold Drinks");
            var hotGroup = new ListViewGroup("Hot Drinks");
            var pastryGroup = new ListViewGroup("Pastries");

            listViewCart.Groups.Add(coldGroup);
            listViewCart.Groups.Add(hotGroup);
            listViewCart.Groups.Add(pastryGroup);

            foreach (var item in CartItems)
            {
                // MAIN ITEM ROW
                ListViewItem row = new ListViewItem(item.Name);
                row.SubItems.Add(item.Quantity.ToString());
                row.SubItems.Add("$" + item.Price.ToString("0.00"));
                row.SubItems.Add("$" + item.Subtotal.ToString("0.00"));
                row.Tag = item;

                // Assign correct group
                switch (item.Category)
                {
                    case "Cold Drinks":
                        row.Group = coldGroup;
                        break;

                    case "Hot Drinks":
                        row.Group = hotGroup;
                        break;

                    case "Pastries":
                        row.Group = pastryGroup;
                        break;
                }

                listViewCart.Items.Add(row);

                // ADD-ONS UNDER ITEM
                foreach (var addon in item.AddOns)
                {
                    ListViewItem addonRow = new ListViewItem("   • " + addon.Name);
                    addonRow.SubItems.Add(addon.Quantity.ToString());

                    addonRow.SubItems.Add("");
                    addonRow.SubItems.Add("");

                    addonRow.ForeColor = Color.DarkSlateGray;

                    // Match parent group
                    addonRow.Group = row.Group;

                    addonRow.Tag = addon;

                    listViewCart.Items.Add(addonRow);
                }
            }

            listViewCart.EndUpdate();
            UpdateTotal();
        }

        private void UpdateTotal()
        {
            total = 0;

            foreach (var item in CartItems)
                total += item.Subtotal;

            lblTotal.Text = "Total: $" + total.ToString("0.00");
        }

        private void menuItemsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.menuItemsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.comfyCafeDBDataSet);

        }

        private void Checkout_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'comfyCafeDBDataSet.MenuItems' table. You can move, or remove it, as needed.
            this.menuItemsTableAdapter.Fill(this.comfyCafeDBDataSet.MenuItems);
            firstNameTextBox.Text = "First Name";
            lastNameTextBox.Text = "Last Name";
            emailTextBox.Text = "Email Address";
            addressTextBox.Text = "Home Address";
            cardTextBox.Text = "Card Number";
            expirationTextBox.Text = "MM/YY";
            CVVTextBox.Text = "CVV";
            ZIPTextBox.Text = "ZIP Code";

            firstNameTextBox.ForeColor = Color.Gray;
            lastNameTextBox.ForeColor = Color.Gray;
            emailTextBox.ForeColor = Color.Gray;
            cardTextBox.ForeColor = Color.Gray;
            expirationTextBox.ForeColor = Color.Gray;
            CVVTextBox.ForeColor = Color.Gray;
            ZIPTextBox.ForeColor = Color.Gray;
            addressTextBox.ForeColor = Color.Gray;


        }


        private void payButton_Click(object sender, EventArgs e)
        {
            // Name validation
            if (string.IsNullOrWhiteSpace(firstNameTextBox.Text) ||
                firstNameTextBox.Text == "First Name")
            {
                MessageBox.Show("Please enter your first name.");
                return;
            }

            if (string.IsNullOrWhiteSpace(lastNameTextBox.Text) || lastNameTextBox.Text == "Last Name")
            {
                MessageBox.Show("Please enter your last name.");
                return;
            }

            //Email validation
            string email = emailTextBox.Text;

            if (string.IsNullOrWhiteSpace(email) || !email.Contains("@") || !email.Contains("."))
            {
                MessageBox.Show("Please enter a valid email address.");
                return;
            }

            // Card validation
            string card = cardTextBox.Text.Replace(" ", "");

            if (card.Length != 16 || !card.All(char.IsDigit))
            {
                MessageBox.Show("Please enter a valid credit/debit card (16 digits).");
                return;
            }

            //Option validation
            if (!pickupRadio.Checked && !deliveryRadio.Checked)
            {
                MessageBox.Show("Please select a pickup or delivery option.");
                return;
            }

            if (deliveryRadio.Checked)
            {
                total += total * 0.15;
                DeliveryForm deliveryForm = new DeliveryForm(emailTextBox.Text,generateOrderNumber());
                deliveryForm.Show();
            }
            else
            {
                confirmationPopUp(generateOrderNumber());
                Menus.Cart.CartItems.Clear();

            }
        }

        private void confirmationPopUp(int num)
        {
            MessageBox.Show("Thank you for your order! A confirmation email has been sent to " + emailTextBox.Text + ".", $"Order {num} Confirmed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private int generateOrderNumber()
        {
            Random rand = new Random();
            return rand.Next(1000, 9999);
        }

        private void firstNameTextBox_TextChanged(object sender, EventArgs e)
        {
            firstNameTextBox.ForeColor = Color.Black;
        }

        private void lastNameTextBox_TextChanged(object sender, EventArgs e)
        {
            lastNameTextBox.ForeColor = Color.Black;
        }

        private void emailTextBox_TextChanged(object sender, EventArgs e)
        {
            emailTextBox.ForeColor = Color.Black;
        }

        private void addressTextBox_TextChanged(object sender, EventArgs e)
        {
            addressTextBox.ForeColor = Color.Black;
        }

        private void cardTextBox_TextChanged(object sender, EventArgs e)
        {
            cardTextBox.ForeColor = Color.Black;
        }

        private void expirationTextBox_TextChanged(object sender, EventArgs e)
        {
            expirationTextBox.ForeColor = Color.Black;
        }

        private void CVVTextBox_TextChanged(object sender, EventArgs e)
        {
            CVVTextBox.ForeColor = Color.Black;
        }

        private void ZIPTextBox_TextChanged(object sender, EventArgs e)
        {
            ZIPTextBox.ForeColor = Color.Black;
        }

        private void firstNameTextBox_DoubleClick(object sender, EventArgs e)
        {
            firstNameTextBox.Clear();
        }

        private void lastNameTextBox_DoubleClick(object sender, EventArgs e)
        {
            lastNameTextBox.Clear();
        }

        private void emailTextBox_DoubleClick(object sender, EventArgs e)
        {
            emailTextBox.Clear();
        }

        private void addressTextBox_DoubleClick(object sender, EventArgs e)
        {
            addressTextBox.Clear();
        }

        private void cardTextBox_DoubleClick(object sender, EventArgs e)
        {
            cardTextBox.Clear();
        }

        private void expirationTextBox_DoubleClick(object sender, EventArgs e)
        {
            expirationTextBox.Clear();
        }

        private void CVVTextBox_DoubleClick(object sender, EventArgs e)
        {
            CVVTextBox.Clear();
        }

        private void ZIPTextBox_DoubleClick(object sender, EventArgs e)
        {
            ZIPTextBox.Clear();
        }

        private void deliveryRadio_CheckedChanged(object sender, EventArgs e)
        {
            // Pickup or delivery handling

            if (deliveryRadio.Checked)
            {
                //total += total * 0.15;
                lblTotal.Text = "Total: $" + (total*1.15).ToString("0.00");
            }
        }

        private void pickupRadio_CheckedChanged(object sender, EventArgs e)
        {
            lblTotal.Text = "Total: $" + total.ToString("0.00");
        }
    }
}
