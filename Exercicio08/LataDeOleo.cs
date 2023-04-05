namespace Exercicio08
{
    internal class LataDeOleo
    {
        public double raio;
        public double altura;

        public LataDeOleo()
        {
        }

        public double CalcularVolume()
        {
            return Math.PI * Math.Pow(raio, 2) * altura;
        }
    }
}