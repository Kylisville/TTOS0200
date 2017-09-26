using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vahvistin
{
    class Program
    {
        static void Main(string[] args)
        {
            Vahvistin Kajari = new Vahvistin();

            do
            {


                Console.WriteLine("Anna äänenvoimakkuus.");
                string sisaantulo = Console.ReadLine();
                int luku;
                bool valinta = int.TryParse(sisaantulo, out luku);
                if (valinta) { Kajari.Aani = luku; }

                else
                {
                    break;
                }
                Console.WriteLine("Äänenvoimakkuus: {0} ", Kajari.Aani);
            } while (true);
        }
    }
}
