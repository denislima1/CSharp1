using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04___ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDoBruno = new ContaCorrente();

            contaDoBruno.titular = "Bruno";

            Console.WriteLine("Seu saldo é: R$" + contaDoBruno.saldo);

            bool resultadoSaque = contaDoBruno.Sacar(500);
            Console.WriteLine(resultadoSaque);
            Console.WriteLine("Seu saldo é: R$" + contaDoBruno.saldo);

            contaDoBruno.Depositar(500);
            Console.WriteLine("Valor depositado: R$" + contaDoBruno.saldo);

            ContaCorrente contaDaGabriela = new ContaCorrente();
            contaDaGabriela.titular = "Gabriela";
            Console.WriteLine("Saldo da Gabriela: R$" + contaDaGabriela.saldo);
            Console.WriteLine("Saldo do Bruno: R$" + contaDoBruno.saldo);

            bool resultadoTransferencia = contaDoBruno.Transferir(200, contaDaGabriela);
            
            Console.WriteLine("Saldo da Gabriela: R$" + contaDaGabriela.saldo);
            Console.WriteLine("Saldo do Bruno: R$" + contaDoBruno.saldo);
            Console.WriteLine("Resultado da transferencia: " + resultadoTransferencia);

            Console.ReadLine();
        }
    }
}
