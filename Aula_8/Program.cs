using System;

namespace Aula_8
{
    class Program
    {
        // Função estática que recebe dois inteiros e retorna a soma deles
        static int soma(int a, int b)
        {
            return a + b;
        }

        // Procedimento 
        static void imprimir(string texto)
        {
            Console.WriteLine(texto);
        }

        // Função com 3 parâmetros
        static double multiplicacao(double a, double b, double c)
        {
            return a * b * c;
        }

        // Função com valores nos parametros
        static double multiplicacao2(double a = 10, double b = 20, double c = 30)
        {
            return a * b * c;
        }

        // Função com parametros de vetor
        static int somaVetor(int[] vetor)
        {
            int soma = 0;
            for (int i = 0; i < vetor.Length; i++)
            {
                soma += vetor[i];
            }
            return soma;
        }
        // Função com parametros de Matriz
        static int somaMatriz(int[,] matriz)
        {
            int soma = 0;
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    soma += matriz[i, j];
                }
            }
            return soma;
        }

        // static void Main(string[] args)
        static void Teste()
        {
            int a = 10;
            int b = 20;
            int resultado = soma(a, b);
            // Console.WriteLine("A soma de {0} e {1} e a soma deles é{2}", a, b, resultado);

            // Chamar o procedimento imprimir
            // Console.WriteLine(imprimir("Olá Mundo!")); // ta errado
            // o certo é chamar o procedimento imprimir sem o Console.WriteLine
            // imprimir("Olá Mundo!");
            // Chamar a função multiplicacao
            double x = 10;
            double y = 20;
            double z = 30;

            double resultado2 = multiplicacao(x, y, z);
            // Console.WriteLine("O resultado da multiplicação é: {0}", resultado2);

            // Chamar a função multiplicacao2
            double resultado3 = multiplicacao2(2, 5); // substitui os valores já existente
            // Console.WriteLine("O resultado da multiplicação é: {0}", resultado3);

            // Chamar a função somaVetor
            int[] vetor = { 1, 2, 3, 4, 5 };
            int resultado4 = somaVetor(vetor);
            Console.WriteLine("O resultado da soma do vetor é: {0}", resultado4);

            // Chamar a função somaMatriz
            int[,] matriz = { { 1, 2, 3 }, { 4, 5, 6 } };
            int resultado5 = somaMatriz(matriz);
            Console.WriteLine("O resultado da soma da matriz é: {0}", resultado5);
        }
    }
}