﻿using System;

namespace _2___CriandoVariaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 2 - Criando Variaveis");

            int idade;
            idade = 25;
            Console.WriteLine(idade);

            idade = 20 + 5;
            Console.WriteLine(idade);

            idade = 30 + 5;
            Console.WriteLine("Sua idade é " + idade + "!");

            Console.WriteLine("Execução finalizada. Tecle enter para sair.!");

            Console.ReadLine();
        }
    }
}
