using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab05
{
    abstract class Nisakas
    {
        public int Ika { get; set; }

        public abstract void Move();
    }
     class Ihminen : Nisakas
    {
        public int Paino { get; set; }
        public int Pituus { get; set; }
        public string Nimi { get; set; }
        public override void Move()
        {
            Console.WriteLine("liikun");
        }
        public void Kasva()
        {
            Ika += 1;
            Console.WriteLine("Kasvoin: {0}",Ika);
        }

    }
    class Vauva : Ihminen
    {
        public string Vaippa { get; set; }
        public Vauva(string nimi, int ika, int paino, int pituus, string vaippa)
        {

            Nimi = nimi;
            Ika = ika;
            Paino = paino;
            Pituus = pituus;
            Vaippa = vaippa;
        }
        public override void Move()
        {
            Console.WriteLine("Konttaan");

        }
        public override string ToString()
        {
            return String.Format("Nimeni on: {0}, Ikäni on: {1}, Painoni on: {2}, Pituuteni on: {3}, Vaippani on: {4}",Nimi,Ika,Paino,Pituus,Vaippa);
        }
    }
    class Aikuinen : Ihminen
    {
        public string Auto { get; set; }
        
        public Aikuinen(string nimi, int ika, int paino, int pituus, string auto)
        {

            Nimi = nimi;
            Ika = ika;
            Paino = paino;
            Pituus = pituus;
            Auto = auto;
        }
        public override void Move()
        {
            Console.WriteLine("Kävelen");
        }
        public override string ToString()
        {
            return String.Format("Nimeni on: {0}, Ikäni on: {1}, Painoni on: {2}, Pituuteni on: {3}, Autoni on: {4}", Nimi, Ika, Paino, Pituus, Auto);
        }
    }
}
