using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vko43
{
    class Program
    {
        static void Main(string[] args)
        {
            //KÄYTTÄKÄÄ TRY-CATCHIA
            /* try
             {
                 string nimi;
                 string filupath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                 string filu = filupath + @"\testi.txt";
                 //kirjoitetaan käyttäjän antamat rivit tiedostoon.
                 //luodaan StreamWriter-tyyppinen olio johon kirjoitetaan
                 StreamWriter sw = new StreamWriter(filu);
                 do
                 {
                     Console.Write("Anna nimi (Enter lopettaa): ");
                     nimi = Console.ReadLine();
                     if (nimi.Length > 0)

                         sw.WriteLine(nimi);

                 } while (nimi.Length != 0);
                 sw.Close();
                 //avataan tiedosto uudestaan ja luetaan sen sisältö ja näytetään käyttäjälle konsolissa
                 if (File.Exists(filu))
                 {
                     string teksti = File.ReadAllText(filu);
                     Console.WriteLine(teksti);
                 }
             }

             catch (Exception ex)
             {

                 Console.WriteLine(ex.Message);
             }*/

            /*   People nimet = new People();
               nimet.LaskeRivit();
               nimet.LaskeNimet(); */
                 Numbers numbers = new Numbers();
                 numbers.Inputs(); 
                 numbers.AddToTxt();
                 numbers.ReadTxt();
 

        }
    }
}
