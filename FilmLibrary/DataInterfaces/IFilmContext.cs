using System;
using System.Collections.Generic;
using System.Text;

namespace DataInterfaces
{
    public interface IFilmContext
    {
        List<IFilmDto> GetFilms();
        void AddFilm(IFilmDto film);
        void DeleteFilm(int filmId);
        void EditFilm(string filmName, string filmInformation, string filmReleaseDate, int filmId);
    }
}
