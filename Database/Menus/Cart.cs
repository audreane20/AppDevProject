using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Menu;

namespace Menus
{
    public partial class Cart : MenuSetup.MenuSetup
    {
        //stores all cart items across the application
        public static List<CartItem> CartItems = new List<CartItem>();
        string lang = System.Threading.Thread.CurrentThread.CurrentUICulture.TwoLetterISOLanguageName;




        //constructor for the cart form
        public Cart()
        {
            InitializeComponent();
            LoadCartItems();
            this.DisableCartMenu();
        }

        //class that represents a main cart item
        public class CartItem
        {
            //stores the item name
            public string Name { get; set; }

            //stores how many of the item were ordered
            public int Quantity { get; set; }

            //stores the price of a single item
            public Double Price { get; set; }

            //stores the total price for this item
            public Double Subtotal { get; set; }

            //stores the category of the item
            public string Category { get; set; }

            //stores all add-ons attached to this item
            public List<AddOnItem> AddOns { get; set; } = new List<AddOnItem>();
            
        }

        //class that represents an add-on item
        public class AddOnItem
        {
            //stores the add-on name
            public string Name { get; set; }

            //stores how many of the add-on were selected
            public int Quantity { get; set; }
        }

        



        //loads all cart items into the listview
        private void LoadCartItems()
        {
            string lang = System.Threading.Thread.CurrentThread.CurrentUICulture.TwoLetterISOLanguageName;

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

        //    //loops through every item in the cart
        //    foreach (var item in CartItems)
        //    {
        //        //creates the main row for the item
        //        ListViewItem row = new ListViewItem(item.Name);

        //        //adds the quantity column
        //        row.SubItems.Add(item.Quantity.ToString());

        //        //adds the price column
        //        row.SubItems.Add("$" + item.Price.ToString("0.00"));

        //        //adds the subtotal column
        //        row.SubItems.Add("$" + item.Subtotal.ToString("0.00"));

        //        //attaches the full object to the row
        //        row.Tag = item;

        //        //assigns the correct category group
        //        switch (item.Category)
        //        {
        //            case "Cold Drinks":
        //                row.Group = coldGroup;
        //                break;

        //            case "Hot Drinks":
        //                row.Group = hotGroup;
        //                break;

        //            case "Pastries":
        //                row.Group = pastryGroup;
        //                break;
        //        }

        //        //adds the item row to the listview
        //        listViewCart.Items.Add(row);

        //        //loops through all add-ons under the item
        //        foreach (var addon in item.AddOns)
        //        {
        //            //creates the add-on row with indentation
        //            ListViewItem addonRow = new ListViewItem("   • " + addon.Name);

        //            //adds the add-on quantity
        //            addonRow.SubItems.Add(addon.Quantity.ToString());

        //            //adds empty columns to match format
        //            addonRow.SubItems.Add("");
        //            addonRow.SubItems.Add("");

        //            //sets the color to visually separate add-ons
        //            addonRow.ForeColor = Color.DarkSlateGray;

        //            //assigns the same group as its parent item
        //            addonRow.Group = row.Group;

        //            //attaches the add-on object to the row
        //            addonRow.Tag = addon;

        //            //adds the add-on row to the listview
        //            listViewCart.Items.Add(addonRow);
        //        }
        //    }

        //    //resumes drawing after updates are complete
        //    listViewCart.EndUpdate();

        //    //updates the total price label
        //    UpdateTotal();
        //}

        //refreshes the cart display
        public void ReloadCart()
        {
            LoadCartItems();
        }

        //calculates and updates the cart total
        private void UpdateTotal()
        {
            //stores the running total
            Double total = 0;

            //adds up all item subtotals
            foreach (var item in CartItems)
                total += item.Subtotal;

            //displays the final total
            lblTotal.Text = "Total: $" + total.ToString("0.00");
        }

        //runs when remove button is clicked
        private void btnRemove_Click(object sender, EventArgs e)
        {
            //prevents crashing if nothing is selected
            if (listViewCart.SelectedItems.Count == 0)
                return;

            //gets the selected row
            var selected = listViewCart.SelectedItems[0];

            //gets the attached cart item object
            var item = selected.Tag as CartItem;

            //removes the item from the cart list
            CartItems.Remove(item);

            //reloads the cart display
            LoadCartItems();
        }

        //runs when edit quantity button is clicked
        private void btnEditQuantity_Click(object sender, EventArgs e)
        {
            //prevents crashing if nothing is selected
            if (listViewCart.SelectedItems.Count == 0)
                return;

            //gets the selected row
            var selected = listViewCart.SelectedItems[0];

            //case 1 main drink or pastry item
            if (selected.Tag is CartItem item)
            {
                using (QuantityForm qf = new QuantityForm(item.Quantity))
                {
                    if (qf.ShowDialog() == DialogResult.OK)
                    {
                        //updates the item quantity
                        item.Quantity = qf.SelectedQuantity;

                        //recalculates the subtotal
                        item.Subtotal = item.Price * item.Quantity;

                        //reloads the cart display
                        LoadCartItems();
                    }
                }
            }

            //case 2 add-on item
            else if (selected.Tag is AddOnItem addon)
            {
                using (QuantityForm qf = new QuantityForm(addon.Quantity))
                {
                    if (qf.ShowDialog() == DialogResult.OK)
                    {
                        //updates the add-on quantity
                        addon.Quantity = qf.SelectedQuantity;

                        //reloads the cart display
                        LoadCartItems();
                    }
                }
            }
        }
    }
}
