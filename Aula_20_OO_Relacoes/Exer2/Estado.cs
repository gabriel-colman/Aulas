using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_20_OO_Relacoes.Exer2
{
    public class Estado
    {
        public string Nome { get; set; }
        public string Sigla { get; set; }

        public Estado(string nome, string sigla)
        {
            Nome = nome;
            Sigla = sigla;
        }
    }
}