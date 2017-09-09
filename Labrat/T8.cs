using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labrat
{
    class labra08
    {
        public static void Tehtava8()
        {

            int luku1, luku2, luku3;
            Console.Write("Anna luku:");
            luku1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Anna luku:");
            luku2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Anna luku:");
            luku3 = Convert.ToInt32(Console.ReadLine());
            if (luku1 > luku2)
                if (luku1 > luku3)
                {
                    Console.WriteLine("Suurin luku: " + luku1);
                }
                else
                {
                    Console.WriteLine("Suurin luku: " + luku3);
                }
            else
                   if (luku2 > luku3)
            {
                Console.WriteLine("Suurin luku: " + luku2);
            }
            else
            {
                Console.WriteLine("Suurin luku: "+ luku3);
            }

        }

    }
}
