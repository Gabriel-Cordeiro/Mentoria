using System;

namespace mentoria.NewImplementation
{
    public class Irf : IDesconto
    {
        public decimal Calcula(decimal valor)
        {
            if (valor <= 1903.98M) return 0;
            else if (valor > 1903.98M && valor <= 2826.65M) return valor * 0.075M + 142.80M;
            else if (valor > 2826.65M && valor <= 3751.05M) return valor * 0.15M + 335.03M;
            else if (valor > 3751.05M && valor <= 4664.68M) return valor * 0.225M + 602.96M;
            return valor * 0.275M + 826.15M;
        }
        
    }
}