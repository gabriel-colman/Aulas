using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_16_OO
{
    public class Limpeza
    {
        public string Nome;  // Nome do produto de limpeza
        public double Preco; // Preço unitário
        public int Quantidade; // Quantidade em estoque

        // Construtor sem parâmetros
        public Limpeza()
        {
            Nome = "Produto de Limpeza Genérico";
            Preco = 0.0;
            Quantidade = 0;
        }

        // Construtor com parâmetros
        public Limpeza(string nome, double preco, int quantidade)
        {
            this.Nome = nome;
            this.Preco = preco;
            this.Quantidade = quantidade;
        }

        // Método para calcular o valor total em estoque
        public double CalcularValorEstoque()
        {
            return Preco * Quantidade;
        }
    }
}