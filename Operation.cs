using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeCalculadora
{
   abstract class Operation 
    {
       protected double[] converter( string valor1, string valor2) // vai converter os dois valores para real
        {
            double[] convert = new double[2] 
            {
                double.Parse(valor1),
                double.Parse( valor2)
             };//crio o vetor do tipo double e ja passo os valores ja convertidos 
            return convert;
        }
       abstract public double calcular(string valor1, string valor2);
    }
}
