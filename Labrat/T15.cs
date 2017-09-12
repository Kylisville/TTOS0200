using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labrat
{
    class harjoitus15
    {
        public static void Tehtava15()
        {
            //Tee ohjelma, joka tulostaa seuraavanlaisen kuvion. Kysy käyttäjältä puunkorkeus käytä juurena kaksi korkeuden yksikkö.


            Console.Write("Christmas tree builder. Enter height of the tree (metres): ");
            int input = int.Parse(Console.ReadLine());

            var star = "*";
            var space = " ";
            for (int x = 0; x < input; x++)
            {

                for (int z = input - x - 1; z > 0; z--)
                {
                    Console.Write(space);
                }
                for (int y = 0; y < 2 * x + 1; y++)
                {
                    Console.Write(star);
                }
                Console.WriteLine();
            }
            for (int x = 0; x < 2; x++)
            {
           
                for (int y = input - 1; y > 0; y--)
                {
                    Console.Write(space);
                }
                Console.Write(star);
                Console.WriteLine();
            }
        }
    }

   }

