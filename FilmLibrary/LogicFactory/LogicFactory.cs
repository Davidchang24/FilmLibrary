using LogicInterfaces;
using Logic;
using System;

namespace LogicFactory
{
    public static class LogicFactory
    {
        public static IFilm GetFilm(string filmName, string filmInformation, DateTime filmReleaseDate)
        {
            return new Film(filmName, filmInformation, filmReleaseDate);
        }
    }
}
