using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_19_OO_Relacoes.Agregacao
{
    public class Professor
    {
        public string Nome;

        public Professor(string nome)
        {
            Nome = nome;
        }

        public void ensinar()
        {
            Console.WriteLine("Professor " + Nome + " ensinando...");
        }
    }
}