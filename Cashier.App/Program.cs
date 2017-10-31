using Cashier.Migration;
using System;
using System.Windows.Forms;
using Unity;
using Unity.ServiceLocation;

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

            UnityServiceLocator serviceLocator = new UnityServiceLocator(UnityConfig.GetConfiguredContainer());
            IMigrationRunner migrationRunner = serviceLocator.GetInstance<IMigrationRunner>();
            migrationRunner.Update();

            Application.Run(new FormMain());
        }
    }
}
