using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace Aula_18_OO_Encapsulamento
{
    public class Executar
    {
        static void Main(string[] args)
        {
            Produto p = new Produto("Bomba Atomica", 10000);
            // Vou alterar o nome do produto
            // p.setNome("Bomba Nuclear");
            // Agora vou utilizar a propriedade
            Console.WriteLine("Nome: " + p.Nome + " Preço: " + p.Preco + " Quantidade: " + p.GetQuantidade());
            
            p.Nome = "B";

            // Vou alterar o preço do produto
            p.Preco= 20000;
            // Vou alterar a quantidade do produto
            p.SetQuantidade(10);
            // Vou imprimir todos eles
            // Imprimir pelo TOString
            Console.WriteLine(p.ToString());

            // Algumas funnções para validar seus tipos e Propriedades
            // A classe type representa o metadados de uma classe em tempo de execução
            Type t = typeof(Produto); // Vai retornar o tipo da classe, 
            Console.WriteLine(t.Name); // Vai retornar o nome da classe


            // Vou mostrar todas as suas proprieadades
            Console.WriteLine("Propriedades: ");
            foreach (PropertyInfo prop in t.GetProperties())
            {
                // O PropertyInfo é uma classe que representa uma propriedade de um tipo
                Console.WriteLine(prop.Name);
            }

        }
    }
}