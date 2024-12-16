using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_19_OO_Interface
{
    public class Formiga : Animal
    {
        // Construtor
        public Formiga() : base(6)
        {
        }

        // Metodo Come
        public override void Come()
        {
            Console.WriteLine("A formiga está comendo folhas");
        }
    }
}