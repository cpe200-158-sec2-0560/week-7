using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace twozerofoureight
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            TwoZeroFourEightView game2048 = new TwoZeroFourEightView();
            game2048.Show();
            //Application.Run(new TwoZeroFourEightView());
            //Application.Run(new Form2());
            Application.Run();
        }
    }
}
