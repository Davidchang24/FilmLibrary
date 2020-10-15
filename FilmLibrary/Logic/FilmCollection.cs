using System;
using System.Collections.Generic;
using System.Text;
using DataInterfaces;
using DataFactory;
using LogicInterfaces;

namespace Logic
{
    public class FilmCollection : IFilmCollection
    {
        private IFilmContext db;
        private List<IFilm> films;

        public void AddFilm(Film film)
        {

        }

        public void RemovieFilm(Film film)
        {

        }

        public FilmCollection(IFilmContext filmContext)
        {
            films = new List<IFilm>();
            db = filmContext;
            List<IFilmDto> filmDtos = db.GetFilms();
            foreach (var film in filmDtos)
            {
                films.Add(new Film(DataFactory.DataFactory.GetFilmContext())
                {
                    filmId = film.filmId,
                    filmName = film.filmName,
                    filmInformation = film.filmInformation,
                    filmReleaseDate = film.filmReleaseDate,
                });
            }
        }

        public List<IFilm> GetFilms()
        {
            return films;
        }
    }
}
