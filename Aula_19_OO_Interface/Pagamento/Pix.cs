using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_19_OO_Interface
{
    public class Pix : IPagamento
    {
        public string? ChavePix { get; set; }
        public string? NomeTitular { get; set; }
        public string? Cpf { get; set; }
        public double Valor { get; set; }
        public DateTime DataPagamento { get; set; }

        // Contrutor
        public Pix(string chavePix, string nomeTitular, string cpf, double valor, DateTime dataPagamento)
        {
            ChavePix = chavePix;
            NomeTitular = nomeTitular;
            Cpf = cpf;
            Valor = valor;
            DataPagamento = dataPagamento;
        }

        // Implementação do método da interface IPagamento
        public void RealizarPagamento(double valor)
        {
            Valor = valor;
            Console.WriteLine("Pagamento realizado com sucesso via Pix de R$ " + valor);
        }

        // Método para ExibirComprovante
        public void ExibirComprovante()
        {
            Console.WriteLine("Comprovante de pagamento via Pix");
            Console.WriteLine("Chave Pix: " + ChavePix);
        }
    }

}