namespace Exercicio07
{
    internal class CalculadoraDeSalario
    {
        public double salarioBase;
        public double totalDeVendas;
        public double percentualDeComissao;

        public CalculadoraDeSalario()
        {
        }

        public double SalarioTotal()
        {
            double comissao = (percentualDeComissao / 100) * totalDeVendas;

            return salarioBase + comissao;
        }
    }
}