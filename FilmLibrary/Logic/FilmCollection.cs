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

        public FilmCollection(IFilmContext filmContext)
        {
            films = new List<IFilm>();
            db = filmContext;
            List<IFilmDto> filmDtos = db.GetFilms();
            foreach (var film in filmDtos)
            {
                films.Add(new Film(DataFactory.Factory.GetFilmContext())
                {
                    filmId = film.FilmId,
                    filmName = film.FilmName,
                    filmInformation = film.FilmInformation,
                    filmReleaseDate = film.FilmReleaseDate,
                });
            }
        }

        public void AddFilm(IFilm film)
        {
            IFilmDto filmDto = DataFactory.Factory.GetFilm();
            filmDto.FilmId = film.filmId;
            filmDto.FilmName = film.filmName;
            filmDto.FilmInformation = film.filmInformation;
            filmDto.FilmReleaseDate = film.filmReleaseDate;

            db.AddFilm(filmDto);
        }
        // TODO Should this function be in FilmCollection or just in Film
        public void RemovieFilm()
        {

        }
        // TODO Should this function be in FilmCollection or just in Film
        public void EditMovie()
        {

        }

        public List<IFilm> GetFilms()
        {
            return films;
        }
    }
}
