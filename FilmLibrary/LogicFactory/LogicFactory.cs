using LogicInterfaces;
using Logic;
using System;

namespace LogicFactory
{
    public static class LogicFactory
    {
        public static IFilm GetFilm()
        {
            return new Film();
        }

        public static IFilmCollection GetFilmCollection()
        {
            return new FilmCollection();
        }
    } 
}
