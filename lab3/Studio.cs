using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace lab3
{
    public class Studio
    {
        public List<Album> Albums { get; set; }
        public Studio(List<Album> albums)//проверить список альбомов на null
        {
            Albums = albums ?? throw new ArgumentNullException(nameof(albums));
            this.Albums = albums ?? throw new ArgumentNullException(nameof(albums));
            foreach (var album in Albums) 
            { 
                if (album ==null) throw new ArgumentNullException(nameof(album));
            }
        }

        public TimeSpan DurationInAllAlbums(List<Album> Albums)
        {
            TimeSpan AllDur1 = new TimeSpan(0);
            foreach (var album in Albums)
            {
                AllDur1 += album.DurationInOneAlbum();
            }
            return AllDur1;
            Console.WriteLine($"Суммарная продолжительность треков: {AllDur1}"); 

        }
    }
}