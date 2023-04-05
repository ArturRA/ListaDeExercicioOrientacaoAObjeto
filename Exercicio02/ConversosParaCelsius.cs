namespace Exercicio02
{
    internal class ConversosParaCelsius
    {
        public double temperaturaFahrenheit;

        public ConversosParaCelsius()
        {
        }

        public double ConverterParaCelsius()
        {
            return (temperaturaFahrenheit - 32) * 5 / 9;
        }
    }
}