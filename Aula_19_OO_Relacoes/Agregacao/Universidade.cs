using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_19_OO_Relacoes.Agregacao
{
    public class Universidade
    {
        public Professor professor;

        // Na agregação, a classe principal pode existir sem a parte essencial.
        // Então é passado a parte essencial como parâmetro no construtor.
        // Aqui só é agregação pois esta sendo passado o professor como parâmetro.
        // Se fosse instanciado o professor dentro do construtor, seria composição.
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