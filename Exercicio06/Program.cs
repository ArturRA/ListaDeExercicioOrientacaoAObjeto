namespace Exercicio06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConversosParaFahrenheit conversor = new ConversosParaFahrenheit();
            conversor.temperaturaCelsius= 37;


            Console.WriteLine($"A temperatura em Fahrenheit é: {conversor.ConverterParaFahrenheit()}");
            Console.ReadLine();
        }
    }
}