using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab05
{
    class Fridge
    {
        private bool Door { get; set; }
        private string DoorOpen
        {
            get
            {
                if (Door) { return "open"; }
                else { return "closed"; }
            }
        }
        private string Lights
        {
            get
            {
                if (Door)
                    return "lights are on";
                else
                    return "lights are off";
            }
        }
        public List<Items> FridgeContents;
        public Fridge()
        {
            FridgeContents = new List<Items>();
        }
        public void OpenDoor()
        {
            if (Door) { Door = false; }
            else { Door = true; }
        }
        public void AddItem(Items item)
        {
            FridgeContents.Add(item);
        }
        public override string ToString()
        {
            string retval = String.Format("Fridge is {0} and {1}. Fridge contents: ", DoorOpen, Lights);
            foreach(Items item in FridgeContents)
            {
                retval += "\n" + item.ToString();
            }
            return retval;
        }
    }
    public class Items
    {
        public string Name { get; set; }
        public Items(string name)
        {
            Name = name;
        }
        public override string ToString()
        {
            return String.Format("Item name: {0}", Name);
        }
    }
}
