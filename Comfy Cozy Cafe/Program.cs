using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Threading;

namespace Comfy_Cozy_Cafe
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // Read saved language (en, fr, es) from user settings
            string lang = Properties.Settings.Default.LanguageCode;
            if (string.IsNullOrEmpty(lang))
            {
                lang = "en-CA"; // default to English
            }

            // Set culture for the UI
            CultureInfo culture = new CultureInfo(lang);
            Thread.CurrentThread.CurrentCulture = culture;
            Thread.CurrentThread.CurrentUICulture = culture;

            // Start the main form of your café project
           // Application.Run(new MainForm());
            Application.Run(new StartUp());
        }
    }
}
