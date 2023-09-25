using SpotifyExemple_YetGenAkbank.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyExemple_YetGenAkbank.Services
{
    internal class NotepadService
    {
        public void WriteToNotepad(Playlist playlist)
        {
            //Saving to Notepad...

            string directory = $"{Directory.GetParent(Directory.GetCurrentDirectory()).Parent?.Parent?.FullName}\\Playlists";

            if (!File.Exists(directory))
                Directory.CreateDirectory(directory);

            string saveFile = Path.Combine(directory, $"{playlist.Id}txt");

            File.WriteAllText("saveFile", playlist.GetSongs());

            Console.WriteLine("Data successfully saved to Notepad");
        }
    }
}
