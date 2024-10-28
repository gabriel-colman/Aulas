namespace Aula_3
{
    public class Entrada_dados
    {
        static void Teste()
        {
            int idade = 15;
            switch (idade)
            {
                case int n when n >= 18 && n <= 50:
                    Console.WriteLine("Adulto");
                    break;
                case int n when n > 50 && n <= 100:
                    Console.WriteLine("Idoso");
                    break;
                case int n when n > 100:
                    Console.WriteLine("Já morreu");
                    break;
                default:
                    Console.WriteLine("Criança");
                    break;
            } // Fechamento do switch
        } // Fechamento do método Main
    }
}
