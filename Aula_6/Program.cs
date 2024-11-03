using System;

namespace Aula_6;

    class Program
    {
        static void Main()
        {
            // Formas de declara um Matriz
            int[,] matriz1 = new int[2, 2]; // 2 linhas e 2 colunas
            int[,] matriz2 = new int[2, 2] {
            { 1, 2 }, // linha 0 tem 1 e 2, linha 1 tem 3 e 4
            { 3, 4 } // coluna 0 tem 1 e 3, coluna 1 tem 2 e 4
        };
            // Acessando elementos da matriz
            // Console.WriteLine(matriz2[0, 0]); // 1
            // Console.WriteLine(matriz2[0, 1]); // 2

            // Percorrendo a matriz
            for (int i = 0; i < matriz2.GetLength(0); i++)
            {
                for (int j = 0; j < matriz2.GetLength(1); j++)
                {
                    // Console.WriteLine(matriz2[i, j]);
                }
            }

            // Somando os elementos da matriz
            int[,] matrizA = {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };
            int[,] matrizB = {
            { 9, 8, 7 },
            { 6, 5, 4 },
            { 3, 2, 1 }
        };
            int[,] matrizC = new int[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    matrizC[i, j] = matrizA[i, j] + matrizB[i, j];
                }
            }
            // Exibindo a matriz C
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(matrizC[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }



