using mentoria.Impostos;
using System;

namespace mentoria
{
  class Program
  {
    static void Main(string[] args)
    {

      Console.WriteLine("Digite seu salário abaixo para cálculo");
      var valorDigitado = Convert.ToDecimal(Console.ReadLine());

      var meuSalario = new Salario(valorDigitado)
                          .Desconta(new Inss())
                          .Desconta(new ImpostoDeRenda())
                          .SalarioAtual;
                          //Strategy 

      Console.WriteLine($"O seu salário líquido é ${meuSalario.ToString()}");
    }
  }
}
