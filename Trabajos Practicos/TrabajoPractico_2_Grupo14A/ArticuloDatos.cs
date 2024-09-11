using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient; //Libreria para DDBB

namespace TrabajoPractico_2_Grupo14A
{
    internal class ArticuloDatos
    {
        public List<Articulo> listaArticulos()
        {
            List<Articulo> lista = new List<Articulo>();
            SqlConnection conexion = new SqlConnection(); // Setear conexion
            SqlCommand comando = new SqlCommand(); // Realiza acciones
            SqlDataReader lector; // No se crea instancia - aloja datos - no se crea instancia por que no se tiene un constructor

            try
            {
                conexion.ConnectionString = "server=.\\SQLEXPRESS; database=CATALOGO_P3_DB; integrated security=false; user=sa; password=123456";
                // para windows authentication se usa --> integrated security=true y no se pone user y pass
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "SELECT Id, Codigo, Nombre, Descripcion FROM ARTICULOS";
                comando.Connection = conexion;

                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.Id = lector.GetInt32(0);
                    aux.Codigo = lector.GetString(1);
                    aux.Nombre = lector.GetString(2);
                    aux.Descripcion = (string)lector["Descripcion"]; // Esta opcion realmente es mas comoda
                    //aux.Precio = lector.GetFloat(4);

                    lista.Add(aux);
                }
                conexion.Close();
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            
        }
    }
}
