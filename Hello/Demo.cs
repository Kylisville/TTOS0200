using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Esa's demo softa tehty 11.1.2017
//nimiavaruus muutettu

namespace Labrat
{
    public class Demo
    {
        public static void TestArray()
        {
            string[] nimet = new string[5];
            //kysytään nimet
            for (int i = 0; i < nimet.Length; i++)
            {
                Console.WriteLine("Anna käyttäjän nimi");
                nimet[i] = Console.ReadLine();
            }
            //näytetään nimet
            Console.WriteLine("Käyttäjät annetussa järjestyksessä:");
            for (int i = 0; i < nimet.Length; i++)
            {
                Console.WriteLine(nimet[i]);
            }
            //sorttaus
            Console.WriteLine("Käyttäjät aakkosjärjestyksessä:");
            Array.Sort(nimet);
            for (int i = 0; i < nimet.Length; i++)
            {
                Console.WriteLine(nimet[i]);
            }
        }
    }
}
