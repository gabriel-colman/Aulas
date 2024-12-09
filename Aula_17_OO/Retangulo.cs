using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_17_OO
{
    public class Retangulo : Forma
    {
        public double Largura;
        public double Altura;

        // Construtor
        public Retangulo(string nome, double largura, double altura) : base(nome)
        {
            this.Largura = largura; // this é opcional porque esta apondo a um atributo da classe global
            this.Altura = altura;
        }

        // Metodo para calcular area
        public override double CalcularArea()
        {
            return Largura * Altura;
        }

        // Metodo para calcular perimetro
        public override double CalcularPerimetro()
        {
            return 2 * (Largura + Altura);
        }

        // Metodo para imprimir dados
        public override void ImprimirDados()
        {
            Console.WriteLine("Nome: " + Nome);
            Console.WriteLine("Largura: " + Largura);
            Console.WriteLine("Altura: " + Altura);
            Console.WriteLine("Area: " + CalcularArea());
            Console.WriteLine("Perimetro: " + CalcularPerimetro());
        }
    }
}