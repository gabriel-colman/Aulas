using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_28_Manipucao2
{
    public class Exercicio1
    {

        static void Main()
        {
            Console.WriteLine("Digite o número de linhas da matriz (N):");
            int rows = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o número de colunas da matriz (M):");
            int cols = int.Parse(Console.ReadLine());

            // Criar e preencher a matriz
            int[,] matrix = GenerateMatrix(rows, cols);
            Console.WriteLine("Matriz Gerada:");
            PrintMatrix(matrix);

            Console.WriteLine("\nEscolha uma operação:");
            Console.WriteLine("1. Soma das Linhas");
            Console.WriteLine("2. Soma das Colunas");
            Console.WriteLine("3. Transpor a Matriz");
            int option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    int[] rowSums = SumRows(matrix);
                    Console.WriteLine("Soma das Linhas:");
                    PrintArray(rowSums);
                    SaveToCsv("resultado.csv", rowSums, "Soma das Linhas");
                    break;
                case 2:
                    int[] colSums = SumColumns(matrix);
                    Console.WriteLine("Soma das Colunas:");
                    PrintArray(colSums);
                    SaveToCsv("resultado.csv", colSums, "Soma das Colunas");
                    break;
                case 3:
                    int[,] transposed = TransposicionMatriz(matrix);
                    Console.WriteLine("Matriz Transposta:");
                    PrintMatrix(transposed);
                    SaveMatrizToCsv("resultado.csv", transposed);
                    break;
                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }

            Console.WriteLine("Resultado salvo em 'resultado.csv'.");
        }

        // Gera uma matriz de números aleatórios
        static int[,] GenerateMatrix(int rows, int cols)
        {
            int[,] matrix = new int[rows, cols];
            Random random = new Random();
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = random.Next(1, 101); // Valores entre 1 e 100
                }
            }
            return matrix;
        }

        // Soma os valores de cada linha
        static int[] SumRows(int[,] matrix) // Soma os valores de cada linha
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            int[] rowSums = new int[rows];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    rowSums[i] += matrix[i, j];
                }
            }
            return rowSums;
        }

        // Soma os valores de cada coluna
        static int[] SumColumns(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            int[] colSums = new int[cols];
            for (int j = 0; j < cols; j++)
            {
                for (int i = 0; i < rows; i++)
                {
                    colSums[j] += matrix[i, j];
                }
            }
            return colSums;
        }

        // Função de salvar os resultados em um arquivo CSV
        static void SaveToCsv(string filepath, int[] array,
            string primeiro)
        {
            using (StreamWriter writer = new StreamWriter(filepath))
            {
                writer.WriteLine(primeiro); // Aqui para ler a primeira linha
                foreach (int item in array)
                {
                    writer.WriteLine(item);
                }
            }
        }

        // Salvar a matriz completa no CSV
        static void SaveMatrizToCsv(string filepath, int[,] matriz)
        {
            using (StreamWriter writer = new StreamWriter(filepath))
            {
                int linha = matriz.GetLength(0);
                int coluna = matriz.GetLength(1);

                for (int i = 0; i < linha; i++)
                {
                    for (int j = 0; j < coluna; j++)
                    {
                        writer.Write(matriz[i, j]); // É para atribuir o valor da matriz nas colunas
                        if (j < coluna - 1)
                        {
                            writer.Write(",");
                        }
                    }
                    writer.WriteLine();
                }
            }
        }


        // transposta da matriz
        static int[,] TransposicionMatriz(int[,] matriz)
        {
            int linha = matriz.GetLength(0);
            int coluna = matriz.GetLength(1);
            int[,] transposta = new int[coluna, linha];

            for (int i = 0; i < linha; i++)
            {
                for (int j = 0; j < coluna; j++)
                {
                    transposta[j, i] = matriz[i, j];
                }
            }
            return transposta;
        }

        // Exibe uma matriz no console
        static void PrintMatrix(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

        // Exibe um array no console
        static void PrintArray(int[] array)
        {
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
        }
    }
}