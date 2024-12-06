using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_16_OO
{
    public class Executar
    {
        static void Main(string[] args)
        {


            // Instanciar os contrutores com parâmetros
            Carnes carnes = new Carnes("Picanha", 50.0, 10);
            Ferramentas ferramentas = new Ferramentas("Martelo", 20.0, 5);
            Laticinios laticinios = new Laticinios("Queijo", 10.0, 20);
            Petiscos petiscos = new Petiscos("Amendoim", 5.0, 50);
            Limpeza limpeza = new Limpeza("Detergente", 3.0, 100);

            // Exebindo informações
            Console.WriteLine("Produtos:");
            Console.WriteLine();
            System.Console.WriteLine($"Carne: {carnes.Nome}, Preço: {carnes.Preco}, Quantidade: {carnes.Quantidade}, Valor total em estoque: {carnes.CalcularValorEstoque()}");
            laticinios.ListarInfo();

            // Maior valos do estoque

            double maiorValor = Math.Max(carnes.CalcularValorEstoque(),
                    Math.Max(limpeza.CalcularValorEstoque(),
                        Math.Max(petiscos.CalcularValorEstoque(),
                             Math.Max(laticinios.CalcularValorEstoque(),
                                ferramentas.CalcularValorEstoque()))));

            System.Console.WriteLine($"Maior valor do estoque: {maiorValor}");
                    
        }
    }
}