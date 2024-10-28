using System;
using System.Security.Cryptography;
namespace Aula_3
{
    internal class Ternario
    {
        static void Teste()
        {
            int idade = 15;
            string resutado = idade > 18 ? "Adulto" : "Criança"; // 2 condições
            System.Console.WriteLine(resutado);

            // 3 condições
            string resutado2 = idade > 18 ? "Adulto" : 
            idade > 50 ? "Idoso" : "Criança";
        }
    }
}

