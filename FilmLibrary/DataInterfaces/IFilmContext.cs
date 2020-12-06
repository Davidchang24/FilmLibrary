using System;
using System.Collections.Generic;
using System.Text;

namespace DataInterfaces
{
    public interface IFilmContext
    {
        List<FilmDto> GetFilms();
        void AddFilm(FilmDto film);
        void RemoveFilm(int filmId);
        void EditFilm(string filmName, string filmInformation, DateTime filmReleaseDate, int filmId);
        List<FilmDto> GetFilmsByDateNewToOld();
    }
}

