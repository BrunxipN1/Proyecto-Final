using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Serilog;

namespace Proyecto
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Log.Logger = new LoggerConfiguration().WriteTo.File("logs/log-.txt",
              rollingInterval: RollingInterval.Day,
              outputTemplate: "{Timestamp:yyyy-MM-dd HH:mm:ss} [{Level:u3}] {Message:lj}{NewLine}{Exception}")
            .CreateLogger();

            Log.Information("El logger ha sido inicializado con éxito");

            Application.ApplicationExit += (sender, e) =>
            {
                Log.CloseAndFlush();
            };

            try {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new WIniciarSesion());
            } 
            catch (Exception ex)
            {
                Log.Error("Program - Main:", ex.Message);
            }
            finally
            {
                Log.CloseAndFlush();
            }
        }
    }

}
