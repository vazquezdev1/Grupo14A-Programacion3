using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabajoPractico_2_Grupo14A
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
            ArticuloDatos articulos = new ArticuloDatos();
            listaArticulos = articulos.listaArticulos();
            dgvArticulos.DataSource = listaArticulos;
            dgvArticulos.Columns["UrlImagen"].Visible = false;
            cargarImagen(listaArticulos[0].UrlImagen);
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
