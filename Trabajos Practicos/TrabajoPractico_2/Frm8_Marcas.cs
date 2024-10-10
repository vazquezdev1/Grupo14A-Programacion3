using negocio;
using dominio;
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
    public partial class Frm8_Marcas : Form
    {
        public Frm8_Marcas()
        {
            InitializeComponent();
        }

        private void Frm8_Marcas_Load(object sender, EventArgs e)
        {
            cargar();
        }

        private void cargar()
        {
            MarcaNegocio ListaMarca = new MarcaNegocio();
            dgvMarcas.DataSource = ListaMarca.listar();
            dgvMarcas.Columns["Id"].Visible = false;
        }

        private void btnAltaMarca_Click(object sender, EventArgs e)
        {
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(Frm9_AltaMarca))
                {
                    MessageBox.Show("No puede abrir más de una vez esta ventana");
                    return;
                }
            }

            Frm9_AltaMarca ventanaAltaMarca = new Frm9_AltaMarca();
            ventanaAltaMarca.ShowDialog();
            cargar();
        }

        private void btnModificacionMarca_Click(object sender, EventArgs e)
        {
            Marca seleccionada;
            seleccionada = (Marca)dgvMarcas.CurrentRow.DataBoundItem;

            Frm9_AltaMarca ventanaModificarMarca = new Frm9_AltaMarca(seleccionada);
            ventanaModificarMarca.ShowDialog();
            cargar();
        }

        private void btnBajaMarca_Click(object sender, EventArgs e)
        {
            MarcaNegocio eliminar = new MarcaNegocio();
            Marca seleccionado;
            try
            {
                DialogResult respuesta = MessageBox.Show("¿Confirma eliminación?", "Eliminado", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if(respuesta == DialogResult.Yes)
                {
                    seleccionado = (Marca)dgvMarcas.CurrentRow.DataBoundItem;
                    eliminar.eliminar(seleccionado.Id);
                    cargar();
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show( ex.ToString());
            }
        }
    }
}
