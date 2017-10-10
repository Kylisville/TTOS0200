using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

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
         /*Fridge Rosenlew = new Fridge();
         Console.WriteLine(Rosenlew.ToString());
         Rosenlew.OpenDoor();
         Items one = new Items("Beer");
         Items two = new Items("Valio maitorahka");
         Rosenlew.AddItem(one);
         Rosenlew.AddItem(two);
         Console.WriteLine(Rosenlew.ToString());
         */
         /*
            StreamReader tiedot = new StreamReader("E:/Users/kissa.txt");
            
         Seura Saipa = new Seura("SaiPa","Lappeenranta\n");

            Saipa.Pelaajat.Add(new Pelaaja("Jussi ", "Markkanen ", "Maalivahti ", "Vasen"));
             Saipa.Pelaajat.Add(new Pelaaja("Cody ", "Kunyk ", "Keskushyökkääjä ", "Vasen"));
             Saipa.Pelaajat.Add(new Pelaaja("Ahti ", "Oksanen ", "Vasen laitahyökkääjä ", "Vasen"));
            Console.WriteLine(Saipa.ToString());
            Saipa.Tiedostoon();
            */

            /*
              Aikuinen Ville = new Aikuinen("Ville", 22, 90, 182, "Volvo");
              Vauva Baby = new Vauva("Vauveli", 1, 6, 70, "Pampers");
              Console.WriteLine(Ville.ToString());
              Console.WriteLine(Baby.ToString());
              Ville.Kasva();
              Ville.Move();
              Baby.Move();
              Baby.Kasva();
              Console.WriteLine(Ville.ToString());
              Console.WriteLine(Baby.ToString());
              */
            Person Henkilo = new Person("Ville");
            
            Wallet Lompakko = new Wallet("Leather wallet", 50, "VISA, S-Etukortti");
            Console.WriteLine(Henkilo.ToString());
            Console.WriteLine(Lompakko.ToString());
            Lompakko.AddMoney();
             Lompakko.Contents.Add(new Wallet("Kors", 200, "Driving License"));
            Console.WriteLine(Lompakko.ToString());
            






        }
    }
}
