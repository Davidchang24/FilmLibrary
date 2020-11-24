using System;
using System.Collections.Generic;
using System.Text;
using DataInterfaces;
using DataFactory;
using LogicInterfaces;

namespace Logic
{
    public class GenreCollection : IGenreCollection
    {
        private List<IGenre> genres;

        public GenreCollection()
        {
            IGenreContext db = DataFactory.DataFactory.GetGenreContext();
            genres = new List<IGenre>();
            List<GenreDto> genreDtos = db.GetGenres();
            foreach (var genre in genreDtos)
            {
                genres.Add(new Genre()
                {
                    GenreTitle = genre.GenreTitle,
                    GenreDesc = genre.GenreDesc,
                });
            }
        }

        public void AddGenre(IGenre genre)
        {
            IGenreContext db = DataFactory.DataFactory.GetGenreContext();
            GenreDto genreDto = DataFactory.DataFactory.GetGenreDto();
            genreDto.GenreId = genre.GenreId;
            genreDto.GenreTitle = genre.GenreTitle;
            genreDto.GenreDesc = genre.GenreDesc;

            db.AddGenre(genreDto);
        }
        public void RenoveGenre(int genreId)
        {
            IGenreContext db = DataFactory.DataFactory.GetGenreContext();

            db.RemoveGenre(genreId);
        }
        public IReadOnlyList<IGenre> GetGenres()
        {
            return genres;
        }
    }
}
