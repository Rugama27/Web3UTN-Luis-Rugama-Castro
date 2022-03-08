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
    public partial class frmPrincipal3 : Form
    {
        public IServiceProvider ServiceProvider { get; }

        public frmPrincipal3(IServiceProvider _serviceProvider)
        {
            InitializeComponent();
            ServiceProvider = _serviceProvider;
        }

        private void pcbCerrar_Click(object sender, EventArgs e)
        {
            //Cierra todo el aplicativo
            Application.Exit();
        }

        private void frmPrincipal3_Load(object sender, EventArgs e)
        {
            lblTitulo.Text = "UTN App";
        }

        private void pcbShow_Click(object sender, EventArgs e)
        {
            //Ocultar panel del menú cuando está desplegado
            if(pnlMenu.Width == 170)
            {
                //Cambia ancho a 0
                pnlMenu.Width = 0;
            }
            else
            {
                //Si es 0, está oculto, me lo pasa a 170, lo muestra
                pnlMenu.Width = 170;
            }
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            var form = ServiceProvider.GetRequiredService<frmListaClientes>();
            form.ShowDialog();
        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }
    }
}
