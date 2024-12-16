using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_18_OO_Exe
{
    public class Executar
    {
        static void Main(string[] args)
        {
            ContaBancaria conta;
            System.Console.WriteLine("Entre o numero da sua conta"); 
            int numero = int.Parse(Console.ReadLine());
            
            System.Console.WriteLine("Entre o nome do titular"); 
            string titular = Console.ReadLine();

            System.Console.WriteLine("Haverá deposito inicial (s/n)?");
            char resp = char.Parse(Console.ReadLine());
            if (resp == 's'|| resp == 'S')
            {
                System.Console.WriteLine("Entre o valor de deposito inicial:");
                double depositoInicial = double.Parse(Console.ReadLine());
                conta = new ContaBancaria(numero, titular, depositoInicial);
            }
            else {
                conta = new ContaBancaria(numero, titular);
            }

            System.Console.WriteLine();
            System.Console.WriteLine("Dados da Conta: ");
            System.Console.WriteLine(conta);

            System.Console.WriteLine();
            System.Console.WriteLine("Entre com o valor do deposito: ");
            double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Deposito(quantia);
            System.Console.WriteLine("Dados Atualizados da conta");
            System.Console.WriteLine(conta);
            
            System.Console.WriteLine();
            System.Console.WriteLine("Entre com o valor do saque: ");
            double saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Deposito(saque);
            System.Console.WriteLine("Dados Atualizados da conta");
            System.Console.WriteLine(conta);

        }
    }
}