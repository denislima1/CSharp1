﻿using ByteBankParteTres.Sistemas;
using System;

namespace ByteBankParteTres.Funcionarios
{
    public class Diretor : FuncionarioAutenticavel
    {
        public Diretor(string cpf) : base(5000, cpf)
        {
            Console.WriteLine("Criando Diretor");
        }

        public override void AumentarSalario()
        {            
            Salario *= 1.15;
        }

        public override double GetBonificacao()
        {

            return Salario * 0.5;
        }
    }
}
