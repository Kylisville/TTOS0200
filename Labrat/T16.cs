using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labrat
{
    class harjoitus16
    {
        public static void Tehtava16()
        {
            //Tee ohjelma, joka arpoo satunnaisluvun väliltä 0-100. Käytä C#:n Random -luokkaa. 
           // Tämän jälkeen ohjelman käyttäjää kehoitetaan arvaaman arvottu luku.
            // Ohjelman tulee antaa vihje arvauksen jälkeen onko arvottu luku pienemäi vai suurempi. Tämän jälkeen vihjeitä toistetaan kunnes käyttäjä arvaa oikean luvun. 
            // Tulosta lopuksi arvausten määrä näytölle. 
          //  PS Satunnaislukujen arpomisesta tietokoneella löytyy mielenkiintoista luettavaa esimerkiksi tästä artikkelista: Computers are lousy random number generators.

            Random rnd = new Random();

            int number = rnd.Next(100);
            int input = new int();
            for (int x = 1; ; x++)
            {

                Console.Write("Arvaa numero väliltä 0-100: ");
                input = int.Parse(Console.ReadLine());
                if (input > number)
                {

                    Console.WriteLine("Arvaus oli suurempi.");

                }
                else if (input < number)
                {

                    Console.WriteLine("Arvaus oli pienempi.");

                }
                else if (input == number)

                {
                    {
                        Console.Clear();
                        Console.WriteLine("Hienoa, arvattu numero oli " + number);
                        Console.WriteLine("Sait oikean vastauksen " + x + " yrittämällä");
                        break;

                    }
                }
            }
        }
    }
}