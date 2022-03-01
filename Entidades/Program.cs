using CapaDatos;
using CapaNegocio;
using Entidades;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utilidades.Interfaces;

namespace CapaPresentacion
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var services = new ServiceCollection();
            configureService(services);

            using (var ServiceProvider = services.BuildServiceProvider())
            {
                var form = ServiceProvider.GetRequiredService<frmPrincipal3>();
                form.ShowDialog();
            }
        }

        private static void configureService(ServiceCollection services)
        {
            /*
             * Trasient = Manejo de memoria dinámica, mantiene la memoria, si no se usa, se elimina
             * Scoped = Manejo de memoria mediante un ámbito como login
             * Singleton = Mantiene la memoria durante la ejecución del proyecto o servidor
             */

            //Inyecciones para formularios
            services.AddTransient<frmPrincipal3>();
            services.AddTransient<frmClientes>();
            services.AddTransient<frmListaClientes>();

            //Inyecciones para negocio
            services.AddSingleton<INegocio<clsCliente>, ClientesNegocio>();

            //Inyecciones para datos
            services.AddSingleton<IDatos<clsCliente>, ClientesDatos>();
        }
    }
}
