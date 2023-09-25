using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyExemple_YetGenAkbank.Entities
{
    internal class Playlist
    {
        public Guid Id { get; set; }    
        private List<Song> Songs { get; set; }

        private Random random;
        
        public Playlist(Song firstSong)
        {
            Id = Guid.NewGuid();    
            Songs = new List<Song>();
            random = new();
            AddSong(firstSong);
        }
        public void AddSong(Song song)
        {
            if (song != null)
                Songs.Add(song);
        }
        public string GetSongs()
        {
            return string.Join(" \n", Songs.Select(song =>$"{ song.Title} - {song.Composer}"));
        }
        //public void ShowSongs()
        //{
        //    foreach (Song song in Songs)
        //    {
        //        Console.WriteLine($"Title: {song.Title} - {song.Composer}");
        //    }
        //}
        public void ShuffleSongs() // Baştan sona doğru olan şarkıları değiştirir.
        {
            int n = Songs.Count;
            while (n > 0)
            {
                n--;

                Song song = Songs[n];    
                int randomIndex = random.Next(n);
                Song swapSong = Songs[randomIndex];
                Songs[n] = Songs[randomIndex];
                Songs[randomIndex] = song;
            }
        }

    }
}
