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

    public partial class PlatosForm : Form
    {
        private string connectionString;
        public PlatosForm()
        {
            InitializeComponent();
            connectionString = Conexion.ConexionBD.ConnectionString;
        }

        private void lblPlateName_Click(object sender, EventArgs e)
        {

        }

        private void lblPrice_Click(object sender, EventArgs e)
        {

        }

        private void btnSavePlate_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection conexion = new MySqlConnection(connectionString))
                {
                    string query = "INSERT INTO platos (name, description, price) VALUES (@name, @description, @price)";
                    MySqlCommand cmd = new MySqlCommand(query, conexion);
                    cmd.Parameters.AddWithValue("@name", txtPlate.Text);
                    cmd.Parameters.AddWithValue("@description", txtDescription.Text);
                    cmd.Parameters.AddWithValue("@price", Convert.ToDecimal(txtPrice.Text));

                    conexion.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Plato agregado correctamente");

                   
                    ActualizarDataGridViewPlatos();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar plato: " + ex.Message);
            }

        }
        private void PlatosForm_Load(object sender, EventArgs e)
        {
         
            ActualizarDataGridViewPlatos();
        }

        private void ActualizarDataGridViewPlatos()
        {
            try
            {
                using (MySqlConnection conexion = new MySqlConnection(connectionString))
                {
                    string query = "SELECT id, name, description, price FROM platos";
                    MySqlCommand cmd = new MySqlCommand(query, conexion);

                    conexion.Open();
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    dataGridViewPlatos.DataSource = table;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar DataGridView: " + ex.Message);
            }
        }

    }
}
