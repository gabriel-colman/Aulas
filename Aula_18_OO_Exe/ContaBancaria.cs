using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_18_OO_Exe
{
    public class ContaBancaria
    {
        // Fazer as prorpiedades da classe
        public int Numero { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }

        // Contrutor
        public ContaBancaria(int numero, string titular)
        {
            Numero = numero;
            Titular = titular;
        }

        // Contrutor co 3 parametros
        public ContaBancaria(int numero, string titular, double saldo) : this(numero, titular)
        {
            Saldo = saldo;
        }

        // Função Deposito
        public void Deposito(double quantia)
        {
            Saldo += quantia;
        }

        // Função Saque
        public void Saque(double quantia)
        {
            Saldo -= quantia + 5.0;
        }

        // Função para mostrar os dados da conta
        public override string ToString()
        {
            return "Conta " + Numero + ", Titular: " + Titular 
            + ", Saldo: $ " + Saldo.ToString("F2");
        }
    }
}