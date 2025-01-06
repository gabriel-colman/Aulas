using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_21_OO.Desafio_3
{
    public abstract class Funcionario : IRelatorio
    {
        // Propridades autoimplementadas
        public string Nome { get; set; }
        public Endereco Endereco { get; set; }
        public int CPF { get; set; }
        public string Telefone { get; set; }
        public double SalarioBase { get; set; }

        // Aqui a composição vai acontecer lá na classe Executar
        // Pois vou atribuir o valor do Endereco quando eu atribuir o valor do Funcionario
        public abstract double CalcularSalario();
        public abstract void GerarRelatorio();
    }

    public class Gerente : Funcionario
    {
        public double Bonus { get; set; }
        public override double CalcularSalario()
        {
            return SalarioBase * 1.2;
        }

        public void CacularGratoficacao(){
            System.Console.WriteLine("Foi calculado a gratificação do Gerente");
        }
        public override void GerarRelatorio()
        {
            Console.WriteLine("Gerente: " + Nome);
            Console.WriteLine("Salário: " + CalcularSalario());
        }
    }

    public class Vendedor : Funcionario
    {
        public double VendasRealizadas { get; set; }
        public override double CalcularSalario()
        {
            return SalarioBase + (VendasRealizadas * 0.1);
        }

        public void CacularComissao(){
            System.Console.WriteLine("Foi calculado a comissão do Vendedor");
        }
        public override void GerarRelatorio()
        {
            Console.WriteLine("Vendedor: " + Nome);
            Console.WriteLine("Salário: " + CalcularSalario());
        }
    }

    public class Padeiro : Funcionario
    {
        public int HorasNoturnasTrabalhas { get; set; }
        public override double CalcularSalario()
        {
            double adicionalNoturno = HorasNoturnasTrabalhas * 
                (SalarioBase * 0.25/160); // Assumindo que é 160 horas /mes
            return SalarioBase + adicionalNoturno;
        }

        public void CacularProducao(){
            System.Console.WriteLine("Foi calculado a produção do Padeiro");
        }
        public override void GerarRelatorio()
        {
            Console.WriteLine("Padeiro: " + Nome);
            Console.WriteLine("Salário: " + CalcularSalario());
        }
    }

}