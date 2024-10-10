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


namespace TrabajoPractico_2_Grupo14A
{
    public partial class Frm11_AltaCategoria : Form
    {
        private Categoria categoria = null;
        public Frm11_AltaCategoria()
        {
            InitializeComponent();
        }

        public Frm11_AltaCategoria(Categoria categoria)
        {
            InitializeComponent();
            this.categoria = categoria;
        }

        private void btnCancelarNuevaCategoria_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnAceptarNuevaCategoria_Click(object sender, EventArgs e)
        {
            if (categoria == null)
            {
                categoria = new Categoria();
            }
            CategoriaNegocio negocio = new CategoriaNegocio();

            try
            {
                categoria.Descripcion = txtNuevaCategoria.Text;

                if (categoria.Id != 0)
                {
                    negocio.modificar(categoria);
                    MessageBox.Show("Agregado correctamente");
                }
                else
                {
                    negocio.agregar(categoria);
                    MessageBox.Show("Agregado correctamente");
                }

                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Frm11_AltaCategoria_Load(object sender, EventArgs e)
        {
            if (categoria != null)
            {
                txtNuevaCategoria.Text = categoria.Descripcion;
            }
        }
    }
}
