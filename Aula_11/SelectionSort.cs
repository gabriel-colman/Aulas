using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_11
{
    public class SelectionSort
    {
        // Funcao de Ordenção usando Selection Sort
        static void Ordenar(int[] vetor)
        {
            int menor, aux;
            for (int i = 0; i < vetor.Length - 1; i++)
            {
                menor = i;
                for (int j = i + 1; j < vetor.Length; j++)
                {
                    if (vetor[j] < vetor[menor])
                    {
                        menor = j;
                    }
                }
                aux = vetor[i];
                vetor[i] = vetor[menor];
                vetor[menor] = aux;
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