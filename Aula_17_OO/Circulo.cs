using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_17_OO
{
    public class Circulo : Forma
    {
        public double Raio;

        // Construtor
        public Circulo(string nome, double raio) : base(nome)
        {
            Raio = raio;
        }

        // Metodo para calcular area
        public override double CalcularArea()
        {
            return Math.PI * Math.Pow(Raio, 2); // PI * raio^2
        }

        // Metodo para calcular perimetro
        public override double CalcularPerimetro()
        {
            return 2 * Math.PI * Raio;
        }

        // Metodo para imprimir dados
        // public override void ImprimirDados()
        // {
        //     Console.WriteLine("Nome: " + Nome);
        //     Console.WriteLine("Raio: " + Raio);
        //     Console.WriteLine("Area: " + CalcularArea());
        //     Console.WriteLine("Perimetro: " + CalcularPerimetro());
        // }

        // Outra forma de ImprimirDados
        public override void ImprimirDados()
        {
            base.ImprimirDados();
            Console.WriteLine("Raio: " + Raio);
        }
    }
}