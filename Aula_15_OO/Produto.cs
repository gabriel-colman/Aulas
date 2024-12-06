using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_15_OO
{
    public class Produto
    {
        public string Nome;
        public double Preco;
        
        // Contrutor é um método que é chamado quando a classe é instanciada
        public Produto(string nome, double preco)
        {
            // Atribui o valor do parâmetro nome ao atributo Nome
            this.Nome = nome;
            this.Preco = preco;
        }

        // Construtor sem parâmetros
        public Produto()
        {
            this.Nome = "Sem nome";
            this.Preco = 0;
        }

        public void ExibirInrormacoes()
        {
            Console.WriteLine("Nome: " + this.Nome); // this é uma referência ao objeto que está sendo instanciado
            Console.WriteLine("Preço: " + this.Preco); // this é uma referência ao objeto que está sendo instanciado
        }

        static void Main(string[] args)
        {
            // Produto p1 = new Produto("Notebook", 2000);
            // p1.ExibirInrormacoes();
            Produto p2 = new Produto();
            p2.Nome = "Celular";
            p2.Preco = 1000;
            p2.ExibirInrormacoes();     

        }
    }
}