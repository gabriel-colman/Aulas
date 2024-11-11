using System;

namespace Aula_10
{
    class Program
    {
        // static void Main(string[] args)
        static void Teste()
        {
            // Estrutura Linq é uma forma de fazer consultas em coleções de objetos
            int [] numeros = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            // Var é  variavel implicita, que é um objeto que pode receber qualquer tipo de dado
            var numerosImpares = numeros.Where(n => n % 2 != 0); //Where é um método de extensão, que onde n é o parâmetro que será passado para a expressão lambda

            foreach (var numero in numerosImpares)
            {
                Console.WriteLine(numero);
            }
        }
    }
}