using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace lab3
{
    public class Studio
    {
        public List<Album> Albums { get; set; }
        public Studio(List<Album> albums)
        {
            Albums = albums ?? throw new ArgumentNullException(nameof(albums));
        }

        public TimeSpan DurationInAllAlbums(List<Album> Albums)//в самом названии метода вылезает ошибка, пишет "не все пути к коду возвращают значение"
        {
            TimeSpan AllDur1 = new TimeSpan(0);
            foreach (var album in Albums)
            {
                AllDur1 += album.DurationInOneAlbum();
            }
            Console.WriteLine($"Суммарная продолжительность треков: {AllDur1}"); 

        }
    }
}