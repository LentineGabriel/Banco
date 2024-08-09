using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    internal class ContaBancaria
    {
        public int NumConta { get; private set; } // private set p/ impedir que o número seja alterado
        public string NomeConta { get; set; }
        public double Saldo { get; private set; } // mesma coisa aqui

        // conta que não recebe saldo inicial (ou seja, inicializa com zero)
        public ContaBancaria(int numConta, string nomeConta)
        {
            NumConta = numConta;
            NomeConta = nomeConta;
        }

        // conta que inicializa com saldo inicial (valor dado pelo usuário)
        public ContaBancaria(int numConta, string nomeConta, double depositoInicial) : this(numConta, nomeConta)
        {
            DepositoConta(depositoInicial);
        }

        public double DepositoConta(double deposito)
        {
            return Saldo = deposito += Saldo;
        }

        public double SaqueConta(double saque)
        {
            return Saldo = (Saldo -= saque) - 5.00;
        }

        public override string ToString()
        {
            return $"Conta {NumConta}, Titular: {NomeConta}, Saldo: {Saldo}";
        }
    }
}
