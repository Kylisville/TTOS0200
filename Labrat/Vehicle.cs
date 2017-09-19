using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labrat
{
    class Vehicle


    {

        public string name;
        public int speed;
        public int tyres;

        public void PrintData()
        {
            Console.WriteLine(name);
            Console.WriteLine(speed);
            Console.WriteLine(tyres);

        }
        public string PrintString()
        {

            return (String.Format("{0} {1} {2}",name, speed, tyres));

        }
    }
        class Autoprogram

        {
            public static void autoohjelma()

            {
                Vehicle car = new Vehicle();
                Console.WriteLine("Anna autolle nimi: ");
                car.name = Console.ReadLine();
                Console.WriteLine("Syötä auton nopeus: ");
                car.speed = int.Parse(Console.ReadLine());
                Console.WriteLine("Syötä renkaiden määrä: ");
                car.tyres = int.Parse(Console.ReadLine());
                car.PrintData();
                Console.WriteLine(car.PrintString());
            }




        }


    }



