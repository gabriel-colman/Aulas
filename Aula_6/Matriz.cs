namespace Aula_6;

public class Matriz
{
    static void Main(string[] args){
        int[,] matriz = new int[3, 3] {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };
        int[,] transposta = new int[3, 3];

        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                transposta[j, i] = matriz[i, j];
            }
            Console.WriteLine();
        }

        // Ver resultado
        for (int i = 0; i < transposta.GetLength(0); i++)
        {
            for ( int j = 0; j < transposta.GetLength(1); j++)
            {
                Console.Write(transposta[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
