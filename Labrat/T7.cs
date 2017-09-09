using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labrat
{
    class labra07
    {
        public static void Tehtava7()
        {
                Console.WriteLine("Syötä vuosi:");
                int year = int.Parse(Console.ReadLine());
                if (year % 400 == 0 || (year % 4 == 0 && year % 100 != 0))
                {
                    Console.WriteLine("Karkausvuosi");
                }
                else
                {
                    Console.WriteLine("Ei ole karkausvuosi");
                }
                Console.ReadLine();
            }
        }


    }
  