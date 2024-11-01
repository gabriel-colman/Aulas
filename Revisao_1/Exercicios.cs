namespace Revisao_1;

public class Exercicios
{
    /*
    Escreva um algoritmo que receba 10 números inteiro e positivos. Em  
    seguida o algoritmos deverá mostrar o menor e o maior deles. 
    5. Escreva um algoritmo que dado uma quantidade indeterminada de  
    números inteiros e positivos, informe o menor e o maior. Utilize o  
    número -1 como finalizador, ou seja, servirá como recurso de saída do  
    laço de repetição 
    */
    public static void Exercicio1()
    {
        int menor = 0;
        int maior = 0;

        System.Console.WriteLine("Voce deve digitar 10 numeros inteiros e positivos");

        for (int i = 0; i < 10; i++)
        {
            Console.Write("Digite um número: ");
            int numero = int.Parse(Console.ReadLine());

            if (numero < menor)
            {
                menor = numero;
            }

            if (numero > maior)
            {
                maior = numero;
            }
        }

        Console.WriteLine($"Menor: {menor}");
        Console.WriteLine($"Maior: {maior}");
    }

    /*
    Construa um programa que receba uma palavra do usuário. O programa deverá 
    verificar se esta palavra corresponde à senha de acesso (senha: “Digix”). Se a palavra 
    fornecida pelo usuário for igual a senha, o programa deverá informar “Acesso 
    autorizado”, caso contrário, deverá informar “Acesso negado”.
    */
    public static void Exercicio2()
    {
        Console.Write("Digite a senha: ");
        string senha = Console.ReadLine();

        if (senha == "Digix")
        {
            Console.WriteLine("Acesso autorizado");
        }
        else
        {
            Console.WriteLine("Acesso negado");
        }
    }

    /*
    Reescreva o programa que identifica o DDD dos estados, utilizando a estrutura Caso, 
de acordo com os seguintes critérios de DDDs e seus respectivos Estados brasileiros.  
• Paraná: 41, 42, 43, 44, 45 e 46  
• Rio Grande do Sul: 51, 53, 54 e 55  
• Brasília: 61  
• Goiás: 62 e 64  
• Mato Grosso: 65 e 66  
• Mato Grosso do Sul: 67
    */
    public static void Exercicio3()
    {
        Console.Write("Digite o DDD: ");
        int ddd = int.Parse(Console.ReadLine());

        switch (ddd)
        {
            case 41:
            case 42:
            case 43:
            case 44:
            case 45:
            case 46:
                Console.WriteLine("Paraná");
                break;
            case 51:
            case 53:
            case 54:
            case 55:
                Console.WriteLine("Rio Grande do Sul");
                break;
            case 61:
                Console.WriteLine("Brasília");
                break;
            case 62:
            case 64:
                Console.WriteLine("Goiás");
                break;
            case 65:
            case 66:
                Console.WriteLine("Mato Grosso");
                break;
            case 67:
                Console.WriteLine("Mato Grosso do Sul");
                break;
            default:
                Console.WriteLine("DDD não encontrado");
                break;
        }
    }

    /*
    Escreva um algoritmo que dado uma quantidade indeterminada de números inteiros e 
positivos, informe o menor e o maior. Utilize o número -1 como finalizador, ou seja, 
servirá como recurso de saída do laço de repetição.
    */

    public static void Exercicio4()
    {
        int menor = int.MaxValue;
        int maior = int.MinValue;

        Console.WriteLine("Digite números inteiros e positivos. Digite -1 para sair.");

        while (true)
        {
            Console.Write("Digite um número: ");
            int numero = int.Parse(Console.ReadLine());

            if (numero == -1)
            {
                break;
            }

            if (numero < menor)
            {
                menor = numero;
            }

            if (numero > maior)
            {
                maior = numero;
            }
        }

        Console.WriteLine($"Menor: {menor}");
        Console.WriteLine($"Maior: {maior}");
    }
}
