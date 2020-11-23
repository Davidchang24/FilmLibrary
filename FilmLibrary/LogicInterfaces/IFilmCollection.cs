using System;
using System.Collections.Generic;

namespace LogicInterfaces
{
    public interface IFilmCollection
    {
        IReadOnlyList<IFilm> GetFilms();
        void AddFilm(IFilm film);
        void RemovieFilm(int filmId);
        void EditFilm();
    }
}
