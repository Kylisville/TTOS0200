using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labrat
{
    class harjoitus1
    {
        public static void Tehtava1()
        {


            //Tee ohjelma, joka tulostaa käyttäjän antamaa lukua (1, 2 tai 3) 
            //vastaavan luvun sanana (yksi, kaksi tai kolme). Jos käyttäjä syöttää jonkin muun luvun, tulee näytölle tulostaa teksti: "joku muu luku".

            
            Console.WriteLine("Anna luku > ");
            int luku = Convert.ToInt32(Console.ReadLine());
            
                if (luku == 1)
            {
                Console.WriteLine("Annoit luvun yksi");

            }
            else if (luku == 2)
            {
                Console.WriteLine("Annoit luvun kaksi");
            }
            else if (luku == 3)
            {

                Console.WriteLine("Annout luvun kolme");

            }
        
            else

                Console.WriteLine("Annoit jonkun muun luvun");
      }

    }
}
