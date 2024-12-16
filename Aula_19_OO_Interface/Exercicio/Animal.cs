using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_19_OO_Interface
{
    public class Animal
    {
        protected int Pernas = 0;

        //Contrutor 
        public Animal(int pernas)
        {
            Pernas = pernas;
        }
        
        // Metodo Caminha
        public void Caminha()
        {
            Console.WriteLine("O animal está caminhando" + Pernas);
        }

        // Metodo come
        public virtual void Come()
        {
            Console.WriteLine("O animal está comendo");
        }

    }
}