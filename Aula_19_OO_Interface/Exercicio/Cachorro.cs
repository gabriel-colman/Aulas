using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_19_OO_Interface
{
    public class Cachorro : Animal, AnimalDeEstimacao
    {
        private string _nome = "";

        //Contrutor 
        public Cachorro(int pernas) : base(pernas)
        {
            
        }

        public Cachorro(string nome) : base(5)
        {
            _nome = nome;
        }

        // Metodo getNome
        public string getNome()
        {
            return _nome;
        }

        // Metodo setNome
        public void setNome(string nome)
        {
            _nome = nome;
        }

        // Metodo brincar
        public void brincar()
        {
            Console.WriteLine("O cachorro está brincando");
        }

        // Metodo Come
        public override void Come()
        {
            Console.WriteLine("O cachorro está comendo");
        }
    }
   
}