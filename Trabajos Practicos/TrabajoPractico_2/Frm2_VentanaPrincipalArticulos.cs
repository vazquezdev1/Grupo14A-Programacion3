using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabajoPractico_2_Grupo14A;

namespace TrabajoPractico_2
{
    public partial class Frm2_VentanaPrincipalArticulos : Form
    {
        public Frm2_VentanaPrincipalArticulos()
        {
            InitializeComponent();
            DateTime fechaHoraActual = DateTime.Now;
            tsslDatosEstadoSesion.Text = fechaHoraActual.ToString();
        }

        private void listarTodosLosArticulosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(Frm3_ListadoArticulos))
                {
                    MessageBox.Show("No puede abrir más de una vez esta ventana");
                    return;
                }
            }

            Frm3_ListadoArticulos ventanaListadoArticulos = new Frm3_ListadoArticulos();
            //ventanaListadoArticulos.MdiParent = this;
            ventanaListadoArticulos.Show();
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm4_VerArticulo verArticulo = new Frm4_VerArticulo();
            verArticulo.ShowDialog();
        }
        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(Frm3_ListadoArticulos))
                {
                    MessageBox.Show("No puede abrir más de una vez la ventana Eliminar");
                    return;
                }
            }

            Frm6_BorrarArticulo borrarArticulo = new Frm6_BorrarArticulo();
            borrarArticulo.Show();
        }

        private void modificaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(Frm5_ModificarArticulo))
                {
                    MessageBox.Show("No puede abrir más de una vez la ventana Modificar");
                    return;
                }
            }

            Frm5_ModificarArticulo modificarArticulo = new Frm5_ModificarArticulo();
            modificarArticulo.Show();
        }
    }
}
