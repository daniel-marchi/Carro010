using System;

namespace Carros010
{
    class Program
    {
        static void Main(string[] args)
        {
            var carro = new Carro();

            carro.Ligar();
        }
    }

    public class Carro
    {
        //Propriedades = características
        //Métodos = ações

        public void Ligar()
        {
            Console.WriteLine("Carro Ligado");
        }
    }
}
