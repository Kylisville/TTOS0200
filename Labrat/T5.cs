using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labrat
{
    class harjoitus5
    {
        public static void Tehtava5()
        {
            Console.Write("Syötä sekunnit: ");
            int alkusekunnit = int.Parse(Console.ReadLine());
            int tunnit = alkusekunnit / 3600;
            int minuutit = (alkusekunnit % 3600) / 60;
            int sekunnit = (alkusekunnit % 3600) % 60;
            Console.WriteLine(String.Format("Tunnit: {0}. Minuutit: {1}. Sekunnit: {2}", tunnit, minuutit, sekunnit ));
        }

    }
}
