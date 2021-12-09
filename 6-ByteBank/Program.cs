using System;

namespace _6_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente();
            conta.Saldo = -10;
            conta.Titular = new Cliente();
            conta.Titular.Nome = "Felipe";
            conta.Titular.Cpf = "235.467.577-57";
            conta.Titular.Profissao = "Desenvolvedor Java";
            Console.WriteLine(conta.Titular.Nome);
            Console.WriteLine(conta.Saldo);
        }
    }
}
