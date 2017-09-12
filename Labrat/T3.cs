using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labrat
{
    class harjoitus3
    {
        public static void Tehtava3()
        //Tee ohjelma, joka kysyy käyttäjältä kolme lukua ja tulostaa niiden summan ja keskiarvon.
        {
            Console.WriteLine("Syötä kolme lukua yksi kerrallaan: ");
            int luku1 = int.Parse(Console.ReadLine());
            int luku2 = int.Parse(Console.ReadLine());
            int luku3 = int.Parse(Console.ReadLine());

            int summa = luku1 + luku2 + luku3;
            int keskiarvo = summa / 3;
            Console.WriteLine(String.Format("Summa: {0}. Keskiarvo: {1}", summa, keskiarvo));

        }

    }
}
