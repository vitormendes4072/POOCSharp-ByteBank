using _7_ByteBank;
using System;
using System.Collections.Generic;
using System.Text;

namespace _7_ByteBank
{
    class ContaCorrente
    {
        public static int NumeroContasCriadas { get; private set; }
        public ContaCorrente(int numeroAgencia, int numeroConta)
        {
            NumeroConta = numeroConta;
            NumeroAgencia = numeroAgencia;
            NumeroContasCriadas++;
        }

        private int _numeroAgencia;
        public int NumeroAgencia
        {
            get { return _numeroAgencia; }
            set
            {
                if(value <= 0)
                {
                    return;
                }
                _numeroAgencia = value;
            }
        }
        public int NumeroConta { get; set; }
        public Cliente Titular { get; set; }
        private double _saldo;

        public double Saldo
        {
            get { return _saldo; }
            set
            {
                if (value < 0)
                {
                    return;
                }
                _saldo = value;
            }
        }

        public bool Sacar(double valor)
        {
            if (Saldo < valor)
            {
                return false;
            }
            Saldo -= valor;
            return true;
        }

        public void Transferir(double valor, ContaCorrente conta)
        {
            Sacar(valor);
            conta.Saldo = valor;
        }
    }
}
