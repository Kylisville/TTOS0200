using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labrat
{
    class Televisio


    {
       
        public bool paalla { get; set; }
        public string kanava { get; set; }
        public string sisaantulo { get; set; }
        public int aanenvoimakkuus { get; set; }

        public Televisio()
        {

            aanenvoimakkuus = 50;
            kanava = String.Format("Nelonen");
            sisaantulo = String.Format("Antenni");
        }

        public override string ToString()
        {
           
  
            return String.Format("Televisio päällä: {0}\n Kanava: {1}\n Sisääntulo: {2}\n Äänenvoimakkuus: {3}\n", paalla, kanava, sisaantulo, aanenvoimakkuus);
            
            
        }
        public void Lisaanta()
        {
             aanenvoimakkuus += 1;

        }
        public void vahemmanaanta()
        {
             aanenvoimakkuus -= 1;

        }
    
    }

    

    class Telkkariohjelma
    {
        public static void telkkari()

        {

            Televisio samsung = new Televisio();
            int looppi = 1;
            while (looppi == 1)
            {
                Console.Clear();
                Console.WriteLine("Tervetuloa televisioon");
                Console.WriteLine(samsung.ToString());
                Console.WriteLine("Paina 1 käynnistääksesi/sammuttaaksesi television.");
                Console.WriteLine("Paina 2 valitaksesi sisääntulon.");
                Console.WriteLine("Paina 3 valitaksesi kanavan.");
                Console.WriteLine("Paina 4 valitaksesi äänenvoimakkuuden.");
                Console.WriteLine("Paina 0 poistuaksesi ohjelmasta.");
                Console.WriteLine("Paina 5 lisätäksesi ääntä");
                Console.WriteLine("Paina 6 vähentääksesi ääntä");
                int input = 0;
                int nro = new int();
                while (input == 0)
                {
                    string[] kanavat = { "TV1", "TV2", "MTV3", "Nelonen", "SubTV" };
                    string[] sisaantulot = { "HDMI", "SCART", "Antenni", "VGA", "Component Video" };
                    string nro2 = Console.ReadLine();
                    int valintanro;
                    bool testi = int.TryParse(nro2, out valintanro);
                    if (testi == true && valintanro < 7)
                    {
                        nro = valintanro;
                        input++;


                    }
                    Console.Clear();
                    switch(nro)
                    {
                        case 0:
                            looppi = 0;

                            break;


                        case 1:
                            if (samsung.paalla == false)
                            {

                                samsung.paalla = true;

                            }
                            else
                            {
                                samsung.paalla = false;

                            }

                            break;



                            case 2:
                            if (samsung.paalla == true)
                            {

                                Console.WriteLine("Valitse sisääntulo: ");
                                for (int i = 0; i < sisaantulot.Length; i++)
                                {
                                    int x = i + 1;
                                    Console.WriteLine(x + " " + sisaantulot[i]);

                                }
                                int inputit = int.Parse(Console.ReadLine()) - 1;
                                samsung.sisaantulo = sisaantulot[inputit];

                            }

                            else
                            {

                                Console.WriteLine("Sisääntuloa ei ole!");

                            }


                            break;
                        case 3:
                            if (samsung.paalla == true)
                            {

                                Console.WriteLine("Valitse kanava: ");
                                for (int i = 0; i < sisaantulot.Length; i++)
                                {
                                    int x = i + 1;
                                    Console.WriteLine(x + " " + kanavat[i]);

                                }
                                int kannu = int.Parse(Console.ReadLine()) - 1;
                                samsung.kanava = kanavat[kannu];

                            }

                            else
                            {

                                Console.WriteLine("Kanava ei ole saatavilla!");

                            }



                            break;
                        case 4:

                            if(samsung.paalla == true)
                            {
                                
                                Console.WriteLine("Anna äänenvoimakkuus 0-100: ");
                                samsung.aanenvoimakkuus = int.Parse(Console.ReadLine());
                                if (samsung.aanenvoimakkuus < 0 || samsung.aanenvoimakkuus > 100)
                                {

                                    Console.WriteLine("Äänenvoimakkuuden pitää olla 0-100");
                                    samsung.aanenvoimakkuus = int.Parse(Console.ReadLine());

                                }
                                else
                                {

                                    Console.WriteLine("Television täytyy olla päällä");


                                }
                               
                            }

                            break;

                        case 5:

                            samsung.Lisaanta();

                            break;

                        case 6:

                            samsung.vahemmanaanta();

                            break;

                    }

                }

            }


        }
    }
}