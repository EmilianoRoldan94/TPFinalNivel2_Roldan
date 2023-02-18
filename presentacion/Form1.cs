using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using business;
using items;

namespace presentacion
{
    public partial class frmPrincipal : Form
    {
        private List<Articulo> listaArticulo;
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            cargar();

        }

        private void dgvVistaPrincipal_SelectionChanged_1(object sender, EventArgs e)
        {
            Articulo seleccionado = (Articulo)dgvVistaPrincipal.CurrentRow.DataBoundItem;
            cargarImagen(seleccionado.UrlImagen);
        }

        private void btnEliminarSeleccion_Click(object sender, EventArgs e)
        {
            Articulo seleccionado;
            articuloNegocio negocio = new articuloNegocio();

            try
            {
                DialogResult answer = MessageBox.Show("Confirmar eliminación, recuerde que esto no se puede deshacer.", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (answer == DialogResult.Yes) 
                {
                    seleccionado = (Articulo)dgvVistaPrincipal.CurrentRow.DataBoundItem;
                    negocio.eliminar(seleccionado.Id);
                    cargar();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
        private void btnAlta_Click(object sender, EventArgs e)
        {
            frmAltaArticulo alta = new frmAltaArticulo();
            alta.ShowDialog();
            cargar();
        }

        // *** Funciones utilizadas ***

        private void cargar() 
        {
            articuloNegocio negocio = new articuloNegocio();
            
            try
            {
                listaArticulo = negocio.listar();
                dgvVistaPrincipal.DataSource = listaArticulo;
                dgvVistaPrincipal.Columns["UrlImagen"].Visible = false;
                dgvVistaPrincipal.Columns["Id"].Visible = false;
                cargarImagen(listaArticulo[0].UrlImagen);
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
                pbxArticulo.Load("https://efectocolibri.com/wp-content/uploads/2021/01/placeholder.png");
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Articulo seleccionado;
            seleccionado = (Articulo)dgvVistaPrincipal.CurrentRow.DataBoundItem;

            frmAltaArticulo modificar = new frmAltaArticulo(seleccionado);
            modificar.ShowDialog();
            cargar();

        }
    }
}
