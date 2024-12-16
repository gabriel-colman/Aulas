using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_19_OO_Interface
{
    public class CartaoCretido : IPagamento, IAnuidade
    {
        // Propriedades
        public string NumeroCartao { get; set; }
        public DateTime DataVencimento { get; set; }
        public double ValorAnuidade { get; set; }

        // Contrutor 
        public CartaoCretido(string numeroCartao)
        {
            NumeroCartao = numeroCartao;
        }

        public CartaoCretido(string numeroCartao, DateTime dataVencimento, double valorAnuidade)
        {
            NumeroCartao = numeroCartao;
            DataVencimento = dataVencimento;
            ValorAnuidade = valorAnuidade;
        }

        public void RealizarPagamento(double valor)
        {
            Console.WriteLine($"Pagamento de R$ {valor} realizado com sucesso com o cartão {NumeroCartao}");
        }

        public void ExibirComprovante()
        {
            Console.WriteLine($"Comprovante de pagamento com o cartão {NumeroCartao} no dia {DateTime.Now}");
        }

        // Importar a interface IAnuidade
        public DateTime CalcularDataVencimento()
        {
            return DateTime.Now.AddYears(1); // Adiciona 1 ano a partir da data atual
        }

        public double CalcularValorAnuidade()
        {
            return 100; // Valor fixo da anuidade
        }
    }
}