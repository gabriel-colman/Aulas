using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_19_OO_Interface
{
    public interface IForma
    {
        double CalcularArea();
        double CalcularPerimetro();

        // Esse tipo de declaração de função
        void ExibirInformacoes()
        {
            Console.WriteLine("Área: " + CalcularArea());
            Console.WriteLine("Perímetro: " + CalcularPerimetro());
        }
    }
}