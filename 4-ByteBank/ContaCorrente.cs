using System;
using System.Collections.Generic;
using System.Text;

namespace _2_ByteBank
{
    class ContaCorrente
    {
        public string Titular { get; set; }
        public int NumeroAgencia { get; set; }
        public int NumeroConta { get; set; }
        public double Saldo { get; set; }

        public bool Sacar(double valor)
        {
            if (this.Saldo < valor)
            {
                return false;
            }
            this.Saldo -= valor;
            return true;
        }

        public bool Depositar(double valor)
        {
            if (valor <= 0)
            {
                return false;
            }
            this.Saldo += valor;
            return true;
        }

        public void Transferir(double valor, ContaCorrente conta)
        {
                Sacar(valor);
                conta.Depositar(valor);
        }
    }
}
