using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
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

            FormLogin login = new FormLogin();
            FormHome logout = new FormHome();
            if (login.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new FormHome());
                
            }
            else
            {
                Application.Exit(); 
            }



        }
    }
}
