using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12___ForEncadeado
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando Projeto 10 - Calcula Poupança");

            // Uma forma diferente de fazer o desenho de asteriscos
            for (int contadorLinha = 0; contadorLinha < 10; contadorLinha++)
            {
                for (int contadorColuna = 0; contadorColuna <= contadorLinha; contadorColuna++)
                    Console.Write("*");
                
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
