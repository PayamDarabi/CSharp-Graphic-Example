using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Graphic
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        public static int AsiabSpeed = 5;
        public static bool IsStarted = false;
        
       
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frm_MainMenu());
           
        }
    }
}
