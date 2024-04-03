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
    public partial class PedidosActivos : Form
    {
        private string connectionString;
        public PedidosActivos()
        {
            InitializeComponent();
            connectionString = Conexion.ConexionBD.ConnectionString;
        }

        private void PedidosActivos_Load(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection conexion = new MySqlConnection(connectionString))
                {
                    string query = "SELECT comentario, cliente, SUM(precio) as total FROM pedidos WHERE generado = 1 GROUP BY comentario, cliente";
                    MySqlCommand cmd = new MySqlCommand(query, conexion);

                    conexion.Open();
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    dataGridViewPedidosActivos.DataSource = table;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar pedidos activos: " + ex.Message);
            }
        }
      
        private void btnFinalizarPedido_Click(object sender, EventArgs e)
        {
            if (dataGridViewPedidosActivos.SelectedRows.Count > 0)
            {
                try
                {
                    using (MySqlConnection conexion = new MySqlConnection(connectionString))
                    {
                       
                        string comentario = dataGridViewPedidosActivos.SelectedRows[0].Cells["comentario"].Value.ToString();
                        string cliente = dataGridViewPedidosActivos.SelectedRows[0].Cells["cliente"].Value.ToString();
                        decimal total = Convert.ToDecimal(dataGridViewPedidosActivos.SelectedRows[0].Cells["total"].Value);

                        string query = "UPDATE pedidos SET generado = false WHERE comentario = @comentario AND cliente = @cliente AND total = @total";
                        MySqlCommand cmd = new MySqlCommand(query, conexion);
                        cmd.Parameters.AddWithValue("@comentario", comentario);
                        cmd.Parameters.AddWithValue("@cliente", cliente);
                        cmd.Parameters.AddWithValue("@total", total);

                        conexion.Open();
                        cmd.ExecuteNonQuery();

                        
                        dataGridViewPedidosActivos.Rows.RemoveAt(dataGridViewPedidosActivos.SelectedRows[0].Index);

                        MessageBox.Show("Pedido finalizado correctamente.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al finalizar pedido: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un pedido para finalizar.");
            }
        }
    }
}
