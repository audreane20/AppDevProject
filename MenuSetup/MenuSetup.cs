using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

            Hot_Drinks.HotDrinks hotDrinksForm = new Hot_Drinks.HotDrinks();
            hotDrinksForm.Show();
        }
        private void coldDrinksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hotDrinksToolStripMenuItem.Checked = false;
            coldDrinksToolStripMenuItem.Checked = true;
            pastriesToolStripMenuItem.Checked = false;
            Cold_Drinks.ColdDrinks coldDrinksForm = new Cold_Drinks.ColdDrinks();
            coldDrinksForm.Show();
        }

        private void pastriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hotDrinksToolStripMenuItem.Checked = false;
            coldDrinksToolStripMenuItem.Checked = false;
            pastriesToolStripMenuItem.Checked = true;
            Pastries.Pastries pastriesForm = new Pastries.Pastries();
            pastriesForm.Show();
        }
    }
}
