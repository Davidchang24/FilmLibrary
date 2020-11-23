using System;

namespace DataInterfaces
{
    public interface IGenreDto
    {
        int GenreId { get; set; }
        string GenreTitle { get; set; }
        string GenreDesc { get; set; }
    }
}
