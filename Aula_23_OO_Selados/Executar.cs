using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_23_OO_Selados
{
    public class Executar
    {
        static void Main(string[] args)
        {
            Funcionario f = new Funcionario();
            f.Salario(1000);
            f.Trabalhar();

            Coordenador c = new Coordenador();
            c.Salario(1000);
            c.Trabalhar();

            Gerente g = new Gerente();
            g.Salario(1000);
            g.Trabalhar();

            Instrutor i = new Instrutor();
            i.Salario(1000);
            i.Trabalhar();
        }
    }
}