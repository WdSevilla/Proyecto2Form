using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using System.Xml.Linq;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Chunk = iTextSharp.text.Chunk;
using System.Diagnostics;
using Proyecto2Form.Utilidades;
namespace Proyecto2Form.Formularios
{
    public partial class PedidoForm : Form
    {
        public bool PedidoGuardado { get; private set; }
        private string connectionString;
        private List<string> itemsSeleccionados = new List<string>();


        public PedidoForm()
        {
            InitializeComponent();
            connectionString = Conexion.ConexionBD.ConnectionString;
            dataGridViewPlatoPedido.Columns.Add("id", "Id");
            dataGridViewPlatoPedido.Columns.Add("nombre", "Nombre");
            dataGridViewPlatoPedido.Columns.Add("cantidad", "Cantidad");
            dataGridViewPlatoPedido.Columns.Add("precio", "Precio");
        }

        private void PedidoForm_Load(object sender, EventArgs e)
        {
            CargarUsuarios();
           
            if (dataGridViewPlatos.Columns.Contains("id"))
            {
                dataGridViewPlatos.Columns["id"].Visible = false;
            }

           
            if (dataGridViewPlatoPedido.Columns.Contains("id"))
            {
                dataGridViewPlatoPedido.Columns["id"].Visible = false;
            }
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
                MessageBox.Show("Error al cargar platos: " + ex.Message);
            }
        }
        private void dataGridViewPlatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewPlatos.Rows[e.RowIndex];
                int platoId = Convert.ToInt32(row.Cells["id"].Value);
                string platoNombre = row.Cells["name"].Value.ToString();
                decimal platoPrecio = Convert.ToDecimal(row.Cells["price"].Value);
                itemsSeleccionados.Add(platoNombre);
                
                bool platoExistente = false;
                foreach (DataGridViewRow pedidoRow in dataGridViewPlatoPedido.Rows)
                {
                    if (Convert.ToInt32(pedidoRow.Cells["id"].Value) == platoId)
                    {
                        
                        int cantidad = Convert.ToInt32(pedidoRow.Cells["cantidad"].Value) + 1;
                        decimal precioTotal = cantidad * platoPrecio;
                        pedidoRow.Cells["cantidad"].Value = cantidad;
                        pedidoRow.Cells["precio"].Value = precioTotal;
                        platoExistente = true;
                        break;
                    }
                }

                if (!platoExistente)
                {
                    dataGridViewPlatoPedido.Rows.Add(platoId, platoNombre, 1, platoPrecio, platoPrecio);
                }

                dataGridViewPlatos.Rows[e.RowIndex].Selected = false;
                ActualizarTotal();
            }
        }
        private void ActualizarTotal()
        {
            decimal total = 0;
            foreach (DataGridViewRow row in dataGridViewPlatoPedido.Rows)
            {
                if (row.Cells["precio"].Value != null)
                {
                    total += Convert.ToDecimal(row.Cells["precio"].Value);
                }
            }
            txtTotal.Text = total.ToString();
        }

        private void CargarUsuarios()
        {
            try
            {
                using (MySqlConnection conexion = new MySqlConnection(connectionString))
                {
                    string query = "SELECT username FROM usuarios";
                    MySqlCommand cmd = new MySqlCommand(query, conexion);

                    conexion.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();
                    comboBoxUsers.Items.Clear();
                    while (reader.Read())
                    {
                        comboBoxUsers.Items.Add(reader["username"].ToString());
                    }
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar usuarios: " + ex.Message);
            }
        }

        private void btnAgregarComentario_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection conexion = new MySqlConnection(connectionString))
                {
                    conexion.Open();
                    foreach (DataGridViewRow row in dataGridViewPlatoPedido.Rows)
                    {
                        if (!row.IsNewRow)
                        {
                            string nombrePlato = row.Cells["nombre"].Value.ToString();
                            int cantidad = Convert.ToInt32(row.Cells["cantidad"].Value);
                            decimal precio = Convert.ToDecimal(row.Cells["precio"].Value);
                            string usuario = comboBoxUsers.SelectedItem.ToString();
                            string comentario = txtComentario.Text;
                            string cliente = txtCliente.Text; 
                            decimal total = Convert.ToDecimal(txtTotal.Text);

                            string query = "INSERT INTO pedidos (usuario, comentario, nombre_plato, cantidad, precio, total, cliente,generado) VALUES (@usuario, @comentario, @nombrePlato, @cantidad, @precio, @total, @cliente, true)";
                            MySqlCommand cmd = new MySqlCommand(query, conexion);
                            cmd.Parameters.AddWithValue("@usuario", usuario);
                            cmd.Parameters.AddWithValue("@comentario", comentario);
                            cmd.Parameters.AddWithValue("@nombrePlato", nombrePlato);
                            cmd.Parameters.AddWithValue("@cantidad", cantidad);
                            cmd.Parameters.AddWithValue("@precio", precio);
                            cmd.Parameters.AddWithValue("@total", total);
                            cmd.Parameters.AddWithValue("@cliente", cliente); 

                            cmd.ExecuteNonQuery();
                        }
                    }
                    MessageBox.Show("Pedidos guardados correctamente");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar pedidos: " + ex.Message);
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            Document doc = new Document();
            try
            {
                PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream("Factura.pdf", FileMode.Create));
                doc.Open();

                // Agregar contenido al documento
                Paragraph header = new Paragraph("Factura de Pedido");
                header.Alignment = Element.ALIGN_CENTER;
                doc.Add(header);
                doc.Add(Chunk.NEWLINE);

                // Información del pedido
                doc.Add(new Paragraph("Usuario: " + comboBoxUsers.SelectedItem.ToString()));
                doc.Add(new Paragraph("Comentario: " + txtComentario.Text));
                doc.Add(new Paragraph("Total: " + txtTotal.Text));
                doc.Add(Chunk.NEWLINE);

                // Detalles del pedido
                PdfPTable table = new PdfPTable(dataGridViewPlatoPedido.Columns.Count);
                // Agregar columnas
                foreach (DataGridViewColumn column in dataGridViewPlatoPedido.Columns)
                {
                    PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                    table.AddCell(cell);
                }
                // Agregar filas
                foreach (DataGridViewRow row in dataGridViewPlatoPedido.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if (cell.Value != null)
                        {
                            table.AddCell(cell.Value.ToString());
                        }
                        else
                        {
                            table.AddCell("");
                        }
                    }
                }

                doc.Add(table);

                MessageBox.Show("PDF generado correctamente");

                



            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar el PDF: " + ex.Message);
            }
            finally
            {
                doc.Close();
            }
            // Imprimir el PDF generado
            ProcessStartInfo info = new ProcessStartInfo();
            info.Verb = "print";
            info.FileName = "Factura.pdf";
            info.CreateNoWindow = true;
            info.WindowStyle = ProcessWindowStyle.Hidden;

            Process p = new Process();
            p.StartInfo = info;
            p.Start();
            p.WaitForInputIdle();
            System.Threading.Thread.Sleep(3000); // Esperar un tiempo para que se inicie la impresión

        }

        private void btnTerminarPedido_Click(object sender, EventArgs e)
        {
            PedidoGuardado = true;
            this.Close();
        }
    }  
    }
