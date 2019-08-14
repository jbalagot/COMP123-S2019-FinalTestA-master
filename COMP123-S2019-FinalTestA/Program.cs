using COMP123_S2019_FinalTestA.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
// to access files on the Objects folder
using COMP123_S2019_FinalTestA.Objects;
using System.Windows.Forms;

namespace COMP123_S2019_FinalTestA
{
    static class Program
    {
        public static HeroGenerator heroGenerator;
        public static HeroGenerator character = new HeroGenerator();

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            heroGenerator = new HeroGenerator();

            Application.Run(heroGenerator);
        }
    }
}
