using System;
using Logic;
using LogicInterfaces;

namespace ViewTest
{
    public class Film
    {
        public Film()
        { 
            IFilmCollection filmCollection = LogicFactory.LogicFactory.GetFilmCollection();
            foreach (var films in filmCollection.GetFilms())
            {
                Console.WriteLine(films.FilmName + ": " + films.FilmInformation + " Released in:" + films.FilmReleaseDate);
            }
        }
    }
}
