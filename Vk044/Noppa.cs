using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vko44
{
    class Noppa
    {
        public int Value { get; set; }
        public List<int> Throws = new List<int>();
        public Random rand = new Random();
        public void Throw (int amount)
        {
            for (int x = 0; x < amount; x++)
            {
                Value = rand.Next(1, 7);
                Throws.Add(Value);
            }
        }
        public void Print()
        {
            foreach (int i in Throws)
            {
                Console.WriteLine(i);
            }
        }
    }
}
