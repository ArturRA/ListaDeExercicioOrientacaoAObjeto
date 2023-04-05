namespace Exercicio10
{
    internal class CalculadoraNotaPonderada
    {
        public double nota1;
        public double peso1;
        public double nota2;
        public double peso2;

        public CalculadoraNotaPonderada()
        {
        }

        public double CalcularMediaPonderada()
        {
            return (nota1 * peso1 + nota2 * peso2) / (peso1 + peso2);
        }
    }
}