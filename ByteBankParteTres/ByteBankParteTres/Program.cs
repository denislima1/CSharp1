

using ByteBankParteTres.Funcionarios;
using ByteBankParteTres.Sistemas;
using System;

namespace ByteBankParteTres
{
    static class Program
    {
        static void Main(string[] args)
        {
            //CalcularBonificacao();
            UsarSistema();
            Console.ReadLine();

        }

        public static void UsarSistema()
        {
            SistemasInterno sistemasInterno = new SistemasInterno();

            Diretor roberta = new Diretor("433.212.221-45");
            roberta.Nome = "Roberta";
            roberta.Senha = "123";

            GerenteDeConta camila = new GerenteDeConta("133.212.221-45");
            camila.Nome = "Roberta";
            camila.Senha = "123";

            ParceiroComercial parceiroComercial = new ParceiroComercial();
            parceiroComercial.Senha = "123";

            sistemasInterno.Logar(roberta, "123");
            sistemasInterno.Logar(camila, "123");
            sistemasInterno.Logar(parceiroComercial, "123");


        }

        public static void CalcularBonificacao()
        {
            GerenciadorBonificacao gerenciadorBonificacao = new GerenciadorBonificacao();

            Funcionario pedro = new Designer("233.212.221-45");
            pedro.Nome = "Pedro";

            Funcionario roberta = new Diretor("433.212.221-45");
            roberta.Nome = "Roberta";

            Funcionario igor = new Auxiliar("533.212.221-45");
            igor.Nome = "Igor";

            Funcionario camila = new GerenteDeConta("133.212.221-45");
            camila.Nome = "Camila";

            Funcionario guilherme = new GerenteDeConta("133.212.221-45");
            guilherme.Nome = "Guilherme";

            gerenciadorBonificacao.Registrar(pedro);
            gerenciadorBonificacao.Registrar(roberta);
            gerenciadorBonificacao.Registrar(igor);
            gerenciadorBonificacao.Registrar(camila);
            gerenciadorBonificacao.Registrar(guilherme);


            Console.WriteLine("Total de bonificações do mês: " + gerenciadorBonificacao.GetTotalBonificacao());
        }
    }
}
