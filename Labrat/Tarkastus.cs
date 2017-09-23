using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Labrat
{
    public class Tarkastus
    {

        public static bool OnkoPvm(string syote)
        {
            
            DateTime temp;
            var dateFormats = new[] { "dd.MM.yyyy", "dd.MM.yy", "d.M.yy", "d.M.yyyy", "dd.M.yy", "d.MM.yy", "d.MM.yyyy" };
            if (DateTime.TryParseExact(syote, dateFormats, DateTimeFormatInfo.InvariantInfo, DateTimeStyles.None, out temp))
            {

                Console.WriteLine(temp);
                return true;

            }

            else
            {
                Console.WriteLine("Ei ollut päivämäärä");
                return false;
            }

        }
        public static bool OnkoLuku(string syote)
        {
            double luku;
            if (double.TryParse(syote, out luku))
            {

                Console.WriteLine("Syöte oli luku: {0}", luku);
                return true;

            }
            else
            {

                Console.WriteLine("ei ollu luku vittu");
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
            Tarkastus.OnkoPvm(syote);
         
        }
       

    }


}