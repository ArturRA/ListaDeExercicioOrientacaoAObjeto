namespace Exercicio02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConversosParaCelsius conversor = new ConversosParaCelsius();
            conversor.temperaturaFahrenheit= 100;


            Console.WriteLine($"A temperatura em Celsius é: {conversor.ConverterParaCelsius()}");
            Console.ReadLine();
        }
    }
}