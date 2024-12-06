using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_16_OO
{
    public class Petiscos
    {
        public string? Nome;

        public double? Preco;

        public int Quantidade;


        public Petiscos()
        {
            Nome = null;
            Preco = 0;
            Quantidade = 10;

            // Se instanciar
            // Petiscos p = new Petiscos();
            // p.Nome = "Coxinha";
        }

        public Petiscos(string nome, double preco, int quantidade)
        {
            this.Nome = nome;
            this.Preco = preco;
            this.Quantidade = quantidade;

            // Se instanciar
            // Petiscos p = new Petiscos("Coxinha", 5.00, 10);
        }

        public double CalcularValorEstoque() {
            return (double)Preco * Quantidade; 
        }


    }
}