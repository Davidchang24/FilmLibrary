using System;
using System.Collections.Generic;
using System.Text;
using DataInterfaces;
using DataFactory;

namespace Logic
{
    public class FilmCollection 
    { 
        private List<Film> _films;

        public FilmCollection()
        {
            IFilmContext db = DataFactory.DataFactory.GetFilmContext();
            _films = new List<Film>();
            List<FilmDto> filmDtos = db.GetFilms();
            foreach (var film in filmDtos)
            {
                _films.Add(new Film()
                {
                    FilmId = film.FilmId,
                    FilmName = film.FilmName,
                    FilmInformation = film.FilmInformation,
                    FilmReleaseDate = film.FilmReleaseDate,
                });
            }
        }

        public void AddFilm(Film film)
        {
            IFilmContext db = DataFactory.DataFactory.GetFilmContext();
            FilmDto filmDto = DataFactory.DataFactory.GetFilmDto();

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

        public List<Film> GetFilmByDateNewToOld()
        {
            IFilmContext db = DataFactory.DataFactory.GetFilmContext();
            _films = new List<Film>();
            List<FilmDto> filmDtos = db.GetFilmsByDateNewToOld();
            foreach (var film in filmDtos)
            {
                _films.Add(new Film()
                {
                    FilmId = film.FilmId,
                    FilmName = film.FilmName,
                    FilmInformation = film.FilmInformation,
                    FilmReleaseDate = film.FilmReleaseDate,
                });
            }
            return _films;
        }
        public IReadOnlyList<Film> GetFilms()
        {
            return _films;
        }
    }
}
