namespace Exercicio10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CalculadoraNotaPonderada calculadora = new CalculadoraNotaPonderada();
            calculadora.nota1 = 10;
            calculadora.peso1 = 2;
            calculadora.nota2 = 1;
            calculadora.peso2 = 1;

            Console.WriteLine($"A média ponderada é: {calculadora.CalcularMediaPonderada()}");
            Console.ReadLine();
        }
    }
}