using dominio;
using negocio;
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
    public partial class frmDetalle : Form
    {
        List<Articulo> lista = new List<Articulo>();
        int articulo;
        string imagen;
        public frmDetalle(int art, string img)
        {
            InitializeComponent();
            articulo = art;
            imagen = img;
        }

        private void frmDetalle_Load(object sender, EventArgs e)
        {
            cargar(articulo, imagen);
        }

        private void cargar(int art, string img)
        {
            try
            {
                ArticuloNegocio negocio = new ArticuloNegocio();
                lista = negocio.ListarDetalle(art);
                dgvDetalle.DataSource = lista;
                cargarImagen(img);

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void cargarImagen(string img)
        {
            try
            {
                pbxDetalle.Load(img);
            }
            catch (Exception ex)
            {

                pbxDetalle.Load("https://www.idsplus.net/wp-content/uploads/default-placeholder.png");
            }
        }
    }
}
