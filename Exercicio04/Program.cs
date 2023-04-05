namespace Exercicio04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CalculadoraDeConsumo calculadora = new CalculadoraDeConsumo();
            calculadora.quilometragemInicial = 100;
            calculadora.quilometragemFinal = 200;
            calculadora.consumoCombustivel = 5;

            Console.WriteLine($"O consumo de combustível por Km é: {calculadora.ConsumoPorKm()}");
            Console.ReadLine();
        }
    }
}