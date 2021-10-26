using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {

            ContaCorrente conta = new ContaCorrente(867, 8674512, "Vanessa da Silva");
            Console.WriteLine("Nome do titular: " + conta.Nome);
            Console.WriteLine("Número da agência: " + conta.Agencia);
            Console.WriteLine("Número da conta: " + conta.Numero);
            Console.WriteLine("Total de contas criadas até o momento: " + ContaCorrente.TotalDeContasCriadas);
            Console.WriteLine("\r\n");

            ContaCorrente contaGabriel = new ContaCorrente(867, 86745820, "Gabriel da Silva");
            Console.WriteLine("Nome do titular: " + contaGabriel.Nome);
            Console.WriteLine("Número da agência: " + contaGabriel.Agencia);
            Console.WriteLine("Número da conta: " + contaGabriel.Numero);
            Console.WriteLine("Total de contas criadas até o momento: " + ContaCorrente.TotalDeContasCriadas);
            Console.WriteLine("\r\n");


            Console.ReadLine();

        }
    }
}
