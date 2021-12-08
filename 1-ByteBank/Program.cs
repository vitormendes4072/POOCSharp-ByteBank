using System;

namespace _1_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente vitoria = new ContaCorrente();
            vitoria.Saldo = 10;
            Console.WriteLine(vitoria.Saldo);
        }
    }
}
