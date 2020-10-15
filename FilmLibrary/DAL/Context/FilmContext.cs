using System;
using System.Collections.Generic;
using System.Text;
using DataInterfaces;

namespace DAL.Context
{
    public class FilmContext : IFilmContext
    {
        public List<IFilmDto> GetFilms()
        {
            string command = "";
            List<IFilmDto> films = new List<IFilmDto>();
            return films;
        }
    }
}
