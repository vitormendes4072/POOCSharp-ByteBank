using _2_ByteBank;
using System;

namespace _4_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente douglas = new ContaCorrente();
            douglas.Depositar(100);
            //Saque inválido
            douglas.Sacar(200);
            Console.WriteLine($"Saldo do Douglas: R$:{douglas.Saldo}");

            ContaCorrente jorge = new ContaCorrente();
            douglas.Transferir(100, jorge);
            Console.WriteLine($"Saldo do Jorge: R${jorge.Saldo}");
            Console.WriteLine($"Saldo do Douglas: R$:{douglas.Saldo}");
        }
    }
}
