/*
Aqui está o enunciado atualizado para incluir o uso de um laço de repetição, de forma que o cálculo do saldo seja feito ano a ano, aplicando a "chance de perda" de 5% para o tipo de investimento em ações:
________________________________________
Exercício 1: Calculadora Financeira com Cálculo Anual
Crie uma calculadora financeira que:
1.	Solicite um valor inicial e um tipo de investimento:
o	1 - Poupança (3% ao ano)
o	2 - Renda Fixa (5% ao ano)
o	3 - Ações (10% ao ano, mas com uma chance de perda que reduz a taxa para 5% em alguns anos)
2.	Pergunte quantos anos o usuário deseja investir.
3.	A cada ano, aplique a taxa de rendimento correspondente:
o	Para o tipo Poupança, aplique uma taxa fixa de 3% ao ano.
o	Para o tipo Renda Fixa, aplique uma taxa fixa de 5% ao ano.
o	Para o tipo Ações, aplique uma taxa de 10% ao ano, mas reduza para 5% a cada alguns anos, simulando uma "chance de perda" no rendimento.
4.	Exiba o saldo ao final de cada ano e o saldo final após o período total de investimento.

*/
using System;

namespace Aula_4
{
    class Exercicio1
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o valor inicial do investimento: ");
            double valorInicial = double.Parse(Console.ReadLine());

            Console.WriteLine("Escolha o tipo de investimento:");
            Console.WriteLine("1 - Poupança (3% ao ano)");
            Console.WriteLine("2 - Renda Fixa (5% ao ano)");
            Console.WriteLine("3 - Ações (10% ao ano com chance de perda para 5%)");
            int tipoInvestimento = int.Parse(Console.ReadLine());

            Console.Write("Digite o número de anos que deseja investir: ");
            int anos = int.Parse(Console.ReadLine());

            double saldoFinal = valorInicial;

            for (int ano = 1; ano <= anos; ano++)
            {
                double taxa = 0;
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
                    taxa = (ano % 4 == 0) ? 1.05 : 1.10;
                }
                else
                {
                    Console.WriteLine("Tipo de investimento inválido");
                    return;
                }

                saldoFinal *= taxa;
                System.Console.WriteLine($"Saldo após {ano} ano(s): {saldoFinal}");

            }
            System.Console.WriteLine($"Saldo final após {anos} ano(s): {saldoFinal}");



        }

    }
}