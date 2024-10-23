using System;
using System.Security.Cryptography;
namespace Exemplo
{
    internal class ExercicioFixacao
    {
        static void Teste()
        {
            String produto = "Computador";
            String produto2 = "Mesa de Escritorio";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.234567;

            Console.WriteLine("Produtos:");
            Console.WriteLine($"{produto}, cujo preço é $ {preco1}");
            Console.WriteLine($"{produto2}, cujo preço é $ {preco2}");

            Console.WriteLine();
            Console.WriteLine($"Registro: {idade} anos de idade, código {codigo} e gênero: {genero}");  
            Console.WriteLine();

            Console.WriteLine($"Medida com oito casas decimais: {medida:F8}");
            Console.WriteLine($"Arredondado (três casas decimais): {medida:F3}");   
            Console.WriteLine("Separador decimal invariant culture: " + medida.ToString("F3", System.Globalization.CultureInfo.InvariantCulture));
        }
    }
}