using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Banco.Model
{
    public class ContaPoupanca : Conta, IContaInvestimento
    {
        private readonly decimal _rendimento;
        public decimal Taxa { get; set; }

        public ContaPoupanca(decimal rendimento)
        {
            _rendimento = rendimento;
        }

        public override decimal Depositar(decimal valor)
        {
            Saldo = Saldo + valor;
            return Saldo;
        }

        public override decimal Retirar(decimal valor)
        {
            var novoSaldo = Saldo - (valor - Taxa);

            if (Saldo - (valor - Taxa) < 0)
                throw new Exception("Saldo insuficiente");

            Saldo = novoSaldo;

            return Saldo;
        }

        public decimal CalculaRetornoInvestimento()
        {
            return Saldo * _rendimento;
        }
    }
}
