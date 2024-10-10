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

namespace TrabajoPractico_2_Grupo14A
{
    
    public partial class Frm9_AltaMarca : Form
    {
        private Marca  marca = null;
        public Frm9_AltaMarca()
        {
            InitializeComponent();
        }
        public Frm9_AltaMarca(Marca marca)
        {
            InitializeComponent();
            this.marca = marca;
        }

        private void btnCancelarNuevaMarca_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptarNuevaMarca_Click(object sender, EventArgs e)
        {
            if(marca == null)
            {
                marca = new Marca();
            }
            MarcaNegocio negocio = new MarcaNegocio();

            try
            {
                marca.Descripcion = txtNuevaMarca.Text;

                if(marca.Id != 0)
                {
                    negocio.modificar(marca);
                    MessageBox.Show("Agregado correctamente");
                }
                else
                {
                    negocio.agregar(marca);
                    MessageBox.Show("Agregado correctamente");
                }
                
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Frm9_AltaMarca_Load(object sender, EventArgs e)
        {
            if (marca != null)
            {
                txtNuevaMarca.Text = marca.Descripcion;
            }
        }
    }
}
