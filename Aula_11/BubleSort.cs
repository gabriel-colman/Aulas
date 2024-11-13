using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_11
{
    public class BubleSort
    {
        // Função para ordenar em ordem crescente, com Bubble Sort
        static void Ordenar(int[] vetor)
        {
            int aux;
            for (int i = 0; i < vetor.Length; i++)
            {
                for (int j = 0; j < vetor.Length - 1; j++)
                {
                    if (vetor[j] > vetor[j + 1])
                    {
                        aux = vetor[j];
                        vetor[j] = vetor[j + 1];
                        vetor[j + 1] = aux;
                    }
                }
            }
        }
        static void Imprimir(int[] vetor)
        {
            for (int i = 0; i < vetor.Length; i++)
            {
                System.Console.WriteLine(vetor[i] + " ");
            }
            System.Console.WriteLine();
        }
        static void Main(string[] args)
        {
            int[] vetor = { 3, 1, 5, 7, 3, 4 };
            System.Console.WriteLine("Vetor desordenado");
            Imprimir(vetor);
            Ordenar(vetor);
            System.Console.WriteLine("Vetor desordenado");
            Imprimir(vetor);

        }
    }
}