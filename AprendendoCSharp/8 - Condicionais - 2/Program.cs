using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8___Condicionais___2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 8 - Condicionais 2");

            string nome = "Denis";
            int idade = 16;
            //int quantidadePessoas = 2;

            bool acompanhado = true;

            if (idade >= 18 || acompanhado == true && nome != "Johnny")
            {
                Console.WriteLine("Pode entrar, você está com uma pessoa boa.!");
            }
            else
            {
                Console.WriteLine("Não pode entrar, você não anda com uma boa pessoa pessoa.!");
            }

            Console.ReadLine();
        }
    }
}
