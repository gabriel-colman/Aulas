using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_17_OO
{
    public abstract class Forma
    {
        public string Nome;

        // Construtor
        public Forma(string nome)
        {
            Nome = nome;
        }

        // Metodo para calcular area
        // Metodos abstratos não possuem corpo e devem ser implementados nas classes filhas
        public abstract double CalcularArea();

        // Metodo para calcular perimetro
        public abstract double CalcularPerimetro();

        // Metodo para imprimir dados
        // public virtual void ImprimirDados()
        // {
        //     Console.WriteLine("Nome: " + Nome);
        //     Console.WriteLine("Area: " + CalcularArea());
        //     Console.WriteLine("Perimetro: " + CalcularPerimetro());
        // }

        public abstract void ImprimirDados();
    }
}