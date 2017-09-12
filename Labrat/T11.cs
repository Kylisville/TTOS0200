using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labrat
{
    class harjoitus11
    {
        public static void Tehtava11()
        {
           // Tee kahden sisäkkäisen for-silmukan avulla ohjelma, joka tulostaa seuraavanlaisen kuvion:
             // *
             // **
             // ***
             // ****
           //   *****

            Console.WriteLine("Syötä tähtien lukumäärä: ");
            int input = int.Parse(Console.ReadLine());
            List<string> tahdet = new List<string>();
            for (int x = 0; x <= input; x++)
            {
                tahdet.Add("*");
                Console.WriteLine();
                for (int y = x; y > 0; y--)
                {
                    Console.Write("*");
           

                }

            }
        }
    }
}