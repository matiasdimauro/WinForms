using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsActII
{
    public partial class frmMenuPrincipal : Form
    {
        public frmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            frmMarcas ventana = new frmMarcas();
            ventana.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void btnMarcas_Click_1(object sender, EventArgs e)
        {
            frmMarcas ventana = new frmMarcas();
            ventana.Show();
        }

        private void btnCategorias_Click(object sender, EventArgs e)
        {
            frmCategorias ventana = new frmCategorias();
            ventana.Show();
        }

        private void btnDetalle_Click(object sender, EventArgs e)
        {
            frmDetalle ventana = new frmDetalle();
            ventana.Show();
        }

        private void pbxArticulo_Click(object sender, EventArgs e)
        {

        }
    }
}
