using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Banco.Model
{
    public sealed class ContaCorrente : Conta
    {
        public TipoConta TipoConta { get; set; }

        public override decimal Depositar(decimal valor)
        {
            Saldo = Saldo + valor;
            return Saldo;
        }

        public override decimal Retirar(decimal valor)
        {
            if (TipoConta == TipoConta.Comum)
            {
                if (Saldo - valor < 0)
                    throw new Exception("Saldo insuficiente para a conta do tipo comum.");

                Saldo = Saldo - valor;
            }

            return Saldo;
        }
    }
}
