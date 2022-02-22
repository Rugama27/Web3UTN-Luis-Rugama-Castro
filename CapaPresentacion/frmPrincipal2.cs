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
        public frmPrincipal2()
        {
            InitializeComponent();
        }
        

        private void frmPrincipal2_Load(object sender, EventArgs e)
        {

        }

        private void chgcToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void clientesToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            //comentarios
            // una linea 

            // una instancia -- accediendo a la memoria
            frmListaClientes frmClientes = new frmListaClientes();
            // showDialog: muestra el formulario
            frmClientes.ShowDialog();
        }

        private void frmPrincipal2_Load_1(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            //comentarios
            // una linea 

            // una instancia -- accediendo a la memoria
            frmListaClientes frmClientes = new frmListaClientes();
            // showDialog: muestra el formulario
            frmClientes.ShowDialog();
        }
    }
    }
