using MySql.Data.MySqlClient;
using Proyecto2Form.Utilidades;
using System;
using System.Windows.Forms;
using Proyecto2Form.Utilidades;
namespace Proyecto2Form.Formularios
{
    public partial class Login : Form
    {
        private string connectionString;

        public Login()
        {
            InitializeComponent();
           
            connectionString = Conexion.ConexionBD.ConnectionString;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsuario.Text;
            string password = txtPassword.Text;

            bool credencialesValidas = VerificarCredenciales(username, password);

            if (credencialesValidas)
            {
                DialogResult = DialogResult.OK; // Establecer el resultado como OK
                this.Close();
            }
            else
            {
                MessageBox.Show("Credenciales incorrectas. Por favor, inténtelo de nuevo.");
            }
        }

        private bool VerificarCredenciales(string username, string password)
        {
            try
            {
                using (MySqlConnection conexion = new MySqlConnection(connectionString))
                {
                    string query = "SELECT COUNT(*) FROM usuarios WHERE username = @username AND password = @password";
                    MySqlCommand cmd = new MySqlCommand(query, conexion);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);

                    conexion.Open();
                    int count = Convert.ToInt32(cmd.ExecuteScalar());

                    return count > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al verificar las credenciales: " + ex.Message);
                return false;
            }
        }
    }
}
