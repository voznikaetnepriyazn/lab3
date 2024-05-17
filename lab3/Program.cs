using lab3;

static void Main()
{
    var track1 = new Track("song1", TimeSpan.FromMinutes(3));
    var track2 = new Track("song2", TimeSpan.FromMinutes(5));
    var track3 = new Track("song3", TimeSpan.FromMinutes(2));
    var track4 = new Track("song4", TimeSpan.FromMinutes(2));

    var album1 = new Album(new List<Track> { track1, track2 });
    var album2 = new Album(new List<Track> { track3, track4 });

    var studio1 = new Studio(new List<Album> { album1, album2 });

    Console.WriteLine(studio1.DurationInAllAlbums);
}