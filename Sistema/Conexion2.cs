using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace Sistema
{
    class Conexion2
    {
        public static MySqlConnection obtenerConexion2()
        {
            MySqlConnection conexion2 = new MySqlConnection("server=127.0.0.1;database=productos;Uid=root;pwd=jesmal123;");
            conexion2.Open();
            return conexion2;
        }
    }
}
