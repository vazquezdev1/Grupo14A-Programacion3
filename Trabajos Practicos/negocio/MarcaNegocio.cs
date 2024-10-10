using dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

        public int agregar(Marca marca)
        {
            int respuesta = 0;
            AccesoDatos datos = new AccesoDatos();

            string sql = "INSERT INTO MARCAS (Descripcion)" + " VALUES (@nuevaMarca)";

            try
            {
                datos.setearConsulta(sql);
                datos.setearParametro("@nuevaMarca", marca.Descripcion);
                respuesta = datos.ejecutarAccion();
                datos.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
            return respuesta;
        }

        public void modificar(Marca marca)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                string sql = "UPDATE MARCAS SET Descripcion = @descrip WHERE Id = @id";
                datos.setearConsulta(sql);
                datos.setearParametro("@descrip", marca.Descripcion);
                datos.setearParametro("@id", marca.Id);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }

        public void eliminar(int id)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                string sql = "DELETE FROM MARCAS WHERE Id = @id";
                datos.setearConsulta(sql);
                datos.setearParametro("@id", id);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
