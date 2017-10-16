using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK_IT.MiniASIO
{
    class TestaaMiniASIO
    {
        /*
        static void Testaa()
        {
            //luodaan List-tyyppinen lista opiskelijoista
            List<Opiskelija> opiskelijat = new List<Opiskelija>();
            //testin vuoksi erilaisia tapoja lisätä olioita listaan
            Opiskelija masa = new Opiskelija("Masa", "Niemi");
            opiskelijat.Add(masa);
            opiskelijat.Add(new Opiskelija("Allan", "Aalto", "A1234"));
            //myös näin
            opiskelijat.Add(new Opiskelija { Etunimi = "Hanna", Sukunimi = "Husso", AsioID = "H5678" });
            opiskelijat.Add(new Opiskelija { Etunimi = "Teppo", Sukunimi = "Testaaja", AsioID = "T9876", Ryhmä = "TTV17S1" });
            Opiskelija kalle = new Opiskelija();
            kalle.Etunimi = "Kalle"; kalle.Sukunimi = "Ankka"; kalle.AsioID = "K6600";
            opiskelijat.Add(kalle);
            //yhden opiskelijan tietojen näyttäminen
            Console.WriteLine("Anna numero väliltä 1-5");
            int i = int.Parse(Console.ReadLine());
            if (i < opiskelijat.Count)
                Console.WriteLine("MiniASIOn {0} opiskelija on {1}", i, opiskelijat[i - 1].ToString());
            else
                Console.WriteLine("MiniASIOssa on vain {0} opiskelija", opiskelijat);
            //kaikkien opiskelijoiten tiedot
            Console.WriteLine("MiniASIOn kaikki opiskelijat:");
            foreach (var o in opiskelijat)
            {
                Console.WriteLine(o.ToString());
            }
            //kaikkien opiskelijoiden tiedot aakkosjärjestyksessä sukunimen mukaa
            //sortataan oliot Sukunimi-ominaisuuden mukaiseen järjestykseen
            opiskelijat.Sort((x,y) => x.Sukunimi.CompareTo(y.Sukunimi));
            Console.WriteLine("MiniASIOn kaikki opiskelijat:");
            foreach (var o in opiskelijat)
            {
                Console.WriteLine(o.ToString());
            }
            //uuden opiskelijan lisääminen, huom tehdään tarkistus ettei AsioID ole jo olemassa
            Console.WriteLine("Anna uuden opiskelijan AsioID: ");
            string asioid = Console.ReadLine();
            //tutkitaan onko listassa
            bool lippu = false;
            foreach  (Opiskelija o in opiskelijat)
            {
                if (asioid == o.AsioID)
                {
                    lippu = true;
                    break;
                }
                
            }
            if(lippu)
            {
                Console.WriteLine("AsioID {0} on jo käytössä", asioid);
            }
            else
            {
                Console.WriteLine("Anna uuden opiskelijan etunimi: ");
                string etunimi = Console.ReadLine();
                Console.WriteLine("Anna sukunimi: ");
                string sukunimi = Console.ReadLine();
                Console.WriteLine("Anna ryhmä: ");
                string ryhma = Console.ReadLine();
                //luodaan uusi Opiskelija olio
                Opiskelija uusi = new Opiskelija(etunimi, sukunimi, asioid, ryhma);
                opiskelijat.Add(uusi);
                Console.WriteLine("MiniASIOn kaikki {0} opiskelijat:", opiskelijat.Count);
            }
            {

            }
        }

     
            static void Main(string[] args)
        {
            Testaa();
        }
    }*/
        /*static void ListAlbum()
        {
            CD album = new CD("The Dark Side of the Moon", "Pink Floyd");
            album.AddTrack(new Track("Breathe", "2:43"));
            album.AddTrack(new Track("On the Run", "3:30"));
            album.AddTrack(new Track("Time", "6:53"));
            album.AddTrack(new Track("The Great Gig in the Sky", "4:15"));
            album.AddTrack(new Track("Money", "6:30"));
            album.AddTrack(new Track("Us and Them", "7:51"));
            album.AddTrack(new Track("Any Colour You Like", "3:24"));
            album.AddTrack(new Track("Brain Damage", "3:50"));
            album.AddTrack(new Track("Eclipse", "2:03"));

            Console.WriteLine(album.ToString());
        }
        static void Main(string[] args)
        {
            ListAlbum();
        }
        */
        static void Main(string[] args)
        {
            // Deck CardDeck = new Deck();
            // CardDeck.CreateDeck(13);
            //  CardDeck.ShowDeck();
        }

        private static Random rng = new Random();
       
    }
}

