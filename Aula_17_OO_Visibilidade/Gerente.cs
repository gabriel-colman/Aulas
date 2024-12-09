using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_17_OO_Visibilidade
{
    public class Gerente : Funcionario
    {
        // Contrutor
        public Gerente(string nome, double salario) 
        : base(nome, salario, "Gerente")
        {

        }

        // Chamar metodo publico da classe base
        public void Imprimir(){
            ExibirInformacoes();
        }

        // Chamar metodo protegido da classe base
        public void AtualizarCargoGerente(string novoCargo){
            AtualizarCargo(novoCargo);
        }

        // Chamar metodo privado da classe base
        private void CalcularImpostoGerente(){
            // Console.WriteLine(CalcularImposto()); // Se for acessar o metodo privado da classe base, dara erro
        }
    }
   
}