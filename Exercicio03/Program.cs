namespace Exercicio03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cilindro cilindro = new Cilindro();
            cilindro.raio = 10;
            cilindro.altura = 20;


            Console.WriteLine($"O volume do cilindro é: {cilindro.CalcularVolume()}");
            Console.ReadLine();
        }
    }
}