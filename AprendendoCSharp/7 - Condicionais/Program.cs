using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7___Condicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 7 - Condicionais");

            string nome = "Johnny";
            int idade = 18;
            int quantidadePessoas = 2;

            if (idade >= 18)
            {
                Console.WriteLine("É maior de idade");
            }
            else if (quantidadePessoas >= 2 && nome != "Johnny")
                {
                    Console.WriteLine("É menor de idade, porem está acompanhado com alguem confiavel, pode entrar");
                }
                else
                {
                    Console.WriteLine("É menor de idade, e está acompanhado do Johnny não pode entrar, são dois trouxas!!!");
                }        
            Console.ReadLine();
        }
    }
}
