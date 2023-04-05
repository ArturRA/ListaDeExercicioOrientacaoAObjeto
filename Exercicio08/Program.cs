namespace Exercicio08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LataDeOleo lata = new LataDeOleo();
            lata.raio = 10;
            lata.altura = 20;

            Console.WriteLine($"O volume da lata de óleo é: {lata.CalcularVolume()}");
            Console.ReadLine();
        }
    }
}