using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04.cs
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace Lab04.cs
    {
        public class Vehicle
        {
            public string Name { get; set; }
            public string Model { get; set; }
            public int Year { get; set; }
            public string Color { get; set; }


            public override string ToString()
            {
                return Name + " " + Profession + " " + Salary;
            }

        }

        public class Boss : Employee
        {
            public string Car { get; set; }
            public int Bonus { get; set; }

            public override string ToString()
            {
                return Name + " " + Profession + " " + Salary + " " + Car + " " + Bonus;
            }
        }
    }

}
