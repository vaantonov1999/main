using System;
using System.Collections.Generic;
using System.Linq;

namespace Antonov_dz_.domain
{
    public class Song
    {
        public string Name { get; }
        public int ReleaseYear { get; }
        public List<string> Genres { get; }

        public List<Artist> Artists { get; }

        private Song()
        {
            this.Artists = new List<Artist>();
        }

        public Song(string Name, int ReleaseYear, params string[] genres) : this()
        {
            this.Name = Name;
            this.ReleaseYear = ReleaseYear;
            this.Genres = new List<string>(genres);
        }
        
        public Song(string Name, int ReleaseYear, List<string> Genres) : this()
        {
            this.Name = Name;
            this.ReleaseYear = ReleaseYear;
            this.Genres = Genres;
        }

        public void SetArtists(params Artist[] artists)
        {
            this.Artists.AddRange(artists);
        }

        public override string ToString()
        {
            if (Artists.Count > 0)
            {
                return String.Join(", ", Artists.Select(artist => artist.ToString()).ToArray()) + " - " + Name + " (" + ReleaseYear + ") [" + String.Join(", ", Genres.ToArray()) + "]";
            }
            else
            {
                return Name + " (" + ReleaseYear + ") [" + String.Join(", ", Genres.ToArray()) + "]";
            }
        }
    }
}