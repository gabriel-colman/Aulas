using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_21_OO.Exercicio_1
{
    public class CanisFamiliaris : Animalia
    {
        // Construtor
        public CanisFamiliaris()
        :base("Chordata", "Mamalia", "Carnivora","Carnidae","Canidae","Canis","Cani Familiares")
        {

        }
        public override string ObterDescricao()
        {
            return base.ObterDescricao();
        }
    }
}