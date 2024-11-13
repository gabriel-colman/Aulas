using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_11
{
    public class InsertionSort
    {
        // Funcação ordenar de forma crescente usando Insertion Sort
        static void Ordenar(int[] vetor)
        {
            int aux, j;
            for (int i = 1; i < vetor.Length; i++)
            {
                aux = vetor[i];
                j = i - 1;
                while (j >= 0 && vetor[j] > aux) {
                    vetor[j+1] = vetor [j];
                    j--;
                }
                vetor[j+1] = aux;
            }
        }
        static void Imprimir (int [] vetor){
            for (int i = 0; i < vetor.Length; i++)
            {
                System.Console.WriteLine(vetor[i] + " ");
            }
            System.Console.WriteLine();
        }
    }
}