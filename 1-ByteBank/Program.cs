using System;

namespace _1_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente vitoria = new ContaCorrente();
            vitoria.Saldo = 10;
            vitoria.Titular = "Vitoria";
            vitoria.NumeroConta = 889;
            vitoria.NumeroAgencia = 88;
            Console.WriteLine($"Nome: {vitoria.Titular}");
            Console.WriteLine($"Agência: {vitoria.NumeroAgencia}");
            Console.WriteLine($"Número: {vitoria.NumeroConta}");
            Console.WriteLine($"Saldo: R${vitoria.Saldo}");
            vitoria.Saldo += 200;
            Console.WriteLine($"Saldo: R${vitoria.Saldo}");
        }
    }
}
