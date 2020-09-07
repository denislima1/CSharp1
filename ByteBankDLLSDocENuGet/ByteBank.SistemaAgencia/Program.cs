using ByteBank.Modelos;
using ByteBank.Modelos.Funcionarios;
using Humanizer;
using System;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            //pagina?argumentos
            //012345678

            string urlParametros = "http://www.bytebank.com/cambio?moedaOrigem=moedaDestino&moedaDestino=dolar";
            ExtratorValorDeArgumentosURL extratorDeValores = new ExtratorValorDeArgumentosURL(urlParametros);

            string valor = extratorDeValores.GetValor("moedaDestino");

            Console.WriteLine("Valor de moedaDestino: " + valor);
            Console.ReadLine();


            string textVazio = "";
            string textNulo = null;

            Console.WriteLine(string.IsNullOrEmpty(textVazio));
            Console.WriteLine(string.IsNullOrEmpty(textNulo));


            string url = "dsdsdsdsdsd?argumentos";

            int indiceInterrogacao = url.IndexOf('?');

            Console.WriteLine(indiceInterrogacao);

            Console.WriteLine(url);
            string argumentos = url.Substring(indiceInterrogacao + 1);
            Console.WriteLine(argumentos);





            //DateTime dataFimPagamento = new DateTime(2020,11,01);

            //DateTime dataCorrente = DateTime.Now;

            //TimeSpan diferencaData = dataFimPagamento - dataCorrente;
            //TimeSpan diferencaHora = TimeSpan.FromMinutes(10);

            //string mensagemData = "Vencimento em: " + TimeSpanHumanizeExtensions.Humanize(diferencaData);
            //string mensagemHora = "Vencimento em: " + TimeSpanHumanizeExtensions.Humanize(diferencaHora);

            //Console.WriteLine(mensagemData);
            //Console.WriteLine(mensagemHora);

            ////Console.WriteLine(dataCorrente);
            ////Console.WriteLine(dataFimPagamento);

            Console.ReadLine();
        }

    }
} 
