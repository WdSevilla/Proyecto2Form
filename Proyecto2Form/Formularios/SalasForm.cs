using MySql.Data.MySqlClient;
using Proyecto2Form.Utilidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto2Form.Formularios
{
    public partial class SalasForm : Form
    {
        private string connectionString;
        public SalasForm()
        {
            InitializeComponent();
            connectionString = Conexion.ConexionBD.ConnectionString;
        }

              private void SalasForm_Load(object sender, EventArgs e)
        {
            
            ActualizarDataGridViewSalas();
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection conexion = new MySqlConnection(connectionString))
                {
                    string query = "INSERT INTO salas (name, capacity) VALUES (@name, @capacity)";
                    MySqlCommand cmd = new MySqlCommand(query, conexion);
                    cmd.Parameters.AddWithValue("@name", txtNombreSala.Text);
                    cmd.Parameters.AddWithValue("@capacity", Convert.ToInt32(txtCapacidad.Text));

                    conexion.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Sala agregada correctamente");

                    
                    ActualizarDataGridViewSalas();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar sala: " + ex.Message);
            }
        }
        private void ActualizarDataGridViewSalas()
        {
            try
            {
                using (MySqlConnection conexion = new MySqlConnection(connectionString))
                {
                    string query = "SELECT id, name, capacity FROM salas";
                    MySqlCommand cmd = new MySqlCommand(query, conexion);

                    conexion.Open();
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    dataGridViewSalas.DataSource = table;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar DataGridView: " + ex.Message);
            }
        }
    }

}

