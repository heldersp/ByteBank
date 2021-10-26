using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente = new Cliente();
            ContaCorrente conta = new ContaCorrente();

            cliente.Nome = "João da Silva";
            cliente.CPF = "123456789-00";
            cliente.Profissao = "Arquiteto";

            conta.Titular = cliente;
            conta.Saldo = -10;

            Console.WriteLine(conta.Saldo);
            Console.WriteLine(conta.Titular.Nome);

            Console.ReadLine();

        }
    }
}
