namespace Exercicio04
{
    internal class CalculadoraDeConsumo
    {
        public double quilometragemInicial;
        public double quilometragemFinal;
        public double consumoCombustivel;

        public CalculadoraDeConsumo()
        {
        }

        public double ConsumoPorKm()
        {
            return consumoCombustivel / (quilometragemFinal - quilometragemInicial);
        }
    }
}