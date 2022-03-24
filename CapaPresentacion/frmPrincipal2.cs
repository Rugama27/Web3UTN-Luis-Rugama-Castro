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
    public partial class frmPrincipal2 : Form
    {
        public frmPrincipal2(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            ServiceProvider = serviceProvider;
        }

        public IServiceProvider ServiceProvider { get; }

        /// <summary>
        /// 
        /// Evento CLick del menú cliente, muestra el formulario cliente
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mnuClientes_Click(object sender, EventArgs e)
        {

            var form = ServiceProvider.GetRequiredService<frmListaClientes>();
            form.ShowDialog();
        }
    }
}
