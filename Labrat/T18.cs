using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labrat
{
    class harjoitus18
    {
        public static void Tehtava18()
        {

          //Tee ohjelma, joka kysyy käyttäjältä merkkijonon(lause).
            //Sovelluksen tulee ilmoittaa käyttäjälle oliko annettu merkkijono palidromi.


          Console.WriteLine("Syötä merkkijono: ");
            string jono = Console.ReadLine();
            
            string palidromi = new string(jono.Reverse().ToArray()); 
            if (jono == palidromi)
            {
                Console.WriteLine("Oli palidromi");
            }
            else
            {
                Console.WriteLine("ei ollu palidromi");
              
            }
            
        }
    }
}