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
using dominio;
using TrabajoPractico_2;

namespace TrabajoPractico_2_Grupo14A
{
    public partial class Frm5_ModificarArticulo : Form
    {
        private List<Articulo> listaArticulos;
        public Frm5_ModificarArticulo()
        {
            InitializeComponent();
        }

        private void Frm5_ModificarArticulo_Load(object sender, EventArgs e)
        {
            try
            {
                ArticuloNegocio articulos = new ArticuloNegocio();
                listaArticulos = articulos.listaArticulos();
                dgvArticulos.DataSource = listaArticulos;
                dgvArticulos.Columns["UrlImagen"].Visible = false;
                dgvArticulos.Columns["Id"].Visible = false;
                cargarImagen(listaArticulos[0].UrlImagen);
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Actualmente no se encuentran artículos cargados. Por favor, cargué un artículo primero antes de eliminar", "Sin Artículos Para Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            cargarImagen(seleccionado.UrlImagen);
        }

        private void cargarImagen(string imagen)
        {
            try
            {
                pbxArticulo.Load(imagen);
            }
            catch (Exception e)
            {
                pbxArticulo.Load("https://developers.elementor.com/docs/assets/img/elementor-placeholder-image.png");
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Articulo seleccionado;
            seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;

            Frm4_VerArticulo modificar = new Frm4_VerArticulo(seleccionado);
            modificar.ShowDialog();

            try
            {
                ArticuloNegocio articulos = new ArticuloNegocio();
                listaArticulos = articulos.listaArticulos();
                dgvArticulos.DataSource = listaArticulos;
                dgvArticulos.Columns["UrlImagen"].Visible = false;
                cargarImagen(listaArticulos[0].UrlImagen);
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Actualmente no se encuentran artículos cargados. Por favor, cargué un artículo primero antes de eliminar", "Sin Artículos Para Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }
    }
}
