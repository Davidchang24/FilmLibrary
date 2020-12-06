using System;
using System.Collections.Generic;
using System.Text;
using DataInterfaces;
using DataFactory;

namespace Logic
{
    public class GenreCollection 
    {
        private List<Genre> _genres;

        public GenreCollection()
        {
            IGenreContext db = DataFactory.DataFactory.GetGenreContext();
            _genres = new List<Genre>();
            List<GenreDto> genreDtos = db.GetGenres();
            foreach (var genre in genreDtos)
            {
                _genres.Add(new Genre()
                {
                    GenreTitle = genre.GenreName,
                    GenreDesc = genre.GenreDesc,
                });
            }
        }

        public void AddGenre(Genre genre)
        {
            IGenreContext db = DataFactory.DataFactory.GetGenreContext();
            GenreDto genreDto = DataFactory.DataFactory.GetGenreDto();
            genreDto.GenreId = genre.GenreId;
            genreDto.GenreName = genre.GenreTitle;
            genreDto.GenreDesc = genre.GenreDesc;

            db.AddGenre(genreDto);
        }
        public void RemoveGenre(int genreId)
        {
            IGenreContext db = DataFactory.DataFactory.GetGenreContext();

            db.RemoveGenre(genreId);
        }

        public List<GenreDto> GetGenreByFilmId(int filmId)
        {
            IGenreContext db = DataFactory.DataFactory.GetGenreContext();
            List<GenreDto> genreDtos = db.GetGenreByFilmId(filmId);

            return genreDtos;
        }
        public IReadOnlyList<Genre> GetGenres()
        {
            return _genres;
        }
    }
}
