using System;

namespace mentoria.NewImplementation
{
    public class Salario
    {
        public Salario(decimal valorDoSalario)
        {
            SalarioAtual = valorDoSalario;
        }
        public decimal SalarioAtual { get; private set; }
        public Salario Desconta(IDesconto desconto)
        {
            SalarioAtual -= desconto.Calcula(SalarioAtual);
            return this;
        }
    }
}
