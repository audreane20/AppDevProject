using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Menus;

namespace MenuSetup
{
    public partial class MenuSetup : Form
    {
        //constructorfor the shared menu setup form that other forms inherit from
        public MenuSetup()
        {
            InitializeComponent();
        }

        //handlesclick when user selects hot drinks from the top menu
        private void HotDrinksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //showshot drinks as checked and unchecks other sections
            HotDrinksToolStripMenuItem.Checked = true;
            ColdDrinksToolStripMenuItem.Checked = false;
            PastriesToolStripMenuItem.Checked = false;

            //createsand opens the hot drinks form
            Menus.HotDrinksForm hotDrinksForm = new Menus.HotDrinksForm();
            hotDrinksForm.Show();

            //closesthe current form so only the new one stays open
            this.Close();
        }

        //handlesclick when user selects cold drinks from the top menu
        private void ColdDrinksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //updateswhich menu item is checked for visual feedback
            HotDrinksToolStripMenuItem.Checked = false;
            ColdDrinksToolStripMenuItem.Checked = true;
            PastriesToolStripMenuItem.Checked = false;

            //createsand opens the cold drinks form
            Menus.ColdDrinksForm coldDrinksForm = new Menus.ColdDrinksForm();
            coldDrinksForm.Show();

            //closesthe current form
            this.Close();
        }

        //handlesclick when user selects pastries from the top menu
        private void PastriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //setspastries menu item as checked and unchecks the others
            HotDrinksToolStripMenuItem.Checked = false;
            ColdDrinksToolStripMenuItem.Checked = false;
            PastriesToolStripMenuItem.Checked = true;

            //createsand opens the pastries form
            Menus.PastriesForm pastriesForm = new Menus.PastriesForm();
            pastriesForm.Show();

            //closesthe current form
            this.Close();
        }

        //enablescart and checkout menu items once something has been added to cart
        public void EnableCartMenu()
        {
            //enablescart so user can open cart window
            cartToolStripMenuItem.Enabled = true;

        }

        public void DisableCartMenu()
        {
            //enablescart so user can open cart window
            cartToolStripMenuItem.Enabled = false;

        }
        public void UpdateCartMenuState()
        {
            cartToolStripMenuItem.Enabled = Menus.Cart.CartItems.Count > 0;
        }


        //openscart window when cart menu item is clicked
        private void cartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var cartForm = Application.OpenForms
                .OfType<Menus.Cart>()
                .FirstOrDefault();

            if (cartForm == null)
                cartForm = new Menus.Cart();

            cartForm.Show();

            // CLOSE the current menu form
            this.Close();

        }



    }
}
