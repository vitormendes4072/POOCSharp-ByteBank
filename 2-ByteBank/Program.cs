using System;

namespace _2_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente();
            conta.Titular = "Gabriel";
            Console.WriteLine(conta.Titular);
            Console.WriteLine(conta.Saldo);
        }
    }
}
