using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto2Form.Clases
{
    public class Detalle
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int DishId { get; set; }
        public int Quantity { get; set; }
        public decimal Subtotal { get; set; }

        public Detalle(int id, int orderId, int dishId, int quantity, decimal subtotal)
        {
            Id = id;
            OrderId = orderId;
            DishId = dishId;
            Quantity = quantity;
            Subtotal = subtotal;
        }

      
        public override string ToString()
        {
            return $"Id: {Id}, OrderId: {OrderId}, DishId: {DishId}, Quantity: {Quantity}, Subtotal: {Subtotal:C}";
        }
    }

}
