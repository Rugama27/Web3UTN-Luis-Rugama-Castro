using CapaNegocio;
using Entidades;
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
using Utilidades.Interfaces;

namespace CapaPresentacion
{
    public partial class frmListaClientes : Form
    {
        public INegocio<clsCliente> ClienteNegocio { get; }
        public IServiceProvider ServiceProvider { get; }

        public frmListaClientes(INegocio<clsCliente> _clienteNegocio, IServiceProvider serviceProvider)
        {
            InitializeComponent();
            ClienteNegocio = _clienteNegocio;
            ServiceProvider = serviceProvider;
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {
            lblTitulo.Text = "Mantenimiento de Clientes";
            obtenerDatos();
        }

        public void obtenerDatos()
        {
            var lista = ClienteNegocio.getAll();
            cargarListView(lista);
        }

        private void cargarListView(List<clsCliente> lista)
        {
            lstVista.Items.Clear();

            foreach (var cliente in lista)
            {
                ListViewItem item = new ListViewItem();
                item.Text = cliente.identificacion;
                item.SubItems.Add(cliente.nombre.ToUpper());
                item.SubItems.Add(cliente.apellido1.ToUpper());
                item.SubItems.Add(cliente.apellido2.ToUpper());
                lstVista.Items.Add(item);
            }
        }

        private void pcbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            var form = ServiceProvider.GetRequiredService<frmClientes>();
            form.ShowDialog();

            obtenerDatos();
        }
    }
}
