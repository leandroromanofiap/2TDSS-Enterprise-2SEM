using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.FIAP.HelloWorld.Console.UI.Model
{
    class Carro : Veiculo
    {
        public int Portas { get; set; }

        public bool ArCondicionado { get; set; }

        public TipoCarro TipoCarro { get; set; }

        public Carro(int ano, double potencia)
            : base(ano, potencia)
        {
        }

        public override void Desligar()
        {
            System.Console.WriteLine("Desligar a chave.");
        }
    }
}
