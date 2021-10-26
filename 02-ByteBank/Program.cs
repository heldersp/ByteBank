using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaGabriel = new ContaCorrente();
            contaGabriel.titular = "Gabriel";
            contaGabriel.agencia = 863;
            contaGabriel.numero = 863452;
            

            Console.WriteLine("Titular: " + contaGabriel.titular);
            Console.WriteLine("Agência: " + contaGabriel.agencia);
            Console.WriteLine("Número da conta: " + contaGabriel.numero);
            Console.WriteLine("Saldo da conta: " + contaGabriel.saldo);

            Console.ReadLine();
        }
    }
}
