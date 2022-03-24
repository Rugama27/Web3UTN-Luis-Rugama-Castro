using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class frmProductos : Form

    {
        public IServiceProvider ServiceProvider { get;}
        public frmProductos(IServiceProvider _serviceProvider)
        {
            InitializeComponent();
            ServiceProvider = _serviceProvider;
        }

   

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            var form = ServiceProvider.GetRequiredService<frmBusquedaProductos>();
            form.pasarDatosEvent+= DatosRecibidos;
            form.ShowDialog();

        }
        private void DatosRecibidos(string nombre)
        {
            lblNombre.Text = nombre;    

        }
    }
}
