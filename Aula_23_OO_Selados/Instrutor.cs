using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_23_OO_Selados
{
    public class Instrutor : Coordenador
    {
        public override void Salario(int salario)
        {
            Console.WriteLine("Salário base:" + salario * 1.3);
        }

        // public override void Trabalhar()
        // {
        //     Console.WriteLine("Instruindo...");
        // }   
    }
}