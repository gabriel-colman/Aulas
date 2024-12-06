using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_16_OO_Heranca
{
    public class Telefonista : Funcionario
    {
        public string EstacaoDeTrabalho;

        public Telefonista(string nome, string cpf, double salario, string estacaoDeTrabalho) : base(nome, cpf, salario)
        {
            this.EstacaoDeTrabalho = estacaoDeTrabalho;
        }

        public override double GetBonificacao()
        {
            return Salario * 0.05;
        }

        public override void ImprimirDados()
        {
            Console.WriteLine("Nome: " + Nome);
            Console.WriteLine("CPF: " + CPF);
            Console.WriteLine("Salario: " + Salario);
            Console.WriteLine("Estação de Trabalho: " + EstacaoDeTrabalho);
            Console.WriteLine("Bonificação: " + GetBonificacao());
        }

        public void AtenderTelefone()
        {
            Console.WriteLine("Atendendo telefone");
        }
    }
}