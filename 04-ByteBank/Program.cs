using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaBruno = new ContaCorrente();

            contaBruno.titular = "Bruno";
            Console.WriteLine(contaBruno.saldo);
            
            bool resultadoSaque = contaBruno.Sacar(500);
            Console.WriteLine(contaBruno.saldo);
            Console.WriteLine(resultadoSaque);

            contaBruno.Depositar(500);
            Console.WriteLine(contaBruno.saldo);

            ContaCorrente contaGabriela = new ContaCorrente();

            contaGabriela.titular = "Gabriela";

            Console.WriteLine("Saldo do Bruno " + contaBruno.saldo);
            Console.WriteLine("Saldo da Gabrielas " + contaGabriela.saldo);

            bool resultadoTransferencia = contaBruno.Transferir(200, contaGabriela);
            Console.WriteLine("Resultado da transferencia: " + resultadoTransferencia);
            Console.WriteLine("Saldo do Bruno " + contaBruno.saldo);
            Console.WriteLine("Saldo da Gabrielas " + contaGabriela.saldo);

            Console.ReadLine();
        }
    }
}
