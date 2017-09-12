using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labrat
{
    class harjoitus13
    {
        public static void Tehtava13()
        {
            //Mäkihypyssä käytetään viittä arvostelutuomaria.
            //Kirjoita ohjelma, joka kysyy arvostelupisteet yhdelle hypylle ja tulostaa tyylipisteiden summan siten, että summasta on vähennetty pois pienin ja suurin tyylipiste.

            int givenScore = new int();
            List<int> kokonaispisteet = new List<int>(new int[5]);
            for (int x = 0; x < 5; x++)
            {
                Console.Write("tuomari " + (x + 1) + "/5 anna pisteet: ");
                givenScore = int.Parse(Console.ReadLine());
                kokonaispisteet[x] = givenScore;

            }
            //poistaa minimi- ja maksimiarvot
            kokonaispisteet.Remove(kokonaispisteet.Max());
            kokonaispisteet.Remove(kokonaispisteet.Min());

            Console.WriteLine("hyppääjä: " + kokonaispisteet.Sum() + " pistettä!");
        }
    }
}
