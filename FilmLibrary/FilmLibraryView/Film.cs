using System;
using Logic;
using LogicInterfaces;

namespace ViewTest
{
    public class Film
    {
        private IFilmCollection filmCollection;
        public Film()
        {
            filmCollection = LogicFactory.ViewFactory.GetFilmCollection();
            foreach (var films in filmCollection.GetFilms())
            {
                Console.WriteLine(films.filmName);
            }
        }
    }
}
