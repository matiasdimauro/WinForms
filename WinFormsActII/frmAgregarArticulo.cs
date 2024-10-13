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
using static System.Net.Mime.MediaTypeNames;

namespace WinFormsActII
{
    public partial class frmAgregarArticulo : Form
    {
        public frmAgregarArticulo()
        {
            InitializeComponent();
        }

        private void cargar()
        {
            MarcaNegocio negocioMarca = new MarcaNegocio();
            CategoriaNegocio negocioCategoria = new CategoriaNegocio();

            try
            {
                cboMarca.DataSource = negocioMarca.listar();
                cboCategoria.DataSource = negocioCategoria.listar();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

       

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnTerminar_Click(object sender, EventArgs e)
        {
            Articulo articulo = new Articulo();
            ArticuloNegocio negocioArticulo = new ArticuloNegocio();

            try
            {
                articulo.Codigo = txbCodigo.Text;
                articulo.Nombre = txbNombre.Text;
                articulo.Descripcion = txbDescripcion.Text;
                articulo.Precio = decimal.Parse(txbPrecio.Text);
                articulo.Marca = (Marca)cboMarca.SelectedItem;
                articulo.Categoria = (Categoria)cboCategoria.SelectedItem;
                articulo.UrlImagen = txbUrlImagen.Text;

                negocioArticulo.agregar(articulo);
                MessageBox.Show("Articulo agregado");
                txbCodigo.Text = string.Empty;
                txbNombre.Text = string.Empty;
                txbDescripcion.Text = string.Empty;
                txbPrecio.Text = string.Empty;
                txbUrlImagen.Text = string.Empty;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void txbUrlImagen_Leave(object sender, EventArgs e)
        {
            cargarImagen(txbUrlImagen.Text);
        }

        private void cargarImagen(string imagen)
        {
            try
            {
                pbxArticulo.Load(imagen);
            }
            catch(Exception ex)
            {
                pbxArticulo.Load("https://www.idsplus.net/wp-content/uploads/default-placeholder.png");                
            }
        }

        private void frmAgregarArticulo_Load(object sender, EventArgs e)
        {
            cargar();
        }
    }
}
