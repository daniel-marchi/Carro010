using System;

namespace Carros010
{
    public class Carro
    {
        //Propriedades = características (o que ele tem)
        //Métodos = ações (o que ele faz)

        //Propriedades
        public string Cor { get; set; }

        public string Modelo { get; set; }

        //Métodos
        public void Andar()
        {
            Console.WriteLine($"Carro {Cor} Andando");
        }
        public void Ligar()
        {
            Console.WriteLine($"Carro {Cor} Ligado");
        }
    }
}
