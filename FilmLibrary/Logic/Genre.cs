using System;
using System.Collections.Generic;
using System.Text;
using LogicInterfaces;
using DataInterfaces;

namespace Logic
{
    public class Genre : IGenre
    {
        private IGenreContext db;
        public int GenreId { get; set; }
        public string GenreTitle { get; set; }
        public string GenreDesc { get; set; }

        public Genre()
        {
             
        }
    }
}
