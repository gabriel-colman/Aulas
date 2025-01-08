using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_24_OO_Excessao.Exercicio
{
    public class Account
    {
        public int Number { get; private set; }
        public string Holder { get; private set; }
        public double Balance { get; private set; }
        public double WithdrawLimit { get; private set; }

        public Account(int number, string holder, double balance, double withdrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }

        public void Deposit(double amount)
        {
            if (amount <= 0)
            {
                throw new DomainException("Deposit amount must be greater than zero");
            }
            Balance += amount;
        }

        public void Withdraw(double amount)
        {
            if (amount > WithdrawLimit)
            {
                throw new DomainException("O valor excede o limite de saque");
            }
            if (amount > Balance)
            {
                throw new DomainException("Não há saldo suficiente");
            }
            if (amount <= 0)
            {
                throw new DomainException("O valor do saque deve ser maior que zero");
            }
            Balance -= amount;
        }
        public override string ToString()
        {
            return $"New balance: {Balance}, Holder: {Holder}, Withdraw limit: {WithdrawLimit}";
        }
    }
}