using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Utilidades.Enumeradores;
using Entidades;
using CapaNegocio;
using Utilidades.Interfaces;
using Utilidades.Exceptions;
using Utilidades;

namespace CapaPresentacion
{
    public partial class frmClientes : Form
    {
        public clsCliente cliente { get; set; }

        //Acá se manda a llamar la capa de negocio de cliente - guardar
        public INegocio<clsCliente> ClienteNegocio { get; }

        public frmClientes(INegocio<clsCliente> _clienteNegocio)
        {
            InitializeComponent();
            ClienteNegocio = _clienteNegocio;
        }

        private void pcbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            bool isCorrect = validarDatos();

            try
            {
                //Permite validar el formulario y da paso a guardar
                if (isCorrect)
                {
                    //New desde 0
                    clsCliente cliente = new clsCliente();
                    cliente.identificacion = txtIdentificacion.Text.Trim().ToUpper();
                    cliente.tipoId = (int)cmbTipoId.SelectedValue;
                    cliente.nombre = txtNombre.Text.Trim().ToUpper();
                    cliente.apellido1 = txtApell1.Text.Trim().ToUpper();
                    cliente.apellido2 = txtApell2.Text.Trim().ToUpper();
                    cliente.tipoCliente = (int)cmbTipoCliente.SelectedValue;
                    cliente.fecha_socio = dtpFechaSocio.Value;
                    cliente.estado = true;

                    ClienteNegocio.save(cliente);
                    MessageBox.Show("Cliente guardado", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Close();
                }
            }
            catch (EntityExistException ex)
            {
                MessageBox.Show(ex.Message, "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo guardar, contacte el Administrador", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {
            if (cliente == null)
            {
                lblTitulo.Text = "Crear Cliente";
            }
            else
            {
                lblTitulo.Text = "Modificar Cliente";
                cargarForm();
                txtIdentificacion.Enabled = false;
                cmbTipoId.Enabled = false;
            }
            

            cargarCombos();

            cmbTipoCliente.SelectedIndex = 0;
            cmbTipoId.SelectedIndex = 0;
        }

        private void cargarForm()
        {
            txtIdentificacion.Text = cliente.identificacion;
            cmbTipoId.Text = Enum.GetName(typeof(Enumeradores.tipoId), cliente.tipoId);
            txtNombre.Text = cliente.nombre;
            txtApell1.Text = cliente.apellido1;
            txtApell2.Text = cliente.apellido2;
            cmbTipoCliente.Text = Enum.GetName(typeof(Enumeradores.tipoCliente), cliente.tipoCliente);
            dtpFechaSocio.Value = cliente.fecha_socio;
        }

        private void cargarCombos()
        {
            cmbTipoId.DataSource = Enum.GetValues(typeof(tipoId));
            cmbTipoCliente.DataSource = Enum.GetValues(typeof(tipoCliente));
        }

        private bool validarDatos()
        {
            if (txtIdentificacion.Text == string.Empty)
            {
                MessageBox.Show("Falta la Identificación","Faltan Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (txtNombre.Text == string.Empty)
            {
                MessageBox.Show("Falta el Nombre", "Faltan Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (txtApell1.Text == string.Empty)
            {
                MessageBox.Show("Falta el Primer Apellido", "Faltan Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (txtApell2.Text == string.Empty)
            {
                MessageBox.Show("Falta el Segundo Apellido", "Faltan Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void cmbTipoId_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
