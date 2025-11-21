using System;
using System.Drawing;
using System.Windows.Forms;

namespace FirstMenu
{
    public partial class FirstMenu : Form
    {


        public FirstMenu()
        {
            InitializeComponent();
        }

        private void hotDrinkIcon_Click_1(object sender, EventArgs e)
        {
            Hot_Drinks.HotDrinks hotDrinksForm = new Hot_Drinks.HotDrinks();
            hotDrinksForm.Show();
            this.Close();
        }

        private void hotDrinksLabel_Click_1(object sender, EventArgs e)
        {
            Hot_Drinks.HotDrinks hotDrinksForm = new Hot_Drinks.HotDrinks();
            hotDrinksForm.Show();
            this.Close();
        }

        private void coldDrinkIcon_Click_1(object sender, EventArgs e)
        {
            Cold_Drinks.ColdDrinks coldDrinksForm = new Cold_Drinks.ColdDrinks();
            coldDrinksForm.Show();
            this.Close();
        }

        private void coldDrinkLabel_Click_1(object sender, EventArgs e)
        {
            Cold_Drinks.ColdDrinks coldDrinksForm = new Cold_Drinks.ColdDrinks();
            coldDrinksForm.Show();
            this.Close();   
        }

        private void pastriesIcon_Click_1(object sender, EventArgs e)
        {
            Pastries.Pastries pasteriesForm = new Pastries.Pastries();
            pasteriesForm.Show();
            this.Close();
        }

        private void pastriesLabel_Click_1(object sender, EventArgs e)
        {
            Pastries.Pastries pasteriesForm = new Pastries.Pastries();
            pasteriesForm.Show();
            this.Close();
        }

        
    }
}
