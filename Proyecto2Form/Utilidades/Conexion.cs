using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Proyecto2Form.Utilidades
{
    public class Conexion
    {
        private string connectionString;

        public static class ConexionBD
        {
            public static string ConnectionString = "server=localhost;port=3306;database=proyecto2;uid=root;password=12qa90pl;";
        }

        public MySqlConnection ObtenerConexion()
        {
            return new MySqlConnection(connectionString);
        }
    }
}
