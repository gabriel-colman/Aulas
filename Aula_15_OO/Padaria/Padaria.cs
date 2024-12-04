using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_15_OO
{
    public class Padaria
    {
        public string NomeAlimento;
        public double Preco;
        public string Bebidas;
        public string Doces;
        public DateTime DataValidade;

        public string EncomendaI()
        {
            return "Encomenda de " + NomeAlimento + " do valor" + Preco + " foi realizada com sucesso!";
        }

        // public double CestaCompras(string NomeAlimento, double Preco)
        // {
        //     return Preco;
        // }

        public double CestaCompras(List<(string NomeAlimento, double Preco)> itens)
        {
            double total = 0;

            // Itera pelos itens da lista e soma os precos
            foreach (var item in itens)
            {
                Console.WriteLine($"Item: {item.NomeAlimento}, Preco: {item.Preco}");
                total += item.Preco;
            }

            return total;
        }
    }
}