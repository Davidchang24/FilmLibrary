using System;
using Logic;
using LogicInterfaces;

namespace FilmLibraryView
{
    class Program
    {
        public static void Main(string[] args)
        {
            ViewTest.Film filmpje = new ViewTest.Film();

            IFilmCollection filmCollection = LogicFactory.LogicFactory.GetFilmCollection();
            IFilm film = LogicFactory.LogicFactory.GetFilm();
            film.FilmId = 0;
            film.FilmName = "Kongfu Panda";
            film.FilmInformation = "Cool animation movie";
            film.FilmReleaseDate = "09-07-2008";
            filmCollection.AddFilm(film);
        }
    }
}
