using System;
using static mentoria.FaixaSalarialEnum;

namespace mentoria
{
  public class ImpostoDeRenda : Imposto
  {
    public ImpostoDeRenda(decimal salario)
    {
      FaixaSalarial = RetornaFaixaSalarial(salario);
      ValorImpostoDeRenda = Calcular(salario);
    }
    private decimal ValorImpostoDeRenda { get; set; }
    private FaixaIr FaixaSalarial { get; set; }
    public override decimal Calcular(decimal valor)
    {
      switch (FaixaSalarial)
      {
        case FaixaIr.Um:
          ValorImpostoDeRenda = 0;
          break;
        case FaixaIr.Dois:
          ValorImpostoDeRenda = valor * (7.5M / 100) - 142.80M;
          break;
        case FaixaIr.Tres:
          ValorImpostoDeRenda = valor * (15M / 100) - 354.80M;
          break;
        case FaixaIr.Quatro:
          ValorImpostoDeRenda = valor * (22.5M / 100) - 636.13M;
          break;
        case FaixaIr.Cinco:
          ValorImpostoDeRenda = valor * (27.5M / 100) - 869.36M;
          break;
      }
      return ValorImpostoDeRenda;
    }
    private FaixaIr RetornaFaixaSalarial(decimal salario)
    {
      if (salario <= 1903.98M) return FaixaIr.Um;
      else if (salario > 1903.98M && salario <= 2826.65M) return FaixaIr.Dois;
      else if (salario > 2826.65M && salario <= 3751.05M) return FaixaIr.Tres;
      else if (salario > 3751.05M && salario <= 4664.68M) return FaixaIr.Quatro;
      else return FaixaIr.Cinco;
    }
  }
}