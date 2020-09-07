using System;

namespace _05___ByteBank
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Cliente gabriela = new Cliente();

            //gabriela.nome = "Gabriela";
            //gabriela.profissao = "Desenvedora C#";
            //gabriela.cpf = "232.232.222-35";

            ContaCorrente contaCorrente = new ContaCorrente();

            //contaCorrente.titular = gabriela;
            contaCorrente.titular = new Cliente();
            contaCorrente.titular.nome = "Gabriela Costa";
            contaCorrente.titular.cpf = "232.232.222-35";
            contaCorrente.titular.profissao = "Desenvolvedora C#";


            contaCorrente.saldo = 500;
            contaCorrente.agencia = 564;
            contaCorrente.numero = 5655444;

            //Console.WriteLine(gabriela.nome);
            Console.WriteLine(contaCorrente.titular.nome);
            Console.WriteLine(contaCorrente.titular.cpf);
            Console.WriteLine(contaCorrente.titular.profissao);
            Console.WriteLine(contaCorrente.saldo);

            Console.ReadLine();
        }
    }
}
