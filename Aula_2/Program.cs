using System;

namespace Aula_2
{
    class Program
    {
        static void Teste()
        {
            // Operadores Aritimeticos
            int a = 20;
            int b = 3;  
            // Console.WriteLine(a + b); // Adição
            // Console.WriteLine(a - b); // Subtração 
            // Console.WriteLine(a * b); // Multiplicação
            // Console.WriteLine(a / b); // Divisão
            // Console.WriteLine(a % b); // Resto da divisão
            // Console.WriteLine(a ^ 2); // Potenciação
            



            // Atrubuição Arithmetica
            int c = 10;
            int d  = 5;
            c += d; // c = c + d  
            // System.Console.WriteLine(c);  
            // c -= d; // c = c - d
            // System.Console.WriteLine(c);
            // c *= d; // c = c * d
            // System.Console.WriteLine(c);
            // c /= d; // c = c / d
            // System.Console.WriteLine(c);

            // Operadores de Comparação
            int x = 10;
            int y = 5;
            // System.Console.WriteLine(x == y); // Igualdade
            // System.Console.WriteLine(x != y); // Diferença
            // System.Console.WriteLine(x > y); // Maior que
            // System.Console.WriteLine(x >= y); // Maior ou igual
            // System.Console.WriteLine(x < y); // Menor que
            // System.Console.WriteLine(x <= y); // Menor ou igual


            // Operadores Lógicos
            bool w = true;
            bool z = false;
            // System.Console.WriteLine(w && z); // Falso
            // System.Console.WriteLine(w || z); // Verdadeiro
            // System.Console.WriteLine(!w); // Falso
            // System.Console.WriteLine((!z && w) && (z || w)); // Verdadeiro

            // Operadores Incremento e Decremento
            int i = 10;
            // Incremento
            System.Console.WriteLine(i++); // i = i + 1
            System.Console.WriteLine(i);
            System.Console.WriteLine(++i); // i = i + 1
            // Decremento
            System.Console.WriteLine(i--); // i = i - 1
            System.Console.WriteLine(i);
            System.Console.WriteLine(--i); // i = i - 1

            // Operador Bitwise
            int j = 10; // 1010
            int k = 5; // 0101
            System.Console.WriteLine(i & k); // 0000
            System.Console.WriteLine(i | k); // 1111
            System.Console.WriteLine(i ^ k); // 1111
            System.Console.WriteLine(~i); // 1111 1111 1111 1111 1111 1111 1111 0101
            System.Console.WriteLine(i << 1); // 10100
            System.Console.WriteLine(i >> 1); // 0101
        }
    }
}