using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_22_OO_Enumerate.Exercicio
{
    public class OrderItem
    {
        public int quantity { get; set; }
        public double price { get; set; }

        public double subTotal()
        {
            return quantity * price;
        }
    }
}