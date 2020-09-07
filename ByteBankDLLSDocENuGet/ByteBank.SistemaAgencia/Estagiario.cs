using ByteBank.Modelos.Funcionarios;
using System;

namespace ByteBank.SistemaAgencia
{
    class Estagiario : Funcionario
    {
        public Estagiario(double salario, string cpf)
    : base(salario, cpf)
        {

        }

        public override void AumentarSalario()
        {
            // Qualquer código
        }

        protected override double GetBonificacao()
        {
            throw new NotImplementedException();
        }
    }
}
