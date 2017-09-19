using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opiskelija
{
    class Student
    {
        public string Nimi { get; set; }
        public int Ika { get; set; }
        public string Koulu { get; set; }
        public bool Kanni { get; set; }

        public Student(string nimi, int ika, string koulu, bool kanni)
        {
            Nimi = nimi;
            Ika = ika;
            Koulu = koulu;
            Kanni = kanni;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            LuoOpiskelijat();
        }
        static void LuoOpiskelijat()
        {
            List<Student> Opiskelijalista = new List<Student>();
            Opiskelijalista.Add(new Student("kissa", 21, "Saimia", true));
            Opiskelijalista.Add(new Student("Ville", 22, "JAMK", true));
            Opiskelijalista.Add(new Student("Jorma", 16, "JYU", true));
            Opiskelijalista.Add(new Student("Vilma", 251, "Aalto", true));
            Opiskelijalista.Add(new Student("Erno", 18, "HAMK", false));

            for (int x = 0; x < Opiskelijalista.Count; x++)
            {
                Console.WriteLine("Opiskelija " + (x + 1));
                Console.WriteLine("Nimi: {0}, Ikä: {1}, Koulu: {2}, Känni: {3}.", Opiskelijalista[x].Nimi, Opiskelijalista[x].Ika, Opiskelijalista[x].Koulu, Opiskelijalista[x].Kanni);
            }
        }
    }
}
