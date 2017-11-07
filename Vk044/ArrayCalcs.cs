using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vko44
{
   public class ArrayCalcs
    {
        public static double Sum(double[] lista)
        {
            double summa = 0;
            foreach(double i in lista)
            {
                summa += i;
            }
            return summa;
        }
        public static double Average(double[] lista)
        {
            return Sum(lista) / lista.Length;
        }

        public static double Min(double[] lista)
        {
            return lista.Min();

        }
        public static double Max(double[] lista)
        {
            return lista.Max();
        }
    }
}
