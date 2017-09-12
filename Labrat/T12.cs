using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labrat
{
    class harjoitus12
    {
        public static void Tehtava12()
        {
            int[] kokonaisluvut = new int[5];
            Console.WriteLine("Anna kokonaisluku: ");
            for (int i = 0; i < 5; i++)
            {


                kokonaisluvut[i] = int.Parse(Console.ReadLine());

            }
            Console.Write("Päinvastainen tulostus: ");
            for (int i = 4; i >= 0; i--)
            {
                Console.Write(kokonaisluvut[i] + ", ");

            }

        }
    }
}
