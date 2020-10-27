using System;
using System.Collections.Generic;

namespace LogicInterfaces
{
    public interface IFilmCollection
    {
        List<IFilm> GetFilms();
        void AddFilm(IFilm film);
        void RemovieFilm();
        void EditMovie();
    }
}
