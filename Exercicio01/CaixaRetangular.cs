namespace Exercicio01
{
    internal class CaixaRetangular
    {
        public int altura;
        public int comprimento;
        public int largura;

        public CaixaRetangular()
        {
        }

        public int CalcularVolume()
        {
            return altura * comprimento * largura;
        }
    }
}