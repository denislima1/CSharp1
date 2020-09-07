using ByteBankImportacaoExportacao.Modelos;
using System;
using System.IO;
using System.Text;

namespace ByteBankImportacaoExportacao
{
    partial class Program
    {
        static void EscritaBinaria()
        {
            using (var fs = new FileStream("contaCorrente.txt", FileMode.Create))
            using (var escrito = new BinaryWriter(fs))
            {
                escrito.Write(233); // Numero da Agencia
                escrito.Write(323221); // Numero da Conta
                escrito.Write(4000.50); // Saldo
                escrito.Write("Denis Lima");
            }
        }

        static void LeituraBinaria()
        {
            using (var fs = new FileStream("contaCorrente.txt", FileMode.Open))
            using (var leitor = new BinaryReader(fs))
            {
                var agencia = leitor.ReadInt32();
                var numeroConta = leitor.ReadInt32();
                var saldo = leitor.ReadDouble();
                var titular = leitor.ReadString();

                Console.WriteLine($"{titular} /{agencia} / {numeroConta} { saldo}");
            }
        }
    }
}
