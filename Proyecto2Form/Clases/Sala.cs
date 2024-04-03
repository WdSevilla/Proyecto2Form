using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto2Form.Clases
{
    public class Sala
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Capacity { get; set; }

        public Sala(int id, string name, int capacity)
        {
            Id = id;
            Name = name;
            Capacity = capacity;
        }

        
        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}, Capacity: {Capacity}";
        }
    }

}
