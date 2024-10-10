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
    public partial class Frm10_Categorias : Form
    {
        public Frm10_Categorias()
        {
            InitializeComponent();
        }

        private void cargar()
        {
            CategoriaNegocio ListaCategoria = new CategoriaNegocio();
            dgvCategorias.DataSource = ListaCategoria.listar();
            dgvCategorias.Columns["Id"].Visible = false;
        }

        private void Frm10_Categorias_Load(object sender, EventArgs e)
        {
            cargar();
        }

        private void btnAltacategoria_Click(object sender, EventArgs e)
        {
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(Frm11_AltaCategoria))
                {
                    MessageBox.Show("No puede abrir más de una vez esta ventana");
                    return;
                }
            }

            Frm11_AltaCategoria ventanaAltaCategoria = new Frm11_AltaCategoria();
            ventanaAltaCategoria.ShowDialog();
            cargar();
        }

        private void btnModificacionCategoria_Click(object sender, EventArgs e)
        {
            Categoria seleccionada;
            seleccionada = (Categoria)dgvCategorias.CurrentRow.DataBoundItem;

            Frm11_AltaCategoria ventanaModificarCategoria = new Frm11_AltaCategoria(seleccionada);
            ventanaModificarCategoria.ShowDialog();
            cargar();
        }

        private void btnBajaCategoria_Click(object sender, EventArgs e)
        {
            CategoriaNegocio eliminar = new CategoriaNegocio();
            Categoria seleccionado;
            try
            {
                DialogResult respuesta = MessageBox.Show("¿Confirma eliminación?", "Eliminado", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.Yes)
                {
                    seleccionado = (Categoria)dgvCategorias.CurrentRow.DataBoundItem;
                    eliminar.eliminar(seleccionado.Id);
                    cargar();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
