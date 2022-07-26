using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ws_modulo5
{
    class ContaBancaria
    {
        public int NumeroConta { get; private set; }
        public string NomeTitular { get; set; }

        public double? ValorInicial { get; set; }

        public double Saldo { get; private set; }


        public ContaBancaria(int numeroConta, string nomeTitular)
        {
            NumeroConta = numeroConta;
            NomeTitular = nomeTitular;
        }

        public ContaBancaria(int numeroConta, string nomeTitular, double saldo) : this(numeroConta, nomeTitular)
        {
            Saldo = saldo;
        }

        public double Deposito(double valorDeposito)
        {
            return Saldo += valorDeposito;
        }

        public double Saque(double valorSaque)
        {
            return Saldo -= (valorSaque + 5.0);
        }

        public override string ToString()
        {
            return $"\n{NomeTitular} \nConta Bancária: {NumeroConta} \nSaldo: {Saldo}";
        }
    }
}
