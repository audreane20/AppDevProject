using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ComfyCozyCafe
{

    public partial class Startup : Form
    {

        private float originalButtonX;
        private float originalButtonY;
        private float originalButtonWidth;
        private float originalButtonHeight;
        private float originalFormWidth;
        private float originalFormHeight;
        private float originalButtonFontSize;
        public Startup()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            startButton.BackColor = System.Drawing.ColorTranslator.FromHtml("#3C1E02");
            startButton.ForeColor = System.Drawing.ColorTranslator.FromHtml("#EBBA80");
            FirstMenu.FirstMenu menu = new FirstMenu.FirstMenu();
            menu.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            originalFormWidth = this.Width;
            originalFormHeight = this.Height;
            originalButtonX = startButton.Left;
            originalButtonY = startButton.Top;
            originalButtonWidth = startButton.Width;
            originalButtonHeight = startButton.Height;
            originalButtonFontSize = startButton.Font.Size;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (originalFormWidth == 0 || originalFormHeight == 0)
                return; 

            float xRatio = (float)this.Width / originalFormWidth;
            float yRatio = (float)this.Height / originalFormHeight;

            startButton.Left = (int)(originalButtonX * xRatio);
            startButton.Top = (int)(originalButtonY * yRatio);
            startButton.Width = (int)(originalButtonWidth * xRatio);
            startButton.Height = (int)(originalButtonHeight * yRatio);

            float fontScale = (xRatio + yRatio) / 2f;
            float newFontSize = originalButtonFontSize * fontScale;

            if (newFontSize < 6) newFontSize = 6; 
            startButton.Font = new Font(startButton.Font.FontFamily, newFontSize, startButton.Font.Style);
        }
    }
}
