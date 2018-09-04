using ITSpecialProject.Views.Commons;
using System;
using System.Windows.Forms;
using DataLayer.Core.Model;
using ITSpecialProject.Views;
using ITSpecialProject.Views.Main;
using ITSpecialProject.Views.PointOfSale;

namespace ITSpecialProject
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
            //Application.Run(new MainView(new Account()));
            Application.Run(new LoginView());
        }
    }
}
