using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_20_OO_Relacoes
{

    public class Escola
    {
        private Aluno estudante;
        private Professor profesor;

        // Contrutor da escola
        // Que aqui vai mostrar a relação de Composição
        public Escola (string nomeEstudante)
        {
            // Aqui que mudar, pois a escola vai ter um aluno como
            // parte dela, então vai ser uma relação de Composição
            estudante = new Aluno(nomeEstudante);
        }

        // Metodo para Agregação (que recebe de forma externa)
        // o professor
        public void ContratarProfessor(Professor professor)
        {
            this.profesor = professor;
        }

        // Mostrar informações
        public void MostrarInfo()
        {
            Console.WriteLine($"Nome do Aluno: {estudante.Nome}");
            Console.WriteLine($"Nome do Professor: {profesor.Nome}");
            profesor.Ensinar();
        }
        
    }
}