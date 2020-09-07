using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9___Escopo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 8 - Condicionais 2");

            string nome = "Denis";
            int idade = 16;
            bool acompanhado = true;
            string mensagemAdicional;

            if (acompanhado == true)
            {
                mensagemAdicional = ("Está acompanhado.!");
            }
            else
            {
                mensagemAdicional = ("Não está acompanhado!");
            }

            if (idade >= 18 || acompanhado == true && nome != "Johnny")
            {
                Console.WriteLine("Pode entrar, você está com uma pessoa boa.!");
                Console.WriteLine(mensagemAdicional);
            }
            else
            {
                Console.WriteLine("Não pode entrar, você não anda com uma boa pessoa pessoa.!");
            }

            Console.ReadLine();
        }
    }
}
