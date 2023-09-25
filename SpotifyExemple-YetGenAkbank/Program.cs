using SpotifyExemple_YetGenAkbank.Entities;
using SpotifyExemple_YetGenAkbank.Services;

Console.WriteLine("Sqotify - Music for Noone");

string currentDirectory = Directory.GetParent(Directory.GetCurrentDirectory()).Parent?.Parent?.FullName;
Console.WriteLine();



var song1 = new Song("Requiem Kç 626", "W. A. Mozart", "Orchestre national de France", null);
var song2 = new Song("Sonata No.6 in F Major", "L. Beethoven", "Fazıl Say", "Warner Music");
var song3 = new Song("Sonata No.6 in F Major", "L. Beethoven", "Fazıl Say", "Warner Music");
var song4 = new Song("Sonata No.6 in F Major", "L. Beethoven", "Fazıl Say", "Warner Music");
var song5 = new Song("Sonata No.6 in F Major", "L. Beethoven", "Fazıl Say", "Warner Music");

var playlist1 = new Playlist(song1);
playlist1.AddSong(song2);
playlist1.AddSong(song3);
playlist1.AddSong(song4);
playlist1.AddSong(song5);

Console.WriteLine("Before Shuffle:");
Console.WriteLine(playlist1.GetSongs());

playlist1.ShuffleSongs();

Console.WriteLine(" \n \nAfter Suffle:");
Console.WriteLine(playlist1.GetSongs());

NotepadService notepadService = new();
notepadService.WriteToNotepad(playlist1);