namespace Carros010
{
    class Program
    {
        static void Main(string[] args)
        {
            var carro = new Carro();

            carro.Cor = "Azul";
            carro.Ligar();
            carro.Andar();
        }
    }
}
