using ByteBankImportacaoExportacao.Modelos;
using System;
using System.IO;
using System.Text;

namespace ByteBankImportacaoExportacao
{
    partial class Program
    {
        static void CriarArquivo()
        {
            var caminhoNovoArquivo = "contasExportadas.csv";

            using (var fluxoDeArquivo = new FileStream(caminhoNovoArquivo, FileMode.Create))
            {
                var contaComoString = "456,78945,4785.50, Gustavo Santos";
                var enconding = Encoding.UTF8;

                var bytes = enconding.GetBytes(contaComoString);


                fluxoDeArquivo.Write(bytes, 0, bytes.Length);
            }
        }

        static void CriarArquivoComWriter()
        {
            var caminhoNovoArquivo = "contasExportadas.csv";

            using (var fluxoDeArquivo = new FileStream(caminhoNovoArquivo, FileMode.CreateNew))
            using (var escritor = new StreamWriter(fluxoDeArquivo, Encoding.UTF8))
            {
                escritor.Write("456, 65465, 465.0, Pedro");
            }
        }

        static void TestaEscrita()
        {
            var caminhoNovoArquivo = "teste.txt";

            using (var fluxoDeArquivo = new FileStream(caminhoNovoArquivo, FileMode.Create))
            using (var escritor = new StreamWriter(fluxoDeArquivo))
            {
                for (int i = 0; i < 100000000; i++)
                {
                    escritor.WriteLine($"Linha {i}");

                    escritor.Flush(); // Despeja o buffer para o stream

                    Console.WriteLine($"Linha {i} foi escrita no arquivo. Tecle enter para adicionar mais uma");
                    Console.ReadLine();
                }
            }
        }

        static void SobrescreverArquivo()
        {
            var arquivoOriginal = new FileStream("conta.txt", FileMode.Open);
            var arquivoNovo = new FileStream("conta2.txt", FileMode.Create);
            var buffer = new byte[1024];

            using (arquivoOriginal)
            using (arquivoNovo)
            {
                var bytesLidos = -1;
                while (bytesLidos != 0)
                {
                    bytesLidos = arquivoOriginal.Read(buffer, 0, 1024);
                    arquivoNovo.Write(buffer, 0, bytesLidos);
                }
            }

            var rodape = Encoding.UTF8.GetBytes("Este documento é uma cópia do original");
        }
    }
}
