using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labrat
{
    class harjoitus10
    {
        public static void Tehtava10()
        {
 
            List<int> lista = new List<int>(new int[] { 1, 2, 33, 44, 55, 68, 77, 96, 100 });

            for (int i = 0; i < lista.Count; i++)
            {
                if  (lista[i] % 2 == 0)
     
                {
                    Console.WriteLine(lista[i] +" HEP");
                }
                else
                {
                    Console.WriteLine(lista[i]);
                }

            }
        }
    }
}