using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Kertaustehtävä
{
   public class AMK
    {
        public string Tutkinnonnimi { get; set; }
        public List<Tutkinto> Tutkinnot = new List<Tutkinto>();
        private string value = "";
        static void Main(string[] args)
        {
            AMK amk = new AMK();
            Tutkinto ttv = new Tutkinto("TTV");
            amk.LisaaTutkinto(ttv);
            Tutkinto raksa = new Tutkinto("RAKSA");
            amk.LisaaTutkinto(raksa);
            Tutkinto trade = new Tutkinto("tradenomi");
            amk.LisaaTutkinto(trade);
            Console.WriteLine(amk.HaeTutkinnot());
            Opintojakso math = new Opintojakso("matematiikka 2");
            Opintojakso olio = new Opintojakso("Olio-ohjelmointi");
            Opintojakso yrit = new Opintojakso("Yrittäjyys");
            ttv.LisaaOpintojakso(math);
            ttv.LisaaOpintojakso(olio);
            ttv.LisaaOpintojakso(yrit);
            Opintojakso viini = new Opintojakso("viininmaistelu");
            Opintojakso excel = new Opintojakso("Excel");
            Opintojakso word = new Opintojakso("Word");
            trade.LisaaOpintojakso(viini);
            trade.LisaaOpintojakso(excel);
            trade.LisaaOpintojakso(word);
            Opintojakso talo = new Opintojakso("talonrakennus");
            Opintojakso matikka = new Opintojakso("matematiikka 1");
            Opintojakso rakennus = new Opintojakso("rakennustekniikka");
            raksa.LisaaOpintojakso(talo);
            raksa.LisaaOpintojakso(matikka);
            raksa.LisaaOpintojakso(rakennus);
            Console.WriteLine(ttv.ToString());
            Console.WriteLine(ttv.HaeOpintojakso());
            Console.WriteLine(trade.ToString());
            Console.WriteLine(trade.HaeOpintojakso());
            Console.WriteLine(raksa.ToString());
            Console.WriteLine(raksa.HaeOpintojakso());
            Opiskelija ville = new Opiskelija("Ville");
            Opiskelija arnold = new Opiskelija("Arnold");
            Opiskelija pepe = new Opiskelija("Pepe");
            Opettaja jesse = new Opettaja("Jesse");
            Opettaja juuso = new Opettaja("Juuso");
            Opiskelija elmeri = new Opiskelija("Elmeri");
            viini.LisaaOpiskelija(ville);
            viini.LisaaOpiskelija(pepe);
            viini.LisaaOpiskelija(arnold);
            viini.LisaaOpiskelija(elmeri);
            viini.LisaaOpettaja(jesse);
            viini.LisaaOpettaja(juuso);
            Console.WriteLine(viini.ToString());
            Console.WriteLine(viini.HaeOpiskelijat() + "Opiskelijoita on: " + viini.LaskeOpiskelijat());
            Console.WriteLine("Opettajia on: " + viini.LaskeOpettajat());
            Console.WriteLine(viini.HaeOpettajat());
        }
        public void LisaaTutkinto(Tutkinto item)
        {
            Tutkinnot.Add(item);
        }
        public string HaeTutkinnot()
        {
            foreach(Tutkinto item in Tutkinnot)
            {
                value += "-" + item.ToString() + "\n";
            }
            return value;
        }
        }
     }
    public class Opiskelija
    {
    public static int opiskelija = 0;
        public string Name { get; set; }
        public Opiskelija(string name)
        {
            Name = name;
        }
    public Opiskelija()
    {
        opiskelija++;
    }

    public override string ToString()
    {
        return Name;
    }
}
    public class Opettaja
    {
        public string Name { get; set; }
        public Opettaja(string name)
        {
            Name = name;
        }
    public override string ToString()
    {
        return Name;
    }
}
    public class Tutkinto
    {
        List<Opintojakso> Opintojaksot = new List<Opintojakso>();
        public string Tutkinnonnimi { get; set; }
        public string value = "";
        public string HaeOpintojakso()
    {
        foreach (Opintojakso o in Opintojaksot)
        {
            value += "-" + o.ToString() + "\n";
        }
        return value;
    }
        public void LisaaOpintojakso(Opintojakso o)
    {
        Opintojaksot.Add(o);
    }
    public override string ToString()
    {
        return Tutkinnonnimi;
    }
    public Tutkinto(string tutkinnonnimi)
        {
            Tutkinnonnimi = tutkinnonnimi;
        }
    }
    public class Opintojakso
    {
        public string Name { get; set; }
        public List<Opettaja> Opettajat = new List<Opettaja>();
        public List<Opiskelija> Opiskelijat = new List<Opiskelija>();
        string value;
        string outvalue;
       public Opintojakso(string name)
        {
            Name = name;
          
        }
          public void LisaaOpiskelija(Opiskelija opiskelija)
            {
        Opiskelijat.Add(opiskelija);

          } 
            public void LisaaOpettaja(Opettaja opettaja)
    {
         Opettajat.Add(opettaja);
    }
        public string HaeOpettajat()
    {
        foreach(Opettaja r in Opettajat)
        {
            outvalue += "-" + r + "\n";
        }
        return outvalue;
    }
    public string HaeOpiskelijat()
    {
        foreach(Opiskelija o in Opiskelijat)
        {
            value += "-" + o + "\n";
        }
        return value;
    }
    public int LaskeOpiskelijat()
    {
        return Opiskelijat.Count();
    }
    public int LaskeOpettajat()
    {
        return Opettajat.Count();
    }
    public override string ToString()
    {
        return Name;
    }
}


