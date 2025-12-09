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
    public partial class PastriesForm : MenuSetup.MenuSetup
    {
        //storesthe currently selected pastry picturebox control
        PictureBox selectedPastryBox = null;

        //storesthe currently selected pastry label control
        Label selectedPastryName = null;

        //storesthe full pastry name string used for price and cart
        string selectedPastryNamestring = null;

        //constructorruns when the pastries form is created
        public PastriesForm()
        {
            InitializeComponent();
        }


        private string T(string key)
        {
            string lang = System.Threading.Thread.CurrentThread.CurrentUICulture.TwoLetterISOLanguageName;
            string result = key;

            // ENGLISH
            if (lang == "en")
            {
                switch (key)
                {
                    case "MissingPastry": result = "Please select a pastry first."; break;
                    case "MissingPastryTitle": result = "Missing Pastry"; break;

                    case "Added": result = "Added to cart!"; break;
                    case "AddedTitle": result = "Success"; break;
                }
                return result;
            }

            // FRENCH
            if (lang == "fr")
            {
                switch (key)
                {
                    case "MissingPastry": result = "Veuillez sélectionner une pâtisserie."; break;
                    case "MissingPastryTitle": result = "Pâtisserie manquante"; break;

                    case "Added": result = "Ajouté au panier !"; break;
                    case "AddedTitle": result = "Succès"; break;
                }
                return result;
            }

            // SPANISH
            if (lang == "es")
            {
                switch (key)
                {
                    case "MissingPastry": result = "Por favor seleccione una pastelería."; break;
                    case "MissingPastryTitle": result = "Pastelería faltante"; break;

                    case "Added": result = "¡Añadido al carrito!"; break;
                    case "AddedTitle": result = "Éxito"; break;
                }
                return result;
            }

            return result;
        }


        //handlesselecting a classic pastry (croissant type pastries)
        private void SelectClassicPastry(PictureBox drinkBox, Label drinkName)
        {
            //removeborder from previously selected pastry if there was one
            if (selectedPastryBox != null)
                selectedPastryBox.BorderStyle = BorderStyle.None;

            //addborder to the new classic pastry picture so the user sees selection
            drinkBox.BorderStyle = BorderStyle.FixedSingle;

            //savereferences to the selected pastry image and label
            selectedPastryBox = drinkBox;
            selectedPastryName = drinkName;

            //showonly the classic pastry groupbox and hide others
            ClassicGB.Visible = true;
            DanishGB.Visible = false;
            MuffinGB.Visible = false;
        }

        //handlesselecting a danish pastry
        private void SelectDanishPastry(PictureBox drinkBox, Label drinkName)
        {
            //removeborder from previously selected pastry
            if (selectedPastryBox != null)
                selectedPastryBox.BorderStyle = BorderStyle.None;

            //addborder to the selected danish pastry
            drinkBox.BorderStyle = BorderStyle.FixedSingle;

            //savethe selected pastry controls
            selectedPastryBox = drinkBox;
            selectedPastryName = drinkName;

            //showonly the danish group and hide classic and muffin
            ClassicGB.Visible = false;
            DanishGB.Visible = true;
            MuffinGB.Visible = false;
        }

        //handlesselecting a muffin pastry
        private void SelectMuffinPastry(PictureBox drinkBox, Label drinkName)
        {
            //removeborder from previously selected pastry
            if (selectedPastryBox != null)
                selectedPastryBox.BorderStyle = BorderStyle.None;

            //addborder to the newly selected muffin pastry
            drinkBox.BorderStyle = BorderStyle.FixedSingle;

            //savethe selected image and label
            selectedPastryBox = drinkBox;
            selectedPastryName = drinkName;

            //showonly the muffin group and hide other groups
            ClassicGB.Visible = false;
            DanishGB.Visible = false;
            MuffinGB.Visible = true;
        }

        //calculatesand updates the total price for the chosen pastry and quantity
        private void ItemPriceCalculation()
        {
            //ifnothing is selected yet, do not calculate
            if (selectedPastryName == null)
                return;

            Double basePrice = 0;

            //decidewhich pastry is selected and assign its base price and name
            switch (selectedPastryBox.Name)
            {
                case "CroissantPic":
                    selectedPastryNamestring = "Croissant";
                    basePrice = 1.75;
                    break;
                case "ChocoCroissantPic":
                    selectedPastryNamestring = "Chocolate Croissant";
                    basePrice = 2.00;
                    break;
                case "ChocolatinePic":
                    selectedPastryNamestring = "Chocolatine";
                    basePrice = 1.75;
                    break;
                case "BlueberryCheesecakeDanishPic":
                    selectedPastryNamestring = "Blueberry Cheesecake Danish";
                    basePrice = 3.25;
                    break;

                case "DanishPic":
                    selectedPastryNamestring = "Clasic Danish";
                    basePrice = 2.25;
                    break;
                case "AppleDanishPic":
                    selectedPastryNamestring = "Apple Danish";
                    basePrice = 2.50;
                    break;
                case "BlueberryDanishPic":
                    selectedPastryNamestring = "Blueberry Danish";
                    basePrice = 2.50;
                    break;
                case "PineappleDanishPic":
                    selectedPastryNamestring = "Pineapple Danish";
                    basePrice = 3.00;
                    break;

                case "BlueberryMuffinPic":
                    selectedPastryNamestring = "Blueberry Muffin";
                    basePrice = 1.95;
                    break;
                case "ChocoChipMuffinPic":
                    selectedPastryNamestring = "Chocolate Chip Muffin";
                    basePrice = 2.00;
                    break;
                case "DBLChocoMuffinPic":
                    selectedPastryNamestring = "Double Chocolate Muffin";
                    basePrice = 2.15;
                    break;
                case "CranOrangeMuffinPic":
                    selectedPastryNamestring = "Cranberry Orange Muffin";
                    basePrice = 1.75;
                    break;
                case "CarmBanPecMuffinPic":
                    selectedPastryNamestring = "Caramel Banana Pecan Muffin";
                    basePrice = 3.25;
                    break;

            }

            //defaultquantity of pastry
            int qty = 1;

            //decidewhich numeric updown to read based on selected pastry group
            if (selectedPastryNamestring == "Croissant" || selectedPastryNamestring == "Chocolate Croissant" ||
                selectedPastryNamestring == "Chocolatine" || selectedPastryNamestring == "Blueberry Cheesecake Danish")
            {
                //classicpastries quantity
                qty = (int)PastriesQTY.Value;
            }
            else if (selectedPastryNamestring == "Clasic Danish" || selectedPastryNamestring == "Apple Danish" ||
                selectedPastryNamestring == "Blueberry Danish" || selectedPastryNamestring == "Pineapple Danish")
            {
                //danishquantity
                qty = (int)DanishQTY.Value;
            }
            else if (selectedPastryNamestring == "Blueberry Muffin" || selectedPastryNamestring == "Chocolate Chip Muffin" ||
                selectedPastryNamestring == "Double Chocolate Muffin" || selectedPastryNamestring == "Cranberry Orange Muffin" ||
                selectedPastryNamestring == "Caramel Banana Pecan Muffin")
            {
                //muffinquantity
                qty = (int)MuffinQTY.Value;
            }

            //finaltotal price for selected pastry type
            Double totalPrice = basePrice * qty;

            //showresult in correct label depending on pastry category
            switch (selectedPastryNamestring)
            {
                //classicpastries
                case "Croissant":
                case "Chocolate Croissant":
                case "Chocolatine":
                case "Blueberry Cheesecake Danish":
                    ClassicPastryPriceLabel.Text = $"${totalPrice:0.00}";
                    break;

                //danishpastries
                case "Clasic Danish":
                case "Apple Danish":
                case "Blueberry Danish":
                case "Pineapple Danish":
                    DanishPriceLabel.Text = $"${totalPrice:0.00}";
                    break;

                //muffinpastries
                case "Blueberry Muffin":
                case "Chocolate Chip Muffin":
                case "Double Chocolate Muffin":
                case "Cranberry Orange Muffin":
                case "Caramel Banana Pecan Muffin":
                    MuffinPriceLabel.Text = $"${totalPrice:0.00}";
                    break;
            }
        }

        //imageclick events for all classic pastries
        private void CroissantPic_Click_1(object sender, EventArgs e)
        {
            //selectcroissant pastry and recalc price
            SelectClassicPastry(CroissantPic, CroissantLabel);
            ItemPriceCalculation();
        }

        private void ChocoCroissantPic_Click_1(object sender, EventArgs e)
        {
            //selectchocolate croissant and recalc price
            SelectClassicPastry(ChocoCroissantPic, ChocoCroissantLabel);
            ItemPriceCalculation();
        }

        private void ChocolatinePic_Click_1(object sender, EventArgs e)
        {
            //selectchocolatine and recalc price
            SelectClassicPastry(ChocolatinePic, ChocolatineLabel);
            ItemPriceCalculation();
        }

        private void BlueberryCheesecakeDanishPic_Click_1(object sender, EventArgs e)
        {
            //selectblueberry cheesecake danish and recalc price
            SelectClassicPastry(BlueberryCheesecakeDanishPic, BlueberryCheesecakeDanishLabel);
            ItemPriceCalculation();
        }

        //imageclick events for danish pastries
        private void DanishPic_Click_1(object sender, EventArgs e)
        {
            //selectclassic danish and recalc price
            SelectDanishPastry(DanishPic, DanishLabel);
            ItemPriceCalculation();
        }

        private void AppleDanishPic_Click_1(object sender, EventArgs e)
        {
            //selectapple danish and recalc price
            SelectDanishPastry(AppleDanishPic, AppleDanishLabel);
            ItemPriceCalculation();
        }

        private void BlueberryDanishPic_Click_1(object sender, EventArgs e)
        {
            //selectblueberry danish and recalc price
            SelectDanishPastry(BlueberryDanishPic, BlueberryDanishLabel);
            ItemPriceCalculation();
        }

        private void PineappleDanishPic_Click_1(object sender, EventArgs e)
        {
            //selectpineapple danish and recalc price
            SelectDanishPastry(PineappleDanishPic, PineappleDanishLabel);
            ItemPriceCalculation();
        }

        //imageclick events for muffin pastries
        private void BlueberryMuffinPic_Click_1(object sender, EventArgs e)
        {
            //selectblueberry muffin and recalc price
            SelectMuffinPastry(BlueberryMuffinPic, BlueberryMuffinLabel);
            ItemPriceCalculation();
        }

        private void ChocoChipMuffinPic_Click_1(object sender, EventArgs e)
        {
            //selectchocolate chip muffin and recalc price
            SelectMuffinPastry(ChocoChipMuffinPic, ChocoChipMuffinLabel);
            ItemPriceCalculation();
        }

        private void DBLChocoMuffinPic_Click_1(object sender, EventArgs e)
        {
            //selectdouble chocolate muffin and recalc price
            SelectMuffinPastry(DBLChocoMuffinPic, DBLChocoMuffinLabel);
            ItemPriceCalculation();
        }

        private void CranOrangeMuffinPic_Click_1(object sender, EventArgs e)
        {
            //selectcranberry orange muffin and recalc price
            SelectMuffinPastry(CranOrangeMuffinPic, CranOrangeMuffinLabel);
            ItemPriceCalculation();
        }

        private void CarmBanPecMuffinPic_Click_1(object sender, EventArgs e)
        {
            //selectcaramel banana pecan muffin and recalc price
            SelectMuffinPastry(CarmBanPecMuffinPic, CarmBanPecMuffinLabel);
            ItemPriceCalculation();
        }

        //quantitychange events so total price updates when quantity changes

        private void PastriesQTY_ValueChanged(object sender, EventArgs e)
        {
            //recalculateprice for classic pastries
            ItemPriceCalculation();
        }

        private void DanishQTY_ValueChanged(object sender, EventArgs e)
        {
            //recalculateprice for danish pastries
            ItemPriceCalculation();
        }

        private void MuffinQTY_ValueChanged(object sender, EventArgs e)
        {
            //recalculateprice for muffin pastries
            ItemPriceCalculation();
        }

        //resetsthe pastry form back to its initial state
        private void ResetPastryForm()
        {
            //removeborder from selected pastry image if any
            if (selectedPastryBox != null)
                selectedPastryBox.BorderStyle = BorderStyle.None;
            selectedPastryBox = null;

            //resetstored pastry name references
            selectedPastryName = null;
            selectedPastryNamestring = null;

            //resetall quantity controls back to 1
            PastriesQTY.Value = 1;
            DanishQTY.Value = 1;
            MuffinQTY.Value = 1;

            //clearall price labels on the screen
            ClassicPastryPriceLabel.Text = "";
            DanishPriceLabel.Text = "";
            MuffinPriceLabel.Text = "";

            //hideall pastry groupboxes so nothing appears selected
            ClassicGB.Visible = false;
            DanishGB.Visible = false;
            MuffinGB.Visible = false;
        }

        //addsa classic pastry item to the global cart list
        private void PastriesAddToCart_Click(object sender, EventArgs e)
        {
            //classicpastries use their fixed base price
            double basePrice = 0;

            //decidebase price based on classic pastry name
            switch (selectedPastryNamestring)
            {
                case "Croissant": basePrice = 1.75; break;
                case "Chocolate Croissant": basePrice = 2.00; break;
                case "Chocolatine": basePrice = 1.75; break;
                case "Blueberry Cheesecake Danish": basePrice = 3.25; break;
            }

            //readquantity from classic pastry numeric updown
            int qty = (int)PastriesQTY.Value;

            //eachpastry is base price, subtotal is price times quantity
            double totalPrice = basePrice;
            double subtotal = totalPrice * qty;

            //createcart item for classic pastry and add it to shared cart list
            Menus.Cart.CartItems.Add(new Menus.Cart.CartItem
            {
                Name = selectedPastryNamestring,
                Quantity = qty,
                Price = totalPrice,
                Subtotal = subtotal,
                Category = "Pastries"
            });

            //enablecart menu so user can open cart
            this.EnableCartMenu();

            //resetquantity back to 1
            PastriesQTY.Value = 1;

            //showconfirmation message
            MessageBox.Show(T("Added"));

            //resetform to clear selection and ui
            ResetPastryForm();
        }

        //addsa danish pastry item to the cart
        private void DanishAddToCart_Click(object sender, EventArgs e)
        {
            //danishpastries use their specific base prices
            double basePrice = 0;

            //decidebase price depending on which danish type was selected
            switch (selectedPastryNamestring)
            {
                case "Clasic Danish": basePrice = 2.25; break;
                case "Apple Danish": basePrice = 2.50; break;
                case "Blueberry Danish": basePrice = 2.50; break;
                case "Pineapple Danish": basePrice = 3.00; break;
            }

            //readquantity for danish pastries
            int qty = (int)DanishQTY.Value;

            //calculateprice for one danish and subtotal for all
            double totalPrice = basePrice;
            double subtotal = totalPrice * qty;

            //createcart item and add it to global cart
            Menus.Cart.CartItems.Add(new Menus.Cart.CartItem
            {
                Name = selectedPastryNamestring,
                Quantity = qty,
                Price = totalPrice,
                Subtotal = subtotal,
                Category = "Pastries"
            });

            //enablecart
            this.EnableCartMenu();

            //resetdanish quantity
            DanishQTY.Value = 1;

            //letuser know item was added
            MessageBox.Show(T("Added"));

            //resetall pastry selection and ui
            ResetPastryForm();
        }

        //addsa muffin pastry item to the cart
        private void MuffinAddToCart_Click(object sender, EventArgs e)
        {
            //muffinsuse their own base price
            double basePrice = 0;

            //setbase price based on specific muffin type
            switch (selectedPastryNamestring)
            {
                case "Blueberry Muffin": basePrice = 1.95; break;
                case "Chocolate Chip Muffin": basePrice = 2.00; break;
                case "Double Chocolate Muffin": basePrice = 2.15; break;
                case "Cranberry Orange Muffin": basePrice = 1.75; break;
                case "Caramel Banana Pecan Muffin": basePrice = 3.25; break;
            }

            //readquantity for muffins
            int qty = (int)MuffinQTY.Value;

            //priceper muffin and subtotal
            double totalPrice = basePrice;
            double subtotal = totalPrice * qty;

            //addmuffin item to shared cart list
            Menus.Cart.CartItems.Add(new Menus.Cart.CartItem
            {
                Name = selectedPastryNamestring,
                Quantity = qty,
                Price = totalPrice,
                Subtotal = subtotal,
                Category = "Pastries"
            });

            //enablecart menu item
            this.EnableCartMenu();

            //resetmuffin quantity for next selection
            MuffinQTY.Value = 1;

            //showconfirmation
            MessageBox.Show(T("Added"));


            //resetform back to initial state
            ResetPastryForm();
        }
    }
}
