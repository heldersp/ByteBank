using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaGabriel = new ContaCorrente();
            contaGabriel.titular = "Gabriel";
            contaGabriel.agencia = 863;
            contaGabriel.numero = 863452;

            ContaCorrente contaGabrielSilva = new ContaCorrente();
            contaGabrielSilva.titular = "Gabriel";
            contaGabrielSilva.agencia = 863;
            contaGabrielSilva.numero = 863452;

            //Console.WriteLine("Igualdade do tipo referência: " + (contaGabriel == contaGabrielSilva));

            int idade = 28;
            int idade2 = 28;

            contaGabriel = contaGabrielSilva;
            Console.WriteLine(contaGabriel == contaGabrielSilva);

            contaGabriel.saldo = 300;
            Console.WriteLine(contaGabriel.saldo);
            Console.WriteLine(contaGabrielSilva.saldo);

            Console.ReadLine();
        }
    }
}
