using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_19_OO_Relacoes.Agregacao
{
    public class Universidade
    {
        public Professor professor;

        public Universidade(Professor professor)
        {
            this.professor = professor;
        }

        public void reailizarAula()
        {
            Console.WriteLine("Realizando aula...");
            professor.ensinar();
        }
    }
}