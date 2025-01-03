using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_21_OO.Exercicio_1
{
    public abstract class Taxonomia
    {
        protected string Reino;
        protected string Filo;
        protected string Classe;
        protected string Ordem;
        protected string Familia;
        protected string Genero;
        protected string Especie;

        // Contrutor
        public Taxonomia(string reino, string filo, string classe, string ordem, string familia, string genero, string especie)
        {
            Reino = reino;
            Filo = filo;
            Classe = classe;
            Ordem = ordem;
            Familia = familia;
            Genero = genero;
            Especie = especie;
        }

        public abstract string ObterDescricao();
    }
}