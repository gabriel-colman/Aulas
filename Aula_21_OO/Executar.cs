using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aula_21_OO.Desafio_3;

namespace Aula_21_OO
{
    public class Executar
    {
        public static void Main(string[] args)
        {
            List<Cliente> clientes = new List<Cliente>();
            List<Produto> produtos = new List<Produto>();
            List<Venda> vendas = new List<Venda>();
            Estoque estoque = new Estoque();

            int opcao;

            do
            {
                Console.Clear();//Limpa a tela
                Console.WriteLine("1 - Cadastrar Cliente");
                Console.WriteLine("2 - Cadastrar Produto");
                Console.WriteLine("3 - Cadastrar Venda");
                Console.WriteLine("4 - Consultar Estoque");
                Console.WriteLine("5 - Gerar Relatório de Funcionarios");
                Console.WriteLine("6 - Sair");
                Console.Write("Digite a opção desejada: ");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        CadastrarCliente(clientes);
                        break;
                    case 2:
                        CadastrarProduto(produtos, estoque);
                        break;
                    case 3:
                        RegistrarVenda(clientes, produtos, vendas);
                        break;
                    case 4:
                        ConsultarEstoque(estoque);
                        break;
                    case 5:
                        GerarRelatorioVendas(vendas);
                        break;
                    case 6:
                        Console.WriteLine("Saindo...");
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }
            } while (opcao != 6);
        }

        public static void CadastrarCliente(List<Cliente> clientes)
        {
            Console.Write("Digite o nome do cliente: ");
            string nome = Console.ReadLine();
            Console.Write("Digite o CPF do cliente: ");
            string cpf = Console.ReadLine();
            Console.Write("Digite o Telefone: ");
            string telefone = Console.ReadLine();
            Console.Write("Digite o Endereço: (Rua, Número, Bairro, Cidade, Estado)");
            string endereco = Console.ReadLine();

            Cliente cliente = new ClienteGold
            {
                Nome = nome,
                CPF = cpf,
                Telefone = telefone,
                Endereco = new Endereco
                {
                    Rua = endereco.Split(", ")[0],
                    Cidade = endereco.Split(", ")[1],
                    Estado = endereco.Split(", ")[2],
                    CEP = endereco.Split(", ")[3]
                }
            };
        }
    }
}