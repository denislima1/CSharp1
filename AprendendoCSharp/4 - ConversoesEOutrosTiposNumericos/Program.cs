using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4___ConversoesEOutrosTiposNumericos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o Projeto 4");

            double salario;
            salario = 1200.50;
            //int é um tipo variavel que suporta até 32 bits//
            int salarioEmInteiro = (int)salario;            
            Console.WriteLine(salarioEmInteiro);
            //Long é uma variavel de 64 bits//
            long idade = 13000000000;
            Console.WriteLine(idade);
            //short é uma variavel de 16 bits//
            short quantidadeProdutos = 1500;
            Console.WriteLine(quantidadeProdutos);
            //float//
            float altura = 1.80f;
            Console.WriteLine(altura);

            Console.ReadLine();
        }
    }
}
