using System;
using System.Windows.Forms;

namespace MenuSetup
{
    public partial class MenuSetup : Form
    {

        public MenuSetup()
        {
            InitializeComponent();
        }

        private void hotDrinksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hotDrinksToolStripMenuItem.Checked = true;
            coldDrinksToolStripMenuItem.Checked = false;
            pastriesToolStripMenuItem.Checked = false;

            //Hot_Drinks.HotDrinks hotDrinksForm = new Hot_Drinks.HotDrinks();
            //hotDrinksForm.Show();
            this.Close();
        }
        private void coldDrinksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hotDrinksToolStripMenuItem.Checked = false;
            coldDrinksToolStripMenuItem.Checked = true;
            pastriesToolStripMenuItem.Checked = false;

            //Cold_Drinks.ColdDrinks coldDrinksForm = new Cold_Drinks.ColdDrinks();
            //coldDrinksForm.Show();
            this.Close();
        }

        private void pastriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hotDrinksToolStripMenuItem.Checked = false;
            coldDrinksToolStripMenuItem.Checked = false;
            pastriesToolStripMenuItem.Checked = true;

            //Pastries.Pastries pastriesForm = new Pastries.Pastries();
            //pastriesForm.Show();
            this.Close();
        }
    }
}
