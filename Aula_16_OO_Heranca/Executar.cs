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
            Funcionario funcionario = new Funcionario("José", "123.456.789-00", 2000);

            // Instanciando um objeto do tipo Gerente
            Gerente gerente = new Gerente("João", "123.456.789-00", 5000, "TI");
            System.Console.WriteLine("Mostrar o salario do gerente: " + gerente.Salario);
            System.Console.WriteLine("Mostrar a bonificação do gerente: " + gerente.GetBonificacao());
            gerente.GerenciarEquipe();
            gerente.ImprimirDados();

            // Secretaria secretaria = new Secretaria("Maria", "987.654.321-00", 2000, "123");
            // secretaria.GetBonificacao();
            
        }
    }
}