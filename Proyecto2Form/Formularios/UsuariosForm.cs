using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto2Form;
using Proyecto2Form.Utilidades;
namespace Proyecto2Form.Formularios
{
    public partial class UsuariosForm : Form
    {
        private string connectionString;
        public UsuariosForm()
        {
            InitializeComponent();
            connectionString = Conexion.ConexionBD.ConnectionString;
        }
        private void FormularioUsuarios_Load(object sender, EventArgs e)
        {
            
            ActualizarDataGridViewUsuarios();
        }
        private void lblId_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardarUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection conexion = new MySqlConnection(connectionString))
                {
                    string query = "INSERT INTO usuarios (username, password, role) VALUES (@username, @password, @role)";
                    MySqlCommand cmd = new MySqlCommand(query, conexion);
                    cmd.Parameters.AddWithValue("@username", txtUsername.Text);
                    cmd.Parameters.AddWithValue("@password", txtPassword.Text);
                    cmd.Parameters.AddWithValue("@role", txtRole.Text);

                    conexion.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Usuario agregado correctamente");

                    
                    ActualizarDataGridViewUsuarios();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar usuario: " + ex.Message);
            }
        }
    
        private void ActualizarDataGridViewUsuarios()
        {
            try
            {
                using (MySqlConnection conexion = new MySqlConnection(connectionString))
                {
                    string query = "SELECT id, username, role FROM usuarios";
                    MySqlCommand cmd = new MySqlCommand(query, conexion);

                    conexion.Open();
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    dataGridViewUsuarios.DataSource = table;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar DataGridView: " + ex.Message);
            }
        }

        private void btnEliminarUsuario_Click(object sender, EventArgs e)
        {
        
            if (dataGridViewUsuarios.SelectedRows.Count > 0)
            {
                int idUsuario = Convert.ToInt32(dataGridViewUsuarios.SelectedRows[0].Cells["id"].Value);

                try
                {
                    using (MySqlConnection conexion = new MySqlConnection(connectionString))
                    {
                        string query = "DELETE FROM usuarios WHERE id = @id";
                        MySqlCommand cmd = new MySqlCommand(query, conexion);
                        cmd.Parameters.AddWithValue("@id", idUsuario);

                        conexion.Open();
                        int filasAfectadas = cmd.ExecuteNonQuery();
                        if (filasAfectadas > 0)
                        {
                            MessageBox.Show("Usuario eliminado correctamente");
                         
                            ActualizarDataGridViewUsuarios();
                        }
                        else
                        {
                            MessageBox.Show("No se pudo eliminar el usuario");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar usuario: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Seleccione un usuario para eliminar");
            }
        }
    }
}
