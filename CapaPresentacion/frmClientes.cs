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
        bool isNew;
        public clsCliente clienteGlobal { get; set; }

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
            try
            {
                DialogResult result = MessageBox.Show("¿Desea eliminar el Cliente?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    ClienteNegocio.delete(clienteGlobal);
                    MessageBox.Show("Cliente eliminado", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error al eliminar el Cliente", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                //Permite validar el formulario y da paso a guardar
                if (validarDatos())
                {
                    //New desde 0
                    clsCliente cliente;

                    cliente = isNew ? new clsCliente() : clienteGlobal;

                    cliente.identificacion = txtIdentificacion.Text.Trim().ToUpper();
                    cliente.tipoId = (int)cmbTipoId.SelectedValue;
                    cliente.nombre = txtNombre.Text.Trim().ToUpper();
                    cliente.apellido1 = txtApell1.Text.Trim().ToUpper();
                    cliente.apellido2 = txtApell2.Text.Trim().ToUpper();
                    cliente.tipoCliente = (int)cmbTipoCliente.SelectedValue;
                    cliente.fecha_socio = dtpFechaSocio.Value;
                    cliente.estado = true;

                    if (isNew)
                    {
                        ClienteNegocio.save(cliente);
                        MessageBox.Show("Cliente guardado", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        ClienteNegocio.update(cliente);
                        MessageBox.Show("Cliente actualizador", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    this.Close();
                }
            }
            catch (EntityExistException ex)
            {
                MessageBox.Show(ex.Message, "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo guardar, contacte el Administrador", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void frmClientes_Load(object sender, EventArgs e)
        {

            isNew = clienteGlobal == null ? true : false;

            cargarCombos();

            cmbTipoCliente.SelectedIndex = 0;
            cmbTipoId.SelectedIndex = 0;

            if (isNew)
            {
                lblTitulo.Text = "Crear Cliente";
                btnEliminar.Enabled = false;
            }
            else
            {
                lblTitulo.Text = "Modificar Cliente";
                cargarForm();
                txtIdentificacion.Enabled = false;
                cmbTipoId.Enabled = false;
                btnGuardar.Text = "Modificar";
            }
        }

        private void cargarForm()
        {
            txtIdentificacion.Text = clienteGlobal.identificacion;
            cmbTipoId.Text = Enum.GetName(typeof(Enumeradores.tipoId), clienteGlobal.tipoId);
            txtNombre.Text = clienteGlobal.nombre;
            txtApell1.Text = clienteGlobal.apellido1;
            txtApell2.Text = clienteGlobal.apellido2;
            cmbTipoCliente.Text = Enum.GetName(typeof(Enumeradores.tipoCliente), clienteGlobal.tipoCliente);
            dtpFechaSocio.Value = clienteGlobal.fecha_socio;
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

        private void pnlTitulo_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
