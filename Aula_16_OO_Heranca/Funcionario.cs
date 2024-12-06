using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_16_OO_Heranca
{
    public class Funcionario
    {
        // Atributos globais de Funcionario
        public string Nome;
        public string CPF;
        public double Salario;

        // Contrutor com Parametros
        public Funcionario(string nome, string cpf, double salario)
        {
            this.Nome = nome;  
            this.CPF = cpf;
            this.Salario = salario;
        }

        // Metodo para calcular salario
        public virtual double GetBonificacao() // Virtual permite que a classe filha possa sobrescrever o metodo
        {
            return Salario * 0.10;
        }

        // Metodo impirmir dados
        public virtual void ImprimirDados()
        {
            Console.WriteLine("Nome: " + Nome);
            Console.WriteLine("CPF: " + CPF);
            Console.WriteLine("Salario: " + Salario);
            Console.WriteLine("Bonificação: " + GetBonificacao());
        }
    }
}