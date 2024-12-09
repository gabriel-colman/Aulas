using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_17_OO_Visibilidade
{
    public class Funcionario
    {
        // Atributo publico: acessivel de qualquer lugar
        public string Nome;

        // Atributo privado: acessivel apenas dentro da classe
        private double Salario;

        // Atributo protegido: acessivel apenas dentro da classe e suas subclasses
        protected string Cargo;

        // Construtor
        public Funcionario(string nome, double salario, string cargo)
        {
            Nome = nome;
            Salario = salario;
            Cargo = cargo;
        }

        // Metodo publico: acessivel de qualquer lugar
        public void ExibirInformacoes()
        {
            Console.WriteLine($"Nome: {Nome}");
            // Console.WriteLine($"Salario: {Salario}"); // * Acessando atributo privado
            Console.WriteLine($"Cargo: {Cargo}");
        }

        // Metodo protegido: acessivel apenas dentro da classe e suas subclasses
        protected void AtualizarCargo(string novoCargo)
        {
            Cargo = novoCargo;
            Console.WriteLine($"Cargo atualizado para: {Cargo}");
        }

        // Metodo privado: acessivel apenas dentro da classe
        private double CalcularImposto()
        {
            return Salario * 0.1; // 10%
        }
    }
}