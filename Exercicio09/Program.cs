using System.Collections;

namespace Exercicio09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CalculadoraDeNota calculadora = new CalculadoraDeNota();
            calculadora.listaDeNotas = new ArrayList();

            calculadora.listaDeNotas.Add(10);
            calculadora.listaDeNotas.Add(10);
            calculadora.listaDeNotas.Add(10);
            calculadora.listaDeNotas.Add(10);

            Console.WriteLine($"A média harmônica das notas é: {calculadora.MediaHarmonica()}");
            Console.ReadLine();
        }
    }
}