using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labrat
{
    class Kiuas


    {
        //kentät
        public bool paalla { get; set; }
        public int lampotila { get; set; }
        public double kosteus { get; set; }
       

    }

        class Ohjelma
        {
            public static void Kiuas1()

            {

            Kiuas kiuasyksi = new Kiuas();
            int looppi = 1;

            while( looppi == 1)
            {
                Console.WriteLine("Saunaharjoitus");
                Console.WriteLine("Paina 1 käynnistääksesi/sammuttaaksesi saunan ");
                Console.WriteLine("Paina 2 asettaaksesi kosteuden");
                Console.WriteLine("Paina 3 asettaaksesi lämpötilan");
                Console.WriteLine("Paina 0 poistuaksesi");
                int input = 0;
                int valinta = new int();
                while(input == 0)
                {

                    string valinta2 = Console.ReadLine();
                    int valintanro;
                    bool testi = int.TryParse(valinta2, out valintanro);
                    if (testi == true && valintanro < 4)
                    {
                        valinta = valintanro;
                        input++;


                    }
                }
                Console.Clear();
                switch (valinta)
                {

                    case 0:
                        looppi = 0;
                        break;

                    case 1:
                        if (kiuasyksi.paalla == false)
                        {

                            kiuasyksi.paalla = true;
                            Console.WriteLine("Sauna päällä: {0}", kiuasyksi.paalla);

                        } else if (kiuasyksi.paalla == true)
                        {

                            kiuasyksi.paalla = false;
                            Console.WriteLine("Sauna päällä: {0}", kiuasyksi.paalla);
                            
                            
                        }
                        break;
                    case 2:
                        if (kiuasyksi.paalla == true)
                        {
                          
                            Console.WriteLine("Anna haluttu kosteustaso 0-100%: ");
                            
                                kiuasyksi.kosteus = int.Parse(Console.ReadLine());
                            if (kiuasyksi.kosteus <= 100)
                            {
                                Console.WriteLine("Saunan kosteustaso on nyt: {0}%", kiuasyksi.kosteus);
                            }
                            else
                            {
                                Console.WriteLine("Kosteuden on oltava välillä 0-100%");

                            }
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Saunan pitää olla ensin päällä!");
                        }
                        break;

                    case 3:
                        if (kiuasyksi.paalla == true)
                        {
                            Console.WriteLine("Syötä haluttu lämpötila: ");
                            kiuasyksi.lampotila = int.Parse(Console.ReadLine());
                            Console.WriteLine("Saunan lämpötila on nyt: {0} celsiusastetta", kiuasyksi.lampotila);

                        }
                        else
                        {
                            Console.WriteLine("Saunan pitää olla ensin päällä!");
                        }
                        break;
                }
            }

            }

        }

    }

