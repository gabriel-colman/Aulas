using System;

class Funcao_Recursiva
{
    // Os pares de um vetor com recursao
    static int Pares (int[] vetor, int n)
    {
        if (n == 0)
            return 0;
        else if (vetor[n - 1] % 2 == 0)
            return vetor[n - 1] + Pares(vetor, n - 1);
        else
            return Pares(vetor, n - 1);
    }
    static int Fatorial(int n)
    {
        if (n == 0)
            return 1;
        else
            return n * Fatorial(n - 1);
    }

    // fibonacci
    static int Fibonacci(int n)
    {
        if (n == 0 || n == 1)
            return 1;
        else
            return Fibonacci(n - 1) + Fibonacci(n - 2);
    }
    //  Formato de interação
    static int Fatorial2(int n)
    {
        int fatorial = 1;
        for (int i = 1; i <= n; i++)
            fatorial *= i;
        return fatorial;
    }

    static int Fibonacci2(int n)
    {
        int a = 0, b = 1, c = 1;
        for (int i = 2; i <= n; i++)
        {
            c = a + b;
            a = b;
            b = c;
        }
        return c;
    }

    // static void Main(string[] args)
    static void Teste()
    {
        Console.WriteLine("Digite um número: ");
        int numero = int.Parse(Console.ReadLine());
        Console.WriteLine("O fatorial de " + numero + " é " + Fatorial(numero));
        Console.WriteLine("O fibonacci de " + numero + " é " + Fibonacci(numero));

        System.Console.WriteLine("Agora respostas com formato interativo");
        Console.WriteLine("O fatorial de " + numero + " é " + Fatorial2(numero));

        // Chamar a função soma dos pares
        int[] vetor = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
        Console.WriteLine("A soma dos pares é: " + Pares(vetor, vetor.Length));
    }

    
}