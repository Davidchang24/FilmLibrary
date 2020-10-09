using LogicInterfaces;
using Logic;

namespace LogicFactory
{
    public static class FilmFactory
    {
        public static IFilm GetFilm(string filmName, string filmInformation)
        {
            return new Film(filmName, filmInformation);
        }
    }
}
