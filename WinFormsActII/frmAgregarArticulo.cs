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
        private Articulo articulo = null;
        public frmAgregarArticulo()
        {
            InitializeComponent();
        }

        public frmAgregarArticulo(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
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
            ArticuloNegocio negocioArticulo = new ArticuloNegocio();

            try
            {
                 if(articulo == null)
                    articulo = new Articulo();

                articulo.Codigo = txbCodigo.Text;
                articulo.Nombre = txbNombre.Text;
                articulo.Descripcion = txbDescripcion.Text;
                articulo.Precio = decimal.Parse(txbPrecio.Text);
                articulo.Marca = (Marca)cboMarca.SelectedItem;
                articulo.Categoria = (Categoria)cboCategoria.SelectedItem;
                articulo.UrlImagen = txbUrlImagen.Text;

                if (articulo.Id != 0)
                {
                     negocioArticulo.modificar(articulo);
                     MessageBox.Show("Articulo modificado");
                }
                else
                {
                negocioArticulo.agregar(articulo);
                MessageBox.Show("Articulo agregado");
                }

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
            ArticuloNegocio articuloNegocio = new ArticuloNegocio();
            try
            {
                cargar();
                if (articulo != null)
                {
                    txbCodigo.Text = articulo.Codigo.ToString();
                    txbNombre.Text = articulo.Nombre;
                    txbDescripcion.Text = articulo.Descripcion;
                    txbPrecio.Text = articulo.Precio.ToString();
                    txbUrlImagen.Text = articulo.UrlImagen;
                    cargarImagen(articulo.UrlImagen);
                }
            }
            catch (Exception ex) { throw ex; }
        }
    }
}
