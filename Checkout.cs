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
using static Menus.Cart;
using static Menus.Checkout;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Menus
{
    public partial class Checkout : Form
    {
        string lang = System.Threading.Thread.CurrentThread.CurrentUICulture.TwoLetterISOLanguageName;
        Double total;
        public List<CartItem> CartItems => Menus.Cart.CartItems;
        public Checkout(double total)
        {
            InitializeComponent();
            this.total = total;
            LoadCartItems();
            
        }


        //loads all cart items into the listview
        private void LoadCartItems()
        {
   

            //prevents flickering while updating the list
            listViewCart.BeginUpdate();

            //clears all existing items
            listViewCart.Items.Clear();

            //clears all existing groups
            listViewCart.Groups.Clear();

            ListViewGroup coldGroup;
            ListViewGroup hotGroup;
            ListViewGroup pastryGroup;

            if (lang == "es")
            {
                coldGroup = new ListViewGroup("Bebidas Frías");
                hotGroup = new ListViewGroup("Bebidas Calientes");
                pastryGroup = new ListViewGroup("Pasteles");
            }
            else if (lang == "fr")
            {
                coldGroup = new ListViewGroup("Boissons Froides");
                hotGroup = new ListViewGroup("Boissons Chaudes");
                pastryGroup = new ListViewGroup("Pâtisseries");
            }
            else
            {
                coldGroup = new ListViewGroup("Cold Drinks");
                hotGroup = new ListViewGroup("Hot Drinks");
                pastryGroup = new ListViewGroup("Pastries");
            }

            //adds groups to the listview
            listViewCart.Groups.Add(coldGroup);
            listViewCart.Groups.Add(hotGroup);
            listViewCart.Groups.Add(pastryGroup);

            //get languages
            Dictionary<string, string> FrenchItems = new Dictionary<string, string>()
            {
                // ----------- Smoothies -----------
                { "Avocado Smoothie", "Smoothie à l'avocat" },
                { "Blueberry Smoothie", "Smoothie aux bleuets" },
                { "Mango Smoothie", "Smoothie à la mangue" },
                { "Strawberry Smoothie", "Smoothie à la fraise" },

                // ----------- Lemonades -----------
                { "Lemonade", "Limonade" },
                { "Frozen Lemonade", "Limonade glacée" },
                { "Orange Lemonade", "Limonade à l’orange" },
                { "Pink Lemonade", "Limonade rose" },

                // ----------- Frappuccinos -----------
                { "Original Frappuccino", "Frappuccino original" },
                { "Caramel Frappuccino", "Frappuccino caramel" },
                { "Chocolate Frappuccino", "Frappuccino chocolat" },

                // ----------- Iced Coffees -----------
                { "Original Iced Coffee", "Café glacé original" },
                { "Caramel Iced Coffee", "Café glacé caramel" },
                { "Chocolate Iced Coffee", "Café glacé au chocolat" },

                // ----------- Hot Chocolate -----------
                { "Hot Chocolate", "Chocolat chaud" },
                { "White Hot Chocolate", "Chocolat chaud blanc" },

                // ----------- Coffee -----------
                { "Coffee", "Café" },
                { "Latte", "Latte" },
                { "Cappuccino", "Cappuccino" },
                { "Americano", "Américano" },

                // ----------- Teas -----------
                { "Black Tea", "Thé noir" },
                { "Green Tea", "Thé vert" },
                { "Hibiscus Tea", "Thé à l'hibiscus" },
                { "Mint Tea", "Thé à la menthe" },
                { "Raspberry Tea", "Thé à la framboise" },

                // ----------- Classic Pastries -----------
                { "Croissant", "Croissant" },
                { "Chocolate Croissant", "Croissant au chocolat" },
                { "Chocolatine", "Chocolatine" },
                { "Blueberry Cheesecake Danish", "Danoise au fromage et bleuets" },

                // ----------- Danish Pastries -----------
                { "Clasic Danish", "Danoise classique" },
                { "Apple Danish", "Danoise aux pommes" },
                { "Blueberry Danish", "Danoise aux bleuets" },
                { "Pineapple Danish", "Danoise à l’ananas" },

                // ----------- Muffins -----------
                { "Blueberry Muffin", "Muffin aux bleuets" },
                { "Chocolate Chip Muffin", "Muffin aux pépites de chocolat" },
                { "Double Chocolate Muffin", "Muffin double chocolat" },
                { "Cranberry Orange Muffin", "Muffin canneberge-orange" },
                { "Caramel Banana Pecan Muffin", "Muffin caramel, banane et pacanes" }
            };



            Dictionary<string, string> SpanishItems = new Dictionary<string, string>()
            {
                // ----------- Smoothies -----------
                { "Avocado Smoothie", "Batido de aguacate" },
                { "Blueberry Smoothie", "Batido de arándanos" },
                { "Mango Smoothie", "Batido de mango" },
                { "Strawberry Smoothie", "Batido de fresa" },

                // ----------- Lemonades -----------
                { "Lemonade", "Limonada" },
                { "Frozen Lemonade", "Limonada helada" },
                { "Orange Lemonade", "Limonada de naranja" },
                { "Pink Lemonade", "Limonada rosa" },

                // ----------- Frappuccinos -----------
                { "Original Frappuccino", "Frappuccino original" },
                { "Caramel Frappuccino", "Frappuccino de caramelo" },
                { "Chocolate Frappuccino", "Frappuccino de chocolate" },

                // ----------- Iced Coffees -----------
                { "Original Iced Coffee", "Café helado original" },
                { "Caramel Iced Coffee", "Café helado de caramelo" },
                { "Chocolate Iced Coffee", "Café helado de chocolate" },

                // ----------- Hot Chocolate -----------
                { "Hot Chocolate", "Chocolate caliente" },
                { "White Hot Chocolate", "Chocolate blanco caliente" },

                // ----------- Coffee -----------
                { "Coffee", "Café" },
                { "Latte", "Latte" },
                { "Cappuccino", "Capuchino" },
                { "Americano", "Americano" },

                // ----------- Teas -----------
                { "Black Tea", "Té negro" },
                { "Green Tea", "Té verde" },
                { "Hibiscus Tea", "Té de hibisco" },
                { "Mint Tea", "Té de menta" },
                { "Raspberry Tea", "Té de frambuesa" },

                // ----------- Classic Pastries -----------
                { "Croissant", "Croissant" },
                { "Chocolate Croissant", "Croissant de chocolate" },
                { "Chocolatine", "Chocolatina" },
                { "Blueberry Cheesecake Danish", "Danish de queso y arándanos" },

                // ----------- Danish Pastries -----------
                { "Clasic Danish", "Danish clásico" },
                { "Apple Danish", "Danish de manzana" },
                { "Blueberry Danish", "Danish de arándanos" },
                { "Pineapple Danish", "Danish de piña" },

                // ----------- Muffins -----------
                { "Blueberry Muffin", "Muffin de arándanos" },
                { "Chocolate Chip Muffin", "Muffin con chispas de chocolate" },
                { "Double Chocolate Muffin", "Muffin doble chocolate" },
                { "Cranberry Orange Muffin", "Muffin de arándano y naranja" },
                { "Caramel Banana Pecan Muffin", "Muffin de caramelo, plátano y pacana" }
            };

            // SIZE TRANSLATION
            string TranslateSize(string size, string langCode)
            {
                string result = size;

                if (langCode == "fr")
                {
                    switch (size)
                    {
                        case "Small": result = "(Petit)"; break;
                        case "Medium": result = "(Moyen)"; break;
                        case "Large": result = "(Grand)"; break;
                    }
                }
                else if (langCode == "es")
                {
                    switch (size)
                    {
                        case "Small": result = "(Pequeño)"; break;
                        case "Medium": result = "(Mediano)"; break;
                        case "Large": result = "(Grande)"; break;
                    }
                }
                else
                {
                    // English fallback
                    result = "(" + size + ")";
                }

                return result;
            }



            foreach (var item in CartItems)
            {
                string name = item.Name;
                string baseName = name;
                string sizeText = "";

                // Detect size inside parentheses: Example → "Latte (Medium)"
                if (name.Contains("("))
                {
                    int idx = name.IndexOf("(");
                    baseName = name.Substring(0, idx).Trim();
                    sizeText = name.Substring(idx).Replace("(", "").Replace(")", "").Trim();
                }

                // Translate base name
                if (lang == "fr" && FrenchItems.ContainsKey(baseName))
                    baseName = FrenchItems[baseName];
                else if (lang == "es" && SpanishItems.ContainsKey(baseName))
                    baseName = SpanishItems[baseName];

                // Translate size
                if (!string.IsNullOrEmpty(sizeText))
                    sizeText = " " + TranslateSize(sizeText, lang);
                else
                    sizeText = "";

                // Final translated full name
                string translatedName = baseName + sizeText;

                // Create row
                ListViewItem row = new ListViewItem(translatedName);
                row.SubItems.Add(item.Quantity.ToString());
                row.SubItems.Add("$" + item.Price.ToString("0.00"));
                row.SubItems.Add("$" + item.Subtotal.ToString("0.00"));
                row.Tag = item;

                // Assign correct group
                switch (item.Category)
                {
                    case "Cold Drinks": row.Group = coldGroup; break;
                    case "Hot Drinks": row.Group = hotGroup; break;
                    case "Pastries": row.Group = pastryGroup; break;
                }

                listViewCart.Items.Add(row);

                // Add-ons translation
                foreach (var addon in item.AddOns)
                {
                    string addonName = addon.Name;

                    // Translate add-on if exists in dictionary
                    if (lang == "fr" && FrenchItems.ContainsKey(addonName))
                        addonName = FrenchItems[addonName];
                    if (lang == "es" && SpanishItems.ContainsKey(addonName))
                        addonName = SpanishItems[addonName];

                    ListViewItem addonRow = new ListViewItem("   • " + addonName);
                    addonRow.SubItems.Add(addon.Quantity.ToString());
                    addonRow.SubItems.Add("");
                    addonRow.SubItems.Add("");
                    addonRow.ForeColor = Color.DarkSlateGray;
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

        //private void menuItemsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        //{
        //    this.Validate();
        //    this.menuItemsBindingSource.EndEdit();
        //    this.tableAdapterManager.UpdateAll(this.comfyCafeDBDataSet);

        //}

        private void Checkout_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'comfyCafeDBDataSet.MenuItems' table. You can move, or remove it, as needed.
         //   this.menuItemsTableAdapter.Fill(this.comfyCafeDBDataSet.MenuItems);
            firstNameTextBox.Text = "First Name";
            lastNameTextBox.Text = "Last Name";
            emailTextBox.Text = "Email Address";
            addressTextBox.Text = "Billing Address";
            cardTextBox.Text = "Card Number";
            expirationTextBox.Text = "MM/YY";
            CVVTextBox.Text = "CVV";
            ZIPTextBox.Text = "ZIP Code";
            // Translate placeholders
            firstNameTextBox.Text = translatePlaceholder(firstNameTextBox.Text, lang);
            lastNameTextBox.Text = translatePlaceholder(lastNameTextBox.Text, lang);
            emailTextBox.Text = translatePlaceholder(emailTextBox.Text, lang);
            addressTextBox.Text = translatePlaceholder(addressTextBox.Text, lang);
            cardTextBox.Text = translatePlaceholder(cardTextBox.Text, lang);
            expirationTextBox.Text = translatePlaceholder(expirationTextBox.Text, lang);
            CVVTextBox.Text = translatePlaceholder(CVVTextBox.Text, lang);
            ZIPTextBox.Text = translatePlaceholder(ZIPTextBox.Text, lang);


            firstNameTextBox.ForeColor = Color.Gray;
            lastNameTextBox.ForeColor = Color.Gray;
            emailTextBox.ForeColor = Color.Gray;
            cardTextBox.ForeColor = Color.Gray;
            expirationTextBox.ForeColor = Color.Gray;
            CVVTextBox.ForeColor = Color.Gray;
            ZIPTextBox.ForeColor = Color.Gray;
            addressTextBox.ForeColor = Color.Gray;


        }

        private string translateMessage(string message)
        {
            if (lang== "fr")
            {
                switch (message)
                {
                    case "Please enter your first name.":
                        return "Veuillez entrer votre prénom.";
                    case "Please enter your last name.":
                        return "Veuillez entrer votre nom de famille.";
                    case "Please enter a valid email address.":
                        return "Veuillez entrer une adresse e-mail valide.";
                    case "Please enter a valid credit/debit card (16 digits).":
                        return "Veuillez entrer une carte de crédit/débit valide (16 chiffres).";
                    case "Please select a pickup or delivery option.":
                        return "Veuillez sélectionner une option de ramassage ou de livraison.";
                    default:
                        return message;
                }
            }
            else if (lang == "es")
            {
                switch (message)
                {
                    case "Please enter your first name.":
                        return "Por favor ingrese su nombre.";
                    case "Please enter your last name.":
                        return "Por favor ingrese su apellido.";
                    case "Please enter a valid email address.":
                        return "Por favor ingrese una dirección de correo electrónico válida.";
                    case "Please enter a valid credit/debit card (16 digits).":
                        return "Por favor ingrese una tarjeta de crédito/débito válida (16 dígitos).";
                    case "Please select a pickup or delivery option.":
                        return "Por favor seleccione una opción de recogida o entrega.";
                    default:
                        return message;
                }
            }
            else
            {
                return message;
            }
        }


        private void payButton_Click(object sender, EventArgs e)
        {
            // Name validation
            if (string.IsNullOrWhiteSpace(firstNameTextBox.Text) ||
                firstNameTextBox.Text == "First Name")
            {
                MessageBox.Show(translateMessage("Please enter your first name."));
                return;
            }

            if (string.IsNullOrWhiteSpace(lastNameTextBox.Text) || lastNameTextBox.Text == "Last Name")
            {
                MessageBox.Show(translateMessage("Please enter your last name."));
                return;
            }

            //Email validation
            string email = emailTextBox.Text;

            if (string.IsNullOrWhiteSpace(email) || !email.Contains("@") || !email.Contains("."))
            {
                MessageBox.Show(translateMessage("Please enter a valid email address."));
                return;
            }

            // Card validation
            string card = cardTextBox.Text.Replace(" ", "");

            if (card.Length != 16 || !card.All(char.IsDigit))
            {
                MessageBox.Show(translateMessage("Please enter a valid credit/debit card (16 digits)."));
                return;
            }

            //Option validation
            if (!pickupRadio.Checked && !deliveryRadio.Checked)
            {
                MessageBox.Show(translateMessage("Please select a pickup or delivery option."));
                return;
            }

            if (deliveryRadio.Checked)
            {
                total += total * 0.15;
                DeliveryForm deliveryForm = new DeliveryForm(this,emailTextBox.Text,generateOrderNumber());
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
            if (lang == "es")
            {
                MessageBox.Show("¡Gracias por su pedido! Se ha enviado un correo electrónico de confirmación a " + emailTextBox.Text + ".", $"Pedido {num} Confirmado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (lang == "fr")
            {
                MessageBox.Show("Merci pour votre commande ! Un e-mail de confirmation a été envoyé à " + emailTextBox.Text + ".", $"Commande {num} Confirmée", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Thank you for your order! A confirmation email has been sent to " + emailTextBox.Text + ".", $"Order {num} Confirmed", MessageBoxButtons.OK, MessageBoxIcon.Information);


            var menu = Application.OpenForms
                .OfType<StartUp>()
                .FirstOrDefault();

            if (menu != null)
            {
                menu.Show();
            }
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

        string translatePlaceholder(string placeholder, string langCode)
        {
            if (lang == "fr")
            {
                switch (placeholder)
                {
                    case "First Name":
                        return "Prénom";
                    case "Last Name":
                        return "Nom de famille";
                    case "Email Address":
                        return "Adresse e-mail";
                    case "Billing Address":
                        return "Adresse de facturation";
                    case "Card Number":
                        return "Numéro de carte";
                    case "MM/YY":
                        return "MM/AA";
                    case "CVV":
                        return "CVV";
                    case "ZIP Code":
                        return "Code postal";
                    default:
                        return "";
                }
            }
            else if (lang == "es")
            {
                switch (placeholder)
                {
                    case "First Name":
                        return "Nombre";
                    case "Last Name":
                        return "Apellido";
                    case "Email Address":
                        return "Dirección de correo electrónico";
                    case "Billing Address":
                        return "Dirección de facturación";
                    case "Card Number":
                        return "Número de tarjeta";
                    case "MM/YY":
                        return "MM/AA";
                    case "CVV":
                        return "CVV";
                    case "ZIP Code":
                        return "Código postal";
                    default:
                        return "";
                }
            }
            else
            {
                return placeholder;

            }
        }

        private void cardLabel_Click(object sender, EventArgs e)
        {

        }

        private void addressLabel_Click(object sender, EventArgs e)
        {

        }

        private void emailLabel_Click(object sender, EventArgs e)
        {

        }

        private void nameLabel_Click(object sender, EventArgs e)
        {

        }

        private void detailsLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
