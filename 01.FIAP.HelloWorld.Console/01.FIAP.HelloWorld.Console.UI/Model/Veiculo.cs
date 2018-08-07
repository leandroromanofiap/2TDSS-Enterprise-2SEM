using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.FIAP.HelloWorld.Console.UI.Model
{
    public abstract class Veiculo
    {
        public double Potencia { get; set; }

        public int Ano { get; set; }

        public Veiculo(int ano, double potencia)
        {
            Potencia = potencia;
            Ano = ano;
        }

        public virtual void Acelerar() => System.Console.WriteLine("Veiculo acelerando!");

        public abstract void Desligar();
    }
}
