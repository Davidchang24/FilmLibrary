using System;
using Logic;
using LogicInterfaces;

namespace FilmLibraryView
{
    class Program
    {
        private static void Main(string[] args)
        {
            IFilm inception = LogicFactory.FilmFactory.GetFilm("Inception", "cool chris nolan film");
            Console.WriteLine(inception.filmName + " " + inception.filmInformation);
        }
    }
}
