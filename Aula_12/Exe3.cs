using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_12
{
    public class Exe3
    {
        // Usando a Solução de Ordenacao com ASCII
        static void SelectionSort(string[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                int menorIndice = i;
                for (int j = 0; j < array.Length; j++)
                {
                    if (EhMenor(array[j], array[menorIndice]))
                    {
                        menorIndice = j;
                    }
                }
                string temp = array[i];
                array[i] = array[menorIndice];
                array[menorIndice] = temp;
            }
        }
        static bool EhMenor(string a, string b)
        {
            // Math.Min(a.Length, b.Length) retorna o menor tamanho entre a e b
            int tamanho = Math.Min(a.Length, b.Length);
            for (int i = 0; i < tamanho; i++)
            {
                if (a[i] < b[i])
                {
                    return true;
                }
                else if (a[i] > b[i])
                {
                    return false;
                }

            }
            return a.Length < b.Length;
        }
        static void Main()
        {
            string[] nomes = { "João", "Maria", "José", "Ana", "Carlos" };
            SelectionSort(nomes);
            foreach (string nome in nomes)
            {
                Console.WriteLine(nome);
            }
        }
    }

}

