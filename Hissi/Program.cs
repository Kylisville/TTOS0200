using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            Hissi Dynamo = new Hissi();

            do
            {

                Console.WriteLine("Syötä kerros.");
                string sisaantulo = Console.ReadLine();
                int luku;
                bool valinta = int.TryParse(sisaantulo, out luku);
                if (valinta) { Dynamo.Kerros = luku; }

                else
                {
                    break;
                }
                Console.WriteLine("Menit kerrokseen {0} ", Dynamo.Kerros);
            } while (true);

        }
    }
}
