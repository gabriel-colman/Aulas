using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aula_17_OO.Execicio;

namespace Aula_17_OO
{
    public class Executar
    {
        static void Main(string [] args){
            // Só poderá instanciar as classes filhas
            // Circulo circulo = new Circulo("Circulo", 5);
            // circulo.CalcularArea();
            // circulo.CalcularPerimetro();
            // circulo.ImprimirDados();

            // Retangulo retangulo = new Retangulo("Retangulo", 5, 10);
            // retangulo.CalcularArea();
            // retangulo.CalcularPerimetro();
            // retangulo.ImprimirDados();

            // Exercicio 1
            Assalariado assalariado = new Assalariado("João", "Silva", "123.456.789-00", 1000);
            assalariado.Vencimento();
            assalariado.MostrarDados();

            

        }
    }
}