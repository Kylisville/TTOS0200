using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labrat
{
    class harjoitus6
    {
        public static void Tehtava6()
        {
            //Auton kulutus on 7.02 litraa 100 kilometrin matkalla ja bensan hinta on 1.595 Euroa.
            //Tee ohjelma, joka tulostaa ajetulla matkalla (kysytään käyttäjältä) kuluvan bensan määrän sekä bensaan menevän rahan määrän.

            Console.Write("Syötä kilometrit: ");
            int kilometrit = int.Parse(Console.ReadLine());
            double kulutus = kilometrit * 7.02 / 100;
            double hinta = kulutus * 1.595;
            Console.WriteLine("Bensaa kuluu {0:0.##} litraa. Kustannus {1:0.##} euroa.", kulutus, hinta);
        }

    }
}
