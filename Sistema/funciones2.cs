using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace Sistema
{
    class funciones2
    {
        public static string insertar(string producto, string precio)
        {
            string mensaje;
            string query = "INSERT INTO producto (productos, precio) VALUES ( '" + producto + "', '" + precio + "');";
            MySqlCommand sentencia = new MySqlCommand(String.Format(query), Conexion2.obtenerConexion2());
            MySqlDataReader lector = sentencia.ExecuteReader();

            if (lector.RecordsAffected > 0)
            {
                mensaje = "OK";
            }
            else
            {
                mensaje = "No se registro usuario";
            }

            return mensaje;
        }
        public static List<productoss> mostrar()
        {
            List<productoss> lista = new List<productoss>();
            MySqlCommand sentencia = new MySqlCommand(String.Format("select id, productos, precio from producto"), Conexion2.obtenerConexion2());
            MySqlDataReader lector = sentencia.ExecuteReader();

            while (lector.Read())
            {
                productoss usr = new productoss();
                usr.id = lector.GetInt32(0);
                usr.productos = lector.GetString(1);
                usr.precio = lector.GetString(2);
                lista.Add(usr);
            }

            return lista;
        }


        public static string eliminar(int id)
        {
            string mensaje;
            string query = "DELETE FROM producto WHERE id =" + id + ";";
            MySqlCommand sentencia = new MySqlCommand(String.Format(query), Conexion2.obtenerConexion2());
            MySqlDataReader lector = sentencia.ExecuteReader();

            if (lector.RecordsAffected > 0)
            {
                mensaje = "OK";
            }
            else
            {
                mensaje = "No se elimino usuario";
            }

            return mensaje;
        }

        public static string actualizar(int id, string productos, string precio)
        {
            string mensaje;
            string query = "UPDATE producto SET productos='" + productos+
                           "', precio='" + precio +
                           "' WHERE id =" + id + ";";
            MySqlCommand sentencia = new MySqlCommand(String.Format(query), Conexion2.obtenerConexion2());
            MySqlDataReader lector = sentencia.ExecuteReader();

            if (lector.RecordsAffected > 0)
            {
                mensaje = "OK";
            }
            else
            {
                mensaje = "No se actualizo usuario";
            }

            return mensaje;
        }








    }
}
