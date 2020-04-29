using System;
using System.Collections.Generic;

namespace mentoria.Impostos
{
    public class ImpostoDeRenda : IImposto
    {

        public decimal Calcula(decimal valor)
        {
            if (valor <= 1903.98M) return 0;
            else if (valor > 1903.98M && valor <= 2826.65M) return valor * 0.075M - 142.80M;
            else if (valor > 2826.65M && valor <= 3751.05M) return valor * 0.15M - 354.80M;
            else if (valor > 3751.05M && valor <= 4664.68M) return valor * 0.225M - 636.13M;
            return valor * 0.275M - 869.36M;
        }
    }
}