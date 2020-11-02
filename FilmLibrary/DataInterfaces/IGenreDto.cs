using System;

namespace DataInterfaces
{
    public interface IGenreDto
    {
        int GenreId { get; set; }
        string GenreName { get; set; }
        string GenreDesc { get; set; }
    }
}
