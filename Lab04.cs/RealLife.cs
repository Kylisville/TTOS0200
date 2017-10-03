using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04
{
    class Hobbies
    {


        public string Name { get; set; }
        public int Years { get; set; }

    }

    class Music : Hobbies
    {
        public string Genre { get; set; }
        
        public Music(string name, int years, string genre)
        {
            Name = name;
            Years = years;
            Genre = genre;


        }
        public override string ToString()
        {
            return "Name: " + Name + ", Years: " + Years + ", Genre: " + Genre;
        }
    }

    class Games : Hobbies
    {
        public string Multiplayer { get; set; }
        public string Singleplayer { get; set; }
        public string Genre { get; set; }


        public Games(string name, int years, string multiplayer, string singleplayer, string genre)
        {

            Name = name;
            Years = years;
            Multiplayer = multiplayer;
            Singleplayer = singleplayer;
            Genre = genre;

        }
        public override string ToString()
        {
            return "Name: " + Name + ", Years: " + Years + ", Multiplayer: " + Multiplayer + ", Singleplayer: " + Singleplayer + ", Genre: " + Genre;
        }
    }


    class Gym : Hobbies
    {
        public int Sets { get; set; }
        public int Max { get; set; }
        public string Exercise { get; set; }

        public Gym(string name, int years, string exercise, int sets, int max)

        {
            Name = name;
            Years = years;
            Sets = sets;
            Max = max;
            Exercise = exercise;


        }
        public override string ToString()
        {
            return "Name: " + Name + ", Years: " + Years + ", Exercise: "+ Exercise + ", Sets: " + Sets + ", Max: " + Max;
        }

    }

}