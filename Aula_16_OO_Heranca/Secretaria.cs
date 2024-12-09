using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_16_OO_Heranca
{
    public class Secretaria : Funcionario
    {
        public string Ramal;

        // Contrutor com Parametros
        public Secretaria(string nome, string cpf, double salario, string ramal) : base(nome, cpf, salario)
        {
            this.Ramal = ramal;
        }

        // Metodo para calcular salario
        // public override double GetBonificacao()
        // {
        //     return Salario * 0.05;
        // }

        // Metodo impirmir dados
        public override void ImprimirDados()
        {
            Console.WriteLine("Nome: " + Nome);
            Console.WriteLine("CPF: " + CPF);
            Console.WriteLine("Salario: " + Salario);
            Console.WriteLine("Ramal: " + Ramal);
            Console.WriteLine("Bonificação: " + GetBonificacao());
        }


        // Metodo para atender telefone
        public void AtenderTelefone()
        {
            Console.WriteLine("Atendendo telefone");
        }
    }
}