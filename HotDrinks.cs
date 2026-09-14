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
    public partial class HotDrinksForm : MenuSetup.MenuSetup
    {
        //stores the picturebox of the currently selected hot drink image
        PictureBox selectedDrinkBox = null;

        //stores the label control for the selected drink (for example coffee, latte)
        Label selectedDrinkName = null;

        //stores the full drink name string used for price and cart text
        string selectedDrinkNamestring = null;

        //stores which size picturebox is selected
        PictureBox selectedSize = null;

        //stores text name of selected size (small, medium, large)
        string selectedSizeName = null;

        //stores which category user is currently in (coffee, hotchoco, tea)
        string currentCategory = null;

        //constructor runs when hot drinks form is created
        public HotDrinksForm()
        {
            InitializeComponent();
            UpdateCartMenuState();
        }

        private string T(string key)
        {
            string lang = System.Threading.Thread.CurrentThread.CurrentUICulture.TwoLetterISOLanguageName;

            // DEFAULT ENGLISH
            string result = key;

            if (lang == "en")
            {
                switch (key)
                {
                    case "MissingDrink": result = "Please select a drink first."; break;
                    case "MissingSize": result = "Please select a size first."; break;
                    case "Added": result = "Added to cart!"; break;
                }
                return result;
            }

            // FRENCH
            if (lang == "fr")
            {
                switch (key)
                {
                    case "MissingDrink": result = "Veuillez sélectionner une boisson."; break;
                    case "MissingSize": result = "Veuillez sélectionner une taille."; break;
                    case "Added": result = "Ajouté au panier !"; break;
                }
                return result;
            }

            // SPANISH
            if (lang == "es")
            {
                switch (key)
                {
                    case "MissingDrink": result = "Por favor seleccione una bebida."; break;
                    case "MissingSize": result = "Por favor seleccione un tamaño."; break;
                    case "Added": result = "¡Añadido al carrito!"; break;
                }
                return result;
            }

            return result;
        }

        //handles size selection for all hot drink categories
        private void SelectSize(PictureBox sizeBox)
        {
            //remove border from previous size selection (if any)
            if (selectedSize != null)
                selectedSize.BorderStyle = BorderStyle.None;

            //add border to show the newly selected size
            sizeBox.BorderStyle = BorderStyle.FixedSingle;

            //store reference to selected size control
            selectedSize = sizeBox;

            //check which group of size pictureboxes this selected one belongs to
            if (selectedSize != null)
            {
                //size is small for any drink type
                if (selectedSize == CoffeeSmall || selectedSize == HotChocoSmall || selectedSize == TeaSmall)
                {
                    selectedSizeName = "Small";
                }
                //size is medium for any drink type
                else if (selectedSize == CoffeeMed || selectedSize == HotChocoMed || selectedSize == TeaMed)
                {
                    selectedSizeName = "Medium";
                }
                //size is large for any drink type
                else if (selectedSize == CoffeeLarge || selectedSize == HotChocoLarge || selectedSize == TeaLarge)
                {
                    selectedSizeName = "Large";
                }
            }

            //after setting size, update on-screen price
            ItemPriceCalculation();
        }

        //calculates and updates the price based on drink, size, and quantity
        private void ItemPriceCalculation()
        {
            //if either drink or size is not chosen yet, do nothing
            if (selectedDrinkName == null || selectedSizeName == null)
                return;

            Double basePrice = 0;
            int sizePrice = 0;

            //determine base price and full name based on which drink picturebox is selected
            switch (selectedDrinkBox.Name)
            {
                case "HotChocoPic":
                    selectedDrinkNamestring = "Hot Chocolate";
                    basePrice = 2.25;
                    break;
                case "WhiteHotChocoPic":
                    selectedDrinkNamestring = "White Hot Chocolate";
                    basePrice = 2.50;
                    break;

                case "CoffeePic":
                    selectedDrinkNamestring = "Coffee";
                    basePrice = 1.50;
                    break;
                case "LattePic":
                    selectedDrinkNamestring = "Latte";
                    basePrice = 2.25;
                    break;
                case "CappuccinoPic":
                    selectedDrinkNamestring = "Cappuccino";
                    basePrice = 2.25;
                    break;
                case "AmericanoPic":
                    selectedDrinkNamestring = "Americano";
                    basePrice = 2.00;
                    break;

                case "BlackTeaPic":
                    selectedDrinkNamestring = "Black Tea";
                    basePrice = 1.75;
                    break;
                case "GreenTeaPic":
                    selectedDrinkNamestring = "Green Tea";
                    basePrice = 1.75;
                    break;
                case "HibiscusTeaPic":
                    selectedDrinkNamestring = "Hibiscus Tea";
                    basePrice = 1.95;
                    break;
                case "MintTeaPic":
                    selectedDrinkNamestring = "Mint Tea";
                    basePrice = 1.85;
                    break;
                case "RaspberryTeaPic":
                    selectedDrinkNamestring = "Raspberry Tea";
                    basePrice = 2.00;
                    break;
            }

            //determine extra cost added based on drink size
            switch (selectedSizeName)
            {
                case "Small": sizePrice = 0; break;
                case "Medium": sizePrice = 1; break;
                case "Large": sizePrice = 2; break;
            }

            //default quantity of drink is 1
            int qty = 1;

            //if hot chocolate category drink, use hot chocolate quantity control
            if (selectedDrinkNamestring == "Hot Chocolate" || selectedDrinkNamestring == "White Hot Chocolate")
            {
                qty = (int)HotChocoQTY.Value;
            }
            //if coffee style drink, use coffee quantity control
            else if (selectedDrinkNamestring == "Coffee" || selectedDrinkNamestring == "Latte" ||
                selectedDrinkNamestring == "Cappuccino" || selectedDrinkNamestring == "Americano")
            {
                qty = (int)CoffeeQTY.Value;
            }
            //if tea drink, use tea quantity control
            else if (selectedDrinkNamestring == "Black Tea" || selectedDrinkNamestring == "Green Tea" ||
                selectedDrinkNamestring == "Hibiscus Tea" || selectedDrinkNamestring == "Mint Tea" ||
                selectedDrinkNamestring == "Raspberry Tea")
            {
                qty = (int)TeaQTY.Value;
            }

            //calculate final total price for that selection
            Double totalPrice = (basePrice + sizePrice) * qty;

            //update the correct price label depending on drink type
            switch (selectedDrinkNamestring)
            {
                //coffee related drinks update coffee label
                case "Coffee":
                case "Latte":
                case "Cappuccino":
                case "Americano":
                    CoffeePriceLabel.Text = $"${totalPrice:0.00}";
                    break;

                //hot chocolate drinks update hot chocolate label
                case "Hot Chocolate":
                case "White Hot Chocolate":
                    HotChocoPriceLabel.Text = $"${totalPrice:0.00}";
                    break;

                //all tea types update tea price label
                case "Black Tea":
                case "Green Tea":
                case "Hibiscus Tea":
                case "Mint Tea":
                case "Raspberry Tea":
                    TeaPriceLabel.Text = $"${totalPrice:0.00}";
                    break;
            }
        }

        //resets all selections and ui elements on the hot drinks form
        public void ResetForm()
        {
            //if a drink image is selected, remove its border to clear selection
            if (selectedDrinkBox != null)
                selectedDrinkBox.BorderStyle = BorderStyle.None;

            //clear selected drink references and name values
            selectedDrinkBox = null;
            selectedDrinkName = null;
            selectedDrinkNamestring = null;

            //if a size is selected, remove its border
            if (selectedSize != null)
                selectedSize.BorderStyle = BorderStyle.None;

            //clear selected size references and name
            selectedSize = null;
            selectedSizeName = null;

            //reset current category since no drink is active
            currentCategory = null;

            //hide all group boxes that contain options for each category
            choicesGB1.Visible = false;
            choicehotChocoGB.Visible = false;
            choiceTeaGB.Visible = false;

            //reset numeric quantity controls back to 1 for all categories
            CoffeeQTY.Value = 1;
            HotChocoQTY.Value = 1;
            TeaQTY.Value = 1;

            //clear displayed price labels
            CoffeePriceLabel.Text = "";
            HotChocoPriceLabel.Text = "";
            TeaPriceLabel.Text = "";
        }

        //opens add-ons form for coffee group drinks
        private void CoffeeAddOns_Click_1(object sender, EventArgs e)
        {
            //if no size is chosen, user must select one before adding add-ons
            if (selectedSize == null)
            {
                MessageBox.Show(T("MissingSize"), T("MissingSizeTitle"),
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //get quantity value from coffee quantity control
            int qty = (int)CoffeeQTY.Value;

            double basePrice = 0;
            int sizePrice = 0;

            //determine base price based on which coffee drink is selected
            switch (selectedDrinkBox.Name)
            {
                case "CoffeePic": basePrice = 1.50; break;
                case "LattePic": basePrice = 2.25; break;
                case "CappuccinoPic": basePrice = 2.25; break;
                case "AmericanoPic": basePrice = 2.00; break;
            }

            //determine size price adjustment for coffee
            switch (selectedSizeName)
            {
                case "Small": sizePrice = 0; break;
                case "Medium": sizePrice = 1; break;
                case "Large": sizePrice = 2; break;
            }

            //final price for a single coffee
            double finalPrice = basePrice + sizePrice;

            //subtotal multiplies final price by quantity
            double subtotal = finalPrice * qty;

            //create a temporary parent drink item to hold add-ons
            Cart.CartItem tempParentDrink = new Cart.CartItem
            {
                //name includes size in parentheses
                Name = $"{selectedDrinkNamestring} ({selectedSizeName})",
                Quantity = qty,
                Price = finalPrice,
                Subtotal = subtotal,
                Category = "Hot Drinks"
            };

            //create add-ons form and pass reference to this hot drinks form and temporary cart item
            AddOns addonForm = new AddOns(
                this,
                tempParentDrink,
                qty,
                selectedDrinkBox.Image
            );

            //show add-ons window on top of hot drinks form
            addonForm.Show();
        }

        //opens add-ons form for tea drinks
        private void TeaAddOns_Click_1(object sender, EventArgs e)
        {
            //user must pick a size before choosing add-ons
            if (selectedSize == null)
            {
                MessageBox.Show(T("MissingSize"), T("MissingSizeTitle"),
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //quantity for tea drinks
            int qty = (int)TeaQTY.Value;

            double basePrice = 0;
            int sizePrice = 0;

            //set base price depending on which tea drink is selected
            switch (selectedDrinkBox.Name)
            {
                case "BlackTeaPic": basePrice = 1.75; break;
                case "GreenTeaPic": basePrice = 1.75; break;
                case "HibiscusTeaPic": basePrice = 1.95; break;
                case "MintTeaPic": basePrice = 1.85; break;
                case "RaspberryTeaPic": basePrice = 2.00; break;
            }

            //size price calculation for tea
            switch (selectedSizeName)
            {
                case "Small": sizePrice = 0; break;
                case "Medium": sizePrice = 1; break;
                case "Large": sizePrice = 2; break;
            }

            //final price for one tea drink
            double finalPrice = basePrice + sizePrice;

            //tea subtotal for all quantities
            double subtotal = finalPrice * qty;

            //create temporary parent drink item with current tea selection
            Cart.CartItem tempParentDrink = new Cart.CartItem
            {
                Name = $"{selectedDrinkNamestring} ({selectedSizeName})",
                Quantity = qty,
                Price = finalPrice,
                Subtotal = subtotal,
                Category = "Hot Drinks"
            };

            //create and show add-ons form for tea
            AddOns addonForm = new AddOns(
                this,
                tempParentDrink,
                qty,
                selectedDrinkBox.Image
            );

            addonForm.Show();
        }

        //resets only size selection (used when switching categories)
        private void ResetSizeSelection()
        {
            //if there was a selected size, remove its border
            if (selectedSize != null)
                selectedSize.BorderStyle = BorderStyle.None;

            //clear stored size info
            selectedSize = null;
            selectedSizeName = null;
        }

        //handles selecting a coffee drink (coffee, latte, cappuccino, americano)
        private void SelectCoffeeDrink(PictureBox drinkBox, Label drinkName)
        {
            //if current category changes to coffee, reset size selection
            if (currentCategory != "Coffee")
                ResetSizeSelection();

            //update current category text
            currentCategory = "Coffee";

            //remove border from previously selected drink if any
            if (selectedDrinkBox != null)
                selectedDrinkBox.BorderStyle = BorderStyle.None;

            //add border to show current selected coffee drink
            drinkBox.BorderStyle = BorderStyle.FixedSingle;

            //store selection references so we know which drink is being used
            selectedDrinkBox = drinkBox;
            selectedDrinkName = drinkName;

            //show coffee group and hide hot chocolate and tea groups
            choicesGB1.Visible = true;
            choicehotChocoGB.Visible = false;
            choiceTeaGB.Visible = false;
        }

        //handles selecting a hot chocolate drink
        private void SelectHotChocoDrink(PictureBox drinkBox, Label drinkName)
        {
            //if user switched to hot chocolate category, reset size selection
            if (currentCategory != "HotChoco")
                ResetSizeSelection();

            //set current category to hot chocolate
            currentCategory = "HotChoco";

            //remove border from previously selected drink
            if (selectedDrinkBox != null)
                selectedDrinkBox.BorderStyle = BorderStyle.None;

            //add border to selected hot chocolate drink
            drinkBox.BorderStyle = BorderStyle.FixedSingle;

            //store selected drink information
            selectedDrinkBox = drinkBox;
            selectedDrinkName = drinkName;

            //show hot chocolate options and hide other categories
            choicesGB1.Visible = false;
            choicehotChocoGB.Visible = true;
            choiceTeaGB.Visible = false;
        }

        //handles selecting a tea drink
        private void SelectTeaDrink(PictureBox drinkBox, Label drinkName)
        {
            //if switching to tea category, reset any size selection
            if (currentCategory != "Tea")
                ResetSizeSelection();

            //set current category to tea
            currentCategory = "Tea";

            //clear border from any previously selected drink
            if (selectedDrinkBox != null)
                selectedDrinkBox.BorderStyle = BorderStyle.None;

            //add border to currently selected tea image
            drinkBox.BorderStyle = BorderStyle.FixedSingle;

            //store reference for selected tea drink
            selectedDrinkBox = drinkBox;
            selectedDrinkName = drinkName;

            //show tea group and hide coffee/hot chocolate groups
            choicesGB1.Visible = false;
            choicehotChocoGB.Visible = false;
            choiceTeaGB.Visible = true;
        }

        //image click events for coffee category
        private void CoffeePic_Click_1(object sender, EventArgs e)
        {
            //select main coffee drink and recalculate price
            SelectCoffeeDrink(CoffeePic, CoffeeLabel);
            ItemPriceCalculation();
        }

        private void LattePic_Click_1(object sender, EventArgs e)
        {
            //select latte drink and recalculate price
            SelectCoffeeDrink(LattePic, LatteLabel);
            ItemPriceCalculation();
        }

        private void CappuccinoPic_Click_1(object sender, EventArgs e)
        {
            //select cappuccino drink and recalculate price
            SelectCoffeeDrink(CappuccinoPic, CappuccinoLabel);
            ItemPriceCalculation();
        }

        private void AmericanoPic_Click_1(object sender, EventArgs e)
        {
            //select americano drink and recalculate price
            SelectCoffeeDrink(AmericanoPic, AmericanoLabel);
            ItemPriceCalculation();
        }

        //image click events for hot chocolate category
        private void HotChocoPic_Click_1(object sender, EventArgs e)
        {
            //select hot chocolate and refresh price
            SelectHotChocoDrink(HotChocoPic, HotChocoLabel);
            ItemPriceCalculation();
        }

        private void WhiteHotChocoPic_Click_1(object sender, EventArgs e)
        {
            //select white hot chocolate and refresh price
            SelectHotChocoDrink(WhiteHotChocoPic, WhiteHotChocoLabel);
            ItemPriceCalculation();
        }

        //image click events for tea category
        private void BlackTeaPic_Click_1(object sender, EventArgs e)
        {
            //select black tea and recalc price
            SelectTeaDrink(BlackTeaPic, TeaBlackLabel);
            ItemPriceCalculation();
        }

        private void GreenTeaPic_Click_1(object sender, EventArgs e)
        {
            //select green tea and recalc price
            SelectTeaDrink(GreenTeaPic, TeaGreenLabel);
            ItemPriceCalculation();
        }

        private void HibiscusTeaPic_Click_1(object sender, EventArgs e)
        {
            //select hibiscus tea and recalc price
            SelectTeaDrink(HibiscusTeaPic, TeaHibiscusLabel);
            ItemPriceCalculation();
        }

        private void MintTeaPic_Click_1(object sender, EventArgs e)
        {
            //select mint tea and recalc price
            SelectTeaDrink(MintTeaPic, TeaMintLabel);
            ItemPriceCalculation();
        }

        private void RaspberryTeaPic_Click_1(object sender, EventArgs e)
        {
            //select raspberry tea and recalc price
            SelectTeaDrink(RaspberryTeaPic, TeaRaspberryLabel);
            ItemPriceCalculation();
        }

        //adds a coffee drink to the cart without add-ons
        private void CoffeeAddToCart_Click(object sender, EventArgs e)
        {
            //if no drink is selected, show warning
            if (selectedDrinkBox == null)
            {
                MessageBox.Show(T("MissingDrink"), T("MissingDrinkTitle"),
                MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }

            //if no size is selected, show warning
            if (selectedSize == null)
            {
                MessageBox.Show(T("MissingSize"), T("MissingSizeTitle"),
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //safe to calculate price and add to cart
            double basePrice = 0;
            int sizePrice = 0;

            //base price for coffee type based on which image was clicked
            switch (selectedDrinkBox.Name)
            {
                case "CoffeePic": basePrice = 1.50; break;
                case "LattePic": basePrice = 2.25; break;
                case "CappuccinoPic": basePrice = 2.25; break;
                case "AmericanoPic": basePrice = 2.00; break;
            }

            //size based price difference
            switch (selectedSizeName)
            {
                case "Small": sizePrice = 0; break;
                case "Medium": sizePrice = 1; break;
                case "Large": sizePrice = 2; break;
            }

            //quantity from coffee quantity numeric updown
            int qty = (int)CoffeeQTY.Value;

            //total price per single drink and subtotal for quantity
            double totalPrice = basePrice + sizePrice;
            double subtotal = totalPrice * qty;

            //create new cart item representing this selection
            Menus.Cart.AddOrUpdateCartItem(new Menus.Cart.CartItem
            {
                Name = $"{selectedDrinkNamestring} ({selectedSizeName})",
                Quantity = qty,
                Price = totalPrice,
                Subtotal = subtotal,
                Category = "Hot Drinks"
            });

            //enables cart menu so user can visit cart
            this.EnableCartMenu();

            //reset coffee quantity for next order
            CoffeeQTY.Value = 1;

            //show confirmation message
            MessageBox.Show(T("Added"));


            //reset form to default state
            ResetForm();
        }

        //adds a hot chocolate drink to the cart
        private void HotChocoAddToCart_Click(object sender, EventArgs e)
        {
            //check that a drink has been chosen
            if (selectedDrinkBox == null)
            {
                MessageBox.Show(T("MissingDrink"), T("MissingDrinkTitle"),
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //check that a size has been chosen
            if (selectedSize == null)
            {
                MessageBox.Show(T("MissingSize"), T("MissingSizeTitle"),
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //pricing variables
            double basePrice = 0;
            int sizePrice = 0;

            //base prices for hot chocolate drinks
            switch (selectedDrinkBox.Name)
            {
                case "HotChocoPic": basePrice = 2.25; break;
                case "WhiteHotChocoPic": basePrice = 2.50; break;
            }

            //apply size-based price adjustment
            switch (selectedSizeName)
            {
                case "Small": sizePrice = 0; break;
                case "Medium": sizePrice = 1; break;
                case "Large": sizePrice = 2; break;
            }

            //use hot chocolate quantity numeric updown
            int qty = (int)HotChocoQTY.Value;

            //calculate final drink price and subtotal
            double totalPrice = basePrice + sizePrice;
            double subtotal = totalPrice * qty;

            //add hot chocolate drink item to cart
            Menus.Cart.AddOrUpdateCartItem(new Menus.Cart.CartItem
            {
                Name = $"{selectedDrinkNamestring} ({selectedSizeName})",
                Quantity = qty,
                Price = totalPrice,
                Subtotal = subtotal,
                Category = "Hot Drinks"
            });

            //enable cart access
            this.EnableCartMenu();

            //reset hot chocolate quantity
            HotChocoQTY.Value = 1;

            //show confirmation to user
            MessageBox.Show(T("Added"));


            //reset entire form ui
            ResetForm();
        }

        //adds a tea drink selection to the cart
        private void TeaAddToCart_Click(object sender, EventArgs e)
        {
            //make sure a tea drink was selected
            if (selectedDrinkBox == null)
            {
                MessageBox.Show(T("MissingDrink"), T("MissingDrinkTitle"),
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //make sure a size was selected
            if (selectedSize == null)
            {
                MessageBox.Show(T("MissingSize"), T("MissingSizeTitle"),
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //variables for tea pricing
            double basePrice = 0;
            int sizePrice = 0;

            //determine base price based on specific tea type chosen
            switch (selectedDrinkBox.Name)
            {
                case "BlackTeaPic": basePrice = 1.75; break;
                case "GreenTeaPic": basePrice = 1.75; break;
                case "HibiscusTeaPic": basePrice = 1.95; break;
                case "MintTeaPic": basePrice = 1.85; break;
                case "RaspberryTeaPic": basePrice = 2.00; break;
            }

            //determine size price for tea
            switch (selectedSizeName)
            {
                case "Small": sizePrice = 0; break;
                case "Medium": sizePrice = 1; break;
                case "Large": sizePrice = 2; break;
            }

            //get quantity from tea numeric updown
            int qty = (int)TeaQTY.Value;

            //calculate full drink price and subtotal
            double totalPrice = basePrice + sizePrice;
            double subtotal = totalPrice * qty;

            //add tea item to cart
            Menus.Cart.AddOrUpdateCartItem(new Menus.Cart.CartItem
            {
                Name = $"{selectedDrinkNamestring} ({selectedSizeName})",
                Quantity = qty,
                Price = totalPrice,
                Subtotal = subtotal,
                Category = "Hot Drinks"
            });

            //enable cart in menu
            this.EnableCartMenu();

            //reset tea quantity for future orders
            TeaQTY.Value = 1;

            //let user know it was added
            MessageBox.Show(T("Added"));


            //reset complete form back to initial state
            ResetForm();
        }

        //size button events call common select size method

        private void TeaMed_Click(object sender, EventArgs e)
        {
            //user chose medium size for tea
            SelectSize(TeaMed);
        }

        private void CoffeeMed_Click(object sender, EventArgs e)
        {
            //user chose medium size for coffee
            SelectSize(CoffeeMed);
        }

        private void CoffeeLarge_Click(object sender, EventArgs e)
        {
            //user chose large size for coffee
            SelectSize(CoffeeLarge);
        }

        private void HotChocoSmall_Click(object sender, EventArgs e)
        {
            //user chose small size for hot chocolate
            SelectSize(HotChocoSmall);
        }

        private void HotChocoMed_Click(object sender, EventArgs e)
        {
            //user chose medium size for hot chocolate
            SelectSize(HotChocoMed);
        }

        private void HotChocoLarge_Click(object sender, EventArgs e)
        {
            //user chose large size for hot chocolate
            SelectSize(HotChocoLarge);
        }

        private void TeaLarge_Click(object sender, EventArgs e)
        {
            //user chose large size for tea
            SelectSize(TeaLarge);
        }

        private void CoffeeSmall_Click(object sender, EventArgs e)
        {
            //user chose small size for coffee
            SelectSize(CoffeeSmall);
        }

        private void TeaSmall_Click(object sender, EventArgs e)
        {
            //user chose small size for tea
            SelectSize(TeaSmall);
        }

        //quantity changed events recalculate price live

        private void CoffeeQTY_ValueChanged(object sender, EventArgs e)
        {
            //update coffee price when quantity changes
            ItemPriceCalculation();
        }

        private void HotChocoQTY_ValueChanged(object sender, EventArgs e)
        {
            //update hot chocolate price when quantity changes
            ItemPriceCalculation();
        }

        private void TeaQTY_ValueChanged(object sender, EventArgs e)
        {
            //update tea price when quantity changes
            ItemPriceCalculation();
        }
    }
}
