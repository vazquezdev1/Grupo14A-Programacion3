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
                MessageBox.Show("Ingresando al sistema..." + userName);
            }
            else
            {
                MessageBox.Show("Nombre de usuario incorrecto...");
            }
            
            
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("Muchas gracias por utilizar el sistema...");
        }

        private void btnDevsBy_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Grupo 14A : Alejandro Gomez - Henry Vazquez - Pablo Felice");
        }
    }
}
