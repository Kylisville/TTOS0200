using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labrat
{
    class Pesukone


    {

        public bool paalla { get; set; }
        public int lampotila { get; set; }
        public string ohjelma { get; set; }
        public int kierrokset { get; set; }

        

        public override string ToString()
        {
            return String.Format("Pesukone päällä: {0}\n Lämpötila: {1}\n Ohjelma: {2}\n Kierrokset: {3}\n", paalla, lampotila, ohjelma, kierrokset);
        }

    }
    class Pesuohjelma

    {

        public static void Pesukone()

        {
            Pesukone valinta = new Pesukone();
            int looppi = 1;

            while (looppi == 1)
            {
                Console.Clear();
                Console.WriteLine("Tervetuloa pesukoneeseen!");
                Console.WriteLine(valinta.ToString());
                Console.WriteLine("Paina 1 käynnistääksesi/sammuttaaksesi pesukoneen.");
                Console.WriteLine("Paina 2 asettaaksesi pesulämpötilan.");
                Console.WriteLine("Paina 3 valitaksesi pesuohjelman.");
                Console.WriteLine("Paina 4 valitaksesi kierrosnopeuden.");
                Console.WriteLine("Paina 0 poistuaksesi ohjelmasta.");
                int input = 0;
                int nro = new int();
                while (input == 0)
                {
                    string[] pesuohjelmat = { "hienopesu", "puuvilla", "valkopesu", "pikapesu", "tekokuidut" };
                    string nro2 = Console.ReadLine();
                    int valintanro;
                    bool testi = int.TryParse(nro2, out valintanro);
                    if (testi == true && valintanro < 5)
                    {
                        nro = valintanro;
                        input++;


                    }
                    Console.Clear();
                    switch (nro)
                    {
                        case 0:
                            looppi = 0;
                            break;
                        case 1:
                            if (valinta.paalla == false)
                            {

                                valinta.paalla = true;
                               

                            }
                      
              
                            break;
                        case 2:
                            if (valinta.paalla == true)
                            {

                                Console.WriteLine("Valitse pesulämpötila: 30, 40, 60, 90");
                                valinta.lampotila = int.Parse(Console.ReadLine());

                            }
                            else
                            {
                                Console.WriteLine("laita pesukone eka päälle");

                            }
                  
                            break;
                        case 3:
                            if (valinta.paalla == true)
                            {

                                Console.WriteLine("Valitse pesuohjelma: ");
                                for (int i = 0; i < pesuohjelmat.Length; i++)
                                {
                                    int x = i + 1;
                                    Console.WriteLine(x + " " + pesuohjelmat[i]);
                                        
                                }
                                int pesuohjelma = int.Parse(Console.ReadLine())-1;
                                valinta.ohjelma = pesuohjelmat[pesuohjelma];
                                
                            }

                            else
                            {

                                Console.WriteLine("Pesuohjelmaa ei ole listalla!");

                            }
                            break;
                        case 4:
                            if (valinta.paalla == true)
                            {

                                Console.WriteLine("Anna kierrosmäärä: ");
                                valinta.kierrokset = int.Parse(Console.ReadLine());
                            }

                            else
                            {
                                Console.WriteLine("Laita pesukone ensin päälle.");
                            }
                            break;
                    }
                           
                    }
                    

                }

                    {


                    }
                }


            }

        }

