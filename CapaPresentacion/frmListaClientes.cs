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
    public partial class frmListaClientes : Form
    {
        private clsTren tren;

        public frmListaClientes()
        {
            InitializeComponent();
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {
            lbltitulo.Text =   "Mantenimiento Clientes";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            //abrir el formulario de crear frmClientes
            frmClientes form = new frmClientes();   
            form.ShowDialog();  

            

        }
    }
}
