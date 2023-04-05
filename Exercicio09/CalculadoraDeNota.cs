using System.Collections;

namespace Exercicio09
{
    internal class CalculadoraDeNota
    {
        public ArrayList listaDeNotas;

        public CalculadoraDeNota()
        {
        }

        public double MediaHarmonica()
        {
            double temp = 0;
            foreach (var nota in listaDeNotas)
                temp += (1/Convert.ToDouble(nota));
            
            return listaDeNotas.Count / temp;
        }
    }
}