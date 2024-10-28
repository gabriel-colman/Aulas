namespace Aula_3;

public class IF_Else
{
    public static void Teste()
    {
        int idade = 15;
        if (idade >= 18 && idade <= 50)
        {
            System.Console.WriteLine("Adulto");
        }
        else if (idade > 50 && idade <= 100)
        {
            System.Console.WriteLine("Idoso");
        }
        else if (idade > 100)
        {
            System.Console.WriteLine("Já morreu");
        }
        else
        {
            System.Console.WriteLine("Criança");
        }
    }
}   
