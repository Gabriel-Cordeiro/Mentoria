// using System;
// using static mentoria.FaixaSalarialEnum;

// namespace mentoria
// {
//   public class Inss : Imposto
//   {
//     public Inss(decimal valor)
//     {
//       FaixaSalarial = RetornaFaixaSalarial(valor);
//       Calcular(valor);
//     }
//     private decimal ValorInss { get; set; }
//     private FaixaInss FaixaSalarial { get; set; }
//     public override decimal Calcular(decimal valor)
//     {
//       switch (FaixaSalarial)
//       {
//         case FaixaInss.Um:
//           ValorInss = valor * 0.08M;
//           break;
//         case FaixaInss.Dois:
//           ValorInss = valor * 0.09M;
//           break;
//         case FaixaInss.Tres:
//           ValorInss = valor * 0.11M;
//           break;
//       }
//       return ValorInss;
//     }

//     private FaixaInss RetornaFaixaSalarial(decimal salario)
//     {
//       if (salario <= 1693.72M) return FaixaInss.Um;
//       else if (salario > 1693.72M && salario <= 2822.90M) return FaixaInss.Dois;
//       else return FaixaInss.Tres;
//     }
//   }
// }