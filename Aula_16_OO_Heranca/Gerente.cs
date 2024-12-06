using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_16_OO_Heranca
{
    public class Gerente : Funcionario // No C# o extends é representado por ":"
    {
        // Atributos globais de Gerente
        public string Setor;

        // Contrutor com Parametros
        public Gerente(string nome, string cpf, double salario, string setor) : base(nome, cpf, salario) // O base é utilizado para chamar o construtor da classe pai
        {
            // base é utilizado para chamar o construtor da classe pai
            this.Setor = setor;
        }

        // Metodo para calcular salario
        public override double GetBonificacao() // Override é utilizado para sobrescrever o metodo da classe pai
        {
            return Salario * 0.15;
        }


        // Metodo impirmir dados
        public override void ImprimirDados()
        {
            Console.WriteLine("Nome: " + Nome);
            Console.WriteLine("CPF: " + CPF);
            Console.WriteLine("Salario: " + Salario);
            Console.WriteLine("Setor: " + Setor);
            Console.WriteLine("Bonificação: " + GetBonificacao());
        }


        // Metodo para gerenciar equipe
        public void GerenciarEquipe()
        {
            Console.WriteLine("Gerenciando equipe");
        }
    }
}