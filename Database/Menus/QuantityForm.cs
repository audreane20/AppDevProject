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
    public partial class QuantityForm : Form
    {
        //storesthe quantity value chosen by the user in this small popup form
        public int SelectedQuantity { get; private set; }

        //constructorreceives the current quantity so the numeric control can start at that value
        public QuantityForm(int currentQuantity)
        {
            InitializeComponent();

            //setsnumeric updown editvalue to show the current quantity when form opens
            EditValue.Value = currentQuantity;
        }

        //runswhen the ok button is clicked on the quantity form
        private void btnOK_Click_1(object sender, EventArgs e)
        {
            //readsthe number that the user selected from the numeric updown
            SelectedQuantity = (int)EditValue.Value;

            //setsthe dialogresult to ok so the parent form knows user confirmed the change
            this.DialogResult = DialogResult.OK;

            //closesthe quantity popup window
            this.Close();
        }
    }
}