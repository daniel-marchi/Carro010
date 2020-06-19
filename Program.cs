namespace Carros010
{
    class Program
    {
        static void Main(string[] args)
        {
            var carro = new Carro();

            carro.Cor = "Prata";
            carro.Ligar();
            carro.Andar();
        }
    }
}
