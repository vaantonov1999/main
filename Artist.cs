using System;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace Antonov_dz_.domain
{
    public class Artist
    {
        public string Name { get; }
        public string Surname { get; }

        public Artist(string Name, string Surname)
        {
            this.Name = Name;
            this.Surname = Surname;
        }
        public override string ToString()
        {
            return Name + " " + Surname;
        }
    }
}