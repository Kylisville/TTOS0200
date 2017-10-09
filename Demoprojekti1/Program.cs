using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demoprojekti1
{

    class Thing
    {
        //julkinen jäsenmuuttuja != ominaisuus
        //public string Name;
        //parempi vaihtoehto, ominaisuus AutoImplemented Propertyn avulla
       // public string Name { get; set; }
        //ToString -metodi käyttää jäsenmuuttujaa tai propertyä
        private string name;
        public string Name
        {

            get { return name; }
            set { name = value; }


        }

        public override string ToString()
        {
            return "nimeni on: " + Name;
            //mutta mieluummin jos on sisäinen muuttuja niin käytetään sitä
            return "nimeni on: " + name;
        }

        //CONSTRUCTORIT
        public Thing()
        {
            name="nobody here";


        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            /*
                        Thing t = new Thing();
                        Console.WriteLine(t.ToString());
                        t.Name = "jotakin";
                        Console.WriteLine(t.Name);
                        Console.WriteLine(t.ToString());
                        */
            Student s = new Student();
            s.FirstName = "Esa";
            s.LastName = "Salmikangas";
            Student s2 = new Student("Jaska", "Jokunen");
            //luodaan kokoelma Student-olioita, käytetään List
            List<Student> students = new List<Student>();
            students.Add(s);
            students.Add(s2);
            students.Add(new Student("Arska", "Aaltonen"));
            //näytetään oppilaat
            Console.WriteLine("Luokan oppilaat: ");
            foreach (var item in students)
            {
                Console.WriteLine(item.ToString());
            }

            //testataan Group-luokka
            Group luokka = new Group();
            luokka.Name = "TTV16S1";
            luokka.Students.Add(new Student("Anna", "Aurinko"));
            Console.WriteLine(luokka.ToString());
       
    }
        }
    }



