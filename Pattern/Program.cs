using Pattern.Presenters;
using Pattern.Wiews;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pattern
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
            //Application.Run(new Form1());


            var wiew = new MainWiew();
            var presenter = new MainPresenter(wiew);
            Application.Run(wiew);

        }
    }
}
