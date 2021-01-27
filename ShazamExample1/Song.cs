using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShazamExample1
{
    class Song
    {
        private string _SongTitle;
        private Artist _Artist;
        private float _duration;

        public string SongTitle { get => _SongTitle; set => _SongTitle = value; }
        public float Duration { get => _duration; set => _duration = value; }
        internal Artist Artist { get => _Artist; set => _Artist = value; }
    }
}
