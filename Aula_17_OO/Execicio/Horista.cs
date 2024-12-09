using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_17_OO.Execicio
{
    public class Horista : Empregado
    {
        public double salarioHora;
        public double horasTrabalhadas;

        public Horista(string nome, string sobrenome, string cpf, double salarioHora, double horasTrabalhadas) : base(nome, sobrenome, cpf)
        {
            this.salarioHora = salarioHora;
            this.horasTrabalhadas = horasTrabalhadas;
        }

        public override double Vencimento()
        {
            double inss = 0.11;
            double ir = 0.275;
            double desconto = salarioHora * horasTrabalhadas * inss + salarioHora * horasTrabalhadas * ir;
            return desconto;
        }

        public override void MostrarDados()
        {
            base.MostrarDados();
            Console.WriteLine("Salário por Hora: " + salarioHora);
            Console.WriteLine("Horas Trabalhadas: " + horasTrabalhadas);

        }


    }
}