using System;
using System.Collections.Generic;
                                        
namespace DataInterfaces
{
    public interface IGenreContext
    {
        void AddGenre(GenreDto genre);
        void RemoveGenre(int genreId);
        List<GenreDto> GetGenres();
    }
}
