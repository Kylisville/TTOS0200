using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labrat
{
    class harjoitus2
    {
        public static void Tehtava2()
        
            {
                int[] arvosanat = { 0, 0, 1, 1, 2, 2, 3, 3, 4, 4, 5, 5, 5 };

                Console.WriteLine("Anna pistemäärä: ");
                int pisteet = int.Parse(Console.ReadLine());
                Console.WriteLine("Koulunumero on: " + arvosanat[pisteet]);
            }


        
    }
}
