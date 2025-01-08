using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_23_OO_Selados
{
    public class Funcionario
    {
        public string Nome { get; set; }

        public virtual void Salario(int salario)
        {
            Console.WriteLine("Salário base:" + salario);
        }

        public virtual void Trabalhar()
        {
            Console.WriteLine("Trabalhando...");
        }
    }
}