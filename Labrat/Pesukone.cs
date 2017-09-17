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

        public void PrintAll()
        {
            Console.WriteLine("Pesuohjelman lämpötila: {0}", lampotila);
            Console.WriteLine("Pesuohjelma: {0}", ohjelma);
            Console.WriteLine("Kierrosmäärä: {0}", kierrokset);
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

                Console.WriteLine("Tervetuloa pesukoneeseen!");
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
                                Console.WriteLine("Pesukone päällä: {0}", valinta.paalla);

                            }
                            else if (valinta.paalla == true)
                            {

                                valinta.paalla = false;
                                Console.WriteLine("Pesukone päällä: {0}", valinta.paalla);

                            }
                            break;
                        case 2:
                            if (valinta.paalla == true)
                            {

                                Console.WriteLine("Valitse pesulämpötila: 30, 40, 60, 90");
                                valinta.lampotila = int.Parse(Console.ReadLine());
                                if (valinta.lampotila == 30)
                                {
                                    Console.WriteLine("Pesulämpötilaksi valittu 30 astetta.");
                                }
                                else if (valinta.lampotila == 40)
                                {

                                    Console.WriteLine("Pesulämpötilaksi valittu 40 astetta.");

                                }
                                else if (valinta.lampotila == 60)
                                {
                                    Console.WriteLine("Pesulämpötilaksi valittu 30 astetta.");

                                }
                                else if (valinta.lampotila == 90)
                                {

                                    Console.WriteLine("Pesulämpötilaksi valittu 90 astetta.");

                                }
                                else
                                {

                                    Console.WriteLine("Haluamaasi lämpötilaa ei ole saatavilla");

                                }

                            }
                            else
                            {
                                Console.WriteLine("Pesukoneen pitää olla ensin päällä!");
                            }

                            break;
                        case 3:
                            if (valinta.paalla == true)
                            {

                                Console.WriteLine("Valitse pesuohjelma: ", pesuohjelmat);
                                valinta.ohjelma = (Console.ReadLine());
 
                                    }
                            break;
                    }

                                {


                                }
                            }
                        
                           
                    }
                    
                }


            }

        }
    
