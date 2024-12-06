using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_16_OO
{
    public class Laticinios 
    {
                 public string Nome;  // Nome do laticínio
        public double Preco; // Preço unitário
        public int Quantidade; // Quantidade em estoque

        // Construtor sem parâmetros
        public Laticinios()
        {
            Nome = "Laticínio Genérico";
            Preco = 0.0;
            Quantidade = 0;
        }

        // Construtor com parâmetros
        public Laticinios(string nome, double preco, int quantidade)
        {
            this.Nome = nome;
            this.Preco = preco;
            this.Quantidade = quantidade;
        }

        // Método para calcular o valor total do estoque
        public double CalcularValorEstoque()
        {
            return Preco * Quantidade;
        }

        // Listar informações do laticínio
        public void ListarInfo()
        {
            Console.WriteLine("Nome: " + Nome);
            Console.WriteLine("Preço: " + Preco.ToString("F2"));
            Console.WriteLine("Quantidade: " + Quantidade);
            Console.WriteLine("Valor total em estoque: " + CalcularValorEstoque().ToString("F2"));
        }
    }
}