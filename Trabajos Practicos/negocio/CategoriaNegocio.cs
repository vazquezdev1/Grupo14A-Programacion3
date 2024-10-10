using dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace negocio
{
    public class CategoriaNegocio
    {
        public List<Categoria> listar()
        {
            List<Categoria> lista = new List<Categoria>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("SELECT Id, Descripcion FROM CATEGORIAS");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Categoria categoria = new Categoria();
                    categoria.Id = (int)datos.Lector["Id"];
                    categoria.Descripcion = (string)datos.Lector["Descripcion"];
                    lista.Add(categoria);
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

        public int agregar(Categoria categoria)
        {
            int respuesta = 0;
            AccesoDatos datos = new AccesoDatos();

            string sql = "INSERT INTO CATEGORIAS (Descripcion)" + " VALUES (@nuevaCategoria)";

            try
            {
                datos.setearConsulta(sql);
                datos.setearParametro("@nuevaCategoria", categoria.Descripcion);
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

        public void modificar(Categoria categoria)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                string sql = "UPDATE CATEGORIAS SET Descripcion = @descrip WHERE Id = @id";
                datos.setearConsulta(sql);
                datos.setearParametro("@descrip", categoria.Descripcion);
                datos.setearParametro("@id", categoria.Id);
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
                string sql = "DELETE FROM CATEGORIAS WHERE Id = @id";
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
