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
    public partial class Frm3_ListadoArticulos : Form
    {
        private List<Articulo> listaArticulos;
        public Frm3_ListadoArticulos()
        {
            InitializeComponent();
        }

        private void Frm3_ListadoArticulos_Load(object sender, EventArgs e)
        {
            try
            {
                //Se revisa que hayan artículos y se cargan
                ArticuloNegocio articulos = new ArticuloNegocio();
                listaArticulos = articulos.listaArticulos();
                dgvArticulos.DataSource = listaArticulos;
                dgvArticulos.Columns["UrlImagen"].Visible = false;
                dgvArticulos.Columns["Id"].Visible = false;
                cargarImagen(listaArticulos[0].UrlImagen);
            }
            //En caso de no haber registros en la Base de Datos
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Actualmente no se encuentran artículos cargados. Por favor, cargué un artículo primero antes de visualizar", "Sin Artículos Para Visualizar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }  
        }

        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            Articulo seleccionado = (Articulo) dgvArticulos.CurrentRow.DataBoundItem;
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
    }
}
