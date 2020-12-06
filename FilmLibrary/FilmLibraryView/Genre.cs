using System;
using System.Collections.Generic;
using System.Text;
using Logic;

namespace ViewTest
{
    class Genre
    {
        public Genre()
        {
            GenreCollection GenreCollection = new GenreCollection();

            foreach(var genre in GenreCollection.GetGenreByFilmId(2))
            {
                Console.WriteLine(genre.GenreName);
            }
        }
    }
}
