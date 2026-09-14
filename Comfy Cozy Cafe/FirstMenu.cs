using System; //gives access to basic system functions
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; //required for creating Windows Forms and GUI elements

namespace Comfy_Cozy_Cafe //namespace groups all related classes in your project
{
    //FIRST MAIN MENU window of your application
    public partial class FirstMenu : Form 
    {
        //constructor, runs automatically when the FirstMenu form opens
        public FirstMenu() 
        {
            //loads all buttons, images, labels, and UI design
            InitializeComponent(); 
        }

        //when the user clicks the COLD DRINK image icon
        private void ColdDrinkIcon_Click_1(object sender, EventArgs e) 
        {
            //creates new cold drink menu window
            Menus.ColdDrinksForm coldDrinksForm = new Menus.ColdDrinksForm(); 

            //show cold drinks window
            coldDrinksForm.Show(); 

            //close First Menu window so only one screen is open
            this.Close(); 
        }

        //when user clicks cold drink text label
        private void ColdDrinkLabel_Click(object sender, EventArgs e) 
        {
            //open cold drinks menu
            Menus.ColdDrinksForm coldDrinksForm = new Menus.ColdDrinksForm(); 

            //display form
            coldDrinksForm.Show(); 

            //close current menu
            this.Close(); 
        }

        //when user clicks pastry pic icon
        private void PastryIcon_Click(object sender, EventArgs e) 
        {
            //creates pasteries menu
            Menus.PastriesForm pasteriesForm = new Menus.PastriesForm(); 

            //show pasteries
            pasteriesForm.Show();

            //close menu 
            this.Close();
        }

        //when the user clicks the PASTRY text label
        private void PastryLabel_Click_1(object sender, EventArgs e)
        {
            //open pastries menu
            Menus.PastriesForm pasteriesForm = new Menus.PastriesForm();

            //show the form on the screen
            pasteriesForm.Show();

            //close the current menu
            this.Close();
        }

        //when the user clicks the HOT DRINK image icon
        private void HotDrinkIcon_Click(object sender, EventArgs e)
        {
            //create the Hot Drinks menu screen
            Menus.HotDrinksForm hotDrinksForm = new Menus.HotDrinksForm();

            //show the Hot Drinks menu
            hotDrinksForm.Show();

            //close the First Menu
            this.Close();
        }

        //when the user clicks the HOT DRINK text label
        private void HotDrinksLabel_Click(object sender, EventArgs e)
        {
            //open the hot drinks menu
            Menus.HotDrinksForm hotDrinksForm = new Menus.HotDrinksForm();

            //display the menu
            hotDrinksForm.Show();

            //close the current window
            this.Close();
        }
    }
}
