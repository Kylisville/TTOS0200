using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labrat
{
    class labra09
    {
        public static void Tehtava9()
        {
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