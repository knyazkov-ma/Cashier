using Cashier.Migration;
using System;
using System.Windows.Forms;
using Unity;

namespace Cashier.App
{
    static class Program
    {
        static UnityContainer unityContainer = new UnityContainer();
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


            UnityConfig.RegisterTypes(unityContainer);

            IMigrationRunner migrationRunner = unityContainer.Resolve<IMigrationRunner>();
            migrationRunner.Update();

            Application.Run(unityContainer.Resolve<FormMain>());
        }
    }
}
