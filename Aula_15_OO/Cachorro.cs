using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_15_OO
{
    public class Cachorro
    {
        public string Nome;
        public string Raca;
        public int Idade;

        public void escrevaSaida()
        {
            Console.WriteLine("Nome: " + Nome);
            Console.WriteLine("Raça: " + Raca);
            Console.WriteLine("Idade: " + Idade);
            Console.WriteLine("Idade em humanos" + getIdadeHumano());
        }

        public int getIdadeHumano()
        {
            int idadeHumano = 0;
            if (Idade <= 2){
                idadeHumano = Idade * 11;
            } else {
                idadeHumano = 22 + (Idade - 2) * 5;
            }
            return idadeHumano;
        }
    }
}