using System;

namespace Carros010
{
    public class Carro
    {
        //Propriedades = características
        //Métodos = ações

        //Propriedades
        public string Cor { get; set; }

        public string Categoria { get; set; }

        public string Roda { get; set; }

        public int Portas { get; set; }

        //Métodos
        public void Andar()
        {
            Console.WriteLine("Carro Andando");
        }
        public void Ligar()
        {
            Console.WriteLine("Carro Ligado");
        }
    }
}
