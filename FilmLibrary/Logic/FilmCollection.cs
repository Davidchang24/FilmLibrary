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
        private List<IFilm> films;

        public FilmCollection()
        {
            IFilmContext db = DataFactory.DataFactory.GetFilmContext();
            films = new List<IFilm>();
            List<IFilmDto> filmDtos = db.GetFilms();
            foreach (var film in filmDtos)
            {
                films.Add(new Film()
                {
                    FilmId = film.FilmId,
                    FilmName = film.FilmName,
                    FilmInformation = film.FilmInformation,
                    FilmReleaseDate = film.FilmReleaseDate,
                });
            }
        }

        public void AddFilm(IFilm film)
        {
            IFilmContext db = DataFactory.DataFactory.GetFilmContext();
            IFilmDto filmDto = DataFactory.DataFactory.GetFilmDto();

            filmDto.FilmId = film.FilmId;
            filmDto.FilmName = film.FilmName;
            filmDto.FilmInformation = film.FilmInformation;
            filmDto.FilmReleaseDate = film.FilmReleaseDate;

            db.AddFilm(filmDto);
        }

        public void RemovieFilm(int filmId)
        {
            IFilmContext db = DataFactory.DataFactory.GetFilmContext();
            db.RemoveFilm(filmId);
        }

        // TODO Should this function be in FilmCollection or just in Film
        public void EditFilm()
        {

        }

        public IReadOnlyList<IFilm> GetFilms()
        {
            return films;
        }
    }
}
