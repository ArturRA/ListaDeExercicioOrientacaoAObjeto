namespace Exercicio07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CalculadoraDeSalario calculadora = new CalculadoraDeSalario();
            calculadora.salarioBase = 100;
            calculadora.totalDeVendas = 20;
            calculadora.percentualDeComissao = 50;

            Console.WriteLine($"O salário total do vendedor é: {calculadora.SalarioTotal()}");
            Console.ReadLine();
        }
    }
}