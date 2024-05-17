using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace lab3
{
    public class Album
    {
        public List<Track> Tracks { get; set; }

        public Album(List<Track> tracks)
        {
            Tracks = tracks ?? throw new ArgumentNullException(nameof(tracks));
        }

        public TimeSpan DurationInOneAlbum(List<Track> tracks)
        {
            TimeSpan AllDur = new TimeSpan(0);
            foreach (var track in tracks)
            {
                AllDur += track.Duration;
            }
            return AllDur;

        }

        internal TimeSpan DurationInOneAlbum()
        {
            throw new NotImplementedException();//означает функция еще не реализована, добавила чтобы реализовать его в методе класса Studio
        }
    }
}

