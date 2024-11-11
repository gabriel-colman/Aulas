using System;

class Program
{
    // static void CalcularMediaRegios(double[,,] temperaturas){
    //     for (int regiao = 0; regiao < temperaturas.GetLength(0); regiao++)
    //     {
    //         double soma = 0;
    //         int totalDias = temperaturas.GetLength(1) * temperaturas.GetLength(2);
    //     }
    // }
    static void Main()
    {
        // Matriz de 3 dimensões
        double[,,] temperaturas = new double[5, 3, 2]{
            {
                {20, 30},
                {25, 35},
                {22, 32}
            },
            {
                {30, 40},
                {35, 45},
                {32, 42}
            },
            {
                {40, 50},
                {45, 55},
                {42, 52}
            },
            {
                {50, 60},
                {55, 65},
                {52, 62}
            },
            {
                {60, 70},
                {65, 75},
                {62, 72}
            }
        };

        // Imprimir a linha da matriz tridimensional
        for (int i = 0; i < temperaturas.GetLength(0); i++)
        {
            for (int j = 0; j < temperaturas.GetLength(1); j++)
            {
                Console.WriteLine($"Região {i}, Dia {j}");
            }
        }
    }
}
