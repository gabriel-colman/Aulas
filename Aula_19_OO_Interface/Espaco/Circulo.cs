using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_19_OO_Interface.Espaco
{
    public class Circulo : IForma
    {
        // Propriedade Raio
        public double Raio { get; set; }

        // Construtor
        public Circulo(double raio)
        {
            Raio = raio;
        }

        // Implementação do método CalcularArea
        public double CalcularArea()
        {
            return Math.PI * Math.Pow(Raio, 2);
        }

        // Implementação do método CalcularPerimetro
        public double CalcularPerimetro()
        {
            return 2 * Math.PI * Raio;
        }

        // Implementação do método ExibirInformacoes
        public void ExibirInformacoes()
        {
            Console.WriteLine("Círculo");
            Console.WriteLine("Raio: " + Raio);
        }
        
    }
}