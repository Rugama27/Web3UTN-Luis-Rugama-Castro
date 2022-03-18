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
   
    public partial class frmBusquedaProductos : Form
    {
        public delegate void pasarDatos(string nombre);
        public event pasarDatos pasarDatosEvent;
        public frmBusquedaProductos()
        {
            InitializeComponent();
        }

        private void frmBusquedaProductos_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            pasarDatosEvent(txtPasar.Text);
            this.Close();
        }
    }
}
