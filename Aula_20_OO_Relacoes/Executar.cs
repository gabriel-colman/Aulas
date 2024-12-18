using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_20_OO_Relacoes
{
    public class Executar
    {
        static void Main(string[] args)
        {
            // Criar um objeto do tipo escola
            Escola escola = new Escola("João");

            // Criar um objeto do tipo professor
            Professor professor = new Professor("Maria");

            // Contratar o professor
            escola.ContratarProfessor(professor);

            // Mostrar informações
            escola.MostrarInfo();
        }
    }
}