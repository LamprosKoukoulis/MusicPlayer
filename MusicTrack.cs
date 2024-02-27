using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayerApp
{
    public class MusicTrack
    {
        public string title { get; set; }
        public string artist { get; set; }
        public int? year { get; set; }
        public string genre { get; set; }
        public string language { get; set; }
        public string path { get; set; }
        public TimeSpan duration { get; set; }
        public int count = 0;
        public MusicTrack(string title, string artist, int? year, string genre, string language, string path)//, TimeSpan duration)
        {
            this.title = title;
            this.artist = artist;
            this.year = year;
            this.genre = genre;
            this.language = language;
            this.path = path;
            //this.duration = duration;
        }

        public MusicTrack()
        {
            title = "None";
            artist = "None";
            genre = "DeafultGenre";
            language = "language";
            //Image = image;
        }

    }


}

