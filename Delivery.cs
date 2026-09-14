using Comfy_Cozy_Cafe;
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
        string lang = System.Threading.Thread.CurrentThread.CurrentUICulture.TwoLetterISOLanguageName;
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
                MessageBox.Show(translateMessage("Please enter a delivery address."), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            confirmationPopUp(generateOrderNumber());
        }
        private void confirmationPopUp(int num)
        {
            if(lang == "es")
            {
                MessageBox.Show("¡Gracias por su pedido! Se ha enviado un correo electrónico de confirmación a " + email + ".", $"Pedido {num} Confirmado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (lang == "fr")
            {
                MessageBox.Show("Merci pour votre commande ! Un e-mail de confirmation a été envoyé à " + email + ".", $"Commande {num} Confirmée", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Thank you for your order! A confirmation email has been sent to " + email + ".", $"Order {num} Confirmed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            var menu = Application.OpenForms
                .OfType<StartUp>()
                .FirstOrDefault();

            if (menu != null)
            {
                menu.Show();
            }
            this.Close();

            Menus.Cart.CartItems.Clear();
            checkoutForm.Close(); 
        }

        string translatePlaceholder(string placeholder)
        {
            if (lang == "es")
            {
                switch (placeholder)
                {
                    case "First Name":
                        return "Nombre";
                    case "Last Name":
                        return "Apellido";
                    case "Street Address":
                        return "Dirección";
                    case "Apt, Suite, etc. (optional)":
                        return "Apto, Suite, etc. (opcional)";
                    case "Phone Number":
                        return "Número de Teléfono";
                    case "ZIP Code":
                        return "Código Postal";
                    default:
                        return placeholder;
                }
            }
            else if (lang == "fr")
            {
                switch (placeholder)
                {
                    case "First Name":
                        return "Prénom";
                    case "Last Name":
                        return "Nom de Famille";
                    case "Street Address":
                        return "Adresse";
                    case "Apt, Suite, etc. (optional)":
                        return "Apt, Suite, etc. (optionnel)";
                    case "Phone Number":
                        return "Numéro de Téléphone";
                    case "ZIP Code":
                        return "Code Postal";
                    default:
                        return placeholder;
                }
            }
            else
            {
                return placeholder;
            }
        }

        private string translateMessage(string message)
        {
            if (lang == "es")
            {
                switch (message)
                {
                    case "Please enter a delivery address.":
                        return "Por favor, ingrese una dirección de entrega.";
                    case var msg when msg.StartsWith("Thank you for your order!"):
                        return "¡Gracias por su pedido! Se ha enviado un correo electrónico de confirmación a " + email + ".";
                    default:
                        return message;
                }
            }
            else if (lang == "fr")
            {
                switch (message)
                {
                    case "Please enter a delivery address.":
                        return "Veuillez entrer une adresse de livraison.";
                    case var msg when msg.StartsWith("Thank you for your order!"):
                        return "Merci pour votre commande ! Un e-mail de confirmation a été envoyé à " + email + ".";
                    default:
                        return message;
                }
            }
            else
            {
                return message;
            }
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
            addressTextBox.ForeColor = Color.Gray;
            aptTextBox.Text = "Apt, Suite, etc. (optional)";
            aptTextBox.ForeColor = Color.Gray;
            phoneTextBox.Text = "Phone Number";
            phoneTextBox.ForeColor = Color.Gray;
            ZIPTextBox.Text = "ZIP Code";
            ZIPTextBox.ForeColor = Color.Gray;

            // Translate placeholders
            firstNameTextBox.Text = translatePlaceholder(firstNameTextBox.Text);
            lastNameTextBox.Text = translatePlaceholder(lastNameTextBox.Text);
            addressTextBox.Text = translatePlaceholder(addressTextBox.Text);
            aptTextBox.Text = translatePlaceholder(aptTextBox.Text);
            phoneTextBox.Text = translatePlaceholder(phoneTextBox.Text);
            ZIPTextBox.Text = translatePlaceholder(ZIPTextBox.Text);


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
            aptTextBox.Clear();
            aptTextBox.ForeColor = Color.Black;
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
