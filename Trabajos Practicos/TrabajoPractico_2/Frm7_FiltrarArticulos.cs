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

namespace TrabajoPractico_2_Grupo14A
{
    public partial class Frm7_FiltrarArticulos : Form
    {
        public Frm7_FiltrarArticulos()
        {
            InitializeComponent();
        }

        private List<Articulo> listaArticulos;

        private void Frm7_FiltrarArticulos_Load(object sender, EventArgs e)
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
            if(dgvArticulos.CurrentRow != null)
            {
                Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                cargarImagen(seleccionado.UrlImagen);
            }
            
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

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            List<Articulo> listaFiltrada;
            string filtro;

            if(txtFiltroCodigo.Text != "")
            {
                filtro = txtFiltroCodigo.Text;
                listaFiltrada = listaArticulos.FindAll(x => x.Codigo.ToUpper().Contains(filtro.ToUpper()));
            }
            else if(txtFiltroMarca.Text != "")
            {
                filtro = txtFiltroMarca.Text;
                listaFiltrada = listaArticulos.FindAll(x => x.Marca.Descripcion.ToUpper().Contains(filtro.ToUpper()));
            }
            else if(txtFiltroNombre.Text != "")
            {
                filtro = txtFiltroNombre.Text;
                listaFiltrada = listaArticulos.FindAll(x => x.Nombre.ToUpper().Contains(filtro.ToUpper()));
            }
            else
            {
                filtro = "";
                listaFiltrada = listaArticulos;
            }

            dgvArticulos.DataSource = null;
            dgvArticulos.DataSource = listaFiltrada;
            dgvArticulos.Columns["UrlImagen"].Visible = false;
            dgvArticulos.Columns["Id"].Visible = false;
            cargarImagen(listaArticulos[0].UrlImagen);

        }

        private void btnLimpiarFiltro_Click(object sender, EventArgs e)
        {
            txtFiltroCodigo.Text = "";
            txtFiltroMarca.Text = "";
            txtFiltroNombre.Text = "";

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
    }
}
