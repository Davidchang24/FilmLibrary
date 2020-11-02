using System;
using System.Collections.Generic;
                                        
namespace DataInterfaces
{
    public interface IGenreContext
    {
        void AddGenre(IGenreDto genre);
        void RemoveGenre(int genreId);
        List<IGenreDto> GetGenres();
    }
}
