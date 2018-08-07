using _01.FIAP.HelloWorld.Console.UI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.FIAP.HelloWorld.Console.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro carro = new Carro(2010, 2.0);

            carro.Ano = 2010;
            carro.ArCondicionado = false;
            carro.TipoCarro = TipoCarro.Passeio;

            System.Console.WriteLine(carro.Ano);

            var lancha = new Lancha(2019, 50)
            {
                Ano = 2010,
                BoiaSalvaVida = true,
            };
        }
    }
}
