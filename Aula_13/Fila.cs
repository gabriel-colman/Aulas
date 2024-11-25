using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_13
{
    public class Fila
    {
        static int[] fila = new int[10];

        static int inicio = 0; // inicio da fila

        static int fim = 0; // fim da fila

        static int cout = 0; // quantidade de elementos na fila

        // Adiciona um elemento na fila, Enqueue
        public static void Adicionar(int valor)
        {
            if (cout < fila.Length)
            {
                fila[fim] = valor;
                fim = (fim + 1) % fila.Length; // Move o fim para o próximo elemento
                cout++; // Incrementa a quantidade de elementos na fila
            }
            else
            {
                Console.WriteLine("Fila cheia!");
            }
        }

        // Remove um elemento da fila, Dequeue
        public static void Remover()
        {
            if (cout > 0)
            {
                fila[inicio] = 0;
                inicio = (inicio + 1) % fila.Length; // Move o inicio para o próximo elemento
                cout--; // Decrementa a quantidade de elementos na fila
            }
            else
            {
                Console.WriteLine("Fila vazia!");
            }
        }

        // Mostra os elementos da fila de forma do Inicio ao Fim
        public static void Mostrar()
        {
            for (int i = 0; i < cout; i++)
            {
                Console.WriteLine(fila[(inicio + i) % fila.Length]);
            }
        }

        //  Primeiro elemento da fila
        public static void Primeiro()
        {
            if (cout > 0)
            {
                Console.WriteLine(fila[inicio]);
            }
            else
            {
                Console.WriteLine("Fila vazia!");
            }
        }

        // Metodo main
        public static void Main(string[] args)
        {

            Adicionar(10);
            Adicionar(20);
            Adicionar(30);
            Adicionar(40);
            Adicionar(50);
            Adicionar(60);

            Mostrar();

            Console.WriteLine("Primeiro elemento da fila: ");
            Primeiro();

            // Removendo elementos
            Remover();

            Mostrar();

            // Remover tudo 
            while (cout > 0)
            {
                Remover();
            }
        }
    }
}