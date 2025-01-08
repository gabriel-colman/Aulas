using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_24_OO_Excessao.Exercicio
{
    public class Executar
    {
        static void Main(string[] args)
        {
            try 
            {
                Console.WriteLine("Enter account data");
                Console.Write("Number: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Titutal: ");
                string holder = Console.ReadLine();
                Console.Write("Balanco Inicial: ");
                double balance = double.Parse(Console.ReadLine());
                Console.Write("Withdraw limit: ");
                double withdrawLimit = double.Parse(Console.ReadLine());

                Account account = new Account(number, holder, balance, withdrawLimit);

                Console.WriteLine();
                Console.Write("Comecando a sacar: + account");

                Console.WriteLine();
                Console.Write("Informe o valor do saque: ");
                double amount = double.Parse(Console.ReadLine());
                account.Withdraw(amount);

                Console.WriteLine();
                Console.WriteLine("Novo saldo: " + account.Balance.ToString("F2"));
                
            }
            catch (DomainException e)
            {
                Console.WriteLine("Erro no saque: " + e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Erro de formato: " + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Erro inesperado: " + e.Message);
            }
        }
    }
}