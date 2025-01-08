using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_23_OO_Selados
{
    public sealed class Gerente : Funcionario 
    // sealead é quando não pode ser herdado
    {
        public override void Salario(int salario)
        {
            Console.WriteLine("Salário base:" + salario * 1.5);
        }

        public override void Trabalhar()
        {
            Console.WriteLine("Gerenciando...");
        }
    }
}