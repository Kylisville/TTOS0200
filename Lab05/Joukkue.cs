using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab05
{
    class Pelaaja
    {
        public string Etunimi { get; set; }
        public string Sukunimi { get; set; }
        public string Pelipaikka { get; set; }
        public string Katisyys { get; set; }

        public Pelaaja()
        {

        }
        public Pelaaja(string etunimi, string sukunimi, string pelipaikka, string katisyys)
        {
            Etunimi = etunimi;
            Sukunimi = sukunimi;
            Pelipaikka = pelipaikka;
            Katisyys = katisyys;

        }
        public override string ToString()
        {
            return "Nimi: " + Etunimi + Sukunimi + "Pelipaikka: " + Pelipaikka + "Kätisyys: " + Katisyys;
        }
    }
    class Seura
    {
        public string Nimi { get; set; }
        public string Kaupunki { get; set; }
        public List<Pelaaja> Pelaajat { get; set; }
        public Seura(string nimi, string kaupunki)
        {
            Nimi = nimi;
            Kaupunki = kaupunki;
            Pelaajat = new List<Pelaaja>();
        }
        public Seura()
        {

        }
        /*  public override string ToString()
          {
              return String.Format("Joukkue: {0} Kaupunki: {1}", Nimi, Kaupunki);
         }*/

        public override string ToString()
        {
            string retval = Nimi + " " + Kaupunki;
            foreach (Pelaaja item in Pelaajat)
            {
                retval += item.ToString() + "\n";

                
            }
            return retval;
        }

    }
}