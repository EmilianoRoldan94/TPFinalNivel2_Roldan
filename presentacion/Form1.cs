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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace presentacion
{
    public partial class frmPrincipal : Form
    {
        private List<Articulo> listaArticulo;
        private List<Articulo> listaFiltrada;
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
            if (dgvVistaPrincipal.CurrentRow != null) // Evita crash por falta de rows
            {
                Articulo seleccionado = (Articulo)dgvVistaPrincipal.CurrentRow.DataBoundItem;
                cargarImagen(seleccionado.UrlImagen);
            }
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

        

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Articulo seleccionado;
            seleccionado = (Articulo)dgvVistaPrincipal.CurrentRow.DataBoundItem;

            frmAltaArticulo modificar = new frmAltaArticulo(seleccionado);
            modificar.ShowDialog();
            cargar();

        }

        private void btnDetalle_Click(object sender, EventArgs e)
        {
            Articulo seleccionado;
            seleccionado = (Articulo)dgvVistaPrincipal.CurrentRow.DataBoundItem;
            
            frmDetalle detalle = new frmDetalle(seleccionado);
            detalle.ShowDialog();
            cargar();
        }

        private void ocultarColumnas() 
        {
            dgvVistaPrincipal.Columns["UrlImagen"].Visible = false;
            dgvVistaPrincipal.Columns["Id"].Visible = false;
        }

        // Lógica filtros #########################################################
        private void tbxFiltroCodigo_TextChanged(object sender, EventArgs e)
        {
            filtrarDatos();
            ocultarColumnas();
        }
        private void tbxFiltroNombre_TextChanged(object sender, EventArgs e)
        {
            filtrarDatos();
            ocultarColumnas();
        }

        private void tbxFiltroDescripcion_TextChanged(object sender, EventArgs e)
        {
            filtrarDatos();
            ocultarColumnas();
        }



        private void btnResetearFiltros_Click(object sender, EventArgs e)
        {
            // Limpio textbox's
            tbxFiltroNombre.Clear();
            tbxFiltroDescripcion.Clear();
        }

        // ********* Funciones utilizadas *********

        private void cargar()
        {
            articuloNegocio negocio = new articuloNegocio();

            try
            {
                listaArticulo = negocio.listar();
                listaFiltrada = listaArticulo;
                dgvVistaPrincipal.DataSource = listaArticulo;
                ocultarColumnas();
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
            catch (Exception)
            {
                pbxArticulo.Load("https://efectocolibri.com/wp-content/uploads/2021/01/placeholder.png");
            }
        }
        private void filtrarDatos() // Faltan criterios por falta de tiempo
        {

            string fltNombre = tbxFiltroNombre.Text.ToUpper();
            string fltDescripcion = tbxFiltroDescripcion.Text.ToUpper();
            string fltCodigo = tbxFiltroCodigo.Text.ToUpper();


            // Aplico filtros según corresponda
            listaFiltrada = listaArticulo.Where(d => d.CodigoArticulo.ToUpper().Contains(fltCodigo)
                                                           && d.Nombre.ToUpper().Contains(fltNombre)
                                                           && d.Descripcion.ToUpper().Contains(fltDescripcion)).ToList();

            // Actualizo la dgv
            dgvVistaPrincipal.DataSource = listaFiltrada;
        }
    }
}
