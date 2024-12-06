using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_16_OO_Heranca
{
    public class Executar
    {
        static void Main(string[] args)
        {
            // Instanciando um objeto do tipo Gerente
            Gerente gerente = new Gerente("João", "123.456.789-00", 5000, "TI");
            System.Console.WriteLine("Mostrar o salario do gerente: " + gerente.Salario);
            System.Console.WriteLine("Mostrar a bonificação do gerente: " + gerente.GetBonificacao());
            gerente.GerenciarEquipe();
            gerente.ImprimirDados();

            
        }
    }
}