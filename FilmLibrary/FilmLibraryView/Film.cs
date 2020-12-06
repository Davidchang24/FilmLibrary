using System;
using Logic;

namespace ViewTest
{
    public class Film
    {
        public Film()
        {
            FilmCollection filmCollection = new FilmCollection();
            foreach (var film in filmCollection.GetFilmByDateNewToOld())
            {
                Console.WriteLine(film.FilmName + film.FilmInformation + film.FilmReleaseDate);
            }
        }
    }
}
