using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



    namespace Lab04.cs
    {
        public class Vehicle
        {
            public string Name { get; set; }
            public string Model { get; set; }
            public int ModelYear { get; set; }
            public string Color { get; set; }


     
        }

        public class Bike : Vehicle
        {
            public string Gear { get; set; }
            public string GearType { get; set; }

            public override string ToString()
            {
                return "Name:" + Name + " " + "Model:" + Model + " " + "ModelYear: " + ModelYear + " " + "Gear: " + Gear + " " + "GearType: " + GearType;
            }
        }
        public class Boat : Vehicle
        {
            public string Type { get; set; }
            public int Seats { get; set; }
            public override string ToString()
            {
                

                    return "Name:" + Name + " " + "Model:" + Model + " " + "ModelYear: " + ModelYear + " " + "Type: " + Type + " " + "Seats: " + Seats;

                }
            }

        }
  
