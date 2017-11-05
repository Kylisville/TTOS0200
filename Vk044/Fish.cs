using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vko44
{
    class Fish
    {
        public string Species { get; set; }
        public double Length { get; set; }
        public double Weight { get; set; }

        public string Location { get; set; }

        public Fish(string species, double length, double weight, string location)
        {
            Species = species;
            Length = length;
            Weight = weight;
            Location = location;

        }
    }
    class Fisher
    {
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public List<Fish> Catch { get; set; }
        public Fisher(string name, string phonenumber)
        {
            Name = name;
            PhoneNumber = phonenumber;
            Catch = new List<Fish>();
        }
    }
    
}
