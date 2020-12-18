using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace Sistema
{
    class funciones3
    {
        public static string comprar(string usuario, string idproducto, string producto, string precio, string cantidad, string pago, string pagototal, string cambio)
        {
            string mensaje;
            string query = "INSERT INTO ventas (usuario,idproducto, producto , precio, cantidad, pago,pagototal,cambio) VALUES ( '" + usuario + "', '" + idproducto + "','" + producto + "','" + precio + "','" +cantidad+ "','" + pago + "','" + pagototal + "','" + cambio + "');";
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
        public static string eliminar(int id)
        {
            string mensaje;
            string query = "DELETE FROM ventas WHERE id =" + id + ";";
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
        public static List<productoss> mostrar()
        {
            List<productoss> lista = new List<productoss>();
            MySqlCommand sentencia = new MySqlCommand(String.Format("select id,usuario,idproducto, producto , precio, cantidad, pago,pagototal,cambio from ventas"), Conexion2.obtenerConexion2());
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

        public static string actualizar(int id, string usuario, string idproducto, string producto, string precio, string cantidad, string pago, string pagototal, string cambio)
        {
            string mensaje;
            string query = "UPDATE ventas SET usuario='" + usuario +
                "', idproducto='" + idproducto + 
                "',  producto='" + producto +
                "',  precio='"+precio + 
                "',  cantidad ='"+cantidad +
                "',  pago='"+pago + 
                "',  pagototal='"+pagototal +
                "', cambio='"+cambio+ "' WHERE id =" + id + ";";
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
