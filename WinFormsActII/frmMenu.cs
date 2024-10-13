using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using negocio;

namespace WinFormsActII
{
    public partial class frmMenuPrincipal : Form
    {
        List<Articulo> lista = new List<Articulo>();
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

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAgregarArticulo ventana = new frmAgregarArticulo();
            ventana.Show();
        }

        private void dgvArticulo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void cargar()
        {
            try
            {
                ArticuloNegocio negocio = new ArticuloNegocio();
                lista = negocio.listar();
                dgvArticulo.DataSource = lista;
                dgvArticulo.Columns["UrlImagen"].Visible = false;
                dgvArticulo.Columns["Categoria"].Visible = false;
                dgvArticulo.Columns["Marca"].Visible = false;
                cargarImagen(lista[0].UrlImagen);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


        private void cargarImagen(string imagen)
        {
            try
            {
                pbxArticulo.Load(imagen);
            }
            catch (Exception ex)
            {
                pbxArticulo.Load("https://www.idsplus.net/wp-content/uploads/default-placeholder.png");
            }
        }

        private void frmMenuPrincipal_Load(object sender, EventArgs e)
        {
            cargar();
            cboCampo.Items.Add("Id");
            cboCampo.Items.Add("Articulo");
            cboCampo.Items.Add("Precio");
        }

        private void cboCampo_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string opcion = cboCampo.SelectedItem.ToString();
            if (opcion == "Id" || opcion == "Precio")
            {
                cboCriterio.Items.Clear();
                cboCriterio.Items.Add("Mayor a");
                cboCriterio.Items.Add("Menor a");
                cboCriterio.Items.Add("Igual a");
            }
            else
            {
                cboCriterio.Items.Clear();
                cboCriterio.Items.Add("Comienza con");
                cboCriterio.Items.Add("Termina con");
                cboCriterio.Items.Add("Contiene");
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            frmModificarArticulo ventana = new frmModificarArticulo();
            ventana.Show();
        }

        private void txtFlitrarNombre_TextChanged(object sender, EventArgs e)
        {
            List<Articulo> listaRapida;
            string filtro = txtFlitrarNombre.Text;

            if (filtro.Length >= 1)
            {
                listaRapida = lista.FindAll(x => x.Nombre.ToUpper().Contains(filtro.ToUpper()));
            }
            else
            {
                listaRapida = lista;
            }

            dgvArticulo.DataSource = null;
            dgvArticulo.DataSource = listaRapida;
            dgvArticulo.Columns["UrlImagen"].Visible = false;
            dgvArticulo.Columns["Categoria"].Visible = false;
            dgvArticulo.Columns["Marca"].Visible = false;
        }
    }
}

