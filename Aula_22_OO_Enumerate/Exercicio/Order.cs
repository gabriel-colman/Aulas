using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_22_OO_Enumerate.Exercicio
{
    public class Order
    {
        public DateTime moment { get; set; }
        public OrderStatus status { get; set; }

        // Aqui pode ter relação de dependência com a classe Client
        // Relação de dependência é quando uma classe depende de outra para funcionar
        // Assim, a classe Order depende da classe Client para funcionar
        // Para o UML, a relação de dependência é representada por uma linha tracejada com uma seta
        public Client client { get; set; }

        public void AddItem(OrderItem item)
        {
            // Aduciona um item a lista de itens
            List<OrderItem> items = new List<OrderItem>();
            items.Add(item);
            
        }

        public void RemoveItem(OrderItem item)
        {
            // Remove um item da lista de itens
            List<OrderItem> items = new List<OrderItem>();
            items.Remove(item);
        }

        public double Total()
        {
            // Calcula o total do pedido
            double total = 0;
            List<OrderItem> items = new List<OrderItem>();
            foreach (OrderItem item in items)
            {
                total += item.subTotal();
            }
            return total;
        }
    }
}