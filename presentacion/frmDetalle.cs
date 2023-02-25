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
    public partial class frmDetalle : Form
    {
        private Articulo articulo;
        public frmDetalle(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
        }

        private void frmDetalle_Load(object sender, EventArgs e)
        {
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();

            try
            {
                tbxCodigo.Text = articulo.CodigoArticulo;
                tbxNombre.Text = articulo.Nombre;
                tbxDescripcion.Text = articulo.Descripcion;
                tbxPrecio.Text = articulo.Precio.ToString();

                cargarImagen(articulo.UrlImagen);

                tbxMarca.Text = articulo.Marca.Descripcion;
                tbxCategoria.Text = articulo.Categoria.Descripcion;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

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
