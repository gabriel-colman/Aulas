using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_10
{
    public class VariaveisImplicitas
    {
        // static void Main(string[] args)
        static void Teste()
        {
            // Variavel implicita é uma variavel que pode receber qualquer tipo de dado
            var nome = "C#";
            Console.WriteLine(nome);
            Console.WriteLine(nome.GetType());

            var idade = 20;
            Console.WriteLine(idade);
            Console.WriteLine(idade.GetType());

            var altura = 1.75;
            Console.WriteLine(altura);
            Console.WriteLine(altura.GetType());

            const double pi = 3.1415;
            Console.WriteLine(pi);
            Console.WriteLine(pi.GetType());

            // Lista
            var lista = new List<int> { 1, 2, 3, 4, 5 };
            Console.WriteLine(lista.GetType());
            // Funcção para listar os elementos da lista
            foreach (var item in lista)
            {
                Console.WriteLine(item);
            }

            // Dicionário
            var dicionario = new Dictionary<string, int>
            {
                {"C#", 1},
                {"Java", 2},
                {"Python", 3}
            };
            Console.WriteLine(dicionario.GetType());
            // Funcção para listar os elementos do dicionário
            foreach (var item in dicionario)
            {
                Console.WriteLine(item);
            }

        }
    }
}