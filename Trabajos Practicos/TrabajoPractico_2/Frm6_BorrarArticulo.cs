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

namespace TrabajoPractico_2
{
    public partial class Frm6_BorrarArticulo : Form
    {
        private List<Articulo> listaArticulos;
        public Frm6_BorrarArticulo()
        {
            InitializeComponent();
        }

        private void Frm6_BorrarArticulo_Load(object sender, EventArgs e)
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
        private void cargarImagen(String imagen)
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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult confirmacion = MessageBox.Show("¿Está seguro que desea eliminar el artículo?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            try
            {
                if (confirmacion == DialogResult.Yes)
                {
                    //Se borra el artículo elegido
                    Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                    ArticuloNegocio articulo = new ArticuloNegocio();
                    articulo.eliminar(seleccionado.Id);

                    //Se recarga la grilla de artículos
                    listaArticulos = articulo.listaArticulos();
                    dgvArticulos.DataSource = listaArticulos;
                    dgvArticulos.Columns["UrlImagen"].Visible = false;
                    cargarImagen(listaArticulos[0].UrlImagen);

                    //Cartel para confirmar la eliminación
                    MessageBox.Show("El articulo se eliminó correctamente.", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            //Si al recargar, la tabla ya no tiene registros...
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Actualmente no se encuentran artículos cargados. Por favor, cargué un artículo primero antes de eliminar", "Sin Artículos Para Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
            
        }
    }
}
