using DataInterfaces;
using DAL.Dto;
using Logic;
using System;

namespace DataFactory
{
    public static class DataFactory
    {
        public static IFilmDto GetFilm()
        {
            return new FilmDto();
        }
    }
}
