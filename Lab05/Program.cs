using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab05
{
    class Program 
    {
      
        static void Main(string[] args)
        {/*
            Vehicle auto = new Vehicle("BMW","M3");
            Vehicle car = new Vehicle("Volvo","240");
            Console.WriteLine("Car {0} specs: {1}", car.Brand, car.ToString());
            car.AddTyre(new Tyres("Michelin", "Primacy 3"));
            car.AddTyre(new Tyres("Michelin", "Primacy 3"));
            Tyres wheelie = new Tyres("Bridgestone", "Potenza RE010");
            Console.WriteLine("Car {0} Specs: {1}", auto.Brand, auto.ToString());
            auto.AddTyre(new Tyres("Bridgestone", "Potenza RE010"));
            auto.AddTyre(new Tyres("Bridgestone", "Potenza RE010"));
            */
            Fridge Rosenlew = new Fridge();
            Console.WriteLine(Rosenlew.ToString());
            Rosenlew.OpenDoor();
            Items one = new Items("Beer");
            Items two = new Items("Valio maitorahka");
            Rosenlew.AddItem(one);
            Rosenlew.AddItem(two);
            Console.WriteLine(Rosenlew.ToString());
        }
    }
}
