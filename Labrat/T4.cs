using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labrat
{
    class harjoitus4
    {
        public static void Tehtava4()
        {
            Console.WriteLine("Anna ikäsi: ");
            int ika = int.Parse(Console.ReadLine());
            if (ika < 18)
            {

                Console.WriteLine("Alaikäinen");

            }
            else if (ika >= 18 && ika <= 65)
                {

                Console.WriteLine("Aikuinen");

            }
            else
            {

                Console.WriteLine("Seniori");

            }
        }

    }
}
