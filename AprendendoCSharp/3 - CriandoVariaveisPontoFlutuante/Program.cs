using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3___CriandoVariaveisPontoFlutuante
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 3 - Criando variaveis ponto flutante");

            double salario;
            salario = 1200.50;

            Console.WriteLine("Seu salário é " + salario + "!");

            double idade;
            idade = 25.3 + 2;

            Console.WriteLine("Sua idade é " + idade + "!");

            Console.WriteLine("A execução acabou. Tecle enter para sair... ");
            Console.ReadLine();
        }
    }
}
