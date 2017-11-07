using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Vko44
{
   /* public struct Ohjastaja
    {
        public string Nimi;
        public int Startit;
        public int Voitot;
        public float VoittoPros;


    }*/
    class Program
    {
        /*static void LueOhjastajatVer2()
        {
            try
            {
                //luetaan CSV-tiedostosta tiedot ja tallennetaan structeihin
                string erotin = ";";
                //luetaan kaikki rivit muuttujaan
                string[] rivit = System.IO.File.ReadAllLines(@"D:\H9109\tilasto2017.csv");
                Ohjastaja kuski;
                int lkm = rivit.Length;
                Console.WriteLine("Ohjastajia yhteensä {0}", lkm - 1);
                //käydään muistiin luetut rivit läpi
                for (int i = 1; i < lkm; i++)
                {
                    string[] sanat = rivit[i].Split(erotin.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                    if (int.TryParse(sanat[2], out int apu))
                    {
                        kuski.Nimi = sanat[0] + " " + sanat[1];
                        kuski.Startit = int.Parse(sanat[2]);
                        kuski.Voitot = int.Parse(sanat[3]);
                        kuski.VoittoPros = (100F * kuski.Voitot / kuski.Startit);
                    }
                    else
                    {
                        kuski.Nimi = sanat[0] + " " + sanat[1] + " " + sanat[2];
                        kuski.Startit = int.Parse(sanat[2]);
                        kuski.Voitot = int.Parse(sanat[3]);
                        kuski.VoittoPros = (100F * kuski.Voitot / kuski.Startit);
                    }
                    //näytetään tulos
                    Console.WriteLine("{0}: {1} startit {2} voitot {3} voittoprosentti {4}",i,kuski.Nimi,kuski.Startit,kuski.Voitot,kuski.VoittoPros);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        static void LueOhjastajatVer1()
        {
            try
            {
                //luetaan tiedosto läpi rivi kerrallaan
                int counter = 0;
                string line;
                System.IO.StreamReader stream = new System.IO.StreamReader(@"D:\H9109\tilasto2017.txt");
                while ((line=stream.ReadLine()) != null)
                {
                    Console.WriteLine(counter + ":" + line);
                    counter++;
                }
                stream.Close();
            }
            catch (Exception)
            {
                throw;
            }
        }*/
        static void Main(string[] args)
        {
            /*
            try
             {
                 LueOhjastajatVer1();
             }
             catch (Exception ex)
             {
                 Console.WriteLine(ex.Message);
             }*/
            /*    Noppa noppa = new Noppa();
                Console.WriteLine("How many times you want to throw a dice?: ");
                int throwamount = int.Parse(Console.ReadLine());
                noppa.Throw(throwamount);
                noppa.Print();
                Console.WriteLine("Average: " + noppa.Throws.Average());
                for (int x = 1; x < 7; x++)
                {
                    int count = 0;
                    foreach (int i in noppa.Throws)
                    {
                        if ( i == x )
                        {
                            count++;
                        }
                    }
                    Console.WriteLine("{0} count is: {1}", x, count); 


                }*/
            /*  List<Product> Shoppingcart = new List<Product>();
              Shoppingcart.Add(new Product("Milk", 1.4));
              Shoppingcart.Add(new Product("Yoghurt", 0.8));
              Shoppingcart.Add(new Product("Juice", 2.5));
              Console.WriteLine("All products in collection: ");
              foreach(Product p in Shoppingcart)
              {
                  Console.WriteLine("-product: {0} {1}e",p.Name,p.Price);
              }
              */
            /*    try
                {
                    List<Fisher> Registry = new List<Fisher>();
                    Registry.Add(new Fisher("Kirsi Kernel", "020-12345678"));
                    Registry.Add(new Fisher("Ville Kalamies", "020-87654321"));
                    Registry[0].Catch.Add(new Fish("Barracuda", 200, 50, "Jyväsjärvi"));
                    Registry[0].Catch.Add(new Fish("Whale", 1000, 5000, "Lake Saimaa"));
                    Registry[1].Catch.Add(new Fish("Pike", 100, 5, "Päijänne"));
                    Registry[1].Catch.Add(new Fish("Monni", 1000, 500, "Ahvenlampi"));

                    foreach (Fisher f in Registry)
                    {
                        Console.WriteLine("Fisherman: {0} Phone: {1}", f.Name, f.PhoneNumber);
                        f.Catch.Sort((x, y) => y.Weight.CompareTo(x.Weight));
                        foreach (Fish r in f.Catch)
                        {

                            Console.WriteLine("-specie: {0}\n-length(cm): {1}\n-weight(kg): {2}\n-location: {3}", r.Species, r.Length, r.Weight, r.Location);

                        }
                    }


                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);

                }*/
          /*  try
            {
                List<Shape> shape = new List<Shape>();
                shape.Add(new Circle(1));
                shape.Add(new Circle(2));
                shape.Add(new Circle(3));
                shape.Add(new Rectangle(10, 20));
                shape.Add(new Rectangle(20, 30));
                shape.Add(new Rectangle(40, 50));
                foreach (var t in shape)
                {
                    Console.WriteLine(t);
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
               */
            try
            {
                double[] array = { 1.0, 2.0, 3.3, 5.5, 6.3, -4.5, 12.0 };
                Console.WriteLine("Sum = {0:00.00}", ArrayCalcs.Sum(array));
                Console.WriteLine("Avg = {0:00.00}", ArrayCalcs.Average(array));
                Console.WriteLine("Min = {0:00.00}", ArrayCalcs.Min(array));
                Console.WriteLine("Max = {0:00.00}", ArrayCalcs.Max(array));
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
	
	
	
    }
}
 