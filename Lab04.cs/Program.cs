using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04
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
            Console.WriteLine(yksi.ToString(), "\n");
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
            Console.WriteLine(toka.ToString());*/
            /*Radio philips = new Radio();
            int looppi = 1;
            while (looppi == 1)
            {
                Console.WriteLine("Tervetuloa radioon!");
                
                Console.WriteLine("Paina 1 käynnistääksesi radion.");
                Console.WriteLine("Paina 2 asettaaksesi taajuuden (2KHz - 26KHz)");
                Console.WriteLine("Paina 3 asettaaksesi äänenvoimakkuuden (0-9)");
                Console.WriteLine("Paina 0 poistuaksesi ohjelmasta.");

                Asetukset asetus = new Asetukset();

                int asetukset = new int();
                int input = 0;
                while (input == 0)
                {

                    string valinta2 = Console.ReadLine();
                    int valintanro;
                    bool testi = int.TryParse(valinta2, out valintanro);
                    if (testi == true && valintanro < 4)
                    {
                        asetukset = valintanro;
                        input++;


                    }
                }
                Console.Clear();
                switch (asetukset)
                {
                    case 0:
                        looppi = 0;
                        break;

                    case 1:

                        if (asetus.paalla == false)
                        {

                            asetus.paalla = true;
                            Console.WriteLine("Radio päällä: {0}", asetus.paalla);

                        }
                        else if (asetus.paalla == true)

                        {
                            asetus.paalla = false;
                            Console.WriteLine("Radio päällä: {0}", asetus.paalla);
                        }

                        break;
                    case 2:
                        if (asetus.paalla == true)
                        {
                            asetus.Taajuus = int.Parse(Console.ReadLine());
                        }

                        else
                        {

                            Console.WriteLine("Radion on oltava päällä!");
                        }
                        break;

                    case 3:
                        asetus.Aani = int.Parse(Console.ReadLine());

                        break;

                }
            }
            
                    case 2:

                        if (asetus.paalla == true)
                        {
                            Console.WriteLine("Syötä taajuus:");
                            philips.Taajuus = int.Parse(Console.ReadLine());
                            Console.WriteLine("Taajuudeksi asetettu: {0}", philips.Taajuus);

                        }else
                        {

                            Console.WriteLine("Radion on oltava päällä!");
                            break;
                        }

                        break;

                }
            }
            
            */
            Radio2 mankka = new Radio2();


            {
                Console.WriteLine("Tervetuloa radioon.");
                Console.WriteLine("Paina 1 kytkeäksesi radion päälle");

                int luku = int.Parse(Console.ReadLine());
                if (luku == 1)
                {
                    mankka.Paalla = true;
                    Console.WriteLine("Radio päällä");

                }
                else
                {
                    Console.WriteLine("Kytke radio päälle painamalla 1");
                }

                if (mankka.Paalla == true)
                {

                    Console.WriteLine("Syötä taajuus (2KHz-26KHz) ");
                    mankka.Taajuus = int.Parse(Console.ReadLine());

                }
                if (mankka.Paalla == true)
                {
                    Console.WriteLine("Syötä Äänenvoimakkuus (0-9) ");

                    mankka.Aani = int.Parse(Console.ReadLine());

                }
                Console.WriteLine(mankka.ToString());


            }

             /*
    

             Cd PFloyd = new Cd("Pink Floyd: The Dark Side of The Moon", 1, 40, 10);
             Book Rambo = new Book("Rambo: First Blood", 3, 15, 252);
             Phone OPO = new Phone("OnePlus", 2, 400, "OxygenOS", "OnePlus","3T");
             Console.WriteLine("Bookcase inventory: ");
             Console.WriteLine(PFloyd.ToString());
             Console.WriteLine(Rambo.ToString());
             Console.WriteLine(OPO.ToString());

            Music Lemmy = new Music("Motörhead", 5, "Rock and Roll");
            Games Pubg = new Games("Playerunknown's Battlegrounds", 1, " Yes ", "No", "Battle Royale");
            Gym Puntti = new Gym("Mörkösali", 25, "Deadlift", 15, 350);
            Console.WriteLine("Hobbies: ");
            Console.WriteLine(Lemmy.ToString());
            Console.WriteLine(Pubg.ToString());
            Console.WriteLine(Puntti.ToString());
            */
        }
    }
}
