using System;
using System.IO;
using System.Text.Json;
using Antonov_dz_.domain;

namespace Antonov_dz
{
    class TestDomainProgram
    {
        static void Main(string[] args)
        {
            Artist artist1 = new Artist("Ed", "Sheeran");
            Artist artist2 = new Artist("Camila", "cabello");

            Song song1 = new Song("South of the Border", 2019, "Pop", "Reggae");
            song1.SetArtists(artist1, artist2);

            Song song2 = new Song("Beautiful People", 2019, "Pop", "Reggae");
            song3.SetArtists(artist1);

            Song song3 = new Song("I Don`t Care", 2019, "Pop", "Reggae");
            song4.SetArtists(artist1);
            
            Album album = new Album("No.6 Collaboration Project", 2019);
            
            album.AddSong(3, song1);
            album.AddSong(1, song2);
            album.AddSong(8, song3);

            Console.WriteLine(artist1.ToString());
            Console.WriteLine(artist2.ToString());
            
            Console.WriteLine(song1.ToString());
            Console.WriteLine(song2.ToString());
            Console.WriteLine(song3.ToString());
            
            Console.WriteLine(album.ToString());

            File.WriteAllText("storage.json",JsonSerializer.Serialize(album));
        }
    }
}