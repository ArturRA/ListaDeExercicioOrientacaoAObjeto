namespace Exercicio03
{
    internal class Cilindro
    {
        public double raio;
        public double altura;

        public Cilindro()
        {
        }

        public double CalcularVolume()
        {
            return Math.PI * Math.Pow(raio, 2) * altura;
        }
    }
}