using Osiguranje.Forme;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Osiguranje
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
            //ovo je da bude uvek isti font, jbg nece :(
            //Application.SetDefaultFont(new Font("Microsoft Sans Serif", 12F, FontStyle.Bold));
            Application.Run(new GlavnaForma());
        }
    }
}
