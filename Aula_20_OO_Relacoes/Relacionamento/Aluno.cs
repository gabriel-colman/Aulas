using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_20_OO_Relacoes
{
    // Classe Aluno, vai ser fundamental para o Escola
    // Então vai ter relação de Compoção
    public class Aluno
    {
        // Propriedades
        public string Nome { get; set; }

        // Contrutor
        public Aluno(string nome)
        {
            Nome = nome;
        }

        // Função informar
        public void MostrarInfo()
        {
            Console.WriteLine($"Nome: {Nome}");
        }
    }
}