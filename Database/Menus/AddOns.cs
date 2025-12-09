using Menus;
using System;
using System.Drawing;
using System.Windows.Forms;



namespace Menus
{

    public partial class AddOns : Form
    {
        private string lang = System.Threading.Thread.CurrentThread.CurrentUICulture.TwoLetterISOLanguageName;

        //stores reference to the hot drinks form so we can go back to it
        private HotDrinksForm parentForm;

        //stores the quantity of the drink selected
        public int DrinkQuantity { get; private set; }

        //stores the main drink item that add-ons will be attached to
        public Cart.CartItem ParentDrink { get; set; }

        //constructor that receives parent form, drink, quantity, and image
        public AddOns(HotDrinksForm parent, Cart.CartItem drink, int quantity, Image chosenImage)
        {
            InitializeComponent();

            //saves reference to parent form
            parentForm = parent;

            //stores the selected drink item
            ParentDrink = drink;

            //stores the quantity selected
            DrinkQuantity = quantity;

            //sets the numeric selector to show selected quantity
            ItemAddOnsQTY.Value = quantity;

            //sets the image of the selected drink
            ChosenItemPic.Image = chosenImage;

            ApplyLanguage();
        }

        private void ApplyLanguage()
        {
            if (lang == "fr")
            {
                AddOnsAddToCart.Text = "Ajouter au panier";
                MilkLabel.Text = "Lait 2%";
                Cream1Label.Text = "Crème 10%";
                Cream2Label.Text = "Crème 18%";
                WhiteSugarLabel.Text = "Sucre blanc";
                BrownSugarLabel.Text = "Cassonade";
                SweetnerLabel.Text = "Édulcorant";
            }
            else if (lang == "es")
            {
                AddOnsAddToCart.Text = "Agregar al carrito";
                MilkLabel.Text = "Leche 2%";
                Cream1Label.Text = "Crema 10%";
                Cream2Label.Text = "Crema 18%";
                WhiteSugarLabel.Text = "Azúcar blanca";
                BrownSugarLabel.Text = "Azúcar morena";
                SweetnerLabel.Text = "Endulzante";
            }
            else
            {
                AddOnsAddToCart.Text = "Add to Cart";
                MilkLabel.Text = "Milk 2%";
                Cream1Label.Text = "Cream 10%";
                Cream2Label.Text = "Cream 18%";
                WhiteSugarLabel.Text = "White Sugar";
                BrownSugarLabel.Text = "Brown Sugar";
                SweetnerLabel.Text = "Sweetener";
            }
        }

        private string TranslateAddOn(string name)
        {
            if (lang == "fr")
            {
                if (name == "Milk 2%") return "Lait 2%";
                if (name == "Cream 10%") return "Crème 10%";
                if (name == "Cream 18%") return "Crème 18%";
                if (name == "White Sugar") return "Sucre blanc";
                if (name == "Brown Sugar") return "Cassonade";
                if (name == "Sweetner") return "Édulcorant";
            }
            else if (lang == "es")
            {
                if (name == "Milk 2%") return "Leche 2%";
                if (name == "Cream 10%") return "Crema 10%";
                if (name == "Cream 18%") return "Crema 18%";
                if (name == "White Sugar") return "Azúcar blanca";
                if (name == "Brown Sugar") return "Azúcar morena";
                if (name == "Sweetner") return "Endulzante";
            }
        return name; // default English
        }
        //property wrapper to allow getting and setting the chosen image
        public Image ChosenItemImage
        {
            get { return ChosenItemPic.Image; }
            set { ChosenItemPic.Image = value; }
        }

        private string T(string key)
        {
            string result = key;

            if (lang == "fr")
            {
                switch (key)
                {
                    case "Added": result = "Ajouté !"; break;
                    case "AddedTitle": result = "Succès"; break;
                }
                return result;
            }

            if (lang == "es")
            {
                switch (key)
                {
                    case "Added": result = "¡Añadido!"; break;
                    case "AddedTitle": result = "Éxito"; break;
                }
                return result;
            }

            // DEFAULT ENGLISH
            switch (key)
            {
                case "Added": result = "Added!"; break;
                case "AddedTitle": result = "Success"; break;
            }

            return result;
        }


        //runs when user clicks add-ons add to cart button
        private void AddOnsAddToCart_Click(object sender, EventArgs e)
        {
            // Add Milk
            if (MilkQTY.Value > 0)
                ParentDrink.AddOns.Add(new Cart.AddOnItem
                {
                    Name = TranslateAddOn("Milk 2%"),
                    Quantity = (int)MilkQTY.Value
                });

            // Add Cream 10%
            if (Cream10QTY.Value > 0)
                ParentDrink.AddOns.Add(new Cart.AddOnItem
                {
                    Name = TranslateAddOn("Cream 10%"),
                    Quantity = (int)Cream10QTY.Value
                });

            // Add Cream 18%
            if (Cream18QTY.Value > 0)
                ParentDrink.AddOns.Add(new Cart.AddOnItem
                {
                    Name = TranslateAddOn("Cream 18%"),
                    Quantity = (int)Cream18QTY.Value
                });

            // White sugar
            if (WhiteSugarQTY.Value > 0)
                ParentDrink.AddOns.Add(new Cart.AddOnItem
                {
                    Name = TranslateAddOn("White Sugar"),
                    Quantity = (int)WhiteSugarQTY.Value
                });

            // Brown sugar
            if (BrownSugarQTY.Value > 0)
                ParentDrink.AddOns.Add(new Cart.AddOnItem
                {
                    Name = TranslateAddOn("Brown Sugar"),
                    Quantity = (int)BrownSugarQTY.Value
                });

            // Sweetener
            if (SweetnerQTY.Value > 0)
                ParentDrink.AddOns.Add(new Cart.AddOnItem
                {
                    Name = TranslateAddOn("Sweetner"),
                    Quantity = (int)SweetnerQTY.Value
                });

            // Add the drink (with add-ons) to the cart
            Cart.CartItems.Add(ParentDrink);

            // Update cart if open
            foreach (Form f in Application.OpenForms)
                if (f is Cart cart)
                    cart.ReloadCart();

            parentForm.ResetForm();
            parentForm.EnableCartMenu();

            MessageBox.Show(T("Added"));


            this.Close();
        }
    }
}
