namespace Aula_5;

public class Exemplo2
{
    static void Main(string[] args){
        int [] vetor = new int[10];
        for (int i = 0; i < 10; i++)
        {
            Console.Write("Digite um número: ");
            vetor[i] = int.Parse(Console.ReadLine());
        }
        int maior = vetor[0];
        int menor = vetor[0];
        for (int i = 1; i < 10; i++)
        {
            if (vetor[i] > maior)
            {
                maior = vetor[i];
            }
            if (vetor[i] < menor)
            {
                menor = vetor[i];
            }
        }

        Console.WriteLine($"Maior: {maior}");
        Console.WriteLine($"Menor: {menor}");
    }
}
