﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeCalculadora
{
    class Subtracao : Operation
    {
        public override double calcular(string valor1, string valor2)
        {
            double[] result = this.converter(valor1, valor2);
            return result[0] - result[1];
        }
    }
}
