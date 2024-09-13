using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient; //Libreria para DDBB
using dominio;

namespace negocio
{
    public class ArticuloNegocio
    {
        public List<Articulo> listaArticulos()
        {
            List<Articulo> lista = new List<Articulo>();
            /*
            SqlConnection conexion = new SqlConnection(); // Setear conexion
            SqlCommand comando = new SqlCommand(); // Realiza acciones
            SqlDataReader lector; // No se crea instancia - aloja datos - no se crea instancia por que no se tiene un constructor
            */
            AccesoDatos datos = new AccesoDatos();

            try
            {
                string consulta = "SELECT a.Id, Codigo, Nombre, Descripcion, ImagenUrl FROM ARTICULOS a, IMAGENES i WHERE a.Id = IdArticulo";

                datos.setearConsulta(consulta);
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.Id = datos.Lector.GetInt32(0);
                    aux.Codigo = datos.Lector.GetString(1);
                    aux.Nombre = datos.Lector.GetString(2);
                    aux.Descripcion = (string)datos.Lector["Descripcion"]; // Esta opcion realmente es mas comoda
                    aux.urlImagen = (string)datos.Lector["ImagenUrl"];
                    //aux.Precio = lector.GetFloat(4);
                    lista.Add(aux);
                }
                return lista;

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }

        }

        public void agregar(Articulo articulo)
        {
            AccesoDatos datos = new AccesoDatos();
            string sql = "insert into ARTICULOS (codigo, nombre, descripcion, IdMarca, IdCategoria, precio)"+"values (@codigo, @nombre, @descripcion, @idMarca, @idCategoria, @precio)";
            try
            {
                datos.setearConsulta(sql);
                datos.setearParametro("@codigo", articulo.Codigo);
                datos.setearParametro("@nombre", articulo.Nombre);
                datos.setearParametro("@descripcion", articulo.Descripcion);
                datos.setearParametro("@precio", articulo.precio);
                datos.setearParametro("@idMarca", articulo.marca.id);
                datos.setearParametro("@idCategoria", articulo.categoria.id);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
    }
}
