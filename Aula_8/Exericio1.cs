namespace Aula_8;

public class Exericio1
{
    public delegate double CalcularMedia(int[] valores);    

    static double Media(int[] valores)
    {
        double media = 0;
        foreach (var valor in valores)
        {
            media += valor;
        }
        return media / valores.Length;
    }

    static void Main(string[] args)
    {
        CalcularMedia calcularMedia = Media;
        int[] valores = { 1, 2, 3, 4, 5 };
        Console.WriteLine($"Media: {calcularMedia(valores)}");

    }
}
