using DataInterfaces;
using System;

namespace DataInterfaces
{
    public class FilmDto 
    {
        public int FilmId { get; set; }
        public string FilmName { get; set; }
        public string FilmInformation { get; set; }
        public DateTime FilmReleaseDate { get; set; }
    }
}
