using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab05
{
     public class Wallet
    {
        public string Type { get; set; }
        public int GotMoney { get; set; }
        public string Cards { get; set; }
        
        public Wallet(string type, int gotmoney, string cards)
        {
            Cards = cards;
            GotMoney = gotmoney;
            Type = type;
            
            
        }
        public void AddMoney()
        {

            GotMoney += 20;
        }
        public override string ToString()
        {
            return String.Format("My wallet: {0}, My cash: {1}, My cards: {2}",Type, GotMoney, Cards);
        }
   
    }
    
     public class Person
    {
       public string Name { get; set; }
        public List<Wallet> Contents;
        public Person(string name)
        {
            Contents = new List<Wallet>();
            Name = name;
        }
        public override string ToString()
        {
            return String.Format("Name: {0}",Name);
        }
       

    }
}