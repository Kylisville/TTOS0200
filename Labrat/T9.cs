using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labrat
{
    class harjoitus9
    {
        public static void Tehtava9()
        
        {
            //Tee ohjelma, joka kysyy käyttäjältä lukuja, kunnes hän syöttää luvun 0. Ohjelman tulee tulostaa syötettyjen lukujen summa.


            List<int> luvut = new List<int>();
            for (int x = 1; ; x++)
            {
                Console.Write("Anna luku: ");
                int luku = int.Parse(Console.ReadLine());
                if (luku == 0)
                {
                    break;
                }
                else
                {
                    luvut.Add(luku);
                }
            }
            Console.WriteLine("Lukujen summa on: " + luvut.Sum());

        }
    }
}