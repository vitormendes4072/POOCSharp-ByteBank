using _2_ByteBank;
using System;

namespace _4_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente cc = new ContaCorrente();
            cc.Saldo = 100;
            cc.Sacar(200);
            Console.WriteLine(cc.Saldo);

            cc.Depositar(100);
            Console.WriteLine(cc.Saldo);

            ContaCorrente cc1 = new ContaCorrente();

            cc.Transferir(100, cc1);
            Console.WriteLine(cc1.Saldo);
            Console.WriteLine(cc.Saldo);
        }
    }
}
