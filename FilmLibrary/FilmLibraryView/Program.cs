using System;
using Logic;
using LogicInterfaces;

namespace FilmLibraryView
{
    class Program
    {
        private static void Main(string[] args)
        {
            IFilm inception = LogicFactory.LogicFactory.GetFilm("Inception", "cool chris nolan film", DateTime.Now);
            Console.WriteLine(inception.filmName + " " + inception.filmInformation + " " + inception.filmReleaseDate);
        }
    }
}
