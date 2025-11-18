using System;
using System.Windows.Forms;

namespace FirstMenu
{
    public partial class FirstMenu : Form
    {
        public FirstMenu()
        {
            InitializeComponent();
        }

        private void hotDrinkIcon_Click(object sender, EventArgs e)
        {
            Hot_Drinks.HotDrinks hotDrinksForm = new Hot_Drinks.HotDrinks();
            hotDrinksForm.Show();
        }

        private void hotDrinksLabel_Click(object sender, EventArgs e)
        {
            Hot_Drinks.HotDrinks hotDrinksForm = new Hot_Drinks.HotDrinks();
            hotDrinksForm.Show();
        }

        private void coldDrinkIcon_Click(object sender, EventArgs e)
        {
            Cold_Drinks.ColdDrinks coldDrinksForm = new Cold_Drinks.ColdDrinks();
            coldDrinksForm.Show();
        }

        private void coldDrinkLabel_Click(object sender, EventArgs e)
        {
            Cold_Drinks.ColdDrinks coldDrinksForm = new Cold_Drinks.ColdDrinks();
            coldDrinksForm.Show();
        }

        private void pastriesIcon_Click(object sender, EventArgs e)
        {
            Pastries.Pastries pasteriesForm = new Pastries.Pastries();
            pasteriesForm.Show();
        }

        private void pastriesLabel_Click(object sender, EventArgs e)
        {
            Pastries.Pastries pasteriesForm = new Pastries.Pastries();
            pasteriesForm.Show();
        }
    }
}
