using _2_ByteBank;
using System;

namespace _3_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente gabriel = new ContaCorrente();
            gabriel.Titular = "Gabriel";
            gabriel.NumeroAgencia = 854;
            gabriel.NumeroConta = 85455;

            ContaCorrente joao = new ContaCorrente();
            gabriel.Titular = "João";
            gabriel.NumeroAgencia = 854;
            gabriel.NumeroConta = 85455;

            Console.WriteLine("Igualdade de tipo de referência: " + (gabriel == joao));

            int idade = 20;
            int idade1 = 20;

            Console.WriteLine("Igualdade de tipo de valor: " + (idade == idade1));
            gabriel = joao;
            gabriel.Saldo = 20;
            Console.WriteLine(gabriel.Saldo);
            Console.WriteLine(joao.Saldo);
        }
    }
}
