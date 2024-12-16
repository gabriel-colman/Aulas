using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_18_OO_Encapsulamento
{
    public class Academia
    {
        public string Nome { get; set; }

        private double Mensalidade { get; set; } // Classe exterior não vai ter acesso

        // Contrutor padrão
        public Academia()
        {
        }

        // Construtor com 2 argumentos
        public Academia(string nome, double mensalidade)
        {
            Nome = nome;
            Mensalidade = mensalidade;
        }



    }
}