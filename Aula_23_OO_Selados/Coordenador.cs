using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_23_OO_Selados
{
    public class Coordenador : Funcionario
    {
        public override void Salario(int salario)
        {
            Console.WriteLine("Salário base:" + salario * 1.2);
        }

        public sealed override void Trabalhar()
        {
            Console.WriteLine("Coordenando...");
        }
        
    }
}