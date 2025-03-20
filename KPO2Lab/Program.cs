using KPO2Lab.utils;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;


namespace KPO2Lab
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var services = new ServiceCollection();
            services.AddDbContext<AppDbContext>();

            var provider = services.BuildServiceProvider();
            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm(provider));
            
        }
    }
}