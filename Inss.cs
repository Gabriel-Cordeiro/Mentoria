using System;
using static mentoria.FaixaSalarialEnum;

namespace mentoria
{
  public class Inss : IImposto
  {
    public decimal Calcula(decimal valor)
    {
      if (valor <= 1693.72M)
        return valor * 0.08M;
      else if (valor > 1693.72M && valor <= 2822.90M)
        return valor * 0.09M;
      else return valor * 0.11M;
    }
  }
}