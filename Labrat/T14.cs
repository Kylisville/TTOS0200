using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labrat
{
    class harjoitus14
    {
        public static void Tehtava14()
        {
            //Kirjoita ohjelma, joka pyytää käyttäjältä opiskelijoiden arvosanat 0-5 ohjelmointi-opintojaksosta (voit itse päättää lopetusehdon). 
            //Tulosta arvosanajakauma käyttäen tähtimerkkejä seuraavasti:
            //Arvosanajakauma: 
               // 0:
             //   1:****
              //  2:**
             //   3:******
            //    4:*****
              //  5:**
   

            List<int> pisteet = new List<int>();
            int input = new int();
            Console.WriteLine("Anna arvosana. Voit lopettaa syöttämällä suuremman luvun kuin 5.");

            //syöttö
            for (int x = 0; ; x++)
            {
                input = int.Parse(Console.ReadLine());
                if (input == 0)
                {
                    pisteet.Add(input);
                }
                else if (input == 1)
                {
                    pisteet.Add(input);
                }
                else if (input == 2)
                {
                    pisteet.Add(input);
                }
                else if (input == 3)
                {
                    pisteet.Add(input);
                }
                else if (input == 4)
                {
                    pisteet.Add(input);
                }
                else if (input == 5)
                {
                    pisteet.Add(input);
                }
                else if (input > 5)
                {
                    break;
                }
            }

            //laskee arvosanojen määrän
            int nolla = pisteet.Count(x => x == 0);
            int yksi = pisteet.Count(x => x == 1);
            int kaksi = pisteet.Count(x => x == 2);
            int kolme = pisteet.Count(x => x == 3);
            int nelja = pisteet.Count(x => x == 4);
            int viisi = pisteet.Count(x => x == 5);

            //tulostaa arvosanojen määrän
            Console.WriteLine("0: " + String.Concat(Enumerable.Repeat("*", nolla)));
            Console.WriteLine("1: " + String.Concat(Enumerable.Repeat("*", yksi)));
            Console.WriteLine("2: " + String.Concat(Enumerable.Repeat("*", kaksi)));
            Console.WriteLine("3: " + String.Concat(Enumerable.Repeat("*", kolme)));
            Console.WriteLine("4: " + String.Concat(Enumerable.Repeat("*", nelja)));
            Console.WriteLine("5: " + String.Concat(Enumerable.Repeat("*", viisi)));
        }
    }
    }

