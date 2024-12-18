using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_20_OO_Relacoes
{
    // Classe Professor, vai ser agregada com a 
    // o da Escola, então vai ter relação de Agregação
    public class Professor
    {
        // Propriedades
        public string Nome { get; set; }

        // Contrutor
        public Professor(string nome)
        {
            Nome = nome;
        }
        
        // Função Ensinar
        public void Ensinar()
        {
            Console.WriteLine($"Professor: {Nome} está ensinando");
        }
        
    }
}