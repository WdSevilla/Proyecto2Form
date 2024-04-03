using MySql.Data.MySqlClient;
using Proyecto2Form.Clases;
using Proyecto2Form.Formularios;
using Proyecto2Form.Utilidades;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Proyecto2Form
{
    public partial class Form1 : Form
    {
        private PictureBox mesaSeleccionada;
        private MesaEstado mesaEstadoSeleccionada;
        private Point mouseOffset;
        private bool isMouseDown = false;
        private Panel selectedPanel = null;
        private string connectionString;
        private Dictionary<string, List<MesaEstado>> mesasPorSala = new Dictionary<string, List<MesaEstado>>();
        private Dictionary<string, List<int>> mesasAbiertasPorSala = new Dictionary<string, List<int>>();
        private Dictionary<int, PedidoForm> formulariosAbiertosPorMesa = new Dictionary<int, PedidoForm>();
        private Dictionary<int, MesaEstado> mesasActivas = new Dictionary<int, MesaEstado>();
        private Dictionary<string, List<MesaEstado>> mesasActivasPorSala = new Dictionary<string, List<MesaEstado>>();

        private string salaActual;
        private PictureBox mesaActiva = null;

        public Form1()
        {
            InitializeComponent();
            connectionString = Conexion.ConexionBD.ConnectionString;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ActualizarListBoxSalas();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UsuariosForm usuariosForm = new UsuariosForm();
            usuariosForm.Show();
        }

        private void asToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            PlatosForm platosForm = new PlatosForm();
            platosForm.Show();
        }

        private void salasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SalasForm salasForm = new SalasForm();
            salasForm.Show();
        }

        private void lblSalasDisplay_Click(object sender, EventArgs e)
        {

        }

        private void listBoxSalas_SelectedIndexChanged(object sender, EventArgs e)
        {
            string salaSeleccionada = listBoxSalas.SelectedItem.ToString();
            MessageBox.Show("Sala seleccionada: " + salaSeleccionada);
            int cantidadMesas = ObtenerCantidadMesas(salaSeleccionada);
            DibujarRectangulos(salaSeleccionada, cantidadMesas);
            salaActual = salaSeleccionada;

          
            if (mesasActivasPorSala.ContainsKey(salaSeleccionada))
            {
                foreach (PictureBox mesa in panel2.Controls.OfType<PictureBox>())
                {
                    int idMesa = int.Parse(mesa.Name.Substring(4)); 
                    if (mesasActivasPorSala[salaSeleccionada].Any(m => m.IdMesa == idMesa))
                    {
                        mesa.BackColor = Color.Red; 
                    }
                }
            }
        }

        private void ActualizarListBoxSalas()
        {
            try
            {
                using (MySqlConnection conexion = new MySqlConnection(connectionString))
                {
                    string query = "SELECT name FROM salas";
                    MySqlCommand cmd = new MySqlCommand(query, conexion);

                    conexion.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();
                    listBoxSalas.Items.Clear();
                    while (reader.Read())
                    {
                        listBoxSalas.Items.Add(reader["name"].ToString());
                    }
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar salas: " + ex.Message);
            }
        }

        private int ObtenerCantidadMesas(string nombreSala)
        {
            int capacidadSala = 0;
            try
            {
                using (MySqlConnection conexion = new MySqlConnection(connectionString))
                {
                    string query = "SELECT capacity FROM salas WHERE name = @sala";
                    MySqlCommand cmd = new MySqlCommand(query, conexion);
                    cmd.Parameters.AddWithValue("@sala", nombreSala);

                    conexion.Open();
                    capacidadSala = Convert.ToInt32(cmd.ExecuteScalar());

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener la capacidad de la sala: " + ex.Message);
            }

            return capacidadSala;
        }

        private void DibujarRectangulos(string nombreSala, int cantidadRectangulos)
        {
            panel2.Controls.Clear();
            int x = 10;
            int y = 10;
            int ancho = 50;
            int alto = 50;
            int idMesa = 1; 
            if (!mesasPorSala.ContainsKey(nombreSala))
            {
                mesasPorSala[nombreSala] = new List<MesaEstado>();
            }
            for (int i = 0; i < cantidadRectangulos; i++)
            {
               
                if (x + ancho > panel2.ClientSize.Width)
                {
                    
                    x = 10;
                    y += alto + 10; 
                }

           
                if (y + alto > panel2.ClientSize.Height)
                {
                    break;
                }

                PictureBox mesa = new PictureBox();
                mesa.BackColor = Color.Blue;
                mesa.Location = new Point(x, y);
                mesa.Size = new Size(ancho, alto);
                mesa.Name = "Mesa" + idMesa; 
                mesa.Click += Mesa_Click; 
                panel2.Controls.Add(mesa);

                x += ancho + 10; 
                idMesa++;
            }
        }

        private void PanelRectangulo_MouseDown(object sender, MouseEventArgs e)
        {
            selectedPanel = (Panel)sender;
            mouseOffset = e.Location;
            isMouseDown = true;
        }

        private void PanelRectangulo_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown && selectedPanel != null)
            {
                Point newLocation = selectedPanel.Location;
                newLocation.X += e.X - mouseOffset.X;
                newLocation.Y += e.Y - mouseOffset.Y;
                selectedPanel.Location = newLocation;
            }
        }

        private void PanelRectangulo_MouseUp(object sender, MouseEventArgs e)
        {
            isMouseDown = false;
            selectedPanel = null;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PedidoForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            PedidoForm pedidoForm = (PedidoForm)sender;


            if (!pedidoForm.PedidoGuardado && mesaSeleccionada != null && mesaEstadoSeleccionada != null)
            {
                mesaSeleccionada.BackColor = Color.Blue;
                mesaEstadoSeleccionada = null; 
            }
            else if (pedidoForm.PedidoGuardado && mesaEstadoSeleccionada != null)
            {
                mesasPorSala[salaActual].Add(mesaEstadoSeleccionada); 
                mesaEstadoSeleccionada = null; 
            }

            mesaSeleccionada = null;
        }
        private int ObtenerIdPedido(int idMesa)
        {
            int idPedido = -1; 

            try
            {
                using (MySqlConnection conexion = new MySqlConnection(connectionString))
                {
                    string query = "SELECT id_pedido FROM mesas WHERE id_mesa = @idMesa";
                    MySqlCommand cmd = new MySqlCommand(query, conexion);
                    cmd.Parameters.AddWithValue("@idMesa", idMesa);

                    conexion.Open();
                    idPedido = Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener el ID del pedido: " + ex.Message);
            }

            return idPedido;
        }

        private void Mesa_Click(object sender, EventArgs e)
        {
            mesaSeleccionada = (PictureBox)sender;
            int idMesa = int.Parse(mesaSeleccionada.Name.Substring(4)); 

            
            if (!mesasPorSala[salaActual].Any(m => m.IdMesa == idMesa))
            {
                mesaEstadoSeleccionada = new MesaEstado(idMesa, true);
                
                mesaEstadoSeleccionada.IdPedido = ObtenerIdPedido(idMesa); 

                mesaSeleccionada.BackColor = Color.Red;

             
                PedidoForm pedidoForm = new PedidoForm();
                pedidoForm.FormClosed += PedidoForm_FormClosed; 
                pedidoForm.ShowDialog();
            }
        }


        private void pedidosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PedidoForm pedidoForm = new PedidoForm();
            pedidoForm.Show();
        }

        private void mesasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PedidosActivos pedidosActivos = new PedidosActivos();
            pedidosActivos.Show();
        }
    }
}
