using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient; //Libreria para DDBB
using dominio;
using System.Windows.Forms;

namespace negocio
{
    public class ArticuloNegocio
    {
        public List<Articulo> listaArticulos()
        {
            List<Articulo> lista = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                string consulta = "SELECT a.Id, a.Codigo, a.Nombre, a.Descripcion, a.IdCategoria as 'ID Categoria', a.IdMarca as 'ID Marca', a.Precio, m.Descripcion as Marca, c.Descripcion as Categoria, i.ImagenUrl FROM ARTICULOS a INNER JOIN IMAGENES i ON a.Id = i.IdArticulo LEFT JOIN MARCAS m ON a.IdMarca = m.Id LEFT JOIN CATEGORIAS c ON a.IdCategoria = c.Id";
                datos.setearConsulta(consulta);
                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.Id = (Int32)datos.Lector["Id"];
                    aux.Codigo = (string)datos.Lector["Codigo"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                    aux.Precio = (decimal)datos.Lector["Precio"];
                    aux.Marca = new Marca();
                    aux.Marca.Id = (Int32)datos.Lector["ID Marca"];
                    aux.Marca.Descripcion = (string)datos.Lector["Marca"];
                    aux.Categoria = new Categoria();
                    aux.Categoria.Id = (Int32)datos.Lector["ID Categoria"];
                    ///Validación de NULL para la categoría
                    if (!(datos.Lector["Categoria"] is DBNull))
                    {
                        aux.Categoria.Descripcion = (string)datos.Lector["Categoria"];
                    }
                    else
                    {
                        aux.Categoria.Descripcion = "Ninguna";
                    }
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

        public int agregar(Articulo articulo)
        {
            int respuesta = 0;
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
                respuesta = datos.ejecutarAccion();
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
                respuesta = datos.ejecutarAccion();

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
            string sql2 = "update IMAGENES set ImagenUrl = @imgurl WHERE IdArticulo = @Id";

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
                datos.ejecutarAccion();
                datos.cerrarConexion();

                datos.setearConsulta(sql2);
                datos.setearParametro("@imgurl", artic.UrlImagen);
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
