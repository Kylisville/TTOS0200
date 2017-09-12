using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labrat
{
    class harjoitus13
    {
        public static void Tehtava13()
        {
            int givenScore = new int();
            List<int> allScores = new List<int>(new int[5]);
            for (int x = 0; x < 5; x++)
            {
                Console.Write("Judge " + (x + 1) + "/5 enter your score: ");
                givenScore = int.Parse(Console.ReadLine());
                allScores[x] = givenScore;

            }
            //poistaa minimi- ja maksimiarvot
            allScores.Remove(allScores.Max());
            allScores.Remove(allScores.Min());

            Console.WriteLine("Skijumper gets: " + allScores.Sum() + " points!");
        }
    }
}
