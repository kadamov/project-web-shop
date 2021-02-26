using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MbmStore.Models
{
    public class MusicCD : Product
    {
        //fields
        public List<Track> Tracks { get; } = new List<Track>();
        //properties
        public string Artist { get; }
        public string Label { get; set; }
        public short Released { get; }

        //methods
        public void AddTrack(Track track)
        {
            Tracks.Add(track);
        }

        public TimeSpan GetPlayingTime()
        {

            var totalLength = new TimeSpan();
            foreach (var track in Tracks)
            {   
                totalLength += track.Length;
            }
            return totalLength;
        }

        public MusicCD()
        {

        }
        public MusicCD(string artist, string title, decimal price, short released) : base(title, price)
        {
            Artist = artist;
            Title = title;
            Price = price;
            Released = released;
        }
    }
}
