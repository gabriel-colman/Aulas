using System;
using System.Security.Cryptography;
namespace Exemplo
{
    internal class Program
    {
        static void Teste()
        {
            int idade;
            idade = 1;
            double saldo = 10.504534;
            string nome = "Maria Conceição";

            Console.WriteLine("Olá "+ nome + ", sua idade é" + idade + "o saldo é "+ saldo);
            // Ou
            Console.WriteLine("{0} tem {1} anos e tem um saldo igual {2:F2} reais", nome, idade, saldo);
            // Ou Interpolação
            Console.WriteLine($"{nome} tem {idade} anos e tem saldo {saldo}");
        }
    }
}