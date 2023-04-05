namespace Exercicio06
{
    internal class ConversosParaFahrenheit
    {
        public double temperaturaCelsius;

        public ConversosParaFahrenheit()
        {
        }

        public double ConverterParaFahrenheit()
        {
            return (temperaturaCelsius * 9 / 5) + 32;
        }
    }
}