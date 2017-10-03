
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04

{
    class Item
    {
       
        public string Name { get; set; }
        public int Amount { get; set; } 
        public int Price { get; set; }
    }
    class Cd : Item
    {
        
        public int TrackAmount { get; set; }
        
        
        public Cd(string name, int amount, int price, int trackamount)
        {
            Name = name;
            Amount = amount;
            Price = price;
            TrackAmount = trackamount;
        }
        
        public override string ToString()
        {
            return "Name: " + Name + ", Amount: " + Amount + ", Price: " + Price + ", Track amount: " + TrackAmount;
        }
    }
    class Book : Item
    {
        
        public int PageCount { get; set; }
        
        
        public Book(string name, int amount, int price, int pagecount)
        {
            Name = name;
            Amount = amount;
            Price = price;
            PageCount = pagecount;
        }
        
        public override string ToString()
        {
            return "Name: " + Name + ", Amount: " + Amount + ", Price: " + Price + ", Page count: " + PageCount;
        }
    }
    
    class Phone : Item
    {

        public string Os { get; set; }
        public string Manufacturer { get; set; }
        public string Model { get; set; }

        
        public Phone(string name, int amount, int price, string os, string manufacturer, string model)
        {
            Name = name;
            Amount = amount;
            Price = price;
            Os = os;
            Manufacturer = manufacturer;
            Model = model;


        }
        public override string ToString()
        {
            return "Name: " + Name + ", Amount: " + Amount + ", Price: " + Price + ", Operating system: " + Os + ", Manufacturer: " + Manufacturer + ", Model: " + Model;
        }

    }


}