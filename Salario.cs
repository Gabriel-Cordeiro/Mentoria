using System;

namespace mentoria
{
  public class Salario
  {
    public Salario(decimal valorDoSalario)
    {
      SalarioAtual = valorDoSalario;
    }
    public decimal SalarioAtual { get; private set; }
    public Salario Desconta(IImposto desconto)
    {
      SalarioAtual -= desconto.Calcula(SalarioAtual);
      return this;
    }
  }
}