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

        }

        private void pbMostar_Click(object sender, EventArgs e)
        {
            //if- estructura condicional
            if (pnlMenu.Width==170)
            {
                pnlMenu.Width=0;
            }
            else
            {
                pnlMenu.Width=170;
            }
        }
    }
}
