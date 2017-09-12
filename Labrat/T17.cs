using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labrat
{
    class harjoitus17
    {
        public static void Tehtava17()
        {



            //  Tee ohjelma, joka lajittelee kahdessa kokonaislukutaulukossa olevat alkiot suurusjärjestykseen kolmanteen kokonaislukutaulukkoon. 
            //Tulosta lopuksi lajitellun taulukon sisältö.



            int[] array1 = new int[] { 10, 20, 30, 40, 50 };
            int[] array2 = new int[] { 5, 15, 25, 35, 45 };
            //MERGE ARRAYS TO NEW ARRAY arraysCombined
            int[] arraysCombined = array1.Concat(array2).ToArray();
            //SORT NEW ARRAY
            Array.Sort(arraysCombined);
            //WRITE ARRAY 1
            Console.Write("Array 1: ");
            for (int x = 0; x < array1.Length; x++)
            {
                Console.Write(array1[x]);
                Console.Write(" ");
            }
            Console.WriteLine();
            //WRITE ARRAY 2
            Console.Write("Array 2: ");
            for (int x = 0; x < array2.Length; x++)
            {
                Console.Write(array2[x]);
                Console.Write(" ");

            }
            Console.WriteLine();
            //WRITE COMBINED SORTED ARRAY
            Console.Write("Lajiteltu: ");
            foreach (int value in arraysCombined)
            {
                Console.Write(value);
                Console.Write(" ");
            }
            Console.WriteLine();
        }

    }
}
