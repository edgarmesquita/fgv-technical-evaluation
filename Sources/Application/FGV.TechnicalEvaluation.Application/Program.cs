using System;
using Microsoft.Practices.Unity;

namespace FGV.TechnicalEvaluation.Application
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            System.Windows.Forms.Application.EnableVisualStyles();
            System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(false);
            System.Windows.Forms.Application.Run(UnityConfig.GetConfiguredContainer().Resolve<MainForm>());
        }
    }
}