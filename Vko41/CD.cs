using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK_IT.MiniASIO
{
    class CD
    {
        //ominaisuudet
        public string Name { get; set; }
        public string Artist { get; set; }
        private List<Track> tracklist;
        //konstruktori
        public CD (string name, string artist)
        {
            Name = name;
            Artist = artist;
            tracklist = new List<Track>();
        }
        //metodit
        public void AddTrack (Track x)
        {
            tracklist.Add(x);
        }
        public override string ToString()
        {
            string retval = String.Format("CD data: \n-name: {0} \n-artist: {1} \n-tracks: ", Name, Artist);
            foreach (Track track in tracklist)
            {
                retval += String.Format("\n -{0}, {1}", track.TrackName, track.TrackTime);
            }
            return retval;
        }
    }
    class Track
    {
        //ominaisuudet
        public string TrackName { get; set; }
        public string TrackTime { get; set; }
        //konstruktori
        public Track (string trackname, string tracktime)
        {
            TrackName = trackname;
            TrackTime = tracktime;
        }
    }
}
