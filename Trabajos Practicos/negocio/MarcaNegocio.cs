using dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace negocio
{
    public class MarcaNegocio
    {
        public List<Marca> listar()
        {
            List<Marca> lista = new List<Marca>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("SELECT Id, Descripcion FROM MARCAS");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Marca marca = new Marca();
                    marca.Id = (int)datos.Lector["Id"];
                    marca.Descripcion = (string)datos.Lector["Descripcion"];
                    lista.Add(marca);
                }

                return lista;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectarse a la base de datos");
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
    }
}
