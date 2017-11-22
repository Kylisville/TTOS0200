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
        public List<Tutkinto> Tutkinnot { get; set; }
       static void Main(string[] args)
        {
            HaeTutkinnot();
            
        }
        public static void HaeTutkinnot()
        {
            List<Tutkinto> Tutkinnot = new List<Tutkinto>();
            Tutkinnot.Add(new Tutkinto("TTV","Olio-ohjelmointi"));
            Tutkinnot.Add(new Tutkinto("Energiatekniikka","asd"));
            Tutkinnot.Add(new Tutkinto("RAKSA","asd"));

            foreach (var tutkinto in Tutkinnot)
            {
                Console.WriteLine();
            }
        }
  
    }

    public class Opiskelija
    {
        public string Name { get; set; }
        public Opiskelija(string name)
        {
            Name = name;
        }
    }
    public class Opettaja
    {
        public string Name { get; set; }
        public Opettaja(string name)
        {
            Name = name;
        }
    }
    public class Tutkinto
    {
        public string Opintojakso { get; set; }
        List<Opintojakso> Opintojaksot { get; set; }
        public string Tutkinnonnimi { get; set; }
        
        public Tutkinto(string tutkinnonnimi,string opintojakso)
        {
            Opintojakso = opintojakso;
            Tutkinnonnimi = tutkinnonnimi;
            Opintojaksot = new List<Opintojakso>();
        }

      
    }
    public class Opintojakso
    {
        public string Name { get; set; }
        public List<Opettaja> Opettajat { get; set; }
        public List<Opiskelija> Opiskelijat { get; set; }
       public Opintojakso(string name)
        {
            Name = name;
            Opettajat = new List<Opettaja>();
            Opiskelijat = new List<Opiskelija>();
        }
        public void HaeIhmiset()
        {
            Console.WriteLine(Opettajat);
            foreach (var opintojakso in Opiskelijat)
            {
                Console.WriteLine(opintojakso.Name);
            }
        }
    }
}
