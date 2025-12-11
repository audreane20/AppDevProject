using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menus
{
    public partial class DeliveryForm : Form
    {
        int num;
        string email;
        Menus.Checkout checkoutForm;
        public DeliveryForm(Menus.Checkout checkoutForm, string email,int num)
        {
            this.checkoutForm = checkoutForm;
            this.email = email;
            this.num = num;
            InitializeComponent();
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(addressTextBox.Text))
            {
                MessageBox.Show("Please enter a delivery address.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            confirmationPopUp(generateOrderNumber());
        }
        private void confirmationPopUp(int num)
        {
            MessageBox.Show("Thank you for your order! A confirmation email has been sent to " + email + ".", $"Order {num} Confirmed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
            checkoutForm.Close(); 
        }

        private int generateOrderNumber()
        {
            Random rand = new Random();
            return rand.Next(1000, 9999);
        }

        private void DeliveryForm_Load(object sender, EventArgs e)
        {
            firstNameTextBox.Text = "First Name";
            firstNameTextBox.ForeColor = Color.Gray;
            lastNameTextBox.Text = "Last Name";
            lastNameTextBox.ForeColor = Color.Gray;
            addressTextBox.Text = "Street Address";
            aptTextBox.Text = "Apt, Suite, etc. (optional)";
            aptTextBox.ForeColor = Color.Gray;
            phoneTextBox.Text = "Phone Number";
            phoneTextBox.ForeColor = Color.Gray;
            ZIPTextBox.Text = "ZIP Code";
            ZIPTextBox.ForeColor = Color.Gray;

        }

        private void firstNameTextBox_DoubleClick(object sender, EventArgs e)
        {
            firstNameTextBox.Clear();
            firstNameTextBox.ForeColor = Color.Black;
        }

        private void lastNameTextBox_DoubleClick(object sender, EventArgs e)
        {
            lastNameTextBox.Clear();
            lastNameTextBox.ForeColor = Color.Black;
        }

        private void addressTextBox_DoubleClick(object sender, EventArgs e)
        {
            addressTextBox.Clear();
            addressTextBox.ForeColor = Color.Black;
        }

        private void aptTextBox_DoubleClick(object sender, EventArgs e)
        {
            addressTextBox.Clear();
            addressTextBox.ForeColor = Color.Black;
        }

        private void phoneTextBox_DoubleClick(object sender, EventArgs e)
        {
            phoneTextBox.Clear();
            phoneTextBox.ForeColor = Color.Black;
        }

        private void ZIPTextBox_DoubleClick(object sender, EventArgs e)
        {
            ZIPTextBox.Clear();
            ZIPTextBox.ForeColor = Color.Black;
        }
    }


}
