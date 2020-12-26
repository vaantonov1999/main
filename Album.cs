using System;
using System.Collections.Generic;
using System.Linq;

namespace Antonov_dz_.domain
{
    public class Album
    {
        public class SongCarriage : IComparable
        {
            public int TrackNumber { get; }
            public Song Song { get; }

            public SongCarriage(int TrackNumber, Song Song)
            {
                this.TrackNumber = TrackNumber;
                this.Song = Song;
            }

            public override string ToString()
            {
                return TrackNumber + ". " + Song.ToString();
            }
            
            public int CompareTo(object? obj)
            {
                SongCarriage sc = (SongCarriage) obj;

                if (sc.TrackNumber == this.TrackNumber) return 0;
                if (sc.TrackNumber > this.TrackNumber) return -1;
                if (sc.TrackNumber < this.TrackNumber) return 1;

                throw new Exception("Illegal point at comparison");
            }
        }
        
        public string Name { get; }
        public int ReleaseYear { get; }

        public List<SongCarriage> Songs { get; }

        private Album()
        {
            this.Songs = new List<SongCarriage>();
        }

        public Album(string Name, int ReleaseYear) : this()
        {
            this.Name = Name;
            this.ReleaseYear = ReleaseYear;
        }

        public void AddSong(int TrackNumber, Song Song)
        {
            Songs.Add(new SongCarriage(TrackNumber, Song));
            
            Songs.Sort(Comparer<SongCarriage>.Default);
        }

        public void AddAllSongs(params Song[] Songs)
        {
            for (int index = 1; index <= Songs.Length; index++)
            {
                AddSong(index, Songs[index]);
            }
        }

        public override string ToString()
        {
            return Name + " (" + ReleaseYear + ")" + " {" + String.Join(", ", Songs.Select(songCarriage => songCarriage.ToString()).ToArray()) + "}";
        }
    }
}