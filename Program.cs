using System;

namespace mentoria
{
  class Program
  {
    static void Main(string[] args)
    {

      Console.WriteLine("Digite seu salário abaixo para cálculo");
      var valorDigitado = Convert.ToDecimal(Console.ReadLine());

      var meuSalario = new Salario(valorDigitado);
      Console.WriteLine($"O seu salário líquido é ${meuSalario.SalarioLiquido.ToString()}");

      // Quebrar código em classes com  Responsabilidade unica
      // Se entrar um imposto novo (ex icms) e (xpto)
      // OCP respeitar

      // var salario = 2000M;
      // var cestaBeneficio = 100M;

      // var inss = salario * 0.08M;

      // if(salario >= 1690 && salario < 2800)
      //     inss = salario * 0.09M;
      // else if (salario >= 2801 )
      //     inss = salario * 0.11M;


      // var salarioAposInss = salario - inss;

      // var irf = 0M;

      // if( salarioAposInss >= 1900 && salarioAposInss < 2800)
      //     irf = salarioAposInss * 0.075M - 142M;
      // else if(salarioAposInss >= 2801 && salarioAposInss < 3700)
      //     irf = salarioAposInss * 0.15M - 354M;
      // else if (salarioAposInss >= 3701 && salarioAposInss < 4600)
      //     irf = salarioAposInss * 0.225M - 636M;
      // else if( salarioAposInss > 4600)
      //     irf = salarioAposInss * 0.27M - 869;


      // var salarioFinal = salario - inss - irf - cestaBeneficio;

      //Console.WriteLine($"O meu salário final é {salarioFinal}");
    }
  }
}
