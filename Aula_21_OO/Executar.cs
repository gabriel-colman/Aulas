using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_21_OO.Desafio_3
{
    public class Executar
    {

        private static Dictionary<Estado, string> ApelidosPorEstado = new Dictionary<Estado, string>
        {
            { Estado.SP, "Chipa" },
            { Estado.MS, "Chipa" },
            { Estado.MG, "Pão de Queijo" },
            { Estado.RJ, "Biscoito" },
            { Estado.BA, "Acarajé" } // Adicione mais estados e apelidos conforme necessário
        };

        public static void Main(string[] args)
        {
            List<Cliente> clientes = new List<Cliente>();
            List<Produto> produtos = new List<Produto>();
            List<Venda> vendas = new List<Venda>();
            List<Vendedor> vendedores = new List<Vendedor>();

            Estoque estoque = new Estoque();

            int opcao;

            do
            {
                Console.Clear();
                Console.WriteLine("=== Sistema de Gestão de Padaria ===");
                Console.WriteLine("1. Cadastrar Cliente");
                Console.WriteLine("2. Cadastrar Produto");
                Console.WriteLine("3. Registrar Venda");
                Console.WriteLine("4. Consultar Estoque");
                Console.WriteLine("5. Gerar Relatório de Funcionários");
                Console.WriteLine("6. Consultar Apelido por Estado");
                Console.WriteLine("7. Sair");
                Console.Write("Escolha uma opção: ");
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
                        RegistrarVenda(produtos, vendas, clientes, vendedores);
                        break;
                    case 4:
                        ConsultarEstoque(estoque);
                        break;
                    case 5:
                        GerarRelatorioFuncionarios();
                        break;
                    case 6:
                        ConsultarApelidoPorEstado();
                        break;
                    case 7:
                        Console.WriteLine("Saindo do sistema...");
                        break;
                    default:
                        Console.WriteLine("Opção inválida! Tente novamente.");
                        break;
                }

                if (opcao != 7)
                {
                    Console.WriteLine("Pressione qualquer tecla para continuar...");
                    Console.ReadKey();
                }

            } while (opcao != 7);
        }

        private static void ConsultarApelidoPorEstado()
        {
            Console.Clear();
            Console.WriteLine("=== Consultar Apelido por Estado ===");
            Console.Write("Digite o estado (sigla, ex: SP, MS): ");
            string estadoStr = Console.ReadLine();

            if (Enum.TryParse(estadoStr, out Estado estado) && ApelidosPorEstado.ContainsKey(estado))
            {
                Console.WriteLine($"Apelido em {estado}: {ApelidosPorEstado[estado]}");
            }
            else
            {
                Console.WriteLine("Estado não encontrado ou sem apelido registrado.");
            }
        }

        private static void CadastrarCliente(List<Cliente> clientes)
        {
            Console.Clear();
            Console.WriteLine("=== Cadastro de Cliente ===");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("CPF: ");
            string cpf = Console.ReadLine();
            Console.Write("Telefone: ");
            string telefone = Console.ReadLine();
            Console.Write("Endereço (Rua, Cidade, Estado, CEP): ");
            string[] endereco = Console.ReadLine().Split(',');

            if (!Enum.TryParse(endereco[2].Trim(), out Estado estado))
            {
                Console.WriteLine("Estado inválido. Cliente não cadastrado.");
                return;
            }

            Console.WriteLine("Tipo de Cliente (1 - Gold, 2 - Platinum): ");
            int tipoCliente = int.Parse(Console.ReadLine());

            Cliente cliente;

            if (tipoCliente == 1)
            {
               Console.Write("Desconto: ");
                double desconto = double.Parse(Console.ReadLine());

                cliente = new ClienteGold
                {
                    Nome = nome,
                    CPF = cpf,
                    Telefone = telefone,
                    Endereco = new Endereco
                    {
                        Rua = endereco[0].Trim(),
                        Cidade = endereco[1].Trim(),
                        Estado = estado,
                        CEP = int.Parse(endereco[3].Trim())
                    },
                    Desconto = desconto
                };
            }
            else if (tipoCliente == 2)
            {
                Console.Write("Desconto: ");
                double desconto = double.Parse(Console.ReadLine());

                cliente = new ClientePlatinum
                {
                    Nome = nome,
                    CPF = cpf,
                    Telefone = telefone,
                    Endereco = new Endereco
                    {
                        Rua = endereco[0].Trim(),
                        Cidade = endereco[1].Trim(),
                        Estado = estado,
                        CEP = int.Parse(endereco[3].Trim())
                    },
                    Desconto = desconto
                };
            }
            else
            {
                Console.WriteLine("Tipo de cliente inválido. Cliente não cadastrado.");
                return;
            }

            clientes.Add(cliente);
            Console.WriteLine("Cliente cadastrado com sucesso!");
        }

        private static void CadastrarProduto(List<Produto> produtos, Estoque estoque)
        {
            Console.Clear();
            Console.WriteLine("=== Cadastro de Produto ===");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Código: ");
            int codigo = int.Parse(Console.ReadLine());
            Console.Write("Preço de Custo: ");
            double precoCusto = double.Parse(Console.ReadLine());
            Console.Write("Preço Final: ");
            double precoFinal = double.Parse(Console.ReadLine());

            Console.Write("Estado de referência (sigla, ex: SP, MS): ");
            string estadoStr = Console.ReadLine();

            if (!Enum.TryParse(estadoStr, out Estado estado) || !ApelidosPorEstado.ContainsKey(estado))
            { // tryParse tenta converter a string para um enum, se não conseguir, retorna false
                Console.WriteLine("Estado inválido ou sem apelido registrado. Produto não cadastrado.");
                return;
            }

            string apelido = ApelidosPorEstado[estado];

            Produto produto = new Produto
            {
                Nome = $"{nome} ({apelido})",
                Codigo = codigo,
                PrecoCusto = precoCusto,
                PrecoFinal = precoFinal,
                Apelido = apelido
            };

            produtos.Add(produto);
            estoque.Produtos = produtos.ToArray();
            Console.WriteLine("Produto cadastrado com sucesso!");
        }

        private static void RegistrarVenda(List<Produto> produtos, List<Venda> vendas, List<Cliente> clientes, List<Vendedor> vendedores)
        {
            Console.Clear();
            Console.WriteLine("=== Registrar Venda ===");

            // Selecionar Cliente
            Console.WriteLine("Selecione o Cliente:");
            for (int i = 0; i < clientes.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {clientes[i].Nome}");
            }
            int clienteIndex = int.Parse(Console.ReadLine()) - 1;
            Cliente cliente = clientes[clienteIndex];

            // Selecionar Vendedor
            Console.WriteLine("Selecione o Vendedor:");
            for (int i = 0; i < vendedores.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {vendedores[i].Nome}");
            }
            int vendedorIndex = int.Parse(Console.ReadLine()) - 1;
            Vendedor vendedor = vendedores[vendedorIndex];

            // Selecionar Produtos
            List<Produto> produtosVenda = new List<Produto>();
            while (true)
            {
                Console.WriteLine("Selecione o Produto (ou digite 0 para finalizar):");
                for (int i = 0; i < produtos.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {produtos[i].Nome} - R${produtos[i].PrecoFinal}");
                }
                int produtoIndex = int.Parse(Console.ReadLine()) - 1;
                if (produtoIndex == -1) break;
                produtosVenda.Add(produtos[produtoIndex]);
            }

            // Selecionar Forma de Pagamento
            Console.WriteLine("Forma de Pagamento:");
            string formaPagamento = Console.ReadLine();

            // Selecionar Parcelas
            Console.WriteLine("Número de Parcelas:");
            int parcelas = int.Parse(Console.ReadLine());

            // Criar Venda
            Venda venda = new Venda
            {
                Produtos = produtosVenda.ToArray(),
                Data = DateTime.Now,
                Vendedor = vendedor,
                FormaPagamento = formaPagamento,
                Parcelas = parcelas,
                Cliente = cliente
            };

            // Calcular Valor Final
            venda.ValorTotal = venda.CalcularValorFinal();

            // Adicionar Venda à lista de vendas
            vendas.Add(venda);

            // Atribuir a venda ao vendedor
            vendedor.VendasRealizadas += venda.ValorTotal;

            // Exibir informações da venda
            Console.WriteLine("Venda registrada com sucesso!");
            Console.WriteLine($"Cliente: {cliente.Nome}");
            Console.WriteLine($"Vendedor: {vendedor.Nome}");
            Console.WriteLine($"Data: {venda.Data}");
            Console.WriteLine($"Forma de Pagamento: {venda.FormaPagamento}");
            Console.WriteLine($"Parcelas: {venda.Parcelas}");
            Console.WriteLine($"Valor Final: R${venda.ValorTotal}");
        }

        private static void ConsultarEstoque(Estoque estoque)
        {
            Console.Clear();
            Console.WriteLine("=== Consulta de Estoque ===");
            if (estoque.Produtos != null)
            {
                for (int i = 0; i < estoque.Produtos.Length; i++)
                {
                    if (i < estoque.Quantidades.Length)
                    {
                        Console.WriteLine($"Produto: {estoque.Produtos[i].Nome}, Quantidade: {estoque.Quantidades[i]}");
                    }
                    else
                    {
                        Console.WriteLine($"Produto: {estoque.Produtos[i].Nome}, Quantidade: 0");
                    }
                }
            }
            else
            {
                Console.WriteLine("Estoque vazio.");
            }
        }
        private static void GerarRelatorioFuncionarios()
        {
            Console.Clear();
            Console.WriteLine("=== Relatório de Funcionários ===");
            Console.WriteLine("(Função não implementada neste exemplo)");
        }

    }
}