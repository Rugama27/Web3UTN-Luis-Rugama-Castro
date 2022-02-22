using CapaNegocio;
using Entidades;
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
    public enum tipoCedula
    {
        Nacional =1,
        Juridica =2,
        Dimex =3,
        Nite = 4,
    }
    public enum tipoCliente
    {
        Normal = 1,
        Regular = 2,
        SuperCliente = 3,
        
    }

    public partial class frmClientes : Form
    {
        public frmClientes()
        {
            InitializeComponent();
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {
            lbltitulo.Text = "Crear Cliente";
            
            cargarCombos();
            cboTipoCliente.SelectedIndex = 0;   
            cboIdentificacion.SelectedIndex = 0;    
        }
        private void cargarCombos()
        {
            cboIdentificacion.DataSource=Enum.GetValues(typeof(tipoCedula));
            cboTipoCliente.DataSource=Enum.GetValues(typeof(tipoCliente));

        }

        private void button3_Click(object sender, EventArgs e, clsCliente cliente)
        {
            bool isOk = validardatos();
            //permite validar el formulario y da paso a guardar
            if (isOk==true)
            {
                clsCliente clientenew = new clsCliente();
                clientenew.identificacion = txtIdentificacion.Text.Trim().ToUpper();
                clientenew.id= (int)cboIdentificacion.SelectedValue;
                clientenew.nombre = txtNombre.Text.Trim().ToUpper();
                clientenew.apellido1 = txtApellido1.Text.Trim().ToUpper();
                clientenew.apellido2 = txtApellido2.Text.Trim().ToUpper();
                clientenew.tipoCliente = (int)cboTipoCliente.SelectedValue;
                clientenew.fecha_socio = dtpFechaSocio.Value;
                clientenew.estado = true;


                ClientesNegocio clienteN = new ClientesNegocio();
                clienteN.guardar(clientenew);


            }





        }

        private bool validardatos()
        {
            if (txtIdentificacion.Text==String.Empty)
            {
                MessageBox.Show("Falta la identificacion", "Falta datos",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return false;
            }
            if (txtNombre.Text==String.Empty)
            {
                MessageBox.Show("Falta el nombre", "Falta datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txtApellido1.Text==String.Empty)
            {
                MessageBox.Show("Falta el primer apellido", "Falta datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txtApellido2.Text==String.Empty)
            {
                MessageBox.Show("Falta el segundo apellido", "Falta datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
