using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_25_OO_Struct
{
        public struct Point
        {
            public int X { get; set;}
            public int Y { get; set;}

            // Construtor no struct é obrigatório inicializar todos os campos
            // E ter parametros nele
            public Point(int x, int y)
            {
                X = x;
                Y = y;
            }

            public double Distancia(Point p)
            {
                //X = 10; // Isso não é permitido em um método de struct pois ele é um tipo de valor
                // Não se tem modificador de estado em um struct
                return Math.Sqrt(Math.Pow(X - p.X, 2) // Math.Pow eleva um número a uma potência
                + Math.Pow(Y - p.Y, 2));
                // Aqui dizemos qua a distância é a raiz quadrada da diferença dos quadrados das coordenadas
            }
        }

        public class Player {
            public string Name { get; set; }
            public Point Position { get; set; }

            public Player(string name, Point position)
            {
                Name = name;
                Position = position;
            }

            public void Move(Point newPosition)
            {
                Position = newPosition;
                
            }
        }

        public class Executar
        {
            public static void ExecutarExemplo()
            {
                Point p1 = new Point(10, 20);
                Point p2 = new Point(20, 30);

                Console.WriteLine($"Distância entre p1 e p2: {p1.Distancia(p2)}");

                Player player = new Player("Jogador 1", p1);
                Console.WriteLine($"Posição do jogador: {player.Position.X}, {player.Position.Y}");

                player.Move(p2);
                Console.WriteLine($"Posição do jogador: {player.Position.X}, {player.Position.Y}");
            }
        }
    
}