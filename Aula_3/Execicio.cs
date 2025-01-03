// Exercício 1: Calculadora Financeira
// •	Crie uma calculadora financeira que:
// o	Receba um valor inicial e um tipo de investimento (1 - Poupança, 2 - Renda Fixa, 3 - Ações).
// o	Para cada tipo de investimento, aplique uma taxa de rendimento diferente:
// 	    Poupança: 3% ao ano
// 	    Renda Fixa: 5% ao ano
// 	Ações: cálculo de 10% ao ano, mas com uma chance de perda de 5% (use uma estrutura condicional).
// o	Pergunte quantos anos o usuário deseja investir e, no final, exiba o saldo final estimado.


using System;

namespace Aula_3
{
    public class Calculadora
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Digite o valor do investimento: ");
            double valorInvestido = double.Parse(Console.ReadLine());

            System.Console.WriteLine("Escollha o tipo de investimento: ");
            System.Console.WriteLine("1 - Poupança (3% ao ano)");
            System.Console.WriteLine("2 - Renda Fixa (5% ao ano)");
            System.Console.WriteLine("3 - CDB (10% ao ano com chance de perda de 5%)");
            int tipoInvestimento = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o numero de anos que deseja investir: ");
            int anos = int.Parse(Console.ReadLine());

            double taxa;

            if (tipoInvestimento == 1)
            {
                taxa = 1.03;
            }
            else if (tipoInvestimento == 2)
            {
                taxa = 1.05;
            }
            else if (tipoInvestimento == 3)
            {
                taxa = (anos >= 10) ? 1.1 : 1.05;
            }
            else
            {
                System.Console.WriteLine("Tipo de investimento inválido");
                return;
            }

            double valorFinal = valorInvestido * Math.Pow(taxa, anos);

            System.Console.WriteLine($"O valor final do investimento é: {valorFinal}");
        }
    }
}