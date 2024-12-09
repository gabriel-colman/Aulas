using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_17_OO_Visibilidade
{
    public class Executar
    {
        static void Main(string [] args){
            // Instaciar o objeto funcionario
            Funcionario funcionario = new Funcionario("Joao", 2000, "Analista");
            Console.WriteLine("Funcionario:" + funcionario.Nome);
            funcionario.Nome = "Fulano";
            Console.WriteLine("Funcionario:" + funcionario.Nome);
            // funcionario.Cargo = "Gerente"; // * Atributo protegido

            // Instaciar o objeto gerente
            Gerente gerente = new Gerente("Maria", 5000);
            Console.WriteLine("Gerente:" + gerente.Nome);
            gerente.Nome = "Ciclano";
            gerente.Nome = "Beltrano";
            Console.WriteLine("Gerente:" + gerente.Nome);
            gerente.AtualizarCargoGerente("Diretor");

            // gerente.CalcularImpostoGerente(); // * Metodo privado
        }
    }
}