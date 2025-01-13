using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aula26_ManipulacaoArquivo.Banco;
using ClosedXML.Excel;

namespace Aula26_ManipulacaoArquivo
{
    public class ExecutarBanco
    {
        static void Main(string[] args)
        {
            var cliente = new Customer("João");
            var contaCorrente  = new CurrentAccount(1234, cliente, 500);
            var contaPoupanca = new  SavingAccount(5421, cliente, 0.01);

            contaCorrente.Depositar(100);
            contaCorrente.Sacar(200);

            contaPoupanca.Depositar(500);
            contaPoupanca.AplicarRendimento();

            // Geracao de Excel
            GerarExcel(new List<Account> {contaCorrente, contaPoupanca});
        }

        public static void GerarExcel(List<Account> contas)
        {
            // geração excel
            // vamos instalar ClosedXML
            // rodar no terminal: dotnet add package ClosedXML
            using (var workbook = new XLWorkbook())
            {
                // Aqui estamos criando o arquivo Contas bancaria em excel
                var worksheet = workbook.AddWorksheet("Contas Bancarias");

                // Cabecalho
                worksheet.Cell(1,1).Value = "Numero da Conta"; // cell é celula no excel
                worksheet.Cell(1,2).Value = "Numero da Cliente"; // cell é celula no excel
                worksheet.Cell(1,3).Value = "Tipo da Conta"; // cell é celula no excel
                worksheet.Cell(1,4).Value = "Saldo"; // cell é celula no excel

                // Configurar para preencher a partir da linha 2
                int row = 2; // row é linha
                foreach (var item in contas)
                {
                    worksheet.Cell(row, 1).Value = item.NumeroConta;
                    worksheet.Cell(row, 2).Value = item.Cliente.Nome;
                    worksheet.Cell(row, 3).Value = item.TipoConta.ToString();
                    worksheet.Cell(row, 4).Value = item.Saldo;
                    row++;  // Para ir para proxima linha ai sucessivamente
                }

                workbook.SaveAs("ContasBancarias.xlsx");
                System.Console.WriteLine("Aquivo excel gerado com sucesso");

            }
        }
    }
}