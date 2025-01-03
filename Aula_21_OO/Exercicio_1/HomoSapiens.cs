using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_21_OO.Exercicio_1
{
    public class HomoSapiens : Animalia
    {
        // Contrutor
        public HomoSapiens()
        : base("Animalia", "Chordata", "Mammalia", "Primates", "Homo", "Homo Sapiens", "")
        {

        }
        public override string ObterDescricao()
        {
            return base.ObterDescricao();   
        }
    }
}