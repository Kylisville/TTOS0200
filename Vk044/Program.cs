﻿using System;
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
            Noppa noppa = new Noppa();
            noppa.Throw(1);
            noppa.Print();
        }
    }
}
