using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_20_OO_Relacoes.Exer2
{
    public class Executar
    {
        static void Main(string[] args)
        {
            // Criando Estado e Cidade
            Estado estado = new Estado("Mato Grosso do Sul", "MS");
            Cidade cidade = new Cidade("Campo Grande", estado);

            // Criando Endereço
            Endereco endereco = new Endereco("Rua A", 123, "Centro", "79000-000", cidade);

            // Criando Equipe de Vendas
            EquipeVenda equipe = new EquipeVenda("Equipe Norte");

            // Criando um Vendedor
            Vendedor vendedor = new Vendedor("Carlos", new DateTime(1990, 5, 20), "123.456.789-00", endereco, equipe);

            // Criando um Gerente
            Gerente gerente = new Gerente("Ana", new DateTime(1985, 3, 15), "987.654.321-00", endereco);

            // Exibindo informações
            Console.WriteLine("=== Informações do Vendedor ===");
            Console.WriteLine($"Nome: {vendedor.Nome}");
            Console.WriteLine($"Nascimento: {vendedor.Nascimento:d}"); // :d formata a data
            Console.WriteLine($"CPF: {vendedor.CPF}");
            Console.WriteLine($"Endereço: {vendedor.Endereco.Rua}, {vendedor.Endereco.Numero}, {vendedor.Endereco.Cidade.Nome}, {vendedor.Endereco.Cidade.Estado.Sigla}");
            Console.WriteLine($"Equipe de Venda: {vendedor.Equipe.Nome}");
            Console.WriteLine($"Salário: R$ {vendedor.GetSalario()}");

            Console.WriteLine("\n=== Informações do Gerente ===");
            Console.WriteLine($"Nome: {gerente.Nome}");
            gerente.GetSalario(); // Método de salário
        }
    }
}