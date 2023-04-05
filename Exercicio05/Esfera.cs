namespace Exercicio05
{
    internal class Esfera
    {
        public double raio;

        public Esfera()
        {
        }

        public double CalcularVolume()
        {
            return (4.0 / 3.0) * Math.PI * Math.Pow(raio, 3);
        }
    }
}