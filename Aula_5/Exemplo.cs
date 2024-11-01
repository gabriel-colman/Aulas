namespace Aula_5;

public class Exemplo
{
    static void Main()
    {
        // 1. Ler um vetor com 10 inteiros e mostrar os valores 
        // da ordem direta e inversa em que foram lidos.
        int[] vetor = new int[10];
        for (int i = 0; i < 10; i++)
        {
            // Console.Write("Digite um número: ");
            // vetor[i] = int.Parse(Console.ReadLine());
            vetor[i] = Random.Shared.Next(1, 100);
        }
        // Ondrm direta
        Console.WriteLine("Ordem direta:");
        for (int i = 0; i < 10; i++)
        {
            Console.Write($"{vetor[i]} ");
        }

        // Ordem inversa
        Console.WriteLine("Ordem inversa:");
        for (int i = 9; i >= 0; i--)
        {
            Console.Write($"{vetor[i]} ");
        }

        
    }
}
