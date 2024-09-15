using dominio;
using negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabajoPractico_2
{
    public partial class Frm4_VerArticulo : Form
    {
        private List<Articulo> listaArticulos;
        public Frm4_VerArticulo()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            DialogResult confirmacion = MessageBox.Show("¿Desea guardar los cambios?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmacion == DialogResult.Yes)
            {
                Articulo articulo = new Articulo();

                articulo.Codigo = txbCodigoArticulo.Text;
                articulo.Nombre = txbNombreArticulo.Text;
                articulo.Descripcion = txbDescripcionArticulo.Text;
                articulo.Precio = decimal.Parse(txbPrecioArticulo.Text);
                articulo.UrlImagen = txtUrlImg.Text;


                // Validar Marca y Categoria
                if (cmbMarcaArticulo.SelectedIndex < 0)
                {
                    MessageBox.Show("Seleccione una marca válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                articulo.Marca = (Marca)cmbMarcaArticulo.SelectedItem;

                if (cmbCategoriaArticulo.SelectedIndex < 0)
                {
                    MessageBox.Show("Seleccione una categoría válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                articulo.Categoria = (Categoria)cmbCategoriaArticulo.SelectedItem;

                ArticuloNegocio articuloNegocio = new ArticuloNegocio();

                articuloNegocio.agregar(articulo);
                
                MessageBox.Show("El articulo se actualizó correctamente.", "Actualizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                this.Close();
                
            }
        }

        private void Frm4_VerArticulo_Load(object sender, EventArgs e)
        {
            //cargar Marcas en el ComboBox
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            List<Marca> marcas = marcaNegocio.listar();
            cmbMarcaArticulo.DataSource = marcas;
            cmbMarcaArticulo.DisplayMember = "descripcion";
            cmbMarcaArticulo.ValueMember = "id";

            //cargar Categoria en el ComboBox
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
            List<Categoria> categorias = categoriaNegocio.listar();
            cmbCategoriaArticulo.DataSource = categorias;
            cmbCategoriaArticulo.DisplayMember = "descripcion";
            cmbCategoriaArticulo.ValueMember = "id";
        }

    }
}
