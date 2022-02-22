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
        public frmPrincipal3()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pbCerrar_Click(object sender, EventArgs e)
        {
            //cierra todo el aplicativo
            Application.Exit();     
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmPrincipal3_Load(object sender, EventArgs e)
        {
            lblTitulo.Text = "UTN APP";
        }

        private void pbMostar_Click(object sender, EventArgs e)
        {
            //if- estructura condicional
            //ocultarme el panel del menu cuando este desplegado 
            //== comparacion
            //= 
            if (pnlMenu.Width==170)
            {
                // cabia el ancho a 0
                pnlMenu.Width=0;
            }
            else
            {
                //si es 0, esta oculto, me lo pasa a 170, me lo muestra
                pnlMenu.Width=170;
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //comentarios
            // una linea 

            // una instancia -- accediendo a la memoria
            frmListaClientes frmClientes = new frmListaClientes();
            // showDialog: muestra el formulario
            frmClientes.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();   
        }
    }
}
    

