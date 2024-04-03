using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace Proyecto2Form.Utilidades
{
    public class VerificadorConexion
    {
        private string connectionString;

        public VerificadorConexion()
        {
            // Cadena de conexión a la base de datos
            connectionString = "server=localhost;port=3306;database=proyecto2;uid=root;password=12qa90pl;";
        }

        public bool VerificarConexion()
        {
            try
            {
                using (MySqlConnection conexion = new MySqlConnection(connectionString))
                {
                    conexion.Open();
                    Console.WriteLine("Conexión exitosa");
                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al conectar a la base de datos: " + ex.Message);
                return false;
            }
        }
    }
}
