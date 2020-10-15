using DataInterfaces;
using DAL.Dto;
using DAL.Context;

namespace DataFactory
{
    public static class DataFactory
    {
        public static IFilmContext GetFilmContext()
        {
            return new FilmContext();
        }
        public static IFilmDto GetFilm()
        {
            return new FilmDto();
        }
    }
}
