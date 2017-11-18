using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team
{

   public static class Joukkue
    {
         public static List<Players> HaePelaajat()
        {
            List<Players> pelaajat = new List<Players>();
            Players player = new Players();
            player.Etunimi = "Urho";
            player.Sukunimi = "Vaakanainen";
            player.Kätisyys = "Vasen";
            player.Numero = 7;
            pelaajat.Add(player);
            Players player2 = new Players() {Etunimi = "Topi",Sukunimi = "Nättinen", Kätisyys = "Vasen", Numero = 59 };
            pelaajat.Add(player2);
            Players player3 = new Players() {Etunimi = "Brett", Sukunimi = "Carson", Kätisyys = "Oikea", Numero = 22};
            pelaajat.Add(player3);
            return pelaajat;
        }
    }

   public class Players
    {
        public string Etunimi { get; set; }
        public string Sukunimi { get; set; }
        public string Kätisyys { get; set; }
        public int Numero { get; set; }
    }
  
    
}
