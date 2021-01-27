﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShazamExample1
{
    enum ReleaseType
        { 
        Single,
        MaxiSingle,
        EP,
        Album
         }

    enum Genre
    {
        Country,
        Rap,
        Rock,
        EDM
    }

    class Release
    {
        public DateTime ReleaseDate;
        public string ReleaseTitle;
        public ReleaseType thisReleaseType;
        public Genre thisGenre;
        public Artist thisArtist;
        public List<Song> SongsInRelease;

        public Release()
        {
            Console.WriteLine("Release Created.");
            SongsInRelease = new List<Song>();
        }
    }
}
