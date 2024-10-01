using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabajoPractico_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btnInicio_Click(object sender, EventArgs e)
        {
            string userName = txtUserName.Text;
            
            if(userName == "admin")
            {
                MessageBox.Show("Ingresando al sistema, " + userName);
                Frm2_VentanaPrincipalArticulos ventanaPrincipal = new Frm2_VentanaPrincipalArticulos();
                ventanaPrincipal.ShowDialog();
            }
            else
            {
                MessageBox.Show("Nombre de usuario incorrecto. Por favor, ingrese un nombre válido");
            }
            
            
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("Muchas gracias por utilizar el sistema ¡Vuelva pronto!");
        }

        private void btnDevsBy_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Grupo 14 A: Alejandro Gomez - Henry Vazquez - Pablo Felice");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
