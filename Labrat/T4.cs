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
            //Tee ohjelma, jossa kysytään käyttäjältä tämän ikä. Jos ikä on alle 18 vuotta, tulosta "alaikäinen", jos se on 18-65 vuotta, tulosta "aikuinen", muussa tapauksessa tulosta "seniori".
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
