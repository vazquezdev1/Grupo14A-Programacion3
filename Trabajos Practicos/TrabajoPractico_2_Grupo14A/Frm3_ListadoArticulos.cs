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
        public Frm3_ListadoArticulos()
        {
            InitializeComponent();
        }

        private void Frm3_ListadoArticulos_Load(object sender, EventArgs e)
        {
            ArticuloDatos articulos = new ArticuloDatos();
            dgvArticulos.DataSource = articulos.listaArticulos();
        }
    }
}
