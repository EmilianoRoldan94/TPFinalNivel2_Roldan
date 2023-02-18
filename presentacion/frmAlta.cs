using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using items;
using business;

namespace presentacion
{
    public partial class frmAltaArticulo : Form
    {
        
        private Articulo articulo = null;
        
        public frmAltaArticulo()
        {
            InitializeComponent();
        }

        private void frmAltaArticulo_Load(object sender, EventArgs e)
        {
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
            try
            {
                cbxCategoria.DataSource = categoriaNegocio.Listar();
                cbxCategoria.ValueMember = "Id";
                cbxCategoria.DisplayMember = "Descripcion";
                cbxMarca.DataSource = marcaNegocio.Listar();
                cbxMarca.ValueMember= "Id";
                cbxMarca.DisplayMember = "Descripcion";

                //falta para modificar

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Articulo articulo = null;
            articuloNegocio negocio = new articuloNegocio();
            try
            {
                if (articulo == null)
                {
                    articulo = new Articulo();
                }
                articulo.CodigoArticulo = tbxCodigo.Text;
                articulo.Nombre= tbxNombre.Text;
                articulo.Descripcion = tbxDescripcion.Text;
                articulo.UrlImagen= tbxUrlImagen.Text;
                articulo.Precio= decimal.Parse(tbxPrecio.Text);
                articulo.Categoria = (MarcaCat)cbxCategoria.SelectedItem;
                articulo.Marca = (MarcaCat)cbxMarca.SelectedItem;

                negocio.Agregar(articulo);
                MessageBox.Show("Artículo agregado correctamente!");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }
        private void tbxUrlImagen_Leave(object sender, EventArgs e)
        {
            cargarImagen(tbxUrlImagen.ToString());
        }

        // *** Funciones Utilizadas ***

        private void cargarImagen(string Imagen)
        {
            try
            {
                pbxUrlImagen.Load(Imagen);
            }
            catch (Exception)
            {

                pbxUrlImagen.Load("https://efectocolibri.com/wp-content/uploads/2021/01/placeholder.png");
            }
        }

        
    }
}
