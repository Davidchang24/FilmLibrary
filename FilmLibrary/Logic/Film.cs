using System;
using LogicInterfaces;

namespace Logic
{
    public class Film : IFilm
    {
        public string filmName { get; private set; }
        public string filmInformation { get; private set; }
        public DateTime filmReleaseDate { get; private set; }

        public Film(string name, string information, DateTime releaseDate)
        {
            filmName = name;
            filmInformation = information;
            filmReleaseDate = releaseDate;
        }
    }
}
