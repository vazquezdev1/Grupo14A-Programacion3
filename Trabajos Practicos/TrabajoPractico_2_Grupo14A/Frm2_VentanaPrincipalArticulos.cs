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
    public partial class Frm2_VentanaPrincipalArticulos : Form
    {
        public Frm2_VentanaPrincipalArticulos()
        {
            InitializeComponent();
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
    }
}
