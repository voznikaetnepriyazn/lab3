using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    public class Track
    {
        public string Name { get; set; }
        public TimeSpan Duration { get; set; }

        public Track(string name, TimeSpan duration) 
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Duration = duration;
        }
    }
}
