using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P10___calculaPoupanca
{
    class Program
    {
        static void Main(string[] args)
        {// 0.36% = 0.0036
            Console.WriteLine("Executando Projeto 10 - Calcula Poupança");
            
            double valorInvestido = 1000;
            int contarMes = 1;

            //while (contarMes <= 12)
            //{
            //    valorInvestido = valorInvestido + valorInvestido * 0.0036;
            //    Console.WriteLine("Apos " + contarMes + " meses você terá R$: " + valorInvestido);
            //    contarMes++;
            //}

            for (var i = 1; i <= 12; i++)
            {
                valorInvestido *= 1.0036;
                Console.WriteLine("Apos " + i + " meses você terá R$: " + valorInvestido);
                contarMes++;
            }

            Console.ReadLine();
        }
    }
}
