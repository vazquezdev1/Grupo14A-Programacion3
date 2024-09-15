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
                //string consulta = "SELECT a.Id, a.Codigo, a.Nombre, a.Descripcion, a.Precio, m.Descripcion as Marca, c.Descripcion as Categoria, i.ImagenUrl FROM ARTICULOS a INNER JOIN IMAGENES i ON a.Id = i.IdArticulo INNER JOIN MARCAS m ON a.IdMarca = m.Id INNER JOIN CATEGORIAS c ON a.IdCategoria = c.Id";
                string consulta = "SELECT a.Id, a.Codigo, a.Nombre, a.Descripcion, a.IdCategoria, a.IdMarca, a.Precio, m.Descripcion as Marca, c.Descripcion as Categoria, i.ImagenUrl FROM ARTICULOS a INNER JOIN IMAGENES i ON a.Id = i.IdArticulo INNER JOIN MARCAS m ON a.IdMarca = m.Id INNER JOIN CATEGORIAS c ON a.IdCategoria = c.Id";

                datos.setearConsulta(consulta);
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.Id = datos.Lector.GetInt32(0);
                    aux.Codigo = datos.Lector.GetString(1);
                    aux.Nombre = datos.Lector.GetString(2);
                    aux.Descripcion = (string)datos.Lector["Descripcion"]; // Esta opcion realmente es mas comoda
                    aux.Precio = datos.Lector.GetDecimal(6);
                    aux.Marca = new Marca();
                    aux.Marca.Id = datos.Lector.GetInt32(4);
                    aux.Marca.Descripcion = (string)datos.Lector["Marca"];
                    aux.Categoria = new Categoria();
                    aux.Categoria.Id = datos.Lector.GetInt32(5);
                    aux.Categoria.Descripcion = (string)datos.Lector["Categoria"];
                    aux.UrlImagen = (string)datos.Lector["ImagenUrl"];

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
            string sql2 = "select * from ARTICULOS where Codigo = @codigo";
            string sql3 = "insert into IMAGENES (IdArticulo, ImagenUrl)" + "values (@IdArticulo, @ImagenUrl)";

            try
            {
                datos.setearConsulta(sql);
                datos.setearParametro("@codigo", articulo.Codigo);
                datos.setearParametro("@nombre", articulo.Nombre);
                datos.setearParametro("@descripcion", articulo.Descripcion);
                datos.setearParametro("@precio", articulo.Precio);
                datos.setearParametro("@idMarca", articulo.Marca.Id);
                datos.setearParametro("@idCategoria", articulo.Categoria.Id);
                datos.ejecutarAccion();
                datos.cerrarConexion();

                datos.setearConsulta(sql2);
                datos.ejecutarLectura();
                Articulo aux = new Articulo();
                datos.Lector.Read();
                aux.Id = datos.Lector.GetInt32(0);
                datos.cerrarConexion();

                datos.setearConsulta(sql3);
                datos.setearParametro("@IdArticulo", aux.Id);
                datos.setearParametro("@ImagenUrl", articulo.UrlImagen);
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
        public void eliminar(int id)
        {
            AccesoDatos datos = new AccesoDatos();
            string sql = "delete from ARTICULOS where Id = @Id";
            try
            {
                datos.setearConsulta(sql);
                datos.setearParametro("@Id", id);
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

        public void modificar(Articulo artic)
        {
            AccesoDatos datos = new AccesoDatos();
            string sql = "update ARTICULOS set Codigo = @codigo, Nombre = @nombre, Descripcion = @descrip, idCategoria = @idcat, idMarca = @idmarc, Precio = @precio WHERE Id = @Id";

            try
            {
                datos.setearConsulta(sql);

                datos.setearParametro("@codigo", artic.Codigo);
                datos.setearParametro("@nombre", artic.Nombre);
                datos.setearParametro("@descrip", artic.Descripcion);
                datos.setearParametro("@idcat", artic.Marca.Id);
                datos.setearParametro("@idmarc", artic.Marca.Id);
                datos.setearParametro("@precio", artic.Precio);
                datos.setearParametro("@Id", artic.Id);
                //datos.setearParametro("@imgurl", artic.UrlImagen);

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
