using System;

namespace _7_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente(876, 4567777);
            //conta.NumeroAgencia = 876;
            //conta.NumeroConta = 4567777;
            ContaCorrente conta2 = new ContaCorrente(876, 4567777);

            Console.WriteLine(ContaCorrente.NumeroContasCriadas);
        }
    }
}
