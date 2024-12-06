using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_16_OO
{
    // public class Ferramentas
    // {
    // Contrutor usando record que é uma nova funcionalidade do C# 9
    public record Ferramentas (string Nome, double Preco, int Quantidade)
    {
        // record é uma nova funcionalidade do C# 9 que permite criar classes 
        // imutáveis que quer dizer que não podem ser alteradas após a sua criação

        // public string Nome;  // Nome da ferramenta
        // public double Preco; // Preço unitário
        // public int Quantidade; // Quantidade em estoque

        // // Construtor sem parâmetros
        // public Ferramentas()
        // {
        //     Nome = "Ferramenta Genérica";
        //     Preco = 0.0;
        //     Quantidade = 0;
        // }

        // // Construtor com parâmetros
        // public Ferramentas(string nome, double preco, int quantidade)
        // {
        //     this.Nome = nome;
        //     this.Preco = preco;
        //     this.Quantidade = quantidade;
        // }

        // Método para calcular o valor total do estoque
        public double CalcularValorEstoque()
        {
            return Preco * Quantidade;
        }
    }
}