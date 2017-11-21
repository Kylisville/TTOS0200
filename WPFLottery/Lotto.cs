using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFLottery
{
    public abstract class Lottery
    {
        public abstract string Name { get; }
        public Random rng = new Random();
        public List<int> Numbers = new List<int>();
        public abstract void Generate();
        
        public string LineToString()
        {
            string s = "";
            foreach (int i in Numbers)
            {
                s += i.ToString() + " ";
            }
            s += "\n";
            return s;
    }
        }
        public class Lotto : Lottery
        {
            public override string Name { get { return "Lotto"; } }
            public override void Generate()
            {
                bool draw = false;
                for (int t = 0; t <= 7;)
                {
                    while (!draw)
                    {
                        int number = rng.Next(1, 40 + 1);
                        if(!Numbers.Contains(number))
                        {
                            Numbers.Add(number);
                            t++;
                        }
                        if (t == 7)
                        {
                            draw = true;
                        }
                    }
                    if (draw)
                    {
                        t++;
                    }
                }
            }
            public override string ToString()
            {
                return Name;
        }
            }
        public class Vikinglotto : Lottery
        {
            public override string Name { get { return "Vikinglotto"; } }
            public override void Generate()
            {
                bool draw = false;
                for (int t = 0; t <= 6;)
                {
                    while (!draw)
                    {
                        int number = rng.Next(1, 48 + 1);
                        if (!Numbers.Contains(number))
                        {
                            Numbers.Add(number);
                            t++;
                        }
                        if (t == 6)
                        {
                            draw = true;
                        }
                    }
                    if (draw)
                    {
                        t++;
                    }
                }
            }
            public override string ToString()
            {
                return Name;
            }
        }
        public class Eurojackpot : Lottery
        {
            public override string Name { get { return "Eurojackpot"; } }
         public override void Generate()
         {
             //generate extra numbers
            int extra1 = rng.Next(1, 11);
            int extra2;
            do
            {
                extra2 = rng.Next(1, 11);
            } while (extra2 == extra1);
               //generate Eurojackpot numbers
             bool draw = false; 
                for (int t = 0; t <= 5;)
                {
                    while (!draw)
                    {
                        int number = rng.Next(1, 50 + 1);
                        if (!Numbers.Contains(number))
                        {
                            Numbers.Add(number);
                            t++;
                        }
                        if (t == 5)
                        {
                        Numbers.Add(extra1);
                        Numbers.Add(extra2);
                        draw = true;
                        }
                    }
                    if (draw)
                    {
                        t++;
                    }
                }
       } 
            public override string ToString()
            {
                return Name;
            }
    }
}
