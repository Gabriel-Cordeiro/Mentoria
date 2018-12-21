using System;

namespace mentoria
{
  public class Salario
  {
    public Salario(decimal valor)
    {
      SalarioBruto = valor;
      CalcularSalarioliquido();
    }

    private decimal _salarioLiquido;
    public decimal SalarioLiquido
    {
      get
      {
        return Math.Round(_salarioLiquido,2);
      }
      protected set {}
    }
    private decimal SalarioBruto { get; set; }
    private void CalcularSalarioliquido()
    {
      _salarioLiquido = SalarioBruto;
      _salarioLiquido -= new Inss(SalarioLiquido).Calcular(SalarioLiquido);
      _salarioLiquido -= new ImpostoDeRenda(SalarioLiquido).Calcular(SalarioLiquido);
    }
  }
}