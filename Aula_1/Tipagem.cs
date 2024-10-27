using System;
using System.Security.Cryptography;
namespace Exemplo
{
    internal class Tipagem
    {
        static void Main(string[] args)
        {
            // Tipagem estaica
            // Inteiro
            int a = 10;
            Console.WriteLine(a);
            Console.WriteLine(a.GetType());

            // Tipagem Dinamica
            // dinamic b = 10;
            // Console.WriteLine(b);
            // Console.WriteLine(b.GetType());

            // Tipagem Implicita
            var c = 10;
            Console.WriteLine(c);
            Console.WriteLine(c.GetType());

            // Tipos de variaveis
            // Arrays
            int[] d = new int[5];
            Console.WriteLine(d);
            Console.WriteLine(d.GetType());

            // Listas
            List<int> e = new List<int>();
            Console.WriteLine(e);
            Console.WriteLine(e.GetType());

            // Dicionarios
            Dictionary<int, string> f = new Dictionary<int, string>();
            Console.WriteLine(f);
            Console.WriteLine(f.GetType());

            // Tuplas
            Tuple<int, string> g = new Tuple<int, string>(1, "teste");
            Console.WriteLine(g);
            Console.WriteLine(g.GetType());

            // Objetos
            object h = new object();
            Console.WriteLine(h);
            Console.WriteLine(h.GetType());
        }
    }
}