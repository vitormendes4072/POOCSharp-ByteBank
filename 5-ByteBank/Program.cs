using System;

namespace _5_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            //Cliente lucas = new Cliente();
            //lucas.Nome = "Lucas";
            //lucas.Profissao = "Desenvolvedor C#";
            //lucas.Cpf = "125.754.678-90";

            ContaCorrente conta = new ContaCorrente();
            //conta.Titular = lucas;
            //conta.Titular = new Cliente();
            //conta.Titular.Nome = "Lucas";
            //conta.Titular.Cpf = "125.754.678-90";
            //conta.Titular.Profissao = "Desenvolvedor C#";

            conta.Saldo = 500;
            conta.NumeroAgencia = 563;
            conta.NumeroConta = 5563;

            if (conta.Titular == null)
            {
                Console.WriteLine("Referência em conta.titular é Null");
            }

            //Console.WriteLine(lucas.Nome);
            Console.WriteLine(conta.Titular);

        }
    }
}
