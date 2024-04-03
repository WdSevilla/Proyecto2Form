using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto2Form.Clases
{
    public class MesaEstado
    {
        public int IdMesa { get; set; }
        public bool Activa { get; set; }
        public List<string> Pedidos { get; set; }
        public List<string> Items { get; set; }
        public int IdPedido { get; set; }

        public MesaEstado(int idMesa, bool activa)
        {
            IdMesa = idMesa;
            Activa = activa;
            Pedidos = new List<string>();
        }
    }

}
