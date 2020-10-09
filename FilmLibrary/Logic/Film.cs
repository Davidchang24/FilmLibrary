using System;
using LogicInterfaces;

namespace Logic
{
    public class Film : IFilm
    {
        public string filmName { get; private set; }
        public string filmInformation { get; private set; }
        private DateTime filmReleaseDate { get; set; }

        public Film(string name, string information)
        {
            filmName = name;
            filmInformation = information;
        }
    }
}
