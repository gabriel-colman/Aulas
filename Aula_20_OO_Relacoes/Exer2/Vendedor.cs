using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_20_OO_Relacoes.Exer2
{
    public class Vendedor : Funcionario
    {
        public EquipeVenda Equipe { get; set; } // Composição com EquipeVenda

        public Vendedor(string nome, DateTime nascimento, string cpf, Endereco endereco, EquipeVenda equipe)
            : base(nome, nascimento, cpf, endereco)
        {
            Equipe = equipe;
        }

        public float GetSalario()
        {
            // Implementação fictícia de salário
            return 3000.0f; // Exemplo fixo
        }
    }
}