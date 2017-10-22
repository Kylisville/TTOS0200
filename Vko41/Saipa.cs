using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK_IT.MiniASIO
{
    class Pelaaja
    {
        public string Etunimi { get; set; }
        public string Sukunimi { get; set; }
        public string Kätisyys { get; set; }
        public int Numero { get; set; }

        public Pelaaja()
        {

        }
        public Pelaaja(string etunimi, string sukunimi, string katisyys, int numero)
        {
            Etunimi = etunimi;
            Sukunimi = sukunimi;
            Kätisyys = katisyys;
            Numero = numero;
        }
        public override string ToString()
        {
            return Etunimi + " " + Sukunimi + " " + Kätisyys + " " + Numero;
        }
       
            


    }
    class Joukkue
    {
        public string Nimi { get; set; }
        public string Kotikaupunki { get; set; }
        public List<Pelaaja> pelaajat;
        public Joukkue(string nimi, string kotikaupunki)
        {
            Nimi = nimi;
            Kotikaupunki = kotikaupunki;
            pelaajat = new List<Pelaaja>();
        }
        public override string ToString()
        {
            return Nimi + " " + Kotikaupunki;
        }
  

    } 
}
