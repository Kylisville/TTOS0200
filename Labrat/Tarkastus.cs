using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labrat
{
    public class Tarkastus
    {

        public static bool OnkoPvm(string syote)
        {
            DateTime temp;
           if (DateTime.TryParse(syote, out temp))
            {

                return true;

            }

            else
            {

                return false;
            }

        }
        public static bool OnkoLuku(string syote)
        {
            double luku;
            if (double.TryParse(syote, out luku))
            {

                Console.WriteLine("oli");
                return true;

            }
            else
            {

                Console.WriteLine("ei ollu");
                return false;

            }
        
        }


    }

    public class TestiPeti
    {
        
        public static void Kysy()
        {

            Console.WriteLine("Anna luku: ");
            string syote = Console.ReadLine();
            Tarkastus.OnkoLuku(syote);
           // Tarkastus.OnkoPvm(syote);
        }
        public static void Testaa()
        {
        

        }


    }


}