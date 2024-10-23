using System;
using System.Security.Cryptography;
namespace Exemplo
{
    internal class Tipos1
    {
        static void Teste()
        {
            bool completo = false;
            char genero = 'M';
            char letra = '\u0041'; // A
            byte n1 = 126;
            int n2 = 1000;
            int n3 = 2147483647;
            long n4 = 2147483648L;
            float n5 = 4.5f;
            double n6 = 4.5;
            String nome = "Maria Conceição";
            Object obj1 = "Alex Brown";

            // Concatenação
            Console.WriteLine("Olá " + nome + ", gereo " + genero + ", completo " + completo);
            // Interpolação
            Console.WriteLine($"{nome} tem {n3} anos e tem saldo {n6}");
        
        }
    }
}