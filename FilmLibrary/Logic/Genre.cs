using System;
using System.Collections.Generic;
using System.Text;
using DataInterfaces;

namespace Logic
{
    public class Genre 
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
