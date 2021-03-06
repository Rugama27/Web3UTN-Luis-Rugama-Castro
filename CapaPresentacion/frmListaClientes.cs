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
        List<tbCliente> lista;

        public INegocio<tbCliente> ClienteNegocio { get; }
        public IServiceProvider ServiceProvider { get; }

        public frmListaClientes(INegocio<tbCliente> _clienteNegocio, IServiceProvider serviceProvider)
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
            try
            {
               
                lista = ClienteNegocio.getAll();
                cargarListView(lista);
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void cargarListView(List<tbCliente> lista)
        {
            lstVista.Items.Clear();


            //lista = new List<tbCliente>();
            foreach (var cliente in lista)
            {
               
                ListViewItem item = new ListViewItem();
                item.Text = cliente.id;
                item.SubItems.Add(cliente.tbPersona.nombre.ToUpper());
                item.SubItems.Add(cliente.tbPersona.apellido1.ToUpper());
                item.SubItems.Add(cliente.tbPersona.apellido2.ToUpper());
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

        private void lstVista_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                var ident = lstVista.SelectedItems[0].Text;
                var cliente = lista.Where(x => x.id.Trim().Equals(ident.Trim())).SingleOrDefault();
                var form = ServiceProvider.GetRequiredService<frmClientes>();
                form.clienteGlobal = cliente;
                form.ShowDialog();

                obtenerDatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo cargar el cliente, contacte el Administrador", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pnlTitulo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lstVista_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text==String.Empty)
            {
                cargarListView(lista);

            }
            else
            {
                
              var listaFiltrada = lista.Where(x => x.id.Trim().ToUpper().Contains(textBox1.Text.Trim().ToUpper())
              || x.tbPersona.nombre.Trim().ToUpper().Contains(textBox1.Text.Trim().ToUpper())
              || x.tbPersona.apellido1.Trim().ToUpper().Contains(textBox1.Text.Trim().ToUpper())
              || x.tbPersona.apellido2.Trim().ToUpper().Contains(textBox1.Text.Trim().ToUpper())).ToList();
                cargarListView(listaFiltrada);


            }
        }
    }
}
