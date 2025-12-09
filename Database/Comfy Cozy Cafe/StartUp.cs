using System; //gives access to core system features (basic C# functionality)
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing; //used for graphics, colors, fonts, and images
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; //needed for forms

namespace Comfy_Cozy_Cafe   //groups all café-related forms together
{
    //this class represents the STARTUP screen of application
    public partial class StartUp : Form
    {
        //these variables store the ORIGINAL button position & size,
        // so button can resize proportionally when the form is resized
        private float originalButtonX;        //original X position of the button
        private float originalButtonY;        //original Y position of the button
        private float originalButtonWidth;    //original width of the button
        private float originalButtonHeight;   //original height of the button

        //store original size of form
        private float originalFormWidth;
        private float originalFormHeight;

        //stores original font size of the button
        private float originalButtonFontSize;

        //constructor
        public StartUp()
        {
            InitializeComponent();  //loads all UI elements from the designer

            //connects the StartUp_Load method to the form's Load event
            this.Load += new System.EventHandler(this.StartUp_Load);

            //connects the resize event so the button scales correctly
            this.Resize += new System.EventHandler(this.Form1_Resize);
        }

        //runs when the START BUTTON is clicked
        private void StartButton_Click(object sender, EventArgs e)
        {
            //change the button background color(dark brown)
            StartButton.BackColor = System.Drawing.ColorTranslator.FromHtml("#3C1E02");

            //change the button text color(gold)
            StartButton.ForeColor = System.Drawing.ColorTranslator.FromHtml("#EBBA80");

            //open the first menu screen
            FirstMenu menu = new FirstMenu();
            menu.Show();   //display menu
        }

        //rRuns once when the StartUp form is first loaded
        private void StartUp_Load(object sender, EventArgs e)
        {
            //store the original form size
            originalFormWidth = this.Width;
            originalFormHeight = this.Height;

            //store original Start Button position & size
            originalButtonX = StartButton.Left;
            originalButtonY = StartButton.Top;
            originalButtonWidth = StartButton.Width;
            originalButtonHeight = StartButton.Height;

            //store original font size
            originalButtonFontSize = StartButton.Font.Size;
        }

        //runs ever time window is resized
        private void Form1_Resize(object sender, EventArgs e)
        {
            //safety check to avoid crashing
            if (originalFormWidth == 0 || originalFormHeight == 0)
                return;

            //calculate how much the form has grown or shrunk
            float xRatio = (float)this.Width / originalFormWidth;
            float yRatio = (float)this.Height / originalFormHeight;

            //resize and reposition the start button proportionally
            StartButton.Left = (int)(originalButtonX * xRatio);
            StartButton.Top = (int)(originalButtonY * yRatio);
            StartButton.Width = (int)(originalButtonWidth * xRatio);
            StartButton.Height = (int)(originalButtonHeight * yRatio);

            //scale font smoothly based on size change
            float fontScale = (xRatio + yRatio) / 2f;
            float newFontSize = originalButtonFontSize * fontScale;

            //prevent the font from becoming too small
            if (newFontSize < 6)
                newFontSize = 6;

            //apply the new scaled font
            StartButton.Font = new Font(
                StartButton.Font.FontFamily,
                newFontSize,
                StartButton.Font.Style
            );
        }

        //when ENGLISH is selected from the language menu
        private void englishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //save the user's language preference as English(Canada)
            Properties.Settings.Default.LanguageCode = "en-CA";
            Properties.Settings.Default.Save();

            //restart the application to apply changes
            Application.Restart();
        }

        //when FRENCH is selected from language menu
        private void francaisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //save the user's language preference as French(Canada)
            Properties.Settings.Default.LanguageCode = "fr-CA";
            Properties.Settings.Default.Save();

            //restart the app to apply the language change
            Application.Restart();
        }

        //when SPANISH is selected from language menu
        private void espanolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //save the user's language preference as Spanish
            Properties.Settings.Default.LanguageCode = "es";
            Properties.Settings.Default.Save();

            //restart the app so Spanish loads properly
            Application.Restart();
        }

        static StartUp()
        {
            // read saved language
            string lang = Properties.Settings.Default.LanguageCode;

            if (!string.IsNullOrEmpty(lang))
            {
                System.Threading.Thread.CurrentThread.CurrentUICulture =
                    new System.Globalization.CultureInfo(lang);

                System.Threading.Thread.CurrentThread.CurrentCulture =
                    new System.Globalization.CultureInfo(lang);
            }
        }

       
    }
}
