using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Employee yksi = new Employee();
            yksi.Name = "Kirsi Kernel";
            yksi.Profession = "Teacher";
            yksi.Salary = 1200;
            Console.WriteLine("Employee:");
            Console.WriteLine(yksi.ToString(),"\n");
            Boss kaksi = new Boss();
            kaksi.Name = "Jussi Jurkka";
            kaksi.Profession = "Head of Institute";
            kaksi.Salary = 9000;
            kaksi.Car = "Audi";
            kaksi.Bonus = 5000;
            Console.WriteLine("Boss:");
            Console.WriteLine(kaksi.ToString(), "\n");
            yksi.Name = "Kirsi Kissa";
            yksi.Profession = "Principal teacher";
            yksi.Salary = 9001;
            Console.WriteLine("Employee: ");
            Console.WriteLine(yksi.ToString(), "\n");*/
            Bike eka = new Bike();
            eka.Name = "Jopo";
            eka.Model = "Street";
            eka.ModelYear = 2015;
            eka.Color = "Pink";
            eka.GearType = "False";
            eka.Gear = "Kissa";
            Console.WriteLine("Bike info");
            Console.WriteLine(eka.ToString());
            eka.Name = "tunturi";
            eka.Model = "StreetPower";
            eka.ModelYear = 2000;
            eka.Color = "Green";
            eka.GearType = "True";
            eka.Gear = "Shimano";
            Console.WriteLine("Bike 2 info");
            Console.WriteLine(eka.ToString());
            Boat toka = new Boat();
            toka.Name = "Buster";
            toka.Model = "XL";
            toka.ModelYear = 2015;
            toka.Color = "Black";
            toka.Seats = 5;
            toka.Type = "Motorboat";
            Console.WriteLine("Boat info");
            Console.WriteLine(toka.ToString());
            toka.Name = "Yamarin";
            toka.Model = "kissa";
            toka.ModelYear = 2015;
            toka.Color = "White";
            toka.Seats = 5;
            toka.Type = "Motorboat";
            Console.WriteLine("Boat 2 info");
            Console.WriteLine(toka.ToString());
        }
    }
}
