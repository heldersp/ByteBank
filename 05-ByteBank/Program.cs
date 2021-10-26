using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente gabriel = new Cliente();
            gabriel.nome = "Gabriel";
            gabriel.profissao = "Professor";
            gabriel.cpf = "123.456.789-00";

            ContaCorrente conta = new ContaCorrente();

            conta.titular = gabriel;
            conta.saldo = 500;
            conta.agencia = 463;
            conta.numero = 463444;

            Console.WriteLine(gabriel.nome);
            Console.WriteLine(conta.titular.nome);

            Console.ReadLine();
        }
    }
}
