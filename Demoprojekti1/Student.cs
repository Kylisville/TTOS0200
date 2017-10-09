using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demoprojekti1
{
    public class Student
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string AsioID { get; set; }

        public Student()
        { }
        public Student(string fname, string lname)
        {
            FirstName = fname;
            LastName = lname;
        }   
        
            public override string ToString()
        {
            return FirstName + " "  + LastName + ", asio: " + AsioID;
        }
    }
    public class Group
    {

        public string Name { get; set; }
        public List<Student> Students;
        //Konstruktori
        public Group()
        {

            Students = new List<Student>();
            //luettaisiin esimerkiksi tietokannasta ne oppilaitten tiedot
            Students.Add(new Student("Pelle", "Peloton"));
            Students.Add(new Student("Aku", "Ankka"));
            Students.Add(new Student("Mikki", "Hiiri"));
        }

        public override string ToString()
        {

            string retval = "Luokka " + Name + "Sisältää oppilaat\n";
            foreach (Student item in Students)
            {
                retval += item.ToString() + "\n";


            }
            return retval;
        }

    }

}



