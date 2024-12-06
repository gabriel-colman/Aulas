using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_16_OO
{
    public class Carnes
    {
        public string Nome;  // Nome da carne
        public double Preco; // Preço por quilo
        public int Quantidade; // Quantidade em estoque em quilos

        // Construtor sem parâmetros
        public Carnes()
        {
            Nome = "Carne Genérica";
            Preco = 0.0;
            Quantidade = 0;
        }

        // Construtor com alguns parâmetros
        public Carnes(string nome)
        {
            this.Nome = nome;
            Preco = 0.0;
            Quantidade = 0;
        }

        // Construtor com parâmetros
        public Carnes(string nome, double preco, int quantidade)
        {
            this.Nome = nome; // 'this' referencia o atributo da classe
            this.Preco = preco;
            this.Quantidade = quantidade;
        }

        // Método para calcular o valor total do estoque
        public double CalcularValorEstoque()
        {
            return Preco * Quantidade;
        }
    }
}