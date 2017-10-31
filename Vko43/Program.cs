using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

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
            /*      Numbers numbers = new Numbers();
                  numbers.Inputs(); 
                  numbers.AddToTxt();
                  numbers.ReadTxt();*/
            try
            {
                List<Ohjelmat> ohjelmat = new List<Ohjelmat>();
                ohjelmat.Add(new Ohjelmat { Nimi = "Science of Stupid", Kanava = "National Geographic", Aika = "00:00 - 00:30", Info = "Typerät videot -sarjassa tieteen asiantuntijat kertovat, miksi jokin harmittomalta tuntuva temppu voi johtaa onnettomuuteen." });
                ohjelmat.Add(new Ohjelmat { Nimi = "Astral-TV", Kanava = "YLE TV2", Aika = "04:05 - ", Info = "Vastaanota neuvoja parhailta asiantuntijoilta! -verkossa ennustajat & ennustaminen" });
                Stream stream = new FileStream(@"C:\Users\ville\desktop\ohjelmat.txt",FileMode.Create,FileAccess.Write,FileShare.None);
                IFormatter formatter = new BinaryFormatter();
                formatter.Serialize(stream, ohjelmat);
                stream.Close();
                Stream openStream = new FileStream(@"C:\Users\ville\desktop\ohjelmat.txt", FileMode.Open, FileAccess.Read, FileShare.Read);
                List<Ohjelmat> lueohjelma = (List<Ohjelmat>)formatter.Deserialize(openStream);
                openStream.Close();
                foreach (Ohjelmat p in lueohjelma)
                {
                    Console.WriteLine("Ohjelma: {0}\n Kanava: {1}\n Aika {2}\n Info: {3}",p.Nimi,p.Kanava,p.Aika,p.Info);
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
